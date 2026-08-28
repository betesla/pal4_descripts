// Structured PAL4 reconstruction for M15.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M15_1_init()
{
    bool ctrl_a_2_visible = false;
    bool ctrl_b_2_visible = false;
    bool ctrl_d_2_visible = false;

    giTimeScript(180.0, "func9001");
    ctrl_a_2_visible = giGetVisibleObject("ctrlA_2");
    ctrl_b_2_visible = giGetVisibleObject("ctrlB_2");
    ctrl_d_2_visible = giGetVisibleObject("ctrlD_2");
    if (!giGetVisibleObject("ctrlA_2"))
    {
        giEventVolumeVisible("A", false);
    }
    if (!ctrl_b_2_visible)
    {
        giEventVolumeVisible("B", false);
    }
    if (!ctrl_d_2_visible)
    {
        giEventVolumeVisible("D", false);
    }
    if (npc_f > 0)
    {
        giSetObjectVisible("SO001", false);
    }
    if (global_mvar != 130100 /* 第三章 / 7-5-3.往事 / 不周山 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2001();
    }
}

void M15_2_init()
{
    bool ctrl_f_2_visible = false;
    bool ctrl_h_2_visible = false;
    float current_player_pos_y = 0.0;
    float current_player_pos_z = 0.0;

    giTimeScript(180.0, "func9001");
    ctrl_f_2_visible = giGetVisibleObject("ctrlF_2");
    ctrl_h_2_visible = giGetVisibleObject("ctrlH_2");
    if (!giGetVisibleObject("ctrlF_2"))
    {
        giEventVolumeVisible("F", false);
    }
    if (!ctrl_h_2_visible)
    {
        giEventVolumeVisible("H", false);
    }
    current_player_pos_y = giPlayerCurrentGetPosY();
    current_player_pos_z = giPlayerCurrentGetPosZ();
    if (current_player_pos_y <= 3550.0 && current_player_pos_z < -1400.0 && giPlayerCurrentGetPosY() <= 3960.0 || current_player_pos_y > 3550.0 && current_player_pos_y >= 3630.0 && current_player_pos_z < -1400.0 && giPlayerCurrentGetPosY() <= 3960.0 || current_player_pos_z >= -1400.0 && giPlayerCurrentGetPosY() <= 3960.0)
    {
        func7500();
    }
    else
    {
        func7501();
    }
    if (global_mvar != 130500 /* 第三章 / 8-1-3.龙颜怒 / 进入鬼界 / 大荒不周 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("Jeffect001", true);
        giArenaReadyRestore();
    }
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    if (!giBGMConfigIsInArea("1"))
    {
        giArenaLoad("M15", "1", "", true);
    }
    giPlayerCurrentSetPos(-6939.0, 24.0, -484.0);
    giPlayerCurrentSetAng(80.0);
    giCameraSetMode(5, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    giArenaLoad("M15", "2", "", true);
    giPlayerCurrentSetPos(-8185.5, 615.0, 1164.5);
    giPlayerCurrentSetAng(132.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("M15", "1", "", true);
    giPlayerCurrentSetPos(6932.3, 1719.1, -441.5);
    giPlayerCurrentSetAng(298.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1003()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    giMonsterStopPursuit();
    giPlayerLock();
    giSelectDialogAddItem("1.御剑飞行  ");
    giSelectDialogAddItem("2.什么都不做");
    giSelectDialogSetDefaultSelect(1);
    giShowSelectDialog("              准备<colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>吗？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        leader_player_id = giPlayerGetLeader();
        giPlayerWalkTo(leader_player_id, -6939.0, 24.0, -484.0, true);
        giPlayerSetDir(leader_player_id, 80.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giPlayerUnLock();
    }
    else
    {
        giShowWorldMap();
    }
    giPlayerUnLock();
}

void func1004()
{
    if (global_mvar == 130500 /* 第三章 / 8-1-3.龙颜怒 / 进入鬼界 / 大荒不周 */)
    {
        giPlayerLock();
        giArenaLoad("Q11", "Q11W", "", true);
    }
}

