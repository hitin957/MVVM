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
    internal class MainViewModel : BindingHelper
    {
        string fileName = "FIO.json";
        public BindableCommand AddCommand { get; set; }
        public BindableCommand RemoveCommand { get; set; }
        public BindableCommand UpdateCommand { get; set; }
        public BindableCommand GOTOOCHENKU { get; set; }
        public BindableCommand GOTO_group {get; set; }
        //
        #region Свойства
        private FIO selected;
        public FIO Selected
        { 
          get { return selected; }
          set 
          {
                selected = value;
                OnPropertyChanged();           
          }
        }
        private ObservableCollection<FIO> fio;
        public ObservableCollection<FIO> FIOInfo
        {
            get { return fio; }
            set
            {
                fio = value;
                OnPropertyChanged();

            }
        }
        //
        #endregion
        public MainViewModel()
        {
            FIOInfo = new ObservableCollection<FIO>()
            {
                new FIO("Арзиане","Зураб","Никитич"),
                new FIO("Сколота","Даня","Дмитриевич")
            };
            AddCommand = new BindableCommand(_ => AddItems_FIO());
            RemoveCommand = new BindableCommand(_ => RemoveItems());
            UpdateCommand = new BindableCommand(_=> Update());
            GOTOOCHENKU = new BindableCommand(_ =>GOTO_OCHENKU());
            GOTO_group = new BindableCommand(_ => GOTO_Group());
            string jsonString = JsonConvert.SerializeObject(FIOInfo);
            File.WriteAllText(fileName, jsonString);
            ObservableCollection<FIO> list = JsonConvert.DeserializeObject<ObservableCollection<FIO>>(jsonString);
            FIOInfo = list;
        }
        //
        public void RemoveItems() 
        {
            FIOInfo.Remove(Selected);
            string jsonString = JsonConvert.SerializeObject(FIOInfo);
            File.WriteAllText(fileName, jsonString);
        }
        public void AddItems_FIO()
        {
            FIOInfo.Add(new FIO("Сперцан", "Эрик", null));
            string jsonString = JsonConvert.SerializeObject(FIOInfo);
            File.WriteAllText(fileName, jsonString);
        }
        private void Update()
        {
            var i = FIOInfo.IndexOf(Selected);
            FIOInfo[i] = Selected;
            string jsonString = JsonConvert.SerializeObject(FIOInfo);
            File.WriteAllText(fileName, jsonString);
        }
        //
        public void GOTO_Group()
        {
            Gruppi gruppi = new Gruppi();
            gruppi.Show();
        }
        public void GOTO_OCHENKU()
        {   Ochenku ochenku = new Ochenku();
            ochenku.Show();
        }
    }
}
