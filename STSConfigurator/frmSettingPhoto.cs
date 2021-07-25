using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using WindowsFormControlsLibrary;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;

namespace STSConfigurator
{
    public partial class frmSettingPhoto : STSConfigurator.frmSettingBase
    {
        private CLSSaveDataPhoto saveDataPhoto;
        public override CLSSaveData ClassSaveData { get { return saveDataPhoto; } }
        public frmSettingPhoto()
        {
            InitializeComponent();
            saveDataPhoto = new CLSSaveDataPhoto();
            HeadingForm = false;
            SaveModeXML = false;
        }
        public frmSettingPhoto(frmSettingsMain ownerForm, string formTitle) : this()
        {
            this.Title = formTitle;
            SetOwnerForm(ownerForm);
        }

        private void frmSettingPhoto_Load(object sender, EventArgs e)
        {
            saveDataPhoto = LoadFromDatabase(saveDataPhoto) as CLSSaveDataPhoto;

            tbxFolderPhotoWorking.Text = saveDataPhoto.PhotoFolderWorking;
            tbxFolderPhoto.Text = saveDataPhoto.PhotoFolder;
            tbxOSpeed.Text = saveDataPhoto.PhotoOralSpeed.ToString();
            tbxODiaphragm.Text = saveDataPhoto.PhotoOralDiaphragm.ToString();
            tbxOIso.Text = saveDataPhoto.PhotoOralIso.ToString();
            tbxFSpeed.Text = saveDataPhoto.PhotoFacialSpeed.ToString();
            tbxFDiaphragm.Text = saveDataPhoto.PhotoFacialDiaphragm.ToString();
            tbxFIso.Text = saveDataPhoto.PhotoFacialIso.ToString();

            preparePBX();
        }
        private void frmSettingPhoto_Shown(object sender, EventArgs e)
        {
            SetOrigin();
            foreach (var cnt in Controls.OfType<TextBoxFWValidation>())
            {
                cnt.isModified = false;
                cnt.TextChanged += DatasChanged;
            }
        }
        public override void SetOrigin()
        {
            this.Controls.OfType<TextBoxFWValidation>().ToList().ForEach(tbx => tbx.Originalstring = tbx.Text);
        }
        public override void ResumeToOrigin()
        {
            this.Controls.OfType<TextBoxFWValidation>().ToList().ForEach(tbx => tbx.Text = tbx.Originalstring);
            FormModified = false;
        }
        public override AcceptDataError AcceptData()   //保存直前にデータクラスを変更する
        {
            saveDataPhoto.PhotoFolderWorking = tbxFolderPhotoWorking.Text;
            saveDataPhoto.PhotoFolder = tbxFolderPhoto.Text;
            saveDataPhoto.PhotoOralSpeed = Convert.ToInt32(tbxOSpeed.Text);
            saveDataPhoto.PhotoOralDiaphragm = Convert.ToSingle(tbxODiaphragm.Text);
            saveDataPhoto.PhotoOralIso = Convert.ToInt32(tbxOIso.Text);
            saveDataPhoto.PhotoFacialSpeed = Convert.ToInt32(tbxFSpeed.Text);
            saveDataPhoto.PhotoFacialDiaphragm = Convert.ToSingle(tbxFDiaphragm.Text);
            saveDataPhoto.PhotoFacialIso = Convert.ToInt32(tbxFIso.Text);

            try
            {
                if (!Directory.GetDirectories(saveDataPhoto.PhotoFolderWorking).All<string>(dir => dir.Contains("OP") && dir.Contains("FP") && dir.Contains("XP")))
                {
                    if (!Directory.Exists(saveDataPhoto.PhotoFolderWorking + "OP")) Directory.CreateDirectory(saveDataPhoto.PhotoFolderWorking + "OP");
                    if (!Directory.Exists(saveDataPhoto.PhotoFolderWorking + "FP")) Directory.CreateDirectory(saveDataPhoto.PhotoFolderWorking + "FP");
                    if (!Directory.Exists(saveDataPhoto.PhotoFolderWorking + "XP")) Directory.CreateDirectory(saveDataPhoto.PhotoFolderWorking + "XP");
                }
            }
            catch(DirectoryNotFoundException ex )
            {
                if(ex != null)
                    MessageBox.Show("フォールダー設定を見直してください", "そのフォルダーは存在しません");
                return new AcceptDataError(true);
            }
            return new AcceptDataError(false);
        }
        private void DatasChanged(object sender, EventArgs e)
        {
            IsValidated = Controls.OfType<TextBoxFWValidation>().All(tbx => tbx.isValidated);
            FormModified = Controls.OfType<TextBoxFWValidation>().Any(n => n.isModified);
        }
        private void preparePBX()
        {
            Bitmap canvasO = new Bitmap(pbxO.Width, pbxO.Height);
            Bitmap canvasF = new Bitmap(pbxF.Width, pbxF.Height);
            Graphics gO = Graphics.FromImage(canvasO);
            Graphics gF = Graphics.FromImage(canvasF);
            string drawStringO = @"基準となる口腔内写真をドロップしてください";
            string drawStringF = @"基準となる顔写真をドロップしてください";
            Font fnt = new Font("メイリオ", 9);
            RectangleF rectO = new RectangleF(10, 10, 100, 70);
            RectangleF rectF = new RectangleF(10, 10, 70, 100);
            gO.FillRectangle(Brushes.White, rectO);
            gF.FillRectangle(Brushes.White, rectF);
            gO.DrawString(drawStringO, fnt, Brushes.Black, rectO);
            gF.DrawString(drawStringF, fnt, Brushes.Black, rectF);
            fnt.Dispose();
            gO.Dispose();
            gF.Dispose();
            pbxO.Image = canvasO;
            pbxF.Image = canvasF;

            pbxO.AllowDrop = true;
            pbxF.AllowDrop = true;
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void OnDragDrop(object sender, DragEventArgs e)
        {
            const int EXPOSURE_TIME = 33434;
            const int F_NUMBER = 33437;
            const int ISO_SPEED_RATING = 34855;

            string[] photoString = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (photoString.Length > 1)
            {
                MessageBox.Show("写真は1枚のみドロップ可能です");
                return;
            }
            else
            {
                ((PictureBox)sender).ImageLocation = photoString[0];

                using (Bitmap bmp = new Bitmap(photoString[0]))
                {
                    TextBoxFWValidation tbxS = (PictureBox)sender == pbxO ? tbxOSpeed : tbxFSpeed;
                    TextBoxFWValidation tbxD = (PictureBox)sender == pbxO ? tbxODiaphragm : tbxFDiaphragm;
                    TextBoxFWValidation tbxI = (PictureBox)sender == pbxO ? tbxOIso : tbxFIso;
                    var s = bmp.PropertyItems.FirstOrDefault(pi => pi.Id == EXPOSURE_TIME);
                    var f = bmp.PropertyItems.FirstOrDefault(pi => pi.Id == F_NUMBER);
                    double opFocul = f.Value[0] / f.Value[4];
                    var i = bmp.PropertyItems.FirstOrDefault(pi => pi.Id == ISO_SPEED_RATING);

                    tbxS.Text = s.Value[4].ToString();
                    tbxD.Text = opFocul.ToString();
                    tbxI.Text = i.Value[0].ToString();
                }
            }
        }
        private void fbdOpen(object sender, EventArgs e)
        {
            fbd.SelectedPath = Environment.SpecialFolder.NetworkShortcuts.ToString();
            DialogResult dr = fbd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                TextBoxFWValidation tbx = (TextBoxFWValidation)((ButtonLink)sender).ParentControl;
                tbx.Text = fbd.SelectedPath + @"\";
            }
        }
        private void tbxFolders_Validating(object sender, CancelEventArgs e)
        {
            if(!Directory.Exists(((TextBoxFWValidation)sender).Text))
            {
                DialogResult dr = MessageBox.Show("このまま登録しますか（非推奨）？", "該当するフォルダが存在しません", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) e.Cancel = true;
            }
        }
    }


    public class CLSSaveDataPhoto : frmSettingBase.CLSSaveData
    {
        public string PhotoFolderWorking;
        public string PhotoFolder;
        public int PhotoOralSpeed;
        public double PhotoOralDiaphragm;
        public int PhotoOralIso;
        public int PhotoFacialSpeed;
        public double PhotoFacialDiaphragm;
        public int PhotoFacialIso;
        public CLSSaveDataPhoto() { }
    }
}