void func2001()
{
    if (global_mvar == 130100 /* 第三章 / 7-5-3.往事 / 不周山 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -6961.7, 48.7, -972.9);
        giPlayerSetPos(1, -6962.8, 52.9, -1015.7);
        giPlayerSetPos(3, -6933.9, 52.9, -1039.8);
        giPlayerSetAng(0, 66.0);
        giPlayerSetAng(1, 80.0);
        giPlayerSetAng(3, 64.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giMonsterSetHide("m15-01-07", false);
        giMonsterSetHide("m15-01-08", false);
        giMonsterSetHide("m15-03-06", false);
        giSetObjectVisible("JpuzzleB01", false);
        giSetObjectVisible("JpuzzleB02", false);
        giSetObjectVisible("JpuzzleB06", false);
        giSetObjectVisible("JpuzzleB07", false);
        giSetObjectVisible("trans05", false);
        giSetObjectVisible("trans06", false);
        giSetObjectVisible("CtrlB_1", false);
        giSetObjectVisible("save1", false);
        giSetObjectVisible("save2", false);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(1.0);
        giCameraRunSingle("002", true);
        giWait(2.0);
        giCameraRunSingle("003", true);
        giWait(2.0);
        giCameraRunSingle("004", true);
        giWait(2.0);
        giCameraRunSingle("005", true);
        giWait(1.8);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：这里，就是不周山？", "44746");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.2);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：应该是这里了，相传此地有神兽衔烛之龙守护，它能照亮整个西北大荒。我们此行只是<colour red=255 green=187 blue=0 alpha=255>要寻找进入鬼界的方法</colour><dc0>，最好不要冒犯于它。</dc0>", "44747");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：嗯……那种活了千万年的神兽，就算我们想打也打不赢吧……", "44748");
        giPlayerEndAction(0);
        giPlayerEndAction(1);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giMonsterSetHide("m15-01-07", true);
        giMonsterSetHide("m15-01-08", true);
        giMonsterSetHide("m15-03-06", true);
        giSetObjectVisible("JpuzzleB01", true);
        giSetObjectVisible("JpuzzleB02", true);
        giSetObjectVisible("JpuzzleB06", true);
        giSetObjectVisible("JpuzzleB07", true);
        giSetObjectVisible("trans05", true);
        giSetObjectVisible("trans06", true);
        giSetObjectVisible("CtrlB_1", true);
        giSetObjectVisible("save1", true);
        giSetObjectVisible("save2", true);
        giIMMEnd();
        global_mvar = 130200; // 0x0001FC98, 第三章 / 8-1-1.龙颜怒 / 寻找鬼界入口
        giPlayerCurrentSetPos(-6907.8, 25.1, -520.3);
        giPlayerCurrentSetAng(52.0);
        giCameraSetMode(5, true);
        giFlushTailYAngle();
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 130200 /* 第三章 / 8-1-1.龙颜怒 / 寻找鬼界入口 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giHideGASkillObject();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -899.1, 658.0, 897.2);
        giPlayerSetPos(1, -874.7, 655.0, 936.4);
        giPlayerSetPos(3, -950.4, 656.8, 914.5);
        giPlayerSetAng(0, 158.0);
        giPlayerSetAng(1, 180.0);
        giPlayerSetAng(3, 152.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giMonsterSetHide("m15-03-06", false);
        giMonsterSetHide("m15-04-02", false);
        giSetObjectVisible("trans05", false);
        giSetObjectVisible("trans06", false);
        giSetObjectVisible("CtrlB_1", false);
        giSetObjectVisible("entrance2", false);
        giSetObjectVisible("save1", false);
        giSetObjectVisible("save2", false);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(1.5, false);
        giWait(0.7);
        gi2DSoundPlay("WJ095", 1);
        giWait(1.0);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：呀！打雷了！", "44749");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giScriptMusicPlay("P47", 2, 0.0, 0.0);
        giWait(1.0);
        giTalk("？？：汝等凡人！为何会来到不周山！此处乃是幽冥之国的属地，速速退去！", "44750");
        giWait(1.0);
        giPlayerSetDir(0, 103.0, true);
        giWait(1.2);
        giPlayerSetDir(0, 210.0, true);
        giWait(1.2);
        giPlayerSetDir(0, 158.0, true);
        giWait(1.0);
        giSetPortrait("101J", true);
        giTalk("云天河：我们是来找进入鬼界的法子！你又是谁？在哪里？", "44751");
        giGOMTouch("Jeffect001");
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        gi2DSoundPlay("WJ094", 1);
        giWait(0.8);
        giPlayerDoAction(0, "J13", 1, false);
        giWait(1.5);
        giNpcBlendIn("MN001", 6.5, false);
        giWait(0.5);
        giCameraRunSingle("002", true);
        giWait(3.0);
        giCameraRunSingle("003", true);
        giWait(1.0);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：鬼界？区区凡人，不过是六界中渺如沙粒的存在，你们真的清楚鬼界是什么地方吗？", "44752");
        giWait(0.8);
        giCameraRunSingle("004", true);
        giWait(0.8);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：神龙！！", "44753");
        giWait(0.8);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：是龙耶！真的是龙！", "44754");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.8);
        giSetPortrait("101J", false);
        giTalk("云天河：我不知道鬼界是什么样的，但是为了找一个朋友，我们一定要去鬼界！", "44755");
        giWait(0.5);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：天河！不可无礼！", "44756");
        giWait(0.5);
        giPlayerDoAction(3, "J07", -1, true);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我等乃是昆仑琼华派弟子，专司修仙问道，如今因有要事，特来寻找鬼界入口，绝非有意冒犯！", "44757");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.8);
        giCameraRunSingle("006", true);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：昆仑琼华派？凡人妄想修仙乃是可笑，千秋万代之间，遂心愿者又有几人？！不如乖乖生老病死！", "44758");
        giWait(1.2);
        giIMMBegin();
        giCameraRunSingle("001", true);
        giSetNpcVisible("MN001", false);
        giIMMEnd();
        giSetPortrait("101J", true);
        giTalk("云天河：我们来这里，只想知道进鬼界的办法！和修不修仙没关系！", "44759");
        giWait(0.5);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：哦？如此言语态度，有意思！", "44760");
        giWait(0.5);
        giCameraRunSingle("007", true);
        giNpcBlendIn("MN002", 3.5, false);
        giGOMTouch("Jeffect001");
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giWait(1.5);
        giPlayerDoAction(1, "J02", 1, false);
        giWait(0.3);
        giSetPortrait("105D", true);
        giTalk("慕容紫英： ……！", "44761");
        giWait(0.5);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：凡人，回答本尊，你叫什么名字？", "44762");
        giWait(0.4);
        giSetPortrait("101J", true);
        giTalk("云天河：我叫云天河，她叫韩菱纱，他叫慕容紫英。", "44763");
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：（就问你一个，把我们的名字全报出来干嘛……）", "44764");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：本尊不讨厌胆大的凡人，但讨厌说大话的凡人！你们有胆量就走上盘龙镇柱试试！可能再也没有命走出不周山！", "44765");
        giWait(0.5);
        giSetPortrait("101A", true);
        giTalk("云天河：……上面，就有去鬼界的入口吗？", "44766");
        giWait(0.8);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：凡人，你们能不能去鬼界，由本尊决定！", "44767");
        giGOMTouch("Jeffect001");
        giNpcBlendOut("MN002", 3.0, false);
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giWait(4.5);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P42", 2, 0.0, 2.5);
        giCameraRunSingle("008", true);
        giWait(0.8);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：好！说话要算数，你等着！", "44768");
        giPlayerEndAction(0);
        giPlayerSetDir(1, 204.0, true);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：…………", "44769");
        giWait(0.5);
        giPlayerSetDir(0, 30.0, true);
        giWait(0.3);
        giSetPortrait("101A", false);
        giTalk("云天河：菱纱——", "44770");
        giPlayerSetDir(3, 80.0, false);
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：你、你怎么了？你那样看我？", "44771");
        giWait(0.6);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：还问我！我都快被你吓死了，知不知道！", "44772");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：……爹说过男子汉立世无所畏惧，没什么好怕的。", "44773");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("009", false);
        giWait(0.3);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：那是龙哎！你这野人，居然还敢用那种语气和神龙说话！我真怕神龙一生气，就直接把你撕碎了！", "44774");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101C", false);
        giTalk("云天河：撕碎？我没觉得有杀气啊……", "44775");
        giWait(0.5);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：谁管你什么杀气不杀气的，真是气死我了……", "44776");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 26.0, true);
        giWait(1.5);
        giPlayerDoAction(3, "C09", 1, false);
        giWait(0.8);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：……菱纱，算了，如今亦是祸福难料，<colour red=255 green=187 blue=0 alpha=255>不如先往上走，静观其变。</colour>", "44777");
        giPlayerEndAction(3);
        giPlayerSetDir(1, 256.0, true);
        giWait(0.4);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：我知道，当然也只能这样了……可我就是气不过嘛……", "44778");
        giWait(0.8);
        giPlayerSetDir(1, 204.0, true);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：哼～！", "44779");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerWalkTo(1, -820.7, 660.1, 775.2, false);
        giWait(1.8);
        giIMMBegin();
        giPlayerSetAng(0, 166.0);
        giPlayerSetAng(3, 142.0);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：好久没见菱纱这样有精神地生气了……也不错，呵呵，看样子长老给的石头真的挺有用。", "44780");
        giPlayerEndAction(0);
        giPlayerDoAction(3, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：她也是担心你啊……唉。", "44781");
        giPlayerEndAction(3);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giMonsterSetHide("m15-03-06", true);
        giMonsterSetHide("m15-04-02", true);
        giSetObjectVisible("trans05", true);
        giSetObjectVisible("trans06", true);
        giSetObjectVisible("CtrlB_1", true);
        giSetObjectVisible("entrance2", true);
        giSetObjectVisible("save1", true);
        giSetObjectVisible("save2", true);
        giShowSignpost();
        giIMMEnd();
        global_mvar = 130201; // 0x0001FC99, 第三章 / 8-1-2.龙颜怒 / 依言赴约
        giPlayerCurrentSetPos(-899.1, 658.0, 897.2);
        giPlayerCurrentSetAng(206.0);
        giCameraSetMode(5, true);
        giFlushTailYAngle();
        giArenaSkillEnable(true);
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2003()
{
    if (global_mvar == 130201 /* 第三章 / 8-1-2.龙颜怒 / 依言赴约 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giHideGASkillObject();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -4223.6, 5397.0, 3526.6);
        giPlayerSetPos(1, -4243.9, 5397.0, 3481.5);
        giPlayerSetPos(3, -4162.5, 5397.0, 3505.7);
        giPlayerSetAng(0, 354.0);
        giPlayerSetAng(1, 0.0);
        giPlayerSetAng(3, 0.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("save1", false);
        giSetObjectVisible("save2", false);
        giSetObjectVisible("save3", false);
        giMonsterSetHide("m15-07-05", false);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(1.5, true);
        giWait(1.5);
        giCameraRunSingle("002", false);
        giWait(2.0);
        giPlayerWalkTo(0, -4255.3, 5397.0, 3713.3, false);
        giPlayerWalkTo(1, -4285.5, 5397.0, 3667.0, false);
        giPlayerWalkTo(3, -4196.5, 5397.0, 3672.6, true);
        giPlayerEndMove(0);
        giPlayerEndMove(1);
        giPlayerEndMove(3);
        giCameraWait();
        giPlayerDoAction(0, "J13", 1, true);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetAng(0, 354.0);
        giPlayerSetAng(1, 12.0);
        giPlayerSetAng(3, 352.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(0, "J23", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：喂～～我们已经上来了，你在哪里？", "44782");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.2);
        giTalk("衔烛之龙：凡人，你可知道？对神龙呼来喊去，是何等的大不敬？！", "44783");
        giWait(0.3);
        giSetObjectVisible("Jeffect007", true);
        giWait(0.3);
        giPlayerDoAction(0, "Z12", 0, false);
        giSetPortrait("101D", true);
        giTalk("云天河：啊——！！", "44784");
        giWait(0.5);
        giPlayerSetDir(3, 322.0, false);
        giPlayerSetDir(1, 16.0, true);
        giCameraRunSingle("004", true);
        giWait(0.3);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：天河！你、你怎么样？", "44785");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.1);
        giPlayerDoAction(0, "Z11", 0, false);
        giWait(1.3);
        giSetPortrait("101E", false);
        giTalk("云天河：好痛，为什么……我下山以后总要被雷劈……", "44786");
        giWait(0.6);
        giGOMTouch("Jeffect002");
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giScriptMusicPlay("P47", 2, 0.0, 2.5);
        giWait(1.5);
        giCameraRunSingle("005", false);
        giIMMBegin();
        giNpcBlendIn("MN001", 2.0, false);
        giSetObjectVisible("Jeffect014", true);
        giIMMEnd();
        giCameraWait();
        giPlayerSetDir(1, 4.0, false);
        giPlayerSetDir(3, 342.0, false);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：凡人，这便是无礼的下场！", "44787");
        giWait(1.2);
        giPlayerEndAction(0);
        giWait(1.2);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：我不晓得什么才算有礼！你让我们上来，说是有去鬼界的办法，我们当然是急急忙忙跑上来找你！有什么不对吗？", "44788");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("006", true);
        giWait(1.0);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：……看来你的胆子很大，也不怕死，但若是本尊告诉你，想去鬼界，你的两个朋友之中，必须死一个人，你会如何回答本尊？", "44789");
        giWait(0.3);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：……！", "44790");
        giWait(0.2);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：……！", "44791");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：死？为什么？！", "44792");
        giWait(0.5);
        giCameraRunSingle("007", true);
        giWait(1.0);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：本尊说过，这里是幽冥之国的属地，若是毫无缘由让凡人进入鬼界，本尊日后要如何忍受阎王的蔑视？", "44793");
        giWait(0.5);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：大胆的凡人，本尊只要求一个魂魄，已是相当宽大！", "44794");
        giWait(0.5);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：快选吧！到底要谁死？一位是红颜知己，另一位是至交好友，想清楚！", "44795");
        giWait(0.5);
        giCameraRunSingle("008", true);
        giWait(0.8);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：这、这算什么条件？更何况我……不是他的……", "44796");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：…………", "44797");
        giWait(0.8);
        giSetPortrait("101J", true);
        giTalk("云天河：……一定要这样吗？", "44798");
        giWait(0.5);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：不错！本尊等你的答案！", "44799");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, true);
        giSetPortrait("101I", true);
        giTalk("云天河：那我一个都不选。", "44800");
        giWait(0.3);
        giCameraRunSingle("009", true);
        giGOMTouch("Jeffect003");
        giWait(1.8);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：好大的胆子！敢戏弄本尊！！", "44801");
        giWait(0.5);
        giSetPortrait("101I", true);
        giTalk("云天河：虽然为了找我的朋友，我一定要去鬼界，但是如果因为这样，必须失去另一个朋友，我宁可不要！就算离开不周山，总能找到其他办法进鬼界的！", "44802");
        giWait(0.5);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：此地岂是你要来便来，要去便去！", "44803");
        giWait(0.5);
        giGOMTouch("Jeffect002");
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giWait(3.0);
        giSetPortrait("101I", true);
        giTalk("云天河：（杀气！好强！！）", "44804");
        giWait(0.8);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：若是激怒了本尊，本尊可以让你们几个通通死在这里！", "44805");
        giWait(0.8);
        giCameraRunSingle("008", true);
        giWait(0.8);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101I", true);
        giTalk("云天河：你很强，我感觉得出来。不过……是我不愿意选，和他们俩没关系……请你不要杀他们。", "44806");
        giWait(0.8);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：天河……", "44807");
        giWait(0.3);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：要我牺牲朋友绝不可能，我不会改变主意的。", "44808");
        giWait(0.8);
        giCameraRunSingle("006", true);
        giWait(1.0);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：…………", "44809");
        giWait(0.5);
        giCameraRunSingle("010", false);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：凡人，你很有趣，你一定还看不清世间真正的疾苦，一定认为所有事情都能靠自己的力量解决。", "44810");
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：凡人，或许你值得本尊欣赏你，或许你只是一个什么都不懂的愚人！", "44811");
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：什么意思……？", "44812");
        giWait(0.5);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：本尊给你一个机会，本尊将会释放相隔千万年、未飞升得道之前的幻影，你们若能战胜它，本尊就打开往鬼界无常殿的通路。", "44813");
        giWait(0.5);
        giSetPortrait("101B", false);
        giTalk("云天河：真的？！你愿意帮我们了？", "44814");
        giWait(0.5);
        giCameraRunSingle("011", true);
        giGOMTouch("Jeffect003");
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：哈哈！本尊镇守此地已经九千九百年，即将功德圆满之际，还能遇上你这种可笑的凡人，我是帮助你们进入鬼界呢，还是——", "44815");
        giNpcDoAction("MN001", "X01", 1, false);
        giWait(1.0);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：将你们的魂魄送入鬼界！！", "44816");
        giFlashOutBlack(0.5, true, true);
        giSetObjectVisible("Jeffect007", false);
        giWait(3.5);
        giIMMBegin();
        giAddPlayerFavor(0, 1, 20);
        giAddPlayerFavor(0, 3, 40);
        giSetFullHP();
        giSetFullMP();
        giIMMEnd();
        giAddCombatMonster(2592, 4);
        giConfigCombatBgm("P47");
        giConfigCombatCamera("CA49");
        giConfigCombatGroundCamera("CA50");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M15C");
        giScriptMusicPlay("P42", 2, 2.5, 0.0);
        giNpcDoAction("MN001", "C01", 0, false);
        giFlashInBlack(1.5, true);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：很好，凡人，你很努力。", "44817");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(1, 36.0);
        giPlayerSetAng(3, 302.0);
        giPlayerDoAction(0, "Z11", 0, false);
        giCameraRunSingle("012", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：呃……", "44818");
        giWait(0.5);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：天河！你受伤了？！", "44819");
        giWait(0.5);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：……！", "44820");
        giWait(0.5);
        giPlayerDoAction(3, "Z07", 1, false);
        giWait(2.2);
        giEffectPlayWithPlayer("HW_XS027", 1, 0);
        giWait(1.9);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：白费力气，神龙所伤，凡人的法术岂能治愈？", "44821");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(1, 6.0);
        giPlayerSetAng(3, 356.0);
        giCameraSetDistOptEnable(false);
        giCameraRunSingle("013", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：你们有所求，就要付出代价。", "44822");
        giWait(0.5);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：代价？你对天河做了什么？！", "44823");
        giWait(0.5);
        giCameraRunSingle("014", false);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：既然放你们通过，本尊干脆跟阎王多开个小玩笑。", "44824");
        giWait(0.5);
        giPlayerEndAction(0);
        giWait(0.8);
        giSetPortrait("101H", true);
        giTalk("云天河：……你可以打开鬼界的门了吧？", "44825");
        giWait(0.8);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：此法阵有去无回，如何从鬼界重返人间，你们须得自己想办法。", "44826");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：啊？原来还要自己想法子回人间啊……", "44827");
        giWait(1.0);
        gi2DSoundPlay("WE197", 1);
        giSetObjectVisible("Jeffect001", true);
        giWait(1.1);
        giIMMBegin();
        giSetObjectVisible("Jeffect004", true);
        giSetObjectVisible("Jeffect005", true);
        giSetObjectVisible("Jeffect006", true);
        giIMMEnd();
        giWait(1.2);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：这是……？", "44828");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("B14A", false);
        giTalk("衔烛之龙：凡人进入无常殿，岂非与送死无异？此法术可令汝等生人之气不被鬼察觉，十二个时辰后自行消散。", "44829");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：……谢谢。", "44830");
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("015", true);
        giCameraSetDistOptEnable(true);
        giWait(1.2);
        giCameraRunSingle("016", false);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：本尊今日令你得偿所愿，但是等你有朝一日，尝遍世间辛酸之时，或许就会怨恨这样的命运。", "44831");
        giWait(1.0);
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：胆大又有趣的凡人啊，待你此生阳寿尽时，本尊会来找你，看一看你是否还是如此洒脱！", "44832");
        giSetPortrait("B14A", true);
        giTalk("衔烛之龙：哈哈——！", "44833");
        giWait(0.5);
        giGOMTouch("Jeffect002");
        giIMMBegin();
        giNpcBlendOut("MN001", 3.5, false);
        giSetObjectVisible("Jeffect014", false);
        giIMMEnd();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giWait(4.5);
        giIMMBegin();
        giPlayerSetAng(3, 316.0);
        giPlayerSetAng(1, 22.0);
        giCameraRunSingle("017", true);
        giIMMEnd();
        giWait(1.0);
        giSetPortrait("101G", true);
        giTalk("云天河：…………", "44834");
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：天河，你的伤，真的不要紧吗？……", "44835");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(0, 204.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：没关系的。", "44836");
        giPlayerEndAction(0);
        giSetPortrait("101G", false);
        giTalk("云天河：……我刚才觉得全身都像被火烧着了一样，现在已经好多了，大概是大哥教我的凝冰诀起了作用……只是一下冷、一下热，有点难受……", "44837");
        giWait(0.8);
        giPlayerSetDir(0, 302.0, true);
        giWait(0.3);
        giSetPortrait("101D", false);
        giTalk("云天河：…………", "44838");
        giWait(0.5);
        giPlayerDoAction(0, "Z11", 0, false);
        giSetPortrait("101D", false);
        giTalk("云天河：啊！————", "44839");
        giCameraRunSingle("018", false);
        giWait(0.5);
        giSetObjectVisible("Jeffect008", true);
        giWait(0.5);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：……！", "44840");
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：天河！你怎么了？！你别吓我……别吓我……", "44841");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giSetPortrait("101G", false);
        giTalk("云天河：我……我……", "44842");
        giWait(0.5);
        giPlayerWalkTo(3, -4219.4, 5397.0, 3687.3, true);
        giWait(0.3);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：切勿勉强开口！还不快静下心神，我运功助你调息！", "44843");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：唔……", "44844");
        giWait(0.5);
        giIMMBegin();
        giSetObjectVisible("Jeffect008", false);
        giSetObjectVisible("Jeffect013", true);
        giPlayerDoAction(0, "C10", -1, false);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(3, "C10", -1, false);
        giIMMBegin();
        gi2DSoundPlay("WE007", 0);
        giSetObjectVisible("Jeffect010", true);
        giSetObjectVisible("Jeffect011", true);
        giIMMEnd();
        giCameraRunSingle("019", false);
        giWait(0.5);
        giPlayerSetAng(1, 50.0);
        giPlayerDoAction(1, "J04", -1, false);
        giWait(0.3);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：吐息引气，宁神静心，如是往来——", "44845");
        giWait(1.2);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：……！这是…………！！", "44846");
        giWait(1.0);
        giSetPortrait("101G", true);
        giTalk("云天河：……紫英……不行，我觉得很冷、又很热……", "44847");
        giWait(0.5);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：静下心来！不可自乱心神！", "44848");
        giCameraRunSingle("020", true);
        giSetObjectVisible("Jeffect012", true);
        giWait(1.0);
        giSetPortrait("101G", true);
        giTalk("云天河：唔……", "44849");
        giWait(0.8);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：天河……", "44850");
        giWait(2.0);
        giScriptMusicStop(0, 2.5);
        giFlashOutBlack(2.0, true, true);
        gi2DSoundStop();
        giSetObjectVisible("Jeffect013", false);
        giSetObjectVisible("Jeffect010", false);
        giSetObjectVisible("Jeffect011", false);
        giSetObjectVisible("Jeffect012", false);
        giIMMBegin();
        giPlayerSetPos(1, -4370.2, 5397.0, 3745.4);
        giPlayerSetAng(1, 116.0);
        giPlayerSetPos(3, -4369.1, 5397.0, 3704.4);
        giPlayerSetAng(3, 76.0);
        giPlayerSetAng(0, 264.0);
        giCameraRunSingle("021", true);
        giIMMEnd();
        giPlayerDoAction(0, "C10", 0, false);
        giWait(3.0);
        giFlashInBlack(2.0, true);
        giWait(1.0);
        giCameraRunSingle("022", false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：紫英，天河他……会没事吗？", "44851");
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……他体内气息已归于平和，应无大碍。", "44852");
        giCameraRunSingle("023", true);
        giSetObjectVisible("Jeffect009", true);
        giWait(2.5);
        giSetObjectVisible("Jeffect009", false);
        giSetPortrait("101B", false);
        giTalk("云天河：呼～～", "44853");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.5);
        giPlayerWalkTo(0, -4301.6, 5397.0, 3722.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：哈哈，好了！一点都不难受了！", "44854");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：……真的吗？要不要再休息一会儿？你刚才还那么糟……", "44855");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：没事、没事～我精神反而比之前还好呢！", "44856");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerSetAng(0, 266.0);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：谢谢你，紫英！", "44857");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：不必客气。", "44858");
        giWait(0.5);
        giSetPortrait("101B", false);
        giTalk("云天河：我们出发吧！", "44859");
        giWait(1.0);
        giPlayerSetDir(1, 288.0, true);
        giWait(0.5);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：…………", "44860");
        giWait(0.4);
        giPlayerWalkTo(1, -4473.5, 5397.0, 3764.5, true);
        giWait(0.35);
        giCameraRunSingle("024", true);
        giIMMBegin();
        giPlayerSetPos(1, -4923.7, 5397.0, 3990.4);
        giPlayerSetPos(0, -4910.4, 5397.0, 3956.2);
        giIMMEnd();
        giWait(0.5);
        giPlayerWalkTo(1, -5000.0, 5397.0, 4030.3, true);
        giCameraRunSingle("025", false);
        giWait(3.5);
        giPlayerWalkTo(0, -4989.5, 5397.0, 3993.1, true);
        giPlayerSetDir(0, 354.0, true);
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：菱纱，你怎么了？", "44861");
        giWait(0.8);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……我还从来没有见你为什么事这样拼命过……你……对梦璃真好……", "44862");
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：什么？", "44863");
        giWait(0.5);
        giPlayerSetDir(1, 170.0, false);
        giCameraRunSingle("026", true);
        giWait(0.8);
        giCameraRunSingle("027", false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……如果，我是说如果，有一天，我也像梦璃一样不见了，你也会不顾一切来找我吗？", "44864");
        giWait(0.5);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：呃……一个不见，已经够麻烦的，要是两个都不见了，我、我也不知道怎么办才好……", "44865");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.8);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：……", "44866");
        giWait(0.8);
        giSetPortrait("101B", false);
        giTalk("云天河：你放心！要是真有那么一天，我一定也会去找你，直到找到你为止……", "44867");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：虽然有时候你会说我笨，不过你是除了爹以外，第一个对我好的人，我知道你对我其实是很好很好的……", "44868");
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(1, 160.0);
        giPlayerSetAng(0, 342.0);
        giCameraRunSingle("028", true);
        giIMMEnd();
        giCameraRunSingle("029", false);
        giWait(0.5);
        giSetPortrait("101B", false);
        giTalk("云天河：所以不管发生什么事，我都会去找你，你比梦璃还——", "44869");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103G", true);
        giTalk("韩菱纱：等、等一下！你别说了，我只问一句，你有的没的说一堆干嘛！", "44870");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(1, 0.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103G", true);
        giTalk("韩菱纱：后面的、后面的我不想知道了！", "44871");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 354.0);
        giPlayerSetPos(3, -4861.8, 5397.0, 4079.5);
        giCameraRunSingle("026", true);
        giIMMEnd();
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：明明是你问我啊，又不让我说……不想知道还问干嘛……", "44872");
        giPlayerEndAction(0);
        giSetPortrait("103G", true);
        giTalk("韩菱纱：…………", "44873");
        giWait(0.5);
        giCameraRunSingle("030", false);
        giWait(2.5);
        giPlayerWalkTo(3, -4937.8, 5397.0, 4030.2, true);
        giCameraWait();
        giPlayerSetDir(0, 40.0, false);
        giPlayerSetDir(1, 76.0, false);
        giWait(0.5);
        giCameraRunSingle("031", false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：天河，你受伤之后，内息极是古怪，有一寒一热两道完全不同的气在体内交织——", "44874");
        giWait(0.3);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：啊，听起来好像走火入魔！", "44875");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, true);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：不错……乍听与走火入魔无异，但这两道气息冲撞过后，却又似乎融于一体，并无异状……", "44876");
        giWait(0.8);
        giCameraRunSingle("032", true);
        giCameraRunSingle("033", false);
        giWait(1.2);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：这盘龙镇柱直耸入天，那衔烛之龙也是神龙见首不见尾，所以再难请他治天河的伤……", "44877");
        giWait(1.5);
        giCameraRunSingle("034", true);
        giWait(0.8);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：紫英，我真的没事！全身上下都是使不完的力，简直比受伤前还要好。", "44878");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：无论如何，还是多加小心，觉得难受的话，要立刻告诉我。", "44879");
        giWait(0.5);
        giPlayerSetDir(1, 172.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：对啊，不许逞强、闷着不说。", "44880");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giPlayerSetDir(0, 354.0, true);
        giWait(0.5);
        giSetPortrait("101A", false);
        giTalk("云天河：哦，好……", "44881");
        giWait(0.8);
        giIMMBegin();
        giPlayerSetAng(3, 292.0);
        giCameraRunSingle("035", true);
        giIMMEnd();
        giCameraRunSingle("036", false);
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：（……神龙说跟阎王多开个小玩笑，到底何意？）", "44882");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：（天河的阴阳之气委实古怪……神龙似乎是帮他，但言语之中，又有不善之意……）", "44883");
        giWait(1.2);
        giIMMBegin();
        giPlayerSetAng(0, 40.0);
        giPlayerSetAng(3, 238.0);
        giCameraRunSingle("034", true);
        giIMMEnd();
        giWait(1.0);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>我们走吧，进传送法阵，</colour><dc0>再不走，这个法阵会不会消失啊？</dc0>", "44884");
        giPlayerEndAction(0);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：也只能先去鬼界了，但愿一切顺利……", "44885");
        giPlayerEndAction(3);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giMonsterSetHide("m15-07-05", true);
        giSetObjectVisible("Jeffect004", false);
        giSetObjectVisible("Jeffect005", false);
        giSetObjectVisible("Jeffect006", false);
        giShowSignpost();
        giSetObjectVisible("save1", true);
        giSetObjectVisible("save2", true);
        giSetObjectVisible("save3", true);
        giIMMEnd();
        global_mvar = 130500; // 0x0001FDC4, 第三章 / 8-1-3.龙颜怒 / 进入鬼界 / 大荒不周
        giPlayerCurrentSetPos(-4255.3, 5397.0, 3713.3);
        giPlayerCurrentSetAng(0.0);
        giCameraSetMode(5, true);
        giFlushTailYAngle();
        giShowSignpost();
        giTimeScript(180.0, "func9001");
        giAddPlayerFavor(0, 3, -30);
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func3001()
{
    if (npc_f == 0)
    {
        giMonsterStopPursuit();
        giHideGASkillObject();
        giTimeScriptTerminate();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giHideGASkillObject();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -267.5, 389.5, -493.1);
        giPlayerSetPos(1, -321.6, 389.5, -495.0);
        giPlayerSetPos(3, -339.2, 389.5, -420.5);
        giPlayerSetAng(0, 240.0);
        giPlayerSetAng(1, 238.0);
        giPlayerSetAng(3, 185.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giCameraPrepare("mo1");
        giIMMEnd();
        giScriptMusicPlay("P71", 2, 0.0, 0.0);
        giCameraRunSingle("002", true);
        giCameraRunSingle("001", false);
        giFlashInBlack(1.5, true);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：啊，这个人……他的尸骨上插着一把巨剑……", "");
        giCameraWait();
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(0, -409.0, 389.5, -622.6);
        giPlayerSetPos(3, -491.9, 389.5, -590.1);
        giPlayerSetPos(1, -437.9, 389.5, -608.5);
        giPlayerWalkTo(1, -460.6, 389.5, -672.2, false);
        giPlayerSetAng(0, 242.0);
        giPlayerSetAng(3, 192.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giPlayerEndMove(1);
        giPlayerSetAng(1, 230.0);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：剑身上的刻纹，像是很久以前的古物了——", "");
        giPlayerDoAction(1, "C07", -1, false);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：菱纱，莫要动手！", "");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：呀——！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giSetPortrait("101H", false);
        giTalk("云天河：怎么了？有没有受伤？！", "");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：没、没有，不过这把剑上好像附着什么东西，好可怕……刚才碰到的一瞬间，我、我听到许多厉鬼嚎叫的声音……", "");
        giPlayerEndAction(1);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, -446.0, 389.5, -583.2);
        giPlayerSetPos(1, -418.0, 389.5, -647.1);
        giPlayerSetPos(3, -473.3, 389.5, -593.4);
        giPlayerSetAng(0, 182.0);
        giPlayerSetAng(1, 204.0);
        giPlayerSetAng(3, 200.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：你们暂且退下。", "");
        giWait(0.6);
        giPlayerWalkTo(3, -481.7, 389.5, -637.0, true);
        giPlayerSetAng(3, 150.0);
        giPlayerSetDir(1, 280.0, true);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：紫英，小心……", "");
        giWait(0.5);
        giPlayerDoAction(3, "C07", -1, true);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(1, 240.0);
        giPlayerSetAng(0, 194.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.3);
        giSetObjectVisible("SO006", true);
        giWait(4.5);
        giSetObjectVisible("SO004", false);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……实在罕见，这竟是一把“未成之剑”！", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：未成之剑？啥意思？", "");
        giPlayerEndAction(0);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：便是只铸到一半，功亏一篑……但此剑不知为何，却又有“天成”之象，凶煞之气极重。 ", "");
        giSetObjectVisible("SO003", true);
        giIMMBegin();
        giPlayerSetAng(1, 272.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giCameraRunSingle("008", false);
        giWait(1.0);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：咦？那是……", "");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：紫英，它好像对你很依恋的样子呢。", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giTalk("？？：你们……不要接近魔剑……小葵不想再害人了……", "");
        giPlayerSetDir(1, 248.0, true);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：“小葵”？你是谁，是从剑里飞出来的吗？还有你说这把剑叫作“魔剑”？", "");
        giTalk("小葵：你们走……这个人他知道的，这把剑是凶煞，是不祥之物……", "");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：你本身鬼力与此剑并不完全相融，应该并非恶鬼，但此剑煞气过重，我要将它带走，想办法予以净化。", "");
        giPlayerEndAction(1);
        giTalk("小葵：不要、千万不要！魔剑的力量很大，你会被它、被它……", "");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：是否此剑会反噬执拿之人？", "");
        giTalk("小葵：……好多人……好多人都想得到魔剑……可是他们都死了，被害死了……", "");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：被害死？难道这具尸骨也是？", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("小葵：嗯……他和别人争了好久，终于抢到魔剑，可是又有更多的人要杀他……他逃到这儿，为了摆脱怪物，一直挥剑，这把剑突然就发出红光，刺进了他的胸口……", "");
        giTalk("小葵：小葵也不知道怎么回事……小葵不是有意害他的……", "");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：你……不能控制这把剑吗？", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("小葵：……小葵、小葵只是附在剑中的鬼，没有办法完全驾驭这把剑……", "");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：那你又是如何进入剑中？", "");
        giTalk("小葵：……因为……哥哥死了，可是这把剑还没有铸成，敌人已经攻进城来……小葵就……就跳进了铸剑炉……", "");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：呀！你、你是以身殉剑？！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giCameraRunSingle("012", true);
        giCameraRunSingle("010", false);
        giWait(0.3);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：原来如此……铸剑之道中，以活人祭剑最为凶戾，此剑因你血气而天成，反而获得了非同寻常的力量。若我所料不差，剑成之后只怕顷刻便将方圆数里化为焦土，饮万人之血。", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giTalk("小葵：……是的……后来，小葵好像在魔剑里待了很久很久，那里面有许多怨灵，很可怕……", "");
        giWait(0.3);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：实在太可怜了……", "");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……令兄莫非是位铸剑高人，否则如何会想到铸造这样一把“魔剑”？", "");
        giTalk("小葵：我不知道……不过哥哥他是姜国的太子，他做什么都是很厉害的……我们姜国有本祖传的手卷，上面记载了魔剑铸法，哥哥就是看过那个，才想到铸剑以解围城之困……", "");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：你说姜国，我记得是春秋时的一个小国，以织纫而闻名……天呐，那你在剑里究竟过了多久啊……难道你要一直这样下去？……", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("小葵：……小葵不知道该怎么办……我不要投胎，我想去找哥哥的转世，我想哥哥……可是我还不能化出人形，也不能离开魔剑……", "");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……转世以后就是另一个人了，即使真的见到你哥哥，你还认得出他吗？", "");
        giTalk("小葵：一定可以的，就算相貌变了、性格变了，只要是哥哥，小葵一眼就能认出来……", "");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：你一直待在这里，是不可能遇见你哥哥的转世的……不如，我们把魔剑带在身边，帮你找——", "");
        giTalk("小葵：不行！我……你们是好人，小葵不能害你们……", "");
        giWait(0.5);
        giCameraRunSingle("009", true);
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……不必担心。我可以暂时压制魔剑的凶煞之力，相信踏遍天下，总能找到净化它的办法。", "");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：此剑若是继续留在这里，落入不义之人的手中，只怕又是一场腥风血雨，倒不如我将它带走。", "");
        giTalk("小葵：真的吗？你真的不怕魔剑的煞气？", "");
        giWait(0.3);
        giPlayerDoAction(3, "C08", 1, true);
        giWait(1.0);
        giCameraRunSingle("015", true);
        giCameraRunSingle("011", false);
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：紫英说没事，就一定没事啦！他最擅长铸剑，不会说错的。", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("小葵：……谢谢，他、他叫紫英吗？他和哥哥有一点像，小葵能感觉到，都很正气，又很温柔……", "");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……你且进入剑中，我将魔剑收入剑匣，便启程吧。", "");
        giTalk("小葵：好……可是，如果有一天真的找到哥哥，他知道魔剑害了这么多人，会不会以为小葵不乖？不要小葵了？", "");
        giWait(0.5);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……不会的，你这样乖，他一定舍不得……", "");
        giTalk("小葵：嗯……小葵要回去修炼了，不会再理外物，除非你们呼唤我，或是……我感觉到哥哥在附近……", "");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：知道了，你尽管安心吧……一定、一定可以找到你哥哥的。", "");
        giPlayerEndAction(1);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("015", true);
        giSetObjectVisible("SO003", false);
        giSetObjectVisible("SO001", false);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giShowSignpost();
        giPlayerCurrentSetPos(-389.7, 389.5, -589.2);
        giPlayerCurrentSetAng(52.0);
        giCameraSetMode(5, true);
        giFlushTailYAngle();
        npc_f = 1;
        giTimeScript(180.0, "func9001");
        giAddPlayerFavor(0, 3, 20);
        giAddPlayerFavor(1, 3, 15);
        giScriptMusicStop(0, 2.5);
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func7001()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giShowTutorial(13);
    giWait(0.5);
    giStartJigsawGame(0);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() > 0)
    {
        giOBJBlendOut("ctrlA_2", 0.8, true);
        giEventVolumeVisible("A", false);
        giCameraAutoSeek(false);
        giCameraPrepare("viewA");
        giCameraRunSingle("viewA_1", true);
        giCameraRunSingle("viewA_2", false);
        giGOMTouch("JPuzzleA01");
        giGOMTouch("JPuzzleA03");
        giGOMTouch("JPuzzleA05");
        giWait(5.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
    }
    giPlayerUnLock();
}

void func7002()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(1);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() > 0)
    {
        giOBJBlendOut("ctrlB_2", 0.8, true);
        giEventVolumeVisible("B", false);
        giCameraAutoSeek(false);
        giCameraPrepare("viewB");
        giCameraRunSingle("viewB_1", true);
        giCameraRunSingle("viewB_2", false);
        giGOMTouch("JPuzzleB04");
        giGOMTouch("JPuzzleB05");
        giGOMTouch("JPuzzleB06");
        giWait(5.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
    }
    giPlayerUnLock();
}

void func7003()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(2);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() > 0)
    {
        giOBJBlendOut("ctrlC_2", 0.8, true);
        giCameraAutoSeek(false);
        giCameraPrepare("viewC");
        giCameraRunSingle("viewC_1", true);
        giCameraRunSingle("viewC_2", true);
        giCameraRunSingle("viewC_3", true);
        giCameraRunSingle("viewC_4", false);
        giGOMTouch("JPuzzleC03");
        giGOMTouch("JPuzzleC05");
        giWait(5.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
    }
    giPlayerUnLock();
}

void func7004()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(3);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() > 0)
    {
        giOBJBlendOut("ctrlD_2", 0.8, true);
        giEventVolumeVisible("D", false);
        giCameraAutoSeek(false);
        giCameraPrepare("viewD");
        giCameraRunSingle("viewD_1", true);
        giCameraRunSingle("viewD_2", false);
        giGOMTouch("JPuzzleD_1");
        giGOMTouch("JPuzzleD_2");
        giGOMTouch("JPuzzleD_9");
        giWait(5.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
    }
    giPlayerUnLock();
}

void func7005()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(4);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() > 0)
    {
        giOBJBlendOut("ctrlE_2", 0.8, true);
        giCameraAutoSeek(false);
        giCameraPrepare("viewE");
        giCameraRunSingle("viewE_1", true);
        giCameraRunSingle("viewE_2", true);
        giGOMTouch("JPuzzleE_2");
        giGOMTouch("JPuzzleE_3");
        giGOMTouch("JPuzzleE_5");
        giGOMTouch("JPuzzleE_8");
        giWait(5.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
    }
    giPlayerUnLock();
}

void func7006()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(5);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() > 0)
    {
        giOBJBlendOut("ctrlF_2", 0.8, true);
        giEventVolumeVisible("F", false);
        giCameraAutoSeek(false);
        giCameraPrepare("viewF");
        giCameraRunSingle("viewF_1", true);
        giCameraRunSingle("viewF_2", false);
        giGOMTouch("JPuzzleF_1");
        giGOMTouch("JPuzzleF_2");
        giGOMTouch("JPuzzleF_5");
        giGOMTouch("JPuzzleF_6");
        giWait(5.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
    }
    giPlayerUnLock();
}

void func7007()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(6);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() > 0)
    {
        giOBJBlendOut("ctrlG_2", 0.8, true);
        giCameraAutoSeek(false);
        giCameraPrepare("viewG");
        giCameraRunSingle("viewG_1", true);
        giCameraRunSingle("viewG_2", true);
        giCameraRunSingle("viewG_3", true);
        giCameraRunSingle("viewG_4", false);
        giGOMTouch("JPuzzleG_2");
        giGOMTouch("JPuzzleG_4");
        giGOMTouch("JPuzzleG_7");
        giGOMTouch("JPuzzleG_8");
        giWait(5.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
    }
    giPlayerUnLock();
}

void func7008()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(7);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() > 0)
    {
        giOBJBlendOut("ctrlH_2", 0.8, true);
        giEventVolumeVisible("H", false);
        giCameraAutoSeek(false);
        giCameraPrepare("viewH");
        giCameraRunSingle("viewH_1", true);
        giCameraRunSingle("viewH_2", false);
        giGOMTouch("JPuzzleH_1");
        giGOMTouch("JPuzzleH_3");
        giGOMTouch("JPuzzleH_8");
        giGOMTouch("JPuzzleH_11");
        giWait(5.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
    }
    giPlayerUnLock();
}

void func7009()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(8);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() > 0)
    {
        giOBJBlendOut("ctrlI_2", 0.8, true);
        giCameraAutoSeek(false);
        giCameraPrepare("viewI");
        giCameraRunSingle("viewI_1", true);
        giCameraRunSingle("viewI_2", false);
        giGOMTouch("JPuzzleI_4");
        giGOMTouch("JPuzzleI_9");
        giGOMTouch("JPuzzleI_13");
        giGOMTouch("JPuzzleI_14");
        giWait(5.0);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
    }
    giPlayerUnLock();
}

void func7021(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
{
    // typed_typeinfo_hints: primary=void; extras=[int, int, int, int, int, int, int, int, int, int]
    // prototype_hint: void func7021(int, int, int, int, int, int, int, int, int, int)
    bool trans23_visible = false;
    bool trans24_visible = false;
    bool trans25_visible = false;
    bool trans26_visible = false;
    bool trans27_visible = false;
    bool trans28_visible = false;
    bool trans29_visible = false;
    bool trans30_visible = false;
    bool trans31_visible = false;
    bool trans32_visible = false;

    giIMMBegin();
    trans23_visible = giGetVisibleObject("trans23");
    trans24_visible = giGetVisibleObject("trans24");
    trans25_visible = giGetVisibleObject("trans25");
    trans26_visible = giGetVisibleObject("trans26");
    trans27_visible = giGetVisibleObject("trans27");
    trans28_visible = giGetVisibleObject("trans28");
    trans29_visible = giGetVisibleObject("trans29");
    trans30_visible = giGetVisibleObject("trans30");
    trans31_visible = giGetVisibleObject("trans31");
    trans32_visible = giGetVisibleObject("trans32");
    if (arg0 >= 0)
    {
        if (arg0 != 1)
        {
            if (trans23_visible)
            {
                giSetObjectVisible("trans23", false);
            }
        }
        else if (!trans23_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans23", true);
        }
    }
    if (arg1 >= 0)
    {
        if (arg1 != 1)
        {
            if (trans24_visible)
            {
                giSetObjectVisible("trans24", false);
            }
        }
        else if (!trans24_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans24", true);
        }
    }
    if (arg2 >= 0)
    {
        if (arg2 != 1)
        {
            if (trans25_visible)
            {
                giSetObjectVisible("trans25", false);
            }
        }
        else if (!trans25_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans25", true);
        }
    }
    if (arg3 >= 0)
    {
        if (arg3 != 1)
        {
            if (trans26_visible)
            {
                giSetObjectVisible("trans26", false);
            }
        }
        else if (!trans26_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans26", true);
        }
    }
    if (arg4 >= 0)
    {
        if (arg4 != 1)
        {
            if (trans27_visible)
            {
                giSetObjectVisible("trans27", false);
            }
        }
        else if (!trans27_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans27", true);
        }
    }
    if (arg5 >= 0)
    {
        if (arg5 != 1)
        {
            if (trans28_visible)
            {
                giSetObjectVisible("trans28", false);
            }
        }
        else if (!trans28_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans28", true);
        }
    }
    if (arg6 >= 0)
    {
        if (arg6 != 1)
        {
            if (trans29_visible)
            {
                giSetObjectVisible("trans29", false);
            }
        }
        else if (!trans29_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans29", true);
        }
    }
    if (arg7 >= 0)
    {
        if (arg7 != 1)
        {
            if (trans30_visible)
            {
                giSetObjectVisible("trans30", false);
            }
        }
        else if (!trans30_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans30", true);
        }
    }
    if (arg8 >= 0)
    {
        if (arg8 != 1)
        {
            if (trans31_visible)
            {
                giSetObjectVisible("trans31", false);
            }
        }
        else if (!trans31_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans31", true);
        }
    }
    if (arg9 >= 0)
    {
        if (arg9 != 1)
        {
            if (trans32_visible)
            {
                giSetObjectVisible("trans32", false);
            }
        }
        else if (!trans32_visible)
        {
            gi2DSoundPlay("wh020", 1);
            giSetObjectVisible("trans32", true);
        }
    }
    giIMMEnd();
}

void func7022()
{
    func7021(1, 0, -1, -1, -1, -1, -1, -1, -1, -1);
}

void func7023()
{
    func7021(-1, 1, 0, -1, -1, -1, -1, -1, -1, -1);
}

void func7024()
{
    func7021(1, -1, 1, 0, -1, -1, -1, -1, -1, -1);
}

void func7025()
{
    func7021(0, 1, -1, 1, 0, -1, -1, -1, -1, -1);
}

void func7026()
{
    func7021(-1, 0, 1, -1, 1, 0, -1, -1, -1, -1);
}

void func7027()
{
    func7021(-1, -1, 0, 1, -1, 1, 0, -1, -1, -1);
}

void func7028()
{
    func7021(-1, -1, -1, 0, 1, -1, 1, 0, -1, -1);
}

void func7029()
{
    func7021(-1, -1, -1, -1, 0, 1, -1, 1, 0, -1);
}

void func7030()
{
    func7021(-1, -1, -1, -1, -1, 0, 1, -1, 1, 0);
}

void func7031()
{
    func7021(-1, -1, -1, -1, -1, -1, 0, 1, -1, 1);
}

void func7032()
{
    func7021(-1, -1, -1, -1, -1, -1, -1, 0, 1, -1);
}

void func7033()
{
    func7021(-1, -1, -1, -1, -1, -1, -1, -1, 0, 1);
}

void func7500()
{
    giSetMinimapLevel(0);
}

void func7501()
{
    giSetMinimapLevel(1);
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
