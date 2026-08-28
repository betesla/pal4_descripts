// Structured PAL4 reconstruction for M08.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M08_1_init()
{
    if (global_mvar == 50401)
    {
        func2001();
    }
    if (global_mvar >= 50600)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("title01", false);
        giArenaReadyRestore();
    }
}

void M08_2_init()
{
    bool candlelight01_ctrl_visible = false;
    bool candlelight04_ctrl_visible = false;
    float current_player_pos_y = 0.0;

    candlelight01_ctrl_visible = giGetVisibleObject("candlelight01_ctrl");
    candlelight04_ctrl_visible = giGetVisibleObject("candlelight04_ctrl");
    if (giGetVisibleObject("candlelight01_ctrl"))
    {
        giEventVolumeVisible("wall01", false);
    }
    if (candlelight04_ctrl_visible)
    {
        giEventVolumeVisible("wall02", false);
    }
    current_player_pos_y = giPlayerCurrentGetPosY();
    if (giPlayerCurrentGetPosY() < 130.0)
    {
        func7500();
    }
    else
    {
        func7501();
    }
    giArenaReadyRestore();
}

void M08_3_init()
{
    bool candlelight02_ctrl_visible = false;
    bool candlelight03_ctrl_visible = false;
    bool candlelight04_ctrl_visible = false;
    bool candlelight06_ctrl_visible = false;
    float current_player_pos_y = 0.0;

    candlelight02_ctrl_visible = giGetVisibleObject("candlelight02_ctrl");
    candlelight03_ctrl_visible = giGetVisibleObject("candlelight03_ctrl");
    candlelight04_ctrl_visible = giGetVisibleObject("candlelight04_ctrl");
    candlelight06_ctrl_visible = giGetVisibleObject("candlelight06_ctrl");
    if (candlelight03_ctrl_visible && giGetVisibleObject("candlelight02_ctrl"))
    {
        giEventVolumeVisible("wall01", false);
    }
    if (candlelight04_ctrl_visible && candlelight06_ctrl_visible)
    {
        giEventVolumeVisible("wall02", false);
    }
    current_player_pos_y = giPlayerCurrentGetPosY();
    if (giPlayerCurrentGetPosY() < 130.0)
    {
        func7500();
    }
    else
    {
        func7501();
    }
    giArenaReadyRestore();
}

void M08_4_init()
{
    bool candlelight01_ctrl_visible = false;
    bool candlelight02_ctrl_visible = false;
    bool candlelight03_ctrl_visible = false;
    bool candlelight04_ctrl_visible = false;
    float current_player_pos_y = 0.0;

    candlelight01_ctrl_visible = giGetVisibleObject("candlelight01_ctrl");
    candlelight02_ctrl_visible = giGetVisibleObject("candlelight02_ctrl");
    candlelight03_ctrl_visible = giGetVisibleObject("candlelight03_ctrl");
    candlelight04_ctrl_visible = giGetVisibleObject("candlelight04_ctrl");
    if (candlelight02_ctrl_visible && candlelight03_ctrl_visible && giGetVisibleObject("candlelight01_ctrl"))
    {
        giEventVolumeVisible("wall01", false);
    }
    if (candlelight04_ctrl_visible)
    {
        giEventVolumeVisible("wall02", false);
    }
    current_player_pos_y = giPlayerCurrentGetPosY();
    if (giPlayerCurrentGetPosY() < 130.0)
    {
        func7500();
    }
    else
    {
        func7501();
    }
    giArenaReadyRestore();
}

void M08_5_init()
{
    if (global_mvar == 50600)
    {
        giSetNpcVisible("MN001", true);
        giNpcDoAction("MN001", "J01", -1, false);
        giArenaReadyRestore();
    }
    if (global_mvar != 50800)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2003();
    }
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    if (!giBGMConfigIsInArea("1"))
    {
        giArenaLoad("M08", "1", "", true);
    }
    giPlayerCurrentSetPos(1057.7, 1.0, -839.4);
    giPlayerCurrentSetAng(309.0);
    giCameraSetMode(5, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    giPlayerLock();
    giFlashOutBlack(0.5, true, true);
    giPlayerCurrentSetPos(-700.3, 1.0, 780.4);
    giPlayerCurrentSetAng(136.0);
    giCameraSetMode(5, true);
    giArenaReady();
    giFlashInBlack(0.5, true);
    giPlayerUnLock();
}

