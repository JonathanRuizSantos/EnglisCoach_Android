using System;
using System.Collections.Generic;
using System.Text;

namespace EntrenadorIngles
{
    internal class EnglisCoachClass
    {
        
        int numberone;
        int numbertwo;
        string wordArrayOne;
        string lengthArrayOne;
        string wordArrayTwo;
        string lengthArrayTwo;
        string wordArrayThree;
        string lengthArrayThree;
        public EnglisCoachClass()
        {

        }

        public string dictionary_dic(string Keys)
        {
            
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("raise","aumentar");           // Palabras en ingles
            dic.Add("louder","mas fuerte");
            dic.Add("unbelief","incredulidad");
            dic.Add("weapon","arma");
            dic.Add("heaven","cielo");
            dic.Add("fight","pelear");
            dic.Add("gonna","ir a");
            dic.Add("hear","escuchar");
            dic.Add("roar","rugido");
            dic.Add("ashes","cenizas");
            dic.Add("arise","aumentar");
            dic.Add("defeated","derrotado");
            dic.Add("alive","vivo");
            dic.Add("darkness","oscuridad");
            dic.Add("flee","huir");
            dic.Add("fear","temor");
            dic.Add("lost","perdido");
            dic.Add("hold","sostener");
            dic.Add("little","poco");
            dic.Add("which has","que ha");
            dic.Add("feeling","sensacion");
            dic.Add("such","semejante");
            dic.Add("flight","vuelo");
            dic.Add("it was such","fue tan");
            dic.Add("resume","resumen");
            dic.Add("summary","resumen/extracto");
            dic.Add("so much","tanto/tanta");
            dic.Add("too much","demaciado");
            dic.Add("frightened","aterrado");
            dic.Add("happen","pasar");
            dic.Add("stealing","robando");
            dic.Add("missing","desapparecida");
            dic.Add("leaving","dejando");
            dic.Add("mall","centro comercial");
            dic.Add("ham","jamon");
            dic.Add("whitout","sin");
            dic.Add("changing","cambiando");
            dic.Add("spelling","ortografia");
            dic.Add("each","cada");
            dic.Add("choose","escoger");
            dic.Add("deserve","merecer");
            dic.Add("none","nadie");
            dic.Add("change","cambiar");
            dic.Add("sheep","oveja");
            dic.Add("partner","pareja");
            dic.Add("angry","enojon");
            dic.Add("awesome","impresionante");
            dic.Add("enviroment","entorno");
            dic.Add("however","sin embargo");
            dic.Add("shortage","escases");
            dic.Add("suitably","adecuadamente");
            dic.Add("lack","carecen");
            dic.Add("even","aun");
            dic.Add("poverty","pobreza");
            dic.Add("health","sanar");
            dic.Add("rates","tasas");
            dic.Add("whereas","mientras que");
            dic.Add("among","entre");
            dic.Add("health recods","registros de salud");
            dic.Add("defaulted","fallar");
            dic.Add("additional","extra");
            dic.Add("outcome","resultados");
            dic.Add("unknow","desconocidos");
            dic.Add("also","ademas");
            dic.Add("constitutes","constituir");
            dic.Add("although","aunque");
            dic.Add("over","sobre");
            dic.Add("given","dado");
            dic.Add("disease","enfermedad");
            dic.Add("together","juntos");
            dic.Add("shape","formar");
            dic.Add("which","cual");
            dic.Add("traslate","traducir");
            dic.Add("into","dentro");
            dic.Add("accordance","conformidad");
            dic.Add("environment","ambiente");
            dic.Add("prested","presionado");
            dic.Add("research","investigacion");
            dic.Add("carried","transportado");
            dic.Add("well","bien");
            dic.Add("aim","apuntar");
            dic.Add("aim of","objetivo de");
            dic.Add("therefore","por lo tanto");
            dic.Add("regarding","con respecto a");
            dic.Add("poorest","mas pobres");
            dic.Add("whole","todo");
            dic.Add("articulator","articulador");
            dic.Add("both","ambas cosas");
            dic.Add("through","a travez de");
            dic.Add("lets's","Vamos");
            dic.Add("begin","empezar/comenzar");
            dic.Add("avalible","disponible");
            dic.Add("updates","actualizaciones");
            dic.Add("announcements","auncios");
            dic.Add("jus me","solo yo");
            dic.Add("features","caracterizticas");
            dic.Add("repository","repositorio");
            dic.Add("gist","esencia");
            dic.Add("failed to","no se pudo");
            dic.Add("no such","no hay");
            dic.Add("prognosis","pronostico");
            dic.Add("airborne","aerotransportadora");
            //dic.Add("disease","enfermedad");
            dic.Add("complex","compleja");
            dic.Add("remains","resto");
            dic.Add("once","una vez");
            dic.Add("aid","ayudar");
            dic.Add("goal","meta");
            dic.Add("tells","dice");
            //dic.Add("even","incluso / aun / par");
            dic.Add("sum","suma");
            dic.Add("odd","impar/extraño");  
            dic.Add("aumentar","raise");           //Palabras en español
            dic.Add("mas fuerte","louder");
            dic.Add("incredulidad","unbelief");
            dic.Add("arma","weapon");
            dic.Add("cielo","heaven");
            dic.Add("pelear","fight");
            dic.Add("ir a","gonna");
            dic.Add("escuchar","hear");
            dic.Add("rugido","roar");
            dic.Add("cenizas","ashes");
            dic.Add("derrotado","defeated");
            dic.Add("surgir","arise");
            dic.Add("viva","alive");
            dic.Add("oscuridad","darkness");
            dic.Add("huir","flee");
            dic.Add("temor","fear");
            dic.Add("perdido","lost"); //11
            dic.Add("traducir","traslate");
            dic.Add("dentro","into");
            dic.Add("conformidad","accordance");
            dic.Add("ambiente","environment");
            dic.Add("presionado","prested");
            dic.Add("investigacion","research");
            dic.Add("transportado","carried");
            dic.Add("bien","well");
            dic.Add("apuntar","aim");
            dic.Add("objetivo de","aim of");
            dic.Add("por lo tanto","therefore");
            dic.Add("con respecto a","regarding");
            dic.Add("mas pobres","poorest");
            dic.Add("todo","whole");
            dic.Add("articulador","articulator");
            dic.Add("ambas cosas","both");
            dic.Add("a travez de","through");
            dic.Add("vamos","lets's");
            dic.Add("empezar/comenzar","begin");
            dic.Add("disponible","avalible");
            dic.Add("actualizaciones","updates");
            dic.Add("auncios","announcements");
            dic.Add("solo yo","jus me");
            dic.Add("caracteristicas","features");
            dic.Add("repositorio","repository");
            dic.Add("esencia","gist");
            dic.Add("no se pudo","failed to");
            dic.Add("no hay","no such");
            dic.Add("pronostico","prognosis");
            dic.Add("aerotransportadora","airborne");
            dic.Add("enfermedad","disease");
            dic.Add("compleja","complex");
            dic.Add("resto","remains");
            dic.Add("una vez","once");
            dic.Add("ayudar","aid");
            dic.Add("meta","goal");
            dic.Add("dice","tells");
            dic.Add("ncluso/aun/par","even");
            dic.Add("suma","sum");
            dic.Add("impar/extraño","odd");
            dic.Add("sostener","hold"); //11 conexion
            dic.Add("poco","little");
            dic.Add("que ha","which has");
            dic.Add("sensacion","feeling");
            dic.Add("semejante","such");
            dic.Add("vuelo","flight");
            dic.Add("fue tan","it was such");
            dic.Add("resumen","resume");
            dic.Add("extracto","summary");
            dic.Add("tanto","so much");
            dic.Add("demaciado","too much");
            dic.Add("aterrado","frightened");
            dic.Add("pasar","happen");
            dic.Add("robando","stealing");
            dic.Add("desaparecida","missing");
            dic.Add("dejando","leaving");
            dic.Add("centro comercial","mall");
            dic.Add("jamon","ham");
            dic.Add("sin","whitout");
            dic.Add("cambiando","changing");
            dic.Add("ortografia","spelling");
            dic.Add("cada","each");
            dic.Add("escoger","choose");
            dic.Add("merecer","deserve");
            dic.Add("nadie/ninguno","none");
            dic.Add("cambiar","change");
            dic.Add("oveja","sheep");
            dic.Add("pareja","partner");
            dic.Add("enojon","angry");
            dic.Add("impresionante","awesome");
            dic.Add("entorno","anvironment");
            dic.Add("sin embargo","however");
            dic.Add("escases","shortage");
            dic.Add("adecuadamente","suitably");
            dic.Add("carecen","lack");
            dic.Add("aun","aven");
            dic.Add("pobreza","poverty");
            dic.Add("sanar","health");
            dic.Add("tasas","rates");
            dic.Add("mientras que","whereas");
            dic.Add("entre","among");
            dic.Add("registros de salud","health records");
            dic.Add("fallar","defaulted");
            dic.Add("extra","additional");
            dic.Add("resultados","outcome");
            dic.Add("desconocidos","unknow");
            dic.Add("ademas","also");
            dic.Add("constituir","constitutes");
            dic.Add("aunque","although");
            dic.Add("sobre","over");
            dic.Add("dado","given");
            //dic.Add("enfermedad","disease");
            dic.Add("juntos","together");
            dic.Add("formar","shape");
            dic.Add("cual","which");

            string wordClass=dic[Keys];
            return (wordClass);
        }

