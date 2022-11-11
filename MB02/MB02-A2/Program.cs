namespace MB02_A2
{
    internal class ImplementationVonInstanzvariablen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var rechteck = new Rechteck();
            rechteck.privateIntWithStandardValue = 10;
        }
    }

    internal class Rechteck
    {
        /* 1 */
        private int privateInt;     // privates Feld

        /* 2 */
        private readonly int privateReadOnlyInt;        // privates Feld, dessen Wert nicht verändert werden kann

        /* 3 */
        public int privateIntWithStandardValue = 5;     // wert kann verändert werden, ist standardmässig aber auf 5 gesetzt

        /* 4 */
        private int privateReadyOnlyIntProperty
        {
            get { return privateInt; }       // nur get parameter (read)
        }

        /* 5 */
        private int privateReadWriteIntProperty
        {
            get { return privateReadOnlyInt; }      // get parameter (read)
            set { privateInt = value; }     // und set parameter (write)
        }

        /* 6 */
        private int privateWriteOnlyIntProperty
        {
            set { privateReadWriteIntProperty = value; }        // set parameter (write)
        }

        /* 7 */
        private int privateReadOnlyIntPropertyAutomatic { get; }

        /* 8 */
        private int privateReadWriteIntPropertyAutomatic { get; set; }

        /* 9 */
        private int privateWriteOnlyIntPropertyAutomatic { set { privateWriteOnlyIntPropertyAutomatic = value; } }

        /* 10 */
        private int expressionBody1 => 10 + 5;
        private int expressionBody2 => 10 - 5;
    }
}