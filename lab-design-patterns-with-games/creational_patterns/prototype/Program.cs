using prototype;

GerenciadorNuvens gerenciador_de_nuvens = new();
gerenciador_de_nuvens["padrao"] = new NuvemConcreta("branco", "azul");
gerenciador_de_nuvens["personalizada"] = new NuvemConcreta("branco", "laranja");

NuvemConcreta um = gerenciador_de_nuvens["padrao"].Clone() as NuvemConcreta;
NuvemConcreta dois = gerenciador_de_nuvens["personalizada"].Clone() as NuvemConcreta;
NuvemConcreta tres = gerenciador_de_nuvens["padrao"].Clone() as NuvemConcreta;

Console.ReadKey();