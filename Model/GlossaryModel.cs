﻿
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Model
{
    
    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class RootObject
    {
        public Glossary glossary { get; set; }
        public ObjectId  _id { get; set; }
    }

}
