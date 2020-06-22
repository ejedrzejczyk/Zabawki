namespace Zabawki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectToy = new System.Windows.Forms.ComboBox();
            this.addedToys = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Param = new System.Windows.Forms.GroupBox();
            this.heightParam = new System.Windows.Forms.GroupBox();
            this.height = new System.Windows.Forms.TextBox();
            this.heightInc = new System.Windows.Forms.Button();
            this.heightDec = new System.Windows.Forms.Button();
            this.diveParam = new System.Windows.Forms.GroupBox();
            this.diveDec = new System.Windows.Forms.Button();
            this.diveInc = new System.Windows.Forms.Button();
            this.dive = new System.Windows.Forms.TextBox();
            this.speedParam = new System.Windows.Forms.GroupBox();
            this.speedInc = new System.Windows.Forms.Button();
            this.speedDec = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.TextBox();
            this.Param.SuspendLayout();
            this.heightParam.SuspendLayout();
            this.diveParam.SuspendLayout();
            this.speedParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectToy
            // 
            this.selectToy.FormattingEnabled = true;
            this.selectToy.Items.AddRange(new object[] {
            "Car",
            "Submarine",
            "Plane",
            "Computer"});
            this.selectToy.Location = new System.Drawing.Point(55, 237);
            this.selectToy.Name = "selectToy";
            this.selectToy.Size = new System.Drawing.Size(121, 24);
            this.selectToy.TabIndex = 0;
            // 
            // addedToys
            // 
            this.addedToys.FormattingEnabled = true;
            this.addedToys.ItemHeight = 16;
            this.addedToys.Location = new System.Drawing.Point(237, 56);
            this.addedToys.Name = "addedToys";
            this.addedToys.Size = new System.Drawing.Size(142, 244);
            this.addedToys.TabIndex = 1;
            this.addedToys.Click += new System.EventHandler(this.addedToys_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Control;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add.Location = new System.Drawing.Point(79, 306);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 34);
            this.Add.TabIndex = 2;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.SystemColors.Control;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Remove.Location = new System.Drawing.Point(257, 306);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(97, 34);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "REMOVE";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Param
            // 
            this.Param.Controls.Add(this.heightParam);
            this.Param.Controls.Add(this.diveParam);
            this.Param.Controls.Add(this.speedParam);
            this.Param.Location = new System.Drawing.Point(436, 56);
            this.Param.Name = "Param";
            this.Param.Size = new System.Drawing.Size(287, 268);
            this.Param.TabIndex = 4;
            this.Param.TabStop = false;
            this.Param.Text = "Parmeters";
            // 
            // heightParam
            // 
            this.heightParam.Controls.Add(this.height);
            this.heightParam.Controls.Add(this.heightInc);
            this.heightParam.Controls.Add(this.heightDec);
            this.heightParam.Location = new System.Drawing.Point(6, 181);
            this.heightParam.Name = "heightParam";
            this.heightParam.Size = new System.Drawing.Size(275, 74);
            this.heightParam.TabIndex = 5;
            this.heightParam.TabStop = false;
            this.heightParam.Text = "Height";
            this.heightParam.Visible = false;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(87, 33);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 22);
            this.height.TabIndex = 5;
            this.height.Text = "0";
            // 
            // heightInc
            // 
            this.heightInc.Location = new System.Drawing.Point(193, 33);
            this.heightInc.Name = "heightInc";
            this.heightInc.Size = new System.Drawing.Size(75, 22);
            this.heightInc.TabIndex = 3;
            this.heightInc.Text = "+";
            this.heightInc.UseVisualStyleBackColor = true;
            this.heightInc.Click += new System.EventHandler(this.heightInc_Click);
            // 
            // heightDec
            // 
            this.heightDec.Location = new System.Drawing.Point(6, 33);
            this.heightDec.Name = "heightDec";
            this.heightDec.Size = new System.Drawing.Size(75, 22);
            this.heightDec.TabIndex = 2;
            this.heightDec.Text = "-";
            this.heightDec.UseVisualStyleBackColor = true;
            this.heightDec.Click += new System.EventHandler(this.heightDec_Click);
            // 
            // diveParam
            // 
            this.diveParam.Controls.Add(this.diveDec);
            this.diveParam.Controls.Add(this.diveInc);
            this.diveParam.Controls.Add(this.dive);
            this.diveParam.Location = new System.Drawing.Point(6, 101);
            this.diveParam.Name = "diveParam";
            this.diveParam.Size = new System.Drawing.Size(275, 74);
            this.diveParam.TabIndex = 1;
            this.diveParam.TabStop = false;
            this.diveParam.Text = "Dive";
            this.diveParam.Visible = false;
            // 
            // diveDec
            // 
            this.diveDec.Location = new System.Drawing.Point(6, 32);
            this.diveDec.Name = "diveDec";
            this.diveDec.Size = new System.Drawing.Size(75, 22);
            this.diveDec.TabIndex = 2;
            this.diveDec.Text = "-";
            this.diveDec.UseVisualStyleBackColor = true;
            this.diveDec.Click += new System.EventHandler(this.diveDec_Click);
            // 
            // diveInc
            // 
            this.diveInc.Location = new System.Drawing.Point(193, 32);
            this.diveInc.Name = "diveInc";
            this.diveInc.Size = new System.Drawing.Size(75, 22);
            this.diveInc.TabIndex = 1;
            this.diveInc.Text = "+";
            this.diveInc.UseVisualStyleBackColor = true;
            this.diveInc.Click += new System.EventHandler(this.diveInc_Click);
            // 
            // dive
            // 
            this.dive.Location = new System.Drawing.Point(87, 32);
            this.dive.Name = "dive";
            this.dive.Size = new System.Drawing.Size(100, 22);
            this.dive.TabIndex = 0;
            this.dive.Text = "0";
            // 
            // speedParam
            // 
            this.speedParam.Controls.Add(this.speedInc);
            this.speedParam.Controls.Add(this.speedDec);
            this.speedParam.Controls.Add(this.speed);
            this.speedParam.Location = new System.Drawing.Point(6, 21);
            this.speedParam.Name = "speedParam";
            this.speedParam.Size = new System.Drawing.Size(275, 74);
            this.speedParam.TabIndex = 0;
            this.speedParam.TabStop = false;
            this.speedParam.Text = "Speed";
            this.speedParam.Visible = false;
            // 
            // speedInc
            // 
            this.speedInc.Location = new System.Drawing.Point(193, 30);
            this.speedInc.Name = "speedInc";
            this.speedInc.Size = new System.Drawing.Size(75, 22);
            this.speedInc.TabIndex = 2;
            this.speedInc.Text = "+";
            this.speedInc.UseVisualStyleBackColor = true;
            this.speedInc.Click += new System.EventHandler(this.speedInc_Click);
            // 
            // speedDec
            // 
            this.speedDec.Location = new System.Drawing.Point(6, 30);
            this.speedDec.Name = "speedDec";
            this.speedDec.Size = new System.Drawing.Size(75, 22);
            this.speedDec.TabIndex = 1;
            this.speedDec.Text = "-";
            this.speedDec.UseVisualStyleBackColor = true;
            this.speedDec.Click += new System.EventHandler(this.speedDec_Click);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(87, 30);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(100, 22);
            this.speed.TabIndex = 0;
            this.speed.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Param);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.addedToys);
            this.Controls.Add(this.selectToy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Param.ResumeLayout(false);
            this.heightParam.ResumeLayout(false);
            this.heightParam.PerformLayout();
            this.diveParam.ResumeLayout(false);
            this.diveParam.PerformLayout();
            this.speedParam.ResumeLayout(false);
            this.speedParam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectToy;
        private System.Windows.Forms.ListBox addedToys;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.GroupBox Param;
        private System.Windows.Forms.GroupBox speedParam;
        private System.Windows.Forms.GroupBox heightParam;
        private System.Windows.Forms.GroupBox diveParam;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.Button heightInc;
        private System.Windows.Forms.Button heightDec;
        private System.Windows.Forms.Button diveDec;
        private System.Windows.Forms.Button diveInc;
        private System.Windows.Forms.TextBox dive;
        private System.Windows.Forms.Button speedInc;
        private System.Windows.Forms.Button speedDec;
        private System.Windows.Forms.TextBox height;
    }
}

