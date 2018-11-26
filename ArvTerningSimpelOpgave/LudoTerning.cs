namespace ArvTerningSimpelOpgave
{
    class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return this.Værdi == 3; 
             
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }

        // Default og custom constructor der kalder ”mor” uden yderligere funktionalitet

        public LudoTerning() : base()
        { }

        public LudoTerning(int værdi) : base(værdi)
        { }
    }
}
