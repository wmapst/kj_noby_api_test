namespace wmap_noby_api
{
    partial class frm_main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.txt_appkey = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.lbl_appkey = new System.Windows.Forms.Label();
            this.txt_noby_chat = new System.Windows.Forms.RichTextBox();
            this.lbl_command = new System.Windows.Forms.Label();
            this.txt_command = new System.Windows.Forms.TextBox();
            this.txt_post = new System.Windows.Forms.RichTextBox();
            this.btn_post = new System.Windows.Forms.Button();
            this.txt_json = new System.Windows.Forms.RichTextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_command = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_command)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_appkey
            // 
            this.txt_appkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_appkey.Location = new System.Drawing.Point(69, 12);
            this.txt_appkey.Name = "txt_appkey";
            this.txt_appkey.Size = new System.Drawing.Size(427, 19);
            this.txt_appkey.TabIndex = 0;
            // 
            // txt_url
            // 
            this.txt_url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_url.Location = new System.Drawing.Point(502, 12);
            this.txt_url.Name = "txt_url";
            this.txt_url.ReadOnly = true;
            this.txt_url.Size = new System.Drawing.Size(545, 19);
            this.txt_url.TabIndex = 1;
            // 
            // lbl_appkey
            // 
            this.lbl_appkey.AutoSize = true;
            this.lbl_appkey.Location = new System.Drawing.Point(13, 16);
            this.lbl_appkey.Name = "lbl_appkey";
            this.lbl_appkey.Size = new System.Drawing.Size(50, 12);
            this.lbl_appkey.TabIndex = 2;
            this.lbl_appkey.Text = "AppKey：";
            // 
            // txt_noby_chat
            // 
            this.txt_noby_chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_noby_chat.Location = new System.Drawing.Point(12, 38);
            this.txt_noby_chat.Name = "txt_noby_chat";
            this.txt_noby_chat.ReadOnly = true;
            this.txt_noby_chat.Size = new System.Drawing.Size(484, 360);
            this.txt_noby_chat.TabIndex = 3;
            this.txt_noby_chat.Text = "";
            // 
            // lbl_command
            // 
            this.lbl_command.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_command.AutoSize = true;
            this.lbl_command.Location = new System.Drawing.Point(13, 407);
            this.lbl_command.Name = "lbl_command";
            this.lbl_command.Size = new System.Drawing.Size(57, 12);
            this.lbl_command.TabIndex = 5;
            this.lbl_command.Text = "コマンドID：";
            // 
            // txt_command
            // 
            this.txt_command.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_command.Location = new System.Drawing.Point(76, 404);
            this.txt_command.Name = "txt_command";
            this.txt_command.ReadOnly = true;
            this.txt_command.Size = new System.Drawing.Size(420, 19);
            this.txt_command.TabIndex = 4;
            // 
            // txt_post
            // 
            this.txt_post.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_post.Location = new System.Drawing.Point(12, 438);
            this.txt_post.Name = "txt_post";
            this.txt_post.Size = new System.Drawing.Size(385, 91);
            this.txt_post.TabIndex = 6;
            this.txt_post.Text = "めかぶは体に良いって本当ですか？";
            // 
            // btn_post
            // 
            this.btn_post.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_post.Location = new System.Drawing.Point(403, 438);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(93, 91);
            this.btn_post.TabIndex = 7;
            this.btn_post.Text = "投稿(&D)";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // txt_json
            // 
            this.txt_json.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_json.Location = new System.Drawing.Point(502, 38);
            this.txt_json.Name = "txt_json";
            this.txt_json.ReadOnly = true;
            this.txt_json.Size = new System.Drawing.Size(545, 360);
            this.txt_json.TabIndex = 8;
            this.txt_json.Text = "";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(954, 438);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 91);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "検索(&S)";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_command
            // 
            this.dgv_command.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_command.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_command.Location = new System.Drawing.Point(502, 407);
            this.dgv_command.Name = "dgv_command";
            this.dgv_command.RowTemplate.Height = 21;
            this.dgv_command.Size = new System.Drawing.Size(446, 122);
            this.dgv_command.TabIndex = 10;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 543);
            this.Controls.Add(this.dgv_command);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_json);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.txt_post);
            this.Controls.Add(this.lbl_command);
            this.Controls.Add(this.txt_command);
            this.Controls.Add(this.txt_noby_chat);
            this.Controls.Add(this.lbl_appkey);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.txt_appkey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.Text = "noby api test";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_command)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_appkey;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label lbl_appkey;
        private System.Windows.Forms.RichTextBox txt_noby_chat;
        private System.Windows.Forms.Label lbl_command;
        private System.Windows.Forms.TextBox txt_command;
        private System.Windows.Forms.RichTextBox txt_post;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.RichTextBox txt_json;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_command;
    }
}

