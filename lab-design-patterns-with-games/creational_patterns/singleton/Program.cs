using singleton;

Singleton jogador1 = Singleton.GetInstance();
jogador1.Mensagem("Jogador 1: A bola é minha!");

Singleton jogador2 = Singleton.GetInstance();
jogador2.Mensagem("Jogador 2: recebi a bola!");

Singleton jogador3 = Singleton.GetInstance();
jogador3.Mensagem("Jogador 3: dominou a bola no peito!");

Console.ReadKey();