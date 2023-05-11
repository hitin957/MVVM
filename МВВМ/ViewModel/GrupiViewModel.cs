using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using WpfApp7;
using МВВМ.Model;
using МВВМ.View;
using МВВМ.ViewModel.Helpers;

namespace МВВМ.ViewModel
{
    internal class GrupiViewModel : BindingHelper
    {
        string fileName = "Grupi.json";
        public BindableCommand AddCommand3 { get; set; }
        public BindableCommand RemoveCommand3 { get; set; }
        public BindableCommand UpdateCommand3 { get; set; }
        public BindableCommand GOTOOCHENKU { get; set; }
        public BindableCommand BACKCommand { get; set; }
        //
        #region Свойства
        private G s;
        public G S
        {
            get { return s; }
            set
            {
                s = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<G> group;
        public ObservableCollection<G> groupInfo
        {
            get { return group; }
            set
            {
                group = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public GrupiViewModel()
        {
            groupInfo = new ObservableCollection<G>()
            {
                new G("Э-2-21"),
                new G("ВД-3-21")
            };
            AddCommand3 = new BindableCommand(_ => AddItems_G());
            RemoveCommand3 = new BindableCommand(_ => RemoveItems_G());
            UpdateCommand3 = new BindableCommand(_ => Update_G());
            GOTOOCHENKU = new BindableCommand(_ => GOTO_OCHENKU());
            BACKCommand = new BindableCommand(_ => BACK());
            string jsonString = JsonConvert.SerializeObject(groupInfo);
            File.WriteAllText(fileName, jsonString);
            ObservableCollection<G> list = JsonConvert.DeserializeObject<ObservableCollection<G>>(jsonString);
            groupInfo = list;
        }
        //
        public void AddItems_G()
        {
            groupInfo.Add(new G("Т50-1-21/11-22"));
            string jsonString = JsonConvert.SerializeObject(groupInfo);
            File.WriteAllText(fileName, jsonString);
        }
        public void RemoveItems_G()
        {
            groupInfo.Remove(S);
            string jsonString = JsonConvert.SerializeObject(groupInfo);
            File.WriteAllText(fileName, jsonString);
        }

        private void Update_G()
        {
            var i = groupInfo.IndexOf(S);
            groupInfo[i] = S;
            string jsonString = JsonConvert.SerializeObject(groupInfo);
            File.WriteAllText(fileName, jsonString);
        }
        //
        public void GOTO_OCHENKU()
        {
            Ochenku ochenku = new Ochenku();
            ochenku.Show();
        }
        public void BACK()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
