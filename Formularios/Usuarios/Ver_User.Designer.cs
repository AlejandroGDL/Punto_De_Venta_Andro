
namespace Punto_De_Venta_Andro
{
    partial class Ver_User
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_User));
            this.Users = new System.Windows.Forms.Panel();
            this.DGVUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.TxtSearchUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRegresar = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.TimerReloadUsers = new System.Windows.Forms.Timer(this.components);
            this.Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Users.BackColor = System.Drawing.Color.White;
            this.Users.Controls.Add(this.DGVUsuarios);
            this.Users.Controls.Add(this.guna2ShadowPanel1);
            this.Users.Location = new System.Drawing.Point(12, 12);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Users.Size = new System.Drawing.Size(1342, 744);
            this.Users.TabIndex = 0;
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DGVUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Quicksand", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVUsuarios.ColumnHeadersHeight = 40;
            this.DGVUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUsuarios.EnableHeadersVisualStyles = false;
            this.DGVUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUsuarios.Location = new System.Drawing.Point(0, 63);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVUsuarios.RowHeadersVisible = false;
            this.DGVUsuarios.RowTemplate.Height = 50;
            this.DGVUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsuarios.Size = new System.Drawing.Size(1342, 661);
            this.DGVUsuarios.TabIndex = 1;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVUsuarios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Quicksand", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVUsuarios.ThemeStyle.HeaderStyle.Height = 40;
            this.DGVUsuarios.ThemeStyle.ReadOnly = true;
            this.DGVUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVUsuarios.ThemeStyle.RowsStyle.Height = 50;
            this.DGVUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsuarios_CellClick);
            this.DGVUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsuarios_CellDoubleClick);
            // 
            // Eliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Eliminar.FillWeight = 10F;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::Punto_De_Venta_Andro.Properties.Resources.Colored_TrashIcon;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Controls.Add(this.TxtSearchUser);
            this.guna2ShadowPanel1.Controls.Add(this.BtnAddUser);
            this.guna2ShadowPanel1.Controls.Add(this.BtnRegresar);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 10;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1342, 63);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // TxtSearchUser
            // 
            this.TxtSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearchUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.TxtSearchUser.BorderRadius = 5;
            this.TxtSearchUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearchUser.DefaultText = "";
            this.TxtSearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchUser.DisabledState.Parent = this.TxtSearchUser;
            this.TxtSearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearchUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchUser.FocusedState.Parent = this.TxtSearchUser;
            this.TxtSearchUser.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearchUser.HoverState.Parent = this.TxtSearchUser;
            this.TxtSearchUser.IconLeft = global::Punto_De_Venta_Andro.Properties.Resources.Colored_SearchIcon;
            this.TxtSearchUser.Location = new System.Drawing.Point(707, 6);
            this.TxtSearchUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TxtSearchUser.MaximumSize = new System.Drawing.Size(606, 42);
            this.TxtSearchUser.Name = "TxtSearchUser";
            this.TxtSearchUser.PasswordChar = '\0';
            this.TxtSearchUser.PlaceholderText = "Escribir el nombre del usuario";
            this.TxtSearchUser.SelectedText = "";
            this.TxtSearchUser.ShadowDecoration.Parent = this.TxtSearchUser;
            this.TxtSearchUser.Size = new System.Drawing.Size(606, 42);
            this.TxtSearchUser.TabIndex = 1;
            this.TxtSearchUser.TextChanged += new System.EventHandler(this.TxtSearchUser_TextChanged);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAddUser.AutoRoundedCorners = true;
            this.BtnAddUser.BorderRadius = 21;
            this.BtnAddUser.CheckedState.Parent = this.BtnAddUser;
            this.BtnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddUser.CustomImages.Parent = this.BtnAddUser;
            this.BtnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddUser.DisabledState.Parent = this.BtnAddUser;
            this.BtnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(97)))), ((int)(((byte)(255)))));
            this.BtnAddUser.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.ForeColor = System.Drawing.Color.White;
            this.BtnAddUser.HoverState.Parent = this.BtnAddUser;
            this.BtnAddUser.Image = global::Punto_De_Venta_Andro.Properties.Resources.Colored_AddUserIcon;
            this.BtnAddUser.Location = new System.Drawing.Point(186, 3);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.ShadowDecoration.Parent = this.BtnAddUser;
            this.BtnAddUser.Size = new System.Drawing.Size(200, 45);
            this.BtnAddUser.TabIndex = 0;
            this.BtnAddUser.Text = "Agregar Usuario";
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRegresar.AutoRoundedCorners = true;
            this.BtnRegresar.BorderRadius = 21;
            this.BtnRegresar.CheckedState.Parent = this.BtnRegresar;
            this.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegresar.CustomImages.Parent = this.BtnRegresar;
            this.BtnRegresar.CustomizableEdges.BottomLeft = false;
            this.BtnRegresar.CustomizableEdges.TopLeft = false;
            this.BtnRegresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRegresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRegresar.DisabledState.Parent = this.BtnRegresar;
            this.BtnRegresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnRegresar.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.HoverState.Parent = this.BtnRegresar;
            this.BtnRegresar.Image = global::Punto_De_Venta_Andro.Properties.Resources.Colored_ReturnIcon;
            this.BtnRegresar.Location = new System.Drawing.Point(0, 3);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.ShadowDecoration.Parent = this.BtnRegresar;
            this.BtnRegresar.Size = new System.Drawing.Size(180, 45);
            this.BtnRegresar.TabIndex = 0;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 20F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Punto_De_Venta_Andro.Properties.Resources.Colored_TrashIcon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 1342;
            // 
            // TimerReloadUsers
            // 
            this.TimerReloadUsers.Interval = 3000;
            this.TimerReloadUsers.Tick += new System.EventHandler(this.TimerReloadUsers_Tick);
            // 
            // Ver_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ver_User_Load);
            this.Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Users;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button BtnRegresar;
        private Guna.UI2.WinForms.Guna2Button BtnAddUser;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public Guna.UI2.WinForms.Guna2DataGridView DGVUsuarios;
        private System.Windows.Forms.Timer TimerReloadUsers;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        public Guna.UI2.WinForms.Guna2TextBox TxtSearchUser;
    }
}

