// Structured PAL4 reconstruction for M11.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M11_1_init()
{
    giTimeScript(180.0, "func9001");
    giGOMTouch("auto_weather");
    if (global_mvar != 70500 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("auto_weather", false);
        func2001();
        giSetObjectVisible("auto_weather", true);
        giGOMTouch("auto_weather");
    }
    if (global_mvar < 70800 || global_mvar < 90100 && global_mvar >= 70901)
    {
        giSetObjectVisible("entrance0", false);
        giSetObjectVisible("entrance1", true);
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("entrance0", true);
        giSetObjectVisible("entrance1", false);
        giArenaReadyRestore();
    }
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    giPlayerCurrentSetPos(1567.7776, -95.17909, 4422.158);
    giPlayerCurrentSetAng(170.0);
    giCameraSetMode(5, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 70800 || global_mvar < 90100 && global_mvar >= 70901)
    {
        if (global_mvar != 70700 /* 荒漠深处 */)
        {
            giArenaLoad("Q07", "Q07", "", true);
            giPlayerCurrentSetPos(-1839.8639, -91.1017, 629.13367);
            giPlayerCurrentSetAng(122.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        else
        {
            giArenaLoad("Q07", "Q07", "", true);
        }
    }
    else
    {
        giSetObjectVisible("auto_weather", false);
        giMonsterStopPursuit();
        giPlayerLock();
        giSelectDialogAddItem("1.去月牙村  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去月牙村</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, 2925.9087, -95.6444, -4626.729, true);
                giPlayerSetDir(leader_player_id, 325.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(5, true);
                giPlayerUnLock();
            }
            else
            {
                giShowWorldMap();
            }
        }
        else
        {
            giArenaLoad("Q07", "Q07", "", true);
            giPlayerCurrentSetPos(-1839.8639, -91.1017, 629.13367);
            giPlayerCurrentSetAng(122.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
        giSetObjectVisible("auto_weather", true);
        giGOMTouch("auto_weather");
    }
}

void func1002()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    giSetObjectVisible("auto_weather", false);
    giMonsterStopPursuit();
    giPlayerLock();
    giSelectDialogAddItem("1.御剑飞行  ");
    giSelectDialogAddItem("2.什么都不做");
    giSelectDialogSetDefaultSelect(2);
    giShowSelectDialog("              准备<colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>吗？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        leader_player_id = giPlayerGetLeader();
        giPlayerWalkTo(leader_player_id, 1567.7776, -95.17909, 4422.158, true);
        giPlayerSetDir(leader_player_id, 170.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giPlayerUnLock();
    }
    else
    {
        giShowWorldMap();
    }
    giPlayerUnLock();
    giSetObjectVisible("auto_weather", true);
    giGOMTouch("auto_weather");
}

void func2001()
{
    if (global_mvar == 70500 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 1652.7021, -95.854, 4105.502);
        giPlayerSetAng(0, 198.0);
        giPlayerSetPos(1, 1594.8752, -95.8525, 4060.184);
        giPlayerSetAng(1, 192.0);
        giPlayerSetPos(2, 1677.3412, -95.8592, 4054.8408);
        giPlayerSetAng(2, 222.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetObjectVisible("save1", false);
        giMonsterSetHide("m11-01-01", false);
        giMonsterSetHide("m11-02-07", false);
        giMonsterSetHide("m11-01-07", false);
        giMonsterSetHide("m11-02-08", false);
        giMonsterSetHide("m11-01-05", false);
        giMonsterSetHide("m11-01-04", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("004", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(1.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：这儿的土怎么和播仙镇的不太一样？", "42847");
        giWait(0.8);
        giPlayerSetDir(1, 63.0, false);
        giWait(0.3);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：哪儿有土？分明全是沙子。", "42848");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 240.0);
        giPlayerSetAng(2, 276.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：看样子这里原本有条河，后来水都干了，才会变这样。", "42849");
        giWait(0.5);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：……这，就是沙漠吗？我在书上念到过，大地干涸，树木都会枯死，人也会迁徙离开……", "42850");
        giWait(0.5);
        giPlayerSetDir(0, 198.0, true);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：沙漠？那沙漠的另一边是什么？", "42851");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：不知道，可能是绿洲，也有可能什么都没。", "42852");
        giPlayerEndAction(0);
        giPlayerSetDir(0, 240.0, false);
        giPlayerDoAction(0, "J17", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：呵呵，那我们过去看看不就知道了？", "42853");
        giPlayerEndAction(0);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：什么？！哪有人会跑去沙漠里玩？", "42854");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：不行吗？", "42855");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：哎，跟你说不清，反正那里面很没意思，又危险，去了也白去。", "42856");
        giPlayerEndAction(1);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：<colour red=255 green=187 blue=0 alpha=255>其实……进去看看也无妨啊。</colour>", "42857");
        giWait(0.5);
        giPlayerSetDir(1, 94.0, true);
        giWait(0.5);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：我们身上都有水袋……若有危险，也随时都可以御剑离开不是吗？", "42858");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, true);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：…………", "42859");
        giWait(0.3);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：好吧好吧，拗不过你们两个……", "42860");
        giWait(0.5);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：哈哈，太好了！", "42861");
        giPlayerEndAction(0);
        giPlayerRunTo(0, 1606.5328, -95.848, 3805.5466, false);
        giWait(1.8);
        giCameraRunSingle("006", false);
        giWait(0.5);
        giPlayerWalkTo(1, 1639.8466, -95.8524, 4055.233, true);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104J", true);
        giTalk("韩菱纱：梦璃，你未免对那个傻瓜太好了吧？", "42862");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：没有啊，是我自己想去看看……", "42863");
        giWait(1.0);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：唉，一个愿打，一个愿挨，倒显得我是大坏蛋～", "42864");
        giWait(1.2);
        giFlashOutBlack(1.5, true, true);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("007", true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetVisible(true);
        giMonsterSetHide("m11-01-01", true);
        giMonsterSetHide("m11-02-07", true);
        giMonsterSetHide("m11-01-07", true);
        giMonsterSetHide("m11-02-08", true);
        giMonsterSetHide("m11-01-05", true);
        giMonsterSetHide("m11-01-04", true);
        giSetObjectVisible("save1", true);
        giIMMEnd();
        global_mvar = 70700; // 0x0001142C, 荒漠深处
        giPlayerCurrentSetPos(1616.0814, -95.848, 3886.164);
        giPlayerCurrentSetAng(200.0);
        giCameraSetMode(5, true);
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func7001()
{
    int local_1 = 0;
    float random_1_360 = 0.0;

    giPlayerLock();
    giOpenWeather(6);
    local_1 = gi2DSoundPlay("we198", -1);
    giWait(1.0);
    giPlayerCurrentDoAction("J03", -1, false);
    giFlashOutBlack(1.5, true, true);
    giPlayerCurrentRandomPosition(200.0, 500.0);
    random_1_360 = giGetRandnum(1, 360);
    giPlayerCurrentSetAng(random_1_360);
    giCloseWeather();
    giWait(1.5);
    gi2DSoundStopID(local_1);
    giCameraSetMode(5, true);
    giCameraAutoSeek(true);
    giFlushTailYAngle();
    giFlashInBlack(1.5, false);
    giPlayerCurrentEndAction();
    giPlayerUnLock();
}

void func7002()
{
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
