// Structured PAL4 reconstruction for Q10.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q10_Q10_init()
{
    LL_001(global_mvar);
    if (global_mvar < 120100 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
    {
        giSetObjectVisible("entrance01", false);
        giSetObjectVisible("entrance02", true);
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("entrance01", true);
        giSetObjectVisible("entrance02", false);
        giArenaReadyRestore();
    }
    if (global_mvar == 110500 /* 第二章 / 7-1-2.水中妖界 / 潜水寻妖 */)
    {
        func2001();
    }
    if (global_mvar != 110600 /* 第二章 / 7-1-3.水中妖界 / 深入妖穴 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4003", false);
        giArenaReadyRestore();
    }
}

void Q10_N05_init()
{
    if (global_mvar != 110600 /* 第二章 / 7-1-3.水中妖界 / 深入妖穴 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("4004", false);
        giArenaReadyRestore();
    }
}

void LL_001(int arg0)
{
    // typed_typeinfo_hints: primary=void; extras=[int]
    // prototype_hint: void LL_001(int)
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giSetNpcVisible("4023", true);
        giSetNpcVisible("4024", true);
        giSetNpcVisible("4025", true);
        giSetNpcVisible("4026", true);
    }
}

void func1001()
{
    giArenaLoad("Q10", "N01", "", true);
    giPlayerCurrentSetPos(-0.093052, 0.0, 291.71033);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(1809.2058, 77.660065, -987.4253);
    giPlayerCurrentSetAng(358.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q10", "n02", "", true);
    giPlayerCurrentSetPos(2.486373, 0.0, 290.50336);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(-1563.9717, 80.55892, -1143.108);
    giPlayerCurrentSetAng(14.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q10", "N03", "", true);
    giPlayerCurrentSetPos(0.949671, 0.609144, 237.43675);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(1618.4366, 80.10167, 1719.8729);
    giPlayerCurrentSetAng(317.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("Q10", "N04", "", true);
    giPlayerCurrentSetPos(-2.880177, 0.500015, 248.98428);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(91.0, 434.0, 240.0);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("Q10", "N05", "", true);
    giPlayerCurrentSetPos(383.43948, 89.999985, -285.06888);
    giPlayerCurrentSetAng(314.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(842.5205, -23.449966, 28.870562);
    giPlayerCurrentSetAng(87.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("Q10", "N06", "N06a", true);
    giPlayerCurrentSetPos(-1.008449, 0.023521, 221.42221);
    giPlayerCurrentSetAng(179.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1012()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(1853.0, -70.0, 1957.0);
    giPlayerCurrentSetAng(358.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1013()
{
    giArenaLoad("Q10", "N06", "N06b", true);
    giPlayerCurrentSetPos(-1.008449, 0.023521, 221.42221);
    giPlayerCurrentSetAng(179.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(1398.6686, -70.66512, 1338.4547);
    giPlayerCurrentSetAng(246.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("Q10", "N06", "N06c", true);
    giPlayerCurrentSetPos(-1.008449, 0.023521, 221.42221);
    giPlayerCurrentSetAng(179.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(2094.105, -71.36399, 1238.6108);
    giPlayerCurrentSetAng(135.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1017()
{
    giArenaLoad("Q10", "N06", "N06d", true);
    giPlayerCurrentSetPos(-1.008449, 0.023521, 221.42221);
    giPlayerCurrentSetAng(179.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1018()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(-1252.2257, -70.36805, -1284.5269);
    giPlayerCurrentSetAng(73.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1019()
{
    giArenaLoad("Q10", "N07", "N07a", true);
    giPlayerCurrentSetPos(-2.219969, 0.181396, 190.23311);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1020()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(2211.8137, -89.06906, -997.84265);
    giPlayerCurrentSetAng(59.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1021()
{
    giArenaLoad("Q10", "N07", "N07b", true);
    giPlayerCurrentSetPos(-2.219969, 0.181396, 190.23311);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1022()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(1410.0487, -89.080475, -979.8973);
    giPlayerCurrentSetAng(300.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1023()
{
    giArenaLoad("Q10", "N07", "N07c", true);
    giPlayerCurrentSetPos(-2.219969, 0.181396, 190.23311);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1024()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(1644.408, -88.842575, -1745.0);
    giPlayerCurrentSetAng(196.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1025()
{
    giArenaLoad("Q10", "N07", "N07d", true);
    giPlayerCurrentSetPos(-2.219969, 0.181396, 190.23311);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1026()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(-1993.0, -70.0, -1135.0);
    giPlayerCurrentSetAng(300.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1027()
{
    giArenaLoad("Q10", "N07", "N07e", true);
    giPlayerCurrentSetPos(-2.219969, 0.181396, 190.23311);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(4, true);
    giArenaReady();
}

void func1028()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(-1774.9841, -70.36805, -1831.2878);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1029()
{
    giArenaLoad("Q10", "N05", "", true);
    giPlayerCurrentSetPos(293.14188, 90.26678, 390.80383);
    giPlayerCurrentSetAng(224.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1030()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(-134.68448, -23.023523, 721.7225);
    giPlayerCurrentSetAng(340.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1031()
{
    giArenaLoad("Q10", "N05", "", true);
    giPlayerCurrentSetPos(-291.17404, 90.27646, 389.6055);
    giPlayerCurrentSetAng(134.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1032()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(-659.79694, -23.506598, -5.619572);
    giPlayerCurrentSetAng(265.1);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1033()
{
    giArenaLoad("Q10", "N05", "", true);
    giPlayerCurrentSetPos(-375.20697, 90.26676, -281.61432);
    giPlayerCurrentSetAng(45.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1034()
{
    giArenaLoad("Q10", "Q10", "", true);
    giPlayerCurrentSetPos(95.50151, -23.889103, -735.4809);
    giPlayerCurrentSetAng(178.1);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1035()
{
    int leader_player_id = 0;

    giPlayerLock();
    giNpcPauseBeh("4020");
    giNpcFaceToCurrentPlayer("4020", true);
    giCurrentPlayerFaceToNpc("4020", true);
    giTalk("耀咚：这里是“巢卫队”的机要重地，快走开！", "");
    giNpcResetDir("4020");
    giNpcResumeBeh("4020");
    leader_player_id = giPlayerGetLeader();
    giPlayerWalkTo(leader_player_id, -1549.469, -71.5628, 1305.638, true);
    giPlayerSetDir(leader_player_id, 135.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giPlayerUnLock();
}

void func1036()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 120100 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
    {
        giArenaLoad("M03", "3", "", true);
        giPlayerCurrentSetPos(798.0918, 37.066, -1942.8013);
        giPlayerCurrentSetAng(260.1);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.去百翎洲  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去百翎洲</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -902.24, -23.23, -29.54, true);
                giPlayerSetDir(leader_player_id, 85.0, true);
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
            giArenaLoad("M03", "3", "", true);
            giPlayerCurrentSetPos(798.0918, 37.066, -1942.8013);
            giPlayerCurrentSetAng(260.1);
            giCameraSetMode(5, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1037()
{
    int select_dialog_last_select = 0;
    int local_3 = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.去东北平台");
    giSelectDialogAddItem("2.去东南平台");
    giSelectDialogAddItem("3.去西北平台");
    giSelectDialogAddItem("4.去西南平台");
    giSelectDialogAddItem("5.什么都不做");
    giSelectDialogSetDefaultSelect(4);
    giShowSelectDialog("  这里是<colour red=255 green=102 blue=0 alpha=255>中央平台</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        switch (select_dialog_last_select)
        {
            case 1:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(2082.5986, -70.65549, 1996.7915);
                giPlayerCurrentSetAng(210.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 2:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(-1910.5986, -70.65549, -1898.7915);
                giPlayerCurrentSetAng(30.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 3:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(-1428.5986, -71.65549, 1207.7915);
                giPlayerCurrentSetAng(310.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            default:
                local_3 = giPlayerGetLeader();
                giPlayerWalkTo(local_3, 491.3452, 264.63718, -284.11523, true);
                giPlayerSetDir(local_3, 300.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
                break;
        }
    }
    else
    {
        giEffectPlayWithCurrentPlayer("H_121", 1);
        gi2DSoundPlay("wc005", 1);
        local_3 = giPlayerGetLeader();
        giPlayerBlendOut(local_3, 0.5, false);
        giWait(0.30000001192092896);
        giFlashOutBlack(0.65, true, true);
        giWait(0.5);
        giPlayerCurrentSetPos(2058.5986, -89.65549, -1833.7915);
        giPlayerCurrentSetAng(335.0);
        giArenaReady();
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giFlashInBlack(0.65, false);
        giWait(0.15000000596046448);
        giEffectPlayWithCurrentPlayer("H_122", 1);
        gi2DSoundPlay("wc006", 1);
        giWait(0.30000001192092896);
        giPlayerBlendIn(local_3, 0.5, false);
        giPlayerUnLock();
    }
}

void func1038()
{
    int select_dialog_last_select = 0;
    int local_3 = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.去中央平台");
    giSelectDialogAddItem("2.去东南平台");
    giSelectDialogAddItem("3.去西北平台");
    giSelectDialogAddItem("4.去西南平台");
    giSelectDialogAddItem("5.什么都不做");
    giSelectDialogSetDefaultSelect(4);
    giShowSelectDialog("  这里是<colour red=255 green=102 blue=0 alpha=255>东北平台</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        switch (select_dialog_last_select)
        {
            case 1:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(2082.5986, -70.65549, 1996.7915);
                giPlayerCurrentSetAng(210.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 2:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(-1910.5986, -70.65549, -1898.7915);
                giPlayerCurrentSetAng(30.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 3:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(-1428.5986, -71.65549, 1207.7915);
                giPlayerCurrentSetAng(310.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            default:
                local_3 = giPlayerGetLeader();
                giPlayerWalkTo(local_3, 2058.5986, -89.65549, -1833.7915, true);
                giPlayerSetDir(local_3, 335.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
                break;
        }
    }
    else
    {
        giEffectPlayWithCurrentPlayer("H_121", 1);
        gi2DSoundPlay("wc005", 1);
        local_3 = giPlayerGetLeader();
        giPlayerBlendOut(local_3, 0.5, false);
        giWait(0.30000001192092896);
        giFlashOutBlack(0.65, true, true);
        giWait(0.5);
        giPlayerCurrentSetPos(491.3452, 264.63718, -284.11523);
        giPlayerCurrentSetAng(300.0);
        giArenaReady();
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giFlashInBlack(0.65, false);
        giWait(0.15000000596046448);
        giEffectPlayWithCurrentPlayer("H_122", 1);
        gi2DSoundPlay("wc006", 1);
        giWait(0.30000001192092896);
        giPlayerBlendIn(local_3, 0.5, false);
        giPlayerUnLock();
    }
}

void func1039()
{
    int select_dialog_last_select = 0;
    int local_3 = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.去中央平台");
    giSelectDialogAddItem("2.去东北平台");
    giSelectDialogAddItem("3.去西北平台");
    giSelectDialogAddItem("4.去西南平台");
    giSelectDialogAddItem("5.什么都不做");
    giSelectDialogSetDefaultSelect(4);
    giShowSelectDialog("  这里是<colour red=255 green=102 blue=0 alpha=255>东南平台</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        switch (select_dialog_last_select)
        {
            case 1:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(2058.5986, -89.65549, -1833.7915);
                giPlayerCurrentSetAng(335.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 2:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(-1910.5986, -70.65549, -1898.7915);
                giPlayerCurrentSetAng(30.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 3:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(-1428.5986, -71.65549, 1207.7915);
                giPlayerCurrentSetAng(310.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            default:
                local_3 = giPlayerGetLeader();
                giPlayerWalkTo(local_3, 2082.5986, -70.65549, 1996.7915, true);
                giPlayerSetDir(local_3, 210.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
                break;
        }
    }
    else
    {
        giEffectPlayWithCurrentPlayer("H_121", 1);
        gi2DSoundPlay("wc005", 1);
        local_3 = giPlayerGetLeader();
        giPlayerBlendOut(local_3, 0.5, false);
        giWait(0.30000001192092896);
        giFlashOutBlack(0.65, true, true);
        giWait(0.5);
        giPlayerCurrentSetPos(491.3452, 264.63718, -284.11523);
        giPlayerCurrentSetAng(300.0);
        giArenaReady();
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giFlashInBlack(0.65, false);
        giWait(0.15000000596046448);
        giEffectPlayWithCurrentPlayer("H_122", 1);
        gi2DSoundPlay("wc006", 1);
        giWait(0.30000001192092896);
        giPlayerBlendIn(local_3, 0.5, false);
        giPlayerUnLock();
    }
}

void func1040()
{
    int select_dialog_last_select = 0;
    int local_3 = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.去中央平台");
    giSelectDialogAddItem("2.去东北平台");
    giSelectDialogAddItem("3.去东南平台");
    giSelectDialogAddItem("4.去西南平台");
    giSelectDialogAddItem("5.什么都不做");
    giSelectDialogSetDefaultSelect(4);
    giShowSelectDialog("  这里是<colour red=255 green=102 blue=0 alpha=255>西北平台</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        switch (select_dialog_last_select)
        {
            case 1:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(2058.5986, -89.65549, -1833.7915);
                giPlayerCurrentSetAng(335.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 2:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(2082.5986, -70.65549, 1996.7915);
                giPlayerCurrentSetAng(210.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 3:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(-1428.5986, -71.65549, 1207.7915);
                giPlayerCurrentSetAng(310.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            default:
                local_3 = giPlayerGetLeader();
                giPlayerWalkTo(local_3, -1910.5986, -70.65549, -1898.7915, true);
                giPlayerSetDir(local_3, 30.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
                break;
        }
    }
    else
    {
        giEffectPlayWithCurrentPlayer("H_121", 1);
        gi2DSoundPlay("wc005", 1);
        local_3 = giPlayerGetLeader();
        giPlayerBlendOut(local_3, 0.5, false);
        giWait(0.30000001192092896);
        giFlashOutBlack(0.65, true, true);
        giWait(0.5);
        giPlayerCurrentSetPos(491.3452, 264.63718, -284.11523);
        giPlayerCurrentSetAng(300.0);
        giArenaReady();
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giFlashInBlack(0.65, false);
        giWait(0.15000000596046448);
        giEffectPlayWithCurrentPlayer("H_122", 1);
        gi2DSoundPlay("wc006", 1);
        giWait(0.30000001192092896);
        giPlayerBlendIn(local_3, 0.5, false);
        giPlayerUnLock();
    }
}

void func1041()
{
    int select_dialog_last_select = 0;
    int local_3 = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.去中央平台");
    giSelectDialogAddItem("2.去东北平台");
    giSelectDialogAddItem("3.去东南平台");
    giSelectDialogAddItem("4.去西北平台");
    giSelectDialogAddItem("5.什么都不做");
    giSelectDialogSetDefaultSelect(4);
    giShowSelectDialog("  这里是<colour red=255 green=102 blue=0 alpha=255>西南平台</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        switch (select_dialog_last_select)
        {
            case 1:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(2058.5986, -89.65549, -1833.7915);
                giPlayerCurrentSetAng(335.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 2:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(2082.5986, -70.65549, 1996.7915);
                giPlayerCurrentSetAng(210.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 3:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.30000001192092896);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(-1910.5986, -70.65549, -1898.7915);
                giPlayerCurrentSetAng(30.0);
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15000000596046448);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.30000001192092896);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            default:
                local_3 = giPlayerGetLeader();
                giPlayerWalkTo(local_3, -1428.5986, -71.65549, 1207.7915, true);
                giPlayerSetDir(local_3, 310.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
                break;
        }
    }
    else
    {
        giEffectPlayWithCurrentPlayer("H_121", 1);
        gi2DSoundPlay("wc005", 1);
        local_3 = giPlayerGetLeader();
        giPlayerBlendOut(local_3, 0.5, false);
        giWait(0.30000001192092896);
        giFlashOutBlack(0.65, true, true);
        giWait(0.5);
        giPlayerCurrentSetPos(491.3452, 264.63718, -284.11523);
        giPlayerCurrentSetAng(300.0);
        giArenaReady();
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giFlashInBlack(0.65, false);
        giWait(0.15000000596046448);
        giEffectPlayWithCurrentPlayer("H_122", 1);
        gi2DSoundPlay("wc006", 1);
        giWait(0.30000001192092896);
        giPlayerBlendIn(local_3, 0.5, false);
        giPlayerUnLock();
    }
}

void func2001()
{
    if (global_mvar == 110500 /* 第二章 / 7-1-2.水中妖界 / 潜水寻妖 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -1148.1266, -39.6084, -23.0769);
        giPlayerSetAng(0, 49.0);
        giPlayerSetPos(1, -1055.6653, -38.5762, -29.1357);
        giPlayerSetAng(1, 73.0);
        giPlayerSetPos(2, -1132.5874, -39.8184, 28.9186);
        giPlayerSetAng(2, 73.0);
        giPlayerSetPos(3, -1116.4216, -38.4687, -82.2077);
        giPlayerSetAng(3, 70.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("title01", false);
        giSetObjectVisible("entrance02", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giCameraRunSingle("003", true);
        giWait(0.800000011920929);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：这些是！……", "44166");
        giCameraRunSingle("002", true);
        giWait(1.0);
        giPlayerSetPos(0, -775.2188, -23.2396, 149.1147);
        giPlayerSetAng(0, 347.0);
        giPlayerSetPos(1, -726.9637, -23.2397, 94.0877);
        giPlayerSetAng(1, 68.0);
        giPlayerSetPos(2, -839.778, -23.2397, 107.8235);
        giPlayerSetAng(2, 92.0);
        giPlayerSetPos(3, -798.8182, -23.2397, 54.5128);
        giPlayerSetAng(3, 71.0);
        giCameraRunSingle("006", false);
        giWait(1.5);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：青铜鼎、青铜人面……这里、这里果然就是殷商居巢国的遗迹啊！", "44167");
        giWait(2.0);
        giCameraWait();
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.5);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：这儿住的全是妖怪？长相都好有趣～", "44168");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(1, 324.0, false);
        giPlayerSetDir(2, 13.0, false);
        giPlayerSetDir(3, 1.0, true);
        giWait(1.0);
        giCameraRunSingle("007", true);
        giWait(0.8);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：妖气重重！果然是妖孽聚集之地！！", "44169");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(3, "J09", -1, false);
        giPlayerSetDir(2, 138.0, false);
        giCameraRunSingle("008", false);
        giWait(1.0);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：紫英，你先把剑收起来，好吗？我看这些妖并没有恶意……", "44170");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerSetDir(3, 324.0, true);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：妖本身即是恶，难道还会存有善念？", "44171");
        giPlayerSetAng(0, 177.0);
        giPlayerSetAng(1, 254.0);
        giCameraWait();
        giCameraRunSingle("009", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：不能这么说吧，像是之前在女萝岩遇到的那几只——", "44172");
        giPlayerEndAction(0);
        giPlayerSetDir(3, 13.0, true);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：寿阳女萝岩？你曾去过那里？", "44173");
        giPlayerWalkTo(1, -757.9064, -23.2397, 76.4068, false);
        giCameraRunSingle("011", false);
        giWait(0.5);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：啊、那个，紫英你说，居巢国里会不会藏着鲲鳞呢？", "44174");
        giPlayerSetDir(3, 56.0, false);
        giPlayerSetDir(2, 100.0, false);
        giPlayerEndMove(1);
        giWait(0.5);
        giCameraRunSingle("012", false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……", "44175");
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：嗯，我觉得有可能，毕竟这里也是灵气汇聚之地，总会有些非同寻常的东西……", "44176");
        giPlayerEndAction(2);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：那，紫英……不如你留下，<colour red=255 green=187 blue=0 alpha=255>我们先去打探打探</colour><dc0>吧？</dc0>", "44177");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：现在就跟这儿的妖翻脸，恐怕不太好……", "44178");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……不必，我跟你们一起去！", "44179");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：虽是以玄霄师叔之事为先，但深入妖类巢穴，绝不可掉以轻心！", "44180");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：……好吧，不到万不得已，我们别和这里的妖起冲突。", "44181");
        giPlayerEndAction(1);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……我明白你的顾虑，只是那些受苦的渔民又当如何……", "44182");
        giWait(0.5);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：………… ", "44183");
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("007", true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4003", false);
        giCameraSetDistOptEnable(true);
        giSetObjectVisible("title01", true);
        giSetObjectVisible("entrance02", true);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 110600; // 0x0001B008, 第二章 / 7-1-3.水中妖界 / 深入妖穴
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 110600 /* 第二章 / 7-1-3.水中妖界 / 深入妖穴 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 158.5856, -23.2397, 907.5616);
        giPlayerSetAng(0, 80.0);
        giPlayerSetPos(1, 151.0559, -23.2397, 989.3309);
        giPlayerSetAng(1, 111.0);
        giPlayerSetPos(2, 160.8992, -23.2397, 1029.6482);
        giPlayerSetAng(2, 120.0);
        giPlayerSetPos(3, 110.9483, -23.2397, 933.0226);
        giPlayerSetAng(3, 88.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("MN003", true);
        giSetNpcVisible("MN004", true);
        giSetNpcVisible("MN005", true);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, false);
        giWait(0.8);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：你们快看，那是……", "44184");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giCameraRunSingle("003", true);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：呀～是槐米它们！", "44185");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("004", false);
        giNpcWalkTo("MN002", 249.8293, -23.2396, 977.3583, false);
        giNpcWalkTo("MN005", 263.9647, -23.2397, 923.1479, false);
        giNpcWalkTo("MN001", 317.9468, -23.2397, 950.0634, false);
        giNpcWalkTo("MN003", 280.2879, -23.2396, 901.6661, false);
        giNpcWalkTo("MN004", 310.573, -23.2397, 917.3267, false);
        giNpcEndMove("MN005");
        giNpcSetDir("MN005", 311.0, true);
        giNpcEndMove("MN001");
        giNpcSetDir("MN001", 304.0, true);
        giNpcEndMove("MN003");
        giNpcSetDir("MN003", 315.0, true);
        giNpcEndMove("MN004");
        giNpcSetDir("MN004", 320.0, true);
        giSetPortrait("208A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐枝：喵喵～你们怎么会来居巢国？", "44186");
        giSetPortrait("107B", true);
        giTalk("柳梦璃：槐枝～还能再见到你，真是太好了，你们——", "44187");
        giNpcSetDir("MN005", 331.0, true);
        giSetPortrait("207B", false);
        giTalk("槐米：槐枝，快退后！", "47005");
        giScriptMusicPlay("P36", 2, 0.0, 0.0);
        giNpcSetDir("MN002", 169.0, false);
        giCameraRunSingle("006", true);
        giSetPortrait("208A", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐枝：喵？老大？", "44188");
        giSetPortrait("207B", false);
        giTalk("槐米：快！你没看见那个人吗？！就是他杀了爹和娘！", "44189");
        giPlayerSetAng(3, 79.0);
        giNpcSetDir("MN005", 294.0, false);
        giNpcSetDir("MN002", 229.0, false);
        giNpcSetDir("MN003", 303.0, false);
        giNpcSetDir("MN001", 268.0, false);
        giNpcSetDir("MN004", 298.0, false);
        giCameraRunSingle("007", true);
        giWait(0.5);
        giPlayerSetDir(1, 212.0, false);
        giPlayerSetDir(0, 307.0, false);
        giCameraWait();
        giSetPortrait("208B", true);
        giTalk("槐枝：对！是他，就是他！把爹和娘都害死了！", "44190");
        giIMMBegin();
        giPlayerSetPos(0, 173.7754, -23.2397, 917.0107);
        giPlayerSetPos(1, 152.4826, -23.2397, 997.929);
        giPlayerSetPos(2, 196.0055, -23.2397, 1033.9182);
        giPlayerSetAng(0, 300.0);
        giPlayerSetAng(1, 217.0);
        giPlayerSetAng(2, 209.0);
        giNpcSetPos("MN001", 282.4263, -23.2397, 976.0644);
        giNpcSetPos("MN002", 240.4005, -23.2397, 987.8947);
        giNpcSetPos("MN003", 251.3761, -23.2397, 932.7255);
        giNpcSetPos("MN004", 288.0689, -23.2397, 947.8329);
        giNpcSetPos("MN005", 230.8, -23.2397, 957.0392);
        giNpcSetAng("MN001", 260.0);
        giNpcSetAng("MN002", 242.0);
        giNpcSetAng("MN003", 294.0);
        giNpcSetAng("MN004", 280.0);
        giNpcSetAng("MN005", 280.0);
        giIMMEnd();
        giWait(0.5);
        giCameraRunSingle("009", true);
        giPlayerDoAction(3, "J31", -1, false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：我道是谁？原来是女萝岩的妖孽，竟还有漏网之鱼！", "44191");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：紫英，你听我说——", "44192");
        giPlayerEndAction(1);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：也好！今日我就在此斩草除根！", "44193");
        giSetPortrait("107E", true);
        giTalk("柳梦璃：……！", "44194");
        giCameraRunSingle("010", true);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102H", false);
        giTalk("云天河：紫英，住手！", "44195");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerSetDir(3, 90.0, true);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：……天河，你是什么意思？", "44196");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102H", false);
        giTalk("云天河：槐米它们是朋友！", "44197");
        giPlayerEndAction(0);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：什么？！可笑！人与妖岂能做朋友？", "44198");
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：这些妖物曾于女萝岩伤人，如今又潜伏在湖底，伺机拖人溺水，你竟还要回护它们？！", "44199");
        giPlayerEndAction(3);
        giCameraRunSingle("008", true);
        giWait(0.8);
        giSetPortrait("207B", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵！你乱讲！", "44200");
        giSetPortrait("207B", true);
        giTalk("槐米：是那些人自己不小心掉进漩涡里，才不是我们害的，我和其他妖还好心把他们推上岸！", "44201");
        giPlayerSetAng(3, 80.0);
        giCameraRunSingle("009", true);
        giWait(0.5);
        giPlayerDoAction(3, "J13", -1, false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：妖会救人？！一派胡言！", "44202");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107G", true);
        giTalk("柳梦璃：……紫英，上天有好生之德，它们尚且年幼——", "44203");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：就算年幼无识，长大之后一样要去害人！", "44204");
        giPlayerEndAction(3);
        giSetPortrait("207B", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵喵！我们从来没有害过人！只有人来害我们！", "44205");
        giSetPortrait("105F", true);
        giTalk("慕容紫英：哼！那在女萝岩伤人之事又如何说？", "44206");
        giIMMBegin();
        giPlayerSetAng(3, 125.0);
        giCameraRunSingle("012", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("102H", false);
        giTalk("云天河：紫英，人为了填饱肚子，为了保护自己，杀死其他动物、甚至是杀妖怪也没什么，但槐米它们又没做错事，就算它们的爹娘伤过寿阳城的人，这也是两回事，怎么能无缘无故把它们杀了！", "44207");
        giCameraRunSingle("015", false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：此时不除去它们，待日后强大起来岂不追悔莫及？！", "44208");
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("102H", false);
        giTalk("云天河：要是让你在这里痛下杀手，我才真要后悔！", "44209");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：……你让开！", "44210");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102I", false);
        giTalk("云天河：不可能！", "44211");
        giPlayerEndAction(0);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：你！！", "44212");
        giPlayerSetPos(2, 180.2735, -23.2397, 997.0955);
        giPlayerSetAng(2, 227.0);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：紫英，你冷静一下！", "44213");
        giPlayerSetDir(3, 35.0, false);
        giIMMBegin();
        giPlayerSetPos(1, 141.6121, -23.2397, 970.3624);
        giPlayerSetAng(1, 228.0);
        giCameraRunSingle("016", true);
        giIMMEnd();
        giWait(0.7);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：为什么你只当妖都是恶的，人都是善的？难道就没有例外？", "44214");
        giPlayerEndAction(1);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：菱纱！怎么连你也……", "44215");
        giCameraRunSingle("017", true);
        giPlayerSetDir(3, 106.0, true);
        giWait(1.0);
        giPlayerSetDir(3, 61.0, true);
        giWait(0.5);
        giPlayerWalkTo(2, 185.5124, -23.2397, 974.1346, true);
        giPlayerSetDir(2, 240.0, true);
        giWait(0.5);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：……你们，都要拦我？！", "44216");
        giWait(0.5);
        giSetPortrait("107F", false);
        giTalk("柳梦璃：紫英……", "44217");
        giSetPortrait("105F", true);
        giTalk("慕容紫英：好、好！", "44218");
        giPlayerDoAction(3, "J13", -1, false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：看来只有我一人最是奇怪！道不同不相为谋，今日你们在此，我不必硬来，就此别过！", "44219");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerWalkTo(3, -16.3052, -23.2396, 995.7963, false);
        giWait(1.5);
        giPlayerSetDir(0, 302.0, false);
        giPlayerSetDir(1, 303.0, false);
        giPlayerSetDir(2, 295.0, true);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102H", false);
        giTalk("云天河：紫英——！", "44220");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerEndMove(3);
        giPlayerSetVisible(3, false);
        giSetPortrait("104H", false);
        giTalk("韩菱纱：……", "44221");
        giPlayerOutTeam(3, false);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P34", 2, 0.0, 2.5);
        giWait(1.0);
        giSetPortrait("207B", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵！", "44222");
        giCameraRunSingle("020", false);
        giPlayerSetDir(2, 97.0, false);
        giPlayerWalkTo(0, 220.111, -23.2397, 883.4877, false);
        giPlayerWalkTo(1, 182.2587, -23.2397, 922.0876, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 19.0, false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 59.0, false);
        giNpcSetDir("MN005", 194.0, false);
        giNpcSetDir("MN002", 197.0, false);
        giNpcSetDir("MN003", 220.0, false);
        giNpcSetDir("MN004", 236.0, false);
        giNpcSetDir("MN001", 219.0, true);
        giSetPortrait("102G", true);
        giTalk("云天河：……对不起，紫英他、他是我的朋友，就算你们说要报仇，我也会阻止……", "44223");
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵！你是你，他是他！朋友还是朋友，仇人还是仇人！", "44224");
        giSetPortrait("208A", false);
        giTalk("槐枝：老大说的对，我们现在还小，长大以后要靠自己去报仇！", "44225");
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("104H", true);
        giTalk("韩菱纱：为什么……会变成这样……", "44226");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("021", false);
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：……喵，你们几个，为什么要来居巢国？", "44227");
        giSetPortrait("104H", true);
        giTalk("韩菱纱：本来……是想查清楚近日妖怪伤人的事……而且我们还要找一种叫作“鲲鳞”的东西……", "44228");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：你们呢？又怎会住在这里？", "44229");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giNpcSetDir("MN002", 255.0, false);
        giNpcSetDir("MN005", 284.0, false);
        giNpcSetDir("MN003", 292.0, false);
        giNpcSetDir("MN004", 277.0, false);
        giNpcSetDir("MN001", 265.0, true);
        giSetPortrait("208A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐枝：喵～老大带我们离开女萝岩之后，遇到其他好心的妖，就告诉我们可以来这儿。", "44230");
        giSetPortrait("208A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐枝：喵～这边的妖很多，但是大家都很好，不会随便伤人的。", "44231");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：离开女萝岩之后，我常常担心你们。现在看到你们都平安无事，终于可以放心了。", "44232");
        giPlayerEndAction(2);
        giSetPortrait("208A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐枝：喵～谢谢，你是好人！", "44233");
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：……喵！你们说的鲲鳞，是不是一种大鱼的鳞片？", "44234");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：是啊！槐米，你怎么知道？", "44235");
        giPlayerEndAction(0);
        giNpcSetDir("MN005", 194.0, true);
        giSetPortrait("207A", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵！我听居巢国的长老说起过，我帮你们去问他！", "44236");
        giSetPortrait("207A", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：跟我来！喵！", "44237");
        giNpcWalkTo("MN002", 282.8506, -23.2396, 950.4028, false);
        giNpcWalkTo("MN005", 263.9647, -23.2397, 923.1479, false);
        giNpcWalkTo("MN003", 280.2879, -23.2396, 901.6661, false);
        giNpcWalkTo("MN004", 310.573, -23.2397, 917.3267, false);
        giNpcWalkTo("MN001", 317.9468, -23.2397, 950.0634, false);
        giCameraRunSingle("022", false);
        giWait(1.0);
        giPlayerSetDir(0, 48.0, false);
        giPlayerSetDir(1, 75.0, true);
        giNpcEndMove("MN005");
        giNpcSetDir("MN005", 290.0, true);
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵！跟上跟上～", "44238");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：……这样，真的可以吗？上次还送给我们土灵珠……", "44239");
        giPlayerEndAction(2);
        giSetPortrait("207A", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵！我说了，朋友是朋友，仇人是仇人，朋友有困难，一定要帮！", "44240");
        giSetPortrait("207A", true);
        giTalk("槐米：快来！我带弟弟先去<colour red=255 green=187 blue=0 alpha=255>长老家</colour><dc0>了，</dc0><colour red=255 green=187 blue=0 alpha=255>在这层平台的最上层</colour><dc0>，你们一会儿就过来，我会告诉其他妖，你们不是敌人！喵～</dc0>", "44241");
        giNpcWalkTo("MN005", 350.8419, -23.2397, 921.0679, false);
        giNpcWalkTo("MN002", 354.9425, -23.2397, 951.9946, false);
        giNpcWalkTo("MN004", 389.6746, -23.2397, 921.4142, false);
        giNpcWalkTo("MN001", 389.7277, -23.2397, 955.0984, false);
        giNpcWalkTo("MN003", 355.0172, -23.2397, 895.436, false);
        giWait(1.0);
        giCameraRunSingle("023", true);
        giPlayerSetDir(0, 61.0, false);
        giWait(2.0);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：谢谢，我的朋友……", "44242");
        giWait(0.6);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：它们……都是这样善良，和人没有分别，为什么……紫英就是不能明白呢？", "44243");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("102E", true);
        giTalk("云天河：…………", "44244");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN004", false);
        giSetNpcVisible("MN005", false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("4001", true);
        giSetNpcVisible("4003", true);
        giPlayerCurrentSetPos(42.4877, -23.2396, 789.2406);
        giPlayerCurrentSetAng(106.0);
        giPlayerCurrentSetVisible(true);
        giIMMEnd();
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 110700; // 0x0001B06C, 第二章 / 7-2-1.相争难休 / 前去长老家
        giPlayerUnLock();
        giFlashInBlack(1.0, true);
    }
}

void func2003()
{
    if (global_mvar == 110700 /* 第二章 / 7-2-1.相争难休 / 前去长老家 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P25", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 169.1609, 434.3184, 238.2312);
        giPlayerSetAng(0, 259.0);
        giPlayerSetPos(1, 125.9393, 434.3184, 275.9218);
        giPlayerSetAng(1, 207.0);
        giPlayerSetPos(2, 62.6448, 434.3184, 232.6373);
        giPlayerSetAng(2, 105.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("MN006", true);
        giIMMEnd();
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giCameraRunSingle("002", false);
        giNpcWalkTo("MN006", 93.4618, 434.3184, 186.7377, false);
        giSetPortrait("207A", false);
        giTalk("槐米：……", "44245");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：怎么了？是不是长老也不知道鲲鳞的下落？", "44246");
        giNpcEndMove("MN006");
        giNpcSetDir("MN006", 22.0, true);
        giSetPortrait("207A", false);
        giTalk("槐米：……", "44247");
        giSetPortrait("107A", true);
        giTalk("柳梦璃：……没关系的，别难过，最多我们再去其他地方找——", "44248");
        giWait(0.3);
        giSetObjectVisible("MO001", true);
        giWait(0.4);
        giCameraRunSingle("003", false);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：这是……？", "44249");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵，长老说……他很感激你们帮过妖，很少会有人对妖这么好，他愿意把自己搜集的鲲鳞送给你们，作为报答……", "44250");
        giWait(0.5);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：真的吗？太好了！", "44251");
        giPlayerEndAction(0);
        giNpcSetDir("MN006", 60.0, true);
        giSetPortrait("207A", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵……这个东西寒气好重，要不是长老在上面施了法，我根本拿不了……", "44252");
        giWait(0.5);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：辛苦你了，槐米！还有，谢谢你们的长老！", "44253");
        giPlayerDoAction(0, "J03", -1, true);
        giWait(0.3);
        giSetObjectVisible("MO001", false);
        giAddProperty(3110, 1, true);
        giWait(2.1);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giNpcSetDir("MN006", 318.0, true);
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：不过，喵，长老还说……他说……", "44254");
        giSetPortrait("102A", false);
        giTalk("云天河：……？", "44255");
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：……他说和你们一起来的那个人太危险了，喵，所以他也不欢迎你们留下，请你们快点离开居巢国……", "44256");
        giWait(0.7);
        giCameraRunSingle("007", true);
        giPlayerWalkTo(2, 72.7665, 434.3184, 225.5882, true);
        giPlayerDoAction(2, "J03", -1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：槐米……你是在替我们难过吗？", "44257");
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵……", "44258");
        giSetPortrait("107B", true);
        giTalk("柳梦璃：这没什么的，长老他愿意帮忙，已经令人感激不尽了。", "44259");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：对啊，而且长老虽然让我们赶快走，但也没有强行驱赶，说不定下回我们偷偷溜进来找你玩，他也会睁只眼闭只眼的。", "44260");
        giPlayerEndAction(1);
        giNpcSetDir("MN006", 22.0, true);
        giSetPortrait("207A", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵～那你们一定要再来哦……", "44261");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：当然，一定来！", "44262");
        giPlayerEndAction(0);
        giCameraRunSingle("005", true);
        giWait(0.8);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：嗯……不过有件事我还是不明白，槐米你说湖里的妖不会伤人，那些人是自己溺水的，可是为什么会突然有这么多人溺水呢？", "44263");
        giWait(0.5);
        giNpcSetDir("MN006", 318.0, true);
        giWait(0.3);
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵，那是因为湖上多了好多漩涡，船划到附近就会被卷走。", "44264");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：这更奇怪了，我以前来过巢湖附近，那个时候没听说有这些漩涡啊……", "44265");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcSetDir("MN006", 22.0, true);
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵，我听长老说，这就像月亮和潮汐的道理，因为有个巨大的岛从巢湖上空飞过，湖面才会变成这样，要过段日子才能恢复以前的样子。", "44266");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：巨大的……岛？那是什么？", "44267");
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵……我不知道。", "44268");
        giSetPortrait("107A", true);
        giTalk("柳梦璃：……这样说来，渔民要更小心才是……", "44269");
        giPlayerSetDir(2, 56.0, true);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：嗯……不如我赶回寿阳一趟，请裴大哥在城中发个告示，另外派人通知附近村子的渔民，最好先在家中歇息一段日子，少挣的钱就由县衙补贴他们吧。", "44270");
        giIMMBegin();
        giPlayerSetAng(1, 245.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：这是个好办法！由官府出面，也很容易就能破除妖怪害人的传言，想个稳妥些的理由就行。", "44271");
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：<colour red=255 green=187 blue=0 alpha=255>那我们快些回岸上吧，</colour><dc0>兵分两路，我和天河把鲲鳞送回琼华派，梦璃就去寿阳。</dc0>", "44272");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：好。", "44273");
        giWait(0.5);
        giSetPortrait("207A", true);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵～～～", "44274");
        giPlayerSetDir(2, 115.0, false);
        giPlayerSetDir(1, 207.0, false);
        giCameraRunSingle("007", true);
        giWait(0.8);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：槐米，我们走了，这次多谢了。下次再来看你，还有其他弟弟们。", "44275");
        giNpcSetDir("MN006", 318.0, true);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：对了，我会带很多很多离香草给你们～", "44276");
        giSetPortrait("207A", false);
        gi2DSoundPlay("WJ019", 1);
        giTalk("槐米：喵，说话要算话哦！", "44277");
        giSetPortrait("207A", false);
        giTalk("槐米：我和弟弟永远把你们当要好的朋友！", "44278");
        giPlayerDoAction(2, "C08", 1, true);
        giCameraRunSingle("004", true);
        giWait(0.8);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：（……要好的……朋友……吗……）", "44279");
        giFlashOutBlack(1.5, true, true);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giSetNpcVisible("MN006", false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("MN001", false);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(137.312, 434.318, 274.937);
        giPlayerCurrentSetAng(230.76);
        giCameraSetMode(0, true);
        global_mvar = 110701; // 0x0001B06D, 第二章 / 7-2-2.相争难休 / 离开居巢国 / 水下居巢
        giPlayerUnLock();
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("飓夕：最近又来了许多妖，以后这里一定会更热闹，变成一个群妖聚集的好地方～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("飓夕：咦？！一定是有认识的妖给你们带路吧？不然居巢国怎么会有人进来？");
        giRandTalkPush("飓夕：居巢国有东南西北中五个区域，站在小平台上的圆圈里，一瞬间就能去别的区域了，最适合用来做游戏～");
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
    giRandTalkRelease();
    giRandTalkPush("燎翼：麻烦你们收好兵器，这里的妖大多都很弱小，受不起惊吓。");
    giRandTalkPush("燎翼：居巢国的妖都不希望和外界起任何冲突，只想平平静静过日子，你们只要不伤害这里的妖，我们就能共处。");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("卫英：最近都没什么人再溺水了，我们“巢卫队”也轻松很多，不然每次都把他们送回岸边，也够累的……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("卫英：身为“巢卫队”的一员，就要以护卫居巢国为头等大事，时刻警惕有没有恶人入侵，这是队长对我们说的！");
        giRandTalkPush("卫英：你也想加入“巢卫队”？虽然你是槐米他们的朋友，但是队长说过，人到底不可信，我们“巢卫队”只收妖，不收人～");
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
    giCurrentPlayerFaceToNpc("4004", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("冰儿：来投奔居巢国的妖越来越多，看来世上还是有不少和我一样、不喜欢争斗的妖～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("冰儿：居巢国以前只是沉入湖底的古城，是巢祖带着一群能干的妖怪，把它修建成现在这样，后来我们就给巢祖建了一座神殿～");
        giRandTalkPush("冰儿：你们就是槐米的朋友？还救过他们？看来人有坏的，也有好的，好人就可以和我们做朋友～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4004");
    giPlayerUnLock();
}

void func4005()
{
    giPlayerLock();
    giNpcPauseBeh("4005");
    giNpcFaceToCurrentPlayer("4005", true);
    giCurrentPlayerFaceToNpc("4005", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("絮烨：我看得多修几间房子了，不然妖越来越多，怎么住得下？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("絮烨：这儿很平静，没有大妖怪来欺负我们，一般人又进不来，不修炼也没关系，是我最喜欢的悠闲日子～");
        giRandTalkPush("絮烨：我们虽然不欢迎人，但如果是愿意和妖做朋友的，就另当别论了。");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("麻八：这段时间居巢国来了很多妖，一下子热闹起来了。以前只有我和铁钳两个玩捉迷藏，现在有好多妖怪能和我们一起玩！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("麻八：我就奇怪了～你们是怎么和槐米认识的？一般人不是都不会和妖往来吗？当然，妖也不喜欢人就是了。");
        giRandTalk();
        giRandTalkRelease();
    }
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
        giRandTalkPush("大耳茸：唉，今天又做错事，被“巢卫队”的老大骂了，他的语气就不能好一点吗？……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("大耳茸：以前我住在山上，本事不大，总是被山里的大妖怪欺负，现在搬到水里来，潮是潮了点，总算不被欺负了～");
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
        giRandTalkPush("丝米：其实妖喜欢上人，也是说不清道理的……只是人的寿命那么短，到头来最痛苦的还是我们妖啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("丝米：影棘上回带了个人类女子回来，从此就一直和她住在一块儿。那女的长得是不错啦～细皮嫩肉的，但是毕竟是人哎！影棘的想法还真古怪！");
        giRandTalkPush("丝米：大家都说我们妖会魅惑人，其实人也会魅惑妖，影棘现在不就被他上次救回来的女子迷得七荤八素嘛～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4008");
    giNpcResumeBeh("4008");
    giPlayerUnLock();
}

void func4009()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4009");
    giNpcFaceToCurrentPlayer("4009", true);
    giCurrentPlayerFaceToNpc("4009", true);
    if (global_mvar >= 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("沐璇：这儿的妖怪从来不会特别为难我，他们只是看起来有点可怕，其实心地都很善良。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giTalk("沐璇：当初我被黄天霸逼婚，无路可走只好投湖自尽……多亏影棘救了我，日子一久，我们之间便有了感情……", "");
        }
        else
        {
            giTalk("沐璇：……啊？！你们也是人？", "");
            giSetPortrait("102A", true);
            giTalk("云天河：对啊，你是不小心掉下来的吗？", "");
            giTalk("沐璇：嗯……我被一个妖救了，喜欢上了他，我不在乎他是什么，只要能跟他今生今世在一起，我就心满意足了……所以不管你们是谁，求求你们别伤害这里的妖……", "");
        }
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
        giRandTalkPush("霓蝶：这阵子居巢国来了许多妖怪，有几个身上还带着伤，大概是在外头被欺负了，才逃到我们这儿来。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("霓蝶：其实妖怪也会生病受伤，生病受伤了也都要用药～这用的药呢～也和你们人用的差不多～");
        giRandTalkPush("霓蝶：沐璇是我见过的所有人中最最好的了，经常到我店里来帮忙不说，做了点心还不忘给我带一份～");
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
        giRandTalkPush("哧溜：本以为住这儿的妖越来越多，随便找几个偷点东西就能过活，没想到“巢卫队”管得挺严，成天被他们盯着，想做点坏事还真难！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("哧溜：哎？又有人来啊？最近来居巢国的“人”也多起来，上回还看见影棘带了一个人类女子进来，这一待就再也不走了～");
        giRandTalkPush("哧溜：有一回我偷了别的妖的东西，不巧被他发现，当时我拔起所有的腿就跑，他追也追不上，嘿嘿！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4011");
    giPlayerUnLock();
}

void func4012()
{
    giPlayerLock();
    giNpcPauseBeh("4012");
    giNpcFaceToCurrentPlayer("4012", true);
    giCurrentPlayerFaceToNpc("4012", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("河颐：我真正的兴趣不是开店，而是像人一样，开个学堂，教所有的妖认字～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("河颐：这里有许多殷商时留下的古物，刻着奇怪文字的龟板瓦片和青铜器，上面记载着制造青铜器的方法，我估计啊～所有的妖里大概也只有我能读懂这些字了～");
        giRandTalk();
        giRandTalkRelease();
    }
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("泱瑢：一、二、三，开吃！……哇，好难吃～我做的糯米团子怎么总也不像沐璇做的那么好吃～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("泱瑢：沐璇做的糯米团子真好吃，有豆沙馅的，枣子馅的，还有桂花白糖的，连形状都小巧玲珑～");
        giRandTalkPush("泱瑢：其实像我们这些小妖只要能够吃饱睡足就够了，哪里会想到去害人！很多事情，都是那些大妖怪做的，也算在我们头上……");
        giRandTalkPush("泱瑢：既然你们帮过槐米他们，那么应该不是坏人，只是有两三个好人有什么用？大多数人还不是很讨厌妖怪……");
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
        giRandTalkPush("琰矍：最近巡逻的时候都没看见什么人落水了，这是好事，我们也省去麻烦～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("琰矍：我们“巢卫队”的成员，为了能保护居巢国的大家，每天都在用心修炼～我今天就是奉了队长之命，到铁钺铜爵来买练习用的兵器的！");
        giRandTalkPush("琰矍：看在你们救过妖的份上，“巢卫队”不会和你们为敌，但如果有一天你们伤了居巢国的妖，“巢卫队”一定不会罢休！");
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
        giRandTalkPush("碧岫栖：越来越多的妖来我们居巢国住了，那都是因为这里没有谁会欺负谁，更没有人来骚扰～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("碧岫栖：听长老说，当初巢祖为我们建好这个水底宫殿后，就游方四海去了，要是他现在回来，见到大家过得好好的，一定也好开心。");
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
        giRandTalkPush("花红焱：铁钺铜爵的河颐常说他要开什么书院，还说要教大家念龟壳瓦片上的字～那种东西，有什么好念的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("花红焱：这大锅上面歪歪扭扭刻的什么呀？比我随便画的还丑！");
        giRandTalkPush("花红焱：人还真奇怪，总喜欢把想法什么的用字记下来，哪像我们，从来都不用这样……啊！对了，是他们的记性太差啦～");
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
        giRandTalkPush("影棘：这么多妖都喜欢我家沐璇的糯米团子，如果我们像人一样开一间团子铺，生意一定很红火～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("影棘：自从我遇到沐璇的那天起，我就喜欢上她了！我发誓要永远和她在一起，她若死了，我就和她一起死!");
        giRandTalkPush("影棘：我家的沐璇很温柔，长得也漂亮，而且还会做好吃的糯米团子，这里的妖都挺喜欢她～");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("淼森：长老平时很少露面，看起来不管事，但发生在居巢国的大小事情，没有他不知道的。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("淼森：人界珍宝虽多，又哪有我们这里的稀罕？你见过像手掌大小的珍珠吗？光这一颗在人界可就价值连城呢～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4018");
    giNpcResumeBeh("4018");
    giPlayerUnLock();
}

void func4019()
{
    giPlayerLock();
    giNpcPauseBeh("4019");
    giCurrentPlayerFaceToNpc("4019", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4019", true);
        giRandTalkRelease();
        giRandTalkPush("曲酊：不断有其他地方的妖迁来，大家都想在这里定居，我们“巢卫队”的责任也越来越重了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giNpcFaceToNpc("4019", "4020", true);
        giNpcFaceToNpc("4020", "4019", true);
        giTalk("曲酊：老弟，我说我们这差事还真不错，又清闲又威风～", "");
        giTalk("耀咚：清闲是清闲，只是我加入“巢卫队”也有好久了，不知道什么时候才能受到队长重用呢……", "");
        giTalk("曲酊：别白日做梦了～就我们这样，连只鸡都不敢杀的，还想受重用？还是安分点，做好份内的事就行～", "");
        giTalk("耀咚：我不过随口说说……只是看着队长他们都在里头议事，我们却在门口守着，心里不是滋味……", "");
    }
    giNpcResetDir("4019");
    giNpcResetDir("4020");
    giNpcResumeBeh("4019");
    giPlayerUnLock();
}

void func4020()
{
    giPlayerLock();
    giNpcPauseBeh("4020");
    giNpcFaceToCurrentPlayer("4020", true);
    giCurrentPlayerFaceToNpc("4020", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("耀咚：要是以后这里的妖更多了，不知道我这守卫还当不当得成？希望不会有其他妖怪来和我抢……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("耀咚：这里是“巢卫队”的机要重地，快走开！");
        giRandTalk();
        giRandTalkRelease();
    }
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("咕噜：这里的妖比从前多了，“巢卫队”也正打算增添人手，我想加入，就是不知道队长收不收我……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("咕噜：要是真有什么剑仙来了居巢国，“巢卫队”应该也没什么用吧？他们其实也都是弱小的妖怪……不过比我强了一点点……");
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
        giRandTalkPush("铁钳：最近和我一起玩捉迷藏的妖越来越多，能躲的地方就越来越少，三下两下全都被找到，真没意思～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("铁钳：啊！你怎么找到我的！我正在和别的妖玩捉迷藏，你可千万不要对别的妖说见过我！");
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
    giRandTalkRelease();
    giRandTalkPush("普尖：我修炼成妖也才半年，法力都没多少，怎么和人斗？还好找到这么一个容身之所，以后再也不用怕会被人打死。");
    giRandTalkPush("普尖：这里好是好，可惜没人血可吸，虽然我已经修炼成妖，不用吸血也能活，但总觉得不习惯……");
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
    giRandTalkPush("阿萍：我正在和大家玩捉迷藏，可是我刚到这里没几天，都不知道该藏哪儿～怎么办呢？");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4024");
    giNpcResumeBeh("4024");
    giPlayerUnLock();
}

void func4025()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4025");
    giCurrentPlayerFaceToNpc("4025", true);
    random_1_4 = giGetRandnum(1, 4);
    if (random_1_4 != 2)
    {
        giNpcFaceToCurrentPlayer("4025", true);
        giTalk("癞头：这地方好就好在不会有什么剑仙、道士来捉妖，只要不用东躲西藏地过日子，就比什么都好！", "");
    }
    else
    {
        giNpcFaceToNpc("4025", "4026", true);
        giNpcFaceToNpc("4026", "4025", true);
        giTalk("癞头：哇～你看，这里好宽敞好漂亮啊！以前在人界我只能住在山洞中，从来都没待过这么华丽的地方！", "");
        giTalk("冥丝阴风：真是没见过世面！我皇宫都去过，那才叫富丽堂皇，到处都是奇珍异宝！不过嘛……作为一个容身之所，这里也马马虎虎啦。", "");
    }
    giNpcResetDir("4025");
    giNpcResetDir("4026");
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
    giRandTalkPush("冥丝阴风：听说这里的“巢卫队”正在招人手哎～我打定主意去了，凭我的实力～一定能行！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("4026");
    giNpcResumeBeh("4026");
    giPlayerUnLock();
}

void func5001()
{
    giPlayerLock();
    giNpcPauseBeh("5001");
    giNpcFaceToCurrentPlayer("5001", true);
    giCurrentPlayerFaceToNpc("5001", true);
    giStartTradeSystem("shop006", "");
    giNpcResetDir("5001");
    giNpcResumeBeh("5001");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("5002");
    giNpcFaceToCurrentPlayer("5002", true);
    giCurrentPlayerFaceToNpc("5002", true);
    if (maze_var5 != 0)
    {
        if (maze_var5 != 1)
        {
            giStartTradeSystem("shop016", "");
        }
        else
        {
            if (giCheckPackProperty(3178, 1))
            {
                giTalk("火焱：没错没错，就是这个东西，让我好好钻研一番～", "");
                giDelProperty(3178, 1, true);
                giWait(2.0);
                giTalk("火焱：嗯～给你，这是我参悟所得，另外这个玲珑珊瑚，就当是换你的灵骨突吧。", "");
                giAddPrescription(8077, true);
                giWait(2.0);
                giAddPrescription(8159, true);
                giWait(2.0);
                giAddEquipment(3688, true);
                giWait(2.0);
                maze_var5 = 2;
            }
            giStartTradeSystem("shop016", "");
        }
    }
    else
    {
        giStartTradeSystem("shop016", "Buiness_Q10_5002");
    }
    giNpcResetDir("5002");
    giNpcResumeBeh("5002");
    giPlayerUnLock();
}

void func5003()
{
    bool has_property_3174 = false;
    bool has_property_3169 = false;

    giPlayerLock();
    giNpcPauseBeh("5003");
    giNpcFaceToCurrentPlayer("5003", true);
    giCurrentPlayerFaceToNpc("5003", true);
    if (maze_var6 != 0)
    {
        if (maze_var6 != 1)
        {
            giStartTradeSystem("shop027", "");
        }
        else
        {
            has_property_3174 = giCheckPackProperty(3174, 10);
            has_property_3169 = giCheckPackProperty(3169, 10);
            if (giCheckPackProperty(3174, 10) && has_property_3169)
            {
                giTalk("河颐：哈哈，正是这些兽皮和木炭没错！这回终于能开书院啦！现在先清理一下铺子，等我把铺子里所有的石头都卖完了，就安心开书院。", "");
                giDelProperty(3169, 10, true);
                giWait(2.0);
                giDelProperty(3174, 10, true);
                giWait(2.0);
                gi2DSoundPlay("WA06", 1);
                giShowHint("开启新交易品", 0.5, 0.15);
                giWait(2.0);
                maze_var6 = 2;
            }
            giStartTradeSystem("shop027", "");
        }
    }
    else
    {
        giStartTradeSystem("shop027", "Buiness_Q10_5003");
    }
    giNpcResetDir("5003");
    giNpcResumeBeh("5003");
    giPlayerUnLock();
}

void func5004()
{
    int inn_dialog_result = 0;

    giPlayerLock();
    giNpcPauseBeh("5004");
    giNpcFaceToCurrentPlayer("5004", true);
    giCurrentPlayerFaceToNpc("5004", true);
    giShowInnDialog(false);
    inn_dialog_result = giGetInnDialogResult();
    if (giGetInnDialogResult() == 1)
    {
        giFlashOutBlack(3.0, true, true);
        giPlayerTakeARest();
        giWait(2.0);
        giFlashInBlack(3.0, true);
    }
    giPlayerSetAttr(-1, -1, 100);
    giNpcResetDir("5004");
    giNpcResumeBeh("5004");
    giPlayerUnLock();
}

void Buiness_Q10_5002()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("我听说<colour red=255 green=187 blue=0 alpha=255>百翎洲巨鸟身上的灵骨突</colour><dc0>蕴涵着特别的灵力，如果你能帮我找一块来，我可以教你使用其中灵力的方法。</dc0><br/><dc0>你愿意帮我去找一块来吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var5 = 1;
    }
}

void Buiness_Q10_5003()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("这居巢国中，青铜鼎上记述着无数前朝旧事，却只有我才能看懂，实在无趣得很，不如开间书院，教大家都来认识认识这些字……不过开书院嘛，还缺<colour red=255 green=187 blue=0 alpha=255>十份兽皮和木炭</colour><dc0>来充当纸笔，你既然是人，要弄那些东西应该不难吧？</dc0><br/><dc0>你愿意帮我去弄一些吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var6 = 1;
    }
}
