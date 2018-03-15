using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codeFirstDTO
{
        public class EntityHarley
        {
        int id;
        string couleur;
        int reservoir;
        int nbChevaux;
        string modele;
        // propriétés
        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }
        public int Reservoir
        {
            get { return reservoir; }
            set { reservoir = value; }
        }
        public int NbChevaux
        {
            get { return nbChevaux; }
            set { nbChevaux = value; }
        }
        public string Modele
        {
            get { return modele; }
            set { modele = value; }
        }

        public int ID
        {
            get
            {  return id;    }

            set
            {
                id = value;
            }
        }

        public override string ToString()
            {
                string s;
                s = /*"Harley n° " + ID +*/ " Modèle " + Modele + " de couleur " + Couleur + ", capacité réservoir : " + Reservoir + ", nombre de chevaux : " + NbChevaux;
                return s;
            }
        }
    }

