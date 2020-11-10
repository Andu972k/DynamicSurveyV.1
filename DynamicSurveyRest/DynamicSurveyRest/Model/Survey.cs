using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicSurveyRest.Model
{
    public class Survey
    {

        #region InstanceFields

        private int _id;
        private string _title;
        private List<Question> _questions;



        #endregion


        #region Properties

        public int ID { get; set; }
        public string Title { get; set; }
        public List<Question> Questions { get; set; }


        #endregion


        #region Constructor

        public Survey()
        {

        }


        #endregion

        #region Methods




        #endregion

    }
}
