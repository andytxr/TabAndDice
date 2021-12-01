namespace TabAndDice
{
    partial class frm_home
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Arcanismo");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("História");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Investigação");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Natureza");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Religião");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Inteligência", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Intuição");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Adestrar Animais");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Sobrevivência");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Sabedoria", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Medicina");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Arremessar");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Pontaria", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Vontade");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Determinação", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Habilidade com Katanas");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Habilidade com Armas Pesadas");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Acrobacia");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Furtividade");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Trapaça");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Destreza", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Brigar");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Habilidade com Armas à Distância");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Habilidade com Adagas");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Atuação");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Enganação");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Intimidação");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Persuasão");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Carisma", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Consituição");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Força");
            this.tv_intelig = new System.Windows.Forms.TreeView();
            this.lbl_tab = new System.Windows.Forms.Label();
            this.tv_sab = new System.Windows.Forms.TreeView();
            this.nud_intelig = new System.Windows.Forms.NumericUpDown();
            this.nud_sab = new System.Windows.Forms.NumericUpDown();
            this.tv_med = new System.Windows.Forms.TreeView();
            this.nud_med = new System.Windows.Forms.NumericUpDown();
            this.tv_pont = new System.Windows.Forms.TreeView();
            this.nud_pont = new System.Windows.Forms.NumericUpDown();
            this.tv_det = new System.Windows.Forms.TreeView();
            this.nud_det = new System.Windows.Forms.NumericUpDown();
            this.hab_kat = new System.Windows.Forms.TreeView();
            this.tv_armpes = new System.Windows.Forms.TreeView();
            this.tv_dest = new System.Windows.Forms.TreeView();
            this.tv_brg = new System.Windows.Forms.TreeView();
            this.hab_armdis = new System.Windows.Forms.TreeView();
            this.hab_adg = new System.Windows.Forms.TreeView();
            this.tv_crsm = new System.Windows.Forms.TreeView();
            this.tv_const = new System.Windows.Forms.TreeView();
            this.tv_frç = new System.Windows.Forms.TreeView();
            this.lbl_hab = new System.Windows.Forms.Label();
            this.nud_crsm = new System.Windows.Forms.NumericUpDown();
            this.nud_dest = new System.Windows.Forms.NumericUpDown();
            this.nud_brg = new System.Windows.Forms.NumericUpDown();
            this.nud_const = new System.Windows.Forms.NumericUpDown();
            this.nud_frç = new System.Windows.Forms.NumericUpDown();
            this.nud_habkat = new System.Windows.Forms.NumericUpDown();
            this.nud_armpes = new System.Windows.Forms.NumericUpDown();
            this.nud_adg = new System.Windows.Forms.NumericUpDown();
            this.nud_armdis = new System.Windows.Forms.NumericUpDown();
            this.btn_intelig = new System.Windows.Forms.Button();
            this.btn_sab = new System.Windows.Forms.Button();
            this.btn_det = new System.Windows.Forms.Button();
            this.btn_pont = new System.Windows.Forms.Button();
            this.btn_med = new System.Windows.Forms.Button();
            this.btn_crsm = new System.Windows.Forms.Button();
            this.btn_dest = new System.Windows.Forms.Button();
            this.btn_brg = new System.Windows.Forms.Button();
            this.btn_const = new System.Windows.Forms.Button();
            this.btn_frç = new System.Windows.Forms.Button();
            this.btn_habkat = new System.Windows.Forms.Button();
            this.btn_armpes = new System.Windows.Forms.Button();
            this.btn_adg = new System.Windows.Forms.Button();
            this.btn_armdist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_intelig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_med)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_crsm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_brg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_const)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_frç)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_habkat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_armpes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_armdis)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_intelig
            // 
            this.tv_intelig.Location = new System.Drawing.Point(12, 46);
            this.tv_intelig.Name = "tv_intelig";
            treeNode1.Name = "arcan";
            treeNode1.Text = "Arcanismo";
            treeNode2.Name = "hist";
            treeNode2.Text = "História";
            treeNode3.Name = "invest";
            treeNode3.Text = "Investigação";
            treeNode4.Name = "natu";
            treeNode4.Text = "Natureza";
            treeNode5.Name = "relig";
            treeNode5.Text = "Religião";
            treeNode6.Name = "intelig";
            treeNode6.Text = "Inteligência";
            this.tv_intelig.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tv_intelig.Size = new System.Drawing.Size(141, 101);
            this.tv_intelig.TabIndex = 0;
            // 
            // lbl_tab
            // 
            this.lbl_tab.AutoSize = true;
            this.lbl_tab.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tab.ForeColor = System.Drawing.Color.Black;
            this.lbl_tab.Location = new System.Drawing.Point(154, 9);
            this.lbl_tab.Name = "lbl_tab";
            this.lbl_tab.Size = new System.Drawing.Size(74, 34);
            this.lbl_tab.TabIndex = 1;
            this.lbl_tab.Text = "FICHA";
            // 
            // tv_sab
            // 
            this.tv_sab.Location = new System.Drawing.Point(12, 153);
            this.tv_sab.Name = "tv_sab";
            treeNode7.Name = "itç";
            treeNode7.Text = "Intuição";
            treeNode8.Name = "ad_ani";
            treeNode8.Text = "Adestrar Animais";
            treeNode9.Name = "sob";
            treeNode9.Text = "Sobrevivência";
            treeNode10.Name = "sab";
            treeNode10.Text = "Sabedoria";
            this.tv_sab.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.tv_sab.Size = new System.Drawing.Size(141, 73);
            this.tv_sab.TabIndex = 2;
            // 
            // nud_intelig
            // 
            this.nud_intelig.Location = new System.Drawing.Point(157, 82);
            this.nud_intelig.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_intelig.Name = "nud_intelig";
            this.nud_intelig.Size = new System.Drawing.Size(64, 20);
            this.nud_intelig.TabIndex = 3;
            // 
            // nud_sab
            // 
            this.nud_sab.Location = new System.Drawing.Point(160, 184);
            this.nud_sab.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_sab.Name = "nud_sab";
            this.nud_sab.Size = new System.Drawing.Size(63, 20);
            this.nud_sab.TabIndex = 4;
            // 
            // tv_med
            // 
            this.tv_med.Location = new System.Drawing.Point(12, 316);
            this.tv_med.Name = "tv_med";
            treeNode11.Name = "med";
            treeNode11.Text = "Medicina";
            this.tv_med.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.tv_med.Size = new System.Drawing.Size(140, 22);
            this.tv_med.TabIndex = 5;
            // 
            // nud_med
            // 
            this.nud_med.Location = new System.Drawing.Point(157, 316);
            this.nud_med.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_med.Name = "nud_med";
            this.nud_med.Size = new System.Drawing.Size(64, 20);
            this.nud_med.TabIndex = 6;
            // 
            // tv_pont
            // 
            this.tv_pont.Location = new System.Drawing.Point(12, 271);
            this.tv_pont.Name = "tv_pont";
            treeNode12.Name = "arrem";
            treeNode12.Text = "Arremessar";
            treeNode13.Name = "pont";
            treeNode13.Text = "Pontaria";
            this.tv_pont.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.tv_pont.Size = new System.Drawing.Size(140, 40);
            this.tv_pont.TabIndex = 7;
            // 
            // nud_pont
            // 
            this.nud_pont.Location = new System.Drawing.Point(157, 281);
            this.nud_pont.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_pont.Name = "nud_pont";
            this.nud_pont.Size = new System.Drawing.Size(64, 20);
            this.nud_pont.TabIndex = 8;
            // 
            // tv_det
            // 
            this.tv_det.Location = new System.Drawing.Point(12, 232);
            this.tv_det.Name = "tv_det";
            treeNode14.Name = "vont";
            treeNode14.Text = "Vontade";
            treeNode15.Name = "det";
            treeNode15.Text = "Determinação";
            this.tv_det.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.tv_det.Size = new System.Drawing.Size(140, 37);
            this.tv_det.TabIndex = 9;
            // 
            // nud_det
            // 
            this.nud_det.Location = new System.Drawing.Point(158, 238);
            this.nud_det.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_det.Name = "nud_det";
            this.nud_det.Size = new System.Drawing.Size(63, 20);
            this.nud_det.TabIndex = 10;
            // 
            // hab_kat
            // 
            this.hab_kat.Location = new System.Drawing.Point(504, 46);
            this.hab_kat.Name = "hab_kat";
            treeNode16.Name = "hab_kat";
            treeNode16.Text = "Habilidade com Katanas";
            this.hab_kat.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.hab_kat.Size = new System.Drawing.Size(199, 30);
            this.hab_kat.TabIndex = 11;
            // 
            // tv_armpes
            // 
            this.tv_armpes.Location = new System.Drawing.Point(504, 82);
            this.tv_armpes.Name = "tv_armpes";
            treeNode17.Name = "hab_armpes";
            treeNode17.Text = "Habilidade com Armas Pesadas";
            this.tv_armpes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.tv_armpes.Size = new System.Drawing.Size(199, 30);
            this.tv_armpes.TabIndex = 12;
            // 
            // tv_dest
            // 
            this.tv_dest.Location = new System.Drawing.Point(229, 157);
            this.tv_dest.Name = "tv_dest";
            treeNode18.Name = "acb";
            treeNode18.Text = "Acrobacia";
            treeNode19.Name = "furt";
            treeNode19.Text = "Furtividade";
            treeNode20.Name = "tpç";
            treeNode20.Text = "Trapaça";
            treeNode21.Name = "dest";
            treeNode21.Text = "Destreza";
            this.tv_dest.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.tv_dest.Size = new System.Drawing.Size(140, 69);
            this.tv_dest.TabIndex = 13;
            // 
            // tv_brg
            // 
            this.tv_brg.Location = new System.Drawing.Point(229, 238);
            this.tv_brg.Name = "tv_brg";
            treeNode22.Name = "brg";
            treeNode22.Text = "Brigar";
            this.tv_brg.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.tv_brg.Size = new System.Drawing.Size(141, 22);
            this.tv_brg.TabIndex = 14;
            // 
            // hab_armdis
            // 
            this.hab_armdis.Location = new System.Drawing.Point(504, 154);
            this.hab_armdis.Name = "hab_armdis";
            treeNode23.Name = "hab_armdis";
            treeNode23.Text = "Habilidade com Armas à Distância";
            this.hab_armdis.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23});
            this.hab_armdis.Size = new System.Drawing.Size(199, 30);
            this.hab_armdis.TabIndex = 15;
            // 
            // hab_adg
            // 
            this.hab_adg.Location = new System.Drawing.Point(504, 118);
            this.hab_adg.Name = "hab_adg";
            treeNode24.Name = "hab_adg";
            treeNode24.Text = "Habilidade com Adagas";
            this.hab_adg.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24});
            this.hab_adg.Size = new System.Drawing.Size(199, 30);
            this.hab_adg.TabIndex = 16;
            // 
            // tv_crsm
            // 
            this.tv_crsm.Location = new System.Drawing.Point(229, 46);
            this.tv_crsm.Name = "tv_crsm";
            treeNode25.Name = "atc";
            treeNode25.Text = "Atuação";
            treeNode26.Name = "engç";
            treeNode26.Text = "Enganação";
            treeNode27.Name = "itmd";
            treeNode27.Text = "Intimidação";
            treeNode28.Name = "pers";
            treeNode28.Text = "Persuasão";
            treeNode29.Name = "crsm";
            treeNode29.Text = "Carisma";
            this.tv_crsm.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode29});
            this.tv_crsm.Size = new System.Drawing.Size(141, 101);
            this.tv_crsm.TabIndex = 17;
            // 
            // tv_const
            // 
            this.tv_const.Location = new System.Drawing.Point(229, 279);
            this.tv_const.Name = "tv_const";
            treeNode30.Name = "const";
            treeNode30.Text = "Consituição";
            this.tv_const.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30});
            this.tv_const.Size = new System.Drawing.Size(140, 22);
            this.tv_const.TabIndex = 18;
            // 
            // tv_frç
            // 
            this.tv_frç.Location = new System.Drawing.Point(229, 316);
            this.tv_frç.Name = "tv_frç";
            treeNode31.Name = "frc";
            treeNode31.Text = "Força";
            this.tv_frç.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31});
            this.tv_frç.Size = new System.Drawing.Size(140, 22);
            this.tv_frç.TabIndex = 19;
            // 
            // lbl_hab
            // 
            this.lbl_hab.AutoSize = true;
            this.lbl_hab.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hab.Location = new System.Drawing.Point(527, 8);
            this.lbl_hab.Name = "lbl_hab";
            this.lbl_hab.Size = new System.Drawing.Size(153, 35);
            this.lbl_hab.TabIndex = 20;
            this.lbl_hab.Text = "HABILIDADES";
            // 
            // nud_crsm
            // 
            this.nud_crsm.Location = new System.Drawing.Point(376, 82);
            this.nud_crsm.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_crsm.Name = "nud_crsm";
            this.nud_crsm.Size = new System.Drawing.Size(71, 20);
            this.nud_crsm.TabIndex = 21;
            // 
            // nud_dest
            // 
            this.nud_dest.Location = new System.Drawing.Point(378, 184);
            this.nud_dest.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_dest.Name = "nud_dest";
            this.nud_dest.Size = new System.Drawing.Size(68, 20);
            this.nud_dest.TabIndex = 22;
            // 
            // nud_brg
            // 
            this.nud_brg.Location = new System.Drawing.Point(378, 240);
            this.nud_brg.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_brg.Name = "nud_brg";
            this.nud_brg.Size = new System.Drawing.Size(69, 20);
            this.nud_brg.TabIndex = 23;
            // 
            // nud_const
            // 
            this.nud_const.Location = new System.Drawing.Point(378, 279);
            this.nud_const.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_const.Name = "nud_const";
            this.nud_const.Size = new System.Drawing.Size(69, 20);
            this.nud_const.TabIndex = 24;
            // 
            // nud_frç
            // 
            this.nud_frç.Location = new System.Drawing.Point(378, 316);
            this.nud_frç.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_frç.Name = "nud_frç";
            this.nud_frç.Size = new System.Drawing.Size(69, 20);
            this.nud_frç.TabIndex = 25;
            // 
            // nud_habkat
            // 
            this.nud_habkat.Location = new System.Drawing.Point(709, 46);
            this.nud_habkat.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_habkat.Name = "nud_habkat";
            this.nud_habkat.Size = new System.Drawing.Size(64, 20);
            this.nud_habkat.TabIndex = 26;
            // 
            // nud_armpes
            // 
            this.nud_armpes.Location = new System.Drawing.Point(709, 82);
            this.nud_armpes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_armpes.Name = "nud_armpes";
            this.nud_armpes.Size = new System.Drawing.Size(64, 20);
            this.nud_armpes.TabIndex = 27;
            // 
            // nud_adg
            // 
            this.nud_adg.Location = new System.Drawing.Point(708, 118);
            this.nud_adg.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_adg.Name = "nud_adg";
            this.nud_adg.Size = new System.Drawing.Size(65, 20);
            this.nud_adg.TabIndex = 28;
            // 
            // nud_armdis
            // 
            this.nud_armdis.Location = new System.Drawing.Point(708, 153);
            this.nud_armdis.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_armdis.Name = "nud_armdis";
            this.nud_armdis.Size = new System.Drawing.Size(65, 20);
            this.nud_armdis.TabIndex = 29;
            // 
            // btn_intelig
            // 
            this.btn_intelig.Location = new System.Drawing.Point(12, 354);
            this.btn_intelig.Name = "btn_intelig";
            this.btn_intelig.Size = new System.Drawing.Size(75, 23);
            this.btn_intelig.TabIndex = 30;
            this.btn_intelig.Text = "Inteligência";
            this.btn_intelig.UseVisualStyleBackColor = true;
            // 
            // btn_sab
            // 
            this.btn_sab.Location = new System.Drawing.Point(12, 383);
            this.btn_sab.Name = "btn_sab";
            this.btn_sab.Size = new System.Drawing.Size(75, 23);
            this.btn_sab.TabIndex = 31;
            this.btn_sab.Text = "Sabedoria";
            this.btn_sab.UseVisualStyleBackColor = true;
            // 
            // btn_det
            // 
            this.btn_det.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_det.Location = new System.Drawing.Point(12, 412);
            this.btn_det.Name = "btn_det";
            this.btn_det.Size = new System.Drawing.Size(75, 23);
            this.btn_det.TabIndex = 32;
            this.btn_det.Text = "Determinação";
            this.btn_det.UseVisualStyleBackColor = true;
            // 
            // btn_pont
            // 
            this.btn_pont.Location = new System.Drawing.Point(93, 354);
            this.btn_pont.Name = "btn_pont";
            this.btn_pont.Size = new System.Drawing.Size(75, 23);
            this.btn_pont.TabIndex = 33;
            this.btn_pont.Text = "Pontaria";
            this.btn_pont.UseVisualStyleBackColor = true;
            // 
            // btn_med
            // 
            this.btn_med.Location = new System.Drawing.Point(93, 383);
            this.btn_med.Name = "btn_med";
            this.btn_med.Size = new System.Drawing.Size(75, 23);
            this.btn_med.TabIndex = 34;
            this.btn_med.Text = "Medicina";
            this.btn_med.UseVisualStyleBackColor = true;
            // 
            // btn_crsm
            // 
            this.btn_crsm.Location = new System.Drawing.Point(93, 412);
            this.btn_crsm.Name = "btn_crsm";
            this.btn_crsm.Size = new System.Drawing.Size(75, 23);
            this.btn_crsm.TabIndex = 35;
            this.btn_crsm.Text = "Carisma";
            this.btn_crsm.UseVisualStyleBackColor = true;
            // 
            // btn_dest
            // 
            this.btn_dest.Location = new System.Drawing.Point(174, 354);
            this.btn_dest.Name = "btn_dest";
            this.btn_dest.Size = new System.Drawing.Size(75, 23);
            this.btn_dest.TabIndex = 36;
            this.btn_dest.Text = "Destreza";
            this.btn_dest.UseVisualStyleBackColor = true;
            // 
            // btn_brg
            // 
            this.btn_brg.Location = new System.Drawing.Point(174, 383);
            this.btn_brg.Name = "btn_brg";
            this.btn_brg.Size = new System.Drawing.Size(75, 23);
            this.btn_brg.TabIndex = 37;
            this.btn_brg.Text = "Brigar";
            this.btn_brg.UseVisualStyleBackColor = true;
            // 
            // btn_const
            // 
            this.btn_const.Location = new System.Drawing.Point(174, 412);
            this.btn_const.Name = "btn_const";
            this.btn_const.Size = new System.Drawing.Size(75, 23);
            this.btn_const.TabIndex = 38;
            this.btn_const.Text = "Constituição";
            this.btn_const.UseVisualStyleBackColor = true;
            // 
            // btn_frç
            // 
            this.btn_frç.Location = new System.Drawing.Point(255, 354);
            this.btn_frç.Name = "btn_frç";
            this.btn_frç.Size = new System.Drawing.Size(75, 23);
            this.btn_frç.TabIndex = 39;
            this.btn_frç.Text = "Força";
            this.btn_frç.UseVisualStyleBackColor = true;
            // 
            // btn_habkat
            // 
            this.btn_habkat.Location = new System.Drawing.Point(255, 383);
            this.btn_habkat.Name = "btn_habkat";
            this.btn_habkat.Size = new System.Drawing.Size(75, 23);
            this.btn_habkat.TabIndex = 40;
            this.btn_habkat.Text = "Katanas";
            this.btn_habkat.UseVisualStyleBackColor = true;
            // 
            // btn_armpes
            // 
            this.btn_armpes.Location = new System.Drawing.Point(255, 412);
            this.btn_armpes.Name = "btn_armpes";
            this.btn_armpes.Size = new System.Drawing.Size(75, 23);
            this.btn_armpes.TabIndex = 41;
            this.btn_armpes.Text = "A. Pesadas";
            this.btn_armpes.UseVisualStyleBackColor = true;
            // 
            // btn_adg
            // 
            this.btn_adg.Location = new System.Drawing.Point(336, 354);
            this.btn_adg.Name = "btn_adg";
            this.btn_adg.Size = new System.Drawing.Size(75, 23);
            this.btn_adg.TabIndex = 42;
            this.btn_adg.Text = "Adagas";
            this.btn_adg.UseVisualStyleBackColor = true;
            // 
            // btn_armdist
            // 
            this.btn_armdist.Location = new System.Drawing.Point(336, 383);
            this.btn_armdist.Name = "btn_armdist";
            this.btn_armdist.Size = new System.Drawing.Size(75, 23);
            this.btn_armdist.TabIndex = 43;
            this.btn_armdist.Text = "A. Distância";
            this.btn_armdist.UseVisualStyleBackColor = true;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_armdist);
            this.Controls.Add(this.btn_adg);
            this.Controls.Add(this.btn_armpes);
            this.Controls.Add(this.btn_habkat);
            this.Controls.Add(this.btn_frç);
            this.Controls.Add(this.btn_const);
            this.Controls.Add(this.btn_brg);
            this.Controls.Add(this.btn_dest);
            this.Controls.Add(this.btn_crsm);
            this.Controls.Add(this.btn_med);
            this.Controls.Add(this.btn_pont);
            this.Controls.Add(this.btn_det);
            this.Controls.Add(this.btn_sab);
            this.Controls.Add(this.btn_intelig);
            this.Controls.Add(this.nud_armdis);
            this.Controls.Add(this.nud_adg);
            this.Controls.Add(this.nud_armpes);
            this.Controls.Add(this.nud_habkat);
            this.Controls.Add(this.nud_frç);
            this.Controls.Add(this.nud_const);
            this.Controls.Add(this.nud_brg);
            this.Controls.Add(this.nud_dest);
            this.Controls.Add(this.nud_crsm);
            this.Controls.Add(this.lbl_hab);
            this.Controls.Add(this.tv_frç);
            this.Controls.Add(this.tv_const);
            this.Controls.Add(this.tv_crsm);
            this.Controls.Add(this.hab_adg);
            this.Controls.Add(this.hab_armdis);
            this.Controls.Add(this.tv_brg);
            this.Controls.Add(this.tv_dest);
            this.Controls.Add(this.tv_armpes);
            this.Controls.Add(this.hab_kat);
            this.Controls.Add(this.nud_det);
            this.Controls.Add(this.tv_det);
            this.Controls.Add(this.nud_pont);
            this.Controls.Add(this.tv_pont);
            this.Controls.Add(this.nud_med);
            this.Controls.Add(this.tv_med);
            this.Controls.Add(this.nud_sab);
            this.Controls.Add(this.nud_intelig);
            this.Controls.Add(this.tv_sab);
            this.Controls.Add(this.lbl_tab);
            this.Controls.Add(this.tv_intelig);
            this.Name = "frm_home";
            this.Text = "Tab&Dice";
            ((System.ComponentModel.ISupportInitialize)(this.nud_intelig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_med)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_crsm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_brg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_const)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_frç)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_habkat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_armpes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_armdis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_intelig;
        private System.Windows.Forms.Label lbl_tab;
        private System.Windows.Forms.TreeView tv_sab;
        private System.Windows.Forms.NumericUpDown nud_intelig;
        private System.Windows.Forms.NumericUpDown nud_sab;
        private System.Windows.Forms.TreeView tv_med;
        private System.Windows.Forms.NumericUpDown nud_med;
        private System.Windows.Forms.TreeView tv_pont;
        private System.Windows.Forms.NumericUpDown nud_pont;
        private System.Windows.Forms.TreeView tv_det;
        private System.Windows.Forms.NumericUpDown nud_det;
        private System.Windows.Forms.TreeView hab_kat;
        private System.Windows.Forms.TreeView tv_armpes;
        private System.Windows.Forms.TreeView tv_dest;
        private System.Windows.Forms.TreeView tv_brg;
        private System.Windows.Forms.TreeView hab_armdis;
        private System.Windows.Forms.TreeView hab_adg;
        private System.Windows.Forms.TreeView tv_crsm;
        private System.Windows.Forms.TreeView tv_const;
        private System.Windows.Forms.TreeView tv_frç;
        private System.Windows.Forms.Label lbl_hab;
        private System.Windows.Forms.NumericUpDown nud_crsm;
        private System.Windows.Forms.NumericUpDown nud_dest;
        private System.Windows.Forms.NumericUpDown nud_brg;
        private System.Windows.Forms.NumericUpDown nud_const;
        private System.Windows.Forms.NumericUpDown nud_frç;
        private System.Windows.Forms.NumericUpDown nud_habkat;
        private System.Windows.Forms.NumericUpDown nud_armpes;
        private System.Windows.Forms.NumericUpDown nud_adg;
        private System.Windows.Forms.NumericUpDown nud_armdis;
        private System.Windows.Forms.Button btn_intelig;
        private System.Windows.Forms.Button btn_sab;
        private System.Windows.Forms.Button btn_det;
        private System.Windows.Forms.Button btn_pont;
        private System.Windows.Forms.Button btn_med;
        private System.Windows.Forms.Button btn_crsm;
        private System.Windows.Forms.Button btn_dest;
        private System.Windows.Forms.Button btn_brg;
        private System.Windows.Forms.Button btn_const;
        private System.Windows.Forms.Button btn_frç;
        private System.Windows.Forms.Button btn_habkat;
        private System.Windows.Forms.Button btn_armpes;
        private System.Windows.Forms.Button btn_adg;
        private System.Windows.Forms.Button btn_armdist;
    }
}

