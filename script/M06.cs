// Structured PAL4 reconstruction for M06.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M06_1A_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_1B_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar == 30500 /* 北门出城 */)
    {
        giIMMBegin();
        giSetObjectVisible("MO001", true);
        giEventVolumeVisible("ev_M06_1_6", false);
        giIMMEnd();
        giArenaReadyRestore();
    }
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN004", false);
        giSetNpcVisible("MN005", false);
        giSetNpcVisible("MN006", false);
        giSetNpcVisible("MN007", false);
        giSetNpcVisible("MN009", false);
        giIMMEnd();
        giArenaReadyRestore();
    }
}

void M06_1C_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_1D_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_1E_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_2A_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar <= 30900 /* 第一章 / 2-5-3.女萝平妖 / 寻找菱纱 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("MN001", false);
        giArenaReadyRestore();
    }
}

void M06_2B_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_2C_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_2D_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_2E_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_3A_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_3B_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M06_4_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar < 31200 /* 第一章 / 2-5-5.女萝平妖 / 土灵遁地 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        if (global_mvar == 31200 /* 第一章 / 2-5-5.女萝平妖 / 土灵遁地 */)
        {
            giScriptMusicPlay("P25", 2, 0.0, 2.5);
        }
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN004", false);
        giSetNpcVisible("MN005", false);
        giIMMEnd();
        giArenaReadyRestore();
    }
}

