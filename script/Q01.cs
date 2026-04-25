// Structured PAL4 reconstruction for Q01.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q01_N01_init()
{
    if (global_mvar == 10201 /* 序章 / 1-1.贡猪祭父 / 回房拿弓箭 */)
    {
        giSetObjectVisible("MO002", true);
        giSetObjectVisible("MO003", true);
        giEventVolumeVisible("ev_Q01_N01_3", false);
        giGameObjectSetResearch("MO002", true);
        giGameObjectSetResearch("MO003", true);
    }
    if (global_mvar == 10100)
    {
        func2001();
    }
    giArenaReadyRestore();
}

void Q01_Q01_init()
{
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giSetObjectVisible("entrance0", false);
        giSetObjectVisible("entrance2", true);
    }
    else
    {
        giSetObjectVisible("entrance0", true);
        giSetObjectVisible("entrance2", false);
    }
    if (global_mvar == 10601)
    {
        func2003();
    }
    if (global_mvar < 20200 /* 入世下山 */)
    {
        giSetObjectVisible("entrance2", false);
    }
    if (global_mvar == 160400 /* 第四章 / 9-4-1.步虚词终 / 重回青鸾峰 */)
    {
        func2008();
    }
    if (global_mvar == 160500 /* 第四章 / 9-5-1.欢乐苦短 / 进入木屋 */)
    {
        giPlayerSetLeader(1);
    }
    giArenaReadyRestore();
}

void func1001()
{
    if (global_mvar >= 11400 /* 序章 / 1-3-2.红衣少女 / 回屋收拾 */)
    {
        if (global_mvar >= 11401)
        {
            if (global_mvar != 160500 /* 第四章 / 9-5-1.欢乐苦短 / 进入木屋 */)
            {
                    giArenaLoad("Q01", "N02", "", true);
                    giPlayerCurrentSetPos(-144.71562, 6.085611, 62.984432);
                    giPlayerCurrentSetAng(180.0);
                    giCameraSetMode(2, true);
                    giArenaReady();
            }
            else
            {
                giPlayerLock();
                giFlashOutBlack(0.5, true, true);
                giArenaLoad("Q01", "N02", "", true);
                func2009();
            }
        }
        else
        {
            giArenaLoad("Q01", "N02", "", true);
            func2004();
        }
    }
    else
    {
        giArenaLoad("Q01", "N01", "", true);
        giPlayerCurrentSetPos(-158.0, 7.3, 40.0);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(2, true);
        giArenaReady();
    }
}