        public string wordsArraysOne()
        {
            String[] WordsArray = new String[] {"raise","louder","unbelief","weapon","heaven","fight"
                    ,"gonna","hear","roar","ashes","arise","defeated","alive","darkness","flee","fear"
                    ,"lost","hold","little","which has","feeling","such","flight","it was such","resume"
                    ,"summary","so much","too much","frightened","happen","stealing","missing","leaving"
                    ,"mall","ham","whitout","changing","spelling","each","choose","deserve","none"
                    ,"change","sheep","partner","angry","awesome","enviroment","however","shrotage","suitably"
                    ,"lack","event","poverty","health","rates","whereas","among","health recods","defaulted"
                    ,"additional","outcome","unknown","also","constirutes","althrough","over","given","disease"
                    ,"together","shape","which","traslate","into","accordance","enviroment","prested","research"
                    ,"carried","aim","aim of","therefore","regarding","well","poorest","whole","articulator","both"
                    ,"through","let's","begin","avalible","updates","announcements","jus me","features","repository"
                    ,"gist","failed to","no such","prognosis","airborne","disease","complex","remains","once"
                    ,"aid","goal","tells","even","sum","add"};
            numberRandomOne();
            wordArrayOne = WordsArray[numberone];
            lengthArrayOne = WordsArray.Length.ToString();
            return wordArrayOne;
        }

