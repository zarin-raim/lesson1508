using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalCardSystemLibrary
{
    public class MedicalCard
    {
        private DiseaseStory[] _diseasesStory;
        public int CountDiseases { get; set; }
        private DoctorVisit[] _visitStory;
        public int CountVisits { get; set; }

        public MedicalCard()
        {
            CountDiseases = 0;
            CountVisits = 0;
            _diseasesStory = new DiseaseStory[CountDiseases];
            _visitStory = new DoctorVisit[CountVisits]; 
        }
    }
}
