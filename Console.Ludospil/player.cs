﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludospil
{
    public class Player
    {

        private readonly int playerId;
        private readonly string name;
        private readonly Token[] tokens;

        public Player(int id, string playerName, Token[] tokens)
        {
            this.playerId = id;
            this.name = playerName;
            this.tokens = tokens;
            this.Color = this.tokens[0].GetColor();
        }
        public string GetName
        {
            get
            {
                return this.name;
            }
        }
        public GameColor Color
        {
            get;
        }
        public int GetPlayerId()
        {
            return this.playerId;
        }
        public string GetDescription()
        {
            return "#" + this.GetPlayerId() + " " + this.Color + " spiller: " + this.GetName;
        }
        public Token[] GetTokens()
        {
            return this.tokens;
        }

    }
}
