// Structured PAL4 reconstruction for M02.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M02_1_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
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

void M02_3_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
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
    if (!giBGMConfigIsInArea("1"))
    {
        giArenaLoad("M02", "1", "", true);
    }
    giPlayerCurrentSetPos(-49.54868, -131.68823, 217.37811);
    giPlayerCurrentSetAng(170.0);
    giCameraSetMode(0, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    giArenaLoad("M02", "3", "", true);
    giPlayerCurrentSetPos(-899.4696, 119.91731, 1167.588);
    giPlayerCurrentSetAng(160.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("M02", "1", "", true);
    giPlayerCurrentSetPos(-1331.1445, -1062.9479, -1557.8892);
    giPlayerCurrentSetAng(64.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaLoad("Q01", "Q01", "", true);
        giPlayerCurrentSetPos(-3178.161, -407.63074, 349.00125);
        giPlayerCurrentSetAng(45.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else if (global_mvar == 160400 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaLoad("Q01", "Q01", "", true);
    }
    else
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giSelectDialogAddItem("1.去青鸾峰  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去青鸾峰</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -64.548676, -114.68823, 298.3781, true);
                giPlayerSetDir(leader_player_id, 176.0, true);
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
            giArenaLoad("Q01", "Q01", "", true);
            giPlayerCurrentSetPos(-3178.161, -407.63074, 349.00125);
            giPlayerCurrentSetAng(45.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1004()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        if (global_mvar != 20200 /* 入世下山 */)
        {
            giArenaLoad("Q02", "Q02", "", true);
            giPlayerCurrentSetPos(-411.3458, 221.3821, 1477.6482);
            giPlayerCurrentSetAng(165.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        else
        {
            giArenaLoad("Q02", "Q02", "", true);
        }
    }
    else
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giSelectDialogAddItem("1.去太平村  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去太平村</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -289.656, -681.69806, -1322.3204, true);
                giPlayerSetDir(leader_player_id, 84.0, true);
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
            giArenaLoad("Q02", "Q02", "", true);
            giPlayerCurrentSetPos(-411.3458, 221.3821, 1477.6482);
            giPlayerCurrentSetAng(165.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
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
