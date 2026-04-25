// Structured PAL4 reconstruction for Q13.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q13_Q13_init()
{
    if (global_mvar <= 140100 && npc_e == 0 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giNpcSetPos("SN001", 1385.6014, 139.3868, -1367.1963);
        giNpcSetAng("SN001", 146.0);
        giPlayerSetPos(1, 1411.6222, 139.3868, -1414.0392);
        giPlayerSetAng(1, 342.0);
        giSetNpcVisible("SN001", true);
        giPlayerSetVisible(1, true);
    }
    if (global_mvar != 131100)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2001();
    }
}

void N06_Q13_init()
{
    giPlayerCurrentSetPos(165.43172, 0.029301, 78.03207);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1001()
{
    giArenaLoad("Q13", "N01", "", true);
    giPlayerCurrentSetPos(-79.734344, 0.043932, 105.82507);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(2012.3196, -186.05426, 1937.0103);
    giPlayerCurrentSetAng(350.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q13", "n02", "", true);
    giPlayerCurrentSetPos(0.507661, 0.521805, 144.50775);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(-896.6602, -24.537987, 472.66748);
    giPlayerCurrentSetAng(104.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q13", "N03", "", true);
    giPlayerCurrentSetPos(106.96659, 0.369194, 122.056526);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(2167.123, 140.3747, -1360.9949);
    giPlayerCurrentSetAng(260.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("Q13", "N041", "", true);
    giPlayerCurrentSetPos(-0.663023, 0.525238, 240.60623);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(199.75867, -24.537987, 328.0971);
    giPlayerCurrentSetAng(295.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("Q13", "N042", "", true);
    giPlayerCurrentSetPos(85.0723, 0.510653, -80.64617);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("Q13", "N041", "", true);
    giPlayerCurrentSetPos(-45.191853, 68.554924, -206.34615);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("Q13", "N05", "", true);
    giPlayerCurrentSetPos(3.043219, 0.249863, 140.49731);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1012()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(1278.7642, 140.42949, -1486.307);
    giPlayerCurrentSetAng(73.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1013()
{
    giArenaLoad("Q13", "N06", "", true);
    giPlayerCurrentSetPos(165.43172, 0.029301, 78.03207);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(2400.0222, -186.05429, 2692.3333);
    giPlayerCurrentSetAng(192.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("Q13", "N07", "N07a", true);
    giPlayerCurrentSetPos(-92.81253, -1.399961, 83.70215);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(2272.4685, 139.33911, -1933.9003);
    giPlayerCurrentSetAng(285.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1017()
{
    giArenaLoad("Q13", "N07", "N07b", true);
    giPlayerCurrentSetPos(-92.81253, -1.399961, 83.70215);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1018()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(-843.86115, -24.628672, 197.07016);
    giPlayerCurrentSetAng(66.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1019()
{
    giArenaLoad("Q13", "N07", "N07c", true);
    giPlayerCurrentSetPos(-92.81253, -1.399961, 83.70215);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1020()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(1586.1548, -182.73132, 1733.7002);
    giPlayerCurrentSetAng(326.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1021()
{
    giArenaLoad("Q13", "N08", "N08a", true);
    giPlayerCurrentSetPos(-106.644806, 1.299963, 25.072037);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1022()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(2042.8566, 139.33911, -1169.6382);
    giPlayerCurrentSetAng(235.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1023()
{
    giArenaLoad("Q13", "N08", "N08b", true);
    giPlayerCurrentSetPos(-106.644806, 1.299963, 25.072037);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1024()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(-533.78925, -24.537987, 786.8509);
    giPlayerCurrentSetAng(155.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1025()
{
    giArenaLoad("Q13", "N08", "N08c", true);
    giPlayerCurrentSetPos(-106.644806, 1.299963, 25.072037);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1026()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(-174.06364, -24.537987, 883.5653);
    giPlayerCurrentSetAng(174.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1027()
{
    giArenaLoad("Q13", "N08", "N08d", true);
    giPlayerCurrentSetPos(-106.644806, 1.299963, 25.072037);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1028()
{
    giArenaLoad("Q13", "Q13", "", true);
    giPlayerCurrentSetPos(1121.3477, -187.61221, 1991.2047);
    giPlayerCurrentSetAng(50.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1029()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.御剑飞行  ");
    giSelectDialogAddItem("2.什么都不做");
    giSelectDialogSetDefaultSelect(1);
    giShowSelectDialog("              准备<colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>吗？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        leader_player_id = giPlayerGetLeader();
        giPlayerWalkTo(leader_player_id, 1817.667, -182.23965, 3399.9092, true);
        giPlayerSetDir(leader_player_id, 180.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giPlayerUnLock();
    }
    else
    {
        giShowWorldMap();
    }
    giPlayerUnLock();
}

void func1030()
{
    int leader_player_id = 0;

    giPlayerLock();
    giNpcPauseBeh("4026");
    giNpcFaceToCurrentPlayer("4026", true);
    giCurrentPlayerFaceToNpc("4026", true);
    giTalk("马彪：前方为酆都大帝殿，平日不能上山拜访，请回。", "");
    giNpcResetDir("4026");
    giNpcResumeBeh("4026");
    leader_player_id = giPlayerGetLeader();
    giPlayerWalkTo(leader_player_id, 1204.8623, 143.1, -2332.0007, true);
    giPlayerSetDir(leader_player_id, 55.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giPlayerUnLock();
}

void func2001()
{
    if (global_mvar == 131100)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetPos(0, 579.5667, -183.5282, 2798.243);
        giPlayerSetAng(0, 264.0);
        giPlayerSetPos(1, 514.1947, -183.5282, 2775.8762);
        giPlayerSetAng(1, 274.0);
        giPlayerSetPos(3, 559.21, -183.5282, 2698.163);
        giPlayerSetAng(3, 329.0);
        giSetNpcVisible("4028", false);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giCameraPrepare("MC001");
        giArenaReady();
        giCameraRunSingle("001", true);
        giFlashInWhite(2.0, false);
        giCameraRunSingle("004", true);
        giWait(1.0);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……看来……我们已经回到人间了，这里似乎是蜀中的鬼城酆都。", "45163");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(1.0);
        giCameraRunSingle("006", false);
        giWait(1.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……伯父……呜……", "45164");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：菱纱，你、你别哭了……", "45165");
        giSetPortrait("101E", true);
        giTalk("云天河：你这样哭，我也好难过……", "45166");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 79.0, false);
        giCameraRunSingle("003", true);
        giWait(0.6000000238418579);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：你……你又难过什么？", "45167");
        giSetPortrait("101G", false);
        giTalk("云天河：去了趟鬼界，听到那些事情，我好像变得都不是我了……", "45168");
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：……原来，娘最喜欢的人，不是爹，而是……", "45169");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：我也觉得……为什么许多事情……和原本想的完全不一样……", "45170");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……走吧，我们回琼华派去，也不知道门派里到底如何了。", "45171");
        giPlayerSetDir(1, 163.0, false);
        giPlayerSetDir(0, 203.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：嗯，翳影枝拿到了，我要去找梦璃！", "45172");
        giPlayerEndAction(0);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("4028", true);
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 131200; // 0x00020080, 第三章 / 8-2-5.是昔流芳 / 离开酆都 / 冥河故人
        giPlayerSetPos(1, 1411.6222, 139.3868, -1414.0392);
        giPlayerSetAng(1, 342.0);
        giPlayerSetVisible(1, true);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 131200 /* 第三章 / 8-2-5.是昔流芳 / 离开酆都 / 冥河故人 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giSetObjectVisible("entrance0", false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetPos(0, 1785.0269, -182.3537, 3134.6729);
        giPlayerSetAng(0, 337.0);
        giPlayerSetPos(1, 1746.3773, -182.3537, 3189.1443);
        giPlayerSetAng(1, 152.0);
        giPlayerSetPos(3, 1856.1648, -182.3537, 3205.433);
        giPlayerSetAng(3, 265.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("4028", false);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giCameraRunSingle("002", false);
        giSetObjectVisible("title05", false);
        giFlashInBlack(1.0, false);
        giWait(1.0);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……天河，等一下。", "45173");
        giSetPortrait("101A", false);
        giTalk("云天河：怎么了……？", "45174");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：我想……你陪我去做一件事好吗？", "45175");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", false);
        giTalk("云天河：啥？很急吗？", "45176");
        giPlayerEndAction(0);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：哎，问那么多干嘛，来就是了，反正很重要的！", "45177");
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：什么事？不需要我帮忙吗？", "45178");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerSetDir(1, 84.0, true);
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：嗯……你来也好……", "45179");
        giWait(0.800000011920929);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：不，紫英你还是别来了……", "45180");
        giPlayerEndAction(1);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：到底何事？", "45181");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：其实……刚才在城里的时候，我想了很久，想伯父说的那些话，我决定了却自己的一个心愿，以后就再也不盗墓了。", "45182");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101D", false);
        giTalk("云天河：意思就是……还要去盗一次？", "45183");
        giPlayerSetDir(1, 152.0, false);
        giCameraRunSingle("009", true);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：那是有原因的嘛～你、可以陪我去吗？", "45184");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：不行！", "45185");
        giPlayerEndAction(0);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：为什么？", "45186");
        giSetPortrait("101H", false);
        giTalk("云天河：我虽然不是很懂，但也知道，盗墓不是好事，对你不好，会减你的寿命，所以不能去。", "45187");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：哪有这么严重……就去一次！以前那么多年都这样过了，还在乎这一次吗？", "45188");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：不行！你的命就算是减了一个月、一天也不行！", "45189");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("008", true);
        giSetPortrait("101H", false);
        giTalk("云天河：为啥突然要去？！再说梦璃的事也还没——", "45190");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：哼！别总是梦璃、梦璃的，我当然明白梦璃的事很重要！但我也不是胡闹。", "45191");
        giSetPortrait("103F", true);
        giTalk("韩菱纱：只要这件事一办完，我们马上就回琼华派，去妖界找梦璃！", "45192");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("005", false);
        giPlayerWalkTo(3, 1834.5521, -182.3537, 3209.7034, true);
        giPlayerSetDir(3, 245.0, true);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……何等大事，一定要在这个时候去办？你却又不肯说清楚因果……", "45193");
        giWait(0.30000001192092896);
        giCameraRunSingle("007", false);
        giPlayerSetDir(1, 94.0, true);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：菱纱，攸关你的生死，你要想明白，不可儿戏。", "45194");
        giSetPortrait("101H", true);
        giTalk("云天河：是啊，菱纱，你平时就很爱玩，但也别拿自己的命来玩啊！", "45195");
        giScriptMusicPlay("P34", 2, 0.0, 0.0);
        giPlayerSetDir(1, 152.0, true);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你当我是在玩？", "45196");
        giPlayerSetDir(1, 94.0, true);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你们都以为我是说疯话？！", "45197");
        giSetPortrait("101D", true);
        giTalk("云天河：…………", "45198");
        giSetPortrait("105D", true);
        giTalk("慕容紫英：…………", "45199");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：好，两个大男人婆婆妈妈的不肯去，我自己去总行了吧？！", "45200");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerRunTo(1, 1751.1686, -182.3536, 3267.7078, false);
        giWait(0.30000001192092896);
        giPlayerSetDir(3, 311.0, false);
        giPlayerRunTo(0, 1764.7866, -182.3537, 3175.4082, false);
        giSetPortrait("101H", true);
        giTalk("云天河：等等！你别走！", "45201");
        giWait(0.30000001192092896);
        giPlayerEndMove(0);
        giIMMBegin();
        giCameraRunSingle("006", false);
        giPlayerSetAng(0, 345.0);
        giIMMEnd();
        giWait(0.30000001192092896);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：我干嘛要理你！", "45202");
        giPlayerSetDir(1, 168.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：你们不愿意陪我，还不许我自己去，那干脆把我打昏，直接扛回琼华派算了！", "45203");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：话不能这么说，总之你不能——", "45204");
        giSetPortrait("103F", true);
        giTalk("韩菱纱：哼！", "45205");
        giPlayerSetDir(1, 10.0, true);
        giPlayerDoAction(1, "Z07", 1, false);
        giEffectPlayWithPlayer("H_089", 1, 1);
        giPlayerDoAction(3, "C07", 1, false);
        giPlayerEndAction(1);
        giWait(0.6000000238418579);
        giPlayerSetDir(1, 127.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103K", true);
        giTalk("韩菱纱：紫英你、干嘛妨碍我？！", "45206");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……那件事，你一定要做？", "45207");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：对！你们不去，我一个人也能办成，大不了死在那边，横竖也就是一条命。", "45208");
        giPlayerEndAction(1);
        giCameraRunSingle("010", true);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：那是一件很重要的事，一个很重要的心愿，如果我的阳寿真的很短，那我一定……要在死之前做到……", "45209");
        giSetPortrait("101H", true);
        giTalk("云天河：……你！", "45210");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：而且去妖界会很危险……我只想……此生不要留下遗憾……", "45211");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：不行不行，话不能这么说，不管你怎么说都不行！", "45212");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("011", true);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……好吧，我去。", "45213");
        giWait(0.5);
        giPlayerSetAng(0, 59.0);
        giPlayerSetAng(1, 133.0);
        giCameraRunSingle("012", true);
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：啊？！", "45214");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：与其让你一人涉险，倒不如我跟去……", "45215");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：真的？！", "45216");
        giPlayerDoAction(3, "C08", 1, true);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：哈，那就这么说定了，还是小紫英最明事理。", "45217");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(0, 345.0, true);
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：这怎么行？我不干！", "45218");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(1, 171.0, true);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：喂，紫英都已经答应了，你还找碴啊？", "45219");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：莫要误会，我并未答应你什么，只是跟你同去，免得你胡闹，反而令自己身陷险境。", "45220");
        giPlayerSetDir(1, 133.0, true);
        giWait(0.5);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：如果此行有任何损阴德之事，我会立刻阻止你！", "45221");
        giWait(0.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：有什么不一样，反正就是要陪我去嘛。", "45222");
        giPlayerEndAction(1);
        giCameraRunSingle("013", true);
        giSetPortrait("101H", false);
        giTalk("云天河：……", "45223");
        giSetPortrait("101E", false);
        giTalk("云天河：…………", "45224");
        giSetPortrait("101G", false);
        giTalk("云天河：………………", "45225");
        giPlayerDoAction(0, "J15", 0, false);
        giSetPortrait("101H", false);
        giTalk("云天河：为啥女孩子会这么麻烦啊啊啊？不顺你的意就要闹闹闹！", "45226");
        giSetPortrait("101H", false);
        giTalk("云天河：烦死我了～～～烦死我了～～～烦死我了～～～！！", "45227");
        giSetPortrait("101H", false);
        giTalk("云天河：一个不见了，一个明明知道会减寿命还要去盗墓，我真是搞不懂女孩子在想什么！", "45228");
        giIMMBegin();
        giPlayerSetAng(0, 345.0);
        giPlayerSetAng(1, 180.0);
        giPlayerSetAng(3, 257.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：嘻，这么说，你也同意啰？", "45229");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101E", true);
        giTalk("云天河：…………", "45230");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：唉，还是以前在山上打猎的时候最好，没那么多烦心事……", "45231");
        giSetPortrait("101E", true);
        giTalk("云天河：（真想回山上……）", "45232");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：好啦，别臭着一张脸，想吓谁啊，反正我当你答应了。", "45233");
        giSetPortrait("103M", false);
        giTalk("韩菱纱：走吧！那个地方叫<colour red=255 green=187 blue=0 alpha=255>封神陵</colour><dc0>，</dc0><colour red=255 green=187 blue=0 alpha=255>在陈州的北面</colour><dc0>，因为悬浮于半空，常人根本不能靠近，好在我们几个没问题，御剑过去就好了！</dc0>", "45234");
        giPlayerDoAction(0, "J15", 1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：我……我实在是……都不知道该说什么了……", "45235");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giSetObjectVisible("entrance0", true);
        giCameraSetMode(0, true);
        giSetNpcVisible("4028", true);
        giSetObjectVisible("title05", true);
        giPlayerSetAng(0, 9.0);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 131300; // 0x000200E4, 第三章 / 8-3-1.心愿 / 前去封神陵
        giPlayerSetPos(1, 1411.6222, 139.3868, -1414.0392);
        giPlayerSetAng(1, 342.0);
        giPlayerSetVisible(1, true);
        giPlayerUnLock();
        giScriptMusicStop(0, 2.5);
        giFlashInBlack(1.5, true);
    }
}

void func3001()
{
    if (global_mvar <= 140100 && npc_e == 0 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P26", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 1502.8116, 139.3868, -1382.721);
        giPlayerSetAng(0, 274.0);
        giPlayerSetPos(3, 1490.744, 139.3868, -1419.9194);
        giPlayerSetAng(3, 326.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("4024", false);
        giSetNpcVisible("4021", false);
        giSetNpcVisible("4003", false);
        giSetNpcVisible("4018", false);
        giSetObjectVisible("title13", false);
        giIMMEnd();
        giCameraPrepare("ZI001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giWait(1.0);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……这、这是什么法术？我的头好像没有刚才那样晕了……", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcDoAction("SN001", "J01", -1, false);
        giTalk("？？：在下道臻，刚才施展的乃是蜀山仙剑派的理气通脉之法。", "");
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giWait(0.5);
        giTalk("道臻：另外，这几味丹药可助姑娘凝气定神，如有不适，可随时服用。", "");
        giWait(0.5);
        giAddProperty(3032, 10, true);
        giWait(1.0);
        giAddProperty(3033, 10, true);
        giWait(2.0);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：谢谢……", "");
        giTalk("道臻：区区小事，不足挂齿，告辞。", "");
        giNpcSetDir("SN001", 10.0, true);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：啊，你等一下——", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：这位兄台，请留步。", "");
        giCameraRunSingle("002", false);
        giPlayerWalkTo(3, 1454.358, 139.3868, -1409.4938, false);
        giWait(0.2);
        giPlayerWalkTo(0, 1484.602, 139.3868, -1378.1699, true);
        giWait(0.3);
        giPlayerSetDir(3, 322.0, false);
        giPlayerSetDir(0, 276.0, false);
        giCameraWait();
        giNpcSetDir("SN001", 122.0, true);
        giIMMBegin();
        giPlayerSetPos(3, 1447.4651, 139.3868, -1397.5531);
        giPlayerSetAng(3, 312.0);
        giPlayerSetPos(1, 1421.2676, 139.3868, -1410.7456);
        giPlayerSetAng(1, 336.0);
        giPlayerSetPos(0, 1481.3754, 139.3868, -1384.5812);
        giPlayerSetAng(0, 302.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：在下慕容紫英，乃是昆仑琼华派门下。", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：冒昧一问，兄台腰间坠有蜀山派的守剑文佩，据我所知，此乃入室弟子专用，且分为紫、青、蓝、绿四等，弟子领命下山时才会佩戴，兄台所佩竟是最高级数的紫色，是否蜀山上发生了什么大事？", "");
        giWait(0.7);
        giTalk("道臻：……与你何干？", "");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：在下无意打探其他门派秘事，只不过蜀山派向来以侠义之举闻名天下，令人钦佩，若此回事态紧急，在下力之所及，或许也能略尽心意。", "");
        giWait(0.5);
        giTalk("道臻：好意心领，不敢劳驾。我此次下山与行侠无关，乃是为了铲除门中叛徒，寻回一件失物。", "");
        giWait(0.5);
        giNpcDoAction("SN001", "J01", -1, false);
        giTalk("道臻：时间紧迫，<colour red=255 green=187 blue=0 alpha=255>我要赶往即墨附近</colour><dc0>，不敢耽搁，就此告辞了。</dc0>", "");
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giWait(0.5);
        giNpcWalkTo("SN001", 1454.1987, 139.3868, -1312.3888, true);
        giSetNpcVisible("SN001", false);
        giIMMBegin();
        giPlayerSetPos(3, 1413.9924, 139.3868, -1391.2633);
        giPlayerSetPos(1, 1440.1898, 139.3868, -1417.5232);
        giPlayerSetPos(0, 1481.3754, 139.3868, -1384.5812);
        giPlayerSetAng(3, 344.0);
        giPlayerSetAng(1, 336.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：…………想不到、真想不到，这世上有比小紫英还要冷颜冷面的人呐，当真是一山还比一山高。", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：…………", "42751; 44030; 44566; 44797; 45022; 45199; 45299; 45387; 45554; 45687; 45774; 45776; 45786; 45820; 45823; 45843; 46182; 46311; 46456");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：好啦，我开玩笑的嘛，其实我们都知道你是面冷心热～", "");
        giPlayerSetDir(0, 204.0, false);
        giWait(0.1);
        giPlayerSetDir(3, 152.0, false);
        giWait(0.6);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：说起来，那个人也是呢，刚才我突然觉得头晕不舒服，多亏他用法术帮我缓解了许多。", "");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：那现在呢？你怎么样，还难受吗？！", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(1, 44.0, true);
        giPlayerDoAction(1, "J14", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：已经好了，瞧你紧张的，我最近时常这样，一点小毛病，最后还不都没事？", "");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", false);
        giTalk("云天河：哦……没事就好、没事就好～", "");
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(3, 152.0);
        giPlayerSetAng(1, 336.0);
        giPlayerSetAng(0, 224.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：紫英，你还是很在意蜀山的事吗？", "");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：那个人说要铲除叛徒，找回一件失物，应该是有弟子把蜀山派的什么东西偷走了吧？ ", "");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：既然对方不愿多言，应是不想被门派以外的人知道，我们也毋须猜测。", "");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：嗯……就不晓得是怎样贵重的宝贝弄丢了，让蜀山派那么紧张……", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(1433.7545, 139.3868, -1410.8414);
        giPlayerCurrentSetAng(347.0);
        giSetNpcVisible("4024", true);
        giSetNpcVisible("4021", true);
        giSetNpcVisible("4003", true);
        giSetNpcVisible("4018", true);
        giSetObjectVisible("title13", true);
        giCameraSetMode(0, true);
        npc_e = 1;
        giScriptMusicStop(0, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func4001()
{
    giPlayerLock();
    giNpcPauseBeh("4001");
    giCurrentPlayerFaceToNpc("4001", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4001", true);
        giRandTalkRelease();
        giRandTalkPush("石广知：上回那个道士告诉我，最近阴间怕是出事了，青竹船也不许再往来阴阳两界！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giNpcFaceToNpc("4001", "4002", true);
        giNpcFaceToNpc("4002", "4001", true);
        giTalk("石广知：酆都自古就被称为鬼都，那是因为这里和阴间最接近，傻小子～你知道从哪里才能进入鬼界吗？", "");
        giTalk("刘保柱：只要是酆都人都知道啊，在子时到城门口就行了。", "");
        giTalk("石广知：唔，知道这也不稀奇，但你知道要怎么从鬼界回来吗？告诉你，我听一个做法事的道士说过，得乘着冥河上的船从鬼界漂回来！那冥河是阴间的，到了阳世便是酆都的龙河了！", "");
    }
    giNpcResetDir("4001");
    giNpcResetDir("4002");
    giNpcResumeBeh("4001");
    giPlayerUnLock();
}

void func4002()
{
    giPlayerLock();
    giNpcPauseBeh("4002");
    giNpcFaceToCurrentPlayer("4002", true);
    giCurrentPlayerFaceToNpc("4002", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("刘保柱：我奶奶天天祭拜鬼神，现在都九十岁了身体还好得很，每顿能吃下三大碗白米饭，你说这不是鬼神保佑是什么？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("刘保柱：虽说子时从城门就能去鬼界，不过奶奶从不让我去，她说好端端的活人去阴间，会沾染阴气，小则招惹鬼邪，严重一点的话，可就是要命了！");
        giRandTalkPush("刘保柱：石叔叔虽然见多识广，但他总说从鬼界回来是坐什么船，一听就知道是乱说！阳间要是有河通阴间，不是随便谁都能去了吗？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4002");
    giNpcResumeBeh("4002");
    giPlayerUnLock();
}

void func4003()
{
    giPlayerLock();
    giNpcPauseBeh("4003");
    giNpcFaceToCurrentPlayer("4003", true);
    giCurrentPlayerFaceToNpc("4003", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("阿娇：蒋大师说阴间出了事，冥河上的青竹船不许再开，那是不是没办法往来阴阳两界了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("阿娇：告诉你哦～沿着大路走过鬼门关，酒馆旁边卦摊上的蒋大师，是个很厉害的道士！我经常求他做法唤我死去的爹回来相见，每次都很灵验呢！");
        giRandTalkPush("阿娇：来酆都的外乡人可不能错过孟婆婆的粥～孟婆婆的小摊就在奈何桥旁边，沿着路往山上走就能瞧见。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4003");
    giNpcResumeBeh("4003");
    giPlayerUnLock();
}

void func4004()
{
    giPlayerLock();
    giNpcPauseBeh("4004");
    giNpcFaceToCurrentPlayer("4004", true);
    giCurrentPlayerFaceToNpc("4004", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("彭巧娘：葛大娘家三宝的癫痫好了，听说是请了蒋道士来做法驱邪，那蒋道士留下三张符纸，烧了符纸，将符灰兑了水一喝，三宝就立刻好起来了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("彭巧娘：葛大娘的儿子突然犯了癫痫，口中胡言乱语还全身发抖，那样子真可怕！我活了大半辈子还头一回见到！");
        giRandTalkPush("彭巧娘：以前我一直不知道，总觉得这龙河阴气太重，后来听人家说，龙河流到阴间就是冥河，这阴气能不重吗？！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4004");
    giNpcResumeBeh("4004");
    giPlayerUnLock();
}

void func4005()
{
    giPlayerLock();
    giNpcPauseBeh("4005");
    giNpcFaceToCurrentPlayer("4005", true);
    giCurrentPlayerFaceToNpc("4005", true);
    giRandTalkRelease();
    giRandTalkPush("马大婶：哎哟，小哥～看你不是本地人吧？你们可能不知道，酆都阴气盛，要给阎王鬼差上香才能常保平安，大妈这儿就有现成的香烛，看你长得俊，就给你打九折好了～");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4005");
    giNpcResumeBeh("4005");
    giPlayerUnLock();
}

void func4006()
{
    giPlayerLock();
    giNpcPauseBeh("4006");
    giNpcFaceToCurrentPlayer("4006", true);
    giCurrentPlayerFaceToNpc("4006", true);
    giRandTalkRelease();
    giRandTalkPush("李超：这口楠木棺是城里一个大户人家订做的，不是真死了人，而是为家里的老人存“材”保长寿～");
    giRandTalkPush("李超：祖上传下来的规矩，棺材店天一黑就要打烊，说是夜里做棺材会招鬼，客官您要是有什么事儿就现在说，别等我要打烊了才来敲大门。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4006");
    giNpcResumeBeh("4006");
    giPlayerUnLock();
}

void func4007()
{
    giPlayerLock();
    giNpcPauseBeh("4007");
    giNpcFaceToCurrentPlayer("4007", true);
    giCurrentPlayerFaceToNpc("4007", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("莫晔：你知道我这店里哪件东西卖得最好？竟然是桃木剑……唉，真是半点也显不出我的手艺来……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("莫晔：小哥你知道蜀山剑仙吧？就是斩妖除魔最厉害的人！连他们都用我打的刀剑，你说我的刀剑好不好～");
        giRandTalkPush("莫晔：城里的人天天就只知道求啊拜的，香烛摊的大婶生意最好！我倒觉得与其求神拜佛，不如练武强身，你说是吧？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4007");
    giNpcResumeBeh("4007");
    giPlayerUnLock();
}

void func4008()
{
    giPlayerLock();
    giNpcPauseBeh("4008");
    giNpcFaceToCurrentPlayer("4008", true);
    giCurrentPlayerFaceToNpc("4008", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("潘大爷：我孙儿前几日从蜀山回来了，原来他是看我病得厉害，去替我求仙丹啊！这么孝顺的孩子真是世间少有，以前真是我误会他了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("潘大爷：我那孙儿也不知发的什么疯，竟然说要去蜀山当剑仙，就这么丢下我一个老头子，病得快死了也没人管！");
        giRandTalkPush("潘大爷：沿大路一直往上走，就可以看到酆都大帝殿，不过官府怕惊扰了鬼神，如今那里有卫兵把守，平常时候不能上去啰……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4008");
    giNpcResumeBeh("4008");
    giPlayerUnLock();
}

void func4009()
{
    giPlayerLock();
    giNpcPauseBeh("4009");
    giNpcFaceToCurrentPlayer("4009", true);
    giCurrentPlayerFaceToNpc("4009", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("蒋子牙：我听鬼差说，上回有人乱闯鬼界，还乘青竹船逃回了阳间，阎王一怒之下，最近都不许青竹船再开了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("蒋子牙：你们几个～尤其是那红衣服的小姑娘！年纪轻轻，身上阴气怎那么重？是不是去了什么不该去的地方？");
        giRandTalkPush("蒋子牙：城里的小牛哥真是深情，娘子都死了好几年了，他还每月求我做法招魂魄回来相见。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4009");
    giNpcResumeBeh("4009");
    giPlayerUnLock();
}

void func4010()
{
    giPlayerLock();
    giNpcPauseBeh("4010");
    giNpcFaceToCurrentPlayer("4010", true);
    giCurrentPlayerFaceToNpc("4010", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("霍琳：酆都附近从来也没有闹过妖怪，一来有鬼神守着，二来在蜀山剑仙的眼皮底下，妖怪还不早吓跑了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("霍琳：每逢九月九，山上酆都大帝殿前就会有庙会，大家都赶着上山参拜进香，那场面可热闹着呢！");
        giRandTalkPush("霍琳：听说地府中的刑罚多到数不清，什么拔舌剥皮、上刀山下火海、炸油锅……听听就寒毛直竖，所以人呐，活着的时候可不能做坏事！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4010");
    giNpcResumeBeh("4010");
    giPlayerUnLock();
}

void func4011()
{
    giPlayerLock();
    giNpcPauseBeh("4011");
    giNpcFaceToCurrentPlayer("4011", true);
    giCurrentPlayerFaceToNpc("4011", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("孟巧菱：酆都附近的山上有很多庙，常有和尚来我婆婆的摊上买豆腐乳，好吃的东西谁都爱吃嘛。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("孟巧菱：奈何桥就在前面了，喝了孟婆粥，好过奈何桥～这瘦肉榨菜茶汁煮的，是男粥，这泉水豆汁煮的，是女粥～你们可要尝一尝？");
        giRandTalkPush("孟巧菱：酆都的豆腐乳，叫做仙家豆腐乳，是平都山上的仙人传下来的方子，别处可吃不着～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4011");
    giNpcResumeBeh("4011");
    giPlayerUnLock();
}

void func4012()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4012");
    giCurrentPlayerFaceToNpc("4012", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4012", true);
        giRandTalkRelease();
        giRandTalkPush("仇仲：蜀山派斩妖除魔，在西蜀一带颇有威名，我定要找时间上山拜访一下！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4012", true);
            giTalk("仇仲：别看这酆都好像阳间的阴曹地府一样，其实这什么鬼门关、奈何桥，还不都是活人造的，有什么好怕？！", "");
        }
        else
        {
            giNpcFaceToNpc("4012", "5004", true);
            giNpcFaceToNpc("5004", "4012", true);
            giTalk("仇仲：老板娘～来两碗孟婆粥！荤的素的各一碗，我都要尝尝！", "");
            giTalk("孟祝：这可不行，喝孟婆粥，男荤女素是定好的，你还是喝荤粥好了。", "");
            giTalk("仇仲：真麻烦！我一个大男人，喝了这素粥还会变女人不成！我就是不信邪，今天一定要喝一碗素粥！", "");
        }
    }
    giNpcResetDir("4012");
    giNpcResetDir("5004");
    giNpcResumeBeh("4012");
    giPlayerUnLock();
}

void func4013()
{
    giPlayerLock();
    giNpcPauseBeh("4013");
    giNpcFaceToCurrentPlayer("4013", true);
    giCurrentPlayerFaceToNpc("4013", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("石丫头：店里那外地商人刚到我们城里就直嚷着要回去，可她在这儿一住数日，现在也没有想走的意思嘛！真是个怪人。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("石丫头：客官可要来一坛咱们酆都的麻咂酒尝尝？记好哟！开了坛子先灌开水，过半个时辰，用竹管插进坛子吸着喝才最有味道。");
        giRandTalkPush("石丫头：听说人死后到了地府，要是阳寿未尽还能还阳呢！怪不得有的人气都断了还能突然活过来，这鬼差也有抓错人的时候呐。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4013");
    giNpcResumeBeh("4013");
    giPlayerUnLock();
}

void func4014()
{
    giPlayerLock();
    giNpcPauseBeh("4014");
    giNpcFaceToCurrentPlayer("4014", true);
    giCurrentPlayerFaceToNpc("4014", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("汤金花：在这儿住久了，也觉得没刚来时那么阴森，符纸的生意当然还得做，否则我这一来一回的车马费，可就白费啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("汤金花：酆都城果真和传闻中的一样阴森，晚上睡在客栈里还有怪声传来，真是毛骨悚然！亏这里的人还能一直住下去！");
        giRandTalkPush("汤金花：我听说酆都的符纸生意好，就想着来这儿卖符纸大赚一笔，没想到这地方简直就是个阴曹地府，鬼门关、奈何桥、阎王殿，就差没十八层地狱了！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4014");
    giNpcResumeBeh("4014");
    giPlayerUnLock();
}

void func4015()
{
    giPlayerLock();
    giNpcPauseBeh("4015");
    giNpcFaceToCurrentPlayer("4015", true);
    giCurrentPlayerFaceToNpc("4015", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("洛淑娴：俗话说“七月十五鬼乱窜”，中元节那天，我坐在家里就能看见窗外山上鬼火簇簇，还听到哭声呢！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("洛淑娴：每年中元节，城里都有庙会，到时候，从山脚一直到山顶酆都大帝庙门前，满城都是冥纸、冥衣、线香、烛火……该有的一样不少！");
        giRandTalkPush("洛淑娴：夜里子时，从山下的城门口，可以去鬼界，不过听人说，那也只是鬼界最外头，进不到更里面，想要见到死去的亲人更是难上加难！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4015");
    giNpcResumeBeh("4015");
    giPlayerUnLock();
}

void func4016()
{
    giPlayerLock();
    giNpcPauseBeh("4016");
    giNpcFaceToCurrentPlayer("4016", true);
    giCurrentPlayerFaceToNpc("4016", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("卢定屏：蜀山仙剑派的仙人个个法力高深，行走江湖时不仅斩妖除魔，更是惩奸除恶，实乃真英雄、真仙人也！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("卢定屏：酆都城外的平都山，是道家七十二福地之一，汉时还有王方平、阴长生两人在此得道成仙，如此说来，这酆都应是仙城，而不是如今这般的鬼城呀？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4016");
    giNpcResumeBeh("4016");
    giPlayerUnLock();
}

void func4017()
{
    giPlayerLock();
    giNpcPauseBeh("4017");
    giNpcFaceToCurrentPlayer("4017", true);
    giCurrentPlayerFaceToNpc("4017", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("小峰：潘家哥哥去蜀山求仙丹回来了！他说蜀山的仙人都很好，一听他说是帮爷爷求药，马上就把仙丹给了他～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("小峰：潘家哥哥人真好，天天服侍他爷爷，这回他爷爷病了，他还特地上蜀山去求仙丹呢！");
        giRandTalkPush("小峰：你看！这是潘家哥哥给我做的竹剑，不错吧？看起来是不是像蜀山仙人一样神气？嘻嘻～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4017");
    giNpcResumeBeh("4017");
    giPlayerUnLock();
}

void func4018()
{
    giPlayerLock();
    giNpcPauseBeh("4018");
    giNpcFaceToCurrentPlayer("4018", true);
    giCurrentPlayerFaceToNpc("4018", true);
    giRandTalkRelease();
    giRandTalkPush("商老太：眼前这桥就是奈何桥，那边不远处的池子叫做“血河池”，我常在这儿烧纸钱、供香火，希望以后在阴间的日子能过的好些。");
    giRandTalkPush("商老太：阴间的奈何桥可是和这座不太一样，听说窄得很呐，只有生前为善的人才能通过，生前为恶的人，只能掉下去，被河里的毒虫吃掉！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4018");
    giNpcResumeBeh("4018");
    giPlayerUnLock();
}

void func4019()
{
    giPlayerLock();
    giNpcPauseBeh("4019");
    giNpcFaceToCurrentPlayer("4019", true);
    giCurrentPlayerFaceToNpc("4019", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("傅继德：最近来了个外乡人，也是卖符纸的！他那不知从哪里学来的邪门歪道，怎么比得上我这蜀山仙人亲传的符法？想跟我抢生意，作梦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("傅继德：少侠，要不要在我这儿买几张符纸辟邪？随身带着总是好的～");
        giRandTalkPush("傅继德：告诉你别不信，我这画符的法子是蜀山仙人教的，不仅能驱邪护身，还能斩妖除魔呢～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4019");
    giNpcResumeBeh("4019");
    giPlayerUnLock();
}

void func4021()
{
    giPlayerLock();
    giNpcPauseBeh("4021");
    giNpcFaceToCurrentPlayer("4021", true);
    giCurrentPlayerFaceToNpc("4021", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("董桂花：我才刚知道，原来蜀山上也有女仙人的，你看我怎么样～要是努力修行，也能得道吗？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("董桂花：那次我在山中被毒蛇咬伤，幸好被一个路过的剑仙所救，他长得好英俊呀～可人家不是说仙人都很长寿的吗？他不会已经几百岁了吧？");
        giRandTalkPush("董桂花：听说蜀山派的仙人大都清心寡欲，一心只为修仙，难道他们都不结婚生子吗？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4021");
    giNpcResumeBeh("4021");
    giPlayerUnLock();
}

void func4022()
{
    giPlayerLock();
    giNpcPauseBeh("4022");
    giNpcFaceToCurrentPlayer("4022", true);
    giCurrentPlayerFaceToNpc("4022", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("常梦如：唉，小花托梦给我，说它吃了姐姐炼的丹药，已经变成了一只仙猪，以后都不会再回来了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("常梦如：我们药栈的紫菁玉蓉膏，是我姐姐上蜀山求了仙人三天三夜，仙人才给她的秘方！不管你有什么病，只要一瓶药，保管你立刻就好起来！");
        giRandTalkPush("常梦如：我的天啊！姐姐炼的仙丹被家里的小花偷吃了，它吃过就断气了，也不知是不是尸解成仙了？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4022");
    giNpcResumeBeh("4022");
    giPlayerUnLock();
}

void func4023()
{
    giPlayerLock();
    giNpcPauseBeh("4023");
    giNpcFaceToCurrentPlayer("4023", true);
    giCurrentPlayerFaceToNpc("4023", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("孙安：师父上次炼成的仙丹不小心被后院的猪吃了，后来就再也没炼成第二颗，她为了这事烦恼得要命……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("孙安：我师父真是个神医，连仙丹都能炼出来！上回我亲眼看见后院的猪吃了仙丹，立刻就升天了，只留下一副臭皮囊！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4023");
    giNpcResumeBeh("4023");
    giPlayerUnLock();
}

void func4024()
{
    giPlayerLock();
    giNpcPauseBeh("4024");
    giNpcFaceToCurrentPlayer("4024", true);
    giCurrentPlayerFaceToNpc("4024", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("黄凤苹：江湖上打打杀杀的事我已经厌了，这几天想着干脆就上蜀山拜师修仙，从此远离纷争，但又不知蜀山派收不收我这满手血腥的江湖人。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("黄凤苹：前阵子我在城外山上被仇家打伤，逃进城来买伤药，常大夫给了我一瓶紫菁玉容膏，才用了一回，我的伤就好了大半～");
        giRandTalkPush("黄凤苹：那天我被仇家追杀，夜半进城，在城门处看到一道青光，几个人就凭空消失了！第二天听城里人说起，才知道子时能从城门口去鬼界……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4024");
    giNpcResumeBeh("4024");
    giPlayerUnLock();
}

void func4025()
{
    giPlayerLock();
    giNpcPauseBeh("4025");
    giNpcFaceToCurrentPlayer("4025", true);
    giCurrentPlayerFaceToNpc("4025", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("贾大嘴：马彪他娘子都死了好几年了，他不再娶，还每月请道士做法让他娘子还阳来相见，真比女人还死心眼！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("贾大嘴：酆都大帝殿就在山顶上，只有十殿阎王、玉皇大帝、王母娘娘生辰的日子才能进殿拜祭，其余时候一律不得上山！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4025");
    giNpcResumeBeh("4025");
    giPlayerUnLock();
}

void func4026()
{
    giPlayerLock();
    giNpcPauseBeh("4026");
    giNpcFaceToCurrentPlayer("4026", true);
    giCurrentPlayerFaceToNpc("4026", true);
    giRandTalkRelease();
    giRandTalkPush("马彪：平日不能上山的，你请回吧，要是想拜酆都大帝，每年的九月九再来。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4026");
    giNpcResumeBeh("4026");
    giPlayerUnLock();
}

void func4027()
{
    giPlayerLock();
    giNpcPauseBeh("4027");
    giCurrentPlayerFaceToNpc("4027", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4027", true);
        giRandTalkRelease();
        giRandTalkPush("葛大娘：上次我家三宝莫名其妙犯癫痫，多亏了蒋道士给的符，才让他捡回一条小命！后来三宝自己说，以前总去别人的坟头偷供品吃！这孩子，真是不要命了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giNpcFaceToNpc("4027", "4009", true);
        giNpcFaceToNpc("4009", "4027", true);
        giTalk("葛大娘：蒋道士！您救救我家三宝吧！有天夜里他从坟地回来，就突然犯了癫痫，话也说不出，饭也喂不进！", "");
        giTalk("蒋子牙：莫急莫急，令郎这是冲犯了死人，恶鬼上身哪。", "");
        giTalk("葛大娘：这小子常常往坟地里跑，也不知道他是去干嘛了！这回终于闯祸了，道士您可千万要救救他啊！", "");
        giTalk("蒋子牙：我给你三道符，你将它们供到祭桌上，早中晚各三柱香，到第二天将符纸拿到香烛上烧了，符灰兑水给令郎喝，就该没事了。", "");
    }
    giNpcResetDir("4027");
    giNpcResetDir("4009");
    giNpcResumeBeh("4027");
    giPlayerUnLock();
}

void func4028()
{
    giPlayerLock();
    giNpcPauseBeh("4028");
    giNpcFaceToCurrentPlayer("4028", true);
    giCurrentPlayerFaceToNpc("4028", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("罗天海：“能上山、莫下水”，要不是我这把老骨头经不起每天在山里头砍柴打猎的折腾，也不用每天到山下的大江里去吃风浪啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("罗天海：其实这山上只是酆都城的一部分，山下的房子和人更多，店家也更热闹，我一直都很想搬到山下去住，却又担心随便移居引来鬼神不满……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4028");
    giNpcResumeBeh("4028");
    giPlayerUnLock();
}

void func4036()
{
    giPlayerLock();
    giNpcPauseBeh("4036");
    giNpcFaceToCurrentPlayer("4036", true);
    giCurrentPlayerFaceToNpc("4036", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("顾思：听傅师父说，各路神仙道士画的符，还全都是不一样的！这……反正符纸上画什么我也看不明白，只要能驱鬼辟邪，还不是全一样～", "");
    }
    else
    {
        giTalk("顾思：傅师父画符的本事高着呢！我每天都在铺子里看他画，明明只要用毛笔沾了朱砂就行，可我就怎么都学不来……", "");
    }
    giNpcResetDir("4036");
    giNpcResumeBeh("4036");
    giPlayerUnLock();
}

void func4037()
{
    giPlayerLock();
    giNpcPauseBeh("4037");
    giNpcFaceToCurrentPlayer("4037", true);
    giCurrentPlayerFaceToNpc("4037", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("芳蕊：酆都阴气重，在城里是不太要紧，但要是上山采茶采药的，总得带些符纸在身上，即使遇到什么不干净的东西，有符在身就不用怕。", "");
    }
    else
    {
        giTalk("芳蕊：城里会画符的人很多，不过傅师父画符的本事，听说是跟蜀山上的仙人学来的，符上的咒术可厉害呢！", "");
    }
    giNpcResetDir("4037");
    giNpcResumeBeh("4037");
    giPlayerUnLock();
}

void func4042()
{
    giPlayerLock();
    giNpcPauseBeh("4042");
    gi2DSoundPlay("WB021", 1);
    giNpcResumeBeh("4042");
    giPlayerUnLock();
}

void func4040()
{
    giPlayerLock();
    giNpcPauseBeh("4040");
    gi2DSoundPlay("WB021", 1);
    giNpcResumeBeh("4040");
    giPlayerUnLock();
}

void func4030()
{
    giPlayerLock();
    giNpcPauseBeh("4030");
    gi2DSoundPlay("WB021", 1);
    giNpcResumeBeh("4030");
    giPlayerUnLock();
}

void func4031()
{
    giPlayerLock();
    giNpcPauseBeh("4031");
    gi2DSoundPlay("WB020", 1);
    giNpcResumeBeh("4031");
    giPlayerUnLock();
}

void func4032()
{
    giPlayerLock();
    giNpcPauseBeh("4032");
    gi2DSoundPlay("WB021", 1);
    giNpcResumeBeh("4032");
    giPlayerUnLock();
}

void func4034()
{
    giPlayerLock();
    giNpcPauseBeh("4034");
    gi2DSoundPlay("WB021", 1);
    giNpcResumeBeh("4034");
    giPlayerUnLock();
}

void func5001()
{
    giPlayerLock();
    giNpcPauseBeh("4035");
    giNpcFaceToCurrentPlayer("4035", true);
    giCurrentPlayerFaceToNpc("4035", true);
    giStartTradeSystem("shop008", "");
    giNpcResetDir("4035");
    giNpcResumeBeh("4035");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("47");
    giNpcFaceToCurrentPlayer("47", true);
    giCurrentPlayerFaceToNpc("47", true);
    giStartTradeSystem("shop018", "");
    giNpcResetDir("47");
    giNpcResumeBeh("47");
    giPlayerUnLock();
}

void func5005()
{
    giPlayerLock();
    giNpcPauseBeh("46");
    giNpcFaceToCurrentPlayer("46", true);
    giCurrentPlayerFaceToNpc("46", true);
    giStartTradeSystem("shop018", "");
    giNpcResetDir("46");
    giNpcResumeBeh("46");
    giPlayerUnLock();
}

void func5003()
{
    giPlayerLock();
    giNpcPauseBeh("4045");
    giNpcFaceToCurrentPlayer("4045", true);
    giCurrentPlayerFaceToNpc("4045", true);
    if (maze_var8 != 0)
    {
        if (maze_var8 != 1)
        {
            giStartTradeSystem("shop029", "");
        }
        else
        {
            if (giCheckEquipInInventory(3501))
            {
                giTalk("甘将：这把木剑的做工看起来很精细，不错、不错～我就用这把函灵剑换你的木剑吧，就算加上替我跑腿的盘缠，小兄弟你也不吃亏。", "");
                giRemoveEquipment(3501, true);
                giWait(2.0);
                giAddEquipment(3521, true);
                giWait(2.0);
                maze_var8 = 2;
            }
            giStartTradeSystem("shop029", "");
        }
    }
    else
    {
        giStartTradeSystem("shop029", "Buiness_Q13_5003");
    }
    giNpcResetDir("4045");
    giNpcResumeBeh("4045");
    giPlayerUnLock();
}

void func5004()
{
    giPlayerLock();
    giNpcPauseBeh("5004");
    giNpcFaceToCurrentPlayer("5004", true);
    giCurrentPlayerFaceToNpc("5004", true);
    giStartTradeSystem("shop036", "");
    giNpcResetDir("5004");
    giNpcResumeBeh("5004");
    giPlayerUnLock();
}

void func5007()
{
    giPlayerLock();
    giNpcPauseBeh("5007");
    giNpcFaceToCurrentPlayer("5007", true);
    giCurrentPlayerFaceToNpc("5007", true);
    giStartTradeSystem("shop018", "");
    giNpcResetDir("5007");
    giNpcResumeBeh("5007");
    giPlayerUnLock();
}

void func5006()
{
    int inn_dialog_result = 0;
    int money_amount = 0;
    int common_dialog_last_select = 0;

    giPlayerLock();
    giNpcPauseBeh("5006");
    giNpcFaceToCurrentPlayer("5006", true);
    giCurrentPlayerFaceToNpc("5006", true);
    giShowInnDialog(false);
    inn_dialog_result = giGetInnDialogResult();
    money_amount = giGetMoney();
    if (giGetInnDialogResult() == 1)
    {
        giShowCommonDialogInSelectMode("花费150文钱住宿吗？", 0.5, 0.4);
        common_dialog_last_select = giCommonDialogGetLastSelect();
        if (giCommonDialogGetLastSelect() == 1)
        {
            if (money_amount >= 150)
            {
                giFlashOutBlack(3.0, true, true);
                giPayMoney(150, true);
                giPlayerTakeARest();
                giWait(2.0);
                giFlashInBlack(3.0, true);
            }
            else
            {
                giTalk("石崇：您身上的钱不够。", "");
            }
        }
    }
    giPlayerSetAttr(-1, -1, 100);
    giNpcResetDir("5006");
    giNpcResumeBeh("5006");
    giPlayerUnLock();
}

void Buiness_Q13_5003()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("我这铁铺别的东西卖不掉，只有这驱鬼用的桃木剑，总是有人要买。不过我是个铁匠，不怎么擅长做木剑，小兄弟，能帮我找把<colour red=255 green=187 blue=0 alpha=255>木剑</colour><dc0>来，让我好好学一学吗？</dc0><br/><dc0>你愿意帮我去找把吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var8 = 1;
    }
}
