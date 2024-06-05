namespace THNF_1502
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_matchid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_matchid = new System.Windows.Forms.TextBox();
            this.cb_teamhome = new System.Windows.Forms.ComboBox();
            this.lbl_MD = new System.Windows.Forms.Label();
            this.lbl_teamaway = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cb_teamaway = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lbl_minute = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_player = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.tb_minute = new System.Windows.Forms.TextBox();
            this.cb_team = new System.Windows.Forms.ComboBox();
            this.cb_player = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_matchid
            // 
            this.lbl_matchid.AutoSize = true;
            this.lbl_matchid.Location = new System.Drawing.Point(111, 57);
            this.lbl_matchid.Name = "lbl_matchid";
            this.lbl_matchid.Size = new System.Drawing.Size(59, 16);
            this.lbl_matchid.TabIndex = 0;
            this.lbl_matchid.Text = "Match ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team Home";
            // 
            // tb_matchid
            // 
            this.tb_matchid.Location = new System.Drawing.Point(216, 57);
            this.tb_matchid.Name = "tb_matchid";
            this.tb_matchid.Size = new System.Drawing.Size(132, 22);
            this.tb_matchid.TabIndex = 2;
            // 
            // cb_teamhome
            // 
            this.cb_teamhome.FormattingEnabled = true;
            this.cb_teamhome.Location = new System.Drawing.Point(216, 95);
            this.cb_teamhome.Name = "cb_teamhome";
            this.cb_teamhome.Size = new System.Drawing.Size(132, 24);
            this.cb_teamhome.TabIndex = 3;
            this.cb_teamhome.SelectedIndexChanged += new System.EventHandler(this.cb_teamhome_SelectedIndexChanged);
            // 
            // lbl_MD
            // 
            this.lbl_MD.AutoSize = true;
            this.lbl_MD.Location = new System.Drawing.Point(494, 57);
            this.lbl_MD.Name = "lbl_MD";
            this.lbl_MD.Size = new System.Drawing.Size(75, 16);
            this.lbl_MD.TabIndex = 4;
            this.lbl_MD.Text = "Match Date";
            // 
            // lbl_teamaway
            // 
            this.lbl_teamaway.AutoSize = true;
            this.lbl_teamaway.Location = new System.Drawing.Point(494, 98);
            this.lbl_teamaway.Name = "lbl_teamaway";
            this.lbl_teamaway.Size = new System.Drawing.Size(79, 16);
            this.lbl_teamaway.TabIndex = 5;
            this.lbl_teamaway.Text = "Team Away";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(593, 55);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(299, 22);
            this.dtp.TabIndex = 6;
            // 
            // cb_teamaway
            // 
            this.cb_teamaway.FormattingEnabled = true;
            this.cb_teamaway.Location = new System.Drawing.Point(593, 95);
            this.cb_teamaway.Name = "cb_teamaway";
            this.cb_teamaway.Size = new System.Drawing.Size(132, 24);
            this.cb_teamaway.TabIndex = 7;
            this.cb_teamaway.SelectedIndexChanged += new System.EventHandler(this.cb_teamaway_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(43, 180);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(467, 203);
            this.dgv.TabIndex = 8;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(410, 415);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(141, 23);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // lbl_minute
            // 
            this.lbl_minute.AutoSize = true;
            this.lbl_minute.Location = new System.Drawing.Point(590, 200);
            this.lbl_minute.Name = "lbl_minute";
            this.lbl_minute.Size = new System.Drawing.Size(46, 16);
            this.lbl_minute.TabIndex = 10;
            this.lbl_minute.Text = "Minute";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(590, 237);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(43, 16);
            this.lbl_team.TabIndex = 11;
            this.lbl_team.Text = "Team";
            // 
            // lbl_player
            // 
            this.lbl_player.AutoSize = true;
            this.lbl_player.Location = new System.Drawing.Point(590, 274);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(46, 16);
            this.lbl_player.TabIndex = 12;
            this.lbl_player.Text = "Player";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(590, 310);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(39, 16);
            this.lbl_type.TabIndex = 13;
            this.lbl_type.Text = "Type";
            // 
            // tb_minute
            // 
            this.tb_minute.Location = new System.Drawing.Point(642, 197);
            this.tb_minute.Name = "tb_minute";
            this.tb_minute.Size = new System.Drawing.Size(132, 22);
            this.tb_minute.TabIndex = 14;
            this.tb_minute.TextChanged += new System.EventHandler(this.tb_minute_TextChanged);
            this.tb_minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_minute_KeyPress);
            // 
            // cb_team
            // 
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Location = new System.Drawing.Point(642, 234);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(132, 24);
            this.cb_team.TabIndex = 15;
            this.cb_team.SelectedIndexChanged += new System.EventHandler(this.cb_team_SelectedIndexChanged);
            this.cb_team.TextChanged += new System.EventHandler(this.cb_team_TextChanged);
            // 
            // cb_player
            // 
            this.cb_player.FormattingEnabled = true;
            this.cb_player.Location = new System.Drawing.Point(642, 271);
            this.cb_player.Name = "cb_player";
            this.cb_player.Size = new System.Drawing.Size(132, 24);
            this.cb_player.TabIndex = 16;
            this.cb_player.SelectedIndexChanged += new System.EventHandler(this.cb_player_SelectedIndexChanged);
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "GO",
            "GP",
            "GW",
            "CR",
            "CY",
            "PM"});
            this.cb_type.Location = new System.Drawing.Point(642, 307);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(132, 24);
            this.cb_type.TabIndex = 17;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(573, 360);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(701, 360);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 23);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.cb_player);
            this.Controls.Add(this.cb_team);
            this.Controls.Add(this.tb_minute);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_player);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_minute);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cb_teamaway);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lbl_teamaway);
            this.Controls.Add(this.lbl_MD);
            this.Controls.Add(this.cb_teamhome);
            this.Controls.Add(this.tb_matchid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_matchid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_matchid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_matchid;
        private System.Windows.Forms.ComboBox cb_teamhome;
        private System.Windows.Forms.Label lbl_MD;
        private System.Windows.Forms.Label lbl_teamaway;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cb_teamaway;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lbl_minute;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox tb_minute;
        private System.Windows.Forms.ComboBox cb_team;
        private System.Windows.Forms.ComboBox cb_player;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
    }
}