void func1002()
{
    giPlayerLock();
    giFlashOutBlack(0.5, true, true);
    giPlayerCurrentSetPos(-888.4, 1.0, 997.7);
    giPlayerCurrentSetAng(316.0);
    giCameraSetMode(5, true);
    giArenaReady();
    giFlashInBlack(0.5, true);
    giPlayerUnLock();
}

void func1003()
{
    giArenaLoad("M08", "2", "", true);
    giPlayerCurrentSetPos(584.7, 8.0, 28.1);
    giPlayerCurrentSetAng(165.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("M08", "1", "", true);
    giPlayerCurrentSetPos(757.4, 273.0, -268.7);
    giPlayerCurrentSetAng(350.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("M08", "3", "", true);
    giPlayerCurrentSetPos(904.1, 2.6, -162.3);
    giPlayerCurrentSetAng(191.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("M08", "2", "", true);
    giPlayerCurrentSetPos(894.3, 332.8, 127.5);
    giPlayerCurrentSetAng(320.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("M08", "4", "", true);
    giPlayerCurrentSetPos(909.9, 1.0, -165.8);
    giPlayerCurrentSetAng(210.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("M08", "3", "", true);
    giPlayerCurrentSetPos(918.0, 279.4, 217.6);
    giPlayerCurrentSetAng(327.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("M08", "5", "", true);
    giPlayerCurrentSetPos(716.6, 242.9, -11.4);
    giPlayerCurrentSetAng(200.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("M08", "4", "", true);
    giPlayerCurrentSetPos(932.2, 327.5, 143.3);
    giPlayerCurrentSetAng(333.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("Q04", "Q04HY", "", true);
    giPlayerCurrentSetPos(3011.7, 299.9, -4115.1);
    giPlayerCurrentSetAng(44.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func2001()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giSetObjectVisible("entrance1", false);
    giPlayerSetPos(0, 1282.3, 1.0, 383.9);
    giPlayerSetAng(0, 172.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 1287.2, 1.0, 483.7);
    giPlayerSetAng(1, 324.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, 1230.1, 1.0, 423.4);
    giPlayerSetAng(2, 202.0);
    giPlayerSetVisible(2, true);
    giSetNpcVisible("MN001", true);
    giAddPlayerFavor(0, 1, -10);
    giAddPlayerFavor(0, 2, -30);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.5, false);
    giArenaReady();
    giPlayerDoAction(0, "J13", -1, false);
    giWait(0.7);
    giSetPortrait("106A", false);
    giTalk("柳梦璃：……这千佛塔内确实是宝气庄严……", "42069");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("211A", true);
    giTalk("琴姬：秦家家大业大，<colour red=255 green=187 blue=0 alpha=255>相公的牌位应该是供在最上面几层，我们边走边找吧。</colour>", "42070");
    giIMMBegin();
    giPlayerSetDir(1, 146.0, false);
    giPlayerSetDir(0, 40.0, false);
    giPlayerSetDir(2, 91.0, false);
    giIMMEnd();
    giWait(0.8);
    giSetPortrait("101B", false);
    giTalk("云天河：好！", "42071");
    giWait(0.3);
    giFlashOutBlack(1.5, true, true);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(2, false);
    giSetNpcVisible("MN001", false);
    global_mvar = 50402; // 0x0000C4E2, 第一章 / 3-3-4.弦歌问情 / 塔中寻牌位
    giSetObjectVisible("entrance1", true);
    giIMMEnd();
    giPlayerCurrentSetPos(1230.1, 1.0, 423.4);
    giPlayerCurrentSetAng(339.0);
    giPlayerCurrentSetVisible(true);
    giCameraSetMode(5, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func2002()
{
    if (global_mvar == 50600)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giHideGASkillObject();
        giSetObjectVisible("save1", false);
        giPlayerSetPos(0, 543.8, 242.4, 388.3);
        giPlayerSetAng(0, 309.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 487.2, 242.4, 415.7);
        giPlayerSetAng(1, 329.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(2, 564.8, 242.4, 452.1);
        giPlayerSetAng(2, 297.0);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("MN003", true);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：啊，这里有人？！不是和尚！", "42072");
        giScriptMusicPlay("P31", 2, 0.0, 2.5);
        giWait(0.5);
        giCameraRunSingle("002", true);
        giWait(2.5);
        giCameraRunSingle("003", true);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetPos(0, 269.8, 242.4, 551.4);
        giPlayerSetAng(0, 322.0);
        giPlayerSetPos(1, 225.5, 242.4, 577.8);
        giPlayerSetAng(1, 330.0);
        giPlayerSetPos(2, 330.1, 242.4, 651.2);
        giPlayerSetAng(2, 299.0);
        giNpcSetPos("MN003", 246.7, 242.4, 651.3);
        giNpcSetAng("MN003", 314.0);
        giSetNpcVisible("MN003", true);
        giIMMEnd();
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giNpcSetDir("MN001", 134.0, false);
        giCameraRunSingle("004", true);
        giNpcWalkTo("MN003", 111.8, 242.4, 790.6, false);
        giWait(0.5);
        gi2DSoundPlay("WJ060", 1);
        giPlayerWalkTo(2, 170.9, 242.4, 788.5, false);
        giWait(0.5);
        giPlayerWalkTo(1, 91.7, 242.4, 757.2, false);
        giWait(0.5);
        gi2DSoundPlay("WJ060", 1);
        giPlayerWalkTo(0, 149.6, 242.4, 705.1, false);
        giNpcEndMove("MN003");
        giNpcSetDir("MN003", 312.0, false);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 293.0, false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 340.0, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 325.0, true);
        giWait(0.6);
        giSetPortrait("212A", true);
        giTalk("姜氏：……我知道，终有一天你会来的……虽然我们从来没有见过面，但是我一眼就能认出你……", "42073");
        giSetPortrait("211A", false);
        giTalk("琴姬：你是……？", "42074");
        giSetPortrait("212A", true);
        giTalk("姜氏：想不出吗？……我却是一眼就认出你了。", "42075");
        giSetPortrait("211A", false);
        giTalk("琴姬：……！你是秦逸他、他的——", "42076");
        giCameraRunSingle("005", true);
        giWait(0.3);
        giSetPortrait("212A", false);
        giTalk("姜氏：他的妾。", "42077");
        giSetPortrait("212A", false);
        giTalk("姜氏：……直到相公过世，我也做不了他的妻子，你尽可安心，我的名份永远都只是一个妾。", "42078");
        giCameraRunSingle("006", true);
        giWait(0.3);
        giNpcDoAction("MN003", "C09", 1, false);
        giSetPortrait("211A", true);
        giTalk("琴姬：我……我从来没有这样想过……", "42079");
        giSetPortrait("212A", false);
        giTalk("姜氏：不管你是怎么想的，在相公和公公婆婆心里，我却胜过你这个妻子百倍千倍！", "42080");
        giSetPortrait("212A", false);
        giTalk("姜氏：若不是相公心肠太好，顾念一点旧情，今天又哪里轮到你坐正妻之位！", "42081");
        giSetPortrait("211A", true);
        giTalk("琴姬：…………", "42082");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：喂，你别这么尖酸刻薄地欺负人！人都过世了，争这些有的没的名份还有什么用！", "42083");
        giCameraRunSingle("005", true);
        giWait(0.3);
        giSetPortrait("212A", false);
        giTalk("姜氏：小姑娘，你说的太好了。", "42084");
        giSetPortrait("212A", false);
        giTalk("姜氏：没什么可争的，毕竟相公生前，是我日日夜夜侍候左右，替他熬药穿衣，他也待我惜如珍宝。", "42085");
        giSetPortrait("212A", false);
        giTalk("姜氏：夫妻同心，心意相连，就算……就算他的病再也没法治了，这短短数月，不也如神仙眷侣一般——", "42086");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("006", true);
        giWait(0.3);
        giNpcDoAction("MN003", "C09", 1, false);
        giSetPortrait("211A", true);
        giTalk("琴姬：不、不要说了！", "42087");
        giSetPortrait("212A", false);
        giTalk("姜氏：怎么？你不爱听？不爱听我和相公是如何恩爱？", "42088");
        giSetPortrait("212A", false);
        giTalk("姜氏：你可知，妇人妒忌、合当七出？也难怪公公婆婆不喜欢你——", "42089");
        giNpcDoAction("MN003", "C09", 1, false);
        giSetPortrait("211A", true);
        giTalk("琴姬：求你……求你别再说了……", "42090");
        giSetPortrait("211A", true);
        giTalk("琴姬：我今天来……只是想给相公上柱香，很快就走……", "42091");
        giSetPortrait("212A", false);
        giTalk("姜氏：走？是啊，你又可以抛下他，就跟从前一样。", "42092");
        giSetPortrait("211A", true);
        giTalk("琴姬：不是的、我不是——", "42093");
        giSetPortrait("212A", false);
        giTalk("姜氏：不是什么！你知道吗？自从相公去了，我怕他一个人孤单寂寞，每天都来这儿陪着他，从早到晚都待在他身边。", "42094");
        giSetPortrait("212A", false);
        giTalk("姜氏：可你呢？！你抛下了他整整四年！不是四天、四个月，是四年！", "42095");
        giSetPortrait("211A", true);
        giTalk("琴姬：我！……", "42096");
        giSetPortrait("212A", false);
        giTalk("姜氏：不用说了！！你如今要说的话，相公他若泉下有知，也不会愿意听的！", "42097");
        giWait(0.5);
        giSetPortrait("211A", true);
        giTalk("琴姬：…………", "42098");
        giWait(0.5);
        giSetPortrait("212A", false);
        giTalk("姜氏：你要上香，可以！但须得答应我一件事！", "42099");
        giWait(0.5);
        giSetPortrait("211A", true);
        giTalk("琴姬：……什么事？只要我能做到……", "42100");
        giSetPortrait("212A", false);
        giTalk("姜氏：放心，你当然能！这件事一点都不难！我要你上完香之后，即刻离开陈州，永远不许再回来！你根本不配待在这里！", "42101");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：太过份了！凭什么？！ ", "42102");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……", "42103");
        giNpcSetDir("MN003", 206.0, true);
        giNpcDoAction("MN003", "C09", 1, true);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 25.0, false);
        giCameraRunSingle("008", true);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：琴姬姐姐…… ", "42104");
        giNpcSetDir("MN003", 312.0, true);
        giSetPortrait("211A", false);
        giTalk("琴姬：……我、我答应你……", "42105");
        giPlayerSetDir(1, 340.0, false);
        giSetPortrait("211A", false);
        giTalk("琴姬：……心愿了却，我再也不踏进陈州半步！", "42106");
        giSetPortrait("212A", true);
        giTalk("姜氏：这样最好，我想相公他也不愿意再见你的。", "42107");
        giNpcWalkTo("MN001", -61.2, 242.4, 859.5, true);
        giNpcSetDir("MN001", 291.0, true);
        giWait(1.5);
        giCameraRunSingle("010", false);
        giNpcWalkTo("MN003", 35.1, 242.4, 862.4, true);
        giNpcSetDir("MN003", 0.0, true);
        giWait(0.5);
        giSetPortrait("211A", false);
        giTalk("琴姬：…………", "42108");
        giCameraRunSingle("009", true);
        giNpcDoAction("MN003", "J02", 1, true);
        giWait(1.0);
        giNpcSetDir("MN003", 281.0, false);
        giCameraRunSingle("011", true);
        giWait(1.0);
        giSetPortrait("211A", true);
        giTalk("琴姬：多谢……告辞！", "42109");
        giWait(2.2);
        giPlayerSetVisible(0, false);
        giCameraRunSingle("013", true);
        giWait(0.3);
        giSetPortrait("103K", true);
        giTalk("韩菱纱：哼，真没礼貌！", "42110");
        giPlayerSetDir(2, 247.0, true);
        giPlayerDoAction(2, "J05", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……菱纱，走吧，孰是孰非，不是我们可以说的。", "42111");
        giPlayerEndAction(2);
        giPlayerSetDir(1, 70.0, true);
        giPlayerDoAction(1, "C08", 1, true);
        giWait(1.2);
        giCameraRunSingle("014", true);
        gi2DSoundPlay("WJ061", 1);
        giWait(0.5);
        gi2DSoundPlay("WJ061", 1);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("MN003", false);
        giIMMEnd();
        giCameraRunSingle("015", false);
        giWait(11.0);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("014", true);
        global_mvar = 50700; // 0x0000C60C
        giArenaLoad("Q04", "Q04CY", "", false);
    }
}

void func2003()
{
    if (global_mvar == 50800)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giNpcSetAng("MN001", 4.0);
        giSetNpcVisible("MN001", true);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giCameraRunSingle("002", false);
        giSetPortrait("212B", true);
        giTalk("姜氏：……相公，那个人，就是你直到过世前都念念不忘的女子？她……比我好吗？", "42141");
        giWait(0.5);
        giSetPortrait("212B", true);
        giTalk("姜氏：相公，我从小就一心一意喜欢着你，只想做你的妻子……可是为什么、为什么你要和别的女人在一起……", "42142");
        giWait(0.5);
        giSetPortrait("212B", true);
        giTalk("姜氏：……后来她把你抛下，姑妈说要我嫁入秦家冲喜，你知道……我有多高兴吗？", "42143");
        giWait(0.5);
        giSetPortrait("212B", true);
        giTalk("姜氏：我想好好照顾你，让你忘记那个女人，从今往后只想着我……可你、你怎么忍心看都不看我一眼……", "42144");
        giCameraRunSingle("003", true);
        giWait(1.5);
        giSetPortrait("212B", false);
        giTalk("姜氏：……相公……你在那边会冷吗？是不是很寂寞？我来陪你好不好？", "42145");
        giWait(0.7);
        giSetPortrait("212B", false);
        giTalk("姜氏：……先前我只是不甘心，想要看看是什么样的人把你迷得神魂颠倒，今日终于见着了，她……不过是个很寻常的女子，没有我美……也没有我对你那样好……", "42146");
        giWait(0.5);
        giSetPortrait("212B", false);
        giTalk("姜氏：相公，你要记得，这世上只有我是最爱你的，不管你在哪里，我都跟着……不像其他人会把你抛下……", "42147");
        giFlashOutBlack(2.3, true, true);
        giSetNpcVisible("MN001", false);
        global_mvar = 51000; // 0x0000C738
        giArenaLoad("Q04", "CN05", "CN05C", false);
    }
}

void func2004()
{
    if (global_mvar == 50402 /* 第一章 / 3-3-4.弦歌问情 / 塔中寻牌位 */)
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetPos(0, -839.5, 1.0, 1052.8);
        giPlayerSetAng(0, 171.0);
        giCameraPrepare("MC001");
        giCameraRunSingle("002", true);
        giFlashInBlack(1.5, true);
        giWait(1.0);
        giCameraRunSingle("003", true);
        giWait(1.5);
        giFlashOutBlack(1.5, true, true);
        global_mvar = 50600; // 0x0000C5A8
        giSetObjectVisible("title01", true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func7001()
{
    bool candlelight01_ctrl_visible = false;
    bool has_property_3121 = false;

    candlelight01_ctrl_visible = giGetVisibleObject("candlelight01_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight01_ctrl"))
    {
        if (candlelight01_ctrl_visible || giGetVisibleObject("candlelight01_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight01_ctrl", 0.5, false);
        giWait(1.5);
        giCameraPrepare("viewDoor1");
        giCameraRunSingle("viewDoor1", true);
        giGOMTouch("door01");
        giGOMTouch("door02");
        giWait(3.0);
        giWait(1.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giIMMEnd();
        giPlayerUnLock();
    }
}

void func7002()
{
    bool candlelight01_ctrl_visible = false;
    bool has_property_3121 = false;

    candlelight01_ctrl_visible = giGetVisibleObject("candlelight01_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight01_ctrl"))
    {
        if (candlelight01_ctrl_visible || giGetVisibleObject("candlelight01_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight01_ctrl", 0.5, false);
        giWait(1.5);
        giCameraPrepare("viewDoor01");
        giCameraRunSingle("viewDoor01", true);
        giGOMTouch("door01");
        giEventVolumeVisible("wall01", false);
        giWait(3.0);
        giWait(1.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giIMMEnd();
        giPlayerUnLock();
    }
}

void func7003()
{
    bool candlelight04_ctrl_visible = false;
    bool has_property_3121 = false;
    float camera_pitch = 0.0;

    candlelight04_ctrl_visible = giGetVisibleObject("candlelight04_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight04_ctrl"))
    {
        if (candlelight04_ctrl_visible || giGetVisibleObject("candlelight04_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        camera_pitch = giCameraGetPitch();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight04_ctrl", 0.5, false);
        giWait(1.5);
        giCameraPrepare("viewDoor04");
        giCameraRunSingle("viewDoor04", true);
        giGOMTouch("door02");
        giEventVolumeVisible("wall02", false);
        giWait(4.0);
        if (!giBGMConfigIsInArea("2"))
        {
            giIMMBegin();
            giCameraSetMode(5, true);
            giCameraCtrlYPR(0.0, (camera_pitch - 7.0), 0.0, true);
            giCameraAutoSeek(true);
            giCameraSeekToPlayer();
            giFlushTailYAngle();
            giIMMEnd();
        }
        else
        {
            giIMMBegin();
            giCameraSetMode(5, true);
            giCameraAutoSeek(true);
            giCameraSeekToPlayer();
            giFlushTailYAngle();
            giIMMEnd();
        }
        giPlayerUnLock();
    }
}

void func7004()
{
    int leader_player_id = 0;

    giPlayerLock();
    giScriptClearCTXButCurrent();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giFlashOutWhite(1.0, true, true);
    if (!giBGMConfigIsInArea("2"))
    {
        if (!giBGMConfigIsInArea("3"))
        {
            giPlayerCurrentSetPos(35.5, 1.7, 612.7);
        }
        else
        {
            giPlayerCurrentSetPos(10.0, 2.1, 669.7);
        }
    }
    else
    {
        giPlayerCurrentSetPos(510.4, 8.0, 798.2);
    }
    giPlayerCurrentSetAng(270.0);
    giIMMBegin();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giIMMEnd();
    giFlashInWhite(1.0, false);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7005()
{
    float local_1 = 0.0;

    local_1 = giCameraGetPitch();
    if (giCameraGetPitch() < 31.0)
    {
        giScriptClearCTXButCurrent();
        while (local_1 < 31.0)
        {
            giCameraCtrlYPR(0.0, 2.0, 0.0, true);
            local_1 = giCameraGetPitch();
        }
    }
}

void func7006()
{
    float local_1 = 0.0;

    local_1 = giCameraGetPitch();
    if (giCameraGetPitch() > 7.0)
    {
        giScriptClearCTXButCurrent();
        while (local_1 > 7.0)
        {
            giCameraCtrlYPR(0.0, -2.0, 0.0, true);
            local_1 = giCameraGetPitch();
        }
    }
}

void func7007()
{
    bool candlelight02_ctrl_visible = false;
    bool candlelight03_ctrl_visible = false;
    bool has_property_3121 = false;

    candlelight02_ctrl_visible = giGetVisibleObject("candlelight02_ctrl");
    candlelight03_ctrl_visible = giGetVisibleObject("candlelight03_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight02_ctrl"))
    {
        if (candlelight02_ctrl_visible || giGetVisibleObject("candlelight02_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight02_ctrl", 0.5, false);
        if (candlelight03_ctrl_visible)
        {
            func7009();
        }
        giPlayerUnLock();
    }
}

void func7008()
{
    bool candlelight02_ctrl_visible = false;
    bool candlelight03_ctrl_visible = false;
    bool has_property_3121 = false;

    candlelight02_ctrl_visible = giGetVisibleObject("candlelight02_ctrl");
    candlelight03_ctrl_visible = giGetVisibleObject("candlelight03_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight03_ctrl"))
    {
        if (candlelight03_ctrl_visible || giGetVisibleObject("candlelight03_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight03_ctrl", 0.5, false);
        if (candlelight02_ctrl_visible)
        {
            func7009();
        }
        giPlayerUnLock();
    }
}

void func7009()
{
    giScriptClearCTXButCurrent();
    giWait(1.5);
    giCameraPrepare("viewDoor01");
    giCameraRunSingle("viewDoor01", true);
    giGOMTouch("door01");
    giEventVolumeVisible("wall01", false);
    giWait(3.0);
    giWait(1.0);
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giFlushTailYAngle();
}

void func7010()
{
    bool candlelight04_ctrl_visible = false;
    bool candlelight06_ctrl_visible = false;
    bool has_property_3121 = false;

    candlelight04_ctrl_visible = giGetVisibleObject("candlelight04_ctrl");
    candlelight06_ctrl_visible = giGetVisibleObject("candlelight06_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight04_ctrl"))
    {
        if (candlelight04_ctrl_visible || giGetVisibleObject("candlelight04_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight04_ctrl", 0.5, false);
        if (candlelight06_ctrl_visible)
        {
            func7012();
        }
        giPlayerUnLock();
    }
}

void func7011()
{
    bool candlelight04_ctrl_visible = false;
    bool candlelight06_ctrl_visible = false;
    bool has_property_3121 = false;

    candlelight04_ctrl_visible = giGetVisibleObject("candlelight04_ctrl");
    candlelight06_ctrl_visible = giGetVisibleObject("candlelight06_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight06_ctrl"))
    {
        if (candlelight06_ctrl_visible || giGetVisibleObject("candlelight06_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight06_ctrl", 0.5, false);
        if (candlelight04_ctrl_visible)
        {
            func7012();
        }
        giPlayerUnLock();
    }
}

void func7012()
{
    giScriptClearCTXButCurrent();
    giWait(1.5);
    giCameraPrepare("viewDoor04");
    giCameraRunSingle("viewDoor04", true);
    giGOMTouch("door02");
    giEventVolumeVisible("wall02", false);
    giWait(3.0);
    giWait(1.0);
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giFlushTailYAngle();
}

void func7013()
{
    bool candlelight01_ctrl_visible = false;
    bool candlelight02_ctrl_visible = false;
    bool candlelight03_ctrl_visible = false;
    bool has_property_3121 = false;

    candlelight01_ctrl_visible = giGetVisibleObject("candlelight01_ctrl");
    candlelight02_ctrl_visible = giGetVisibleObject("candlelight02_ctrl");
    candlelight03_ctrl_visible = giGetVisibleObject("candlelight03_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight01_ctrl"))
    {
        if (candlelight01_ctrl_visible || giGetVisibleObject("candlelight01_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight01_ctrl", 0.5, false);
        if (candlelight02_ctrl_visible && candlelight03_ctrl_visible)
        {
            func7009();
        }
        giPlayerUnLock();
    }
}

void func7014()
{
    bool candlelight01_ctrl_visible = false;
    bool candlelight02_ctrl_visible = false;
    bool candlelight03_ctrl_visible = false;
    bool has_property_3121 = false;

    candlelight01_ctrl_visible = giGetVisibleObject("candlelight01_ctrl");
    candlelight02_ctrl_visible = giGetVisibleObject("candlelight02_ctrl");
    candlelight03_ctrl_visible = giGetVisibleObject("candlelight03_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight02_ctrl"))
    {
        if (candlelight02_ctrl_visible || giGetVisibleObject("candlelight02_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight02_ctrl", 0.5, false);
        if (candlelight01_ctrl_visible && candlelight03_ctrl_visible)
        {
            func7009();
        }
        giPlayerUnLock();
    }
}

void func7015()
{
    bool candlelight01_ctrl_visible = false;
    bool candlelight02_ctrl_visible = false;
    bool candlelight03_ctrl_visible = false;
    bool has_property_3121 = false;

    candlelight01_ctrl_visible = giGetVisibleObject("candlelight01_ctrl");
    candlelight02_ctrl_visible = giGetVisibleObject("candlelight02_ctrl");
    candlelight03_ctrl_visible = giGetVisibleObject("candlelight03_ctrl");
    has_property_3121 = giCheckPackProperty(3121, 1);
    if (!has_property_3121 || giGetVisibleObject("candlelight03_ctrl"))
    {
        if (candlelight03_ctrl_visible || giGetVisibleObject("candlelight03_ctrl") && has_property_3121)
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("被点燃的蜡烛", 0.5, 0.15);
        }
        else
        {
            gi2DSoundPlay("wa03", 1);
            giShowHint("熄灭的蜡烛", 0.5, 0.15);
        }
    }
    else
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giDelProperty(3121, 1, true);
        giOBJBlendIn("candlelight03_ctrl", 0.5, false);
        if (candlelight01_ctrl_visible && candlelight02_ctrl_visible)
        {
            func7009();
        }
        giPlayerUnLock();
    }
}

void func7500()
{
    giSetMinimapLevel(1);
}

void func7501()
{
    giSetMinimapLevel(0);
}
