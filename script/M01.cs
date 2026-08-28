// Structured PAL4 reconstruction for M01.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M01_1_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar == 10300 /* 序章 / 1-2-1.沉溪猎猪 / 进洞抓山猪 / 晚起祭父 */)
    {
        giTimeScriptTerminate();
        func2001();
        giTimeScript(180.0, "func9001");
    }
    if (global_mvar == 10602)
    {
        giTimeScriptTerminate();
        func2004();
        giTimeScript(180.0, "func9001");
    }
    if (global_mvar >= 11100 /* 序章 / 1-3-1.红衣少女 / 进密室查看 */)
    {
        giSetObjectVisible("MO003", false);
        giSetObjectVisible("Jeffect006", true);
    }
    if (global_mvar != 11100 /* 序章 / 1-3-1.红衣少女 / 进密室查看 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("title01", true);
        giArenaReadyRestore();
    }
}

void M01_3_init()
{
    LL_001(global_mvar);
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void LL_001(int arg0)
{
    // typed_typeinfo_hints: primary=void; extras=[int]
    // prototype_hint: void LL_001(int)
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giMonsterSetHide("m01-02-02", false);
        giMonsterSetHide("m01-02-01", false);
        giMonsterSetHide("m01-02-03", false);
        giMonsterSetHide("m01-03-01", false);
        giMonsterSetHide("m01-03-02", false);
        giMonsterSetHide("m01-03-03", false);
        giMonsterSetHide("m01-04-01", false);
        giSetObjectVisible("MNPC", true);
        giSetObjectVisible("MNPC1", true);
    }
    else
    {
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4002", false);
        giSetNpcVisible("4003", false);
        giSetNpcVisible("4005", false);
        giSetNpcVisible("4006", false);
        giSetNpcVisible("4007", false);
        giSetNpcVisible("4008", false);
        giSetNpcVisible("4009", false);
        giSetNpcVisible("4010", false);
        giSetNpcVisible("4011", false);
        giSetNpcVisible("4012", false);
        giSetNpcVisible("4013", false);
        giSetNpcVisible("4015", false);
        giSetNpcVisible("4016", false);
        giSetNpcVisible("4017", false);
        giSetNpcVisible("4018", false);
        giSetNpcVisible("4019", false);
        giSetNpcVisible("4020", false);
        giSetNpcVisible("4021", false);
        giSetNpcVisible("4022", false);
        giSetNpcVisible("4023", false);
        giSetNpcVisible("4024", false);
        giSetNpcVisible("4025", false);
        giSetNpcVisible("4026", false);
        giSetNpcVisible("4027", false);
        giSetNpcVisible("4028", false);
        giSetNpcVisible("4029", false);
        giSetNpcVisible("4030", false);
    }
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    giPlayerCurrentSetPos(-638.6, 40.1, 2595.8);
    giPlayerCurrentSetAng(126.0);
    giCameraSetMode(5, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    if (global_mvar == 11100 /* 序章 / 1-3-1.红衣少女 / 进密室查看 */)
    {
        giArenaLoad("M01", "2", "", true);
        func2005();
    }
}

