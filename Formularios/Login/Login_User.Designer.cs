
namespace Punto_De_Venta_Andro.Formularios.Login
{
    partial class Login_User
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_User));
            this.txtTittle = new System.Windows.Forms.Label();
            this.PButtons = new System.Windows.Forms.Panel();
            this.LblSerial = new System.Windows.Forms.Label();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.DGVUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DGVSerial = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.FLPLoginUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.DragPPassword = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PPasswordRounded = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BtnRecoverPass = new Guna.UI2.WinForms.Guna2Button();
            this.POlvide = new System.Windows.Forms.Panel();
            this.PLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.PBUser = new System.Windows.Forms.PictureBox();
            this.BtnChangeUser = new Guna.UI2.WinForms.Guna2Button();
            this.TxtUserLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPasswordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSerial)).BeginInit();
            this.POlvide.SuspendLayout();
            this.PLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTittle
            // 
            this.txtTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTittle.Font = new System.Drawing.Font("Segoe UI Semilight", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTittle.Location = new System.Drawing.Point(0, 75);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(1024, 213);
            this.txtTittle.TabIndex = 0;
            this.txtTittle.Text = "Inicia Sesión";
            this.txtTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PButtons
            // 
            this.PButtons.BackColor = System.Drawing.Color.White;
            this.PButtons.Controls.Add(this.LblSerial);
            this.PButtons.Controls.Add(this.PBLogo);
            this.PButtons.Controls.Add(this.DGVUsuarios);
            this.PButtons.Controls.Add(this.DGVSerial);
            this.PButtons.Controls.Add(this.BtnClose);
            this.PButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PButtons.Location = new System.Drawing.Point(0, 0);
            this.PButtons.Name = "PButtons";
            this.PButtons.Size = new System.Drawing.Size(1024, 75);
            this.PButtons.TabIndex = 2;
            // 
            // LblSerial
            // 
            this.LblSerial.AutoSize = true;
            this.LblSerial.Location = new System.Drawing.Point(637, 12);
            this.LblSerial.Name = "LblSerial";
            this.LblSerial.Size = new System.Drawing.Size(35, 13);
            this.LblSerial.TabIndex = 14;
            this.LblSerial.Text = "label1";
            this.LblSerial.Visible = false;
            // 
            // PBLogo
            // 
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBLogo.Image = global::Punto_De_Venta_Andro.Properties.Resources.Logotipo;
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.MaximumSize = new System.Drawing.Size(90, 90);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Padding = new System.Windows.Forms.Padding(15);
            this.PBLogo.Size = new System.Drawing.Size(90, 90);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 13;
            this.PBLogo.TabStop = false;
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AllowUserToAddRows = false;
            this.DGVUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DGVUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUsuarios.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVUsuarios.EnableHeadersVisualStyles = false;
            this.DGVUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUsuarios.Location = new System.Drawing.Point(12, 12);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.ReadOnly = true;
            this.DGVUsuarios.RowHeadersVisible = false;
            this.DGVUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsuarios.Size = new System.Drawing.Size(213, 150);
            this.DGVUsuarios.TabIndex = 12;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVUsuarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVUsuarios.ThemeStyle.HeaderStyle.Height = 4;
            this.DGVUsuarios.ThemeStyle.ReadOnly = true;
            this.DGVUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVUsuarios.ThemeStyle.RowsStyle.Height = 22;
            this.DGVUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVUsuarios.Visible = false;
            // 
            // DGVSerial
            // 
            this.DGVSerial.AllowUserToAddRows = false;
            this.DGVSerial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVSerial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVSerial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSerial.BackgroundColor = System.Drawing.Color.White;
            this.DGVSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVSerial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVSerial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSerial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVSerial.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVSerial.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVSerial.EnableHeadersVisualStyles = false;
            this.DGVSerial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVSerial.Location = new System.Drawing.Point(406, -38);
            this.DGVSerial.Name = "DGVSerial";
            this.DGVSerial.ReadOnly = true;
            this.DGVSerial.RowHeadersVisible = false;
            this.DGVSerial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSerial.Size = new System.Drawing.Size(213, 150);
            this.DGVSerial.TabIndex = 15;
            this.DGVSerial.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVSerial.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVSerial.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVSerial.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVSerial.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVSerial.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVSerial.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVSerial.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVSerial.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVSerial.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVSerial.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVSerial.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVSerial.ThemeStyle.HeaderStyle.Height = 4;
            this.DGVSerial.ThemeStyle.ReadOnly = true;
            this.DGVSerial.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVSerial.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVSerial.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVSerial.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVSerial.ThemeStyle.RowsStyle.Height = 22;
            this.DGVSerial.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVSerial.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVSerial.Visible = false;
            // 
            // BtnClose
            // 
            this.BtnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BtnClose.HoverState.ImageSize = new System.Drawing.Size(80, 80);
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.BtnClose.ImageRotate = 0F;
            this.BtnClose.ImageSize = new System.Drawing.Size(75, 75);
            this.BtnClose.Location = new System.Drawing.Point(949, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedState.ImageSize = new System.Drawing.Size(75, 75);
            this.BtnClose.PressedState.Parent = this.BtnClose;
            this.BtnClose.ShadowDecoration.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(75, 75);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FLPLoginUsers
            // 
            this.FLPLoginUsers.AutoScroll = true;
            this.FLPLoginUsers.BackColor = System.Drawing.Color.White;
            this.FLPLoginUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPLoginUsers.Location = new System.Drawing.Point(0, 288);
            this.FLPLoginUsers.Name = "FLPLoginUsers";
            this.FLPLoginUsers.Size = new System.Drawing.Size(1024, 480);
            this.FLPLoginUsers.TabIndex = 3;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(38, 177);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(82, 30);
            this.LblUser.TabIndex = 5;
            this.LblUser.Text = "Usuario";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(38, 272);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(120, 30);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "Contraseña:";
            // 
            // DragPPassword
            // 
            this.DragPPassword.DockForm = true;
            this.DragPPassword.DockIndicatorColor = System.Drawing.Color.Black;
            this.DragPPassword.TargetControl = this.LblUser;
            // 
            // PPasswordRounded
            // 
            this.PPasswordRounded.BorderRadius = 15;
            // 
            // BtnRecoverPass
            // 
            this.BtnRecoverPass.AutoRoundedCorners = true;
            this.BtnRecoverPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.BtnRecoverPass.BorderRadius = 29;
            this.BtnRecoverPass.BorderThickness = 1;
            this.BtnRecoverPass.CheckedState.Parent = this.BtnRecoverPass;
            this.BtnRecoverPass.CustomImages.Parent = this.BtnRecoverPass;
            this.BtnRecoverPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRecoverPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRecoverPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRecoverPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRecoverPass.DisabledState.Parent = this.BtnRecoverPass;
            this.BtnRecoverPass.FillColor = System.Drawing.Color.White;
            this.BtnRecoverPass.Font = new System.Drawing.Font("Quicksand", 15F);
            this.BtnRecoverPass.ForeColor = System.Drawing.Color.Black;
            this.BtnRecoverPass.HoverState.Parent = this.BtnRecoverPass;
            this.BtnRecoverPass.Location = new System.Drawing.Point(66, 45);
            this.BtnRecoverPass.MaximumSize = new System.Drawing.Size(900, 60);
            this.BtnRecoverPass.MinimumSize = new System.Drawing.Size(900, 60);
            this.BtnRecoverPass.Name = "BtnRecoverPass";
            this.BtnRecoverPass.ShadowDecoration.BorderRadius = 10;
            this.BtnRecoverPass.ShadowDecoration.Parent = this.BtnRecoverPass;
            this.BtnRecoverPass.Size = new System.Drawing.Size(900, 60);
            this.BtnRecoverPass.TabIndex = 4;
            this.BtnRecoverPass.Text = "Olvidé mi contraseña";
            this.BtnRecoverPass.Click += new System.EventHandler(this.BtnRecoverPass_Click);
            // 
            // POlvide
            // 
            this.POlvide.BackColor = System.Drawing.Color.White;
            this.POlvide.Controls.Add(this.BtnRecoverPass);
            this.POlvide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.POlvide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.POlvide.Location = new System.Drawing.Point(0, 585);
            this.POlvide.Name = "POlvide";
            this.POlvide.Size = new System.Drawing.Size(1024, 183);
            this.POlvide.TabIndex = 5;
            // 
            // PLogin
            // 
            this.PLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.PLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.PLogin.BorderThickness = 1;
            this.PLogin.Controls.Add(this.BtnLogin);
            this.PLogin.Controls.Add(this.PBUser);
            this.PLogin.Controls.Add(this.BtnChangeUser);
            this.PLogin.Controls.Add(this.TxtUserLogin);
            this.PLogin.Controls.Add(this.TxtPasswordLogin);
            this.PLogin.Controls.Add(this.LblUser);
            this.PLogin.Controls.Add(this.LblPassword);
            this.PLogin.Location = new System.Drawing.Point(0, 0);
            this.PLogin.Name = "PLogin";
            this.PLogin.ShadowDecoration.Parent = this.PLogin;
            this.PLogin.Size = new System.Drawing.Size(400, 762);
            this.PLogin.TabIndex = 10;
            this.PLogin.Visible = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderRadius = 5;
            this.BtnLogin.CheckedState.Parent = this.BtnLogin;
            this.BtnLogin.CustomImages.Parent = this.BtnLogin;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.DisabledState.Parent = this.BtnLogin;
            this.BtnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.BtnLogin.Font = new System.Drawing.Font("Quicksand", 15F);
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.HoverState.Parent = this.BtnLogin;
            this.BtnLogin.Image = global::Punto_De_Venta_Andro.Properties.Resources.Black_LoginIcon;
            this.BtnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnLogin.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnLogin.Location = new System.Drawing.Point(36, 703);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.ShadowDecoration.Parent = this.BtnLogin;
            this.BtnLogin.Size = new System.Drawing.Size(315, 50);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PBUser
            // 
            this.PBUser.BackColor = System.Drawing.Color.Transparent;
            this.PBUser.Image = global::Punto_De_Venta_Andro.Properties.Resources.Man;
            this.PBUser.Location = new System.Drawing.Point(125, 9);
            this.PBUser.Name = "PBUser";
            this.PBUser.Size = new System.Drawing.Size(150, 150);
            this.PBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBUser.TabIndex = 5;
            this.PBUser.TabStop = false;
            // 
            // BtnChangeUser
            // 
            this.BtnChangeUser.BorderRadius = 5;
            this.BtnChangeUser.BorderThickness = 1;
            this.BtnChangeUser.CheckedState.Parent = this.BtnChangeUser;
            this.BtnChangeUser.CustomImages.Parent = this.BtnChangeUser;
            this.BtnChangeUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnChangeUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnChangeUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnChangeUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnChangeUser.DisabledState.Parent = this.BtnChangeUser;
            this.BtnChangeUser.FillColor = System.Drawing.Color.WhiteSmoke;
            this.BtnChangeUser.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.BtnChangeUser.ForeColor = System.Drawing.Color.Black;
            this.BtnChangeUser.HoverState.Parent = this.BtnChangeUser;
            this.BtnChangeUser.Image = global::Punto_De_Venta_Andro.Properties.Resources.Black_ChangeIcon;
            this.BtnChangeUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnChangeUser.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnChangeUser.Location = new System.Drawing.Point(36, 647);
            this.BtnChangeUser.Name = "BtnChangeUser";
            this.BtnChangeUser.ShadowDecoration.Parent = this.BtnChangeUser;
            this.BtnChangeUser.Size = new System.Drawing.Size(315, 50);
            this.BtnChangeUser.TabIndex = 8;
            this.BtnChangeUser.Text = "Cambiar de usuario";
            this.BtnChangeUser.Click += new System.EventHandler(this.BtnChangeUser_Click);
            // 
            // TxtUserLogin
            // 
            this.TxtUserLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.TxtUserLogin.BorderRadius = 5;
            this.TxtUserLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserLogin.DefaultText = "";
            this.TxtUserLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUserLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUserLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserLogin.DisabledState.Parent = this.TxtUserLogin;
            this.TxtUserLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserLogin.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TxtUserLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserLogin.FocusedState.Parent = this.TxtUserLogin;
            this.TxtUserLogin.Font = new System.Drawing.Font("Yu Gothic UI", 15F);
            this.TxtUserLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserLogin.HoverState.Parent = this.TxtUserLogin;
            this.TxtUserLogin.IconLeft = global::Punto_De_Venta_Andro.Properties.Resources.Black_UserIcon;
            this.TxtUserLogin.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TxtUserLogin.Location = new System.Drawing.Point(36, 213);
            this.TxtUserLogin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtUserLogin.Name = "TxtUserLogin";
            this.TxtUserLogin.PasswordChar = '\0';
            this.TxtUserLogin.PlaceholderText = "";
            this.TxtUserLogin.ReadOnly = true;
            this.TxtUserLogin.SelectedText = "";
            this.TxtUserLogin.ShadowDecoration.Parent = this.TxtUserLogin;
            this.TxtUserLogin.Size = new System.Drawing.Size(315, 53);
            this.TxtUserLogin.TabIndex = 7;
            this.TxtUserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPasswordLogin
            // 
            this.TxtPasswordLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.TxtPasswordLogin.BorderRadius = 5;
            this.TxtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPasswordLogin.DefaultText = "";
            this.TxtPasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPasswordLogin.DisabledState.Parent = this.TxtPasswordLogin;
            this.TxtPasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPasswordLogin.FillColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPasswordLogin.FocusedState.Parent = this.TxtPasswordLogin;
            this.TxtPasswordLogin.Font = new System.Drawing.Font("Yu Gothic UI", 15F);
            this.TxtPasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPasswordLogin.HoverState.Parent = this.TxtPasswordLogin;
            this.TxtPasswordLogin.IconLeft = global::Punto_De_Venta_Andro.Properties.Resources.Black_PasswordIcon;
            this.TxtPasswordLogin.IconLeftSize = new System.Drawing.Size(30, 30);
            this.TxtPasswordLogin.Location = new System.Drawing.Point(36, 308);
            this.TxtPasswordLogin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtPasswordLogin.Name = "TxtPasswordLogin";
            this.TxtPasswordLogin.PasswordChar = '\0';
            this.TxtPasswordLogin.PlaceholderText = "";
            this.TxtPasswordLogin.SelectedText = "";
            this.TxtPasswordLogin.ShadowDecoration.Parent = this.TxtPasswordLogin;
            this.TxtPasswordLogin.Size = new System.Drawing.Size(315, 53);
            this.TxtPasswordLogin.TabIndex = 6;
            this.TxtPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPasswordLogin.TextChanged += new System.EventHandler(this.TxtPasswordLogin_TextChanged);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Login_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.PLogin);
            this.Controls.Add(this.POlvide);
            this.Controls.Add(this.FLPLoginUsers);
            this.Controls.Add(this.txtTittle);
            this.Controls.Add(this.PButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_User_Load);
            this.SizeChanged += new System.EventHandler(this.Login_User_SizeChanged);
            this.PButtons.ResumeLayout(false);
            this.PButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSerial)).EndInit();
            this.POlvide.ResumeLayout(false);
            this.PLogin.ResumeLayout(false);
            this.PLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PButtons;
        private System.Windows.Forms.PictureBox PBUser;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserLogin;
        private Guna.UI2.WinForms.Guna2TextBox TxtPasswordLogin;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private Guna.UI2.WinForms.Guna2Button BtnChangeUser;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2DragControl DragPPassword;
        public Guna.UI2.WinForms.Guna2DataGridView DGVUsuarios;
        private Guna.UI2.WinForms.Guna2ImageButton BtnClose;
        private System.Windows.Forms.PictureBox PBLogo;
        private Guna.UI2.WinForms.Guna2Elipse PPasswordRounded;
        private System.Windows.Forms.Panel POlvide;
        private Guna.UI2.WinForms.Guna2Panel PLogin;
        public System.Windows.Forms.Label txtTittle;
        public System.Windows.Forms.FlowLayoutPanel FLPLoginUsers;
        public Guna.UI2.WinForms.Guna2Button BtnRecoverPass;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LblSerial;
        public Guna.UI2.WinForms.Guna2DataGridView DGVSerial;
    }
}