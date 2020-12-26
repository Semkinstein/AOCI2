namespace AOCI1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.buttonChannel = new System.Windows.Forms.Button();
            this.buttonBW = new System.Windows.Forms.Button();
            this.buttonSepia = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonIntersect = new System.Windows.Forms.Button();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.trackBarSat = new System.Windows.Forms.TrackBar();
            this.trackBarValue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBlur = new System.Windows.Forms.Button();
            this.buttonSharpen = new System.Windows.Forms.Button();
            this.buttonAquarel = new System.Windows.Forms.Button();
            this.buttonCartoon = new System.Windows.Forms.Button();
            this.trackBarCoeff = new System.Windows.Forms.TrackBar();
            this.trackBarCartoon = new System.Windows.Forms.TrackBar();
            this.buttonEmbos = new System.Windows.Forms.Button();
            this.buttonEdges = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCartoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(500, 500);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(627, 0);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(500, 500);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Location = new System.Drawing.Point(506, 42);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(33, 17);
            this.radioButtonR.TabIndex = 4;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "R";
            this.radioButtonR.UseVisualStyleBackColor = true;
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(545, 42);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(33, 17);
            this.radioButtonG.TabIndex = 5;
            this.radioButtonG.TabStop = true;
            this.radioButtonG.Text = "G";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(584, 42);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 6;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // buttonChannel
            // 
            this.buttonChannel.Location = new System.Drawing.Point(506, 65);
            this.buttonChannel.Name = "buttonChannel";
            this.buttonChannel.Size = new System.Drawing.Size(115, 23);
            this.buttonChannel.TabIndex = 7;
            this.buttonChannel.Text = "Channel";
            this.buttonChannel.UseVisualStyleBackColor = true;
            this.buttonChannel.Click += new System.EventHandler(this.buttonChannel_Click);
            // 
            // buttonBW
            // 
            this.buttonBW.Location = new System.Drawing.Point(506, 94);
            this.buttonBW.Name = "buttonBW";
            this.buttonBW.Size = new System.Drawing.Size(115, 23);
            this.buttonBW.TabIndex = 8;
            this.buttonBW.Text = "Black and white";
            this.buttonBW.UseVisualStyleBackColor = true;
            this.buttonBW.Click += new System.EventHandler(this.buttonBW_Click);
            // 
            // buttonSepia
            // 
            this.buttonSepia.Location = new System.Drawing.Point(506, 123);
            this.buttonSepia.Name = "buttonSepia";
            this.buttonSepia.Size = new System.Drawing.Size(115, 23);
            this.buttonSepia.TabIndex = 9;
            this.buttonSepia.Text = "Sepia";
            this.buttonSepia.UseVisualStyleBackColor = true;
            this.buttonSepia.Click += new System.EventHandler(this.buttonSepia_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(506, 152);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(506, 181);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(115, 23);
            this.buttonSub.TabIndex = 11;
            this.buttonSub.Text = "Exception";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonIntersect
            // 
            this.buttonIntersect.Location = new System.Drawing.Point(506, 210);
            this.buttonIntersect.Name = "buttonIntersect";
            this.buttonIntersect.Size = new System.Drawing.Size(115, 23);
            this.buttonIntersect.TabIndex = 12;
            this.buttonIntersect.Text = "Intersect";
            this.buttonIntersect.UseVisualStyleBackColor = true;
            this.buttonIntersect.Click += new System.EventHandler(this.buttonIntersect_Click);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(506, 239);
            this.trackBarBrightness.Minimum = -10;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(115, 45);
            this.trackBarBrightness.TabIndex = 13;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.LargeChange = 1;
            this.trackBarContrast.Location = new System.Drawing.Point(506, 290);
            this.trackBarContrast.Maximum = 5;
            this.trackBarContrast.Minimum = 1;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(115, 45);
            this.trackBarContrast.TabIndex = 14;
            this.trackBarContrast.Value = 1;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Contrast";
            // 
            // trackBarHue
            // 
            this.trackBarHue.Location = new System.Drawing.Point(506, 338);
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(115, 45);
            this.trackBarHue.TabIndex = 17;
            this.trackBarHue.Value = 5;
            this.trackBarHue.Scroll += new System.EventHandler(this.trackBarHue_Scroll);
            // 
            // trackBarSat
            // 
            this.trackBarSat.Location = new System.Drawing.Point(506, 389);
            this.trackBarSat.Name = "trackBarSat";
            this.trackBarSat.Size = new System.Drawing.Size(104, 45);
            this.trackBarSat.TabIndex = 18;
            this.trackBarSat.Value = 5;
            this.trackBarSat.Scroll += new System.EventHandler(this.trackBarSat_Scroll);
            // 
            // trackBarValue
            // 
            this.trackBarValue.Location = new System.Drawing.Point(506, 440);
            this.trackBarValue.Name = "trackBarValue";
            this.trackBarValue.Size = new System.Drawing.Size(104, 45);
            this.trackBarValue.TabIndex = 19;
            this.trackBarValue.Value = 5;
            this.trackBarValue.Scroll += new System.EventHandler(this.trackBarValue_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Saturation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Value";
            // 
            // buttonBlur
            // 
            this.buttonBlur.Location = new System.Drawing.Point(507, 492);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(114, 23);
            this.buttonBlur.TabIndex = 23;
            this.buttonBlur.Text = "Blur";
            this.buttonBlur.UseVisualStyleBackColor = true;
            this.buttonBlur.Click += new System.EventHandler(this.buttonBlur_Click);
            // 
            // buttonSharpen
            // 
            this.buttonSharpen.Location = new System.Drawing.Point(506, 521);
            this.buttonSharpen.Name = "buttonSharpen";
            this.buttonSharpen.Size = new System.Drawing.Size(114, 23);
            this.buttonSharpen.TabIndex = 24;
            this.buttonSharpen.Text = "Sharpen";
            this.buttonSharpen.UseVisualStyleBackColor = true;
            this.buttonSharpen.Click += new System.EventHandler(this.buttonSharpen_Click);
            // 
            // buttonAquarel
            // 
            this.buttonAquarel.Location = new System.Drawing.Point(506, 551);
            this.buttonAquarel.Name = "buttonAquarel";
            this.buttonAquarel.Size = new System.Drawing.Size(114, 23);
            this.buttonAquarel.TabIndex = 25;
            this.buttonAquarel.Text = "Aquarel";
            this.buttonAquarel.UseVisualStyleBackColor = true;
            this.buttonAquarel.Click += new System.EventHandler(this.buttonAquarel_Click);
            // 
            // buttonCartoon
            // 
            this.buttonCartoon.Location = new System.Drawing.Point(506, 581);
            this.buttonCartoon.Name = "buttonCartoon";
            this.buttonCartoon.Size = new System.Drawing.Size(115, 23);
            this.buttonCartoon.TabIndex = 26;
            this.buttonCartoon.Text = "Cartoon";
            this.buttonCartoon.UseVisualStyleBackColor = true;
            this.buttonCartoon.Click += new System.EventHandler(this.buttonCartoon_Click);
            // 
            // trackBarCoeff
            // 
            this.trackBarCoeff.LargeChange = 1;
            this.trackBarCoeff.Location = new System.Drawing.Point(627, 551);
            this.trackBarCoeff.Name = "trackBarCoeff";
            this.trackBarCoeff.Size = new System.Drawing.Size(104, 45);
            this.trackBarCoeff.TabIndex = 27;
            this.trackBarCoeff.Value = 5;
            this.trackBarCoeff.Scroll += new System.EventHandler(this.trackBarCoeff_Scroll);
            // 
            // trackBarCartoon
            // 
            this.trackBarCartoon.LargeChange = 1;
            this.trackBarCartoon.Location = new System.Drawing.Point(628, 581);
            this.trackBarCartoon.Name = "trackBarCartoon";
            this.trackBarCartoon.Size = new System.Drawing.Size(104, 45);
            this.trackBarCartoon.TabIndex = 28;
            this.trackBarCartoon.Value = 5;
            this.trackBarCartoon.Scroll += new System.EventHandler(this.trackBarCartoon_Scroll);
            // 
            // buttonEmbos
            // 
            this.buttonEmbos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEmbos.Location = new System.Drawing.Point(628, 521);
            this.buttonEmbos.Name = "buttonEmbos";
            this.buttonEmbos.Size = new System.Drawing.Size(75, 23);
            this.buttonEmbos.TabIndex = 29;
            this.buttonEmbos.Text = "Embos";
            this.buttonEmbos.UseVisualStyleBackColor = false;
            this.buttonEmbos.Click += new System.EventHandler(this.buttonEmbos_Click);
            // 
            // buttonEdges
            // 
            this.buttonEdges.Location = new System.Drawing.Point(710, 521);
            this.buttonEdges.Name = "buttonEdges";
            this.buttonEdges.Size = new System.Drawing.Size(75, 23);
            this.buttonEdges.TabIndex = 30;
            this.buttonEdges.Text = "Edges";
            this.buttonEdges.UseVisualStyleBackColor = true;
            this.buttonEdges.Click += new System.EventHandler(this.buttonEdges_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(380, 507);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 31;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(422, 507);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown2.TabIndex = 32;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(464, 506);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown3.TabIndex = 33;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(380, 533);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown4.TabIndex = 34;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(422, 533);
            this.numericUpDown5.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown5.TabIndex = 35;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(464, 532);
            this.numericUpDown6.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown6.TabIndex = 36;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(380, 559);
            this.numericUpDown7.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown7.TabIndex = 37;
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(422, 559);
            this.numericUpDown8.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown8.TabIndex = 38;
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(464, 559);
            this.numericUpDown9.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown9.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 799);
            this.Controls.Add(this.numericUpDown9);
            this.Controls.Add(this.numericUpDown8);
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonEdges);
            this.Controls.Add(this.buttonEmbos);
            this.Controls.Add(this.trackBarCartoon);
            this.Controls.Add(this.trackBarCoeff);
            this.Controls.Add(this.buttonCartoon);
            this.Controls.Add(this.buttonAquarel);
            this.Controls.Add(this.buttonSharpen);
            this.Controls.Add(this.buttonBlur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarValue);
            this.Controls.Add(this.trackBarSat);
            this.Controls.Add(this.trackBarHue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.buttonIntersect);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSepia);
            this.Controls.Add(this.buttonBW);
            this.Controls.Add(this.buttonChannel);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonG);
            this.Controls.Add(this.radioButtonR);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCartoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.RadioButton radioButtonR;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.Button buttonChannel;
        private System.Windows.Forms.Button buttonBW;
        private System.Windows.Forms.Button buttonSepia;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonIntersect;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.TrackBar trackBarSat;
        private System.Windows.Forms.TrackBar trackBarValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBlur;
        private System.Windows.Forms.Button buttonSharpen;
        private System.Windows.Forms.Button buttonAquarel;
        private System.Windows.Forms.Button buttonCartoon;
        private System.Windows.Forms.TrackBar trackBarCoeff;
        private System.Windows.Forms.TrackBar trackBarCartoon;
        private System.Windows.Forms.Button buttonEmbos;
        private System.Windows.Forms.Button buttonEdges;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
    }
}

