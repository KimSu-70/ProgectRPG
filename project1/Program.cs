namespace project1
{
    internal class Program
    {
        enum Scene { Select, Confirm, Town, Town2, Town3, Town4, Forest, Forest2, Forest3, Forest4, End, End2, End3, End4, End5 }
        enum Item { portion = 1, sword, antidote, pendant }
        struct GameData
        {
            public bool running;
            public Scene scene;

            public string name;
            public Item item;
            public int curHP;
            public int maxHP;
            public int STR;
            public int INT;
            public int DEX;
            public int gold;
        }
        #region 엔딩 종류
        static void EndScene()
        {
            Console.Clear();
            switch (data.scene)
            {
                case Scene.End:
                    Console.WriteLine("==============================================");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                 YOU DIED                   |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("==============================================");
                    Console.WriteLine();
                    Console.WriteLine("희미해지는 시야 사이로 겁에 질린 마을여인의 얼굴이 보였다.");
                    Console.WriteLine("그녀는 매우 겁에 질린 표정으로 당신를 바라보고 있었고 당신은 곧 의식을 잃고 말았습니다.");
                    break;
                case Scene.End2:
                    Console.WriteLine("==============================================");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                 YOU DIED                   |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("==============================================");
                    Console.WriteLine();
                    Console.WriteLine("숲을 떠나 이동하는 중에 산짐승들에게 다시 한번 습격당했다.");
                    Console.WriteLine("침을 흘리며 이성을 잃은듯한 짐승들이 물어 뜯는 모습을 마지막으로 의식을 잃었다.");
                    break;
                case Scene.End3:
                    Console.WriteLine("==============================================");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                 YOU DIED                   |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("==============================================");
                    Console.WriteLine();
                    Console.WriteLine("무기를 들고 있던 몬스터들을 전멸 시킬 수 있었지만, 당신도 치명상을 입어 쓰러지고 말았다.");
                    Console.WriteLine("희미해지는 의식 사이로 사람들의 비명을 들으며 의식을 잃었다.");
                    break;
                case Scene.End4:
                    Console.Clear();
                    Console.WriteLine("==============================================");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                 Good End                   |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("==============================================");
                    Console.WriteLine();
                    Console.WriteLine("이제서야 기억이 났다. 내가 묻어줬던 모험가가 같이 갔던 동료이며");
                    Console.WriteLine("토벌 중에 내가 독에 당해 치료 하련던 동료를 몬스터로 보고 죽인것을...");
                    break;
                case Scene.End5:
                    Console.WriteLine("==============================================");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                 YOU DIED                   |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("==============================================");
                    Console.WriteLine();
                    Console.WriteLine("마을을 찾아 이동하는 중에 과다출혈로 의식을 일고 말았다.");
                    break;
                default:
                    break;
            }
            data.running = false;
        }
        #endregion

        static GameData data;
        static void Main(string[] args)
        {
            Start();

            while(data.running)
            {
                Run();
            }
            EndScene();
        }
        static void Start()
        {
            data = new GameData();

            data.running = true;

            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|              Poison Mushroom               |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("         시작하려면 아무 키나 누르세요          ");
            Console.ReadKey();
        }
        static void Run()
        {
            Console.Clear();

            switch (data.scene)
            {
                case Scene.Select:
                    SelecScene();
                    break;
                case Scene.Confirm:
                    ConfirmScene();
                    break;
                case Scene.Town:
                    TownScene();
                    break;
                case Scene.Town2:
                    TownScene2();
                    break;
                case Scene.Town3:
                    TownScene3();
                    break;
                case Scene.Town4:
                    TownScene4();
                    break;
                case Scene.Forest:
                    ForestScene();
                    break;
                case Scene.Forest2:
                    ForestScene2();
                    break;
                case Scene.Forest3:
                    ForestScene3();
                    break;
                case Scene.Forest4:
                    ForestScene4();
                    break;
                case Scene.End:
                case Scene.End2:
                case Scene.End3:
                case Scene.End4:
                case Scene.End5:
                    EndScene();
                    break;
            }
        }
        static void PrintProfile()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"이름 : {data.name,-6} 직업 : 모험가 ");
            Console.WriteLine($"체력 : {data.curHP,+3} / {data.maxHP}");
            Console.WriteLine($"힘 : {data.STR,-3} 지력 : {data.INT,-3} 민첩 : {data.DEX,-3}");
            Console.WriteLine($"소지금 : {data.gold,+5} G");
            Console.WriteLine("=====================================");
            Console.WriteLine();
        }
        static void Wait(float seconds)
        {
            Thread.Sleep((int)(seconds * 1000));
        }
        static void SelecScene()
        {
            Console.WriteLine("캐릭터의 이름을 입력하세요 : ");
            data.name = Console.ReadLine();
            if (data.name == "")
            {
                return;
            }

            Console.WriteLine("기본 소지템을 선택하세요.");
            Console.WriteLine("1.하급 포션");
            Console.WriteLine("2.롱소드");
            Console.WriteLine("3.깨진 해독제병");
            Console.WriteLine("4.펜던트");
            if (int.TryParse(Console.ReadLine(), out int select) == false)
            {
                Console.WriteLine("잘못 입력하셨습니다.");
                Wait(1);
                return;
            }
            else if (Enum.IsDefined(typeof(Item), select) == false)
            {
                Console.WriteLine("잘못 입력하셨습니다.");
                Wait(1);
                return;
            }
            else if (select == 3)
            {
                Console.WriteLine("깨진 해독제병은 사용 할수가 없습니다. 다시 선택해주세요.");
                Wait(1);
                return;
            }

            switch ((Item)select)
            {
                case Item.portion:
                    data.item = Item.portion;
                    data.maxHP = 200;
                    data.curHP = data.maxHP;
                    data.STR = 12;
                    data.INT = 2;
                    data.DEX = 12;
                    data.gold = 1500;
                    break;
                case Item.sword:
                    data.item = Item.sword;
                    data.maxHP = 140;
                    data.curHP = data.maxHP;
                    data.STR = 20;
                    data.INT = 2;
                    data.DEX = 12;
                    data.gold = 1500;
                    break;
                case Item.antidote:
                    data.item = Item.antidote;
                    data.maxHP = 140;
                    data.curHP = data.maxHP;
                    data.STR = 12;
                    data.INT = 2;
                    data.DEX = 12;
                    data.gold = 1500;
                    break;
                case Item.pendant:
                    data.item = Item.pendant;
                    data.maxHP = 140;
                    data.curHP = data.maxHP;
                    data.STR = 12;
                    data.INT = 10;
                    data.DEX = 12;
                    data.gold = 1400;
                    break;
            }
            data.scene = Scene.Confirm;
        }
        static void ConfirmScene()
        {
            // Render
            Console.WriteLine("===================");
            Console.WriteLine($"이름 : {data.name}");
            Console.WriteLine("직업 : 모험가");
            Console.WriteLine($"체력 : {data.maxHP}");
            Console.WriteLine($"힘   : {data.STR}");
            Console.WriteLine($"지력 : {data.INT}");
            Console.WriteLine($"민첩 : {data.DEX}");
            Console.WriteLine($"소지금 : {data.gold}");
            Console.WriteLine("===================");
            Console.WriteLine();
            Console.Write("이대로 플레이 하시겠습니까?(y/n)");

            // Input
            string input = Console.ReadLine();

            // Update
            switch (input)
            {
                case "Y":
                case "y":
                    Console.Clear();
                    Console.WriteLine("당신은 치열한 사투 끝에 토벌 받은 의뢰를 달성 할 수 있었습니다.");
                    Wait(1);
                    Console.WriteLine("몬스터의 일부를 잘라내어 챙긴 후 마을로 이동 할 준비를 하였다.");
                    Wait(1);
                    Console.WriteLine("의뢰 달성 보고를 위해 마을로 이동합니다.");
                    Wait(2);
                    data.scene = Scene.Town;
                    break;
                case "N":
                case "n":
                    data.scene = Scene.Select;
                    break;
                default:
                    data.scene = Scene.Confirm;
                    break;
            }
        }
        static void TownScene()
        {
            // Render
            PrintProfile();
            Console.WriteLine("마을에 도착하니 사람들이 보이지 않았다.");
            Console.WriteLine("어디로 이동하겠습니까?");
            Console.WriteLine("1. 광장");
            Console.WriteLine("2. 마을 밖 숲");
            Console.Write("선택 : ");

            // Input
            string input = Console.ReadLine();

            // Update
            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("광장으로 이동합니다...");
                    Wait(2);
                    data.scene = Scene.Town2;
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("마을 밖 숲으로 이동합니다...");
                    Wait(2);
                    data.scene = Scene.Forest;
                    break;
            }
        }
        static void TownScene2()
        {
            Console.WriteLine("광장에 도착하니 몬스터들이 돌아다니는게 보였다.");
            Wait(1);
            Console.WriteLine("이미 마을이 몬스터들에게 점령 됬다고 생각한 당신은 어떻게 해야 할지 고민 했다.");
            Wait(1);
            Console.WriteLine();
            Console.WriteLine("당신의 행동을 선택해주세요");
            Console.WriteLine("1. 눈 앞에 오크부터 공격한다.");
            Console.WriteLine("2. 오크 옆에 고블린 부터 처리 한다.");
            Console.WriteLine("3. 몬스터가 어느 경로로 왔는지 숲을 조사한다.");
            Console.Write("선택 : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    if (data.STR > 18)
                    {
                        Console.WriteLine("당신의 공격은 오크에게 치명적이었습니다!");
                        Wait(1);
                        Console.WriteLine("오크가 즉사하였습니다!");
                        Wait(1);
                        Console.WriteLine("옆에 있던 고블린이 두렵다는 듯이 당신을 쳐다보고 있습니다.");
                        Wait(2);
                        data.gold += 285;
                        Console.Clear();
                        Console.WriteLine("다른 몬스터들이 다가오고 있습니다.");
                        Wait(2);
                        data.scene = Scene.Town3;
                    }
                    else
                    {
                        Console.WriteLine("기습적인 당신의 공격은 오크의 왼팔을 자르는데 성공하였습니다.");
                        Wait(1);
                        Console.WriteLine("오크가 반격했습니다!");
                        Wait(1);
                        Console.WriteLine("20의 체력 피해를 받았습니다!");
                        Wait(2);
                        data.curHP -= 20;
                        Console.Clear();
                        Console.WriteLine("다른 몬스터들이 다가오고 있습니다.");
                        Wait(2);
                        data.scene = Scene.Town3;
                    }
                    break;
                case "2":
                    if (data.STR > 18)
                    {
                        Console.WriteLine("당신의 공격은 고블린에게 치명적이었습니다!");
                        Wait(1);
                        Console.WriteLine("고블린이 즉사하였습니다.");
                        Wait(1);
                        Console.WriteLine("오크가 분노에 가득찬 눈빛으로 달려들었습니다.");
                        Wait(1);
                        data.gold += 50;
                        Console.WriteLine("25의 체력 피해를 받았지만, 오크를 쓰러뜨릴수 있었습니다!");
                        Wait(2);
                        data.curHP -= 25;
                        data.gold += 215;
                        Console.Clear();
                        Console.WriteLine("다른 몬스터들이 다가오고 있습니다.");
                        Wait(2);
                        data.scene = Scene.Town3;
                    }
                    else
                    {
                        Console.WriteLine("당신의 공격은 오크에게 저지 당했습니다.");
                        Wait(1);
                        Console.WriteLine("오크가 반격했습니다!");
                        Wait(1);
                        Console.WriteLine("30의 체력 피해를 받았습니다!");
                        Wait(2);
                        data.curHP -= 30;
                        Console.Clear();
                        Console.WriteLine("다른 몬스터들이 다가오고 있습니다.");
                        Wait(2);
                        data.scene = Scene.Town3;
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("광장을 벗어나 숲으로 이동합니다.");
                    Wait(2);
                    data.scene = Scene.Forest;
                    break;
            }
        }
        static void ForestScene()
        {
            Console.WriteLine("적막한 숲입니다.");
            Wait(1);
            Console.WriteLine("마을을 벗어나 이동 중에 낯익은 모험가의 시체를 발견하였습니다.");
            Wait(1);
            Console.WriteLine("시체에 남은 흔적을 조사하였습니다.");
            Wait(1);
            Console.WriteLine("발자국은 숲 안쪽으로 향하고 있습니다.");
            Console.WriteLine();
            Console.WriteLine("당신의 행동을 선택해주세요");
            Console.WriteLine("1. 무기를 가져간다 (힘 UP)");
            Console.WriteLine("2. 시체를 묻어준다.");

            Console.Write("선택 : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("당신은 모험가 시체에서 무기를 챙겼습니다.");
                    data.STR += 8;
                    Wait(2);

                    break;
                case "2":
                    if (data.INT > 9)
                    {
                        Console.WriteLine("당신은 모험가의 시체를 묻어 주었습니다.");
                        Wait(1);
                        Console.WriteLine("묻어주고 말없이 펜던트의 사진을 바라보았습니다.");
                        data.INT += 5;
                        Wait(1);
                    }
                    else
                    {
                        Console.WriteLine("당신은 모험가의 시체를 묻어 주었습니다.");
                        Wait(1);
                    }
                    break;
                default:
                    break;
            }
            Console.Clear();
            Console.WriteLine("애도를....");
            Wait(2);
            data.scene = Scene.Forest2;
        }
        static void ForestScene2()
        {
            Console.WriteLine("다음으로 무엇을 하면 좋을까?");
            Wait(1);
            Console.WriteLine();
            Console.WriteLine("당신의 행동을 선택해주세요");
            Console.WriteLine("1. 마을로 돌아간다");
            Console.WriteLine("2. 발자국을 따라 간다.");

            Console.Write("선택 : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("마을로 돌아 갑니다.");
                    Wait(1);
                    data.scene = Scene.Town;

                    break;
                case "2":
                    Console.WriteLine("숲 안쪽으로 이동합니다.");
                    Wait(1);
                    data.scene = Scene.Forest3;

                    break;
            }
        }
        static void ForestScene3()
        {
            Console.WriteLine("발자국을 쫒아 이동중에 낯익은 장소에 도착했다.");
            Wait(1);
            Console.WriteLine("분명 본 기억이 있는 장소 인데... 잘 기억이 나지를 않는다.");
            Wait(1);
            Console.WriteLine("근처를 조사하니 발자국의 주인으로 생각되는 몬스터가 죽어 있었다.");
            Wait(1);
            Console.WriteLine();
            Console.WriteLine("당신의 행동을 선택해주세요");
            Console.WriteLine("1. 주변을 더 조사한다.");
            Console.WriteLine("2. 숲을 떠난다.");

            Console.Write("선택 : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    if (data.INT > 14)
                    {
                        Console.WriteLine("몬스터의 시체쪽 숲풀에서 백팩을 발견하였다.");
                        Wait(1);
                        Console.WriteLine("백팩 안에 멀쩡한 해독제 병 하나를 찾을 수 있었다.");
                        Wait(1);
                        Console.WriteLine("그때 갑자기 사슴이 달려 들며 왼손을 공격하였다!");
                        Wait(1);
                        Console.WriteLine("사슴의 물기 공격 20의 체력 피해를 받았습니다!");
                        Wait(2);
                        data.curHP -= 20;
                        data.scene = Scene.Forest4;
                    }
                    else
                    {
                        Console.WriteLine("몬스터의 시체쪽 숲풀에 미쳐 날뛰는 산짐승들이 있었다.");
                        Wait(1);
                        Console.WriteLine("방심한 사이 사슴에게 왼손을 공격 당했다!");
                        Wait(1);
                        Console.WriteLine("사슴의 물기 공격 20의 체력 피해를 받았습니다!");
                        Wait(2);
                        data.curHP -= 20;
                        data.scene = Scene.Forest4;
                    }
                    break;
                case "2":
                    Console.WriteLine("숲을 떠나 다른곳으로 이동하였다.");
                    Wait(2);
                    data.scene = Scene.End2;
                    break;
            }
        }
        static void ForestScene4()
        {
            Console.WriteLine("간신히 사슴을 죽이고 그 자리를 벗어났다.");
            Wait(1);
            Console.WriteLine("동물들의 상태로 볼때 병에 걸렸을 확률이 있어 어떻게 해야 할지 고민 됬다.");
            Wait(1);
            Console.WriteLine();
            Console.WriteLine("당신의 행동을 선택해주세요");
            Console.WriteLine("1. 상처를 치료 한다");
            Console.WriteLine("2. 다른 마을에서 의사를 찾기 위해 이동한다.");

            Console.Write("선택 : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    if (data.INT > 14)
                    {
                        Console.WriteLine("아까 주웠던 해독제 병을 사용하여 상처를 치유하였다.");
                        Wait(1);
                        Console.WriteLine("이게 잘 먹히기를...");
                        Wait(1);
                        Console.WriteLine("임시방편으로 치료한 당신은 마을로 이동하였다.");
                        Wait(2);
                        data.scene = Scene.Town4;
                    }
                    else
                    {
                        Console.WriteLine("왼팔을 압박하고 추가적인 감염을 막기 위해 왼손을 잘라내었다.");
                        Wait(1);
                        Console.WriteLine("30의 체력 피해를 받았습니다!");
                        Wait(1);
                        data.curHP -= 30;
                        Console.WriteLine("추가적인 치료를 받기 위해 마을을 찾아 이동하였다.");
                        Wait(2);
                        data.scene = Scene.End5;
                    }
                    break;
                case "2":
                    Console.WriteLine("다른 마을을 찾아 이동하는 중에 상처가 벌어지고 말았다.");
                    Wait(1);
                    Console.WriteLine("고통을 참고 대충 상처를 압박한 당신은 빠르게 이동하였다.");
                    Wait(2);
                    data.scene = Scene.End5;

                    break;
            }
        }
        static void TownScene3()
        {
            Console.WriteLine("당신은 몬스터들에게 둘러싸였다.");
            Wait(1);
            Console.WriteLine("몬스터들을 창이나, 검을 들고 당신을 바라보고 있다.");
            Wait(1);
            Console.WriteLine();
            Console.WriteLine("당신의 행동을 선택해주세요");
            Console.WriteLine("1. 전심전력으로 싸운다");
            Console.Write("선택 : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    if (data.STR > 26)
                    {
                        Console.WriteLine("당신의 공격은 몬스터들에게 치명적이었습니다!");
                        Wait(1);
                        Console.WriteLine("일격에 오크가 즉사하였습니다.");
                        Wait(1);
                        Console.WriteLine("다른 몬스터들이 그 모습을 보고 겁을 먹었는지 멈칫하는 순간");
                        Wait(1);
                        Console.WriteLine("기회를 놓치지 않고 당신은 달려 들었습니다.");
                        Wait(2);
                        data.scene = Scene.End3;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("당신은 최선을 다해 싸웠지만 여러 명을 상대하는 것은 힘들었습니다.");
                        Wait(1);
                        Console.WriteLine("두려움을 참으며, 사력을 다해 검을 휘둘렀습니다.");
                        Wait(2);
                        data.scene = Scene.End;
                        break;
                    }
            }
        }
        static void TownScene4()
        {
            Console.WriteLine("마을에 도착해 보니 사람들이 보였다.");
            Wait(1);
            Console.WriteLine("당신은 상처를 치료 받고 토벌 의뢰 달성을 보고하러 이동하였다");
            Wait(1);
            Console.WriteLine();
            Console.WriteLine("당신의 행동을 선택해주세요");
            Console.WriteLine("1. 토벌 의뢰 달성을 보고하러 간다");
            Console.Write("선택 : ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("접수원: 포이즌 머쉬룸 토벌 확인 되었습니다.");
                    Wait(1);
                    Console.WriteLine("접수원: 여기 토벌 보수 입니다");
                    Wait(1);
                    Console.WriteLine("700 골드를 얻었습니다!");
                    Wait(1);
                    data.gold += 700;
                    break;

            }
            Console.Clear();
            Console.WriteLine("접수원:그런데 같이 갔던 분은 어디 계시나요?");
            Wait(2);
            data.scene = Scene.End4;
        }
    }
}