void EarthBall()
{
    if (global_mvar != 31200 /* 第一章 / 2-5-5.女萝平妖 / 土灵遁地 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.0, true, true);
        if (!giBGMConfigIsInArea("1a"))
        {
            giArenaLoad("M06", "1", "1a", true);
        }
        giPlayerCurrentSetPos(217.0, 0.0, 787.0);
        giPlayerCurrentSetAng(145.0);
        giCameraSetMode(5, true);
        giFlashInBlack(1.0, true);
        giArenaReady();
        giPlayerUnLock();
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.0, true, true);
        giArenaLoad("M05", "1", "", true);
    }
}

void func1001()
{
    bool cover02_visible = false;

    cover02_visible = giGetVisibleObject("cover02");
    if (!giGetVisibleObject("cover02"))
    {
        giArenaLoad("M06", "1", "1B", true);
        giPlayerCurrentSetPos(174.36147, 0.436794, 811.1235);
        giPlayerCurrentSetAng(120.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1002()
{
    giArenaLoad("M06", "1", "1A", true);
    giPlayerCurrentSetPos(508.1233, 0.599998, -715.80615);
    giPlayerCurrentSetAng(30.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("M06", "2", "2A", true);
    giPlayerCurrentSetPos(247.86206, 0.670807, 7.766599);
    giPlayerCurrentSetAng(115.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("M06", "1", "1B", true);
    giPlayerCurrentSetPos(-353.6599, 0.599998, -640.20355);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("M06", "3", "3A", true);
    giPlayerCurrentSetPos(-300.44446, 0.299997, 465.84082);
    giPlayerCurrentSetAng(172.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("M06", "1", "1B", true);
    giPlayerCurrentSetPos(508.1233, 0.599998, -715.80615);
    giPlayerCurrentSetAng(30.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1007()
{
    bool cover02_visible = false;

    cover02_visible = giGetVisibleObject("cover02");
    if (!giGetVisibleObject("cover02"))
    {
        giArenaLoad("M06", "3", "3B", true);
        giPlayerCurrentSetPos(-300.44446, 0.299997, 465.84082);
        giPlayerCurrentSetAng(172.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1008()
{
    giArenaLoad("M06", "2", "2A", true);
    giPlayerCurrentSetPos(-954.0009, 0.700005, 720.65717);
    giPlayerCurrentSetAng(293.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1009()
{
    bool cover03_visible = false;

    cover03_visible = giGetVisibleObject("cover03");
    if (!giGetVisibleObject("cover03"))
    {
        giArenaLoad("M06", "2", "2B", true);
        giPlayerCurrentSetPos(247.86206, 0.670807, 7.766599);
        giPlayerCurrentSetAng(115.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1010()
{
    giArenaLoad("M06", "2", "2A", true);
    giPlayerCurrentSetPos(1058.8643, 0.700001, -715.4784);
    giPlayerCurrentSetAng(292.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("M06", "2", "2C", true);
    giPlayerCurrentSetPos(247.86206, 0.670807, 7.766599);
    giPlayerCurrentSetAng(115.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1012()
{
    giArenaLoad("M06", "2", "2B", true);
    giPlayerCurrentSetPos(-1037.9337, 0.699999, -666.37683);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1013()
{
    giArenaLoad("M06", "1", "1C", true);
    giPlayerCurrentSetPos(174.36147, 0.436794, 811.1235);
    giPlayerCurrentSetAng(120.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("M06", "2", "2B", true);
    giPlayerCurrentSetPos(962.2354, 0.700003, 721.397);
    giPlayerCurrentSetAng(91.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("M06", "1", "1D", true);
    giPlayerCurrentSetPos(174.36147, 0.436794, 811.1235);
    giPlayerCurrentSetAng(120.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("M06", "2", "2C", true);
    giPlayerCurrentSetPos(962.2354, 0.700003, 721.397);
    giPlayerCurrentSetAng(91.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1017()
{
    bool cover03_visible = false;

    cover03_visible = giGetVisibleObject("cover03");
    if (!giGetVisibleObject("cover03"))
    {
        giArenaLoad("M06", "2", "2D", true);
        giPlayerCurrentSetPos(247.86206, 0.670807, 7.766599);
        giPlayerCurrentSetAng(115.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1018()
{
    giArenaLoad("M06", "1", "1C", true);
    giPlayerCurrentSetPos(-353.6599, 0.599998, -640.20355);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1019()
{
    bool cover01_visible = false;

    cover01_visible = giGetVisibleObject("cover01");
    if (!giGetVisibleObject("cover01"))
    {
        giArenaLoad("M06", "1", "1E", true);
        giPlayerCurrentSetPos(174.36147, 0.436794, 811.1235);
        giPlayerCurrentSetAng(120.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1020()
{
    giArenaLoad("M06", "1", "1C", true);
    giPlayerCurrentSetPos(-113.90343, 0.599998, 5.573001);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1021()
{
    bool cover03_visible = false;

    cover03_visible = giGetVisibleObject("cover03");
    if (!giGetVisibleObject("cover03"))
    {
        giArenaLoad("M06", "2", "2E", true);
        giPlayerCurrentSetPos(247.86206, 0.670807, 7.766599);
        giPlayerCurrentSetAng(115.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1022()
{
    giArenaLoad("M06", "2", "2D", true);
    giPlayerCurrentSetPos(-1037.9337, 0.699999, -666.37683);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1023()
{
    bool cover03_visible = false;

    cover03_visible = giGetVisibleObject("cover03");
    if (!giGetVisibleObject("cover03"))
    {
        giArenaLoad("M06", "4", "", true);
        giPlayerCurrentSetPos(-254.32524, 0.199999, 762.3215);
        giPlayerCurrentSetAng(280.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1024()
{
    giArenaLoad("M06", "2", "2D", true);
    giPlayerCurrentSetPos(1058.8643, 0.700001, -715.4784);
    giPlayerCurrentSetAng(292.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1025()
{
    if (global_mvar != 31200 /* 第一章 / 2-5-5.女萝平妖 / 土灵遁地 */)
    {
        giArenaLoad("M05", "1", "", true);
        giPlayerCurrentSetPos(-2103.0, 701.0, -2676.0);
        giPlayerCurrentSetAng(11.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(1.5, true, true);
        giArenaLoad("M05", "1", "", true);
    }
}

void func2001()
{
    if (global_mvar == 30500 /* 北门出城 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giScriptMusicPlay("P56", 0, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giHideGASkillObject();
        giMonsterSetHide("m06-01-01", false);
        giMonsterSetHide("m06-01-02", false);
        giMonsterSetHide("m06-01-03", false);
        giMonsterSetHide("m06-02-02", false);
        giMonsterSetHide("m06-02-03", false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -124.5378, 0.5999, -40.6392);
        giPlayerSetAng(0, 334.0);
        giPlayerSetPos(2, -50.6045, 0.5999, -82.942);
        giPlayerSetAng(2, 347.0);
        giPlayerSetPos(1, -19.3944, 0.5999, -10.7059);
        giPlayerSetAng(1, 325.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giCameraRunSingle("002", true);
        giWait(0.30000001192092896);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：天呐，这是怎么回事？ ", "41223");
        giCameraRunSingle("003", true);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：看来有人先我们一步……", "41224");
        giCameraRunSingle("004", true);
        giWait(0.5);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：谁？这个人把妖怪都打倒了，那我们不就没事做了？", "41225");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(2, 301.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：我们只是来探查为何妖会忽然伤人，不一定是除妖。", "41226");
        giIMMBegin();
        giPlayerSetDir(0, 114.0, false);
        giPlayerSetDir(1, 213.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：这里的槐妖向来性情温和，应该是有什么缘由……", "41227");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("006", true);
        giPlayerSetAng(1, 249.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：怎样都好啦！就是别停在这里，我快吐了……", "41228");
        giIMMBegin();
        giPlayerSetDir(2, 20.0, false);
        giPlayerSetDir(0, 63.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giSetPortrait("101D", true);
        giTalk("云天河：吐？你早上吃太饱？", "41229");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：少废话！我是因为血腥味——咦？", "41230");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：慢着！天河！你的脚边有坑，小心别踩！！", "41231");
        giPlayerSetDir(2, 307.0, false);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J03", -1, true);
        giSetPortrait("101B", true);
        giTalk("云天河：你说这个啊，我刚才就看见了，手法不好，土都没盖整齐。", "41232");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：……倒是你站的地方，好像有个很大的坑哎，挖得比这好多了……", "41233");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(2, 20.0, true);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：哪有？我在上面站这么久也没事……", "41234");
        giPlayerDoAction(1, "C06_1", 1, false);
        giWait(0.800000011920929);
        gi2DSoundPlay("WF041", 1);
        giPlayerDoAction(1, "C06_1", 1, false);
        giWait(0.800000011920929);
        gi2DSoundPlay("WF041", 1);
        giWait(1.0);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：嘻～看吧，你弄错了。", "41235");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：嗯……还是小心为上。", "41236");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("005", false);
        giPlayerSetAng(2, 318.0);
        giIMMEnd();
        giWait(0.8999999761581421);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：云公子，我们继续往深处走吧。", "41237");
        giPlayerSetDir(0, 138.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：呵呵，好……", "41238");
        giPlayerEndAction(0);
        giSetObjectVisible("Jeffect001", true);
        giGOMTouch("Jeffect001");
        gi2DSoundPlay("WJ017", 1);
        giWait(0.5);
        gi2DSoundPlay("WJ018", 1);
        giSetObjectVisible("MO001", false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：呀——！！", "41239");
        giPlayerSetVisible(1, false);
        giIMMBegin();
        giPlayerSetDir(0, 66.0, false);
        giPlayerSetDir(2, 38.0, false);
        giIMMEnd();
        giWait(0.800000011920929);
        giCameraRunSingle("007", true);
        giSetPortrait("101D", true);
        giTalk("云天河：菱纱！", "41240");
        giPlayerEndAction(0);
        giPlayerRunTo(0, -75.0739, 0.5899, -29.0456, false);
        giPlayerWalkTo(2, -42.161, 0.5704, -70.7305, false);
        giPlayerEndMove(0);
        giPlayerDoAction(0, "J03", -1, false);
        giPlayerEndMove(2);
        giPlayerDoAction(2, "J03", -1, false);
        giCameraRunSingle("008", false);
        giWait(0.4000000059604645);
        giSetPortrait("101H", true);
        giTalk("云天河：喂～～～", "41241");
        giSetPortrait("101H", true);
        giTalk("云天河：菱～～～纱～～～", "41242");
        giSetPortrait("101H", true);
        giTalk("云天河：你～～听～～得～～见～～吗～～～", "41243");
        giWait(2.0);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101H", true);
        giTalk("云天河：…………早跟她说这是陷阱嘛……", "41244");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerSetDir(2, 328.0, true);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：云公子，我们快点去找菱纱吧！", "41245");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101I", true);
        giTalk("云天河：我要直接跳下去。", "41246");
        giPlayerEndAction(0);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：云公子不可！下面是什么样谁都不清楚。这女萝岩里太古怪，万一你也受伤，怎能救菱纱呢？", "41247");
        giPlayerSetDir(0, 133.0, true);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：越是心急，越是要冷静！", "41248");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101F", true);
        giTalk("云天河：……是、是，你说的对。", "41249");
        giSetPortrait("106D", false);
        giTalk("柳梦璃：……", "41250");
        giSetPortrait("106D", false);
        giTalk("柳梦璃：<colour red=255 green=187 blue=0 alpha=255>抓紧时间去下层吧！</colour>", "41251");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：好！", "41252");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giCameraWait();
        giIMMBegin();
        giPlayerOutTeam(1, false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-170.1943, 0.6, -18.9771);
        giPlayerCurrentSetAng(180.0);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giMonsterSetHide("m06-01-01", true);
        giMonsterSetHide("m06-01-02", true);
        giMonsterSetHide("m06-01-03", true);
        giMonsterSetHide("m06-02-02", true);
        giMonsterSetHide("m06-02-03", true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 30900; // 0x000078B4, 第一章 / 2-5-3.女萝平妖 / 寻找菱纱
        giEventVolumeVisible("ev_M06_1_6", true);
        giShowSignpost();
        giIMMEnd();
        giScriptMusicStop(0, 2.5);
        giSetObjectVisible("Jeffect001", false);
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 30900 /* 第一章 / 2-5-3.女萝平妖 / 寻找菱纱 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giFlashOutBlack(0.5, true, true);
        giIMMBegin();
        giHideGASkillObject();
        giMonsterStopPursuit();
        giMonsterSetHide("m06-03-03", false);
        giMonsterSetHide("m06-04-01", false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 674.203, 0.6976, 519.8544);
        giPlayerSetAng(0, 137.0);
        giPlayerSetPos(2, 619.0004, 0.6735, 459.4007);
        giPlayerSetAng(2, 132.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(2, true);
        giCameraPrepare("MC001");
        giIMMEnd();
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, true);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：啊！在那边！", "41253");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("002", false);
        giPlayerRunTo(0, 863.5235, 0.7, 313.8915, false);
        giWait(0.5);
        giPlayerWalkTo(2, 708.9287, 0.6968, 426.1135, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 170.0, true);
        giSetPortrait("101H", false);
        giTalk("云天河：菱纱！你怎么样？！ ", "41254");
        giPlayerEndMove(2);
        giCameraRunSingle("004", false);
        giWait(0.5);
        giPlayerDoAction(0, "J15", 1, false);
        giPlayerWalkTo(2, 805.542, 0.7, 291.7734, false);
        giSetPortrait("101H", false);
        giTalk("云天河：怎么办怎么办怎么办！菱纱她摔死了！！", "41255");
        giPlayerEndMove(2);
        giPlayerSetDir(2, 70.0, true);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：云公子别慌，她还有气息，应该只是昏过去了。", "41256");
        giSetPortrait("103H", true);
        giTalk("韩菱纱：…………好吵…………", "41257");
        giNpcSetAng("MN001", 328.0);
        giNpcDoAction("MN001", "C10", 0, false);
        giWait(0.6000000238418579);
        giPlayerSetDir(2, 126.0, false);
        giPlayerEndAction(0);
        giSetPortrait("101D", false);
        giTalk("云天河：菱纱？！", "41258");
        giCameraRunSingle("002", false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……你这山顶野人……少动不动就咒我……", "41259");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：（……可恶！想我通晓机关巧槛，竟然会中这种破破烂烂的陷阱，脸都丢光了！）", "41260");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：没摔死就好，没摔死就好，呵呵。", "41261");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：你受了伤，先别动。", "41262");
        giPlayerDoAction(2, "J12", 1, false);
        giEffectAttachToPlayer(2, "H_TL03.2", false);
        giWait(3.5);
        giEffectDetachFromPlayer(2);
        giSetObjectVisible("Jeffect001", true);
        giWait(1.5);
        giFlashOutWhite(1.3, true, true);
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giPlayerSetPos(0, 795.6358, 0.6976, 377.9718);
        giPlayerSetAng(0, 98.0);
        giPlayerSetPos(2, 830.8762, 0.6735, 303.1497);
        giPlayerSetAng(2, 39.0);
        giPlayerSetPos(1, 886.1092, 0.6735, 358.8576);
        giPlayerSetAng(1, 225.0);
        giPlayerSetVisible(1, true);
        giIMMEnd();
        giCameraRunSingle("003", false);
        giFlashInWhite(1.3, true);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：骨头一点都不痛了，头也不晕了？真厉害！", "41263");
        giSetObjectVisible("Jeffect001", false);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：这香只能暂缓疼痛，你还是得把伤药敷上。", "41264");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……嗯，谢啦！", "41265");
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(1, 33.0, true);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……弄得这么狼狈……真讨厌……", "41266");
        giPlayerEndAction(1);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：可恶可恶可恶！到底是哪个家伙挖的陷阱，管他是人是妖，姑娘我非把他揪出来狠狠教训不可！", "41267");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：菱、菱纱？你要不要先回柳波波家休息？你的伤不要紧吗？", "41268");
        giPlayerSetDir(1, 296.0, true);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：一～点～都～不～！", "41269");
        giSetPortrait("103K", false);
        giTalk("韩菱纱：我要报仇雪耻！要让那家伙吃到苦头！", "41270");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.4000000059604645);
        giPlayerWalkTo(1, 982.7849, 0.6735, 381.1713, false);
        giSetPortrait("103K", true);
        giTalk("韩菱纱：气死我了！衣服上弄得尽是泥巴！！", "41271");
        giPlayerEndMove(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：她是气泥巴的事？女孩子真怪，身上有泥巴也没什么嘛，猪都还在泥巴水里洗澡呢。", "41272");
        giPlayerEndAction(0);
        giPlayerSetDir(2, 342.0, true);
        giSetPortrait("106E", false);
        giTalk("柳梦璃：你……", "41273");
        giPlayerSetDir(0, 146.0, true);
        giWait(0.5);
        giSetPortrait("101C", true);
        giTalk("云天河：怎么了？", "41274");
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：……没什么……至少菱纱身体是无大碍了，云公子，我们也跟上吧。", "41275");
        giPlayerEndAction(2);
        giPlayerWalkTo(2, 982.7849, 0.6735, 381.1713, false);
        giWait(1.7000000476837158);
        giPlayerSetDir(0, 98.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：等等我。", "41276");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：我刚刚是不是说错什么话？怪怪的……猪是在泥巴水里洗澡啊！", "41277");
        giPlayerEndAction(0);
        giFlashOutBlack(1.5, true, true);
        giCameraWait();
        giIMMBegin();
        giPlayerInTeam(1, false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetVisible(true);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giMonsterSetHide("m06-03-03", true);
        giMonsterSetHide("m06-04-01", true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giShowSignpost();
        global_mvar = 31100; // 0x0000797C, 罪魁祸首
        giIMMEnd();
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2003()
{
    if (global_mvar == 31100 /* 罪魁祸首 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giScriptMusicPlay("P25", 2, 0.0, 2.5);
        giFlashOutBlack(0.5, true, true);
        giIMMBegin();
        giHideGASkillObject();
        giMonsterStopPursuit();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 13.9973, 0.2, -797.8786);
        giPlayerSetPos(2, -74.038, 0.2, -827.7754);
        giPlayerSetPos(1, -17.437, 0.2, -886.1347);
        giPlayerSetAng(0, 236.0);
        giPlayerSetAng(1, 306.0);
        giPlayerSetAng(2, 87.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetObjectVisible("save1", false);
        giCameraPrepare("MC001");
        giIMMEnd();
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：嗯……这附近……有离香草的味道……", "41278");
        giSetPortrait("106A", false);
        giTalk("柳梦璃：……这边，跟我来。", "41279");
        giPlayerWalkTo(2, -198.7988, 0.2, -800.4149, false);
        giWait(1.5);
        giCameraRunSingle("002", true);
        giPlayerEndMove(2);
        giIMMBegin();
        giPlayerSetPos(0, -462.0859, 0.2, -794.9539);
        giPlayerSetPos(1, -421.0013, 0.2, -786.3872);
        giPlayerSetPos(2, -577.3894, 0.2, -809.683);
        giIMMEnd();
        giPlayerWalkTo(2, -556.1386, 0.2, -719.1098, true);
        giSetPortrait("106E", false);
        giTalk("柳梦璃：…………", "41280");
        giCameraRunSingle("003", false);
        giWait(1.0);
        giPlayerWalkTo(0, -512.5063, 0.2, -667.3676, false);
        giSetPortrait("101C", false);
        giTalk("云天河：怎么了？ ", "41281");
        giPlayerEndMove(0);
        giSetPortrait("101D", false);
        giTalk("云天河：…………", "41282");
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵～～～", "41283");
        giPlayerWalkTo(1, -448.894, 0.2, -693.1386, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：奇怪，这里有猫？ ", "41284");
        giPlayerEndMove(1);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：哇～～～这是什么？", "41285");
        giCameraRunSingle("005", true);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：好小、好可爱～～", "41286");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(1, -499.0185, 0.2, -504.5848);
        giPlayerSetAng(1, 6.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：嘻～让我摸摸看。", "41287");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(1, "J03", -1, true);
        giNpcBackTo("MN001", -493.1699, 0.2, -409.5665, false);
        giSetPortrait("207B", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵！喵喵——！！", "41288");
        giNpcEndMove("MN001");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetPos(0, -447.162, 0.2, -528.7592);
        giPlayerSetAng(0, 297.0);
        giPlayerSetPos(2, -540.0602, 0.2, -585.2259);
        giPlayerSetAng(2, 23.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giCameraRunSingle("007", false);
        giSetPortrait("101C", false);
        giTalk("云天河：菱纱，它好像不喜欢你……", "41289");
        giPlayerSetDir(1, 121.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103G", true);
        giTalk("韩菱纱：多、多话！有本事换你试试！", "41290");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("008", true);
        giWait(0.30000001192092896);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……看样子，挖陷阱的人已经找到了。", "41291");
        giIMMBegin();
        giPlayerSetPos(0, -490.9751, 0.2, -531.8721);
        giPlayerSetAng(0, 297.0);
        giPlayerSetPos(1, -572.697, 0.2, -492.423);
        giPlayerSetAng(1, 51.0);
        giNpcSetAng("MN001", 219.0);
        giNpcSetAng("MN002", 198.0);
        giNpcSetAng("MN003", 210.0);
        giNpcSetAng("MN004", 211.0);
        giNpcSetAng("MN005", 211.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：谁？！在哪里？！", "41292");
        giCameraRunSingle("010", true);
        giCameraRunSingle("011", true);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(0, -468.249, 0.2, -506.6896);
        giPlayerSetAng(0, 280.0);
        giPlayerSetPos(1, -572.697, 0.2, -492.423);
        giPlayerSetAng(1, 150.0);
        giPlayerSetPos(2, -543.1449, 0.2, -538.0956);
        giPlayerSetAng(2, 321.0);
        giIMMEnd();
        giCameraRunSingle("012", true);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……梦璃，你的意思……是它们？！", "41293");
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.5);
        giPlayerSetDir(0, 335.0, true);
        giPlayerSetDir(1, 22.0, true);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：好哇！！我都还没发威，你们这些小猫竟敢害到我头上来了！", "41294");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：菱纱你别生气，它们很可怜……我能感觉到它们的痛苦……", "41295");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giCameraRunSingle("013", true);
        giSetPortrait("207B", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵喵——！", "41296");
        giSetPortrait("207B", false);
        giTalk("？？：坏人！爹和娘都被你们杀了！ ", "41297");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：什么？！", "41298");
        giIMMBegin();
        giPlayerSetPos(0, -465.8289, 0.2, -482.4792);
        giPlayerSetAng(0, 342.0);
        giPlayerSetPos(1, -551.3399, 0.2, -472.0055);
        giPlayerSetAng(1, 22.0);
        giPlayerSetPos(2, -507.6516, 0.2, -454.7909);
        giPlayerSetAng(2, 359.0);
        giNpcSetAng("MN001", 191.0);
        giNpcSetAng("MN002", 191.0);
        giNpcSetAng("MN003", 171.0);
        giNpcSetAng("MN004", 201.0);
        giNpcSetAng("MN005", 182.0);
        giCameraRunSingle("014", true);
        giIMMEnd();
        giCameraRunSingle("015", false);
        giPlayerDoAction(2, "J03", -1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：你好。请你别害怕，我们没有恶意的。你说爹娘被杀了，是怎么一回事？", "41299");
        giSetPortrait("207B", false);
        giTalk("？？：……", "41300");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：能跟我们说吗？我们真的没有恶意，你放心。", "41301");
        giSetPortrait("207B", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵喵！人都是坏蛋！我们要报仇！", "41302");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：所以你们才挖了陷阱？", "41303");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……那些倒在地上的妖怪，其中就有你们的爹娘吗……", "41304");
        giSetPortrait("208B", false);
        giTalk("？？：呜呜呜～～爹～～娘～～", "41305");
        giNpcSetDir("MN001", 6.0, true);
        giSetPortrait("207B", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵！不许哭！不要让人看笑话！", "41306");
        giSetPortrait("208B", false);
        giTalk("？？：呜……", "41307");
        giCameraRunSingle("016", true);
        giCameraRunSingle("017", false);
        giNpcSetDir("MN001", 191.0, true);
        giSetPortrait("207B", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵喵！你们人实在太坏了！突然闯进来把大家都杀死！", "41308");
        giSetPortrait("106F", false);
        giTalk("柳梦璃：你看到那个人长什么样了吗？", "41309");
        giSetPortrait("207B", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵！当然！他拿了一把长长的剑，我知道！就是你们人所说的剑仙！", "41310");
        giSetPortrait("207B", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵！我和其他几个兄弟年纪还小，妖气也弱，那个人没有察觉才离开的。", "41311");
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……妖侵犯人，人自然也要除妖。", "41312");
        giSetPortrait("106F", false);
        giTalk("柳梦璃：近日妖伤人之事，恐怕已经惊动了那些入世剑仙。", "41313");
        giSetPortrait("207B", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵喵！是人不对！人把离香草都采光了，槐妖没东西吃，爹和娘才说要吓吓他们，就咬死了几个人……", "41314");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：啊？！原来是这么回事！", "41315");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……你们……有地方可以去吗？如果有就快走吧，女萝岩里如今只剩下毒虫毒草，并非久留之地。", "41316");
        giSetPortrait("207A", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵！你、你不杀我们？", "41317");
        giSetPortrait("101C", false);
        giTalk("云天河：杀你们干嘛？", "41318");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetPos(0, -470.1788, 0.2, -501.0198);
        giPlayerSetAng(0, 342.0);
        giPlayerSetPos(1, -545.7854, 0.2, -483.1915);
        giPlayerSetAng(1, 106.0);
        giPlayerSetAng(2, 132.0);
        giCameraRunSingle("018", true);
        giIMMEnd();
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：反正你说的那些我也只听懂一半，不过妖杀了人，人要报仇，人杀了妖，妖也不罢休，这样打来打去，到哪一天也没结果。", "41319");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("106E", true);
        giTalk("柳梦璃：云公子……", "41320");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：天河……你真的是天河吗？！竟然说出这么有道理的话……", "41321");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(0, 287.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：呵呵，这都是我爹说的，他说人和人是这样因时果报，我想人和妖应该也差不多吧。", "41322");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……云叔说的没错。", "41323");
        giIMMBegin();
        giPlayerSetPos(0, -458.4852, 0.2, -492.1337);
        giPlayerSetAng(0, 339.0);
        giPlayerSetAng(1, 16.0);
        giPlayerSetAng(2, 354.0);
        giCameraRunSingle("019", true);
        giIMMEnd();
        giSetPortrait("106F", true);
        giTalk("柳梦璃：你们走吧，回去以后我会告诉城里的人，让他们采摘适度，绝不让你们没有了食物。", "41324");
        giSetPortrait("207A", false);
        giTalk("？？：…………", "41325");
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("？？：喵！我叫槐米，他们是我弟弟槐花、槐实、槐角、槐枝。", "41326");
        giSetPortrait("207B", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵！长大以后，我们还是要找到那个人，替爹娘他们报仇！不过……人也不全都是坏的，我记下了！", "41327");
        giNpcSetDir("MN001", 353.0, true);
        giSetPortrait("207B", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵～我们走！", "41328");
        giNpcWalkTo("MN003", -622.8589, 0.2, -385.509, false);
        giNpcWalkTo("MN005", -616.1751, 0.2, -414.198, false);
        giNpcWalkTo("MN002", -622.8589, 0.2, -385.509, false);
        giWait(0.699999988079071);
        giNpcWalkTo("MN004", -622.8589, 0.2, -385.509, false);
        giWait(0.20000000298023224);
        giNpcWalkTo("MN001", -616.1751, 0.2, -414.198, false);
        giWait(1.0);
        giCameraRunSingle("020", false);
        giIMMBegin();
        giPlayerSetDir(2, 307.0, false);
        giPlayerSetDir(1, 324.0, false);
        giPlayerSetDir(0, 310.0, false);
        giIMMEnd();
        giWait(1.0);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：真可怜……这么小就没有了爹娘，以后会过得很辛苦……", "41329");
        giWait(1.0);
        giCameraRunSingle("021", true);
        giSetPortrait("101J", false);
        giTalk("云天河：……", "41330");
        giPlayerDoAction(0, "J14", 1, true);
        giNpcEndMove("MN001");
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN004", false);
        giNpcSetPos("MN005", -629.452, 0.2, -375.2665);
        giSetNpcVisible("MN005", false);
        giIMMEnd();
        giIMMBegin();
        giPlayerSetPos(2, -498.9467, 0.2, -440.6294);
        giPlayerSetAng(2, 31.0);
        giPlayerSetAng(1, 100.0);
        giCameraRunSingle("022", true);
        giIMMEnd();
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：（这么说来，他不是也……）", "41331");
        giPlayerEndAction(1);
        giPlayerSetDir(1, 45.0, true);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……梦璃，被你这么一说，我气早消了，它们确实蛮可怜的……", "41332");
        giPlayerSetDir(2, 217.0, true);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：那个大哥很护着弟弟，一定会保护它们的。", "41333");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：嗯……", "41334");
        giWait(1.0);
        giSetNpcVisible("MN005", true);
        giNpcWalkTo("MN005", -557.2272, 0.2, -408.3789, false);
        giIMMBegin();
        giPlayerSetPos(0, -473.9334, 0.2, -483.537);
        giPlayerSetAng(0, 299.0);
        giPlayerSetPos(1, -543.045, 0.2, -486.5318);
        giPlayerSetAng(1, 335.0);
        giPlayerSetPos(2, -495.3805, 0.2, -431.5325);
        giPlayerSetAng(2, 281.0);
        giCameraRunSingle("023", true);
        giIMMEnd();
        giNpcEndMove("MN005");
        giNpcSetDir("MN005", 106.0, true);
        giSetPortrait("208A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐枝：喵～～老大自己不好意思来，他让我把这个送给你，这是我们唯一的宝贝。", "41335");
        giWait(0.699999988079071);
        giSetObjectVisible("MO005", true);
        giWait(0.699999988079071);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：送给我？", "41336");
        giSetPortrait("208A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐枝：喵～～老大说人有好坏，你是好人，对我们也很好，所以我们要感谢你。", "41337");
        giSetPortrait("208A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐枝：喵～喵喵～～", "41338");
        giWait(0.699999988079071);
        giNpcWalkTo("MN005", -630.2777, 0.2, -383.9816, true);
        giSetNpcVisible("MN005", false);
        giPlayerWalkTo(1, -545.7332, 0.2, -447.5001, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：宝贝？让我瞧瞧！", "41339");
        giPlayerEndMove(1);
        giPlayerDoAction(1, "J03", -1, false);
        giPlayerSetDir(2, 259.0, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：咦？这个……？真的假的？！这个好像是土灵珠耶！", "41340");
        giSetObjectVisible("MO005", false);
        giSetPortrait("101D", true);
        giTalk("云天河：土林猪？啥东西？不像猪啊……", "41341");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giAddProperty(3067, 1, true);
        giWait(2.5);
        giIMMBegin();
        giPlayerSetPos(0, -494.0971, 0.2, -488.4041);
        giPlayerSetAng(0, 309.0);
        giPlayerSetPos(1, -545.7332, 0.2, -447.5001);
        giPlayerSetAng(1, 125.0);
        giPlayerSetPos(2, -474.6733, 0.2, -437.1393);
        giPlayerSetAng(2, 259.0);
        giCameraRunSingle("024", true);
        giIMMEnd();
        giSetPortrait("103M", true);
        giTalk("韩菱纱：据说天地间一共有水、火、雷、风、土五颗灵珠，都是由灵气聚集而成，是了不起的好宝贝，韩家先祖曾经得到过雷灵珠，所以本家文献上有记载。", "41342");
        giSetPortrait("101C", false);
        giTalk("云天河：……跟什么菜有关？", "41343");
        giCameraRunSingle("025", false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：（就知道吃……刚刚说一番道理，还以为这野人稍微有点学问了！可气！）", "41344");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：传说嘛～五灵珠各有不同功效，若能集齐五颗，又是大大的不同了。", "41345");
        giSetPortrait("103B", true);
        giTalk("韩菱纱：我想想，<colour red=255 green=187 blue=0 alpha=255>土灵珠是……可以令人瞬息回到起始之地，</colour><dc0>嘻嘻，说不定用它就能马上从女萝岩出去呢！</dc0>", "41346");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：真是这样，确实会省掉不少脚程。", "41347");
        giPlayerSetDir(0, 2.0, false);
        giPlayerSetDir(1, 81.0, true);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：快！试试看不就知道了～", "41348");
        giPlayerSetDir(2, 303.0, true);
        giWait(0.5);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：谢谢你们。", "41349");
        giPlayerEndAction(2);
        giPlayerSetDir(2, 269.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：嗯，试试看土灵珠。", "41350");
        giPlayerEndAction(2);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("001", true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 31200; // 0x000079E0, 第一章 / 2-5-5.女萝平妖 / 土灵遁地
        giAddPlayerFavor(2, 0, 18);
        giAddPlayerFavor(2, 1, 18);
        giAddPlayerFavor(1, 0, 10);
        giSetObjectVisible("save1", true);
        giIMMEnd();
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func7001()
{
    giPlayerLock();
    giMonsterStopPursuit();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giCameraPrepare("viewFog");
    giCameraRunSingle("viewFog_1", false);
    giPlayerCurrentWalkTo(182.4689, 1.6, -107.9918, true);
    giPlayerCurrentFaceToGOB("light01_f", true);
    giPlayerCurrentDoAction("z03", 1, false);
    gi2DSoundPlay("WH028", 1);
    giWait(1.0);
    giPlayerCurrentEndAction();
    giOBJBlendOut("light01_f", 1.0, false);
    gi2DSoundPlay("WJ073", 1);
    giOBJBlendOut("light01", 1.0, false);
    giOBJBlendIn("fog", 0.5, true);
    giWait(2.5);
    giGOBMovment("fog", 2.0, 210.0529, 82.6001, -67.1512, false);
    giCameraPrepare("viewFog");
    giCameraRunSingle("viewFog_2", false);
    giWait(2.0);
    giGOBMovment("fog", 5.0, 316.042, 82.6001, -790.9402, false);
    giCameraRunSingle("viewFog_4", true);
    giCameraRunSingle("viewFog_5", false);
    giWait(2.799999952316284);
    giGOBMovment("fog", 2.0, 316.042, 0.6001, -790.9402, false);
    giCameraRunSingle("viewFog_6", false);
    giWait(2.299999952316284);
    giOBJBlendOut("fog", 1.0, false);
    giOBJBlendOut("cover02", 1.0, false);
    gi2DSoundPlay("WJ074", 1);
    giOBJBlendIn("Light_u2", 0.5, false);
    giWait(2.0);
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giPlayerUnLock();
}

void func7002()
{
    bool light1_f_visible = false;
    bool light2_f_visible = false;

    giPlayerLock();
    giMonsterStopPursuit();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giCameraPrepare("viewFog");
    giCameraRunSingle("viewFog_1", false);
    giPlayerCurrentWalkTo(-589.9863, 0.7, 314.5168, true);
    giPlayerCurrentFaceToGOB("light1_f", true);
    giPlayerCurrentDoAction("z03", 1, false);
    gi2DSoundPlay("WH028", 1);
    giWait(1.0);
    giPlayerCurrentEndAction();
    giOBJBlendOut("light1_f", 1.0, false);
    gi2DSoundPlay("WJ073", 1);
    giOBJBlendOut("light1", 1.0, false);
    giOBJBlendIn("fog", 0.5, true);
    giWait(2.5);
    giGOBMovment("fog", 3.0, -637.739, 90.3, 331.5772, false);
    giCameraRunSingle("viewFog_2", false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
    giOBJBlendOut("fog", 0.1, true);
    light1_f_visible = giGetVisibleObject("light1_f");
    light2_f_visible = giGetVisibleObject("light2_f");
    if (!giGetVisibleObject("light1_f") && !light2_f_visible)
    {
        func7004();
    }
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giFlashInBlack(1.0, true);
    giPlayerUnLock();
}

void func7003()
{
    bool light1_f_visible = false;
    bool light2_f_visible = false;

    giPlayerLock();
    giMonsterStopPursuit();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giCameraPrepare("viewFog2");
    giCameraRunSingle("viewFog2_1", false);
    giPlayerCurrentWalkTo(1425.6382, 0.7, -314.4163, true);
    giPlayerCurrentFaceToGOB("light2_f", true);
    giPlayerCurrentDoAction("z03", 1, false);
    gi2DSoundPlay("WH028", 1);
    giWait(1.0);
    giPlayerCurrentEndAction();
    giOBJBlendOut("light2_f", 1.0, false);
    gi2DSoundPlay("WJ073", 1);
    giOBJBlendOut("light2", 1.0, false);
    giOBJBlendIn("fog2", 0.5, true);
    giWait(2.5);
    giGOBMovment("fog2", 3.0, 1392.9803, 108.7, -363.0565, false);
    giCameraRunSingle("viewFog2_2", false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
    giOBJBlendOut("fog2", 0.1, true);
    light1_f_visible = giGetVisibleObject("light1_f");
    light2_f_visible = giGetVisibleObject("light2_f");
    if (!giGetVisibleObject("light1_f") && !light2_f_visible)
    {
        func7004();
    }
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giFlashInBlack(1.0, true);
    giPlayerUnLock();
}

void func7004()
{
    giCameraPrepare("viewHole");
    giCameraRunSingle("viewHole_1", false);
    giFlashInBlack(1.0, true);
    giOBJBlendOut("cover03", 1.0, false);
    gi2DSoundPlay("WJ074", 1);
    giOBJBlendIn("light03", 0.5, false);
    giWait(2.0);
    giCameraRunSingle("viewHole_2", false);
    giOBJBlendOut("cover02", 1.0, false);
    gi2DSoundPlay("WJ074", 1);
    giOBJBlendIn("light02", 0.5, false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
}

void func7005()
{
    bool light1_f_visible = false;
    bool light2_f_visible = false;

    giPlayerLock();
    giMonsterStopPursuit();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giCameraPrepare("viewFog_1c");
    giCameraRunSingle("viewFog_1c_1", false);
    giPlayerCurrentWalkTo(489.2066, 24.1939, 923.6324, true);
    giPlayerCurrentFaceToGOB("light1_f", true);
    giPlayerCurrentDoAction("z03", 1, false);
    gi2DSoundPlay("WH028", 1);
    giWait(1.0);
    giPlayerCurrentEndAction();
    giOBJBlendOut("light1_f", 1.0, false);
    gi2DSoundPlay("WJ073", 1);
    giOBJBlendOut("light1", 1.0, false);
    giOBJBlendIn("fog", 0.5, true);
    giWait(2.5);
    giGOBMovment("fog", 3.0, 514.5398, 95.927, 968.6722, false);
    giCameraRunSingle("viewFog_1c_2", false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
    giOBJBlendOut("fog", 0.1, true);
    light1_f_visible = giGetVisibleObject("light1_f");
    light2_f_visible = giGetVisibleObject("light2_f");
    if (!giGetVisibleObject("light1_f") && !light2_f_visible)
    {
        func7007();
    }
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giFlashInBlack(1.0, true);
    giPlayerUnLock();
}

void func7006()
{
    bool light1_f_visible = false;
    bool light2_f_visible = false;

    giPlayerLock();
    giMonsterStopPursuit();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giCameraPrepare("viewFog2_1c");
    giCameraRunSingle("viewFog2_1c_1", false);
    giPlayerCurrentWalkTo(282.1404, 0.6, -432.6674, true);
    giPlayerCurrentFaceToGOB("light2_f", true);
    giPlayerCurrentDoAction("z03", 1, false);
    gi2DSoundPlay("WH028", 1);
    giWait(1.0);
    giPlayerCurrentEndAction();
    giOBJBlendOut("light2_f", 1.0, false);
    gi2DSoundPlay("WJ073", 1);
    giOBJBlendOut("light2", 1.0, false);
    giOBJBlendIn("fog2", 0.5, true);
    giWait(2.5);
    giGOBMovment("fog2", 3.0, 235.5975, 96.4, -399.6233, false);
    giCameraRunSingle("viewFog2_1c_2", false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
    giOBJBlendOut("fog2", 0.1, true);
    light1_f_visible = giGetVisibleObject("light1_f");
    light2_f_visible = giGetVisibleObject("light2_f");
    if (!giGetVisibleObject("light1_f") && !light2_f_visible)
    {
        func7007();
    }
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giFlashInBlack(1.0, true);
    giPlayerUnLock();
}

void func7007()
{
    giCameraPrepare("viewHole_1c");
    giCameraRunSingle("viewHole_1c_1", false);
    giFlashInBlack(1.0, true);
    giOBJBlendOut("cover01", 1.0, false);
    gi2DSoundPlay("WJ074", 1);
    giOBJBlendIn("Light_u3", 0.5, false);
    giWait(2.0);
    giCameraRunSingle("viewHole_1c_2", false);
    giOBJBlendOut("cover03", 1.0, false);
    gi2DSoundPlay("WJ074", 1);
    giOBJBlendIn("Light_u1", 0.5, false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
}

void func7008()
{
    bool light1_f_visible = false;
    bool light2_f_visible = false;
    bool light3_f_visible = false;

    giPlayerLock();
    giMonsterStopPursuit();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giCameraPrepare("viewFog_2d");
    giCameraRunSingle("viewFog_2d_1", false);
    giPlayerCurrentWalkTo(-1255.3748, 0.7, -220.3617, true);
    giPlayerCurrentFaceToGOB("light1_f", true);
    giPlayerCurrentDoAction("z03", 1, false);
    gi2DSoundPlay("WH028", 1);
    giWait(1.0);
    giPlayerCurrentEndAction();
    giOBJBlendOut("light1_f", 1.0, false);
    gi2DSoundPlay("WJ073", 1);
    giOBJBlendOut("light1", 1.0, false);
    giOBJBlendIn("fog", 0.5, true);
    giWait(2.5);
    giGOBMovment("fog", 3.0, -1238.5453, 90.3, -276.1178, false);
    giCameraRunSingle("viewFog_2d_2", false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
    giOBJBlendOut("fog", 0.1, true);
    light1_f_visible = giGetVisibleObject("light1_f");
    light2_f_visible = giGetVisibleObject("light2_f");
    light3_f_visible = giGetVisibleObject("light3_f");
    if (!giGetVisibleObject("light1_f") && !light2_f_visible && !light3_f_visible)
    {
        func7011();
    }
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giFlashInBlack(1.0, true);
    giPlayerUnLock();
}

void func7009()
{
    bool light1_f_visible = false;
    bool light2_f_visible = false;
    bool light3_f_visible = false;

    giPlayerLock();
    giMonsterStopPursuit();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giCameraPrepare("viewFog2_2d");
    giCameraRunSingle("viewFog_2d_2_1", false);
    giPlayerCurrentWalkTo(-647.0472, 0.7, 269.0833, true);
    giPlayerCurrentFaceToGOB("light2_f", true);
    giPlayerCurrentDoAction("z03", 1, false);
    gi2DSoundPlay("WH028", 1);
    giWait(1.0);
    giPlayerCurrentEndAction();
    giOBJBlendOut("light2_f", 1.0, false);
    gi2DSoundPlay("WJ073", 1);
    giOBJBlendOut("light2", 1.0, false);
    giOBJBlendIn("fog2", 0.5, true);
    giWait(2.5);
    giGOBMovment("fog2", 3.0, -645.1269, 95.3, 329.7785, false);
    giCameraRunSingle("viewFog_2d_2_2", false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
    giOBJBlendOut("fog2", 0.1, true);
    light1_f_visible = giGetVisibleObject("light1_f");
    light2_f_visible = giGetVisibleObject("light2_f");
    light3_f_visible = giGetVisibleObject("light3_f");
    if (!giGetVisibleObject("light1_f") && !light2_f_visible && !light3_f_visible)
    {
        func7011();
    }
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giFlashInBlack(1.0, true);
    giPlayerUnLock();
}

void func7010()
{
    bool light1_f_visible = false;
    bool light2_f_visible = false;
    bool light3_f_visible = false;

    giPlayerLock();
    giMonsterStopPursuit();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giCameraPrepare("viewFog3_2d");
    giCameraRunSingle("viewFog_2d_3_1", false);
    giPlayerCurrentWalkTo(1278.2677, 0.7, 654.5809, true);
    giPlayerCurrentFaceToGOB("light3_f", true);
    giPlayerCurrentDoAction("z03", 1, false);
    gi2DSoundPlay("WH028", 1);
    giWait(1.0);
    giPlayerCurrentEndAction();
    giOBJBlendOut("light3_f", 1.0, false);
    gi2DSoundPlay("WJ073", 1);
    giOBJBlendOut("light3", 1.0, false);
    giOBJBlendIn("fog3", 0.5, true);
    giWait(2.5);
    giGOBMovment("fog3", 3.0, 1224.4011, 100.7, 655.4041, false);
    giCameraRunSingle("viewFog_2d_3_2", false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
    giOBJBlendOut("fog3", 0.1, true);
    light1_f_visible = giGetVisibleObject("light1_f");
    light2_f_visible = giGetVisibleObject("light2_f");
    light3_f_visible = giGetVisibleObject("light3_f");
    if (!giGetVisibleObject("light1_f") && !light2_f_visible && !light3_f_visible)
    {
        func7011();
    }
    giIMMBegin();
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giCameraSeekToPlayer();
    giIMMEnd();
    giFlashInBlack(1.0, true);
    giPlayerUnLock();
}

void func7011()
{
    giCameraPrepare("viewHole_2d");
    giCameraRunSingle("viewHole_2d_1", false);
    giFlashInBlack(1.0, true);
    giOBJBlendOut("cover01", 1.0, false);
    gi2DSoundPlay("WJ074", 1);
    giOBJBlendIn("light01", 0.5, false);
    giWait(2.0);
    giCameraRunSingle("viewHole_2d_2", false);
    giOBJBlendOut("cover03", 1.0, false);
    gi2DSoundPlay("WJ074", 1);
    giOBJBlendIn("light03", 0.5, false);
    giWait(2.0);
    giFlashOutBlack(1.0, true, true);
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
    }
    giIMMEnd();
}
