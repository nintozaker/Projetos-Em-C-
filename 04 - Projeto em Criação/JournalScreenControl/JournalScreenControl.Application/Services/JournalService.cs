using JournalScreenControl.Core.Model;
using JournalScreenControl.Core.Services;
using JournalScreenControl.Data.Utils;
using System;
using System.Collections.Generic;


namespace JournalScreenControl.Services
{
    public class JournalService : IJournalService
    {
        private static int index = 0;
        public Journal NextJournal()
        {
            try
            {
                var jornals = FileManipulation.ReadExcelFile();
                Journal journal = jornals[index];
                index++;
                return journal;
            }
            catch (Exception ex)
            {

                throw;
            }


        }




    }
}
