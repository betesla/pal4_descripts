// Structured PAL4 reconstruction for M09.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M09_1_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar < 70500 || global_mvar > 70900 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
        {
            giSetObjectVisible("entrance0", false);
            giSetObjectVisible("entrance1", true);
        }
        else
        {
            giSetObjectVisible("entrance0", true);
            giSetObjectVisible("entrance1", false);
        }
    }
    else
    {
        giSetObjectVisible("entrance0", true);
        giSetObjectVisible("entrance1", false);
    }
    if (global_mvar == 60200 /* 第二章 / 4-1-2.寻仙昆仑 / 往南上山 */)
    {
        func2001();
    }
    giArenaReadyRestore();
}

void M09_2_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar <= 130100 /* 第三章 / 7-5-3.往事 / 不周山 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4002", false);
        giSetNpcVisible("4003", false);
        giSetNpcVisible("4004", false);
        giSetNpcVisible("4005", false);
        giSetNpcVisible("4006", false);
        giArenaReadyRestore();
    }
}

void M09_3_init()
{
    giOpenWeather(2);
    giTimeScript(180.0, "func9001");
    if (global_mvar < 160200 /* 第四章 / 9-3-2.君莫思归 / 再访长老 / 生离之痛 */)
    {
        giSetObjectVisible("MO001", false);
        giEventVolumeVisible("ev_M09_3_4", false);
    }
    if (global_mvar < 70500 || global_mvar > 70900 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
        {
            giSetObjectVisible("entrance0", false);
            giSetObjectVisible("entrance2", true);
        }
        else if (global_mvar >= 160200 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
        {
            giSetObjectVisible("entrance0", false);
            giSetObjectVisible("entrance2", false);
            giEventVolumeVisible("ev_M09_3_0", false);
        }
        else if (global_mvar >= 140100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
        {
            giSetObjectVisible("entrance0", true);
            giSetObjectVisible("entrance2", false);
        }
        else if (global_mvar >= 131300 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
        {
            giSetObjectVisible("entrance0", false);
            giSetObjectVisible("entrance2", false);
        }
        else
        {
            giSetObjectVisible("entrance0", true);
            giSetObjectVisible("entrance2", false);
        }
    }
    else
    {
        giSetObjectVisible("entrance0", true);
        giSetObjectVisible("entrance2", false);
    }
    giArenaReadyRestore();
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    if (!giBGMConfigIsInArea("1"))
    {
        giArenaLoad("M09", "1", "", true);
    }
    giPlayerCurrentSetPos(-3450.7776, -226.1791, -1768.1584);
    giPlayerCurrentSetAng(30.0);
    giCameraSetMode(0, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 131300 || global_mvar >= 140100 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        switch (global_mvar)
        {
            case 60800:
                giArenaLoad("Q06", "Q06Q", "", true);
                break;
            case 91200:
                giArenaLoad("Q06", "Q06Q", "", true);
                break;
            case 101400:
                giFlashOutBlack(0.1, true, false);
                giArenaLoad("Q06", "Q06Q", "", true);
                break;
            case 120100:
                giFlashOutBlack(0.1, true, false);
                giArenaLoad("Q06", "Q06Q", "", true);
                break;
            default:
                if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
                {
                    giArenaLoad("Q06", "Q06Q", "", true);
                    giPlayerCurrentSetPos(12676.761, -2022.7461, -15857.931);
                    giPlayerCurrentSetAng(352.0);
                    func7500();
                    giCameraSetMode(0, true);
                    giArenaReady();
                }
                else
                {
                    giMonsterStopPursuit();
                    giPlayerLock();
                    giSelectDialogAddItem("1.去琼华派  ");
                    giSelectDialogAddItem("2.御剑飞行  ");
                    giSelectDialogAddItem("3.什么都不做");
                    giSelectDialogSetDefaultSelect(2);
                    giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去琼华派</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
                    select_dialog_last_select = giSelectDialogGetLastSelect();
                    if (select_dialog_last_select != 0)
                    {
                        if (select_dialog_last_select != 1)
                        {
                            leader_player_id = giPlayerGetLeader();
                            giPlayerWalkTo(leader_player_id, -1458.6412, 1122.77, 2866.7542, true);
                            giPlayerSetDir(leader_player_id, 177.0, true);
                            giCameraAutoSeek(true);
                            giCameraSetMode(0, true);
                            giPlayerUnLock();
                        }
                        else
                        {
                            giShowWorldMap();
                        }
                    }
                    else
                    {
                        giArenaLoad("Q06", "Q06Q", "", true);
                        giPlayerCurrentSetPos(12676.761, -2022.7461, -15857.931);
                        giPlayerCurrentSetAng(352.0);
                        func7500();
                        giCameraSetMode(0, true);
                        giArenaReady();
                    }
                    giPlayerUnLock();
                }
                break;
        }
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -1466.3003, 1128.7644, 2934.7056, true);
        giPlayerSetDir(0, 157.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101J", true);
        giTalk("云天河：菱纱说<colour red=255 green=187 blue=0 alpha=255>要在封神陵找一件很重要的东西</colour><dc0>，现在暂时不回琼华派。</dc0>", "");
        giPlayerUnLock();
    }
}

void func1002()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 70500 || global_mvar < 90100 && global_mvar >= 70901 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(250.67487, 145.12617, 2606.9866);
        giPlayerCurrentSetAng(175.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else if (global_mvar != 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giSelectDialogAddItem("1.去播仙镇  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去播仙镇</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -3450.7776, -226.1791, -1768.1584, true);
                giPlayerSetDir(leader_player_id, 30.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
            }
            else
            {
                giShowWorldMap();
            }
        }
        else if (global_mvar < 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
        {
            giArenaLoad("Q05", "Q05", "", true);
            giPlayerCurrentSetPos(250.67487, 145.12617, 2606.9866);
            giPlayerCurrentSetAng(175.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        else
        {
            giArenaLoad("Q05", "Q05P", "", true);
            giPlayerCurrentSetPos(250.67487, 145.12617, 2606.9866);
            giPlayerCurrentSetAng(175.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
    }
}

void func1003()
{
    giArenaLoad("M09", "2", "", true);
    giPlayerCurrentSetPos(-294.17096, -1405.2139, -2986.5488);
    giPlayerCurrentSetAng(358.0);
    giCameraSetMode(0, true);
    giArenaReady();
    giPlayerLock();
    giShowTutorial(24);
    giPlayerUnLock();
}

void func1004()
{
    giArenaLoad("M09", "1", "", true);
    giPlayerCurrentSetPos(1971.4719, 696.8033, 1858.1947);
    giPlayerCurrentSetAng(125.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("M09", "3", "", true);
    giPlayerCurrentSetPos(1732.7592, 100.697205, -1987.739);
    giPlayerCurrentSetAng(355.0);
    giCameraSetMode(0, true);
    giArenaReady();
    giPlayerLock();
    giShowTutorial(25);
    giPlayerUnLock();
}

void func1006()
{
    giArenaLoad("M09", "2", "", true);
    giPlayerCurrentSetPos(559.93713, 688.34796, 2037.1272);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func2001()
{
    if (global_mvar == 60200 /* 第二章 / 4-1-2.寻仙昆仑 / 往南上山 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giScriptMusicPlay("P56", 2, 2.5, 0.0);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giCameraSetDistOptEnable(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -3040.1929, -226.1306, -1634.5739);
        giPlayerSetAng(0, 92.0);
        giPlayerSetPos(1, -3151.4539, -222.8221, -1711.8066);
        giPlayerSetAng(1, 24.0);
        giPlayerSetPos(2, -3188.8384, -222.6488, -1688.0934);
        giPlayerSetAng(2, 44.0);
        giPlayerSetPos(3, -2937.8174, -216.7136, -1567.9257);
        giPlayerSetAng(3, 112.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giMonsterSetHide("m09-01-01", false);
        giMonsterSetHide("m09-02-01", false);
        giMonsterSetHide("m09-03-01", false);
        giMonsterSetHide("m09-01-02", false);
        giMonsterSetHide("m09-02-02", false);
        giMonsterSetHide("m09-01-03", false);
        giMonsterSetHide("cloud01", false);
        giMonsterSetHide("cloud02", false);
        giMonsterSetHide("cloud03", false);
        giMonsterSetHide("cloud04", false);
        giMonsterSetHide("cloud05", false);
        giSetObjectVisible("save1", false);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giArenaReady();
        giFlashInBlack(1.5, true);
        giWait(2.0);
        giCameraRunSingle("002", true);
        giWait(2.0);
        giIMMBegin();
        giCameraSetDistOptEnable(true);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(1.0);
        giPlayerDoAction(0, "J13", -1, false);
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：这味道……要下雨了？！", "42320");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：（……不对，是杀气！）", "42321");
        giPlayerDoAction(0, "Z01", 0, false);
        giWait(1.0);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：真想不到，在这儿竟还有这样绿树荫荫的地方！", "42322");
        giPlayerEndAction(2);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：嘻～不然怎么叫仙山呢。", "42323");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerWalkTo(1, -3096.2004, -224.4982, -1676.9912, false);
        giPlayerWalkTo(2, -3122.234, -221.8935, -1642.8585, false);
        giWait(0.3);
        giCameraRunSingle("005", true);
        giWait(1.2);
        giPlayerSetDir(1, 58.0, false);
        giPlayerSetDir(2, 92.0, false);
        giWait(0.8);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：你干嘛紧张兮兮的样子？", "42324");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：杀气！", "42325");
        giWait(0.5);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：又来了，哪来这么多杀气……", "42326");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：真的，相信我……", "42327");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：喂！有点礼貌好不好，我在跟你讲话呢，背对我干嘛？ ", "42328");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(0, 232.0, false);
        giWait(1.0);
        giSetPortrait("101H", true);
        giTalk("云天河：真的有——", "42329");
        giWait(1.0);
        giIMMBegin();
        giEffectPlayWithPlayer("HW_XS013", 1, 0);
        giGOMTouch("Jeffect002");
        giIMMEnd();
        giWait(0.4);
        giPlayerDoAction(0, "Z11", 0, false);
        giSetPortrait("101D", true);
        giTalk("云天河：哇——！！", "42330");
        giWait(0.3);
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：……！", "42331");
        giWait(0.3);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：云公子，你受伤了？！", "42332");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giSetPortrait("101G", true);
        giTalk("云天河：没、没有……只是全身麻了……不能动……你们小心……", "42333");
        giWait(0.5);
        giEffectPlayWithNPC("H_097", 1, "MN001");
        giNpcBlendIn("MN001", 1.5, true);
        gi2DSoundPlay("WJ071", 1);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetDir(1, 82.0, false);
        giPlayerSetDir(2, 82.0, false);
        giCameraRunSingle("006", false);
        giIMMEnd();
        giCameraWait();
        giWait(1.0);
        gi2DSoundPlay("WH028", 1);
        giNpcDoAction("MN001", "Z03", 1, true);
        giPlayerRunTo(1, -2963.9956, -226.0815, -1640.9987, true);
        giPlayerSetAng(1, 58.0);
        giPlayerDoAction(1, "Z01", 0, false);
        giWait(0.5);
        giSetPortrait("103K", false);
        giTalk("韩菱纱：怪物偷袭！梦璃，你先看看天河的伤！我来对付这个怪物！", "42334");
        giWait(0.5);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P26", 2, 0.0, 0.0);
        giEffectPlayWithPlayer("H_090", 1, 3);
        giPlayerBlendIn(3, 1.0, true);
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("MN001", 268.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giWait(1.2);
        giIMMBegin();
        giSetObjectVisible("Jeffect001", true);
        giPlayerDoAction(3, "Z07", 1, false);
        giIMMEnd();
        giWait(2.2);
        giNpcDoAction("MN001", "Z04", 1, false);
        giEffectPlayWithNPC("H_TM01_4", 1, "MN001");
        gi2DSoundPlay("WH002", 1);
        giNpcBlendOut("MN001", 1.5, true);
        giWait(0.5);
        giIMMBegin();
        giPlayerDoAction(1, "C01", 1, false);
        giPlayerSetPos(1, -2958.1968, -224.4332, -1623.2324);
        giPlayerSetAng(1, 36.0);
        giIMMEnd();
        giCameraRunSingle("008", true);
        giWait(0.6);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：你是……？", "42335");
        giWait(0.5);
        giPlayerSetDir(3, 186.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J02", -1, true);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：你……剑仙！谢谢，你又帮了我们一次！", "42336");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetPos(0, -3031.1716, -226.1413, -1647.5032);
        giPlayerSetAng(0, 50.0);
        giPlayerSetPos(2, -3049.6785, -216.0029, -1596.8276);
        giPlayerSetAng(2, 154.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：云公子，你好些了吗？", "42337");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giWait(0.5);
        giPlayerSetDir(0, 342.0, true);
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：呃……身上已经不麻了……", "42338");
        giWait(0.5);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：嗯，没事就好。", "42339");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：刚才怎么回事？突然打下那么厉害的雷？", "42340");
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, true);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(1, 286.0);
        giPlayerSetAng(3, 280.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：梦璃～这就是在巢湖岸边救过我和天河的剑仙，他的剑术很厉害呢！", "42341");
        giWait(0.8);
        giIMMBegin();
        giPlayerSetDir(1, 22.0, false);
        giPlayerSetDir(0, 52.0, false);
        giPlayerSetDir(2, 94.0, false);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(2, "J07", 1, true);
        giWait(0.5);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("少年剑客：……", "42342");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("少年剑客：你们为何在此？", "42343");
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：我们正要上山寻仙访道。", "42344");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(3, 178.0, true);
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("少年剑客：……原来如此，刚才不应该帮你们的。", "42345");
        giWait(0.5);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：你……？！", "42346");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("少年剑客：姑娘莫要误会，若是来求仙，太一仙径只不过是小小试炼，须得凭自身之力通过。 ", "42347");
        giWait(0.3);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：太一仙径？名字很好听，怎么这样凶险啊……", "42348");
        giWait(0.3);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：不如剑仙你好人做到底，就带我们上山吧～", "42349");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(3, "J13", 1, true);
        giSetPortrait("105A", true);
        giTalk("少年剑客：不可。", "42350");
        giWait(0.3);
        giPlayerSetDir(3, 36.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：哎，等等！", "42351");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：虽说要凭自身之力，可剑仙你刚才明明帮了我们，既然出手，就是打破规矩了，破例一次和破例两次又有什么分别呢？对不对？", "42352");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(3, 178.0, true);
        giWait(0.5);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105C", true);
        giTalk("少年剑客：……不必多逞口舌之利。你们适才遇雷电也不知闪躲，毫无应变可言，若是没有修仙资质，就请回吧。", "42353");
        giWait(0.5);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：什么？你！你少瞧不起人！", "42354");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", true);
        giTalk("少年剑客：我不过就事论事。", "42355");
        giPlayerEndAction(3);
        giWait(0.6);
        giEffectPlayWithPlayer("H_089", 1, 3);
        giPlayerBlendOut(3, 1.0, true);
        giWait(2.0);
        giPlayerWalkTo(1, -2940.0703, -217.9191, -1582.115, true);
        giWait(1.5);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：不是吧？这家伙的性格这么讨人厌……", "42356");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.5);
        giSetPortrait("101A", false);
        giTalk("云天河：他也没怎样，还帮了我们……", "42357");
        giWait(1.0);
        giPlayerSetDir(1, 226.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：你啊，到底懂不懂人争一口气的道理！", "42358");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：走！拼了命我们也要爬上山，让那个冰块脸刮目相看！", "42359");
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：嗯……有些人就是面冷心热，他出手帮我们，应该也没有恶意，菱纱你就别气了。", "42360");
        giWait(0.3);
        giPlayerSetDir(1, 276.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：……其实，我也知道啊，他救了我们两次，是个好人，我只是不喜欢他那么说话……我们走吧。", "42361");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giShowTutorial(23);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetPos(-3034.7114, -226.1306, -1637.0135);
        giPlayerCurrentSetAng(54.0);
        giMonsterSetHide("m09-01-01", true);
        giMonsterSetHide("m09-02-01", true);
        giMonsterSetHide("m09-03-01", true);
        giMonsterSetHide("m09-01-02", true);
        giMonsterSetHide("m09-02-02", true);
        giMonsterSetHide("m09-01-03", true);
        giMonsterSetHide("cloud01", true);
        giMonsterSetHide("cloud02", true);
        giMonsterSetHide("cloud03", true);
        giMonsterSetHide("cloud04", true);
        giMonsterSetHide("cloud05", true);
        giSetObjectVisible("save1", true);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        global_mvar = 60600; // 0x0000ECB8, 仙山试炼
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giScriptMusicStop(0, 2.5);
        giSetObjectVisible("Jeffect001", false);
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 60600 /* 仙山试炼 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giHideGASkillObject();
        giFlashOutBlack(0.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giMonsterSetHide("m09-01-05", false);
        giMonsterSetHide("m09-02-04", false);
        giMonsterSetHide("m09-02-01", false);
        giMonsterSetHide("m09-01-07", false);
        giMonsterSetHide("cloud05", false);
        giMonsterSetHide("cloud06", false);
        giMonsterSetHide("cloud07", false);
        giMonsterSetHide("cloud08", false);
        giPlayerSetPos(0, -1160.0272, -401.639, 112.1915);
        giPlayerSetAng(0, 214.0);
        giPlayerSetPos(1, -1174.4565, -401.639, 25.6953);
        giPlayerSetAng(1, 222.0);
        giPlayerSetPos(2, -1127.8074, -401.639, 69.4294);
        giPlayerSetAng(2, 228.0);
        giNpcSetPos("MN001", -1465.3842, -401.6392, 97.5191);
        giNpcSetAng("MN001", 96.0);
        giNpcSetPos("MN002", -1463.3169, -401.639, 125.8596);
        giNpcSetAng("MN002", 94.0);
        giNpcSetPos("MN003", -1486.9832, -401.7452, 147.2698);
        giNpcSetAng("MN003", 112.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giArenaReady();
        giFlashInBlack(1.5, true);
        giWait(1.0);
        giCameraRunSingle("002", true);
        giWait(1.5);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：走了大半天，不要说什么修仙门派，连个人影都没看见……", "42362");
        giScriptMusicPlay("P24", 2, 0.0, 0.0);
        giNpcWalkTo("MN001", -1262.3358, -401.639, 74.862, false);
        giWait(0.3);
        giNpcWalkTo("MN002", -1263.1279, -401.6391, 106.9806, true);
        giNpcEndMove("MN001");
        giNpcSetDir("MN001", 66.0, true);
        giCameraRunSingle("003", true);
        giWait(1.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giTalk("耿峰：此山是我开，此树是我栽！", "42363");
        giWait(0.5);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giNpcDoAction("MN002", "J01", -1, false);
        giTalk("巴靖安：要从此路过，留下干粮来！", "42364");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giIMMBegin();
        giPlayerSetAng(0, 260.0);
        giPlayerSetAng(1, 310.0);
        giPlayerSetAng(2, 294.0);
        giPlayerSetPos(1, -1169.2457, -401.639, 37.5939);
        giPlayerSetPos(2, -1140.9221, -401.639, 67.0077);
        giIMMEnd();
        giCameraRunSingle("005", false);
        giWait(0.5);
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giCameraWait();
        giWait(1.0);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：哈，才说没人呢，马上就来了两个傻瓜。", "42365");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giIMMBegin();
        giNpcSetAng("MN001", 96.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：你们是谁？有事吗？", "42366");
        giPlayerEndAction(0);
        giNpcSetDir("MN002", 158.0, true);
        giWait(0.5);
        giTalk("巴靖安：老大，怎么办？我们都已经讲这么白了……", "42367");
        giWait(0.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giTalk("耿峰：担心什么，他们只是在故作镇定罢了！", "42368");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(0.5);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：仙山之中……怎会有匪徒？", "42369");
        giWait(0.5);
        giTalk("耿峰：错！我们不是匪徒，而是江湖上人称“剑南双侠”的豪杰！", "42370");
        giWait(0.5);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：贱男？双侠？……那，请问有何贵干？", "42371");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcSetDir("MN002", 130.0, true);
        giWait(0.5);
        giTalk("巴靖安：刚才不是说过了吗？！哼，那我再说一次，听好！", "42372");
        giNpcDoAction("MN002", "J01", -1, false);
        giTalk("巴靖安：要从此路过，留下干粮来！", "42373");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：为什么要把干粮给你们？", "42374");
        giPlayerEndAction(0);
        giIMMBegin();
        giNpcSetDir("MN001", 78.0, false);
        giNpcSetDir("MN002", 94.0, false);
        giIMMEnd();
        giWait(0.8);
        giTalk("耿峰：蠢货！你没看我们手上拿着剑吗？！", "42375");
        giWait(0.5);
        giTalk("巴靖安：对！拳头大的人有干粮吃，快拿来！", "42376");
        giWait(0.5);
        giCameraRunSingle("007", true);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101J", false);
        giTalk("云天河：剑？可是我也有啊，还不止一把。", "42377");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(2, 322.0, false);
        giPlayerSetDir(1, 358.0, false);
        giWait(0.5);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101J", false);
        giTalk("云天河：还有拳头？我看你们拳头小得很，应该你们把干粮给我。", "42378");
        giWait(0.5);
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("106C", true);
        giTalk("柳梦璃：噗～", "42379");
        giPlayerEndAction(2);
        giWait(0.5);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：哈哈，人说秀才遇到兵，有理说不清，今天是强盗遇到野人，一样有理说不清。", "42380");
        giWait(1.0);
        giCameraRunSingle("008", true);
        giPlayerSetDir(2, 290.0, false);
        giPlayerSetDir(1, 310.0, false);
        giWait(1.0);
        giNpcSetDir("MN002", 142.0, true);
        giWait(0.3);
        giTalk("巴靖安：老大，怎么办？打不？", "42381");
        giWait(0.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giTalk("耿峰：咳咳……这个……", "42382");
        giWait(0.5);
        giNpcSetDir("MN002", 84.0, true);
        giWait(2.3);
        giNpcSetDir("MN002", 142.0, true);
        giWait(0.5);
        giTalk("巴靖安：老大，这小子身形剽悍呐，打不？", "42383");
        giWait(0.5);
        giTalk("耿峰：咳咳……那个……我看……", "42384");
        giWait(0.3);
        giTalk("巴靖安：莫非老大一眼就看出他是使双剑的好手？", "42385");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giTalk("耿峰：啊？！对、对、对，是使双剑的好手，一流的剑客呀！", "42386");
        giTalk("巴靖安：高！还是老大眼光高啊，那我们…………打不？", "42387");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(1, 296.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(0.8);
        giNpcDoAction("MN001", "J02", -1, false);
        giTalk("耿峰：咳咳……这位少侠，既然都是使剑高手，我们英雄惜英雄，单剑惜双剑。这样吧，你继续吃你的干粮，我继续吃我的干粮。", "42388");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giNpcSetDir("MN002", 98.0, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：（听不懂……到底干粮要给谁？）", "42389");
        giPlayerEndAction(0);
        giCameraRunSingle("010", false);
        giNpcDoAction("MN001", "J02", -1, false);
        giTalk("耿峰：青山不改，绿水长流，就此别过！我们走！", "42390");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giTalk("巴靖安：是，老大！", "42391");
        giWait(0.5);
        giNpcSetDir("MN001", 272.0, false);
        giNpcSetDir("MN002", 286.0, false);
        giWait(0.8);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：慢～～着～～", "42392");
        giCameraRunSingle("011", true);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giNpcSetDir("MN001", 122.0, false);
        giNpcSetDir("MN002", 132.0, false);
        giWait(0.8);
        giNpcDoAction("MN001", "J01", -1, false);
        giTalk("耿峰：你、你想怎样？", "42393");
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：不怎样，只是想问问这条路是不是能通到仙山顶上？", "42394");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("巴靖安：就算是，就凭你们几个也上不去！连我们“剑南双侠”都——", "42395");
        giTalk("耿峰：咳咳！！", "42396");
        giWait(0.5);
        giNpcDoAction("MN002", "J01", -1, false);
        giTalk("巴靖安：对啊，你问我就说，不是太没面子了！", "42397");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giSetNpcVisible("MN003", true);
        giWait(1.0);
        giCameraRunSingle("012", true);
        giWait(0.8);
        giTalk("少女：你们两个！又在欺负刚上山的人！", "42398");
        giIMMBegin();
        giNpcSetPos("MN001", -1286.9161, -401.639, 122.9823);
        giNpcSetAng("MN001", 278.0);
        giNpcSetPos("MN002", -1283.1064, -401.6391, 156.3012);
        giNpcSetAng("MN002", 272.0);
        giPlayerSetPos(0, -1157.7035, -401.639, 95.873);
        giPlayerSetAng(0, 260.0);
        giPlayerSetPos(1, -1174.4565, -401.639, 25.6953);
        giPlayerSetAng(1, 314.0);
        giPlayerSetPos(2, -1140.4845, -401.639, 53.96);
        giPlayerSetAng(2, 282.0);
        giIMMEnd();
        giWait(1.0);
        giCameraRunSingle("013", false);
        giWait(0.8);
        giNpcWalkTo("MN003", -1368.453, -401.639, 131.0962, true);
        giCameraWait();
        giWait(0.5);
        giTalk("耿峰：石榴妹妹，你可别冤枉人，我和大巴也是好心，怕他们在山上迷了路，才来帮忙的。", "42399");
        giWait(0.5);
        giTalk("石榴：听你鬼扯！", "42400");
        giWait(0.5);
        giTalk("耿峰：不信就算了，咱兄弟俩还要练剑，先走一步！", "42401");
        giWait(0.5);
        giNpcWalkTo("MN001", -1441.4763, -401.6391, 175.9052, false);
        giWait(0.3);
        giNpcWalkTo("MN002", -1437.9624, -401.639, 213.6389, false);
        giWait(1.1);
        giCameraRunSingle("014", true);
        giNpcWalkTo("MN003", -1231.5646, -401.6391, 89.0574, true);
        giNpcEndMove("MN001");
        giNpcEndMove("MN002");
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：这，究竟是……？", "42402");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giWait(0.5);
        giTalk("石榴：别理那两个混蛋！除了欺软怕硬，别的什么都不会！", "42403");
        giWait(0.5);
        giCameraRunSingle("015", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：他们干嘛要干粮？", "42404");
        giWait(0.3);
        giNpcSetDir("MN003", 82.0, true);
        giWait(0.5);
        giTalk("石榴：那个啊～当然拿来吃了！", "42405");
        giWait(0.5);
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giIMMEnd();
        giPlayerEndAction(0);
        giCameraRunSingle("016", false);
        giTalk("石榴：其实我们都是来求仙问道的，可惜通不过试炼，又不甘心就此离开，所以在山腰结庐，苦修武功，想要再去闯关。", "42406");
        giWait(0.5);
        giTalk("石榴：虽然山上偶尔也会送些东西下来，但这儿毕竟很清苦，那两个没骨气的东西就想了个馊主意，专打劫你们这种刚上山的人。", "42407");
        giWait(0.5);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：你说的山上，是指那个修仙门派吗？", "42408");
        giWait(0.5);
        giNpcSetDir("MN003", 140.0, true);
        giWait(0.5);
        giTalk("石榴：是啊，据说昆仑山中一共有八个修仙门派，在播仙镇附近的这个最大最强，叫作“琼华派”，供奉着九天玄女。", "42409");
        giWait(0.5);
        giTalk("石榴：这一派讲究“人剑合一”的修行之法，收取门徒极是严格，可以说是百里，不，千里挑一！", "42410");
        giWait(0.5);
        giCameraRunSingle("017", true);
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：有这么难？那你和我们一起上山吧，人多不怕闯不过去！", "42411");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.3);
        giNpcSetDir("MN003", 102.0, true);
        giWait(0.5);
        giTalk("石榴：多谢，但是我不能入门并非因为走不过太一仙径，这儿不少人都和我一样……", "42412");
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：那你能不能告诉我们——", "42413");
        giWait(0.5);
        giTalk("石榴：对不起……我知道你想问什么，可往后的试炼我连一点点都不能透露，要是让人知道了，我会立刻被送下山去。", "42414");
        giWait(0.5);
        giPlayerEndAction(2);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：抱歉，让你为难了……", "42415");
        giPlayerEndAction(2);
        giWait(0.5);
        giTalk("石榴：没关系，但愿你们都能如愿以偿～", "42416");
        giTalk("石榴：累了的话，可以在前面稍微歇息一下。", "42417");
        giPlayerDoAction(1, "C08", 1, true);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：谢谢！", "42418");
        giWait(1.0);
        giNpcWalkTo("MN003", -1368.453, -401.639, 131.0962, true);
        giSetNpcVisible("MN003", false);
        giCameraRunSingle("018", true);
        giWait(0.3);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：听她这么一说，我更是想快点上山看看！", "42419");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, true);
        giPlayerSetDir(1, 10.0, true);
        giWait(0.5);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：天河！", "42420");
        giWait(0.3);
        giPlayerSetDir(0, 168.0, false);
        giWait(0.5);
        giPlayerSetDir(2, 310.0, true);
        giWait(0.5);
        giSetPortrait("101D", false);
        giTalk("云天河：啊？", "42421");
        giWait(0.5);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：青山不改、绿水长流！我们走！嘻嘻～", "42422");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "J14", 1, false);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：是……", "42423");
        giFlashOutBlack(1.0, true, true);
        giPlayerEndAction(2);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetPos(-1157.7035, -401.639, 95.873);
        giPlayerCurrentSetAng(274.0);
        giMonsterSetHide("m09-01-05", true);
        giMonsterSetHide("m09-02-04", true);
        giMonsterSetHide("m09-02-01", true);
        giMonsterSetHide("m09-01-07", true);
        giMonsterSetHide("cloud05", true);
        giMonsterSetHide("cloud06", true);
        giMonsterSetHide("cloud07", true);
        giMonsterSetHide("cloud08", true);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        global_mvar = 60800; // 0x0000ED80, 仙山试炼 / 太一仙径
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giScriptMusicStop(1, 2.5);
        giShowSignpost();
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(0.5, true);
    }
}

void func3001()
{
    int leader_player_id = 0;

    leader_player_id = giPlayerGetLeader();
    if (giPlayerGetLeader() == 0 && global_mvar <= 100100 && global_mvar >= 70500 && npc_c == 0 /* 第二章 / 6-3-3.义结金兰 / 歇息一晚 */)
    {
        giScriptMusicPlay("P23", 2, 0.0, 0.0);
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giHideGASkillObject();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giNpcSetPos("SN001", -1452.7845, 1131.2233, 1891.799);
        giNpcSetAng("SN001", 90.0);
        giNpcSetPos("SN002", -1329.657, 1083.2103, 1887.7064);
        giNpcSetAng("SN002", 270.0);
        giSetNpcVisible("SN001", true);
        giSetNpcVisible("SN002", true);
        giPlayerSetPos(0, -1402.1836, 1094.4999, 2449.8228);
        giPlayerSetAng(0, 175.0);
        giMonsterSetHide("m09-01-08", false);
        giMonsterSetHide("m09-04-03", false);
        giIMMEnd();
        giCameraPrepare("wu001");
        giCameraRunSingle("001", true);
        giNpcSetEmotion("SN001", "339_fn");
        giFlashInBlack(1.5, true);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("102D", false);
        giTalk("云天河：咦？那是什么？", "");
        giWait(0.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("002", true);
        giCameraRunSingle("003", true);
        giWait(0.8);
        giCameraRunSingle("004", true);
        giCameraRunSingle("005", true);
        gi2DSoundPlay("WJ090", 1);
        giCameraRunSingle("006", true);
        giCameraRunSingle("007", true);
        giCGEffPlay(5);
        giCameraRunSingle("008", true);
        giCameraRunSingle("009", true);
        giWait(1.0);
        giNpcDoAction("SN001", "C02", 0, false);
        giCameraRunSingle("010", true);
        giWait(3.0);
        giIMMBegin();
        giCGEffStop();
        giCameraRunSingle("011", false);
        giIMMEnd();
        giWait(0.5);
        giNPCFlyTo("SN001", -1354.0645, 1105.308, 1888.1738, true);
        gi2DSoundPlay("WJ091", 1);
        giNpcSetEmotion("SN001", "339_jj");
        giNPCFlyTo("SN001", -1394.2491, 1105.308, 1892.775, true);
        giNpcSetDir("SN001", 92.0, true);
        giNpcDoAction("SN001", "C09", 1, false);
        gi2DSoundPlay("WJ089", 1);
        giNpcEndAction("SN001", true);
        giNpcSetEmotion("SN001", "339_fn");
        giWait(0.5);
        giNpcDoAction("SN002", "Z03", 1, false);
        gi2DSoundPlay("WJ096", 1);
        giWait(0.23);
        gi2DSoundPlay("WJ091", 1);
        giNPCFlyTo("SN001", -1405.8918, 1127.1019, 1888.3557, true);
        giNpcSetDir("SN001", 90.0, true);
        giNpcDoAction("SN001", "C02", 0, false);
        giWait(0.5);
        giSetPortrait("102H", true);
        giTalk("云天河：住手！", "");
        giNpcSetDir("SN001", 6.0, false);
        giNpcSetDir("SN002", 332.0, false);
        giWait(0.5);
        giTalk("路怪甲：……？！", "");
        giNpcSetEmotion("SN001", "339_mr");
        gi2DSoundPlay("WJ088", 1);
        giWait(1.0);
        giPlayerSetPos(0, -1440.3481, 1052.4835, 2032.6125);
        giPlayerRunTo(0, -1409.7878, 1083.2505, 1978.5671, true);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102H", true);
        giTalk("云天河：这猎物是我的！", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("012", true);
        giPlayerDoAction(0, "J17", -1, false);
        giCameraRunSingle("013", false);
        giWait(0.6);
        giSetPortrait("102M", true);
        giTalk("云天河：此山是我开，此树是我栽！要……嗯？", "");
        giCameraWait();
        giCameraRunSingle("014", true);
        giPlayerDoAction(0, "J14", 1, true);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102J", false);
        giTalk("云天河：后面忘了怎说了……反正这只看上去嫩嫩的会飞小猪我要了！", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("011", true);
        giWait(0.5);
        giNpcDoAction("SN002", "X01", 1, false);
        giWait(1.0);
        gi2DSoundPlay("WJ096", 1);
        giTalk("路怪甲：咕呱～！！", "");
        giWait(0.5);
        giSetPortrait("102I", true);
        giTalk("云天河：啊？！想打架？我不怕你！", "");
        giWait(0.3);
        giPlayerRunTo(0, -1365.7773, 1083.2551, 1934.9958, true);
        giPlayerSetAng(0, 146.0);
        giPlayerDoAction(0, "Z03", 1, false);
        gi2DSoundPlay("WH028", 1);
        giWait(1.0);
        giSetObjectVisible("Jeffect001", true);
        giNpcBlendOut("SN002", 1.5, true);
        giWait(0.5);
        giPlayerDoAction(0, "J17", -1, false);
        giIMMBegin();
        giNpcSetAng("SN001", 60.0);
        giCameraRunSingle("015", true);
        giNpcSetEmotion("SN001", "339_kx");
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("102C", true);
        giTalk("云天河：实在太弱了，连个肉渣都没剩下……", "");
        gi2DSoundPlay("WJ085", 1);
        giNPCFlyTo("SN001", -1395.8555, 1155.1019, 1907.4108, true);
        giNpcSetDir("SN001", 54.0, true);
        gi2DSoundPlay("WJ085", 1);
        giNpcDoAction("SN001", "J03", 1, true);
        giWait(0.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(0, 214.0);
        giCameraRunSingle("016", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("102B", true);
        giTalk("云天河：（看样子皮也很薄，应该不用剥皮，直接烤了算了……）", "");
        giWait(0.5);
        gi2DSoundPlay("WJ085", 1);
        giWait(1.0);
        giSetPortrait("102C", true);
        giTalk("天河：（奇怪……这只猪不逃走？跟其他的不太一样……）", "");
        gi2DSoundPlay("WJ085", 1);
        giNpcDoAction("SN001", "J02", 1, true);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：（怎么给我一种感觉……唔，长得很有勇气的样子……）", "");
        giWait(0.5);
        gi2DSoundPlay("WJ085", 1);
        giNpcDoAction("SN001", "J02", 1, true);
        giSetPortrait("102B", true);
        giTalk("云天河：（………………难得见到这么勇敢的猪，居然不怕我，了不起！）", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("102K", true);
        giTalk("云天河：唔，算了，今天就先放过你吧，以后再来找你，哈哈，记得多吃点，把自己养肥一点～", "");
        gi2DSoundPlay("WJ088", 1);
        giNpcSetEmotion("SN001", "339_mr");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：再见了，勇气猪～", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.0);
        giPlayerWalkTo(0, -1356.5946, 1000.7909, 2126.7175, false);
        giWait(0.5);
        giNpcSetEmotion("SN001", "339_zc");
        giNpcSetDir("SN001", 16.0, true);
        giNPCFlyTo("SN001", -1381.0846, 1069.1019, 2108.9924, false);
        giWait(0.5);
        giCameraRunSingle("017", true);
        giWait(2.0);
        giNpcSetDir("SN001", 40.0, true);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 220.0, true);
        giWait(0.5);
        giNpcSetEmotion("SN001", "339_kx");
        gi2DSoundPlay("WJ085", 1);
        giNpcDoAction("SN001", "C08", 1, true);
        giPlayerWalkTo(0, -1386.176, 1000.7909, 2214.7505, false);
        giCameraRunSingle("018", false);
        giNpcSetEmotion("SN001", "339_zc");
        giNPCFlyTo("SN001", -1416.3201, 1071.1019, 2250.962, true);
        giNpcSetDir("SN001", 124.0, true);
        giWait(0.5);
        giPlayerSetDir(0, 326.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：你干嘛一直跟着我？", "");
        giCameraRunSingle("019", true);
        giWait(0.5);
        giNpcSetEmotion("SN001", "339_kx");
        gi2DSoundPlay("WJ085", 1);
        giNpcDoAction("SN001", "C08", 1, true);
        giNpcSetEmotion("SN001", "339_zc");
        gi2DSoundPlay("WJ093", 1);
        giNpcDoAction("SN001", "C09", 1, true);
        giWait(0.3);
        giSetPortrait("102C", false);
        giTalk("云天河：……说什么？不懂……", "");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：难道你觉得自己够肥了？不会吧？好歹吃到身体比头大吧？", "");
        giWait(0.5);
        gi2DSoundPlay("WJ088", 1);
        giWait(1.2);
        gi2DSoundPlay("WJ085", 1);
        giNpcDoAction("SN001", "J02", 1, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：啥意思？……你要跟着我？", "");
        giWait(0.8);
        giNpcSetEmotion("SN001", "339_kx");
        giNpcDoAction("SN001", "C08", 1, false);
        giWait(0.3);
        gi2DSoundPlay("WJ086", 1);
        giNpcEndAction("SN001", true);
        giWait(0.5);
        giSetPortrait("102B", false);
        giTalk("云天河：哈哈，真的吗？这可是你自己送上门来的！", "");
        giWait(0.5);
        giNpcDoAction("SN001", "C08", 1, false);
        giWait(0.3);
        gi2DSoundPlay("WJ086", 1);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102M", false);
        giTalk("云天河：（太好了～～～这样下次烤肉的时候就可以……哈哈、哈哈哈……）", "");
        giSetPortrait("102B", false);
        giTalk("云天河：（要是紫英师叔问起来，也不关我的事，是这只勇气猪自己要跟来的～）", "");
        giNpcDoAction("SN001", "C08", 1, false);
        gi2DSoundPlay("WJ086", 1);
        giNpcEndAction("SN001", true);
        giCameraRunSingle("020", true);
        giWait(0.5);
        giSetPortrait("102B", false);
        giTalk("云天河：走吧，勇气！", "");
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：哈哈，第一次有食物跟着我跑，不是我追着食物跑，实在太高兴啦！", "");
        giPlayerEndAction(0);
        giPlayerRunTo(0, -1395.2865, 1054.0306, 2358.4148, false);
        giWait(0.6);
        giNpcSetEmotion("SN001", "339_mr");
        giNpcSetDir("SN001", 358.0, true);
        gi2DSoundPlay("WJ088", 1);
        giWait(1.2);
        giNpcSetEmotion("SN001", "339_zc");
        giNPCFlyTo("SN001", -1410.7693, 1080.1019, 2359.9634, false);
        giWait(2.0);
        giFlashOutBlack(1.5, true, true);
        giPlayerEndMove(0);
        giWait(1.0);
        giIMMBegin();
        giSetNpcVisible("SN001", false);
        giPlayerSetVisible(0, false);
        giPlayerCurrentSetPos(-1400.809, 1097.216, 2487.7146);
        giPlayerCurrentSetAng(353.0);
        giMonsterSetHide("m09-01-08", true);
        giMonsterSetHide("m09-04-03", true);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(0, true);
        giTimeScript(180.0, "func9001");
        npc_c = 1;
        giPlayerUnLock();
        giShowSignpost();
        giPetShow(true);
        giSetObjectVisible("Jeffect001", false);
        giScriptMusicStop(1, 2.5);
        giFlashInBlack(1.5, true);
    }
}

void func4001()
{
    giPlayerLock();
    giNpcPauseBeh("4001");
    giNpcFaceToCurrentPlayer("4001", true);
    giCurrentPlayerFaceToNpc("4001", true);
    if (global_mvar >= 70500 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giRandTalkRelease();
        giRandTalkPush("阿吉达：天神的使者告诉我们，山上出了大事，这里不能继续住下去了，让我们尽快下山！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("阿吉达：太一仙径的路实在太难走！我走了十几天，包袱里的大饼都快吃完了，才刚走到这里！留在这里的大叔看起来都比我厉害，可他们说，再往上的路更难走！");
        giRandTalkPush("阿吉达：……看来我是无缘见到山上的天神了……可是下山的路我也不记得，只能先在这里住一阵再说……");
        giRandTalk();
        giRandTalkRelease();
    }
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
    if (global_mvar >= 70500 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giRandTalkRelease();
        giRandTalkPush("萧秋语：仙家讲求缘分，看来你们几个才是和琼华派有缘的人，却不知道我的仙缘又在哪里呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("萧秋语：昆仑仙山果然不同凡响，山下播仙镇一派绿洲景象，山道上四时景观又各不相同，即使琼华派不收我入门，我这一趟西域之行，也不算白来。");
        giRandTalkPush("萧秋语：据说太一仙径分别有紫微道、白灏道、玄寂道，乃是含有通神之意。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4002");
    giNpcResumeBeh("4002");
    giPlayerUnLock();
}

void func4003()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4003");
    giCurrentPlayerFaceToNpc("4003", true);
    if (global_mvar >= 70500 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giRandTalkRelease();
        giRandTalkPush("邓一浩：之前有琼华派的剑仙来过，我还以为他们要改变主意收我入门，没想到是来让我们速速下山的……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4003", true);
            giTalk("邓一浩：我是千里迢迢从京城来昆仑求仙的，希望仙人一定要收我入门，不然我在家中立下重誓，回去岂不是脸都丢光了？……", "");
        }
        else
        {
            giNpcFaceToNpc("4004", "4003", true);
            giNpcFaceToNpc("4003", "4004", true);
            giTalk("邓一浩：谢大哥，你功夫高，能不能告诉我，再往上的山路到底好走不好走？", "");
            giTalk("谢见星：再往上啊，冷得要命，河水都结冰了……", "");
            giTalk("邓一浩：这么说来，我们两人多穿点，还是能上山求仙？", "");
            giTalk("谢见星：其实我已经上过山了，只是琼华派不肯收我，我才刚入山门，就被站在门口的弟子请出来了。", "");
        }
    }
    giNpcResetDir("4003");
    giNpcResetDir("4002");
    giNpcResumeBeh("4003");
    giPlayerUnLock();
}

void func4004()
{
    giPlayerLock();
    giNpcPauseBeh("4004");
    giNpcFaceToCurrentPlayer("4004", true);
    giCurrentPlayerFaceToNpc("4004", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("谢见星：什么？我上山时琼华派的人明明跟我说他们不收弟子的呀！你比我晚上山，他们凭什么收你不收我？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("谢见星：除了昆仑之外，蜀山也是赫赫有名的修仙之地，不过我仰慕琼华派炼剑之法，所以宁可跑这么远来西域！");
        giRandTalkPush("谢见星：邓兄算不上习武之人，能来到半山腰已经很不容易，我看还是不要强求了……");
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
    if (global_mvar >= 70500 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giRandTalkRelease();
        giRandTalkPush("石榴：呀！恭喜你们，看来已经被收入剑仙门下了！……只可惜……我似乎是没有这里的仙缘，剑仙说近日将有大事发生，遣我们速速下山去……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("石榴：你们几个一路小心～我相信只要有决心，一定能入琼华派门下的！");
        giRandTalk();
        giRandTalkRelease();
    }
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
    giPlayerLock();
    giRandTalkRelease();
    giRandTalkPush("沙依木：天神保佑！我终于来到了半山腰……可是为什么又马上就让我下山呢……好累……");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4006");
    giNpcResumeBeh("4006");
    giPlayerUnLock();
}

void func7001()
{
    giEnableSTS(2);
}

void func7002()
{
    giEnableSTS(3);
}

void func7003()
{
    giEnableSTS(1);
}

void func7500()
{
    float current_player_pos_y = 0.0;

    current_player_pos_y = giPlayerCurrentGetPosY();
    if (giPlayerCurrentGetPosY() < 0.0)
    {
        giSetMinimapLevel(1);
    }
    else
    {
        giSetMinimapLevel(0);
    }
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
