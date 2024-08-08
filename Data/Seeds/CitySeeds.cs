using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeds
{
    public static class CitySeeds
    {
        public static void Cities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CityEntity>().HasData(
                // Acre (AC)
                new CityEntity { Id = 1, Name = "Acrelândia", UfId = 1 },
                new CityEntity { Id = 2, Name = "Assis Brasil", UfId = 1 },
                new CityEntity { Id = 3, Name = "Brasiléia", UfId = 1 },
                new CityEntity { Id = 4, Name = "Bujari", UfId = 1 },
                new CityEntity { Id = 5, Name = "Capixaba", UfId = 1 },
                new CityEntity { Id = 6, Name = "Cruzeiro do Sul", UfId = 1 },
                new CityEntity { Id = 7, Name = "Epitaciolândia", UfId = 1 },
                new CityEntity { Id = 8, Name = "Feijó", UfId = 1 },
                new CityEntity { Id = 9, Name = "Jordão", UfId = 1 },
                new CityEntity { Id = 10, Name = "Mâncio Lima", UfId = 1 }
            );

            //List<CityEntity> cities = new List<CityEntity>();

            // Acre (AC)
            //cities.AddRange(GetCitiesForState(1, "Acrelândia", "Assis Brasil", "Brasiléia", "Bujari", "Capixaba", "Cruzeiro do Sul", "Epitaciolândia", "Feijó", "Jordão", "Mâncio Lima"));

            //// Alagoas (AL)
            //cities.AddRange(GetCitiesForState(2, "Água Branca", "Anadia", "Arapiraca", "Atalaia", "Barra de Santo Antônio", "Barra de São Miguel", "Batalha", "Belém", "Belo Monte", "Boca da Mata"));

            //// Amapá (AP)
            //cities.AddRange(GetCitiesForState(3, "Amapá", "Calçoene", "Cutias", "Ferreira Gomes", "Itaubal", "Laranjal do Jari", "Macapá", "Mazagão", "Oiapoque", "Pedra Branca do Amapari"));

            //// Amazonas (AM)
            //cities.AddRange(GetCitiesForState(4, "Alvarães", "Amaturá", "Anamã", "Anori", "Apuí", "Atalaia do Norte", "Autazes", "Barcelos", "Barreirinha", "Benjamin Constant"));

            //// Bahia (BA)
            //cities.AddRange(GetCitiesForState(5, "Abaíra", "Abaré", "Acajutiba", "Adustina", "Água Fria", "Aiquara", "Alagoinhas", "Alcobaça", "Almadina", "Amargosa"));

            //// Ceará (CE)
            //cities.AddRange(GetCitiesForState(6, "Abaiara", "Acarapé", "Acaraú", "Acopiara", "Aiuaba", "Alcântaras", "Altaneira", "Alto Santo", "Amontada", "Antonina do Norte"));

            //// Distrito Federal (DF)
            //cities.AddRange(GetCitiesForState(7, "Brasília"));

            //// Espírito Santo (ES)
            //cities.AddRange(GetCitiesForState(8, "Afonso Cláudio", "Água Doce do Norte", "Águia Branca", "Alegre", "Alfredo Chaves", "Alto Rio Novo", "Anchieta", "Apiacá", "Aracruz", "Atilio Vivacqua"));

            //// Goiás (GO)
            //cities.AddRange(GetCitiesForState(9, "Abadia de Goiás", "Abadiânia", "Acreúna", "Adelândia", "Água Fria de Goiás", "Água Limpa", "Águas Lindas de Goiás", "Alexânia", "Aloândia", "Alto Horizonte"));

            //// Maranhão (MA)
            //cities.AddRange(GetCitiesForState(10, "Açailândia", "Afonso Cunha", "Água Doce do Maranhão", "Alcântara", "Aldeias Altas", "Altamira do Maranhão", "Alto Alegre do Maranhão", "Alto Alegre do Pindaré", "Alto Parnaíba", "Amapá do Maranhão"));

            //// Mato Grosso (MT)
            //cities.AddRange(GetCitiesForState(11, "Acorizal", "Água Boa", "Alta Floresta", "Alto Araguaia", "Alto Boa Vista", "Alto Garças", "Alto Paraguai", "Alto Taquari", "Apiacás", "Araguaiana"));

            //// Mato Grosso do Sul (MS)
            //cities.AddRange(GetCitiesForState(12, "Água Clara", "Alcinópolis", "Amambaí", "Anastácio", "Anaurilândia", "Angélica", "Antônio João", "Aparecida do Taboado", "Aquidauana", "Aral Moreira"));

            //// Minas Gerais (MG)
            //cities.AddRange(GetCitiesForState(13, "Abadia dos Dourados", "Abaeté", "Abre Campo", "Acaiaca", "Açucena", "Água Boa", "Água Comprida", "Aguanil", "Águas Formosas", "Águas Vermelhas"));

            //// Pará (PA)
            //cities.AddRange(GetCitiesForState(14, "Abaetetuba", "Abel Figueiredo", "Acará", "Afuá", "Água Azul do Norte", "Alenquer", "Almeirim", "Altamira", "Anajás", "Ananindeua"));

            //// Paraíba (PB)
            //cities.AddRange(GetCitiesForState(15, "Água Branca", "Aguiar", "Alagoa Grande", "Alagoa Nova", "Alagoinha", "Alcantil", "Algodão de Jandaíra", "Alhandra", "São João do Rio do Peixe", "São João do Tigre"));

            //// Paraná (PR)
            //cities.AddRange(GetCitiesForState(16, "Abatiá", "Adrianópolis", "Agudos do Sul", "Almirante Tamandaré", "Altamira do Paraná", "Alto Paraíso", "Alto Paraná", "Alto Piquiri", "Altônia", "Alvorada do Sul"));

            //// Pernambuco (PE)
            //cities.AddRange(GetCitiesForState(17, "Abreu e Lima", "Afogados da Ingazeira", "Afrânio", "Agrestina", "Água Preta", "Águas Belas", "Alagoinha", "Aliança", "Altinho", "Amaraji"));

            //// Piauí (PI)
            //cities.AddRange(GetCitiesForState(18, "Acauã", "Agricolândia", "Água Branca", "Alagoinha do Piauí", "Alegrete do Piauí", "Alto Longá", "Altos", "Alvorada do Gurguéia", "Amarante", "Angical do Piauí"));

            //// Rio de Janeiro (RJ)
            //cities.AddRange(GetCitiesForState(19, "Angra dos Reis", "Aperibé", "Araruama", "Areal", "Armação dos Búzios", "Arraial do Cabo", "Barra do Piraí", "Barra Mansa", "Belford Roxo", "Bom Jardim"));

            //// Rio Grande do Norte (RN)
            //cities.AddRange(GetCitiesForState(20, "Acari", "Açu", "Afonso Bezerra", "Água Nova", "Alexandria", "Almino Afonso", "Alto do Rodrigues", "Angicos", "Antônio Martins", "Apodi"));

            //// Rio Grande do Sul (RS)
            //cities.AddRange(GetCitiesForState(21, "Aceguá", "Água Santa", "Agudo", "Ajuricaba", "Alecrim", "Alegrete", "Alegria", "Almirante Tamandaré do Sul", "Alpestre", "Alto Alegre"));

            //// Rondônia (RO)
            //cities.AddRange(GetCitiesForState(22, "Alta Floresta do Oeste", "Alto Alegre dos Parecis", "Alto Paraíso", "Alvorada d'Oeste", "Ariquemes", "Buritis", "Cabixi", "Cacaulândia", "Cacoal", "Campo Novo de Rondônia"));

            //// Roraima (RR)
            //cities.AddRange(GetCitiesForState(23, "Alta Floresta do Oeste", "Alto Alegre dos Parecis", "Alto Paraíso", "Alvorada d'Oeste", "Ariquemes", "Buritis", "Cabixi", "Cacaulândia", "Cacoal", "Campo Novo de Rondônia"));

            //// Santa Catarina (SC)
            //cities.AddRange(GetCitiesForState(24, "Abdon Batista", "Abelardo Luz", "Agrolândia", "Agronômica", "Água Doce", "Águas de Chapecó", "Águas Frias", "Águas Mornas", "Alfredo Wagner", "Alto Bela Vista"));

            //// São Paulo (SP)
            //cities.AddRange(GetCitiesForState(25, "Adamantina", "Adolfo", "Aguaí", "Águas da Prata", "Águas de Lindóia", "Águas de Santa Bárbara", "Águas de São Pedro", "Agudos", "Alambari", "Alfredo Marcondes"));

            //// Sergipe (SE)
            //cities.AddRange(GetCitiesForState(26, "Amparo de São Francisco", "Aquidabã", "Aracaju", "Arauá", "Areia Branca", "Barra dos Coqueiros", "Boquim", "Brejo Grande", "Campo do Brito", "Canhoba"));

            //// Tocantins (TO)
            //cities.AddRange(GetCitiesForState(27, "Abreulândia", "Aguiarnópolis", "Aliança do Tocantins", "Almas", "Alvorada", "Ananás", "Angico", "Aparecida do Rio Negro", "Aragominas", "Araguacema"));

            //modelBuilder.Entity<CityEntity>().HasData(cities);
        }

        //private static List<CityEntity> GetCitiesForState(int stateId, params string[] cityNames)
        //{
        //    List<CityEntity> cities = new List<CityEntity>();
        //    UfEntity uf = new UfEntity { Id = stateId };

        //    foreach (var cityName in cityNames)
        //    {
        //        cities.Add(new CityEntity { Uf = uf, Name = cityName });
        //    }
        //    return cities;
        //}
    }
}
