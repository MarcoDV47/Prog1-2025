namespace Aula01.Models
{
    public class Variables
    {
        //Tipos Implicitos
        // var teste = 10;

        //Anotação de Tipos

        public int userCount = 10;

        //Uma variável pode ser declarada e não inicializada

        public int totalCount;

        //Constantes
        //Para declarar uma constatbte utilizamos a palvra-chave "CONST"
        //No entanto, a "CONST" deve ser inicializada quando declarada 
        const int interestRate = 10;

        public byte byteMin = byte.MinValue;
        public byte byteMax = byte.MaxValue;
        public short shortMin = short.MinValue;
        public short shortMax = short.MaxValue;
        public int intMin = int.MinValue;
        public int intMax = int.MaxValue;
        public uint uintMin = uint.MinValue;
        public uint uintMax = uint.MaxValue;
        public long longMin = long.MinValue;
        public long longMax = long.MaxValue;

        //O Método Construtor é invocado na instanciação do Objeto por meio da palavra reservada "new"
        //Por regra, o Construtor sempre tem o mesmo nome da Classe 

        //Procedimento
        public Variables()
        {
            totalCount = 0;

            //Tipo Implicito
            //A palavra chave "VAR" se encarrega de definir o tipo de variável na instrução de atribuição
            var signalStrength = 47;
            var companyName = "The Agency";
        }
    }
}