        public string lengArrayOneFuntion()
        {
            return lengthArrayOne;
        }

        public string wordsArraysTwo()
        {
            String[] WordsSpanishArray = new String[] {"aumentar","mas fuerte","incredulidad","arma"
                ,"cielo","pelear","ir a","rugido","cenizas","aumentar","derrotado","vida","oscuridad"
                ,"huir", "temor","perdido","sostener","poco","que ha","sensacion","semejante","vuelo"
                ,"fue tan","resumen","extracto/resumen","tanto","demaciado","aterrado","pasar",
                "robando","desaparecida","dejando","centro comercial","jamon","sin","cambiando"
                ,"ortografia","cada","escoger","merecer","nadie/ninguno","cambiar","oveja","pareja","dado"
                ,"enojon","impresionante","entorno","sin embargo","escases","adecuadamente","carecen","aun"
                ,"pobreza","sanar","tasas","mientras que","entre","registros de salud","faltar","adicional/extra"
                ,"resultados","desconocidos","ademas","constituir","aunque","sobre","enfermedad","juntos","formal"
                ,"cual","traducir","dentro","conformidad","ambiente","presionado","investigacion","transportado"
                ,"apuntar","objetivo de","por lo tanto","con respecto a","bien","mas pobres","todo","articulador"
                ,"ambas cosas","a travez de","vamos","empezar","disponible","actualizaciones","anuncios","solo yo"
                ,"caracteristicas","repositorio","esencia","no se pudo","no hay","pronostico","aerotransportadora"
                ,"enfermedad","compleja","resto","una vez","ayudar","meta","mediante","dice","incluso/par","suma"
                ,"impar/extraño"};

            numberRandomOne();
            wordArrayTwo = WordsSpanishArray[numberone];
            lengthArrayTwo = WordsSpanishArray.Length.ToString();
            return wordArrayTwo;
        }