void func1002()
{
    if (global_mvar > 20000)
    {
        giArenaLoad("M01", "3", "", true);
        giPlayerCurrentSetPos(-524.9, -124.3, -1106.5);
        giPlayerCurrentSetAng(60.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("M01", "1", "", true);
        giPlayerCurrentSetPos(-524.9, -124.3, -1106.5);
        giPlayerCurrentSetAng(60.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1003()
{
}

void func1004()
{
    if (global_mvar != 10601)
    {
        if (global_mvar < 160700 || global_mvar >= 160901 /* 照看菱纱 */)
        {
            giArenaLoad("Q01", "Q01", "", true);
            giPlayerCurrentSetPos(-2308.0, -119.0, -1302.0);
            giPlayerCurrentSetAng(349.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        else
        {
            giArenaLoad("Q01", "Q01Y", "", true);
            giPlayerCurrentSetPos(-2308.0, -119.0, -1302.0);
            giPlayerCurrentSetAng(349.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
    }
    else
    {
        giArenaLoad("Q01", "Q01", "", true);
    }
}

void func2001()
{
    if (global_mvar == 10300 /* 序章 / 1-2-1.沉溪猎猪 / 进洞抓山猪 / 晚起祭父 */)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetPos(-452.0, 40.0, 2527.0);
        giPlayerCurrentSetAng(144.0);
        giHideGASkillObject();
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("003", true);
        giFlashInBlack(1.0, false);
        giArenaReady();
        giPlayerWalkTo(0, -353.0, 40.0, 2282.0, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 166.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：（这地方好暗，以前都没进来过——）", "40029");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("004", false);
        giPlayerCurrentSetAng(210.0);
        giIMMEnd();
        giWait(0.5);
        giCameraRunSingle("005", false);
        giWait(0.3);
        giSetPortrait("101D", false);
        giTalk("云天河：（那是……？）", "40030");
        giSetPortrait("101C", false);
        giTalk("云天河：（……爹说过的机关？）", "40031");
        giPlayerRunTo(0, -498.0, 39.0, 2097.0, false);
        giCameraRunSingle("007", true);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 195.0, true);
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：（爹说只要有这机关，其他人绝对不会闯到洞里。）", "40032");
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：……不～会～吧！！", "40033");
        giSetPortrait("101D", false);
        giTalk("云天河：刚才闯进来的那只，难不成就是爹说过的“妖怪”？……“猪妖”？", "40034");
        giSetPortrait("101D", false);
        giTalk("云天河：所以才会开机关？！", "40035");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "J15", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：糟了、糟了！<colour red=255 green=187 blue=0 alpha=255>猪妖闯进了石沉溪洞，</colour><dc0>被爹知道我就惨了！怎么会这样？！</dc0>", "40036");
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：死猪妖，看我饶不了你！把你抓来烤上十遍八遍！！", "40037");
        giPlayerEndAction(0);
        giSetPortrait("101H", false);
        giTalk("云天河：……可是，又没见过妖怪，不知道打不打得过……", "40038");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：不行！打不过也要打，妖怪厉不厉害不知道，但爹生起气来我可是知道的。", "40039");
        giPlayerEndAction(0);
        giPlayerSetDir(0, 232.0, true);
        giWait(0.6);
        giPlayerDoAction(0, "J23", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：死猪妖，快给我出来呀！", "40040");
        giFlashOutBlack(1.5, true, true);
        global_mvar = 10400; // 0x000028A0, 序章 / 1-2-2.沉溪猎猪 / 洞中找猪妖
        giShowSignpost();
        giPlayerCurrentSetPos(-405.0, 40.0, 2159.0);
        giPlayerCurrentSetAng(256.0);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giShowTutorial(17);
        giPlayerUnLock();
    }
}

void func2002()
{
    if (global_mvar == 10400 /* 序章 / 1-2-2.沉溪猎猪 / 洞中找猪妖 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetLeader(0);
        giIMMBegin();
        giPlayerCurrentSetPos(-1202.0, 40.0, 1666.0);
        giPlayerCurrentSetAng(202.0);
        giPlayerSetPos(1, -1622.0, 46.0, 1411.0);
        giPlayerSetVisible(1, true);
        giSetObjectVisible("MO001", true);
        giHideGASkillObject();
        giMonsterSetHide("m01-01-01", false);
        giPlayerSetAng(1, 222.0);
        giIMMEnd();
        giPlayerDoAction(1, "J03", -1, false);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giWait(0.3);
        giFlashInBlack(1.5, false);
        giCameraRunSingle("002", false);
        giPlayerWalkTo(0, -1261.0, 40.0, 1534.0, false);
        giPlayerEndMove(0);
        giWait(0.3);
        giPlayerDoAction(0, "J13", 1, true);
        giWait(0.3);
        giPlayerDoAction(0, "J03", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：（……不太妙！越往里走地面的土越少，都看不清猪妖的脚印了——）", "40041");
        giSetPortrait("101C", false);
        gi2DSoundPlay("WJ006", 1);
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：（咦？！）", "40042");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 251.0, true);
        giWait(0.3);
        giSetPortrait("101I", false);
        giTalk("云天河：（在那边！！死猪妖！看你往哪跑！）", "40043");
        giSetNpcVisible("MN001", true);
        giPlayerSetVisible(0, false);
        giNpcDoAction("MN001", "J25", 1, false);
        giWait(0.6);
        gi2DSoundPlay("WJ067", 1);
        giWait(0.7);
        gi2DSoundPlay("WH030", 1);
        giWait(0.1);
        giSetObjectVisible("Jeffect001", true);
        giWait(0.5);
        gi2DSoundPlay("WF004", 1);
        giCameraRunSingle("003", true);
        giWait(1.3);
        giCameraRunSingle("004", false);
        giTalk("？？：啊！！谁这么卑鄙，居然放冷箭！	", "40044");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：（那是……）", "40045");
        giSetObjectVisible("Jeffect002", true);
        giTalk("？？：咦？！——喂喂喂，到底有没有常识啊，把剑当箭射！", "40046");
        giScriptMusicPlay("P24", 2, 0.0, 0.0);
        giWait(0.3);
        giSetObjectVisible("MO001", false);
        giWait(0.3);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 78.0, true);
        giWait(0.3);
        giTalk("？？：可恶——！", "40047");
        giPlayerRunTo(1, -1346.0, 40.0, 1511.0, true);
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giPlayerSetVisible(0, true);
        giSetNpcVisible("MN001", false);
        giWait(0.2);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103F", true);
        giTalk("少女：我说，你谁啊？难道是住在这里的山顶野人？居然趁别人不注意偷袭！阴～险～！！", "40048");
        giSetObjectVisible("MO002", true);
        giSetObjectVisible("Jeffect003", true);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giIMMBegin();
        giCameraRunSingle("002", false);
        giPlayerSetAng(1, 88.0);
        giIMMEnd();
        giWait(0.3);
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：…………你……不是吧？怎么还会说人话？", "40049");
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103F", true);
        giTalk("少女：这可奇怪了～你还不是一样站在这里同我说话？还是说～你是野猴子变的妖怪？", "40050");
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101I", false);
        giTalk("云天河：你才是妖怪！我不饶你——", "40051");
        giIMMBegin();
        giCameraRunSingle("001", true);
        giPlayerSetAng(1, 65.0);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103F", true);
        giTalk("少女：喂，你、你别靠过来啊！", "40052");
        giSetPortrait("103F", true);
        giTalk("少女：哼～比蛮力我可拼不过你，姑娘我有要事在身，不奉陪了！", "40053");
        giSetPortrait("103A", true);
        giTalk("少女：看招～烟雨夺魂！", "40054");
        giPlayerDoAction(1, "J18", 1, false);
        giWait(0.5);
        giEffectPlayWithPlayer("HW_TH03.1", 1, 1);
        giWait(1.0);
        giPlayerSetVisible(1, false);
        giWait(0.3);
        giCameraRunSingle("002", true);
        giWait(0.3);
        giPlayerDoAction(0, "J34", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：……呛死人了！！", "40055");
        giSetPortrait("101D", false);
        giTalk("云天河：糟糕，被它逃了……", "40056");
        giPlayerWalkTo(0, -1288.0, 40.0, 1502.0, true);
        giPlayerSetDir(0, 265.0, true);
        giWait(0.3);
        giSetPortrait("101C", false);
        giTalk("云天河：（这支剑……奇怪～怎么还会发光？……那我以后夜里不是都不用点灯了？）", "40057");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giSetObjectVisible("Jeffect003", false);
        giWait(0.3);
        giTalk("云天河：（啊！光又消失了？……）", "40058");
        giSetPortrait("101J", false);
        giTalk("云天河：（死猪妖不但会变人形、会说人话，还使出奇怪的妖法，按爹说的，道行已经挺高了……）", "40059");
        giSetPortrait("101J", false);
        giTalk("云天河：（……不怕，就算弓箭对付不了它，还有爹教我的剑术，好在木剑我也一直带在身边～那猪妖绝对逃不掉！）", "40060");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giSetObjectVisible("MO002", false);
        global_mvar = 10600; // 0x00002968, 洞中找猪妖
        giShowSignpost();
        giMonsterSetHide("m01-01-01", true);
        giIMMEnd();
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giSetObjectVisible("Jeffect001", false);
        giSetObjectVisible("Jeffect002", false);
        giTimeScript(180.0, "func9001");
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
    }
}

void func2003()
{
    if (global_mvar == 10600 /* 洞中找猪妖 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetLeader(0);
        giIMMBegin();
        giPlayerCurrentSetPos(153.0, -126.0, -893.0);
        giPlayerCurrentSetAng(231.0);
        giMonsterSetHide("m01-02-02", false);
        giHideGASkillObject();
        giIMMEnd();
        giCameraPrepare("MC004");
        giCameraRunSingle("001", true);
        giWait(0.3);
        giFlashInBlack(1.5, false);
        giPlayerRunTo(0, -92.0, -125.4, -994.0, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 236.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：（整个石沉溪洞都跑遍了，也没瞧见那只猪妖，难不成逃到洞外去了？）", "40061");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101E", false);
        giTalk("云天河：（呼～但愿爹在阴间偶尔打打瞌睡，没瞧见这里发生的事，不然我可惨了。）", "40062");
        giWait(0.3);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：（爹说他和娘葬在洞中，连我都不清楚在哪，他总是神神秘秘的——）", "40063");
        giSetPortrait("101G", true);
        giTalk("云天河：（石沉溪洞……爹……）", "40064");
        giFlashOutWhite(3.0, true, true);
        global_mvar = 10601; // 0x00002969
        giTimeScript(180.0, "func9001");
        giArenaLoad("Q01", "Q01", "", false);
    }
}

void func2004()
{
    giPlayerLock();
    giTimeScriptTerminate();
    giScriptMusicPlay("P23", 2, 0.0, 0.0);
    giCameraSetCollide(false);
    giPlayerSetLeader(0);
    giPlayerCurrentSetPos(-208.0, -124.0, -1039.0);
    giPlayerCurrentSetAng(270.0);
    giPlayerSetPos(1, 46.0, -135.0, -1104.0);
    giPlayerSetAng(1, 278.0);
    giPlayerSetVisible(1, true);
    giMonsterSetHide("m01-02-02", false);
    giSetNpcVisible("MN003", true);
    giCameraPrepare("MC005");
    giCameraRunSingle("001", true);
    giArenaReady();
    giFlashInWhite(3.0, true);
    giWait(0.5);
    giSetPortrait("101G", false);
    giTalk("云天河：……唉……", "40095");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101E", false);
    giTalk("云天河：……我命在我也，不在于天……似懂非懂，有点难懂……还是别懂了……", "40096");
    giWait(0.7);
    gi2DSoundPlay("WJ058", 1);
    giWait(0.5);
    giPlayerSetDir(0, 101.0, true);
    giWait(0.8);
    giCameraRunSingle("002", false);
    giWait(1.0);
    giPlayerDoAction(1, "J02", 1, false);
    giSetPortrait("103D", false);
    giTalk("少女：啊！！怎么、你比我先到？！", "40097");
    giPlayerDoAction(0, "J18", 1, false);
    giSetPortrait("101H", true);
    giTalk("云天河：来的正好，看你这回往哪逃！", "40098");
    giPlayerEndAction(1);
    giPlayerDoAction(1, "J18", 1, false);
    giSetPortrait("103D", false);
    giTalk("少女：烟雨夺——咦？！", "40099");
    giPlayerDoAction(1, "J02", -1, false);
    giSetPortrait("103D", false);
    giTalk("少女：不可能！我明明记得还剩一个！！", "40100");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101H", true);
    giTalk("云天河：死猪妖，别想再用古怪的妖法！今天的晚饭已经决定！就是你了！", "40101");
    giSetNpcVisible("MN002", true);
    giPlayerSetVisible(0, false);
    giNpcDoAction("MN002", "J25", 1, false);
    giWait(0.6);
    gi2DSoundPlay("WJ067", 1);
    giWait(0.7);
    gi2DSoundPlay("WH030", 1);
    giWait(0.1);
    giSetObjectVisible("Jeffect004", true);
    giWait(0.1);
    gi2DSoundPlay("WF004", 1);
    giWait(0.3);
    giPlayerDoAction(1, "J19", -1, false);
    giSetObjectVisible("MO004", true);
    giSetObjectVisible("Jeffect005", true);
    giSetPortrait("101D", true);
    giTalk("云天河：怎么会……", "40102");
    giWait(0.3);
    giCameraRunSingle("003", true);
    giWait(1.0);
    giPlayerSetVisible(0, true);
    giSetObjectVisible("Jeffect008", true);
    giWait(0.2);
    giSetNpcVisible("MN002", false);
    giSetObjectVisible("Jeffect005", false);
    giSetObjectVisible("MO004", false);
    giWait(1.0);
    giCameraRunSingle("004", true);
    giWait(0.8);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：这把剑……", "40103");
    giSetPortrait("103I", false);
    giTalk("少女：可恶！还好我闪得快！真想要我的命吗？！", "40104");
    giSetPortrait("103I", false);
    giTalk("少女：你到底是哪里来的野人啊！带着一把怪剑，还会自己飞来飞去！", "40105");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：我、我也不知道，以前从来没有这样过……", "40106");
    giSetPortrait("101C", true);
    giTalk("云天河：又是发光，又是自己飞回来……", "40107");
    giSetPortrait("103F", false);
    giTalk("少女：你刚才说我什么？你说的最后一句！", "40108");
    giPlayerDoAction(0, "C07", -1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：你是我的晚饭！", "40109");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("103F", false);
    giTalk("少女：不对，是你说的倒数第二句！", "40110");
    giSetPortrait("101C", true);
    giTalk("云天河：你是猪妖！", "40111");
    giSetPortrait("103K", false);
    giTalk("少女：你你你——！！洗干净你的耳朵听好了，本姑娘“韩菱纱”，好歹也算一个如花似玉的少女，几时成了你嘴里的“猪腰”、“猪肝”！", "40112");
    giCameraRunSingle("005", true);
    giWait(0.3);
    giSetPortrait("101D", false);
    giTalk("云天河：少、女？", "40113");
    giSetPortrait("103K", true);
    giTalk("韩菱纱：而且还说我是你的晚饭，下流淫贼！你想对我做什么？！", "40114");
    giPlayerDoAction(0, "J02", -1, false);
    giSetPortrait("101D", false);
    giTalk("云天河：你……是女人？爹说过的那种？", "40115");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("103I", true);
    giTalk("韩菱纱：越说越过份！你倒是说说我哪点不像女人！", "40116");
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：……是女人，那就不是猪妖啰……", "40117");
    giSetPortrait("103D", true);
    giTalk("韩菱纱：（……骗、骗人的吧？这人到底是从哪冒出来的呆子，好像连女人也没见过，看起来又不像假的……）", "40118");
    gi2DSoundPlay("WJ002", 1);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetDir(0, 70.0, true);
    giCameraRunSingle("006", true);
    giWait(0.3);
    giCameraRunSingle("007", false);
    giNpcWalkTo("MN003", 453.0, -53.0, -802.0, true);
    giNpcSetDir("MN003", 242.0, true);
    giWait(1.0);
    gi2DSoundPlay("WJ038", 1);
    giTalk("山猪：…………", "40119");
    giWait(1.5);
    giNpcRunTo("MN003", 523.0, 6.0, -554.0, true);
    giWait(0.5);
    giCameraRunSingle("006", true);
    giWait(0.3);
    giSetPortrait("101D", false);
    giTalk("云天河：…………", "40120");
    giSetPortrait("101D", false);
    giTalk("云天河：山、山猪…………", "40121");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：…………", "40122");
    giCameraPrepare("MC006");
    giCameraRunSingle("001", true);
    giWait(0.3);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：哦～我明白了，你追着山猪进山洞，后来遇上我，所以就弄错了，对不对？", "40123");
    giPlayerRunTo(0, 12.0, -133.4, -1105.0, true);
    giPlayerSetDir(0, 85.0, false);
    giWait(0.5);
    giSetPortrait("101F", true);
    giTalk("云天河：我弄错了？……好、好像是……", "40124");
    giSetPortrait("101C", true);
    giTalk("云天河：(奇怪……她不是猪妖，那门的机关是哪只猪打开的？！)", "40125");
    giSetPortrait("101A", true);
    giTalk("云天河：你，刚才有没有受伤？", "40126");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：哼，可算想起来了，还不过来扶我一把，闪得太急，脚都扭到了。", "40127");
    giSetObjectVisible("Jeffect008", false);
    giSetPortrait("101D", true);
    giTalk("云天河：扶你？", "40128");
    giCameraRunSingle("003", true);
    giPlayerDoAction(0, "J05", 1, false);
    giSetPortrait("101H", true);
    giTalk("云天河：那不行！我爹说过，男女授受不亲，不能乱摸的。", "40129");
    giSetPortrait("103G", false);
    giTalk("韩菱纱：你！想得美！谁让你摸了，是扶、扶我一下！ ", "40130");
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101E", true);
    giTalk("云天河：好吧，我这可是为了帮你……", "40131");
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J03", -1, true);
    giWait(0.5);
    giSetPortrait("103G", false);
    giTalk("韩菱纱：哼～谢啦。", "40132");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerSetDir(1, 264.0, false);
    giPlayerEndAction(0);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：我说，看你这样，好像完全没见过什么世面，连女人都没见过，应该也不是山脚下村子里的人吧？", "40133");
    giSetPortrait("101A", true);
    giTalk("云天河：我一直住在山上。", "40134");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：难怪从没见过女孩子～真不知道你爹怎么和你说的！", "40135");
    giSetPortrait("101C", true);
    giTalk("云天河：说什么？", "40136");
    giSetPortrait("103G", false);
    giTalk("韩菱纱：说“男女授受不亲”之类的啊。", "40137");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：他、我爹说，女孩子的胸和男孩子的不一样，软软的，不可以随便乱摸。", "40138");
    giPlayerDoAction(1, "J15", 1, false);
    giSetPortrait("103G", false);
    giTalk("韩菱纱：你！淫贼啊！原以为你爹是个儒酸文人，竟然教出你这种傻瓜，没想到也是个胡言乱语之徒。", "40139");
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J18", 1, false);
    giSetPortrait("101I", true);
    giTalk("云天河：住口！虽然我听不太懂你在说什么，不过不许说我爹的坏话，他是天底下最厉害的人！", "40140");
    giCameraRunSingle("005", true);
    giWait(0.5);
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：好了好了～别气，算我讲错总行了吧？", "40141");
    giPlayerEndAction(1);
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103C", false);
    giTalk("韩菱纱：你一直说这个山洞叫“石沉溪洞”，是不是知道这里的秘密？告诉我好不好？", "40142");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101H", true);
    giTalk("云天河：你是故意闯进来的？我爹说过，不能让别人进到石沉溪洞。", "40143");
    giSetPortrait("101H", true);
    giTalk("云天河：看来猪没开机关，是你把机关打开闯进来的，你到底想干什么？！", "40144");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：我……", "40145");
    giScriptMusicStop(0, 2.5);
    giScriptMusicPlay("P42", 2, 0.0, 2.5);
    giSetPortrait("101I", true);
    giTalk("云天河：（嗯？！有杀气！）", "40146");
    giPlayerDoAction(0, "J18", 1, false);
    giSetPortrait("101I", true);
    giTalk("云天河：（难道…………这女的要杀我？！）", "40147");
    giWait(0.3);
    giCameraRunSingle("006", false);
    giWait(0.3);
    giPlayerDoAction(1, "J02", 1, false);
    giSetPortrait("103D", false);
    giTalk("韩菱纱：喂喂喂～怎么说的好好的，你翻脸跟翻书一样？ ", "40148");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：洞口那里又没写不让人进，我哪知道呀，你说对不对？", "40149");
    giPlayerEndAction(0);
    giSetPortrait("101I", true);
    giTalk("云天河：话不能这么说吧……你、你到底想怎样？", "40150");
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：这样好了，我告诉你我来这儿的原因，你就说出你知道的秘密好不好？", "40151");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：这就扯平了，谁也不吃亏～", "40152");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101H", true);
    giTalk("云天河：我——", "40153");
    gi2DSoundPlay("WJ007", 1);
    giTalk("？？：嘘为云雨，嘻为雷霆。通天彻地，出幽入明，千变万化，何者非我！", "40154");
    giWait(1.5);
    giPlayerSetDir(0, 271.0, false);
    giPlayerSetDir(1, 283.0, false);
    giCameraPrepare("MC007");
    giCameraRunSingle("001", true);
    giCameraRunSingle("002", false);
    giCameraWait();
    giEffectPlayWithNPC("H_082", 1, "MN004");
    giWait(0.2);
    giSetNpcVisible("MN004", true);
    giWait(0.5);
    giPlayerDoAction(1, "J02", -1, false);
    giSetPortrait("103D", true);
    giTalk("韩菱纱：呀！这、这是什么？！鬼吗？", "40155");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：……不知道，难道杀气是他发出的？", "40156");
    giSetPortrait("103I", true);
    giTalk("韩菱纱：我、我看他好像很凶，我们先跑吧！", "40157");
    giSetPortrait("101C", false);
    giTalk("云天河：为什么要跑？我爹凶起来比他凶多了。", "40158");
    giWait(0.3);
    giCameraWait();
    giCameraRunSingle("004", true);
    giSetPortrait("B01A", true);
    giTalk("？？：吾乃魁召，奉主人之命镇守此地，凡擅自闯入者，令其立毙当场！", "40159");
    giSetPortrait("103I", false);
    giTalk("韩菱纱：立毙当场？！山顶野人，小心啦！", "40160");
    giFlashOutBlack(1.0, true, true);
    giPlayerInTeam(1, false);
    giAddPlayerEquip(1, 3526);
    giAddPlayerEquip(1, 3604);
    giSetPlayerLevel(1, 2);
    giSetFullHP();
    giSetFullMP();
    giAddCombatMonster(2579, 1);
    giAddCombatMonster(2580, 0);
    giAddCombatMonster(2580, 2);
    giConfigCombatBgm("P39");
    giConfigCombatCamera("CA7");
    giConfigCombatGroundCamera("CA12");
    giConfigCombatParam(true, 4, 2579, 2);
    giStartCombat("M01");
    giScriptMusicPlay("P42", 2, 0.0, 2.5);
    giPlayerCurrentSetPos(-135.0, -128.0, -1095.0);
    giPlayerCurrentSetAng(294.0);
    giPlayerSetPos(1, -169.0, -125.0, -1041.0);
    giPlayerSetAng(1, 283.0);
    giPlayerDoAction(0, "Z01", 0, false);
    giPlayerDoAction(1, "Z01", 0, false);
    giCameraPrepare("MC008");
    giCameraRunSingle("001", true);
    giFlashInBlack(1.0, true);
    giWait(0.5);
    giSetPortrait("103I", true);
    giTalk("韩菱纱：不行！这样砍上几百年也伤不了他！只好用那一招了，死马当活马医……", "40161");
    giSetPortrait("103I", true);
    giTalk("韩菱纱：喂，你静下心来听我念咒，<colour red=255 green=187 blue=0 alpha=255>我们一起用仙术对付他！</colour>", "40162");
    giSetPortrait("101D", false);
    giTalk("云天河：什么仙术？我不会啊！", "40163");
    giSetPortrait("103I", true);
    giTalk("韩菱纱：呆子～所以才让你静下心来听我念，临阵磨枪，总比等死强！", "40164");
    giSetPortrait("103I", true);
    giTalk("韩菱纱：道贯三才为一气耳，天以气而运行，地以气而发生，阴阳以气而惨舒，风雷以气而动荡，人身以气而呼吸，道法以气而感通。", "40165");
    giSetPortrait("101H", false);
    giTalk("云天河：你、你念慢一点，太快了我记不下来！", "40166");
    giSetPortrait("103I", true);
    giTalk("韩菱纱：水之润下，无孔不入；火之炎上，无物不焚；雷之肃敛，无坚不摧；风之肆拂，无阻不透；土之养化，无物不融！", "40167");
    giShowTutorial(26);
    giGrantMagicSystem(true, true);
    giGrantSystemUi(3, true);
    giGrantSystemUi(0, false);
    giGrantSystemUi(1, false);
    giGrantSystemUi(2, false);
    giGrantSystemUi(5, false);
    giGrantSystemUi(6, false);
    giOpenSystemUi(3);
    while (!giCheckMagicMastered())
    {
        giSetPortrait("103I", true);
        giTalk("韩菱纱：唉，不是让你静下心来吗？不要这么乱七八糟好不好……", "40168");
        giOpenSystemUi(3);
    }
    giSetPortrait("103I", true);
    giTalk("韩菱纱：好了！我们尽全力打倒他！", "40169");
    giGrantSystemUi(0, true);
    giGrantSystemUi(1, true);
    giGrantSystemUi(2, true);
    giGrantSystemUi(5, true);
    giGrantSystemUi(6, true);
    giFlashOutBlack(1.0, true, true);
    giPlayerEndAction(0);
    giSetFullHP();
    giSetFullMP();
    giAddCombatMonster(2602, 1);
    giAddCombatMonster(2580, 0);
    giAddCombatMonster(2580, 2);
    giConfigCombatBgm("P39");
    giConfigCombatCamera("CA7");
    giConfigCombatGroundCamera("CA12");
    giConfigCombatParam(false, 7, 2602, 2);
    giStartCombat("M01");
    giScriptMusicPlay("P42", 2, 0.0, 0.0);
    giSetNpcVisible("MN005", true);
    giNpcDoAction("MN005", "J26", -1, false);
    giGOBAttachToNpc("MO005", "H_083", "MN005", true);
    giPlayerSetVisible(0, false);
    giPlayerDoAction(1, "Z11", 0, false);
    giCameraRunSingle("002", true);
    giFlashInBlack(1.0, true);
    giSetPortrait("103H", false);
    giTalk("韩菱纱：（……不行，太厉害了……我心愿还没了，怎么能死在这里……还是和来路不明的山顶野人一起……）", "40170");
    giSetPortrait("101I", false);
    giTalk("云天河：厉害……我跟你拼了！看箭！", "40171");
    giCameraRunSingle("003", true);
    giPlayerEndAction(1);
    giWait(0.5);
    giPlayerSetDir(1, 147.0, true);
    giWait(0.3);
    giPlayerDoAction(1, "J02", -1, false);
    giSetPortrait("103D", true);
    giTalk("韩菱纱：你…………！", "40172");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giCameraWait();
    giWait(0.5);
    giSetPortrait("B01A", true);
    giTalk("魁召：望舒……", "40173");
    giPlayerSetDir(1, 283.0, true);
    giWait(0.3);
    giNpcDoAction("MN004", "J01", 1, false);
    giSetPortrait("B01A", true);
    giTalk("魁召：原来是主人驾临。", "40174");
    giNpcEndAction("MN004", true);
    giSetPortrait("101D", false);
    giTalk("云天河：啊！主人？！", "40175");
    giSetPortrait("B01A", true);
    giTalk("魁召：无怪乎吾感应到“望舒之气”而醒觉，初时以为错认，故言行犯上，望主人恕罪。", "40176");
    giWait(0.3);
    giNpcDoAction("MN004", "J01", 1, false);
    giSetPortrait("B01A", true);
    giTalk("魁召：魁召告退。", "40177");
    giNpcEndAction("MN004", true);
    giNpcBlendOut("MN004", 1.7, true);
    giWait(0.3);
    giScriptMusicStop(0, 2.5);
    giSetPortrait("103D", false);
    giTalk("韩菱纱：……消失了？", "40178");
    giWait(0.5);
    giGOBDetachFromNPC("MN005");
    giNpcUnHoldAct("MN005");
    giNpcEndAction("MN005", true);
    giSetPortrait("101B", false);
    giTalk("云天河：呼～好险……", "40179");
    giPlayerSetVisible(0, true);
    giSetNpcVisible("MN005", false);
    giPlayerSetDir(1, 152.0, true);
    giPlayerDoAction(1, "J16", -1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：……你好厉害～原来你早知道那个怪物害怕弓和……剑！", "40180");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giWait(0.4);
    giIMMBegin();
    giCameraRunSingle("004", false);
    giPlayerSetAng(0, 321.0);
    giIMMEnd();
    giWait(0.5);
    giSetPortrait("101B", true);
    giTalk("云天河：它害不害怕我可不知道，反正用砍的打不赢，射死它不就得了？", "40181");
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：什么嘛……搞半天还是傻瓜一个，以为你多威风呢……", "40182");
    giSetPortrait("101C", true);
    giTalk("云天河：什么？", "40183");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：没、没有啦，我是说这个山洞够古怪的，居然会有这种东西。", "40184");
    giSetObjectVisible("MO003", false);
    giSetObjectVisible("Jeffect006", true);
    giSetObjectVisible("MO006", true);
    giPlayerSetDir(0, 278.0, false);
    giWait(0.5);
    giSetPortrait("101D", true);
    giTalk("云天河：……", "40185");
    giSetPortrait("103F", false);
    giTalk("韩菱纱：喂，怎么了？好歹刚才那么威风，现在又变呆呆的，不会是吓傻了吧？", "40186");
    giPlayerSetDir(1, 272.0, false);
    giCameraRunSingle("005", true);
    giWait(0.7);
    giPlayerDoAction(1, "J02", 1, false);
    giSetPortrait("103D", false);
    giTalk("韩菱纱：<colour red=255 green=187 blue=0 alpha=255>……是密室？！</colour>", "40187");
    giSetPortrait("103D", false);
    giTalk("韩菱纱：这地上的……好像是……道家的符咒！这么说来，刚才那个是用法力驱使的符灵？！", "40188");
    giPlayerEndAction(1);
    giPlayerDoAction(1, "J16", 1, false);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：太好了！我就知道剑仙的传说果然是真的！", "40189");
    giPlayerSetDir(0, 320.0, false);
    giCameraRunSingle("004", true);
    giWait(0.3);
    giSetPortrait("101C", true);
    giTalk("云天河：剑……仙？", "40190");
    giPlayerSetDir(1, 143.0, false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：是啊，就是仙人嘛，会很多法术，飞来飞去的那种～", "40191");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：你爹说不定也是剑仙的有缘之人，他不许别人进这个山洞，想必是担心泄露了剑仙的行踪吧？", "40192");
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：……这我不知道，爹可没交代过。", "40193");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：哎～一问三不知，真没劲！可我瞧你那支古怪的剑，也许就是剑仙之物呢。", "40194");
    giSetPortrait("101C", true);
    giTalk("云天河：你怎么知道？连我爹都没交代过。", "40195");
    giCameraRunSingle("006", true);
    giWait(0.5);
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：嘻嘻，傻瓜，不然刚才那些符灵干嘛怕它？", "40196");
    giSetPortrait("103M", true);
    giTalk("韩菱纱：再说一般的剑长不过三尺左右，这把剑却超出许多，最怪异的是，剑柄和剑身之间没有剑格，要怎么握啊？江湖规矩，文剑挂剑穗，武剑不挂，要说你这把剑是“武剑”，偏又不像……", "40197");
    giSetPortrait("101C", false);
    giTalk("云天河：剑不是只分用来砍的和用来射的吗？", "40198");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：大～错～特～错！除了你这种山顶野人，谁会把剑拿来射！", "40199");
    giPlayerEndAction(1);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：寻常剑以铁铜打造，再好一点也不过是乌金、玄铁，你这把倒是非金非玉，看不出质地。", "40200");
    giSetPortrait("101E", false);
    giTalk("云天河：那个……用来砍的剑不是用木头做的吗？", "40201");
    giSetPortrait("103B", true);
    giTalk("韩菱纱：不一样不一样，那只是小孩子耍着玩的。", "40202");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：对了，这把剑叫什么名字啊？", "40203");
    giCameraRunSingle("004", true);
    giWait(0.3);
    giSetPortrait("101A", true);
    giTalk("云天河：哦，这我爹交代过～这是剑！", "40204");
    giSetPortrait("103A", false);
    giTalk("韩菱纱：你耍我呢？我也知道这是剑，我问它有没有名字。", "40205");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101A", true);
    giTalk("云天河：我说了，它的名字就叫“这是剑”。", "40206");
    giPlayerEndAction(1);
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：嘻嘻，怎么可能～我看这把剑即便不是神兵，也算利器，哪会取这种蠢名字？", "40207");
    giSetPortrait("101J", true);
    giTalk("云天河：名字是爹亲口说的。", "40208");
    giSetPortrait("101J", true);
    giTalk("云天河：有一回我问他，既然木头做的剑叫“木剑”，那这把蓝色的剑又叫什么。", "40209");
    giSetPortrait("101J", true);
    giTalk("云天河：爹那天心情好像不怎么好，脸上都不笑，就说名字有什么重要，今天你叫“云天河”，明天也可以改叫“云阿三”，但你还是你。剑也一样，你喜欢取什么名字都行，嫌麻烦就干脆叫“这是剑”，又简单又好记。", "40210");
    giSetPortrait("103D", false);
    giTalk("韩菱纱：…………", "40211");
    giPlayerDoAction(1, "C08", 1, false);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：哈、哈哈～你爹真有意思！", "40212");
    giPlayerEndAction(1);
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101H", true);
    giTalk("云天河：不对，他是厉害，我打赢了山里那只吊睛白老虎，也还是打不赢他！", "40213");
    giPlayerEndAction(0);
    giCameraRunSingle("006", true);
    giWait(0.3);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：（……又在说傻话了……）", "40214");
    giPlayerDoAction(1, "J14", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：好好好，你说得都对，如果他这么厉害，说不定真的认识剑仙，这个山洞里也有大秘密。", "40215");
    giPlayerEndAction(1);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：喂，我们来都来了，入了宝山哪有空手而回的？嘻嘻，走啦～", "40216");
    giWait(1.0);
    giCameraRunSingle("007", false);
    giPlayerRunTo(1, -543.0, -124.0, -1124.0, false);
    giPlayerSetDir(0, 265.0, false);
    giPlayerEndMove(1);
    giPlayerSetVisible(1, false);
    giPlayerDoAction(0, "C07", -1, false);
    giSetPortrait("101H", false);
    giTalk("云天河：等一下，你不能乱闯！", "40217");
    giWait(0.5);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giCameraWait();
    giCameraRunSingle("008", false);
    giWait(4.0);
    giFlashOutBlack(1.5, true, true);
    giCameraRunSingle("009", true);
    giPlayerOutTeam(1, false);
    giIMMBegin();
    global_mvar = 11100; // 0x00002B5C, 序章 / 1-3-1.红衣少女 / 进密室查看
    giAddProperty(3101, 1, false);
    giDelProperty(3241, 1, false);
    giMonsterSetHide("m01-02-02", true);
    giShowSignpost();
    giSetNpcVisible("MN003", false);
    giSetObjectVisible("title01", true);
    giSetObjectVisible("Jeffect004", false);
    giSetObjectVisible("Jeffect007", false);
    giIMMEnd();
    giCameraSetMode(5, true);
    giCameraSeekToPlayer();
    giTimeScript(180.0, "func9001");
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func2005()
{
    giPlayerLock();
    giTimeScriptTerminate();
    giScriptMusicPlay("P35", 2, 0.0, 0.0);
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giIMMBegin();
    giPlayerCurrentSetPos(-4.0, 1.0, 461.0);
    giPlayerCurrentSetAng(173.0);
    giPlayerSetPos(1, -34.0, 48.0, -89.0);
    giPlayerSetAng(1, 148.0);
    giPlayerSetVisible(1, true);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("002", true);
    giFlashInBlack(2.0, false);
    giArenaReady();
    giPlayerWalkTo(0, 25.0, 4.0, 276.0, false);
    giPlayerEndMove(0);
    giPlayerSetDir(0, 184.0, true);
    giWait(0.8);
    giCameraRunSingle("003", false);
    giWait(4.0);
    giPlayerSetDir(1, 21.0, true);
    giCameraRunSingle("004", true);
    giWait(0.5);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：喂，快来看！这玉石好漂亮！像有光在里面流动一样。", "40218");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：不过呢，依我看修这个墓的人是个大大的外行，洞外就有瀑布河流，穴前去水可是大忌，俗话说“穴前水去不聚，则生气外泄”呢！", "40219");
    giPlayerEndAction(1);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：（最古怪的还是这些冰，和我以前在冰川古墓里见过的一样，硬得不得了……只可惜这回出门前没准备，那些宝贝也没带在身上，不然一定能把冰层破了……这棺材里肯定大有玄机……）", "40220");
    giCameraRunSingle("006", true);
    giWait(0.5);
    giPlayerRunTo(0, 23.0, 10.0, 75.0, true);
    giPlayerSetDir(0, 199.0, true);
    giWait(0.3);
    giPlayerDoAction(0, "J13", 1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：这里…………难道就是爹和娘的墓室？", "40221");
    giPlayerEndAction(0);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：好冷……整个山洞就这儿最冷，还莫名其妙结了这么厚的冰……", "40222");
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：对了，你刚才说什么？什么爹和娘？", "40223");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101C", false);
    giTalk("云天河：我爹说过，他死了以后要和我娘合葬在这里，他不想被打扰，连我也是第一次——", "40224");
    giPlayerDoAction(1, "J01", -1, false);
    giSetPortrait("103D", true);
    giTalk("韩菱纱：慢慢慢慢——慢！", "40225");
    giSetPortrait("103D", true);
    giTalk("韩菱纱：你、你说清楚！这是你爹娘的墓室？", "40226");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：嗯……", "40227");
    giPlayerEndAction(0);
    giWait(0.5);
    giCameraPrepare("MC002");
    giIMMBegin();
    giCameraRunSingle("001", false);
    giPlayerSetAng(1, 172.0);
    giIMMEnd();
    giWait(0.5);
    giSetPortrait("103D", true);
    giTalk("韩菱纱：那那那那——那么～这两副棺木里就是他们的尸骨？！", "40228");
    giSetPortrait("101A", false);
    giTalk("云天河：应该是吧……除非这个山洞里还有其他的墓室。", "40229");
    giWait(0.5);
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：咦？！你看，后面山壁上好像还有……字？", "40230");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：是用剑锋刻上去的！……", "40231");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giWait(0.3);
    giCameraRunSingle("002", false);
    giWait(0.8);
    giShowPoetry(0, true);
    giWait(1.7);
    giCameraPrepare("MC001");
    giCameraRunSingle("007", true);
    giWait(0.3);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：写的是……啥意思？", "40232");
    giPlayerEndAction(0);
    giPlayerSetDir(1, 21.0, true);
    giSetPortrait("103C", false);
    giTalk("韩菱纱：前面两句……说的是秦始皇、汉武帝求仙问道的事，后面两句嘛，我也不太明白……", "40233");
    giSetPortrait("101C", true);
    giTalk("云天河：秦始皇、汉武帝？又是什么人？", "40234");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103C", false);
    giTalk("韩菱纱：唔……真看不出你这样一个山顶野人，居然……", "40235");
    giSetPortrait("103C", false);
    giTalk("韩菱纱：你爹和你娘难道就是传说中的剑仙？", "40236");
    giPlayerEndAction(1);
    giSetPortrait("101C", true);
    giTalk("云天河：剑仙是什么？", "40237");
    giSetPortrait("103C", false);
    giTalk("韩菱纱：你、你再仔细想想，你爹真的没有说起过“剑仙”之类的话吗？", "40238");
    giPlayerDoAction(0, "C09", 1, true);
    giSetPortrait("101A", true);
    giTalk("云天河：爹只教我练剑，说长大以后不至于受人欺负。", "40239");
    giCameraPrepare("MC002");
    giCameraRunSingle("001", true);
    giWait(0.3);
    giPlayerDoAction(1, "J04", 1, false);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：（……你这一身蛮力，像个野人，又学了剑术，不欺负别人已经是万幸了……）", "40240");
    giPlayerEndAction(1);
    giPlayerWalkTo(1, -24.0, 38.0, 7.0, true);
    giPlayerSetDir(1, 30.0, true);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：方才看你使剑，不像懂得以气御剑，真正的剑仙都可御剑而飞，瞬息千里，寻常人一辈子也做不到这样的事。", "40241");
    giSetPortrait("101D", false);
    giTalk("云天河：以气御剑？", "40242");
    giSetPortrait("101A", false);
    giTalk("云天河：这个爹说过的，他说那是很难达到的境界，还不如学点强身的剑术杀杀野猪来得实在，至少不会饿肚子。", "40243");
    giSetPortrait("103E", true);
    giTalk("韩菱纱：（……高人的行事当真古怪。） ", "40244");
    giPlayerDoAction(1, "J04", 1, false);
    giSetPortrait("103J", true);
    giTalk("韩菱纱：哎～用膝盖想都知道，你肯定也不明白仙术是什么，不过资质倒是很好。我刚才念的那些咒法也是从一本古书上看来的，没修炼多久，要不是为了打那些符灵，才不会告诉你呢！", "40245");
    giSetPortrait("101E", false);
    giTalk("云天河：我又不想知道，听你那样念，我胡乱想一通，手脚都不受控制了。", "40246");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103J", true);
    giTalk("韩菱纱：你这大呆子，天底下多少人做梦都想学的五灵仙术，被你讲成这样，少得了便宜卖乖～", "40247");
    giPlayerEndAction(1);
    giSetPortrait("101E", false);
    giTalk("云天河：哦。", "40248");
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103J", true);
    giTalk("韩菱纱：什么“哦”，你装傻啊？一副有听没懂的样子……", "40249");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giWait(0.5);
    giIMMBegin();
    giCameraRunSingle("003", false);
    giPlayerSetAng(1, 41.0);
    giPlayerSetAng(0, 198.0);
    giIMMEnd();
    giWait(0.5);
    giSetPortrait("101E", false);
    giTalk("云天河：我是没太懂……", "40250");
    giSetPortrait("103M", true);
    giTalk("韩菱纱：喂，我把我知道的都告诉你了，换你说说剑仙前辈的事了！", "40251");
    giSetPortrait("101C", false);
    giTalk("云天河：剑仙……前辈？", "40252");
    giPlayerDoAction(1, "J14", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：就是你爹和你娘嘛。", "40253");
    giPlayerEndAction(1);
    giSetPortrait("101A", false);
    giTalk("云天河：哦……", "40254");
    giSetPortrait("101J", false);
    giTalk("云天河：我没见过我娘，听爹说，她生下我之后没多久就死了，她是世上最好的人。", "40255");
    giSetPortrait("103A", true);
    giTalk("韩菱纱：……那你爹真有福气。", "40256");
    giSetPortrait("101J", false);
    giTalk("云天河：爹经常咳嗽，咳出来都是血——", "40257");
    giPlayerDoAction(1, "J02", -1, false);
    giSetPortrait("103D", true);
    giTalk("韩菱纱：啊！！这么重的病？！", "40258");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101J", false);
    giTalk("云天河：爹他总是待在屋子里，很少出来，他怕冷。", "40259");
    giSetPortrait("103E", true);
    giTalk("韩菱纱：……也许、也许我弄错了，剑仙怎么还会生病……", "40260");
    giSetPortrait("101H", false);
    giTalk("云天河：那个……你、我们快些离开吧，不然爹要生气了。", "40261");
    giIMMBegin();
    giCameraRunSingle("004", false);
    giPlayerSetAng(0, 199.0);
    giPlayerSetAng(1, 30.0);
    giIMMEnd();
    giWait(0.5);
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：嘻～什么这个那个，我又不是没名字，叫我“菱纱”就好了。", "40262");
    giPlayerEndAction(1);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101F", false);
    giTalk("云天河：哦，菱、菱纱。", "40263");
    giPlayerEndAction(0);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：嘻嘻，不是菱菱纱，是菱纱～傻瓜！", "40264");
    giSetPortrait("103M", true);
    giTalk("韩菱纱：我们先出去吧，在这儿人都要冻成冰了！", "40265");
    giSetPortrait("101C", false);
    giTalk("云天河：咦？！", "40266");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：怎么了？", "40267");
    giWait(0.5);
    giGOBAttachToPlayer("MO003", "H_080", 0, true);
    giPlayerDoAction(0, "J09", -1, false);
    giWait(1.0);
    giCameraRunSingle("006", true);
    giWait(1.0);
    giSetPortrait("103D", true);
    giTalk("韩菱纱：呀！这把剑怎么回事？", "40268");
    giSetPortrait("101D", false);
    giTalk("云天河：我也不知道！它突然就变这样了！", "40269");
    giWait(0.7);
    giCameraRunSingle("007", false);
    giWait(4.3);
    giFlashOutBlack(1.5, true, true);
    giGOBDetachFromPlayer(0);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetVisible(1, false);
    giScriptMusicPause();
    giPlayMovie("1L.bik");
    giOpenMovieFlag(1);
    giScriptMusicResume();
    giArenaLoad("M01", "3", "", true);
    giPlayerLock();
    giCameraSetCollide(false);
    giPlayerCurrentSetPos(-367.0, -124.0, -1120.0);
    giPlayerCurrentSetAng(255.0);
    giPlayerSetPos(1, -272.0, -124.0, -1172.0);
    giPlayerSetAng(1, 302.0);
    giPlayerSetVisible(1, true);
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giArenaReady();
    giPlayerDoAction(0, "Z11", 0, false);
    giPlayerDoAction(1, "J19", -1, false);
    giSetObjectVisible("Jeffect006", false);
    giIMMBegin();
    giSetObjectVisible("Jeffect001", true);
    giSetObjectVisible("Jeffect002", true);
    giSetObjectVisible("Jeffect003", true);
    giIMMEnd();
    giFlashInBlack(2.0, true);
    giSetPortrait("101E", false);
    giTalk("云天河：……咳、咳咳……", "40270");
    giPlayerEndAction(0);
    giWait(0.8);
    giPlayerDoAction(0, "J30", -1, false);
    giSetPortrait("101D", false);
    giTalk("云天河：不～是～吧——！！", "40271");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：……唔，好痛…………", "40272");
    giCameraRunSingle("002", false);
    giSetPortrait("101H", false);
    giTalk("云天河：爹和娘的墓室被我一剑毁了！！", "40273");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：……脚好像被石头砸到了……", "40274");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：你帮我一下好不好？", "40275");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J15", 0, false);
    giSetPortrait("101H", false);
    giTalk("云天河：我把爹和娘的墓室毁了…………！！", "40276");
    giWait(0.5);
    giCameraWait();
    giCameraRunSingle("002", true);
    giWait(0.3);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：……喂………你先冷静一下……", "40277");
    giSetPortrait("101H", false);
    giTalk("云天河：怎么办怎么办怎么办啊…………", "40278");
    giSetPortrait("103F", false);
    giTalk("韩菱纱：我说……能不能先静一静？", "40279");
    giSetPortrait("101H", false);
    giTalk("云天河：惨了惨了惨了……", "40280");
    giWait(0.5);
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("103I", false);
    giTalk("韩菱纱：可恶……", "40281");
    giPlayerDoAction(1, "Z09", 1, false);
    giWait(0.3);
    gi2DSoundPlay("WJ043", 1);
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J21", 1, false);
    giSetPortrait("101E", true);
    giTalk("云天河：……好痛啊……", "40282");
    giWait(0.5);
    giIMMBegin();
    giCameraRunSingle("004", false);
    giPlayerSetAng(0, 113.0);
    giIMMEnd();
    giWait(0.5);
    giPlayerWalkTo(1, -317.0, -124.0, -1149.0, true);
    giPlayerSetDir(1, 302.0, true);
    giSetPortrait("103I", false);
    giTalk("韩菱纱：我都说了，让你冷静一下！", "40283");
    giPlayerDoAction(1, "J05", 1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：这样大吼大叫也没用，这事情我也有错，要不是我闯进这个山洞，说不定……说不定什么都不会发生了……如果你怕被爹娘责骂，最多我帮你担一份好了！", "40284");
    giPlayerEndAction(1);
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101H", true);
    giTalk("云天河：那怎么行？我爹说不可以骂女孩子。", "40285");
    giPlayerEndAction(0);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：那更好了，你爹要是不忍心骂我，说不定对你也只随便说上两句。", "40286");
    giPlayerDoAction(0, "J04", 1, false);
    giSetPortrait("101H", true);
    giTalk("云天河：……不可能，你不知道他发起脾气来…………", "40287");
    giPlayerEndAction(0);
    giCameraRunSingle("005", true);
    giWait(0.5);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：那我们把石头搬开，找找你爹娘的尸骨！", "40288");
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101E", true);
    giTalk("云天河：……还是不要了。", "40289");
    giSetPortrait("101E", true);
    giTalk("云天河：这么大的石头压下来，里面不晓得变成什么样，如果再进去打扰，爹肯定打死我，我还是等他出现骂我好了。", "40290");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（这……算什么歪理啊？野人和一般人想的就是不同……）", "40291");
    giSetPortrait("101D", true);
    giTalk("云天河：啊，菱纱，你刚才有没有受伤？", "40292");
    giPlayerDoAction(1, "J17", -1, false);
    giSetPortrait("103G", false);
    giTalk("韩菱纱：哼～总算想到我了？喊你又不理，到现在才问，我的伤早好了！", "40293");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101A", true);
    giTalk("云天河：伤能好这么快？那肯定是小伤～", "40294");
    giPlayerEndAction(0);
    giWait(0.5);
    giPlayerSetDir(0, 251.0, false);
    giWait(0.3);
    giSetPortrait("101G", false);
    giTalk("云天河：唉……", "40295");
    giSetPortrait("103F", false);
    giTalk("韩菱纱：你！……", "40296");
    giPlayerDoAction(1, "J15", -1, false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（傻瓜傻瓜傻瓜！连气话都听不出来，就不会再多问一句吗？）", "40297");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101G", false);
    giTalk("云天河：……怎么办呀？爹和娘的墓室……", "40298");
    giPlayerEndAction(0);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（算了，他够可怜的，说起来我也有错……）", "40299");
    giSetPortrait("103A", false);
    giTalk("韩菱纱：喂，那接下来怎么办？", "40300");
    giPlayerSetDir(0, 117.0, true);
    giWait(0.3);
    giSetPortrait("101J", true);
    giTalk("云天河：……你把东西给我先。", "40301");
    giPlayerDoAction(1, "J02", -1, false);
    giSetPortrait("103D", false);
    giTalk("韩菱纱：什么东西啊～莫名其妙。", "40302");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101J", true);
    giTalk("云天河：墓室里的那块石头，你不是拿出来了吗？我要挖个坑把它埋了，陪着爹娘。", "40303");
    giSetPortrait("103D", false);
    giTalk("韩菱纱：你、你哪只眼睛看见我拿，逃出来的时候谁还顾的上那个。", "40304");
    giPlayerDoAction(0, "C07", -1, false);
    giSetPortrait("101J", true);
    giTalk("云天河：我不可能看错，你要再不拿出来，就算男女授受不亲，我也要自己找啰！", "40305");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：…………哼，怕了你了，给你就是！……反正还有你没看见的……", "40306");
    giSetPortrait("101C", true);
    giTalk("云天河：什么？", "40307");
    giPlayerDoAction(1, "C07", -1, false);
    giWait(0.8);
    giSetObjectVisible("MO001", true);
    giWait(0.3);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：没……我说这是上好的古玉，才不是什么石头，你真不识货！", "40308");
    giWait(0.3);
    giSetObjectVisible("MO001", false);
    giWait(0.3);
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerWalkTo(0, -476.0, -124.0, -1077.0, false);
    giCameraRunSingle("004", false);
    giPlayerEndMove(0);
    giPlayerSetDir(0, 226.0, true);
    giPlayerDoAction(0, "J03", -1, true);
    giSetPortrait("103D", false);
    giTalk("韩菱纱：你不会真要埋了吧？", "40309");
    giSetPortrait("101C", true);
    giTalk("云天河：是啊。", "40310");
    giSetPortrait("101H", true);
    giTalk("云天河：哼！我每天都要换个地方埋，不能再让你找到，不信你试试！", "40311");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（谁要玩这种小孩子的游戏……幼稚……）", "40312");
    giSetPortrait("103C", false);
    giTalk("韩菱纱：（这块玉有点蹊跷，真被这野人埋了，线索就断了……）", "40313");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：喂，你说自己一直住山上，要不要跟我下山？", "40314");
    giSetPortrait("101C", true);
    giTalk("云天河：为什么？山上和山下都是一样过日子，又没不一样。", "40315");
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：傻瓜，当然大大的不一样！", "40316");
    giPlayerEndAction(1);
    giCameraRunSingle("006", true);
    giWait(0.3);
    giPlayerWalkTo(1, -402.0, -124.0, -1100.0, true);
    giPlayerSetDir(1, 294.0, true);
    giWait(0.3);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：我呢～从小立誓要寻遍天下的宝物和传说，山脚下有人告诉我，十几年前这附近出现过一男一女两位剑仙，扶危济困、仗义助人，所以我才不辞劳苦爬上这青鸾峰，想要拜见传说中的剑仙。", "40317");
    giSetPortrait("103B", false);
    giTalk("韩菱纱：最后剑仙没找着，倒遇上你这个什么都不懂的野人。", "40318");
    giSetPortrait("101A", true);
    giTalk("云天河：你说的那些我是不懂，懂了也没啥用啊。", "40319");
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：哎，和你说不清。不过你都没想过下山了解你爹娘的过去吗？", "40320");
    giPlayerEndAction(1);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetDir(0, 105.0, true);
    giWait(0.3);
    giCameraRunSingle("007", false);
    giSetPortrait("101A", true);
    giTalk("云天河：我爹和我娘……不就是这样了？", "40321");
    giPlayerDoAction(1, "J14", 1, false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：什么这样！你爹那么厉害就很不寻常了，更何况一般人过世，说穿就是挖个坑埋了，除非有权有势才弄得神神秘秘，你爹娘来历肯定不简单！", "40322");
    giPlayerEndAction(1);
    giSetPortrait("101D", true);
    giTalk("云天河：……是吗？", "40323");
    giSetPortrait("103B", false);
    giTalk("韩菱纱：听我的没错～你把剑和古玉带上，下山四处走走，说不定哪一天遇上你爹娘以前认识的人，就能知道他们过去的事了。", "40324");
    giSetPortrait("101C", true);
    giTalk("云天河：听起来不错，但是……", "40325");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：还但是？", "40326");
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：我先说好，我还要去找其他的宝物和传说，没那么多时间好耽搁，天黑以前肯定要下山。你爹要打要骂，我都毫无怨言，不过如果他天黑以后才出现，就剩你一个，我想帮也帮不成了。", "40327");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101E", true);
    giTalk("云天河：…………", "40328");
    giSetPortrait("103J", false);
    giTalk("韩菱纱：哎，你自己想清楚，你不是说你爹很凶吗？又说他很喜欢你娘？", "40329");
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101E", true);
    giTalk("云天河：是啊，这有什么好想的？", "40330");
    giPlayerEndAction(0);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：墓室里也有你娘，现在墓室毁了，你觉得你爹会不会因为你娘的缘故，比以前更凶呢？", "40331");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101H", true);
    giTalk("云天河：我……这个……你别……", "40332");
    giPlayerEndAction(0);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：真想像不到你爹会如何大发雷霆……", "40333");
    giSetPortrait("101H", true);
    giTalk("云天河：啊……", "40334");
    giSetPortrait("103J", false);
    giTalk("韩菱纱：人生气就很恐怖了，鬼生气那不就是更恐怖？", "40335");
    giSetPortrait("101D", true);
    giTalk("云天河：这……", "40336");
    giSetPortrait("103J", false);
    giTalk("韩菱纱：这附近虽说幽静，但山上的阴气也是很重的，我看瀑布旁那棵古树盘根错节，俗话说“木下有鬼”，阴寒至极……我真替你担心呀！", "40337");
    giSetPortrait("101D", true);
    giTalk("云天河：我……", "40338");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：哎，替你担心也没用，多保重吧，我下山去了。", "40339");
    giPlayerEndAction(1);
    giPlayerSetDir(1, 85.0, true);
    giWait(0.5);
    giPlayerDoAction(0, "C07", -1, false);
    giSetPortrait("101H", true);
    giTalk("云天河：你等一下！", "40340");
    giPlayerSetDir(1, 294.0, true);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：又怎么了？", "40341");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("101E", true);
    giTalk("云天河：……和你下山，真的能知道我爹和我娘过去的事吗？", "40342");
    giSetPortrait("103J", false);
    giTalk("韩菱纱：我也不知道，不过天大地大，巧合之事也是很多的，总比在山上机会大得多吧～", "40343");
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101H", true);
    giTalk("云天河：好吧，我和你一起走！<colour red=255 green=187 blue=0 alpha=255>我们现在就回去收拾东西！</colour>", "40344");
    giPlayerEndAction(0);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：咦？", "40345");
    giSetPortrait("101H", true);
    giTalk("云天河：快点！", "40346");
    giWait(0.3);
    giCameraRunSingle("009", false);
    giPlayerRunTo(0, -221.0, -125.0, -927.0, false);
    giWait(1.0);
    giPlayerSetDir(1, 45.0, true);
    giPlayerEndMove(0);
    giWait(0.7);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：（决定就决定了，用不着这么心急吧？还是怕他爹晚上找来？……哈哈！真是没见过更傻的人了。）", "40347");
    giWait(1.0);
    giAddProperty(3104, 1, true);
    giWait(2.5);
    giPlayerInTeam(1, true);
    giWait(2.5);
    giShowTutorial(18);
    giFlashOutBlack(1.5, true, true);
    giCameraRunSingle("010", true);
    giPlayerSetVisible(1, false);
    global_mvar = 11400; // 0x00002C88, 序章 / 1-3-2.红衣少女 / 回屋收拾
    giPlayerCurrentSetPos(130.0, -128.0, -948.0);
    giPlayerCurrentSetAng(58.0);
    giCameraSetMode(5, true);
    giCameraSeekToPlayer();
    giFlushTailYAngle();
    giTimeScript(180.0, "func9001");
    giIMMBegin();
    giAddPlayerFavor(0, 1, 20);
    giAddPlayerFavor(1, 0, 20);
    giSetObjectVisible("Jeffect001", false);
    giSetObjectVisible("Jeffect002", false);
    giSetObjectVisible("Jeffect003", false);
    giIMMEnd();
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func4001()
{
    giPlayerLock();
    giNpcPauseBeh("4001");
    giNpcFaceToCurrentPlayer("4001", true);
    giCurrentPlayerFaceToNpc("4001", true);
    giRandTalkRelease();
    giRandTalkPush("Cool-J：啥事儿，有事儿尽管说，说了也没啥，啥事儿这么难？");
    giRandTalkPush("Cool-J：仙剑四好玩哦，会有很多惊喜的，呵呵，不过要做好充分的准备，去尽情体验吧～！");
    giRandTalkPush("Cool-J：和你说句心里话，真的是心里话，写代码有没有感觉最重要的就是键盘。");
    giRandTalkPush("Cool-J：哟呵～来啦，即然来了就是客，这里位置不太多，看喜欢哪儿，找个地方休息一下吧。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4001");
    giNpcResumeBeh("4001");
    giPlayerUnLock();
}

void func4002()
{
    giPlayerLock();
    giNpcPauseBeh("4002");
    giNpcFaceToCurrentPlayer("4002", true);
    giCurrentPlayerFaceToNpc("4002", true);
    giRandTalkRelease();
    giRandTalkPush("凤梨罐头：如果你和我对话超过四句，我就会告诉你关于仙四游戏中的最大秘密。");
    giRandTalkPush("凤梨罐头：其实当主角比当路人甲好玩，可是企划大人不让我当主角，我只好跑来当路人甲了。");
    giRandTalkPush("凤梨罐头：其实当怪物也比当路人甲好玩，可是怪物又没有对白……");
    giRandTalkPush("凤梨罐头：好了，让我告诉你这个游戏的大秘密，那就是，如果你在游戏里和一个水滴状的NPC对话超过四句，他就会告诉你关于仙四游戏的最大秘密！");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("Baickl：告诉你个秘密，我有个绰号叫“电影男”。");
    giRandTalkPush("Baickl：如果你下次看到“血星之刃”的话，记得一定要还他5000G，都穷疯了。");
    giRandTalkPush("Baickl：用English和我说话，please！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4003");
    giNpcResumeBeh("4003");
    giPlayerUnLock();
}

void func4025()
{
    giPlayerLock();
    giNpcPauseBeh("4025");
    giNpcFaceToCurrentPlayer("4025", true);
    giCurrentPlayerFaceToNpc("4025", true);
    giTalk("异世界的lulu：这次也许是你赢了，但是，请记住，有朝一日踏上了我的地盘，爱吃月饼的谢夫洛德将再也不能帮你了，到那时……啊哈哈哈哈……", "");
    giNpcResetDir("4003");
    giNpcResumeBeh("4003");
    giPlayerUnLock();
}

void func4005()
{
    giPlayerLock();
    giNpcPauseBeh("4005");
    giNpcFaceToCurrentPlayer("4005", true);
    giCurrentPlayerFaceToNpc("4005", true);
    giRandTalkRelease();
    giRandTalkPush("工长君：仙四汇聚很多人两年间夜以继日的心血。上软只有六岁，光是追上大宇十九岁就很吃力，感谢正版用户的支持，但是上软不敢跟国外大作比较。");
    giRandTalkPush("工长君：为何不让楼儿出现？因为上软有希望继楼儿、景儿、煌儿之后，继续创作出更多让玩家喜爱的儿子女儿……甚至BOSS儿……子孙满堂！笑～");
    giRandTalkPush("工长君：与仙剑有许多缘分，阴差阳错接手制作后，看尽研发悲欢离合的沧桑变化。有一天我也会成为一名过客而离去，但这些年与仙剑的感情，不会忘却。");
    giRandTalkPush("工长君：仙剑，是一款百万玩家喜爱的游戏，我们应该用真心去灌溉，而非将利己之心放在首位，否则如何奢望玩家要为仙剑的故事而感动？");
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
    giRandTalkPush("叫我老K：我不叫“老K”，叫我的时候要叫全名“叫我老K”而不是“老K”。");
    giRandTalkPush("叫我老K：sky king cover ground tiger ^____^ ");
    giRandTalkPush("叫我老K：和某个人对话一百次也不会……");
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
    giRandTalkRelease();
    giRandTalkPush("某树：静静待在角落，思考一些永远不会去做的人设和剧情，那就像把人类鲜活的灵魂浸泡在虫尸化成的血水里，咕嘟嘟冒出泡泡～嗯，请称我为“死灵法师某树”～");
    giRandTalkPush("某树：某天，我经过监制大人的办公桌，看到一只很可爱的粉红猪，于是仙四序章的雏形就诞生鸟～ ");
    giRandTalkPush("某树：家有肥猫一只，未及弱冠，容姿端正，兼有Cosplay加菲猫之潜质，欲寻一知书达理、温柔婉约的母猫做未婚妻，有意者请托梦接洽它的主人——我。");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("御前带两把刀：尊重正版，抵制盗版，我们的成长需要您的支持！");
    giRandTalkPush("御前带两把刀：感谢家人和朋友们多年来的理解与支持，让我能够专心制作游戏。 ");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("Kaibi：花生～～西瓜～～可乐～～粽子～～好吃～～期待仙剑OL2～～");
    giRandTalkPush("Kaibi：要是一天能睡三十六小时该多好～～无限梦游中～～～ ");
    giRandTalkPush("Kaibi：最近得了BUG迷恋症，看到BUG就想去DE一下～～");
    giRandTalkPush("Kaibi：我是史上最大的BUG～～");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("冰块史莱姆：行走江湖历练人生，各地的小吃一定要尝尝。说起来好久没有吃烤肉了……");
    giRandTalkPush("冰块史莱姆：行走江湖历练人生，难免会遇到凶险，止血草、鼠儿果、无忧梦铃一定要常备。");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("赝月：刚才不小心烤焦了一份翅膀，结果它抗议我烤的烂，扑腾几下，自己飞走了……如果你看见一对冒着热气、香喷喷的焦翅膀，能不能回来告诉我？");
    giRandTalkPush("赝月：想做自己喜欢的事情总要付出代价，你愿意每天面对枯燥无聊的文档报表混吃等死，还是愿意带着满满的爱，每天面对帅帅的天河加班到深夜？ ");
    giRandTalkPush("赝月：思想的邪恶也好，内心的粉红也好，我都承认，但这些都不能阻止我对《仙剑奇侠传四》深深的爱！ ");
    giRandTalkPush("赝月：小天河、小紫英，人家都很喜欢嘛～为什么主管一定要人家选一个“最”喜欢捏～～～蹲到角落画圈圈…… ");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4011");
    giNpcResumeBeh("4011");
    giPlayerUnLock();
}

void func4012()
{
    giPlayerLock();
    giNpcPauseBeh("4012");
    giNpcFaceToCurrentPlayer("4012", true);
    giCurrentPlayerFaceToNpc("4012", true);
    giRandTalkRelease();
    giRandTalkPush("士东：其实菱纱初遇天河时没躲过那一剑，其实玄霄早就冻出了重感冒，其实秘室倒塌的时候，没有一颗水滴逃出来，其实一切的一切都是幻觉～");
    giRandTalkPush("士东：前两天我感觉头很痛，就晃了晃脑袋，结果倒出好多水来…… ");
    giRandTalkPush("士东：当我第一次看见冰块里面的玄霄，我就已经拜倒在霄蜀黍的天蚕睡袍之下！ ");
    giRandTalkPush("士东：你能给我点橘子味的果汁么？我自己是蓝莓味的…… ");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4012");
    giNpcResumeBeh("4012");
    giPlayerUnLock();
}

void func4013()
{
    giPlayerLock();
    giNpcPauseBeh("4013");
    giNpcFaceToCurrentPlayer("4013", true);
    giCurrentPlayerFaceToNpc("4013", true);
    giRandTalkRelease();
    giRandTalkPush("阿洽洽：这个洞太小，所以这次他们不让我把坦克开进来，呜呜呜……T^T");
    giRandTalkPush("阿洽洽：这阵子一直和美术讨论仙术、特技的表现，最后效果比想象中要好得多呢！希望你喜欢。");
    giRandTalkPush("阿洽洽：想买Wii、想买PSP、想买macbook……但最后都想想而已，嗯！这就叫“有欲无求”？");
    giRandTalkPush("阿洽洽：身边结婚的朋友越来越多，甚至有些都有小孩了。聚会中也开始讨论“爸妈经”，还真让人无法适应。 ");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4013");
    giNpcResumeBeh("4013");
    giPlayerUnLock();
}

void func4015()
{
    giPlayerLock();
    giNpcPauseBeh("4015");
    giNpcFaceToCurrentPlayer("4015", true);
    giCurrentPlayerFaceToNpc("4015", true);
    giRandTalkRelease();
    giRandTalkPush("某云天：（唱）我不是云天河，我不会武功，我只要小纱纱，完美的爱情。");
    giRandTalkPush("某云天：（唱）看见猪妖，我不怕不怕啦～想起小纱纱，我不怕不怕不怕啦～梦璃最美，我每天看得见，可爱还属璇玑妹妹～");
    giRandTalkPush("某云天： 都说我“花心”，其实是我“很花心思”而已～");
    giRandTalkPush("某云天： 现实里何尝没有“菱纱、梦璃”呢？我就认识这么一个女孩……嗯嗯，想要电话号码吗？");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("笑犬：……企鹅……企鹅到底是白底黑边的鸟，还是黑底白肚子的鸟？");
    giRandTalkPush("笑犬：………………我常常在想，嘴炮，到底是嘴上有炮，还是炮上长嘴？？？");
    giRandTalkPush("笑犬：…………如果我们的精神真的能透过游戏传达给你……");
    giRandTalkPush("笑犬：……盗版的，这句送你……众人皆醒汝独昏，人皆食毂君食屎。");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("基将军：“同一个仙剑，同一个梦想”，听起来是不是有点耳熟呢？呵呵，重在参与嘛～");
    giRandTalkPush("基将军：从前有只家猪，喜欢爬山，爬着爬着突然有一天就变成山猪了。");
    giRandTalkPush("基将军：你是风儿我是沙，他是天河我是菱纱；说起来我也长得不差，为什么你每次跑迷宫都用天河那个呆瓜……");
    giRandTalkPush("基将军：适度游戏益脑，沉迷游戏伤身～注意劳逸结合:）");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkPush("胃妖：话说某树家那只大脸猫，不知怎么喂养的，一个月可以长出一斤肉，现在已经是十一斤重的“小”猫了……而且居然还长出了狸猫的大尾巴！");
    giRandTalkPush("胃妖：嘿嘿～～我买了好多猫罐头，改天把某树家的胖猫骗出来，翻它个肚皮朝天！……你是谁，不要偷听别人说话，也不要妄想阻止我！");
    giRandTalkPush("胃妖：我虽然叫“胃妖”，但吃的一点也不多，真的，真的，真的！绝对没有骗人！！");
    giRandTalkPush("胃妖：我们家的饭很好吃哦，真是又高兴又苦恼——吃习惯家里的饭，外面的就吃不下了，怎么办……家里要是不高兴做给我吃了………………千万不要呀！");
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
    giRandTalkRelease();
    giRandTalkPush("巨云侠：看大侠一身行头，是打算踏上遥远的旅程吧，看来你已经闯过了不少劫难。不急的话，到是可以在此好好歇歇哦XD～～～");
    giRandTalkPush("巨云侠：能在此地见到用剑如此之快的少侠，算是给我最大的安慰。其实用剑不需要力气，想斩也斩不下去，在下巨云到是很想和少侠一战。");
    giRandTalkPush("巨云侠：又在用语言思考了，鸟儿想飞却不飞，唉～～难得有这种清静，你在笑吗？等你看了结局一切就明白了～～");
    giRandTalkPush("巨云侠：我把每天的工作，像写日记一样记下来。会明白任何一件事都有去做的理由和意义，而没有意义或是不想做的事，好像变得越来越少去做，大侠也别耽搁太久啦，快点前去山的另一边吧，希望还能再相见。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4019");
    giNpcResumeBeh("4019");
    giPlayerUnLock();
}

void func4020()
{
    giPlayerLock();
    giNpcPauseBeh("4020");
    giNpcFaceToCurrentPlayer("4020", true);
    giCurrentPlayerFaceToNpc("4020", true);
    giRandTalkRelease();
    giRandTalkPush("阿德：告诉你个天机哦，其实在下就是那只可爱的小山猪的声优，我的目标就是把猪叫演绎到极致，OH，YEAH！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4020");
    giNpcResumeBeh("4020");
    giPlayerUnLock();
}

void func4021()
{
    giPlayerLock();
    giNpcPauseBeh("4021");
    giNpcFaceToCurrentPlayer("4021", true);
    giCurrentPlayerFaceToNpc("4021", true);
    giRandTalkRelease();
    giRandTalkPush("地瓜：只要你一转身，我就会给你丢个死死团的诅咒……囧囧囧……");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("Vampirefox：感谢您对《仙剑奇侠传四》的支持与厚爱！！！");
    giRandTalkPush("Vampirefox：警告！与我对话完毕5分钟后仙4盗版盘片将自动销毁，如有需要请在5分钟内存档并将盘片取出以免损坏您的光驱，谢谢合作！");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("寸身言：告诉你哦，我在八公山北边的海边小镇碰到一个小姑娘，好可爱哦！我正准备买花去看她，可惜现在加班没时间啊……等游戏出了，我一定买套正版送给她。");
    giRandTalkPush("寸身言：梦璃粉丝团，菱纱歌迷会现在招募粉丝中，报名请排队。报名条件必须会跳草裙舞。不会的跟我学，12，12，123……");
    giRandTalkPush("寸身言：这里太危险，你们还是快回去吧。被我们美术看到了，一定拿你们做模特。");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("豆腐：我爱的人名花有主，爱我的人不堪入目……");
    giRandTalkPush("豆腐：这年头要找个媳妇太难了，都说天上能掉老婆，那我怎么从来没捡到过……要是真能掉老婆下来，那最好掉个柳MM给我，哈哈哈！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4024");
    giNpcResumeBeh("4024");
    giPlayerUnLock();
}

void func4026()
{
    giPlayerLock();
    giNpcPauseBeh("4026");
    giNpcFaceToCurrentPlayer("4026", true);
    giCurrentPlayerFaceToNpc("4026", true);
    giRandTalkRelease();
    giRandTalkPush("天天猫：我们的灵魂在游戏中跳跃，我们的游戏是梦想之源。");
    giRandTalkPush("天天猫：玩家们欢笑而来，也将欢笑而去，只留下水中幻像，和存在者的证言。");
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
    giNpcFaceToCurrentPlayer("4027", true);
    giCurrentPlayerFaceToNpc("4027", true);
    giRandTalkRelease();
    giRandTalkPush("天堂我恨神：上天是公平的，得到一些的同时必然会失去另一些。至于是否值得，只有等经过时间的洗礼后才能得到答案。所以，做现在的自己想做的事才是王道！");
    giRandTalkPush("天堂我恨神：等游戏出来了，忙完了就去找个老婆，听说春天把老婆埋在地里，秋天就有一大堆老婆了。嘿嘿……");
    giRandTalkPush("天堂我恨神：好想吃地道的回锅肉啊！");
    giRandTalkPush("天堂我恨神：想知道我最大的爱好吗？那就是一觉睡到晌午，没人打扰。哈哈，人生一大乐趣啊！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4027");
    giNpcResumeBeh("4027");
    giPlayerUnLock();
}

void func4028()
{
    giPlayerLock();
    giNpcPauseBeh("4028");
    giNpcFaceToCurrentPlayer("4028", true);
    giCurrentPlayerFaceToNpc("4028", true);
    giRandTalkRelease();
    giRandTalkPush("伊维鲁：小仓抹茶意大利面一份，不加韭菜。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4028");
    giNpcResumeBeh("4028");
    giPlayerUnLock();
}

void func4029()
{
    giPlayerLock();
    giNpcPauseBeh("4029");
    giNpcFaceToCurrentPlayer("4029", true);
    giCurrentPlayerFaceToNpc("4029", true);
    giRandTalkRelease();
    giRandTalkPush("Niko：请支持正版，谢谢！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4029");
    giNpcResumeBeh("4029");
    giPlayerUnLock();
}

void func4030()
{
    int random_1_5 = 0;

    giPlayerLock();
    giNpcPauseBeh("4030");
    giNpcFaceToCurrentPlayer("4030", true);
    giCurrentPlayerFaceToNpc("4030", true);
    random_1_5 = giGetRandnum(1, 5);
    if (random_1_5 != 2)
    {
        giRandTalkRelease();
        giRandTalkPush("鲸鱼：咕噜咕噜……（吐泡泡）");
        giRandTalkPush("鲸鱼：其实我是汪汪旺旺财。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giTalk("鲸鱼：什么？你想知道我主人的大名？！！！", "");
        giTalk("鲸鱼：不说。", "");
    }
    giNpcResetDir("4029");
    giNpcResumeBeh("4029");
    giPlayerUnLock();
}

void func9001()
{
    string local_1 = "";
    int local_3 = 0;
    bool item202_visible = false;
    string local_5 = "";

    local_1 = "item";
    giIMMBegin();
    while (local_3 <= 99)
    {
        local_1 = "item";
        if (local_3 >= 10)
        {
            local_1 = "item" + "20" + "2";
        }
        else
        {
            local_1 = "item" + "20";
        }
        local_5 = "item" + "20" + "2";
        item202_visible = giGetVisibleObject("item" + "20" + "2");
        if (!giGetVisibleObject(local_5))
        {
            local_5 = "item" + "20" + "2";
            giGOBReset("item" + "20" + "2");
            local_5 = "item" + "20" + "2";
            giSetObjectVisible("item" + "20" + "2", true);
        }
        local_3 = local_3 + 1;
    }
    giIMMEnd();
}
