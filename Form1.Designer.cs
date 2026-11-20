namespace Examen_RentCar_Wilson
{
    partial class Form1
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
            txtCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkCorporativo = new CheckBox();
            label3 = new Label();
            dtpSalida = new DateTimePicker();
            label4 = new Label();
            txtVehiculo = new TextBox();
            label5 = new Label();
            txtTarifa = new TextBox();
            label6 = new Label();
            nudDias = new NumericUpDown();
            groupBox1 = new GroupBox();
            rbtCompleto = new RadioButton();
            rbtBasico = new RadioButton();
            groupBox2 = new GroupBox();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            chkGps = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            lblEncabezado = new Label();
            lstAlquileres = new ListBox();
            label8 = new Label();
            label9 = new Label();
            LBLSubtotal = new TextBox();
            label10 = new Label();
            lblDescuento = new TextBox();
            labelname = new Label();
            lblDomicilio = new TextBox();
            lbllabel = new Label();
            lblItbis = new TextBox();
            label11 = new Label();
            lblTotal = new TextBox();
            label7 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(76, 9);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(144, 27);
            txtCliente.TabIndex = 0;
            txtCliente.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 63);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(22, 42);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(158, 24);
            chkCorporativo.TabIndex = 3;
            chkCorporativo.Text = "Cliente corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 83);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Salida:";
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(69, 83);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(250, 27);
            dtpSalida.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 139);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "Vehiculo:";
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(76, 136);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(125, 27);
            txtVehiculo.TabIndex = 7;
            txtVehiculo.Text = "Sedan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 182);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 8;
            label5.Text = "Tarifa:";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(63, 182);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(125, 27);
            txtTarifa.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 227);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 10;
            label6.Text = "Dias:";
            // 
            // nudDias
            // 
            nudDias.Location = new Point(62, 229);
            nudDias.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(150, 27);
            nudDias.TabIndex = 11;
            nudDias.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtCompleto);
            groupBox1.Controls.Add(rbtBasico);
            groupBox1.Location = new Point(10, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 125);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro";
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Location = new Point(4, 57);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(168, 24);
            rbtCompleto.TabIndex = 1;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo(+RD$300)";
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Location = new Point(3, 26);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(73, 24);
            rbtBasico.TabIndex = 0;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtDomicilio);
            groupBox2.Controls.Add(rbtSucursal);
            groupBox2.Location = new Point(226, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Entrega";
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Location = new Point(4, 59);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(171, 24);
            rbtDomicilio.TabIndex = 1;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio (+RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Location = new Point(6, 26);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(108, 24);
            rbtSucursal.TabIndex = 0;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = " En Sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(10, 412);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(185, 24);
            chkGps.TabIndex = 14;
            chkGps.Text = "GPS (+RD$100 por dia)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(22, 460);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(130, 45);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(158, 460);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(138, 45);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Nuevo Alquiler";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(302, 460);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 42);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(606, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(246, 54);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar al alquiler";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEncabezado.Location = new Point(606, 83);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(45, 20);
            lblEncabezado.TabIndex = 19;
            lblEncabezado.Text = "Dias";
            // 
            // lstAlquileres
            // 
            lstAlquileres.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(606, 106);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(347, 124);
            lstAlquileres.TabIndex = 20;
            lstAlquileres.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(661, 83);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 21;
            label8.Text = "Vehiculo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(589, 252);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 22;
            label9.Text = "subtotal:";
            // 
            // LBLSubtotal
            // 
            LBLSubtotal.Location = new Point(661, 249);
            LBLSubtotal.Name = "LBLSubtotal";
            LBLSubtotal.Size = new Size(125, 27);
            LBLSubtotal.TabIndex = 23;
            LBLSubtotal.Text = "RD$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(576, 286);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 24;
            label10.Text = "Descuento:";
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(661, 283);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(125, 27);
            lblDescuento.TabIndex = 25;
            lblDescuento.Text = "RD$";
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(578, 315);
            labelname.Name = "labelname";
            labelname.Size = new Size(77, 20);
            labelname.TabIndex = 26;
            labelname.Text = "Domicilio:";
            // 
            // lblDomicilio
            // 
            lblDomicilio.Location = new Point(661, 312);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(125, 27);
            lblDomicilio.TabIndex = 27;
            lblDomicilio.Text = "RD$";
            // 
            // lbllabel
            // 
            lbllabel.AutoSize = true;
            lbllabel.Location = new Point(576, 345);
            lbllabel.Name = "lbllabel";
            lbllabel.Size = new Size(80, 20);
            lbllabel.TabIndex = 28;
            lbllabel.Text = "ITBIS(18%)";
            // 
            // lblItbis
            // 
            lblItbis.Location = new Point(661, 345);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(125, 27);
            lblItbis.TabIndex = 29;
            lblItbis.Text = "RD$";
            lblItbis.TextChanged += lblItbis_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(556, 402);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 30;
            label11.Text = "TOTAL A PAGAR";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(676, 399);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(125, 27);
            lblTotal.TabIndex = 31;
            lblTotal.Text = "RD$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(813, 81);
            label7.Name = "label7";
            label7.Size = new Size(50, 23);
            label7.TabIndex = 32;
            label7.Text = "Tarifa";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(885, 83);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 33;
            label12.Text = "Total";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 517);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(lblTotal);
            Controls.Add(label11);
            Controls.Add(lblItbis);
            Controls.Add(lbllabel);
            Controls.Add(lblDomicilio);
            Controls.Add(labelname);
            Controls.Add(lblDescuento);
            Controls.Add(label10);
            Controls.Add(LBLSubtotal);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lstAlquileres);
            Controls.Add(lblEncabezado);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkGps);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(nudDias);
            Controls.Add(label6);
            Controls.Add(txtTarifa);
            Controls.Add(label5);
            Controls.Add(txtVehiculo);
            Controls.Add(label4);
            Controls.Add(dtpSalida);
            Controls.Add(label3);
            Controls.Add(chkCorporativo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCliente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private Label label1;
        private Label label2;
        private CheckBox chkCorporativo;
        private Label label3;
        private DateTimePicker dtpSalida;
        private Label label4;
        private TextBox txtVehiculo;
        private Label label5;
        private TextBox txtTarifa;
        private Label label6;
        private NumericUpDown nudDias;
        private GroupBox groupBox1;
        private RadioButton rbtCompleto;
        private RadioButton rbtBasico;
        private GroupBox groupBox2;
        private RadioButton rbtSucursal;
        private CheckBox chkGps;
        private RadioButton rbtDomicilio;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private Label lblEncabezado;
        private ListBox lstAlquileres;
        private Label label8;
        private Label label9;
        private TextBox LBLSubtotal;
        private Label label10;
        private TextBox lblDescuento;
        private Label labelname;
        private TextBox lblDomicilio;
        private Label lbllabel;
        private TextBox lblItbis;
        private Label label11;
        private TextBox lblTotal;
        private Label label7;
        private Label label12;
    }
}
