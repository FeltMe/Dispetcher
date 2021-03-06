﻿                using System.Collections.Generic;
using System.Diagnostics;
using Dispetcher.Classes;

namespace Dispetcher
{
    public class ViewModeler : IViewModeler
    {
        private List<MyAppHeader> AppsList = new List<MyAppHeader>();
        private List<MyProcesessHeader> ProcesList = new List<MyProcesessHeader>();

        public List<MyAppHeader> AddApplication()
        {
            AppsList.Clear();
            foreach (var item in Process.GetProcesses())
            {
                if(string.IsNullOrEmpty(item.MainWindowTitle) == false)
                {
                    MyAppHeader temp = new MyAppHeader
                    {
                        AppNamee = item.ProcessName
                    };

                    AppsList.Add(temp);
                }
            }
            return AppsList;
        }

        public List<MyProcesessHeader> AddProcesess()
        {
            ProcesList.Clear();
            foreach (var item in Process.GetProcesses())
            {
                MyProcesessHeader TempMyProceses = new MyProcesessHeader
                {
                    Id = item.Id,
                    Name = item.ProcessName,
                    Priority = item.BasePriority,
                    Descripts = item.HandleCount
                };

                ProcesList.Add(TempMyProceses);
            }
            return ProcesList;
        }
    }
}
