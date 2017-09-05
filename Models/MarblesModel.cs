using System;
using System.Collections.Generic;

namespace Marbles.Models
{
    public class MarblesModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public MarblesModel()
        {

        }
        public static List<MarblesModel> MarblesList = new List<MarblesModel>
        {
            new MarblesModel
            {
                Id = 1,
                Color = "red"
            },

            new MarblesModel
            {
                Id = 2,
                Color = "blue"
            },

            new MarblesModel
            {
                Id = 3,
                Color = "yellow"
            }
        };
    }
}
