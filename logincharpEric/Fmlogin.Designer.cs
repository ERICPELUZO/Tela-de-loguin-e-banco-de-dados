namespace logincharpEric
{
    partial class Fmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Usuario = new Label();
            Btn_Iniciar = new Button();
            Text_Usuario = new TextBox();
            Tex_tlogin = new TextBox();
            lbl_Loguin = new Label();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Calibri", 12F);
            lbl_Usuario.Location = new Point(48, 140);
            lbl_Usuario.Margin = new Padding(4, 0, 4, 0);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(59, 19);
            lbl_Usuario.TabIndex = 0;
            lbl_Usuario.Text = "Usuario";
            // 
            // Btn_Iniciar
            // 
            Btn_Iniciar.Location = new Point(154, 309);
            Btn_Iniciar.Margin = new Padding(4);
            Btn_Iniciar.Name = "Btn_Iniciar";
            Btn_Iniciar.Size = new Size(115, 32);
            Btn_Iniciar.TabIndex = 1;
            Btn_Iniciar.Text = "Iniciar";
            Btn_Iniciar.UseVisualStyleBackColor = true;
            // 
            // Text_Usuario
            // 
            Text_Usuario.Font = new Font("Segoe UI", 12F);
            Text_Usuario.Location = new Point(126, 136);
            Text_Usuario.Margin = new Padding(4);
            Text_Usuario.Name = "Text_Usuario";
            Text_Usuario.Size = new Size(171, 29);
            Text_Usuario.TabIndex = 2;
            // 
            // Tex_tlogin
            // 
            Tex_tlogin.Font = new Font("Segoe UI", 12F);
            Tex_tlogin.Location = new Point(126, 218);
            Tex_tlogin.Margin = new Padding(4);
            Tex_tlogin.Name = "Tex_tlogin";
            Tex_tlogin.Size = new Size(171, 29);
            Tex_tlogin.TabIndex = 4;
            Tex_tlogin.UseSystemPasswordChar = true;
            // 
            // lbl_Loguin
            // 
            lbl_Loguin.AutoSize = true;
            lbl_Loguin.Font = new Font("Calibri", 12F);
            lbl_Loguin.Location = new Point(55, 223);
            lbl_Loguin.Margin = new Padding(4, 0, 4, 0);
            lbl_Loguin.Name = "lbl_Loguin";
            lbl_Loguin.Size = new Size(44, 19);
            lbl_Loguin.TabIndex = 3;
            lbl_Loguin.Text = "Login";
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(307, 446);
            btn_voltar.Margin = new Padding(4);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(64, 32);
            btn_voltar.TabIndex = 5;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            // 
            // Fmlogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 491);
            Controls.Add(btn_voltar);
            Controls.Add(Tex_tlogin);
            Controls.Add(lbl_Loguin);
            Controls.Add(Text_Usuario);
            Controls.Add(Btn_Iniciar);
            Controls.Add(lbl_Usuario);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "Fmlogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loguin";
            Load += this.Fmlogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Usuario;
        private Button Btn_Iniciar;
        private TextBox Text_Usuario;
        private TextBox Tex_tlogin;
        private Label lbl_Loguin;
        private Button btn_voltar;
    }
}
