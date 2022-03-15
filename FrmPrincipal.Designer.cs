namespace Arduino_doppler
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.gpSerial = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nVelMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetSensibilidade = new System.Windows.Forms.Button();
            this.nSensibilidadeDpp = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviaSensibilidadeDpp = new System.Windows.Forms.Button();
            this.gpInfo.SuspendLayout();
            this.gpSerial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVelMax)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSensibilidadeDpp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.BackColor = System.Drawing.Color.DarkGray;
            this.btnOpenSerial.FlatAppearance.BorderSize = 0;
            this.btnOpenSerial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerial.Location = new System.Drawing.Point(22, 106);
            this.btnOpenSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(146, 64);
            this.btnOpenSerial.TabIndex = 0;
            this.btnOpenSerial.Text = "OpenSerial";
            this.btnOpenSerial.UseVisualStyleBackColor = false;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // gpInfo
            // 
            this.gpInfo.Controls.Add(this.txtLog);
            this.gpInfo.Location = new System.Drawing.Point(14, 224);
            this.gpInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpInfo.Size = new System.Drawing.Size(574, 241);
            this.gpInfo.TabIndex = 1;
            this.gpInfo.TabStop = false;
            this.gpInfo.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.ForeColor = System.Drawing.Color.Lime;
            this.txtLog.Location = new System.Drawing.Point(4, 24);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(566, 212);
            this.txtLog.TabIndex = 2;
            this.txtLog.DoubleClick += new System.EventHandler(this.txtLog_DoubleClick);
            // 
            // gpSerial
            // 
            this.gpSerial.Controls.Add(this.btnOpenSerial);
            this.gpSerial.Controls.Add(this.label1);
            this.gpSerial.Controls.Add(this.cbxPorts);
            this.gpSerial.Location = new System.Drawing.Point(13, 18);
            this.gpSerial.Name = "gpSerial";
            this.gpSerial.Size = new System.Drawing.Size(190, 209);
            this.gpSerial.TabIndex = 2;
            this.gpSerial.TabStop = false;
            this.gpSerial.Text = "Serial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Porta Serial:";
            // 
            // cbxPorts
            // 
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(22, 68);
            this.cbxPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(146, 28);
            this.cbxPorts.TabIndex = 0;
            this.cbxPorts.DropDown += new System.EventHandler(this.cbxPorts_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nVelMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSendCmd);
            this.groupBox1.Location = new System.Drawing.Point(209, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comando Arduino";
            // 
            // nVelMax
            // 
            this.nVelMax.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nVelMax.Location = new System.Drawing.Point(59, 69);
            this.nVelMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nVelMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nVelMax.Name = "nVelMax";
            this.nVelMax.Size = new System.Drawing.Size(64, 26);
            this.nVelMax.TabIndex = 5;
            this.nVelMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Velocidade Máxima:";
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.BackColor = System.Drawing.Color.DarkGray;
            this.btnSendCmd.Enabled = false;
            this.btnSendCmd.FlatAppearance.BorderSize = 0;
            this.btnSendCmd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSendCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCmd.Location = new System.Drawing.Point(20, 106);
            this.btnSendCmd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(146, 64);
            this.btnSendCmd.TabIndex = 2;
            this.btnSendCmd.Text = "Envia Velocidade";
            this.btnSendCmd.UseVisualStyleBackColor = false;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 17);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetSensibilidade);
            this.groupBox2.Controls.Add(this.nSensibilidadeDpp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnEnviaSensibilidadeDpp);
            this.groupBox2.Location = new System.Drawing.Point(406, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 209);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comando Doppler";
            // 
            // btnGetSensibilidade
            // 
            this.btnGetSensibilidade.BackColor = System.Drawing.Color.DarkGray;
            this.btnGetSensibilidade.Enabled = false;
            this.btnGetSensibilidade.FlatAppearance.BorderSize = 0;
            this.btnGetSensibilidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGetSensibilidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSensibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSensibilidade.Location = new System.Drawing.Point(20, 144);
            this.btnGetSensibilidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetSensibilidade.Name = "btnGetSensibilidade";
            this.btnGetSensibilidade.Size = new System.Drawing.Size(146, 50);
            this.btnGetSensibilidade.TabIndex = 6;
            this.btnGetSensibilidade.Text = "Checa Sensibilidade";
            this.btnGetSensibilidade.UseVisualStyleBackColor = false;
            this.btnGetSensibilidade.Click += new System.EventHandler(this.btnGetSensibilidade_Click);
            // 
            // nSensibilidadeDpp
            // 
            this.nSensibilidadeDpp.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nSensibilidadeDpp.Location = new System.Drawing.Point(59, 61);
            this.nSensibilidadeDpp.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nSensibilidadeDpp.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nSensibilidadeDpp.Name = "nSensibilidadeDpp";
            this.nSensibilidadeDpp.Size = new System.Drawing.Size(64, 26);
            this.nSensibilidadeDpp.TabIndex = 5;
            this.nSensibilidadeDpp.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sensibilidade:";
            // 
            // btnEnviaSensibilidadeDpp
            // 
            this.btnEnviaSensibilidadeDpp.BackColor = System.Drawing.Color.DarkGray;
            this.btnEnviaSensibilidadeDpp.Enabled = false;
            this.btnEnviaSensibilidadeDpp.FlatAppearance.BorderSize = 0;
            this.btnEnviaSensibilidadeDpp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEnviaSensibilidadeDpp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviaSensibilidadeDpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviaSensibilidadeDpp.Location = new System.Drawing.Point(20, 95);
            this.btnEnviaSensibilidadeDpp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnviaSensibilidadeDpp.Name = "btnEnviaSensibilidadeDpp";
            this.btnEnviaSensibilidadeDpp.Size = new System.Drawing.Size(146, 39);
            this.btnEnviaSensibilidadeDpp.TabIndex = 2;
            this.btnEnviaSensibilidadeDpp.Text = "Envia Sensibilidade";
            this.btnEnviaSensibilidadeDpp.UseVisualStyleBackColor = false;
            this.btnEnviaSensibilidadeDpp.Click += new System.EventHandler(this.btnEnviaSensibilidadeDpp_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpSerial);
            this.Controls.Add(this.gpInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 522);
            this.MinimumSize = new System.Drawing.Size(616, 522);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Doppler 1.0.0";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.gpSerial.ResumeLayout(false);
            this.gpSerial.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVelMax)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSensibilidadeDpp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPorts;
        private System.Windows.Forms.GroupBox gpSerial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nVelMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nSensibilidadeDpp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviaSensibilidadeDpp;
        private System.Windows.Forms.Button btnGetSensibilidade;
    }
}

