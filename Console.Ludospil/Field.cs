﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ludospil
{
    public enum FieldType { Home, Safe, InPlay, Finish }
    

    public class Field
    {
        private GameColor color;
        private int fieldId;
        private Token[] tokens = new Token[2];
        
        public Field(int id,GameColor color)
        {
            this.fieldId = id;
            this.color = color;
        }

        //     public bool PlaceToken(Token tkn)
        //     {
        //         if (tokens.Any()){ // Field has Token objects on it




        //} else {
        //        // No tokens, place token
        //        tokens[0] = tkn;
        //    }

        //}
    }
}