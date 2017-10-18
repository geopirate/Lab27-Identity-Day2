﻿using System.ComponentModel.DataAnnotations;

namespace Lab27George.Models
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public string Title { get; set; }
        public int Height { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool GameMaster { get; set; }
    }
}
