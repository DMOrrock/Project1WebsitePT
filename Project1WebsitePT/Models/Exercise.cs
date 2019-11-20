using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Project1WebsitePT.Models
{
    public class Exercise {
        [DisplayName("Exercise Name:")]
        public string Name { get; set; }
        [DisplayName("Affected Muscle Group:")]
        public string MuscleGroup { get; set; }
        [DisplayName("Number of Reps:")]
        public int RepNumber { get; set; }
        [DisplayName("Hold Time:")]
        public string Time { get; set; }
        public string Graphic { get; set; }
        [DisplayName("Suggested Exercise 1:")]
        public string SimilarEX1 { get; set; }
        [DisplayName("Suggested Exercise 1:")]
        public string SimilarEX2 { get; set; }

}
}