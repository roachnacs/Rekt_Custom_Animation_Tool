
namespace Rekt_Custom_Animation_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AnimList = new System.Windows.Forms.LinkLabel();
            this.SetAnimation = new System.Windows.Forms.Button();
            this.NewAnimation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnimationBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WeaponBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AnimList);
            this.groupBox1.Controls.Add(this.SetAnimation);
            this.groupBox1.Controls.Add(this.NewAnimation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AnimationBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WeaponBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Animations";
            // 
            // AnimList
            // 
            this.AnimList.AutoSize = true;
            this.AnimList.Location = new System.Drawing.Point(336, 129);
            this.AnimList.Name = "AnimList";
            this.AnimList.Size = new System.Drawing.Size(96, 13);
            this.AnimList.TabIndex = 7;
            this.AnimList.TabStop = true;
            this.AnimList.Text = "BO1 Animation List";
            this.AnimList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AnimList_LinkClicked);
            // 
            // SetAnimation
            // 
            this.SetAnimation.Location = new System.Drawing.Point(6, 94);
            this.SetAnimation.Name = "SetAnimation";
            this.SetAnimation.Size = new System.Drawing.Size(426, 23);
            this.SetAnimation.TabIndex = 6;
            this.SetAnimation.Text = "Set Custom Animation";
            this.SetAnimation.UseVisualStyleBackColor = true;
            this.SetAnimation.Click += new System.EventHandler(this.SetAnimation_Click);
            // 
            // NewAnimation
            // 
            this.NewAnimation.Location = new System.Drawing.Point(6, 68);
            this.NewAnimation.Name = "NewAnimation";
            this.NewAnimation.Size = new System.Drawing.Size(426, 20);
            this.NewAnimation.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Animation";
            // 
            // AnimationBox
            // 
            this.AnimationBox.FormattingEnabled = true;
            this.AnimationBox.Items.AddRange(new object[] {
            "Please Select A Weapon"});
            this.AnimationBox.Location = new System.Drawing.Point(224, 35);
            this.AnimationBox.Name = "AnimationBox";
            this.AnimationBox.Size = new System.Drawing.Size(208, 21);
            this.AnimationBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Weapon";
            // 
            // WeaponBox
            // 
            this.WeaponBox.FormattingEnabled = true;
            this.WeaponBox.Items.AddRange(new object[] {
            "============================================================",
            "MP5K",
            "Skorpion",
            "MAC11",
            "AK74u",
            "Uzi",
            "PM63",
            "MPL",
            "Spectre",
            "Kiparis",
            "============================================================",
            "M16",
            "Enfield",
            "M14",
            "Famas",
            "Galil",
            "AUG",
            "FN FAL",
            "AK47",
            "Commando",
            "G11",
            "============================================================",
            "Olympia",
            "Stakeout",
            "SPAS-12",
            "HS10",
            "============================================================",
            "HK21",
            "RPK",
            "M60",
            "Stoner63",
            "============================================================",
            "Dragunov",
            "WA2000",
            "L96A1",
            "PSG1",
            "============================================================",
            "ASP",
            "M1911",
            "Makarov",
            "Python",
            "CZ75",
            "============================================================",
            "M27 LAW",
            "RPG",
            "Strela-3",
            "China Lake",
            "============================================================",
            "Ballistic Knife",
            "Crossbow",
            "============================================================",
            "Grim Reaper",
            "RC-XD",
            "Carepackage",
            "Bomb",
            "============================================================",
            "Camera Spike",
            "C4",
            "Tactical Insertion",
            "Jammer",
            "Motion Sensor",
            "Claymore"});
            this.WeaponBox.Location = new System.Drawing.Point(6, 35);
            this.WeaponBox.Name = "WeaponBox";
            this.WeaponBox.Size = new System.Drawing.Size(202, 21);
            this.WeaponBox.TabIndex = 0;
            this.WeaponBox.SelectedIndexChanged += new System.EventHandler(this.SelectedWeap_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Toggle Always Knife Lunge";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(463, 183);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "REKT Custom Animation Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox WeaponBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AnimationBox;
        private System.Windows.Forms.TextBox NewAnimation;
        private System.Windows.Forms.Button SetAnimation;
        private System.Windows.Forms.LinkLabel AnimList;
        private System.Windows.Forms.Button button1;
    }
}

