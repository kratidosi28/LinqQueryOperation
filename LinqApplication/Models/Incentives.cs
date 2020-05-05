using System;
using System.Collections.Generic;
using System.Text;

namespace LinqApplication.Models
{
    class Incentives
    {

        public int EMPLOYEE_REF_ID { get; set; }

        public string INCENTIVE_DATE { get; set; }

        public int INCENTIVE_AMOUNT { get; set; }

        public static List<Incentives> IncentiveDetails()

        {
            List<Incentives> incentives = new List<Incentives>();
            {
                incentives.Add(new Incentives
                {
                    EMPLOYEE_REF_ID = 1,
                    INCENTIVE_DATE = "01-FEB-13",
                    INCENTIVE_AMOUNT = 5000

                });

                incentives.Add(new Incentives
                {
                    EMPLOYEE_REF_ID = 2,
                    INCENTIVE_DATE = "01-FEB-13",
                    INCENTIVE_AMOUNT = 3000

                });

                incentives.Add(new Incentives
                {
                    EMPLOYEE_REF_ID = 3,
                    INCENTIVE_DATE = "01-FEB-13",
                    INCENTIVE_AMOUNT = 4000

                });

                incentives.Add(new Incentives
                {
                    EMPLOYEE_REF_ID = 1,
                    INCENTIVE_DATE = "01-FEB-13",
                    INCENTIVE_AMOUNT = 4500

                });

                return incentives;

            }

        }
    }
}