void func1002()
{
    giArenaLoad("Q01", "Q01", "", true);
    giPlayerCurrentSetPos(-590.30475, 56.05246, -442.83975);
    giPlayerCurrentSetAng(355.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q01", "Q01", "", true);
    giPlayerCurrentSetPos(-590.30475, 56.05246, -442.83975);
    giPlayerCurrentSetAng(355.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1004()
{
    if (global_mvar != 11500 /* 序章 / 1-4-1.入世 / 树屋取物 */)
    {
        giArenaLoad("Q01", "N03", "", true);
        giPlayerCurrentSetPos(-67.08864, 0.069967, 0.259668);
        giPlayerCurrentSetAng(90.0);
        giCameraSetMode(3, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q01", "N03", "", true);
        func2005();
    }
}

void func1005()
{
    giArenaLoad("Q01", "Q01", "", true);
    giPlayerCurrentSetPos(873.9085, 958.686, -1047.8976);
    giPlayerCurrentSetAng(305.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1006()
{
    if (global_mvar != 10300 /* 序章 / 1-2-1.沉溪猎猪 / 进洞抓山猪 / 晚起祭父 */)
    {
        if (global_mvar < 11400 /* 序章 / 1-3-2.红衣少女 / 回屋收拾 */)
        {
            giArenaLoad("M01", "1", "", true);
            giPlayerCurrentSetPos(-638.56793, 40.05522, 2595.762);
            giPlayerCurrentSetAng(126.0);
            giCameraSetMode(5, true);
            giArenaReady();
        }
        else
        {
            giArenaLoad("M01", "3", "", true);
            giPlayerCurrentSetPos(-638.56793, 40.05522, 2595.762);
            giPlayerCurrentSetAng(126.0);
            giCameraSetMode(5, true);
            giArenaReady();
        }
    }
    else
    {
        giArenaLoad("M01", "1", "", true);
    }
}

void func1007()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaLoad("M02", "1", "", true);
        giPlayerCurrentSetPos(-49.54868, -131.68823, 217.37811);
        giPlayerCurrentSetAng(170.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.去紫云架  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去紫云架</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -3178.161, -407.63074, 349.00125, true);
                giPlayerSetDir(leader_player_id, 45.0, true);
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
            giArenaLoad("M02", "1", "", true);
            giPlayerCurrentSetPos(-49.54868, -131.68823, 217.37811);
            giPlayerCurrentSetAng(170.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1008()
{
    if (global_mvar != 160700 /* 照看菱纱 */)
    {
        giArenaLoad("Q01", "N02Y", "", true);
        giPlayerCurrentSetPos(-144.71562, 6.085611, 62.984432);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(2, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(0.5, true, true);
        giArenaLoad("Q01", "N02Y", "", true);
        func2010();
    }
}

void func1009()
{
    giArenaLoad("Q01", "Q01Y", "", true);
    giPlayerCurrentSetPos(-590.30475, 56.05246, -442.83975);
    giPlayerCurrentSetAng(355.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1010()
{
    if (global_mvar != 160900 /* 第四章 / 9-6-1.死生悠茫 / 寻找菱纱 */)
    {
        giArenaLoad("Q01", "N03Y", "", true);
        giPlayerCurrentSetPos(-67.08864, 0.069967, 0.259668);
        giPlayerCurrentSetAng(90.0);
        giCameraSetMode(3, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.5, true, true);
        giArenaLoad("Q01", "N03Y", "", true);
        func2011();
    }
}

void func1011()
{
    giArenaLoad("Q01", "Q01Y", "", true);
    giPlayerCurrentSetPos(873.9085, 958.686, -1047.8976);
    giPlayerCurrentSetAng(305.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1012()
{
    float current_player_pos_y = 0.0;

    current_player_pos_y = giPlayerCurrentGetPosY();
    if (giPlayerCurrentGetPosY() > -150)
    {
        giPlayerLock();
        giFlashOutBlack(0.5, true, true);
        giPlayerCurrentSetPos(-2697.0, -385.0, 808.0);
        giPlayerCurrentSetAng(320.0);
        giFlushTailYAngle();
        giFlashInBlack(0.5, true);
        giPlayerUnLock();
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(0.5, true, true);
        giPlayerCurrentSetPos(-2627.0, -75.0, 670.0);
        giPlayerCurrentSetAng(135.0);
        giFlushTailYAngle();
        giFlashInBlack(0.5, true);
        giPlayerUnLock();
    }
}

void func1013()
{
    float current_player_pos_y = 0.0;

    current_player_pos_y = giPlayerCurrentGetPosY();
    if (giPlayerCurrentGetPosY() > -200)
    {
        giPlayerLock();
        giFlashOutBlack(0.5, true, true);
        giPlayerCurrentSetPos(756.0, -378.0, 951.0);
        giPlayerCurrentSetAng(45.0);
        giFlushTailYAngle();
        giFlashInBlack(0.5, true);
        giPlayerUnLock();
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(0.5, true, true);
        giPlayerCurrentSetPos(664.0, -107.0, 832.0);
        giPlayerCurrentSetAng(225.0);
        giFlushTailYAngle();
        giFlashInBlack(0.5, true);
        giPlayerUnLock();
    }
}

void func2001()
{
    giScriptMusicPlay("P23", 2, 0.0, 2.5);
    giCameraSetCollide(false);
    giPlayerSetLeader(0);
    giCameraAutoSeek(false);
    giPlayerLock();
    giPlayerCurrentSetPos(7.0, 7.0, -22.0);
    giPlayerCurrentSetAng(180.0);
    giArenaReady();
    giGrantMagicSystem(false, true);
    giGrantSystemUi(4, false);
    giPlayerDoAction(0, "J08", -1, true);
    giAddPlayerEquip(0, 3586);
    giAddPlayerEquip(0, 3501);
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    gi2DSoundPlay("WJ001", 1);
    giFlashInBlack(2.0, false);
    giWait(1.5);
    giCameraRunSingle("002", true);
    gi2DSoundPlay("WJ001", 1);
    giTalk("小山猪：哦咿～哦咿～", "40001");
    giSetPortrait("101G", true);
    giTalk("云天河：爹，孩儿知错了……", "40002");
    gi2DSoundPlay("WJ001", 1);
    giTalk("小山猪：哦咿～哦咿～", "40003");
    giCameraPrepare("MC003");
    giCameraRunSingle("002", true);
    giWait(0.3);
    giCameraRunSingle("003", false);
    giSetPortrait("101E", true);
    giTalk("云天河：……孩儿不该贪睡，不该误了上香的时辰……", "40004");
    giSetPortrait("101E", true);
    giTalk("云天河：不过……说来说去，都怪昨晚山猪叫太凶，害得人直到半夜还睡不着，睡着了又醒不了……", "40005");
    giSetPortrait("101C", true);
    giTalk("云天河：唉～春天早过了，也不晓得它们在乱叫个啥？", "40006");
    gi2DSoundPlay("WJ001", 1);
    giTalk("小山猪：哼唧～哼唧～", "40007");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giCameraRunSingle("004", true);
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：小猪～小猪～小肥猪～你叫再多声“哦咿”也没用，马上把你烤熟了当供品！", "40008");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：呵呵，爹看到香喷喷的肉，心里铁定高兴……", "40009");
    giSetPortrait("101E", true);
    giTalk("云天河：爹以前嘱咐过的，早晚三柱香……你不知道他发起脾气来多可怕……", "40010");
    giSetPortrait("101E", true);
    giTalk("云天河：爹，早上没点的三柱香，孩儿也补上了，还另加了三柱呢～", "40011");
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：……爹，你会原谅孩儿吧？", "40012");
    giSetPortrait("101C", true);
    giTalk("云天河：（……一……二…………）", "40013");
    giCameraPrepare("MC005");
    giCameraRunSingle("002", false);
    giWait(3.5);
    giSetPortrait("101D", true);
    giTalk("云天河：（……三…………）", "40014");
    giCameraWait();
    giWait(0.1);
    giPlayerEndAction(0);
    giCameraPrepare("MC003");
    giCameraRunSingle("004", true);
    giWait(0.3);
    giPlayerDoAction(0, "J16", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：哈哈，看来爹是原谅孩儿了，孩儿这就去烤山猪啦！", "40015");
    giPlayerEndAction(0);
    gi2DSoundPlay("WJ001", 1);
    giTalk("小山猪：哼唧～哼唧～", "40016");
    giWait(1.0);
    gi2DSoundPlay("WJ002", 1);
    giTalk("？？：吼～吼～", "40017");
    giCameraPrepare("MC004");
    giCameraRunSingle("001", true);
    giPlayerSetDir(0, 297.0, false);
    giSetPortrait("101D", false);
    giWait(1.5);
    giTalk("云天河：什么声音？！……是山猪？", "40018");
    gi2DSoundPlay("WJ001", 1);
    giTalk("小山猪：哦咿～哦咿～", "40019");
    giWait(0.5);
    giPlayerSetDir(0, 186.0, true);
    giWait(0.5);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：这倒好！抓一只还引一只，哈哈～", "40020");
    giFlashOutBlack(1.0, true, true);
    giPlayerEndAction(0);
    gi2DSoundPlay("WJ025", 1);
    giWait(0.1);
    giArenaLoad("Q01", "Q01", "", false);
    giPlayerLock();
    giCameraSetCollide(false);
    giIMMBegin();
    giSetObjectVisible("entrance1", false);
    giSetObjectVisible("title01", false);
    giSetNpcVisible("MN001", true);
    giPlayerCurrentSetPos(-575.0, 61.0, -576.0);
    giPlayerCurrentSetAng(318.0);
    giIMMEnd();
    giCameraSetDistOptEnable(false);
    giArenaReady();
    giPlayerRunTo(0, -670.0, 53.0, -465.0, false);
    giCameraPrepare("MC001");
    giCameraRunSingle("002", true);
    giFlashInBlack(1.0, true);
    giPlayerEndMove(0);
    giPlayerSetDir(0, 252.0, true);
    giPlayerDoAction(0, "J13", -1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：山猪……在那边——", "40021");
    giCameraRunSingle("003", true);
    giCameraPrepare("MC002");
    giCameraRunSingle("001", true);
    gi2DSoundPlay("WJ003", 1);
    giNpcDoAction("MN001", "J01", 1, false);
    giWait(1.0);
    giSetObjectVisible("Jeffect001", true);
    giWait(2.0);
    giCameraRunSingle("002", true);
    giWait(0.3);
    gi2DSoundPlay("WJ003", 1);
    giNpcDoAction("MN001", "J01", 1, false);
    giWait(1.0);
    giSetObjectVisible("Jeffect001", true);
    giWait(1.6);
    giNpcEndAction("MN001", true);
    giNpcRunTo("MN001", -2309.0, -113.0, -1440.0, false);
    giWait(2.2);
    giCameraRunSingle("003", true);
    giWait(0.5);
    giSetNpcVisible("MN001", false);
    giSetPortrait("101D", false);
    giTalk("云天河：好家伙，它跑进<colour red=255 green=187 blue=0 alpha=255>石沉溪洞</colour><dc0>了！</dc0>", "40022");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101H", false);
    giTalk("云天河：（爹交代过，那山洞不让进的……我得马上跟去看看！）", "40023");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("101A", false);
    giTalk("云天河：好！<colour red=255 green=187 blue=0 alpha=255>回房拿弓，顺便猎山猪！</colour>", "40024");
    giPlayerDoAction(0, "J16", 1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：（呵呵，八成是小山猪的叫声把它引来了，早上梦见吃烤全猪果然是好兆头～）", "40025");
    giFlashOutBlack(1.5, true, true);
    giCameraSetDistOptEnable(true);
    giSetObjectVisible("entrance1", true);
    global_mvar = 10201; // 0x000027D9, 序章 / 1-1.贡猪祭父 / 回房拿弓箭
    giPlayerCurrentSetPos(-579.0, 56.0, -421.0);
    giPlayerCurrentSetAng(174.0);
    giCameraSetMode(0, true);
    giCameraSeekToPlayer();
    giSetObjectVisible("Jeffect001", false);
    giSetObjectVisible("title01", true);
    giFlashInBlack(1.5, true);
    giShowTutorial(10);
    giPlayerUnLock();
}

void func2002()
{
    int pal_test_result = 0;
    int local_4 = 0;
    int local_5 = 0;

    if (global_mvar == 10201 /* 序章 / 1-1.贡猪祭父 / 回房拿弓箭 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetLeader(0);
        giPlayerCurrentSetPos(82.0, 7.0, -26.0);
        giPlayerCurrentSetAng(73.0);
        giCameraPrepare("MC006");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giWait(1.0);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：（哈哈，今天这顿烤全猪是吃定了～）", "40026");
        giPlayerEndAction(0);
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.5);
        giSetObjectVisible("MO002", false);
        giAddProperty(3103, 1, true);
        giWait(2.0);
        giSetObjectVisible("MO003", false);
        giAddProperty(3241, 1, true);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.6);
        giPlayerRunTo(0, -97.0, 6.0, 45.0, false);
        giWait(0.4);
        giSetPortrait("101K", true);
        giTalk("云天河：哟嚯～～～", "40027");
        giCameraRunSingle("002", false);
        gi2DSoundPlay("WJ004", 1);
        giTalk("小山猪：哦咿～哦咿～哦咿咿咿咿咿咿咿～", "40028");
        giWait(2.2);
        giFlashOutBlack(1.0, true, true);
        pal_test_result = giGetPalTestResult(0);
        local_4 = giGetPalTestResult(1);
        local_5 = giGetPalTestResult(2);
        if (giGetPalTestResult(0) == 1)
        {
            giAddProperty(3030, 10, false);
            giAddProperty(3065, 3, false);
            giAddProperty(3182, 1, false);
            giAddPlayerEquip(0, 3666);
        }
        if (local_4 == 1)
        {
            giAddProperty(3006, 10, false);
            giAddProperty(3062, 5, false);
            giAddProperty(3182, 1, false);
            giAddPlayerEquip(0, 3669);
        }
        if (local_5 == 1)
        {
            giAddProperty(3004, 5, false);
            giAddProperty(3055, 5, false);
            giAddProperty(3182, 1, false);
        }
        giArenaLoad("Q01", "Q01", "", false);
        giPlayerLock();
        giPlayerCurrentSetPos(-537.56, 61.6, -247.15);
        giPlayerCurrentSetAng(4.0);
        giArenaReady();
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 10300; // 0x0000283C, 序章 / 1-2-1.沉溪猎猪 / 进洞抓山猪 / 晚起祭父
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2003()
{
    giPlayerLock();
    giScriptMusicPlay("P01-3", 2, 0.0, 2.5);
    giCameraSetCollide(false);
    giSetNpcVisible("MN004", true);
    giSetNpcVisible("MN003", true);
    giCameraPrepare("MC003");
    giCameraRunSingle("001", true);
    giArenaReady();
    giCGEffPlay(11);
    giNpcDoAction("MN003", "J01", -1, false);
    giCameraRunSingle("002", false);
    giFlashInWhite(3.0, true);
    giWait(2.0);
    giSetPortrait("236A", false);
    giTalk("云天河：喝！——喝！——喝！", "40065");
    giSetPortrait("236A", false);
    giTalk("云天河：喝！——喝！——喝！", "40066");
    giWait(0.3);
    giNpcDoAction("MN004", "C01", 0, false);
    giWait(0.8);
    giSetPortrait("236A", false);
    giTalk("云天河：哟嚯～三百下练完了！", "40067");
    giSetNpcVisible("MN002", true);
    giSetNpcVisible("MN004", false);
    giNpcDoAction("MN002", "J03", 1, false);
    giSetPortrait("236A", false);
    giTalk("云天河：……咦？爹呢？", "40068");
    giWait(0.5);
    giCameraRunSingle("003", true);
    giSetPortrait("236A", false);
    giTalk("云天河：爹……", "40069");
    giWait(0.3);
    giCameraRunSingle("004", false);
    giWait(3.0);
    giCameraRunSingle("005", true);
    giWait(1.1);
    giTalk("云天青：……夙玉，你看这云海雾松，当真是美不胜收，只是这世上没有了你，即使再有千般美景，却也无趣得很。", "40070");
    giWait(0.5);
    giTalk("云天青：呵呵，这道理我也是近些日子才想明白，如今我大限将至，反而觉得心里舒坦许多。待我死后，就同你合葬在石沉溪洞。", "40071");
    giWait(0.5);
    giTalk("云天青：石沉溪洞……洞悉尘世……哈哈哈，这世上又有几人真能做到，求个问心无愧已是很不容易了……", "40072");
    giNpcSetPos("MN002", -141.0, -79.0, 1256.0);
    giNpcSetDir("MN002", 288.0, false);
    giWait(0.8);
    giCameraRunSingle("006", false);
    giTalk("云天青：…………天河，我交代你的三百下挥剑都练完了？", "40073");
    giCameraWait();
    giNpcDoAction("MN002", "J03", 1, false);
    giSetPortrait("236A", true);
    giTalk("云天河：练、练完了。", "40074");
    giNpcEndAction("MN002", true);
    giNpcUnHoldAct("MN003");
    giNpcEndAction("MN003", true);
    giNpcSetDir("MN003", 99.0, false);
    giCameraRunSingle("007", true);
    giWait(0.3);
    giTalk("云天青：好小子，什么不学，学起偷看偷听来了！你当爹和你猎的那些兔子一样，耳朵不灵便呐？", "40075");
    giNpcRunTo("MN002", -249.0, -102.0, 1290.0, true);
    giNpcSetDir("MN002", 285.0, true);
    giWait(0.4);
    giNpcDoAction("MN002", "J02", 1, false);
    giSetPortrait("236A", true);
    giTalk("云天河：不是啊，爹！孩儿、孩儿肚子饿，想叫你一起吃饭。", "40076");
    giNpcEndAction("MN002", false);
    giTalk("云天青：吃吃吃！你这野小子除了又吃又睡又玩，还会想什么？", "40077");
    giNpcDoAction("MN002", "J03", 1, false);
    giSetPortrait("236A", true);
    giTalk("云天河：呵呵，爹～", "40078");
    giNpcEndAction("MN002", false);
    giTalk("云天青：算了，今日有其他事要交代你，爹说的每一句话，你都要牢牢记住，知道吗？", "40079");
    giSetPortrait("236A", true);
    giTalk("云天河：……嗯！", "40080");
    giTalk("云天青：有朝一日爹离开人世，就和你娘合葬在石沉溪洞里……", "40081");
    giTalk("云天青：一切我都已安排妥当，洞口设有机关，寻常人绝对无法乱闯，你也不用费什么心，如果想尽孝道，对我牌位早晚三柱香便是。至于你娘……多年来未曾给她立个牌位，那也是她的意思，我们都不要拂逆吧。", "40082");
    giTalk("云天青：……干嘛？瞧你一张苦瓜脸。 ", "40083");
    giNpcDoAction("MN002", "J03", 1, false);
    giSetPortrait("236A", true);
    giTalk("云天河：爹，孩儿不要你离开……就剩孩儿一个，没人陪着玩了！", "40084");
    giTalk("云天青：…………", "40085");
    giTalk("云天青：……小子，爹得去陪你娘，再说你整天上蹿下跳，玩得不是很乐吗？", "40086");
    giTalk("云天青：记好了！爹教你的剑术，你练到不好不坏，足以自保就行。我云天青的儿子，岂能受人欺负？", "40087");
    giSetPortrait("236A", true);
    giTalk("云天河：爹，我…………", "40088");
    giNpcDoAction("MN003", "J01", -1, false);
    giTalk("云天青：听不明白也无妨，记在心里，你现在年纪还小，终有一日会明白的。", "40089");
    giSetPortrait("236A", true);
    giTalk("云天河：是，爹。", "40090");
    giTalk("云天青：……好孩子……", "40091");
    giNpcUnHoldAct("MN003");
    giNpcEndAction("MN003", true);
    giWait(0.5);
    giNpcSetDir("MN003", 19.0, true);
    giCameraRunSingle("008", true);
    giWait(0.7);
    giTalk("云天青：夙玉啊夙玉，我若离开，唯一放心不下的就是天河。这些年来，我从未让他下过山，也不知是做对还是做错了……", "40092");
    giWait(0.5);
    giTalk("云天青：夙玉，你告诉过我，死生在手，变化由心，地不能埋，天不能煞，此之为我命在我也，不在于天，莫非早就料到今日之局？", "40093");
    giWait(0.5);
    giTalk("云天青：……唉，也罢，天河的命自是交由他自己，我再多操心过问也是无用……", "40094");
    giFlashOutWhite(3.0, true, true);
    giCGEffStop();
    global_mvar = 10602; // 0x0000296A
    giArenaLoad("M01", "1", "", false);
}

void func2004()
{
    giPlayerLock();
    giScriptMusicPlay("P23", 2, 0.0, 0.0);
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giPlayerSetPos(0, -168.0, 6.0, 40.0);
    giPlayerSetAng(0, 213.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, -118.0, 6.0, 44.0);
    giPlayerSetAng(1, 154.0);
    giPlayerSetVisible(1, true);
    giSetObjectVisible("MO001", true);
    giSetObjectVisible("MO002", true);
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.5, false);
    giArenaReady();
    giWait(1.8);
    giPlayerDoAction(0, "J02", -1, false);
    giSetPortrait("101D", true);
    giTalk("云天河：屋子里变这么乱！！是、是我爹！！他来过了！", "40348");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J15", 0, false);
    giSetPortrait("101H", true);
    giTalk("云天河：怎么办怎么办怎么办啊！他生气了、他生气了……", "40349");
    giPlayerSetDir(1, 250.0, true);
    giWait(0.5);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（……又开始发疯了……）", "40350");
    giWait(1.0);
    giCameraRunSingle("002", true);
    giPlayerWalkTo(1, 36.0, 6.0, -11.0, true);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：……", "40351");
    giPlayerSetDir(1, 195.0, true);
    giWait(0.5);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：……这是……", "40352");
    giPlayerDoAction(1, "J03", -1, false);
    giWait(1.5);
    giSetObjectVisible("MO001", false);
    giWait(0.5);
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerSetDir(1, 275.0, false);
    giCameraRunSingle("003", false);
    giCameraWait();
    giWait(0.5);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（……唉，还在发疯……）", "40353");
    giPlayerDoAction(1, "Z09", 1, false);
    giWait(0.3);
    gi2DSoundPlay("WJ043", 1);
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J21", 1, true);
    giSetPortrait("101E", true);
    giTalk("云天河：……好痛……", "40354");
    giPlayerEndAction(0);
    giPlayerSetDir(0, 109.0, true);
    giSetPortrait("101E", true);
    giTalk("云天河：……干嘛又扔我……", "40355");
    giSetPortrait("103F", false);
    giTalk("韩菱纱：你冷静一下！过来看看这是什么？", "40356");
    giPlayerDoAction(0, "J14", 1, true);
    giWait(0.5);
    giPlayerWalkTo(0, -5.0, 6.0, 36.0, false);
    giCameraRunSingle("004", true);
    giWait(2.8);
    giPlayerSetDir(1, 336.0, false);
    giPlayerEndMove(0);
    giPlayerSetDir(0, 147.0, true);
    giPlayerDoAction(1, "C07", -1, true);
    giWait(0.5);
    giSetObjectVisible("MO008", true);
    giWait(1.5);
    giSetPortrait("101C", true);
    giTalk("云天河：这是……爹的牌位？", "40357");
    giSetObjectVisible("MO008", false);
    giWait(0.5);
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：上面刻着“云天青”，我想应该是你爹的名字。", "40358");
    giSetPortrait("103C", false);
    giTalk("韩菱纱：……云天青、云天河……父子俩的名字只差一个字，真少见，该不会你爹给你取名，也是用给“这是剑”取名的方法吧……", "40359");
    giSetPortrait("101A", true);
    giTalk("云天河：爹说过，我的名字是娘取的。", "40360");
    giSetPortrait("103C", false);
    giTalk("韩菱纱：（……一家人都很古怪……）", "40361");
    giSetPortrait("103A", false);
    giTalk("韩菱纱：这牌位是我从地上捡起来的……你爹发再大脾气，也不会把自己的牌位都扔地上吧？", "40362");
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：话是这么说没错，但是……", "40363");
    giPlayerEndAction(0);
    giPlayerDoAction(1, "J13", -1, false);
    giSetPortrait("103C", false);
    giTalk("韩菱纱：你再好好想想，没有其他人会来这里？", "40364");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerSetDir(0, 268.0, true);
    giWait(0.5);
    giSetPortrait("101C", true);
    giTalk("云天河：……", "40365");
    giPlayerDoAction(0, "J03", -1, true);
    giWait(1.0);
    giSetPortrait("101B", true);
    giTalk("云天河：……哈、哈哈、哈哈哈！知道了，是那只山猪！绝对没错！它的蹄印还留在这呢！", "40366");
    giSetPortrait("103C", false);
    giTalk("韩菱纱：什么山猪？ ", "40367");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetDir(0, 147.0, false);
    giCameraRunSingle("005", true);
    giWait(0.3);
    giSetPortrait("101B", true);
    giTalk("云天河：就是我们在石沉溪洞里看到的那只！", "40368");
    giSetPortrait("101B", true);
    giTalk("云天河：我抓了只小山猪给爹做供品，也不知是不是那只大猪的孩子，大猪就毁我房子，把小猪带走了。", "40369");
    giSetPortrait("103D", false);
    giTalk("韩菱纱：…………", "40370");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：呃，我猜的……", "40371");
    giPlayerEndAction(0);
    giSetPortrait("103C", false);
    giTalk("韩菱纱：真想不到，人虽是万物灵长，但爱子心切，连山猪也是一样。", "40372");
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101G", true);
    giTalk("云天河：唉，可惜了一顿香喷喷的烤猪，下次再给我遇上，绝不放过！", "40373");
    giPlayerDoAction(1, "J17", -1, false);
    giSetPortrait("103I", false);
    giTalk("韩菱纱：喂！你这野人，怎么连一点同情心也没有？", "40374");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101D", true);
    giTalk("云天河：……你才奇怪，我不吃它们就会饿死啊。", "40375");
    giSetPortrait("103I", false);
    giTalk("韩菱纱：就算是这样，也不用说那么冷血吧！", "40376");
    giSetPortrait("101D", true);
    giTalk("云天河：你生什么气？爹说活着的东西都是要死的。", "40377");
    giSetPortrait("103D", false);
    giTalk("韩菱纱：……", "40378");
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103H", false);
    giTalk("韩菱纱：是啊，你们说的都对，可是就算结果都一样，各人的命还是不一样呐……", "40379");
    giPlayerEndAction(1);
    giSetPortrait("101C", true);
    giTalk("云天河：你说什么？", "40380");
    giPlayerDoAction(1, "C09", 1, true);
    giWait(0.5);
    giPlayerWalkTo(1, -106.0, 6.0, 57.0, false);
    giWait(1.0);
    giPlayerSetDir(0, 263.0, true);
    giWait(0.7);
    giSetPortrait("101C", false);
    giTalk("云天河：爹说的对，女孩子有时候很古怪。", "40381");
    giSetPortrait("101A", false);
    giTalk("云天河：不管她～赶快收拾东西！", "40382");
    giCameraRunSingle("006", true);
    giPlayerWalkTo(0, 26.0, 6.0, -19.0, true);
    giPlayerSetDir(0, 186.0, true);
    giWait(0.5);
    giPlayerDoAction(0, "J08", -1, true);
    giWait(0.3);
    giSetObjectVisible("MO003", true);
    giWait(1.2);
    giCameraRunSingle("007", false);
    giSetPortrait("101E", true);
    giTalk("云天河：……爹……孩儿要下山去了……", "40383");
    giSetPortrait("101E", true);
    giTalk("云天河：孩儿真的很想知道，你和娘……你们到底………………真是菱纱说的剑仙吗……", "40384");
    giSetPortrait("101E", true);
    giTalk("云天河：你留给我的剑，怎么有那么大的力量……一百只大山猪加起来大概也没它厉害……", "40385");
    giSetPortrait("101G", true);
    giTalk("云天河：……墓室毁了……都是孩儿的错，和菱纱无关……", "40386");
    giSetPortrait("101G", true);
    giTalk("云天河：爹你说过的，用剑不能心浮气躁，孩儿那时却心里慌张，控制不住力道……爹，你要罚就罚吧……", "40387");
    giSetPortrait("101F", true);
    giTalk("云天河：不过……你要是有其他事，晚一天，不不不，晚几天再来也没关系……", "40388");
    giSetPortrait("101F", true);
    giTalk("云天河：爹，刚才说的那些都是真的……所以，晚上不用来找孩儿了，孩儿不在……", "40389");
    giSetPortrait("101A", true);
    giTalk("云天河：（老爹的早晚三柱香绝不能少，牌位和香炉都得带着……其他也没什么要带了。）", "40390");
    giSetObjectVisible("MO003", false);
    giAddProperty(3245, 1, true);
    giWait(2.5);
    giSetObjectVisible("MO002", false);
    giAddProperty(3246, 1, true);
    giWait(2.0);
    giPlayerSetPos(1, -185.0, 6.0, 19.0);
    giPlayerSetAng(1, 99.0);
    giPlayerDoAction(1, "C10", 0, false);
    giCameraRunSingle("008", false);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerWalkTo(0, -31.0, 6.0, 41.0, true);
    giPlayerWalkTo(0, -126.0, 6.0, -1.0, true);
    giPlayerSetDir(0, 274.0, true);
    giSetPortrait("101A", false);
    giTalk("云天河：你饿了？没力气站？", "40391");
    giCameraRunSingle("009", true);
    giWait(0.3);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：以为谁都像你啊，就知道吃。", "40392");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：我在想，这火炉这么大，看样子你爹真的很怕冷？", "40393");
    giSetPortrait("101A", false);
    giTalk("云天河：嗯，除了夏天，炉子都得点着，火要是熄了，爹会冷得受不了。", "40394");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：这到底是什么怪病？ ", "40395");
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101A", false);
    giTalk("云天河：不知道，听说娘比爹更怕冷，大概他们身体都不够壮吧。", "40396");
    giPlayerEndAction(0);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：（……歪理，猪那么壮，还不是一样会冷……）", "40397");
    giSetPortrait("103A", true);
    giTalk("韩菱纱：对了，你东西都收差不多了？", "40398");
    giSetPortrait("101A", false);
    giTalk("云天河：嗯，重要的都拿了，<colour red=255 green=187 blue=0 alpha=255>得再去树屋一趟，</colour><dc0>走吧！</dc0>", "40399");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：<colour red=255 green=187 blue=0 alpha=255>树屋？是在房子旁边的那棵大树上？</colour>", "40400");
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：对啊，<colour red=255 green=187 blue=0 alpha=255>沿着树干上去就行了～</colour>", "40401");
    giPlayerEndAction(0);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：（……不愧是野人，和猴子一样上蹿下跳的……）", "40402");
    giFlashOutBlack(1.5, true, true);
    giPlayerEndAction(1);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(0, false);
    giPlayerCurrentSetVisible(true);
    global_mvar = 11500; // 0x00002CEC, 序章 / 1-4-1.入世 / 树屋取物
    giPlayerCurrentSetPos(-139.0, 6.0, 52.0);
    giPlayerCurrentSetAng(5.0);
    giCameraSetMode(2, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giScriptMusicStop(1, 2.5);
    giPlayerUnLock();
}

void func2005()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giPlayerSetPos(0, -77.0, 1.0, -4.0);
    giPlayerSetAng(0, 93.0);
    giPlayerSetPos(1, -77.0, 1.0, -4.0);
    giPlayerSetAng(1, 93.0);
    giPlayerSetVisible(1, true);
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.0, false);
    giPlayerWalkTo(1, 43.0, 0.0, 13.0, false);
    giArenaReady();
    giPlayerEndMove(1);
    giPlayerSetDir(1, 110.0, true);
    giWait(1.0);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：……", "40403");
    giPlayerSetVisible(0, true);
    giWait(1.0);
    giPlayerWalkTo(0, -20.0, 0.0, -7.0, true);
    giPlayerSetDir(0, 180.0, true);
    giWait(0.5);
    giPlayerDoAction(0, "J03", -1, true);
    giWait(0.5);
    giSetPortrait("101A", true);
    giTalk("云天河：止血草、鼠儿果……", "40404");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：这儿风景真好！看来你爹娘都是有心人。", "40405");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：……以后我年纪大了，也来这儿住，不问江湖世事。……要是真有那么一天，该多好啊……", "40406");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetDir(0, 74.0, false);
    giCameraRunSingle("002", true);
    giWait(0.5);
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：风景看来看去还不都一样，不过住这里好哇！到处都能猎到好吃的野味！", "40407");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetDir(1, 257.0, true);
    giWait(0.3);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：野人！跟你说也白说！收拾好了没？", "40408");
    giSetPortrait("101B", true);
    giTalk("云天河：好了，带了些止血草在身边，还有鼠儿果。", "40409");
    giAddProperty(3000, 5, true);
    giWait(2.2);
    giAddProperty(3006, 5, true);
    giWait(2.2);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：看不出哟～你不懂世事，疗伤本事倒不含糊。", "40410");
    giPlayerEndAction(1);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：会吗？用草药是爹教我的。力气大的野兽没两下就挣脱陷阱了，受伤是常有的事。", "40411");
    giPlayerEndAction(0);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：这么说来，你的弓也使得很好啰？", "40412");
    giSetPortrait("101B", true);
    giTalk("云天河：还、还好吧，用左手还射得挺准，换用右手虽然力量大了很多，可就是容易射偏了。", "40413");
    giPlayerDoAction(1, "J14", -1, false);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：挺厉害的嘛，还能左右开弓！我一路上山，光是应付那些猪啊熊啊就累得够呛，等下就靠你啦！", "40414");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：没问题，连爹都夸我打猎功夫高明呢！", "40415");
    giPlayerEndAction(0);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：（臭美～～你大概也就这么一个长处了……）", "40416");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：那块玉带了没？", "40417");
    giSetPortrait("101B", true);
    giTalk("云天河：带了呀。", "40418");
    giSetPortrait("103B", false);
    giTalk("韩菱纱：不要再待一会儿？", "40419");
    giPlayerDoAction(0, "J05", 1, false);
    giSetPortrait("101F", true);
    giTalk("云天河：呃……不用了。", "40420");
    giPlayerEndAction(0);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：嘻嘻……", "40421");
    giCameraRunSingle("003", false);
    giPlayerRunTo(0, -77.0, 1.0, -4.0, false);
    giFlashOutBlack(0.7, true, true);
    giCameraRunSingle("001", true);
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(0, false);
    giPlayerCurrentSetVisible(true);
    giArenaLoad("Q01", "Q01", "", false);
    giPlayerLock();
    giCameraSetCollide(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, 382.0, 614.0, -973.0);
    giPlayerSetAng(0, 96.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 934.0, 969.0, -973.0);
    giPlayerSetAng(1, 269.0);
    giPlayerSetVisible(1, true);
    giSetObjectVisible("entrance2", true);
    giSetObjectVisible("title02", false);
    giIMMEnd();
    giCameraSetDistOptEnable(false);
    giCameraPrepare("MC004");
    giCameraRunSingle("002", true);
    giFlashInBlack(2.0, false);
    giArenaReady();
    giWait(1.2);
    giPlayerWalkTo(1, 790.5799, 895.1293, -989.8825, true);
    giPlayerSetDir(1, 282.0, true);
    giWait(1.0);
    giPlayerDoAction(0, "J19", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：喂～～～走快点吧！不然天要黑了！", "40422");
    giPlayerEndAction(0);
    giPlayerRunTo(0, 359.0, 537.0, -888.0, true);
    giPlayerSetVisible(0, false);
    giWait(1.0);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：瞎～说～～明明离天黑还早得很，肯定是心虚。", "40423");
    giCameraRunSingle("003", false);
    giWait(0.8);
    giShowPoetry(1, true);
    giWait(1.2);
    giFlashOutBlack(1.5, true, true);
    giScriptMusicPause();
    giPlayMovie("Pal4B.bik");
    giOpenMovieFlag(2);
    giSetFullHP();
    giSetFullMP();
    giPlayerSetVisible(1, false);
    giPlayerCurrentSetVisible(true);
    giCameraSetDistOptEnable(true);
    global_mvar = 20200; // 0x00004EE8, 入世下山
    giScriptMusicResume();
    giArenaLoad("M02", "1", "", false);
    giPlayerLock();
    giCameraSetCollide(false);
    giPlayerCurrentSetPos(-30.0, -140.0, 143.0);
    giPlayerCurrentSetAng(162.0);
    giCameraSetMode(0, true);
    giCameraSeekToPlayer();
    giPlayerUnLock();
    giFlashInBlack(2.0, false);
    giArenaReady();
}

void func2006()
{
    if (global_mvar == 10201 /* 序章 / 1-1.贡猪祭父 / 回房拿弓箭 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -564.4598, 58.3323, -447.0535, true);
        giPlayerSetDir(0, 175.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101B", true);
        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>先回房拿弓，</colour><dc0>再去石沉溪洞猎山猪～</dc0>", "");
        giPlayerUnLock();
    }
}

void func2007()
{
    if (global_mvar >= 20200 /* 入世下山 */)
    {
        if (global_mvar == 160500 /* 第四章 / 9-5-1.欢乐苦短 / 进入木屋 */)
        {
            giPlayerLock();
            giPlayerWalkTo(1, -3045.6504, -410.8017, 490.8477, true);
            giPlayerSetDir(1, 26.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("103A", true);
            giTalk("韩菱纱：<colour red=255 green=187 blue=0 alpha=255>先进小木屋吧，</colour><dc0>天河还在等着呢。</dc0>", "");
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -3045.6504, -410.8017, 490.8477, true);
        giPlayerSetDir(0, 26.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101C", true);
        giTalk("云天河：那边好像是下山的路，现在不用过去吧……", "");
        giPlayerUnLock();
    }
}

void func2008()
{
    if (global_mvar == 160400 /* 第四章 / 9-4-1.步虚词终 / 重回青鸾峰 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P23", 2, 0.0, 2.5);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -391.3253, -115.2286, 1115.4993);
        giPlayerSetPos(1, -384.3326, -116.2613, 1172.7255);
        giPlayerSetPos(3, -330.602, -118.753, 1154.2588);
        giPlayerSetAng(0, 208.0);
        giPlayerSetAng(1, 202.0);
        giPlayerSetAng(3, 242.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("title01", false);
        giSetObjectVisible("tip03", false);
        giCameraPrepare("MC005");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(2.3, false);
        giArenaReady();
        giCameraSetDistOptEnable(false);
        giWait(2.0);
        giCameraRunSingle("002", false);
        giWait(2.5);
        giPlayerDoAction(0, "J23", -1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：啊～～～～～～！！", "46337");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraWait();
        giWait(0.5);
        giPlayerDoAction(0, "J23", -1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：我回来啦！！好～高～兴～呀！！", "46338");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.8);
        giSetPortrait("105B", false);
        giTalk("慕容紫英：这里便是青鸾峰？", "46339");
        giWait(0.8);
        giPlayerSetDir(0, 58.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "C08", 1, true);
        giSetPortrait("101M", true);
        giTalk("云天河：对啊，我从小就住这儿，山上很好玩的！能打野猪、吃烤肉、抓松鼠！", "46340");
        giWait(0.5);
        giPlayerRunTo(0, -444.2983, 15.1868, 708.9011, false);
        giWait(0.3);
        giIMMBegin();
        giPlayerSetAng(3, 198.0);
        giPlayerSetAng(1, 186.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giPlayerEndMove(0);
        giWait(0.5);
        giPlayerSetDir(0, 8.0, true);
        giCameraRunSingle("004", false);
        giPlayerDoAction(0, "J19", 1, false);
        giSetPortrait("101M", true);
        giTalk("云天河：那边就是我的房子！", "46341");
        giPlayerEndAction(0);
        giPlayerSetDir(0, 178.0, false);
        giCameraRunSingle("005", true);
        giWait(0.6);
        giCameraRunSingle("006", false);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：哈，这么久没回来，还是老样子。", "46342");
        giPlayerEndAction(0);
        giPlayerSetDir(0, 8.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：你们看，你们看！哈哈～", "46343");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.3);
        giPlayerRunTo(0, -478.557, 61.7097, 7.7405, false);
        giWait(2.5);
        giIMMBegin();
        giPlayerSetPos(1, -399.0969, -110.6678, 1403.4761);
        giPlayerSetAng(1, 176.0);
        giPlayerSetPos(3, -355.5517, -109.0797, 1387.3906);
        giPlayerSetAng(3, 196.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：野人一回到山上，就是不一样，好久没见天河这样上蹿下跳了。", "46344");
        giWait(0.8);
        giPlayerSetDir(1, 8.0, true);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetDir(3, 328.0, false);
        giPlayerSetPos(0, -243.7404, -102.0927, 1286.4426);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giWait(1.0);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：以前无忧无虑的日子一直是他最想念的。", "46345");
        giWait(0.8);
        giSetPortrait("101K", true);
        giTalk("云天河：哇！山猪！我看到你了，别跑！哈哈～", "46346");
        gi2DSoundPlay("WJ038", 1);
        giPlayerRunTo(0, -517.7743, -91.217, 1344.529, true);
        giWait(3.0);
        gi2DSoundPlay("WJ038", 1);
        giPlayerRunTo(0, -421.8004, -102.5444, 1358.4961, true);
        giPlayerSetAng(0, 126.0);
        giPlayerDoAction(0, "J13", 1, true);
        giSetPortrait("101K", false);
        giTalk("云天河：山猪！你跑不掉了～", "46347");
        gi2DSoundPlay("WJ038", 1);
        giPlayerRunTo(0, -243.7404, -102.0927, 1286.4426, true);
        giWait(0.7);
        giSetPortrait("105B", true);
        giTalk("慕容紫英：……他一个人，在这待了十几年？", "46348");
        giWait(0.5);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：是啊，横行霸道，像个山大王似的。", "46349");
        giWait(0.5);
        giPlayerRunTo(0, -517.7743, -91.217, 1344.529, false);
        giSetPortrait("101K", true);
        giTalk("云天河：哟嚯～哈哈哈哈～", "46350");
        giPlayerEndMove(0);
        giWait(0.5);
        giCameraRunSingle("010", false);
        giWait(0.8);
        giSetPortrait("105B", false);
        giTalk("慕容紫英：……一人当大王，那兵是谁？", "46351");
        giWait(0.5);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：……可能是那些猪吧……", "46352");
        giWait(0.5);
        giPlayerSetDir(3, 312.0, true);
        giWait(0.3);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：……", "46353");
        giWait(0.5);
        giPlayerSetDir(1, 132.0, true);
        giWait(0.5);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：……", "46354");
        giWait(0.5);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：……", "46355");
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：噗……呵呵……呵呵呵呵……", "46356");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105G", false);
        giTalk("慕容紫英：哈哈……哈哈哈……", "46357");
        giWait(0.8);
        giCameraRunSingle("011", true);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：我还是第一次看紫英你这样开怀的笑呢～", "46358");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105G", true);
        giTalk("慕容紫英：嗯……确实……大概是被天河现在的心情影响了。", "46359");
        giWait(0.7);
        giIMMBegin();
        giPlayerSetPos(0, -1121.4172, -127.2378, 872.471);
        giPlayerSetAng(0, 190.3224);
        giCameraRunSingle("012", true);
        giIMMEnd();
        giWait(1.0);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：奇怪，猪不见了！", "46360");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, -400.8683, -5.2544, 762.4618);
        giCameraRunSingle("013", false);
        giIMMEnd();
        giWait(0.5);
        giPlayerRunTo(0, -395.9218, 51.5512, 571.627, true);
        giPlayerSetAng(0, 238.0);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.8);
        giSetPortrait("101M", false);
        giTalk("云天河：算了……改天再跟你玩捉迷藏，我赢就吃你，我输就下次再吃你，哈哈～", "46361");
        giWait(0.8);
        giPlayerSetDir(0, 6.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J19", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：你们快来，进屋来！看看有没有那本书……", "46362");
        giPlayerEndAction(0);
        giPlayerRunTo(0, -447.6624, 61.7096, -25.5705, false);
        giWait(0.3);
        giCameraRunSingle("014", true);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giCameraRunSingle("015", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：紫英小时候呢？是什么样子的？从来没有听你提过。", "46363");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.8);
        giCameraRunSingle("016", false);
        giSetPortrait("105B", true);
        giTalk("慕容紫英：……我六岁即被送往琼华派修行，在家中的那些日子，只依稀记得是锦衣玉食，并不为吃穿所累。", "46364");
        giPlayerDoAction(1, "C08", 1, false);
        giWait(0.6);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：唔，那你真是了不起，过惯了富贵日子，到山上还能忍受清淡。", "46365");
        giWait(0.5);
        giSetPortrait("105B", true);
        giTalk("慕容紫英：那没什么了不起……比起天河自幼失去双亲，在山林中自求生存，我所得到的，已经太多……", "46366");
        giWait(0.5);
        giCameraRunSingle("017", true);
        giWait(0.8);
        giSetPortrait("105B", false);
        giTalk("慕容紫英：初时我只觉天河单纯异常、不懂世事，如今才知他过得辛苦，却难得保持一颗赤子之心，我又有什么资格去对他品头论足……实在惭愧……", "46367");
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：哎，小紫英～你又来了……", "46368");
        giWait(0.5);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：对自己别那么苛刻嘛，照你这么说，没吃过苦的人就一定比不上吃过苦的人啰？嘻，我可觉得你比天河那只野猴子强多了。再说我看天河在山上过挺开心的，自得其乐得很。", "46369");
        giIMMBegin();
        giSetNpcVisible("MN001", true);
        giNpcSetPos("MN001", -598.7429, -104.7437, 1033.1434);
        giNpcSetAng("MN001", 26.0);
        giCameraRunSingle("019", false);
        giIMMEnd();
        giWait(1.0);
        giNpcWalkTo("MN001", -495.1502, -93.0199, 1241.305, false);
        giCameraWait();
        giPlayerSetDir(1, 206.0, false);
        giPlayerSetDir(3, 244.0, true);
        giNpcEndMove("MN001");
        gi2DSoundPlay("WJ038", 1);
        giNpcDoAction("MN001", "J01", 1, false);
        giWait(1.0);
        giSetObjectVisible("Jeffect001", true);
        giTalk("山猪：哼唧、哼唧～～～", "46370");
        giWait(0.8);
        giNpcEndAction("MN001", true);
        giNpcRunTo("MN001", -685.9022, -99.7825, 844.7329, true);
        giSetNpcVisible("MN001", false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：…………", "46371");
        giWait(0.8);
        giSetPortrait("105G", false);
        giTalk("慕容紫英：……", "46372");
        giCameraRunSingle("020", false);
        giWait(0.5);
        giPlayerSetDir(1, 118.0, true);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：走吧、走吧，<colour red=255 green=187 blue=0 alpha=255>我们进屋去，</colour><dc0>不然天河那家伙要来催了！</dc0>", "46373");
        giWait(0.5);
        giPlayerSetDir(3, 294.0, true);
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, true);
        giWait(0.3);
        giFlashOutBlack(1.5, true, true);
        giCameraSetDistOptEnable(true);
        giCameraRunSingle("017", true);
        giIMMBegin();
        giPlayerSetLeader(1);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giSetObjectVisible("title01", true);
        giSetObjectVisible("sound002", true);
        giSetObjectVisible("Jeffect001", false);
        giSetObjectVisible("tip03", true);
        giIMMEnd();
        global_mvar = 160500; // 0x000272F4, 第四章 / 9-5-1.欢乐苦短 / 进入木屋
        giPlayerCurrentSetPos(-428.9936, -103.6266, 1335.6499);
        giPlayerCurrentSetAng(164.0);
        giCameraSetMode(0, true);
        giFlashInBlack(1.5, true);
        giPlayerOutTeam(0, false);
        giPlayerUnLock();
    }
}

void func2009()
{
    if (global_mvar == 160500 /* 第四章 / 9-5-1.欢乐苦短 / 进入木屋 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P24", 2, 2.5, 0.0);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerInTeam(0, false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 97.6556, 6.0647, -33.2431);
        giPlayerSetPos(1, -45.8922, 6.0766, 28.6882);
        giPlayerSetPos(3, -104.3024, 6.0832, 52.3376);
        giPlayerSetAng(0, 68.0);
        giPlayerSetAng(1, 86.0);
        giPlayerSetAng(3, 110.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("MO004", true);
        giSetObjectVisible("MO005", true);
        giSetObjectVisible("MO006", true);
        giSetObjectVisible("MO007", true);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giArenaReady();
        giFlashInBlack(1.0, true);
        giWait(0.8);
        giPlayerWalkTo(1, 99.0782, 6.1147, 36.6445, false);
        giWait(0.3);
        giCameraRunSingle("002", false);
        giWait(0.3);
        giPlayerWalkTo(3, 36.5931, 6.1324, 6.246, false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 190.0, true);
        giWait(0.8);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：怎样？找到了吗？", "46374");
        giWait(0.3);
        giCameraRunSingle("003", false);
        giPlayerDoAction(0, "C09", 1, true);
        giPlayerSetDir(0, 8.0, true);
        giWait(0.5);
        giSetPortrait("101E", false);
        giTalk("云天河：……爹留下的书，没烧掉的，都在这儿了，不过没一本是和铸剑有关的……", "46375");
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：你啊，平时就大大咧咧，说不定看漏了，我和紫英再仔细瞧瞧。", "46376");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：哦，好……", "46377");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giWait(1.5);
        giCameraWait();
        giIMMBegin();
        giPlayerSetPos(0, 48.4719, 6.1018, -17.7345);
        giPlayerSetAng(0, 50.0);
        giPlayerSetPos(1, 104.4411, 6.1147, 17.9333);
        giPlayerSetAng(1, 150.0);
        giPlayerSetPos(3, 98.039, 6.0647, -44.8144);
        giPlayerSetAng(3, 66.0);
        giIMMEnd();
        giFlashInBlack(1.5, true);
        giWait(0.8);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：没有……真的没有，都翻遍了……", "46378");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……", "46379");
        giWait(0.5);
        giPlayerSetDir(1, 242.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：不用指望啦，一定是被这笨蛋给烧了……", "46380");
        giWait(0.3);
        giPlayerSetDir(3, 304.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J15", 0, false);
        giWait(0.3);
        giSetPortrait("101H", true);
        giTalk("云天河：怎么办、怎么办……", "46381");
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(0, 62.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：天河，云前辈留下的东西，全在这里了？", "46382");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.3);
        giPlayerSetDir(0, 95.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：其他就只有些锅子什么的……", "46383");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.4);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：算了……虽然空欢喜一场……但是回到青鸾峰还是一件很高兴的事。", "46384");
        giWait(0.4);
        giPlayerSetDir(3, 24.0, true);
        giWait(0.3);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：至此定论，为时尚早……我在想，如此重要之物，云前辈既然并无交代，或许他根本没有留给天河……", "46385");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 4.0);
        giPlayerSetAng(0, 116.0);
        giPlayerSetAng(1, 195.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……！紫英，你是说……？", "46386");
        giWait(0.5);
        giCameraRunSingle("006", false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：天河说过，前辈在山洞中修了一间隐秘的墓室，他是否会将手记带入墓中？或藏于其他地方？", "46387");
        giWait(0.3);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：咦……！！", "46388");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：……呃，那个……爹和娘的墓都塌了，难不成还要挖开？！", "46389");
        giPlayerEndAction(0);
        giPlayerSetDir(0, 60.0, false);
        giIMMBegin();
        giPlayerSetAng(3, 22.0);
        giPlayerSetAng(1, 238.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：好！为了菱纱……我现在去挖！！", "46390");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：慢……等等！墓中、墓中……", "46391");
        giWait(1.5);
        giPlayerDoAction(1, "C07", -1, false);
        giWait(0.75);
        giSetObjectVisible("MO009", true);
        giWait(0.4);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：手记……手记会不会是这一本？！", "46392");
        giWait(0.5);
        giSetPortrait("101D", false);
        giTalk("云天河：啥？你哪来的？我瞧瞧。", "46393");
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giWait(0.5);
        giIMMBegin();
        giSetObjectVisible("MO009", false);
        giSetObjectVisible("MO010", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetObjectVisible("MO010", false);
        giWait(0.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.0);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：奇怪，这什么？上面的字都看不懂，涂涂画画的……", "46394");
        giWait(0.3);
        giPlayerFaceToPlayer(3, 0, true);
        giPlayerWalkTo(3, 83.9092, 6.0647, -41.2915, true);
        giWait(0.3);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：拿来我看一下！", "46395");
        giWait(0.5);
        giPlayerSetDir(0, 100.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giWait(0.7);
        giSetObjectVisible("MO011", true);
        giWait(0.8);
        giSetObjectVisible("MO011", false);
        giWait(0.7);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(2.0);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：这确是师公的笔迹！", "46396");
        giWait(0.5);
        giPlayerSetAng(1, 215.0);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：真的？！紫英，你看得懂这些符号？", "46397");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(3, 38.0, true);
        giWait(0.3);
        giCameraRunSingle("008", false);
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105B", false);
        giTalk("慕容紫英：这并非符号，而是一种数百年传承的秘形文字，只有真正懂得琼华派铸剑秘术的人方能读懂！寻常人看来自是一头雾水。", "46398");
        giPlayerEndAction(3);
        giSetPortrait("105B", false);
        giTalk("慕容紫英：菱纱，师公的手记，你从何处得来？", "46399");
        giWait(0.3);
        giPlayerSetDir(0, 62.0, false);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：啊？……嗯……这个…………", "46400");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：对啊，为什么青阳长老给爹的东西，会在你那里？", "46401");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerSetDir(1, 238.0, true);
        giWait(0.3);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……其实……也没什么啦……", "46402");
        giWait(0.8);
        giSetPortrait("101D", false);
        giTalk("云天河：那，到底是什么？", "46403");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 48.0);
        giPlayerSetAng(3, 16.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：哎呀，不就是当初和你进到墓室里，我看见放灵光藻玉的台子上有本书，一时手快，忍不住就拿了嘛……不过，你好像没注意到……", "46404");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：怎么可能？你动作有那么快？", "46405");
        giPlayerDoAction(1, "C12", 1, false);
        giWait(0.8);
        giSetPortrait("103G", false);
        giTalk("韩菱纱：哼，也不想想我是做什么的，不眼疾手快怎行？", "46406");
        giPlayerEndAction(1);
        giSetPortrait("101D", true);
        giTalk("云天河：…………", "46407");
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103G", false);
        giTalk("韩菱纱：好啦，瞒着你是我不对……我错了还不行吗？……", "46408");
        giWait(0.8);
        giSetPortrait("101D", true);
        giTalk("云天河：…………后来，你就一直把手记带在身上？", "46409");
        giWait(0.3);
        giPlayerDoAction(1, "C08", 1, true);
        giWait(0.3);
        giPlayerSetDir(1, 34.0, true);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103G", false);
        giTalk("韩菱纱：……那个时候被你这野人发现我拿了灵光藻玉，实在很丢脸，但是你没看见这本书……所以我一直随身带着，准备哪天跟你吵架时当作秘密武器，可以嘲笑你一下……", "46410");
        giWait(0.3);
        giPlayerDoAction(3, "C09", 1, false);
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……菱纱你想太多了……", "46411");
        giPlayerEndAction(3);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：女孩子怎么老是一堆秘密……", "46412");
        giWait(0.3);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 242.0, true);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103G", false);
        giTalk("韩菱纱：哼……", "46413");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("105B", true);
        giTalk("慕容紫英：无论什么原由，阴差阳错之下，却也令我们寻得了宗炼师公的手记，或许都是天意安排……", "46414");
        giWait(0.3);
        giPlayerSetDir(3, 330.0, false);
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：哈，这真是太好了！就像人家说的，穿着鞋子找不到，不穿就找到了！", "46415");
        giWait(0.3);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：天啊，什么穿着鞋子找不到，是踏破铁鞋无觅处，得来全不费功夫……", "46416");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：对对对，就是这么讲！", "46417");
        giPlayerEndAction(0);
        giSetPortrait("105B", false);
        giTalk("慕容紫英：我且翻看一遍，其中是否有阻止宿主使用双剑之法。", "46418");
        giWait(0.3);
        giPlayerSetDir(0, 114.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：好，你快点看，越快越好——", "46419");
        giPlayerEndAction(0);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P29", 2, 0.0, 2.5);
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giPlayerDoAction(1, "J19", -1, false);
        giSetPortrait("103L", false);
        giTalk("韩菱纱：……！唔…………", "46420");
        giWait(0.5);
        giPlayerSetDir(0, 44.0, false);
        giPlayerSetDir(3, 16.0, true);
        giWait(0.5);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：菱纱？！", "46421");
        giCameraRunSingle("010", false);
        giPlayerWalkTo(0, 79.6799, 6.0864, 4.5313, true);
        giPlayerSetAng(0, 54.0);
        giPlayerDoAction(0, "J03", -1, false);
        giWait(0.5);
        giSetPortrait("101D", true);
        giTalk("云天河：菱纱你怎么了？是不是又难受了？！", "46422");
        giWait(1.2);
        giSetPortrait("103L", false);
        giTalk("韩菱纱：……我、我头好晕……", "46423");
        giWait(0.5);
        giCameraRunSingle("011", false);
        giWait(0.8);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：师叔和掌门，他们……", "46424");
        giWait(1.0);
        giSetPortrait("103L", false);
        giTalk("韩菱纱：……天河……好冷啊…………", "46425");
        giWait(0.8);
        giSetPortrait("101H", true);
        giTalk("云天河：你别怕！我马上运功帮你驱寒！", "46426");
        giWait(1.0);
        giSetPortrait("103L", false);
        giTalk("韩菱纱：……唔…………", "46427");
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("001", true);
        giWait(1.5);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giSetObjectVisible("MO004", false);
        giSetObjectVisible("MO005", false);
        giSetObjectVisible("MO006", false);
        giSetObjectVisible("MO007", false);
        giIMMEnd();
        giArenaLoad("Q01", "Q01Y", "", true);
        giSetObjectVisible("sound010", false);
        giSetObjectVisible("sound002", false);
        giScriptMusicPlay("P33", 2, 0.0, 0.0);
        giIMMBegin();
        giCameraPrepare("MC001");
        giCameraSetCollide(false);
        giCameraRunSingle("001", true);
        giPlayerCurrentSetVisible(false);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(3, true);
        giPlayerSetPos(0, -560.8016, 62.2421, -579.8082);
        giPlayerSetPos(3, -581.834, 57.064, -336.2061);
        giPlayerSetAng(0, 356.0);
        giPlayerSetAng(3, 155.0);
        giSetObjectVisible("title01", false);
        giSetObjectVisible("sound002", false);
        giIMMEnd();
        giArenaReady();
        giCameraSetDistOptEnable(false);
        giFlashInBlack(1.5, true);
        gi2DSoundPlay("WJ025", 1);
        giWait(1.0);
        giCameraRunSingle("002", false);
        giPlayerWalkTo(0, -570.6786, 57.8009, -394.4039, true);
        giCameraWait();
        giWait(0.8);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……菱纱如何？", "46428");
        giWait(0.8);
        giSetPortrait("101G", false);
        giTalk("云天河：已经睡了。", "46429");
        giWait(0.3);
        giPlayerDoAction(3, "C09", 1, false);
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：一定是掌门和师叔又用了望舒剑之力，如此反反复复，还不知要让菱纱受多少苦…… ", "46430");
        giPlayerEndAction(3);
        giWait(0.3);
        giIMMBegin();
        giCameraRunSingle("003", false);
        giPlayerSetAng(3, 170.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：紫英，你快点把那本手记看完吧。看完说不定就能知道救菱纱的办法了！", "46431");
        giSetPortrait("101H", false);
        giTalk("云天河：每一次这样，她身体里的寒气都会越来越多，就算我替她驱寒……也已经没有多大用了……", "46432");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 168.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(3, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……你不必多说，我都明白……也一样心急如焚……", "46433");
        giPlayerEndAction(3);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：只是手记中所载内容十分艰深，有些说法更是我铸剑至今，闻所未闻，一时半刻却是无法读通……", "46434");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：不管怎样，能快一点都是好的！", "46435");
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, false);
        giWait(0.3);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：我知道，我会全力而为。", "46436");
        giPlayerEndAction(3);
        giPlayerSetDir(3, 8.0, false);
        giWait(0.2);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：紫英……", "46437");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(3, 184.0, true);
        giWait(0.4);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：还有其他事？", "46438");
        giWait(0.5);
        giCameraRunSingle("003", true);
        giWait(0.3);
        giCameraRunSingle("005", false);
        giSetPortrait("101A", false);
        giTalk("云天河：……紫英，你害怕过吗？", "46439");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：…………为何这样问？", "46440");
        giWait(0.6);
        giPlayerSetDir(0, 40.0, true);
        giWait(0.7);
        giSetPortrait("101A", true);
        giTalk("云天河：……我以前，总是天不怕地不怕……觉得就像爹说的，堂堂男子汉，没什么可惊怕的……", "46441");
        giPlayerDoAction(0, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("101G", true);
        giTalk("云天河：可是现在……我好像变得胆小了，会害怕很多事……我怕这辈子真的再也不能见到梦璃，怕我们阻止不了玄霄…………我更怕……救不了菱纱，她会死…………", "46442");
        giWait(1.0);
        giPlayerSetDir(0, 348.0, true);
        giWait(0.3);
        giSetPortrait("101G", false);
        giTalk("云天河：原来，天底下有这么多的事，我没办法做到……不是所有事情，尽全力做就会好了…………", "46443");
        giWait(0.5);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giCameraRunSingle("006", false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：天河，你我皆是凡人，生老病死、一世的结果，冥冥之中恐怕已有天意安排……人，要怎么与天争？", "46444");
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：天意……你们都说是“天意”，那为什么爹和娘要说“我命在我，不在天地”？……", "46445");
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：……爹就算拼尽全力，也救不了娘的时候，是不是就像我现在对着菱纱，什么都做不到，恨自己一点用都没有……", "46446");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：天河，你问的这些……实在太难回答，就算是阅遍人生的老者也不一定说得清楚……", "46447");
        giPlayerEndAction(3);
        giWait(0.5);
        giCameraRunSingle("007", true);
        giWait(0.8);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我自问并不畏惧世间强权，自己的生死也可相轻，若是用我一命，能换菱纱一命，我定会毫不犹豫。", "46448");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：但是有些事情，我知道……我们只能祈求所谓的天意……", "46449");
        giWait(0.6);
        giSetPortrait("101G", true);
        giTalk("云天河：……", "46450");
        giWait(0.5);
        giCameraRunSingle("008", true);
        giWait(0.8);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105B", true);
        giTalk("慕容紫英：你也累了，先歇息一下，我尽快读通师公的手记，说不定一切还有转机。", "46451");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101A", false);
        giTalk("云天河：我不睡，我陪着菱纱。", "46452");
        giPlayerEndAction(0);
        giPlayerWalkTo(0, -582.0999, 62.6285, -581.0272, false);
        giCameraRunSingle("009", true);
        giCameraRunSingle("007", true);
        giWait(1.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……师公，但愿您已经找到阻止双剑宿主的办法……这一切即使是天意，难道就不能给予凡人一点眷顾吗……", "46453");
        giFlashOutBlack(1.5, true, true);
        giWait(5.0);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P27", 2, 0.0, 2.5);
        giIMMBegin();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giPlayerSetPos(0, -489.9654, 61.49, -409.5827);
        giPlayerSetAng(0, 312.0);
        giPlayerSetPos(3, -535.4735, 59.3392, -386.5326);
        giPlayerSetAng(3, 120.0);
        giIMMEnd();
        giFlashInBlack(1.5, true);
        giWait(0.3);
        giSetPortrait("101H", false);
        giTalk("云天河：紫英，怎么样？手记看完了吗？", "46454");
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, true);
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：那有没有找到阻止宿主的办法？！", "46455");
        giWait(0.7);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：…………", "46456");
        giWait(0.5);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：怎么了？为什么不说话？", "46457");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, true);
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：你摇头……是没找到……？", "46458");
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：…………并非没有，只不过……", "46459");
        giWait(0.3);
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：只不过什么？你快说呀！", "46460");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 300.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：那方法难于登天，尤其对你我而言……", "46461");
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：到底是什么？只要有办法，就一定能办到的，你告诉我！", "46462");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.7);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……好吧，我说出来，但你听后，切不可乱了心神，一定要冷静。", "46463");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：好！ ", "46464");
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("004", false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：羲和、望舒剑成之后，与幻瞑界的大战开始之前，宗炼师公已隐约觉得双剑力量过于霸道，随着玄霄师叔和夙玉前辈不断修行有成，师公此念愈发强烈。", "46465");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：尽管由昆仑山上白日飞升，乃是凡人梦寐以求的美好夙愿，但所谓物极必反，若是琼华双剑的力量失去控制，则羲和宿主可能堕入嗜血狂乱之道，望舒宿主则会变得冷酷凶残……", "46466");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：……！嗜血乱狂……现在的玄霄不就是…… ", "46467");
        giPlayerDoAction(3, "C08", 1, true);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：师公将这些话告诉了玄霄师叔和夙玉前辈，命他们二人修炼时务必循规蹈矩，不可躁进，以免走火入魔，引发祸事。", "46468");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：怎料与幻瞑界一战，双剑失去其一，师叔受阳炎所扰，变得暴躁异常，更是狂性大发，将数名弟子打成重伤……", "46469");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：凡此种种，似乎都应验了师公当初的忧虑，令他万分痛心，双剑既可以是飞升的灵器，也可以成为起祸的凶器！", "46470");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：师公他决心找出当宿主失控时，封印双剑力量的办法。", "46471");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：他找到了是吗？要怎么做才能封印住？！", "46472");
        giWait(0.8);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……“宿主殪，则双剑亡”，这便是师公留下的话。", "46473");
        giIMMBegin();
        giPlayerSetAng(0, 312.0);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giWait(0.6);
        giSetPortrait("101H", false);
        giTalk("云天河：这……什么意思？是说……要让宿主“死”？……", "46474");
        giPlayerDoAction(3, "C08", 1, true);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：宿主若死其一，则他持有的剑将会陷入长眠，双剑缺一，自然无法再用……", "46475");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：可是……这只是说要怎样阻止双剑，根本没说能不能让宿主恢复正常啊……", "46476");
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("005", false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……我想，师公他直至过世，并未真正找到将双剑之祸消于无形的办法……", "46477");
        giWait(0.5);
        giSetPortrait("101D", false);
        giTalk("云天河：啊？！", "46478");
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……玄霄师叔之所以在夙玉前辈离开后，变得狂暴难以自控，乃是因为他二人共同修炼双剑……", "46479");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：而菱纱令望舒剑复苏，如今师叔与掌门不断催动望舒之力，未经修炼的宿主只能元神不断受损，一再被寒冰之气所扰……", "46480");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：……！！", "46481");
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：师公还说，宿主持剑，则力量异常强大，要将其杀死谈何容易，寻常修行之人与之交手，必会被阳炎烈火或冷凝寒冰所伤，除非有人……能够抵御这两种力量……", "46482");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：他当年万万料想不到，当真有人体质如此特异，既不畏寒，亦不怕炎热……", "46483");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：……紫英，这是……什么意思……", "46484");
        giWait(0.5);
        giCameraRunSingle("006", true);
        giWait(0.8);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：天河，你知道我在说什么……", "46485");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：从你手触三寒器而不觉得冰冷、在炎帝神农洞中又不觉炎热，就已经令人又惊又疑……", "46486");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：在不周山时，我替你疗伤，初时以为你走火入魔，后来才发觉你体内有一寒一热两道气息，冲撞之后竟是融为一体，并无异状……连玄霄师叔也说过你体质特异……还有其他许多有迹可循之处——", "46487");
        giWait(0.5);
        giCameraRunSingle("007", true);
        giWait(0.8);
        giSetPortrait("101H", false);
        giTalk("云天河：你说这些……是要我去做什么？", "46488");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：唉……", "46489");
        giWait(0.5);
        giCameraRunSingle("008", false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：天河，你是否无论如何都要救菱纱？", "46490");
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：还用说吗？这是一定要救的！", "46491");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：菱纱是未经修炼完成的宿主，当双剑做成剑柱、琼华飞升之际，强烈催动双剑必定令菱纱元神耗尽而亡……", "46492");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：嗯！为了菱纱，一定要阻止琼华飞升！而且玄霄飞升，反而会害了他自己，害了所有人……", "46493");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 282.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(1.5);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：要阻止琼华飞升有三种方法……", "46494");
        giWait(0.5);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：一是夺回望舒剑，从此隐居山林……姑且不论你我如何夺回此剑，即便顺利夺回……师叔已无法再被冰封，不能飞升又再度失去了望舒剑，你能想像心魔深种的师叔会狂乱到何种程度……", "46495");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：是的……他已经控制不住自己了……", "46496");
        giWait(0.5);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：所以只夺回望舒，后果必定危害整个琼华派，甚至更多无辜的人……", "46497");
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：第二个方法就是……让双剑宿主死其一，则持有的剑会陷入长眠，双剑缺一，自然无法再用于飞升……所以只能除去羲和剑的宿主……", "46498");
        giIMMBegin();
        giPlayerSetAng(0, 312.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：要我去……杀死……大哥？！", "46499");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.8);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：天河——", "46500");
        giWait(0.8);
        giSetPortrait("101H", false);
        giTalk("云天河：他、他是玄霄……是除了爹以外对我最好的人之一，是我的大哥啊，就算我再也不肯喊他大哥，就算他杀了重光长老，就算他变成那样……", "46501");
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：天河！我已说过，师公留下的办法，对你我而言太难了……", "46502");
        giWait(0.3);
        giCameraRunSingle("011", true);
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：……你说还有第三种方法？", "46503");
        giWait(0.8);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……你劝师叔放弃飞升、放弃执念……但是……天河，第三种方法最简单却也最难，你认为师叔会听你的吗？", "46504");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, true);
        giWait(0.5);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：…………", "46505");
        giWait(0.8);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：你先静一静吧……", "46506");
        giWait(0.5);
        giPlayerWalkTo(3, -579.1676, 59.0287, -259.6552, false);
        giCameraRunSingle("012", true);
        giPlayerEndMove(3);
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：…………", "46507");
        giWait(0.8);
        giSetPortrait("101G", false);
        giTalk("云天河：……玄霄…………", "46508");
        giWait(0.8);
        giSetPortrait("101G", false);
        giTalk("云天河：……大哥……我到底该怎么办？…………", "46509");
        giFlashOutBlack(1.5, true, true);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giSetObjectVisible("title01", true);
        giSetObjectVisible("sound010", true);
        giSetObjectVisible("sound002", true);
        giIMMEnd();
        giPlayerOutTeam(1, false);
        giPlayerOutTeam(3, false);
        giPlayerSetLeader(0);
        global_mvar = 160700; // 0x000273BC, 照看菱纱
        giPlayerCurrentSetPos(-489.9654, 61.49, -409.5827);
        giPlayerCurrentSetAng(342.0);
        giCameraSetMode(0, true);
        giCameraSetDistOptEnable(true);
        giPlayerUnLock();
        giFlashInBlack(0.5, true);
    }
}

void func2010()
{
    if (global_mvar == 160700 /* 照看菱纱 */)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -59.9728, 6.0647, 24.8581);
        giPlayerSetPos(3, -59.9728, 6.0647, 24.8581);
        giPlayerSetAng(0, 78.0);
        giPlayerSetAng(3, 78.0);
        giPlayerSetVisible(0, true);
        giIMMEnd();
        giArenaReady();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：……！菱纱！", "46510");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("002", false);
        gi2DSoundPlay("WF013", 3);
        giPlayerRunTo(0, 108.1402, 6.0728, -11.3774, true);
        giCameraWait();
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：人呢？！", "46511");
        gi2DSoundPlay("WJ025", 1);
        giWait(0.4);
        giPlayerSetVisible(3, true);
        giPlayerWalkTo(3, 69.0609, 6.1007, 23.1542, true);
        giPlayerSetDir(3, 130.0, true);
        giWait(0.5);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：发生何事？！", "46512");
        giWait(0.3);
        giPlayerSetDir(0, 326.0, true);
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：菱纱、她不见了！", "46513");
        giWait(0.3);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：什么？！", "46514");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：先前明明还睡在这里的！", "46515");
        giWait(0.3);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：……糟！她会不会是……", "46516");
        giWait(0.5);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：快走！我们分头去找！她应该还没走远，<colour red=255 green=187 blue=0 alpha=255>你找青鸾峰附近，</colour><dc0>我直接御剑往山下去！</dc0>", "46517");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：好！", "46518");
        giWait(0.5);
        giPlayerRunTo(3, -59.9728, 6.0647, 24.8581, false);
        gi2DSoundPlay("WF013", 3);
        giWait(0.7);
        giFlashOutBlack(1.0, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(108.1402, 6.0728, -11.3774);
        giPlayerCurrentSetAng(292.0);
        giIMMEnd();
        global_mvar = 160900; // 0x00027484, 第四章 / 9-6-1.死生悠茫 / 寻找菱纱
        giCameraSetMode(2, true);
        giPlayerUnLock();
        giFlashInBlack(0.5, true);
    }
}

void func2011()
{
    if (global_mvar == 160900 /* 第四章 / 9-6-1.死生悠茫 / 寻找菱纱 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P35", 2, 2.5, 0.0);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -48.4886, 0.58, 20.2863);
        giPlayerSetPos(1, 53.0864, 0.4636, -10.5045);
        giPlayerSetAng(0, 100.0);
        giPlayerSetAng(1, 62.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giIMMEnd();
        giArenaReady();
        giCameraPrepare("LL001");
        giCameraRunSingle("003", true);
        giFlashInBlack(2.0, true);
        giWait(1.5);
        giCameraRunSingle("004", true);
        giWait(1.5);
        giCameraRunSingle("005", true);
        giWait(1.0);
        giPlayerSetDir(1, 290.0, true);
        giWait(0.5);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：天河……", "46519");
        giWait(0.5);
        giCameraRunSingle("002", true);
        giCameraRunSingle("006", false);
        giPlayerWalkTo(0, -9.6785, 0.6335, 10.523, true);
        giPlayerSetAng(0, 102.0);
        giSetPortrait("101H", true);
        giTalk("云天河：菱纱，你怎么会在这？！你没在房里，把我和紫英吓了一跳。", "46520");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：…………", "46521");
        giWait(0.699999988079071);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetEmotion(1, "103_bs");
        giPlayerSetDir(1, 62.0, true);
        giWait(0.5);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：早知道……我就该直接下山去的……可我还是忍不住，想来这里……", "46522");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：下山？你要去哪？……干嘛不跟我和紫英说？我们一起去。", "46523");
        giCameraRunSingle("007", false);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：……还记得吗？我们第一次来树屋时，我说以后要到山上隐居，不问江湖世事，那些……都还像是昨天的情景，可仔细想想，原来已经过了那么久啊，发生了好多好多事……", "46524");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：我不明白，不是说好了吗？以后一起住在青鸾峰……怎么你又要走？", "46525");
        giPlayerEndAction(0);
        giWait(0.30000001192092896);
        giPlayerSetDir(1, 298.0, true);
        giWait(0.5);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：……我听见了，你和紫英的话……", "46526");
        giSetPortrait("101D", true);
        giTalk("云天河：……！那是——", "46527");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：不要瞒我……也别安慰我好吗？", "46528");
        giPlayerEndAction(1);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：其实……你和紫英，你们不用这样痛苦……只要我把自己杀了，所有的一切不都结束了？", "46529");
        giSetPortrait("101D", true);
        giTalk("云天河：菱纱……你在乱说什么……", "46530");
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：这、这怎么可以？！！", "46531");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(0, 122.0);
        giPlayerSetAng(1, 62.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giCameraRunSingle("009", false);
        giWait(1.0);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……我只想找个地方，静静了结自己的性命……日子久了，你和紫英会慢慢把我忘记的，忘记了，就不会再伤心……", "46532");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：别说了！你跟我回去，好好休息，别再想这些！", "46533");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……可是，人一旦要死了，反而会多很多牵挂，想起从前的事……", "46534");
        giWait(0.30000001192092896);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giCameraRunSingle("011", false);
        giWait(0.699999988079071);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：第一次见梦璃，我想世上怎么会有这样漂亮的人，只可惜是个任性的大小姐，把人耍得团团转……", "46535");
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……在太一仙径的时候，我们虽然是被紫英救了，却也被他数落了几句，把我气得直跳脚…… ", "46536");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……可有些事情，就算开始的时候乱七八糟，最后却变成了无论如何也不想忘掉的回忆……", "46537");
        giWait(0.5);
        giSetPortrait("101E", false);
        giTalk("云天河：…………", "46538");
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：出来这么久了，不晓得故乡的亲人有没有盼我回去……", "46539");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giPlayerSetEmotion(1, "103_zc");
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giPlayerSetDir(1, 294.0, true);
        giCameraRunSingle("014", true);
        giIMMEnd();
        giWait(1.0);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：这些……我通通舍不得、放不下……我是不是太贪心了？", "46540");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：舍不得的话，为什么还要说死？！", "46541");
        giPlayerEndAction(0);
        giCameraRunSingle("013", false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：正因为舍不得，才只能这样……", "46542");
        giWait(0.800000011920929);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：天河，我不像你和紫英那么强，我还有什么其他的办法，能保护自己想保护的人呢？ ", "46543");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：不对！是我要保护你，要是做不到，我就太没用了……", "46544");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.4);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：……你知道我最放不下的，是什么吗？", "46545");
        giWait(1.0);
        giPlayerDoAction(0, "C09", 1, false);
        giScriptMusicStop(0, 2.5);
        giWait(1.5);
        giScriptMusicPlay("P33", 2, 2.5, 2.5);
        giPlayerSetEmotion(1, "103_zc");
        giCameraRunSingle("016", true);
        giCameraRunSingle("017", false);
        giWait(1.5);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：……有一天，我误打误撞进到一个山洞里，在那里遇上一个人，看着还挺顺眼的，脑袋却不怎么灵光，居然把我当成了山猪精……", "46546");
        giWait(0.3);
        giSetPortrait("101D", true);
        giTalk("云天河：……！", "46547");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：我那时就觉得，这真是个傻子，呆呆的，怕是被人卖了都不知道。", "46548");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：和他一起下山闯荡，就只是觉得好玩，虽然他常常做出些吓到人的事，让我收烂摊……", "46549");
        giWait(0.5);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：渐渐地，我越来越把他放在心上，总想着……要是哪一天没有了我，谁来照顾他，他那么呆，一定会被人骗、被人欺负……", "46550");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(1, 29.5509, 0.4636, 1.5927);
        giPlayerSetAng(1, 292.0);
        giPlayerSetAng(0, 108.0);
        giCameraRunSingle("018", true);
        giIMMEnd();
        giCameraRunSingle("019", false);
        giWait(0.699999988079071);
        giSetPortrait("101G", false);
        giTalk("云天河：菱纱……", "46551");
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：其实，那都是些借口，他已经比以前懂事好多，是我……是我自己离不开他……", "46552");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：不是，菱纱……不是这样！我知道自己笨，没有你的话，很多事都做不成，你不要走……", "46553");
        giPlayerEndAction(0);
        giWait(0.30000001192092896);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：就算没有望舒剑，我也注定是要短命的……为了那短短几年阳寿，真的值得你和玄霄拼个你死我活吗？", "46554");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(1, 32.5544, 0.4636, -2.5024);
        giPlayerSetAng(1, 294.0);
        giPlayerSetAng(0, 126.0);
        giCameraRunSingle("012", true);
        giIMMEnd();
        giWait(0.30000001192092896);
        giSetPortrait("101H", false);
        giTalk("云天河：我和紫英不是去拼命！是……是去劝玄霄放弃飞升……", "46555");
        giSetPortrait("103B", true);
        giTalk("韩菱纱：……劝他放弃？你……你真的是笨蛋……", "46556");
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：……我的一条命，能救很多人……如果琼华派数百年基业，真的毁在玄霄手里，我们要怎么面对青阳长老的嘱托……", "46557");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：若是唯你一死，方能解我派之灾，那琼华派即使无恙，往后又有何颜面存于世间？", "46558");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(0, 3.5713, 0.6335, 30.955);
        giPlayerSetPos(1, 16.5902, 0.4636, -10.3656);
        giPlayerSetPos(3, -72.0211, 0.4372, 1.7448);
        giPlayerSetAng(0, 246.0);
        giPlayerSetAng(1, 276.0);
        giPlayerSetAng(3, 83.0);
        giPlayerSetVisible(3, true);
        giCameraRunSingle("020", false);
        giIMMEnd();
        giPlayerWalkTo(3, -42.6819, 0.4372, -7.0122, true);
        giPlayerSetAng(3, 83.0);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……紫英……", "46559");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：抱歉，我无意旁听……只是在山下没找见你，回到山上找，听见树屋有人声……", "46560");
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：对不起，害你担心……", "46561");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.30000001192092896);
        giIMMBegin();
        giPlayerSetPos(0, -3.6404, 0.6335, 36.4819);
        giPlayerSetPos(1, 10.2919, 0.4636, -9.021);
        giPlayerSetAng(0, 220.0);
        giPlayerSetAng(1, 274.0);
        giCameraRunSingle("021", true);
        giIMMEnd();
        giWait(0.6000000238418579);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：菱纱，你可知你求得一死，也只不过令琼华派暂时无法飞升，但望舒剑还在师叔手中，他只需寻到合适的宿体，今日之局又会重演……", "46562");
        giPlayerDoAction(1, "J04", -1, true);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：但是……想找到宿体，一定很难吧？", "46563");
        giWait(0.6000000238418579);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：能拖多久就是多久，说不定、说不定那段日子里，就能发现其他阻止玄霄的办法了……", "46564");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：纵然有此可能，但师叔只会入魔更深，力量更加不可控制，他若带着双剑踏遍天下，寻找宿体，不知将会引出多少腥风血雨……", "46565");
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：…………", "46566");
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……或许……真的会这样吧……", "46567");
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：被羲和剑之力吞噬的宿主，将变得嗜血狂乱，直到完全迷失心智，师叔如今的样子，也已相差无几了……", "46568");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, -15.1935, 0.5767, 32.8398);
        giPlayerSetAng(0, 156.0);
        giPlayerSetPos(1, 18.4222, 0.4636, -17.7492);
        giPlayerSetAng(1, 276.0);
        giPlayerSetPos(3, -42.7118, 0.4372, -23.0033);
        giPlayerSetAng(3, 89.0);
        giCameraRunSingle("022", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101J", false);
        giTalk("云天河：菱纱，你别再乱想了……所有的事，都在玄霄身上，只要他还有升仙的念头，别人做什么都没用……", "46569");
        giPlayerEndAction(0);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……", "46570");
        giWait(0.5);
        giPlayerWalkTo(0, 15.385, 0.6393, -26.0698, false);
        giIMMBegin();
        giCameraRunSingle("025", true);
        giPlayerSetEmotion(1, "103_bs");
        giPlayerSetPos(1, 44.1358, 0.4636, -7.213);
        giPlayerSetAng(1, 236.0);
        giPlayerSetPos(3, -23.4689, 0.4372, 10.1288);
        giPlayerSetAng(3, 101.0);
        giPlayerSetVisible(3, false);
        giIMMEnd();
        giPlayerEndMove(0);
        giPlayerSetAng(0, 218.0);
        giWait(0.699999988079071);
        giSetPortrait("101J", true);
        giTalk("云天河：……天已经快亮了，等天一亮，我就御剑去琼华派。", "46571");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：不能再等下去，要是玄霄和夙瑶已经做成剑柱，就太迟了！", "46572");
        giCameraRunSingle("026", false);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：我会劝他放弃……", "46573");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：如果他不愿意呢？", "46574");
        giWait(0.699999988079071);
        giSetPortrait("101G", true);
        giTalk("云天河：我…………", "46575");
        giWait(0.800000011920929);
        giSetPortrait("101G", true);
        giTalk("云天河：我……会……会杀了他！", "46576");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.6000000238418579);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：天河……你让你自己太痛苦了……", "46577");
        giPlayerEndAction(1);
        giWait(1.0);
        giSetPortrait("101G", true);
        giTalk("云天河：不要再说了……没有别的方法……", "46578");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetAng(1, 240.0);
        giCameraRunSingle("023", true);
        giIMMEnd();
        giWait(0.699999988079071);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……那，我和你一起去。", "46579");
        giWait(0.30000001192092896);
        giPlayerSetDir(0, 50.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：不，你留在青鸾峰，让紫英和“梦璃”照顾你！", "46580");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：不行，到现在你还想把我丢下？！你去，我就一定要去！", "46581");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101H", true);
        giTalk("云天河：菱纱！", "46582");
        giCameraRunSingle("024", false);
        giWait(3.0);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：……", "46583");
        giCameraWait();
        giSetPortrait("101H", true);
        giTalk("云天河：你……", "46584");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetEmotion(1, "103_zc");
        giPlayerSetVisible(3, true);
        giCameraRunSingle("027", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……也罢，我们就一起去琼华派，也免得彼此担心，反而误事。", "46585");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerSetDir(0, 324.0, false);
        giPlayerSetDir(1, 294.0, true);
        giPlayerSetDir(3, 127.0, true);
        giWait(0.6000000238418579);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：菱纱的状况时好时坏，若是突然发作起来，天河你可以及时替她运功驱寒……不然我也难料后果……", "46586");
        giSetPortrait("101G", false);
        giTalk("云天河：……", "46587");
        giWait(0.5);
        giPlayerSetDir(1, 250.0, true);
        giWait(0.5);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：我们这三个好朋友既然都替彼此着想，也放心不下彼此，不如就一起去，不是吗？", "46588");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 50.0);
        giCameraRunSingle("030", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：你……", "46589");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：放心吧，天河你每次都瞻前顾后，后来还不是没事？别瞧不起人了，我能照顾好自己的。", "46590");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.699999988079071);
        giPlayerDoAction(0, "J15", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：哎呀！！我真是说不过你……", "46591");
        giPlayerEndAction(0);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：那好吧，身体不舒服的话，要马上告诉我！", "46592");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：知道了啦。", "46593");
        giWait(0.30000001192092896);
        giIMMBegin();
        giPlayerSetAng(3, 115.0);
        giPlayerSetVisible(0, false);
        giCameraRunSingle("028", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我们即刻动身。不知琼华派的结界有无撤去，<colour red=255 green=187 blue=0 alpha=255>先御剑飞往播仙镇，</colour><dc0>到了那里再做打算。</dc0>", "46594");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerSetEmotion(1, "103_zc");
        giIMMEnd();
        global_mvar = 161000; // 0x000274E8, 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记
        giArenaLoad("Q01", "Q01", "", true);
        giIMMBegin();
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-3126.855, -412.1065, 402.8156);
        giPlayerCurrentSetAng(226.0);
        giIMMEnd();
        giPlayerInTeam(1, false);
        giPlayerInTeam(3, false);
        giArenaReady();
        giCameraSetMode(0, true);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2013()
{
    if (global_mvar == 160500 /* 第四章 / 9-5-1.欢乐苦短 / 进入木屋 */)
    {
        giPlayerLock();
        giPlayerWalkTo(1, 60.6096, 80.7635, 59.9459, true);
        giPlayerSetDir(1, 352.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：先回小木屋吧，看看天河找到那本书了没有～", "");
        giPlayerUnLock();
    }
}

void func2014()
{
    if (global_mvar == 160700 /* 照看菱纱 */)
    {
        giPlayerLock();
        giPlayerWalkTo(0, -587.938, 56.2295, -447.4892, true);
        giPlayerSetDir(0, 168.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101G", true);
        giTalk("云天河：先回屋看看菱纱吧。", "");
        giPlayerUnLock();
    }
}

void func2015()
{
    if (global_mvar != 160700 /* 照看菱纱 */)
    {
        if (global_mvar == 160900 /* 第四章 / 9-6-1.死生悠茫 / 寻找菱纱 */)
        {
            giPlayerLock();
            giPlayerWalkTo(0, -3058.5725, -412.1123, 496.8126, true);
            giPlayerSetDir(0, 13.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("101H", true);
            giTalk("云天河：那边已经是下山的路了，我先<colour red=255 green=187 blue=0 alpha=255>在山上找菱纱……</colour>", "");
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giPlayerWalkTo(0, -3058.5725, -412.1123, 496.8126, true);
        giPlayerSetDir(0, 13.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101G", true);
        giTalk("云天河：已经晚了，还是<colour red=255 green=187 blue=0 alpha=255>回屋去看看菱纱吧</colour><dc0>。</dc0>", "");
        giPlayerUnLock();
    }
}

void func2016()
{
    if (global_mvar == 160700 /* 照看菱纱 */)
    {
        giPlayerLock();
        giPlayerWalkTo(0, 37.4731, 105.3238, -136.6098, true);
        giPlayerSetDir(0, 2.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101G", true);
        giTalk("云天河：已经晚了，还是<colour red=255 green=187 blue=0 alpha=255>回屋去看看菱纱吧</colour><dc0>。</dc0>", "");
        giPlayerUnLock();
    }
}

void func2099()
{
    int select_dialog_last_select = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.是");
    giSelectDialogAddItem("2.否");
    giSelectDialogSetDefaultSelect(1);
    giShowSelectDialog("　　　　是否要<colour red=255 green=102 blue=0 alpha=255>休息</colour><dc0>一下？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        giPlayerUnLock();
    }
    else
    {
        giFlashOutBlack(1.5, true, true);
        giPlayerTakeARest();
        giWait(3.0);
        giFlashInBlack(1.5, true);
        giShowHint("人物<colour red=255 green=187 blue=0 alpha=255>精</colour><dc0>、</dc0><colour red=255 green=187 blue=0 alpha=255>神</colour><dc0>回复满值</dc0>", 0.5, 0.15);
        giWait(2.0);
        giPlayerUnLock();
    }
}