        public string lengArrayTwoFuntion()
        {
            return lengthArrayTwo;
        }

        public string wordsArraysThree() {
            String[] WordsSpanishEnglishArray = new String[] {"raise","louder","unbelief","weapon","heaven","fight"
                    ,"gonna","hear","roar","ashes","arise","defeated","alive","darkness","flee","fear"
                    ,"lost","hold","little","which has","feeling","such","flight","it was such","resume"
                    ,"summary","so much","too much","frightened","happen","stealing","missing","leaving"
                    ,"mall","ham","whitout","changing","spelling","each","choose","deserve","none"
                    ,"change","sheep","partner","angry","awesome","enviroment","however","shrotage","suitably"
                    ,"lack","event","poverty","health","rates","whereas","among","health recods","defaulted"
                    ,"additional","outcome","unknown","also","constirutes","althrough","over","given","disease"
                    ,"together","shape","which","traslate","into","accordance","enviroment","prested","research"
                    ,"carried","aim","aim of","therefore","regarding","well","poorest","whole","articulator","both"
                    ,"through","let's","begin","avalible","updates","announcements","jus me","features","repository"
                    ,"gist","failed to","no such","prognosis","airborne","disease","complex","remains","once"
                    ,"aid","goal","tells","even","sum","add","aumentar","mas fuerte","incredulidad","arma"
                ,"cielo","pelear","ir a","rugido","cesizas","aumentar","derrotado","vida","oscuridad"
                ,"huir", "temor","perdido","sostener","poco","que ha","sensacion","semejante","vuelo"
                ,"fue tan","resumen","extracto/resumen","tanto","demaciado","aterrado","pasar",
                "robando","desaparecida","dejando","centro comercial","jamon","sin","cambiando"
                ,"ortografia","cada","escoger","merecer","nadie/ninguno","cambiar","oveja","pareja","dado"
                ,"enojon","impresionante","entorno","sin embargo","escases","adecuadamente","carecen","aun"
                ,"pobreza","sanar","tasas","mientras que","entre","registros de salud","faltar","adicional/extra"
                ,"resultados","desconocidos","ademas","constituir","aunque","sobre","enfermedad","juntos","formal"
                ,"cual","traducir","dentro","conformidad","ambiente","presionado","investigacion","transportado"
                ,"apuntar","objetivo de","por lo tanto","con respecto a","bien","mas pobres","todo","articulador"
                ,"ambas cosas","a travez de","vamos","empezar","disponible","actualizaciones","anuncios","solo yo"
                ,"caracteristicas","repositorio","esencia","no se pudo","no hay","pronostico","aerotransportadora"
                ,"enfermedad","compleja","resto","una vez","ayudar","meta","mediante","dice","incluso/par","suma"
                ,"impar/extraño"};

            numberRandomTwo();
            wordArrayThree = WordsSpanishEnglishArray[numbertwo];
            lengthArrayThree = WordsSpanishEnglishArray.Length.ToString();
            return wordArrayThree;
        }

        public string lengArrayThreeFuntion()
        {
            return lengthArrayThree;
        }

        public void numberRandomOne()
        {
            Random rnd = new Random();                      //Se crea el objeto random rnd
            numberone = rnd.Next(1, 112);                  //Se asigna a la variable numberone un numero aleatorio entre 0 y 108
        }
        public void numberRandomTwo()
        {
            Random rnd = new Random();                      //Se crea el objeto random rnd
            numbertwo = rnd.Next(1, 224);                  //Se asigna a la variable numbertwo un numero aleatorio entre 0 y 108
        }
    }
   
}
