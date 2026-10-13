namespace Cafeteria.UI
{
    partial class UC_Pedidos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Pedidos));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            lblPedido = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtBuscarPlatillo = new Guna.UI2.WinForms.Guna2TextBox();
            dtgvPlatillos = new Guna.UI2.WinForms.Guna2DataGridView();
            btnDetalle = new Guna.UI2.WinForms.Guna2Button();
            btnCancelarPedido = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPlatillos).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel5
            // 
            guna2Panel5.BackColor = Color.FromArgb(242, 232, 225);
            guna2Panel5.Controls.Add(lblPedido);
            guna2Panel5.CustomizableEdges = customizableEdges9;
            guna2Panel5.Location = new Point(-2, -1);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel5.Size = new Size(839, 87);
            guna2Panel5.TabIndex = 9;
            // 
            // lblPedido
            // 
            lblPedido.BackColor = Color.Transparent;
            lblPedido.Font = new Font("Elephant", 23.9999981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPedido.ForeColor = Color.Maroon;
            lblPedido.Location = new Point(201, 20);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(394, 53);
            lblPedido.TabIndex = 1;
            lblPedido.Text = "Registro de pedidos ";
            // 
            // txtBuscarPlatillo
            // 
            txtBuscarPlatillo.BorderColor = Color.Maroon;
            txtBuscarPlatillo.CustomizableEdges = customizableEdges11;
            txtBuscarPlatillo.DefaultText = "Buscar platillos";
            txtBuscarPlatillo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscarPlatillo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscarPlatillo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarPlatillo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarPlatillo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarPlatillo.Font = new Font("Segoe UI", 9F);
            txtBuscarPlatillo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarPlatillo.IconLeft = (Image)resources.GetObject("txtBuscarPlatillo.IconLeft");
            txtBuscarPlatillo.Location = new Point(27, 123);
            txtBuscarPlatillo.Margin = new Padding(3, 4, 3, 4);
            txtBuscarPlatillo.Name = "txtBuscarPlatillo";
            txtBuscarPlatillo.PlaceholderText = "";
            txtBuscarPlatillo.SelectedText = "";
            txtBuscarPlatillo.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtBuscarPlatillo.Size = new Size(264, 45);
            txtBuscarPlatillo.TabIndex = 10;
            // 
            // dtgvPlatillos
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dtgvPlatillos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgvPlatillos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgvPlatillos.ColumnHeadersHeight = 4;
            dtgvPlatillos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtgvPlatillos.DefaultCellStyle = dataGridViewCellStyle6;
            dtgvPlatillos.GridColor = Color.FromArgb(231, 229, 255);
            dtgvPlatillos.Location = new Point(15, 194);
            dtgvPlatillos.Name = "dtgvPlatillos";
            dtgvPlatillos.RowHeadersVisible = false;
            dtgvPlatillos.RowHeadersWidth = 51;
            dtgvPlatillos.Size = new Size(746, 454);
            dtgvPlatillos.TabIndex = 11;
            dtgvPlatillos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dtgvPlatillos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dtgvPlatillos.ThemeStyle.HeaderStyle.Height = 4;
            dtgvPlatillos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dtgvPlatillos.ThemeStyle.RowsStyle.Height = 29;
            // 
            // btnDetalle
            // 
            btnDetalle.BorderRadius = 8;
            btnDetalle.CustomizableEdges = customizableEdges13;
            btnDetalle.DisabledState.BorderColor = Color.DarkGray;
            btnDetalle.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDetalle.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDetalle.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDetalle.FillColor = Color.Maroon;
            btnDetalle.Font = new Font("Segoe UI", 9F);
            btnDetalle.ForeColor = Color.White;
            btnDetalle.Location = new Point(44, 680);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnDetalle.Size = new Size(217, 44);
            btnDetalle.TabIndex = 12;
            btnDetalle.Text = "Agregar nota ";
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.BorderRadius = 8;
            btnCancelarPedido.CustomizableEdges = customizableEdges15;
            btnCancelarPedido.DisabledState.BorderColor = Color.DarkGray;
            btnCancelarPedido.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelarPedido.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelarPedido.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelarPedido.FillColor = Color.Maroon;
            btnCancelarPedido.Font = new Font("Segoe UI", 9F);
            btnCancelarPedido.ForeColor = Color.White;
            btnCancelarPedido.Location = new Point(446, 671);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnCancelarPedido.Size = new Size(178, 44);
            btnCancelarPedido.TabIndex = 13;
            btnCancelarPedido.Text = "Cancelar pedido";
            // 
            // UC_Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancelarPedido);
            Controls.Add(btnDetalle);
            Controls.Add(dtgvPlatillos);
            Controls.Add(txtBuscarPlatillo);
            Controls.Add(guna2Panel5);
            Name = "UC_Pedidos";
            Size = new Size(826, 756);
            guna2Panel5.ResumeLayout(false);
            guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPlatillos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPedido;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarPlatillo;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvPlatillos;
        private Guna.UI2.WinForms.Guna2Button btnDetalle;
        private Guna.UI2.WinForms.Guna2Button btnCancelarPedido;
    }
}
