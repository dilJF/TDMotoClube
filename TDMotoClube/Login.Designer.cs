namespace TDMotoClube
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.usuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.buttonEntrar, "buttonEntrar");
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click_1);
            // 
            // textBoxSenha
            // 
            resources.ApplyResources(this.textBoxSenha, "textBoxSenha");
            this.textBoxSenha.Name = "textBoxSenha";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            resources.ApplyResources(this.textBoxUsuario, "textBoxUsuario");
            this.textBoxUsuario.Name = "textBoxUsuario";
            // 
            // senha
            // 
            resources.ApplyResources(this.senha, "senha");
            this.senha.Name = "senha";
            // 
            // pictureBoxLogo
            // 
            resources.ApplyResources(this.pictureBoxLogo, "pictureBoxLogo");
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.TabStop = false;
            // 
            // usuario
            // 
            resources.ApplyResources(this.usuario, "usuario");
            this.usuario.Name = "usuario";
            // 
            // Login
            // 
            this.AcceptButton = this.buttonEntrar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.usuario);
            this.MaximizeBox = false;
            this.Name = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label usuario;


    }
}

