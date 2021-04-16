
namespace reproductorcampos
{
    partial class Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonplay = new System.Windows.Forms.Button();
            this.buttonpausa = new System.Windows.Forms.Button();
            this.buttonsiguiente = new System.Windows.Forms.Button();
            this.buttonanterior = new System.Windows.Forms.Button();
            this.buttonstop = new System.Windows.Forms.Button();
            this.CANCIONES = new System.Windows.Forms.ListBox();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonagregar = new System.Windows.Forms.Button();
            this.volumen = new XComponent.SliderBar.MACTrackBar();
            this.minutero = new XComponent.SliderBar.MACTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time1 = new System.Windows.Forms.Label();
            this.btnvolumen = new System.Windows.Forms.Button();
            this.labelvolumen = new System.Windows.Forms.Label();
            this.buttonaleatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(546, 126);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(292, 120);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // buttonplay
            // 
            this.buttonplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonplay.BackgroundImage")));
            this.buttonplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonplay.Location = new System.Drawing.Point(620, 200);
            this.buttonplay.Name = "buttonplay";
            this.buttonplay.Size = new System.Drawing.Size(73, 46);
            this.buttonplay.TabIndex = 2;
            this.buttonplay.UseVisualStyleBackColor = true;
            this.buttonplay.Click += new System.EventHandler(this.buttonplay_Click);
            // 
            // buttonpausa
            // 
            this.buttonpausa.BackgroundImage = global::reproductorcampos.Properties.Resources.botonpausa;
            this.buttonpausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonpausa.Location = new System.Drawing.Point(654, 74);
            this.buttonpausa.Name = "buttonpausa";
            this.buttonpausa.Size = new System.Drawing.Size(76, 46);
            this.buttonpausa.TabIndex = 3;
            this.buttonpausa.UseVisualStyleBackColor = true;
            this.buttonpausa.Click += new System.EventHandler(this.buttonpausa_Click);
            // 
            // buttonsiguiente
            // 
            this.buttonsiguiente.BackgroundImage = global::reproductorcampos.Properties.Resources.botonsiguiente;
            this.buttonsiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonsiguiente.Location = new System.Drawing.Point(764, 200);
            this.buttonsiguiente.Name = "buttonsiguiente";
            this.buttonsiguiente.Size = new System.Drawing.Size(73, 46);
            this.buttonsiguiente.TabIndex = 4;
            this.buttonsiguiente.UseVisualStyleBackColor = true;
            this.buttonsiguiente.Click += new System.EventHandler(this.buttonsiguiente_Click);
            // 
            // buttonanterior
            // 
            this.buttonanterior.BackgroundImage = global::reproductorcampos.Properties.Resources.botonanterior;
            this.buttonanterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonanterior.Location = new System.Drawing.Point(547, 200);
            this.buttonanterior.Name = "buttonanterior";
            this.buttonanterior.Size = new System.Drawing.Size(73, 46);
            this.buttonanterior.TabIndex = 5;
            this.buttonanterior.UseVisualStyleBackColor = true;
            this.buttonanterior.Click += new System.EventHandler(this.buttonanterior_Click);
            // 
            // buttonstop
            // 
            this.buttonstop.BackgroundImage = global::reproductorcampos.Properties.Resources.botonstop;
            this.buttonstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonstop.Location = new System.Drawing.Point(692, 200);
            this.buttonstop.Name = "buttonstop";
            this.buttonstop.Size = new System.Drawing.Size(73, 46);
            this.buttonstop.TabIndex = 6;
            this.buttonstop.UseVisualStyleBackColor = true;
            this.buttonstop.Click += new System.EventHandler(this.buttonstop_Click);
            // 
            // CANCIONES
            // 
            this.CANCIONES.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CANCIONES.FormattingEnabled = true;
            this.CANCIONES.Location = new System.Drawing.Point(511, 312);
            this.CANCIONES.Name = "CANCIONES";
            this.CANCIONES.Size = new System.Drawing.Size(375, 381);
            this.CANCIONES.TabIndex = 7;
            this.CANCIONES.SelectedIndexChanged += new System.EventHandler(this.CANCIONES_SelectedIndexChanged);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttoneliminar.BackgroundImage")));
            this.buttoneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttoneliminar.Location = new System.Drawing.Point(406, 335);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(70, 70);
            this.buttoneliminar.TabIndex = 8;
            this.buttoneliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonagregar
            // 
            this.buttonagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonagregar.BackgroundImage")));
            this.buttonagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonagregar.Location = new System.Drawing.Point(929, 335);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(70, 70);
            this.buttonagregar.TabIndex = 9;
            this.buttonagregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonagregar.UseVisualStyleBackColor = true;
            this.buttonagregar.Click += new System.EventHandler(this.buttonagregar_Click);
            // 
            // volumen
            // 
            this.volumen.BackColor = System.Drawing.Color.Transparent;
            this.volumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.volumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.volumen.IndentHeight = 6;
            this.volumen.Location = new System.Drawing.Point(861, 205);
            this.volumen.Maximum = 100;
            this.volumen.Minimum = 0;
            this.volumen.Name = "volumen";
            this.volumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumen.Size = new System.Drawing.Size(28, 75);
            this.volumen.TabIndex = 10;
            this.volumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.volumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.volumen.TickHeight = 4;
            this.volumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumen.TrackerColor = System.Drawing.Color.Yellow;
            this.volumen.TrackerSize = new System.Drawing.Size(10, 16);
            this.volumen.TrackLineColor = System.Drawing.Color.Lime;
            this.volumen.TrackLineHeight = 3;
            this.volumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.volumen.Value = 0;
            this.volumen.Visible = false;
            this.volumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.volumen_ValueChanged);
            this.volumen.MouseLeave += new System.EventHandler(this.volumen_MouseLeave);
            // 
            // minutero
            // 
            this.minutero.BackColor = System.Drawing.Color.Transparent;
            this.minutero.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.minutero.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.minutero.IndentHeight = 6;
            this.minutero.Location = new System.Drawing.Point(505, 252);
            this.minutero.Maximum = 100;
            this.minutero.Minimum = 0;
            this.minutero.Name = "minutero";
            this.minutero.Size = new System.Drawing.Size(362, 28);
            this.minutero.TabIndex = 11;
            this.minutero.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.minutero.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.minutero.TickHeight = 4;
            this.minutero.TickStyle = System.Windows.Forms.TickStyle.None;
            this.minutero.TrackerColor = System.Drawing.Color.Yellow;
            this.minutero.TrackerSize = new System.Drawing.Size(10, 16);
            this.minutero.TrackLineColor = System.Drawing.Color.Lime;
            this.minutero.TrackLineHeight = 3;
            this.minutero.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.minutero.Value = 0;
            this.minutero.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar2_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.BackColor = System.Drawing.SystemColors.Window;
            this.time1.Location = new System.Drawing.Point(508, 283);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(28, 13);
            this.time1.TabIndex = 15;
            this.time1.Text = "0:00";
            this.time1.Click += new System.EventHandler(this.time1_Click);
            // 
            // btnvolumen
            // 
            this.btnvolumen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvolumen.BackgroundImage")));
            this.btnvolumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvolumen.Location = new System.Drawing.Point(859, 280);
            this.btnvolumen.Name = "btnvolumen";
            this.btnvolumen.Size = new System.Drawing.Size(32, 26);
            this.btnvolumen.TabIndex = 16;
            this.btnvolumen.UseVisualStyleBackColor = true;
            this.btnvolumen.Click += new System.EventHandler(this.btnvolumen_Click);
            // 
            // labelvolumen
            // 
            this.labelvolumen.AutoSize = true;
            this.labelvolumen.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelvolumen.Location = new System.Drawing.Point(897, 283);
            this.labelvolumen.Name = "labelvolumen";
            this.labelvolumen.Size = new System.Drawing.Size(13, 13);
            this.labelvolumen.TabIndex = 17;
            this.labelvolumen.Text = "0";
            // 
            // buttonaleatorio
            // 
            this.buttonaleatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonaleatorio.BackgroundImage")));
            this.buttonaleatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonaleatorio.Location = new System.Drawing.Point(666, 22);
            this.buttonaleatorio.Name = "buttonaleatorio";
            this.buttonaleatorio.Size = new System.Drawing.Size(52, 46);
            this.buttonaleatorio.TabIndex = 18;
            this.buttonaleatorio.UseVisualStyleBackColor = true;
            this.buttonaleatorio.Click += new System.EventHandler(this.buttonaleatorio_Click);
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.buttonaleatorio);
            this.Controls.Add(this.labelvolumen);
            this.Controls.Add(this.btnvolumen);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.minutero);
            this.Controls.Add(this.volumen);
            this.Controls.Add(this.buttonagregar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.CANCIONES);
            this.Controls.Add(this.buttonstop);
            this.Controls.Add(this.buttonanterior);
            this.Controls.Add(this.buttonsiguiente);
            this.Controls.Add(this.buttonplay);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonpausa);
            this.Name = "Reproductor";
            this.Text = "ReproductorCampos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonplay;
        private System.Windows.Forms.Button buttonpausa;
        private System.Windows.Forms.Button buttonsiguiente;
        private System.Windows.Forms.Button buttonanterior;
        private System.Windows.Forms.Button buttonstop;
        private System.Windows.Forms.ListBox CANCIONES;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonagregar;
        private XComponent.SliderBar.MACTrackBar volumen;
        private XComponent.SliderBar.MACTrackBar minutero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Button btnvolumen;
        private System.Windows.Forms.Label labelvolumen;
        private System.Windows.Forms.Button buttonaleatorio;
    }
}

