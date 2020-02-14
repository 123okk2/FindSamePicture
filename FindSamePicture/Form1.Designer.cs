namespace FindSamePicture
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.time = new System.Windows.Forms.Label();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.게임ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새게임ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기록보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rank = new System.Windows.Forms.GroupBox();
            this.score5 = new System.Windows.Forms.Label();
            this.score4 = new System.Windows.Forms.Label();
            this.score3 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.기록초기화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.rank.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time.Location = new System.Drawing.Point(215, 38);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(115, 29);
            this.time.TabIndex = 0;
            this.time.Text = "0.0 sec";
            // 
            // btn02
            // 
            this.btn02.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn02.Location = new System.Drawing.Point(174, 89);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(75, 75);
            this.btn02.TabIndex = 1;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn00.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn00.Location = new System.Drawing.Point(12, 89);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(75, 75);
            this.btn00.TabIndex = 2;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn01
            // 
            this.btn01.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn01.Location = new System.Drawing.Point(93, 89);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 75);
            this.btn01.TabIndex = 3;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn03
            // 
            this.btn03.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn03.Location = new System.Drawing.Point(255, 89);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(75, 75);
            this.btn03.TabIndex = 4;
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn10.Location = new System.Drawing.Point(12, 170);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 75);
            this.btn10.TabIndex = 5;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn11
            // 
            this.btn11.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn11.Location = new System.Drawing.Point(93, 170);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 75);
            this.btn11.TabIndex = 6;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn12.Location = new System.Drawing.Point(174, 170);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 75);
            this.btn12.TabIndex = 7;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn13
            // 
            this.btn13.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn13.Location = new System.Drawing.Point(255, 170);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(75, 75);
            this.btn13.TabIndex = 8;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn20.Location = new System.Drawing.Point(12, 251);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 75);
            this.btn20.TabIndex = 9;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn21
            // 
            this.btn21.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn21.Location = new System.Drawing.Point(93, 251);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(75, 75);
            this.btn21.TabIndex = 10;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn22
            // 
            this.btn22.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn22.Location = new System.Drawing.Point(174, 251);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(75, 75);
            this.btn22.TabIndex = 11;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn23
            // 
            this.btn23.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn23.Location = new System.Drawing.Point(255, 251);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(75, 75);
            this.btn23.TabIndex = 12;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn30
            // 
            this.btn30.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn30.Location = new System.Drawing.Point(12, 332);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(75, 75);
            this.btn30.TabIndex = 13;
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn31
            // 
            this.btn31.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn31.Location = new System.Drawing.Point(93, 332);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(75, 75);
            this.btn31.TabIndex = 14;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn32
            // 
            this.btn32.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn32.Location = new System.Drawing.Point(174, 332);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(75, 75);
            this.btn32.TabIndex = 15;
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // btn33
            // 
            this.btn33.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn33.Location = new System.Drawing.Point(255, 332);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(75, 75);
            this.btn33.TabIndex = 16;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopTimer
            // 
            this.stopTimer.Interval = 500;
            this.stopTimer.Tick += new System.EventHandler(this.stopTimer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.게임ToolStripMenuItem,
            this.기록ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 게임ToolStripMenuItem
            // 
            this.게임ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새게임ToolStripMenuItem,
            this.중지ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.게임ToolStripMenuItem.Name = "게임ToolStripMenuItem";
            this.게임ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.게임ToolStripMenuItem.Text = "게임";
            // 
            // 새게임ToolStripMenuItem
            // 
            this.새게임ToolStripMenuItem.Name = "새게임ToolStripMenuItem";
            this.새게임ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.새게임ToolStripMenuItem.Text = "새 게임";
            this.새게임ToolStripMenuItem.Click += new System.EventHandler(this.새게임ToolStripMenuItem_Click);
            // 
            // 중지ToolStripMenuItem
            // 
            this.중지ToolStripMenuItem.Enabled = false;
            this.중지ToolStripMenuItem.Name = "중지ToolStripMenuItem";
            this.중지ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.중지ToolStripMenuItem.Text = "중지";
            this.중지ToolStripMenuItem.Click += new System.EventHandler(this.중지ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 기록ToolStripMenuItem
            // 
            this.기록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기록보기ToolStripMenuItem,
            this.기록초기화ToolStripMenuItem});
            this.기록ToolStripMenuItem.Name = "기록ToolStripMenuItem";
            this.기록ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.기록ToolStripMenuItem.Text = "기록";
            // 
            // 기록보기ToolStripMenuItem
            // 
            this.기록보기ToolStripMenuItem.Name = "기록보기ToolStripMenuItem";
            this.기록보기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.기록보기ToolStripMenuItem.Text = "기록 보기";
            this.기록보기ToolStripMenuItem.Click += new System.EventHandler(this.기록보기ToolStripMenuItem_Click);
            // 
            // rank
            // 
            this.rank.Controls.Add(this.score5);
            this.rank.Controls.Add(this.score4);
            this.rank.Controls.Add(this.score3);
            this.rank.Controls.Add(this.score2);
            this.rank.Controls.Add(this.score1);
            this.rank.Controls.Add(this.label5);
            this.rank.Controls.Add(this.label4);
            this.rank.Controls.Add(this.label3);
            this.rank.Controls.Add(this.label2);
            this.rank.Controls.Add(this.label1);
            this.rank.Location = new System.Drawing.Point(346, 38);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(105, 369);
            this.rank.TabIndex = 23;
            this.rank.TabStop = false;
            this.rank.Text = "Ranking";
            // 
            // score5
            // 
            this.score5.AutoSize = true;
            this.score5.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score5.Location = new System.Drawing.Point(4, 316);
            this.score5.Name = "score5";
            this.score5.Size = new System.Drawing.Size(111, 29);
            this.score5.TabIndex = 9;
            this.score5.Text = "label10";
            // 
            // score4
            // 
            this.score4.AutoSize = true;
            this.score4.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score4.Location = new System.Drawing.Point(4, 245);
            this.score4.Name = "score4";
            this.score4.Size = new System.Drawing.Size(94, 29);
            this.score4.TabIndex = 8;
            this.score4.Text = "label9";
            // 
            // score3
            // 
            this.score3.AutoSize = true;
            this.score3.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score3.Location = new System.Drawing.Point(5, 178);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(94, 29);
            this.score3.TabIndex = 7;
            this.score3.Text = "label8";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score2.Location = new System.Drawing.Point(5, 106);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(94, 29);
            this.score2.TabIndex = 6;
            this.score2.Text = "label7";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.score1.Location = new System.Drawing.Point(4, 33);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(94, 29);
            this.score1.TabIndex = 5;
            this.score1.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(6, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "5등";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(5, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "4등";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "3등";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2등";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1등";
            // 
            // 기록초기화ToolStripMenuItem
            // 
            this.기록초기화ToolStripMenuItem.Name = "기록초기화ToolStripMenuItem";
            this.기록초기화ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.기록초기화ToolStripMenuItem.Text = "기록 초기화";
            this.기록초기화ToolStripMenuItem.Click += new System.EventHandler(this.기록초기화ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 419);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.time);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rank.ResumeLayout(false);
            this.rank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer stopTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 게임ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새게임ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기록보기ToolStripMenuItem;
        private System.Windows.Forms.GroupBox rank;
        private System.Windows.Forms.Label score5;
        private System.Windows.Forms.Label score4;
        private System.Windows.Forms.Label score3;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 기록초기화ToolStripMenuItem;
    }
}

