using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AllergyRecProtoype
{
    public class DataManager
    {
        public List<AllergyRec> AllergyRecList { get; set; }
        public List<Allergen> AllergenList { get; set; }
        public List<Reaction> ReactionList { get; set; }
        
        /// <summary>
        /// Instace variable
        /// </summary>
        private static DataManager _instance;

        /// <summary>
        /// Constructor
        /// </summary>
        private DataManager() 
        {
            AllergyRecList = new List<AllergyRec> { 
                new AllergyRec { Reconcile = false, Category = "Allergy", Type = "Food", Allergen = "AGAR (FOOD)", Campus = "EAST" , Reactions = "Anaphylaxis", AllscriptsReactions = "", EnteredOn = "03/30/2016"},
                new AllergyRec { Reconcile = false, Category = "Allergy", Type = "Food", Allergen = "CAFEEINE (FOOD)", Campus = "EAST" , Reactions = "Fever", AllscriptsReactions = "", EnteredOn = "03/30/2016"},
                new AllergyRec { Reconcile = false, Category = "Allergy", Type = "Latex", Allergen = "LATEX", Campus = "EAST" , Reactions = "Unknown", AllscriptsReactions = "", EnteredOn = "03/30/2016"},
                new AllergyRec { Reconcile = false, Category = "Allergy", Type = "Drug Category", Allergen = "SHELLFISH", Campus = "EAST" , Reactions = "Dizziness; Edema",  AllscriptsReactions = "", EnteredOn = "03/30/2016"},
                new AllergyRec { Reconcile = false, Category = "Allergy", Type = "Environmental", Allergen = "ADHESIVE (ENV)", Campus = "EAST" , Reactions = "Congestion", AllscriptsReactions = "", EnteredOn = "03/30/2016"},
                new AllergyRec { Reconcile = false, Category = "Drug Category", Type = "Allergy", Allergen = "4-aminoquinoines", Campus = "EAST" , Reactions = "Unknown", AllscriptsReactions = "", EnteredOn = "Just Now"},
                new AllergyRec { Reconcile = true, Category = "Allergy", Type = "Allergies", Allergen = "Shelfish", Campus = "CROWN" , Reactions = "", AllscriptsReactions = "", EnteredOn = "N/A"},
                new AllergyRec { Reconcile = true, Category = "Allergy", Type = "Allergies", Allergen = "Soy", Campus = "CROWN" , Reactions = "[Dry Mouth]", AllscriptsReactions = "", EnteredOn = "N/A"},
                new AllergyRec { Reconcile = true, Category = "Allergy", Type = "Food", Allergen = "CAFEEINE (FOOD)", Campus = "WEST" , Reactions = "Fever", AllscriptsReactions = "", EnteredOn = "03/24/2016"},
                new AllergyRec { Reconcile = true, Category = "Allergy", Type = "Latex", Allergen = "LATEX", Campus = "WEST" , Reactions = "Unknown", AllscriptsReactions = "", EnteredOn = "03/21/2016"},
                new AllergyRec { Reconcile = true, Category = "Intolerance", Type = "Drug", Allergen = "omega-3 polyunsaturated fatty acids", Campus = "WEST" , Reactions = "Cramps; Diarrhea", AllscriptsReactions = "", EnteredOn = "03/21/2016"},
            };

            AllergenList = new List<Allergen>
            {
                new Allergen { Name = "12 Hour Decongestant", Value = 1 },
                new Allergen { Name = "4-DIMETHYLAMINOPHENOL", Value = 2 },
                new Allergen { Name = "8-Hour Acetaminophen E.R.", Value = 3 },
                new Allergen { Name = "ABC Plus Senior", Value = 4 },
                new Allergen { Name = "acarbose", Value = 5 },
                new Allergen { Name = "Acetaminophen 8-hr Relief", Value = 0 },
                new Allergen { Name = "acetaminophen-diphenhydramine", Value = 0 },
                new Allergen { Name = "Acyclovir Sodium", Value = 0 },
                new Allergen { Name = "bile acids", Value = 0 },
                new Allergen { Name = "Capastat Sulfate", Value = 0 },
                new Allergen { Name = "EPIMEDIUM EXTRACT, GOAT DERIV", Value = 0 },
                new Allergen { Name = "Haldol Decanoate", Value = 0 },
                new Allergen { Name = "HyperTET S/D", Value = 0 },
                new Allergen { Name = "Lotrimin AF Powder Spray", Value = 0 },
                new Allergen { Name = "Nalbuphine Hydrochloride", Value = 0 },
                new Allergen { Name = "Ocuvite PreserVision", Value = 0 },
                new Allergen { Name = "Patanol", Value = 0 },
                new Allergen { Name = "PrednisoLONE Sodium Phosphate", Value = 0 }
            };

            ReactionList = new List<Reaction>
            {
                new Reaction { Name = "Anaphylaxis", Value = 1 },
                new Reaction { Name = "Congestion", Value = 2 },
                new Reaction { Name = "Coughing", Value = 3 },
                new Reaction { Name = "Dizziness", Value = 4 },
                new Reaction { Name = "Eczema", Value = 0 },
                new Reaction { Name = "Edema", Value = 0 },
                new Reaction { Name = "Erythema", Value = 0 },
                new Reaction { Name = "Fever", Value = 0 },
                new Reaction { Name = "Hives", Value = 0 },
                new Reaction { Name = "Itching", Value = 0 },
                new Reaction { Name = "Other", Value = 0 },
                new Reaction { Name = "Rash", Value = 0 },
                new Reaction { Name = "Short of breath", Value = 0 },
                new Reaction { Name = "Sneezing", Value = 0 },
                new Reaction { Name = "Swelling", Value = 0 },
                new Reaction { Name = "Unknown", Value = 0 },
                new Reaction { Name = "Urticaria", Value = 0 },
                new Reaction { Name = "Wheezing", Value = 0 }
            };
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataManager();
                return _instance;
            }
        }
    }
}
