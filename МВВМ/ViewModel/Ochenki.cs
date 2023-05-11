using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp7;
using МВВМ.Model;
using МВВМ.View;
using МВВМ.ViewModel.Helpers;

namespace МВВМ.ViewModel
{
    internal class Ochenki : BindingHelper
    {
        string fileName = "Ochenki.json";
        public BindableCommand AddCommand2 { get; set; }
        public BindableCommand RemoveCommand2 { get; set; }
        public BindableCommand UpdateCommand2 { get; set; }
        public BindableCommand BACKCommand { get; set; }
        public BindableCommand GOTO_group { get; set; }
        //
        #region Свойства
        //
        private O sele;
        public O Sele
        {
            get { return sele; }
            set
            {
                sele = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<O> o;
        public ObservableCollection<O> OInfo
        {
            get { return o; }
            set
            {
                o = value;
                OnPropertyChanged();

            }
        }
        //
        #endregion
        public Ochenki()
        {
           
            AddCommand2 = new BindableCommand(_ => AddItems_O());
            RemoveCommand2 = new BindableCommand(_ => RemoveItems_O());
            UpdateCommand2 = new BindableCommand(_ => Update_O());
            BACKCommand = new BindableCommand(_ => BACK());
            GOTO_group = new BindableCommand(_ => GOTO_Group());
            string jsonString = JsonConvert.SerializeObject(OInfo);
            ObservableCollection<O> list = JsonConvert.DeserializeObject<ObservableCollection<O>>(jsonString);
            OInfo = new ObservableCollection<O>()
            {
                new O("4"),
                new O("3")
            };
            File.WriteAllText(fileName, jsonString);
        }
        //
        public void AddItems_O()
        {
            OInfo.Add(new O("5"));
            string jsonString = JsonConvert.SerializeObject(OInfo);
            File.WriteAllText(fileName, jsonString);
        }
        public void RemoveItems_O()
        {
            OInfo.Remove(Sele);
            string jsonString = JsonConvert.SerializeObject(OInfo);
            File.WriteAllText(fileName, jsonString);
        }

        private void Update_O()
        {
            var i = OInfo.IndexOf(Sele);
            OInfo[i] = Sele;
            string jsonString = JsonConvert.SerializeObject(OInfo);
            File.WriteAllText(fileName, jsonString);
        }
        //
        public void GOTO_Group()
        {
            Gruppi gruppi = new Gruppi();
            gruppi.Show();
        }
        public void BACK()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
