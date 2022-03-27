namespace cs18_paskaita_Store.Functionality
{
    public class BarcodeAuthenticator
    {
        public string ItemIdentifier(float barcode)
        {
            string returningName = "";
            switch (barcode)
            {
                case 20011:
                    returningName = "Šokoladas";
                    break;
                case 20022:
                    returningName = "Juodas Šokoladas";
                    break;
                case 20023:
                    returningName = "Confeti";
                    break;
                case 20024:
                    returningName = "BonBons";
                    break;

                case 10001:
                    returningName = "Vištiena";
                    break;
                case 10002:
                    returningName = "Kiauliena";
                    break;
                case 10003:
                    returningName = "Jautiena";
                    break;
                case 10004:
                    returningName = "Antiena";
                    break;

                case 30031:
                    returningName = "Pomidoras";
                    break;
                case 30032:
                    returningName = "Agurkas";
                    break;
                case 30033:
                    returningName = "Bulvė";
                    break;
                case 30034:
                    returningName = "Morka";
                    break;

                case 40041:
                    returningName = "Cola";
                    break;
                case 40042:
                    returningName = "Vanduo";
                    break;
                case 40043:
                    returningName = "Sultys";
                    break;
                case 40044:
                    returningName = "Pienas";
                    break;
            }
            return returningName;
        }
    }
}
