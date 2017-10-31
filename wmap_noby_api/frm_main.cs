using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace wmap_noby_api
{
    public partial class frm_main : Form
    {
        sql_source sql = new sql_source();
        cls_mysql_connect mysql_con = new cls_mysql_connect();
        static string constr_wmapst;

        public frm_main()
        {
            InitializeComponent();
            constr_wmapst = cls_connect_string.constr_wmapst;
        }

        //投稿ボタン
        private void btn_push_Click(object sender, EventArgs e)
        {
            if (txt_post.Text.Replace("\n","") == "")
            {
                MessageBox.Show("テキストを入力してください。");
                return;
            }

            if(txt_appkey.Text == "")
            {
                MessageBox.Show("Appkeyを入力してください。");
                return;
            }

            try
            {
                //GETリクエスト用URL生成
                string url = url_fomatter(txt_appkey.Text, txt_post.Text.Replace("\n", ""));

                //GETリクエストを実行しjsonを受け取りパースする
                string json = new HttpClient().GetStringAsync(url).Result;
                JObject jobj = JObject.Parse(json);

                //jsonから必要な情報だけ取得
                string nobyText = (string)((jobj["text"] as JValue).Value);
                string nobyCommand = (string)((jobj["commandId"] as JValue).Value);

                //Appkeyが正しくない場合のバグが内臓されています。//
                //解決策模索中・・・。                            //

                //チャット結果を表示
                txt_noby_chat.AppendText(chat_formatter(txt_post.Text.Replace("\n", ""), nobyText));

                //最後の行にフォーカス
                txt_noby_chat.SelectionStart = txt_noby_chat.Text.Length;
                txt_noby_chat.Focus();
                txt_noby_chat.ScrollToCaret();

                //各パラメータを表示
                txt_url.Text = url;
                txt_json.Text = jobj.ToString();
                txt_command.Text = nobyCommand;

                //wmap系コマンドIDの場合のみ先に進む
                if (!Regex.IsMatch(txt_command.Text, "^wmap_*"))
                {
                    return;
                }

                //コマンドを実行
                cmd_exe(cmd_text_get(nobyCommand));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //検索ボタン
        private void btn_search_Click(object sender, EventArgs e)
        {
            string strSql = "";

            strSql = sql.sql_mst_mst_noby_command_select();
            DataTable dt = mysql_con.DataBaseAccess_Fill_da(strSql, constr_wmapst);
            dgv_command.DataSource = dt;
        }

        //URL生成メソッド
        private string url_fomatter(string appkey,string user_post_text)
        {
            string baseUrl = "https://www.cotogoto.ai/webapi/noby.json";
            string post_appkey = appkey;
            string post_text = user_post_text;
            string post_study = "1";
            string post_persona = "0";

            string url = $"{baseUrl}?appkey={post_appkey}&text={post_text}&study={post_study}&persona={post_persona}";

            return url;
        }

        //チャット表示変換メソッド
        private string chat_formatter(string user_post,string noby_post)
        {
            StringBuilder chat_text = new StringBuilder();

            chat_text.Append("USER：" + user_post + "\r\n");
            chat_text.Append("NOBY：" + noby_post + "\r\n");
            chat_text.Append("==============================================\r\n");

            return chat_text.ToString();
        }

        //コマンドIDから実行コマンドへの変換メソッド
        private string cmd_text_get(string command_id)
        {
            string strSql = "";

            strSql = sql.sql_mst_mst_noby_command_select(command_id);
            string strCmd = mysql_con.DataBaseAccess_ExecuteScaler(strSql, constr_wmapst);

            return strCmd;
        }

        //コマンド実行メソッド
        private void cmd_exe(string cmd_text)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = @"/c"+ cmd_text;

            //起動
            p.Start();

            p.Close();
        }
    }
}
