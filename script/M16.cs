// Structured PAL4 reconstruction for M16.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M16_1_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar != 130700 /* 第三章 / 8-2-3.是昔流芳 / 逃往放逐渊 / 重逢天青 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2001();
    }
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    giPlayerCurrentSetPos(-1560.6, -0.1, -1243.6);
    giPlayerCurrentSetAng(30.0);
    giCameraSetMode(5, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func2001()
{
    if (global_mvar == 130700 /* 第三章 / 8-2-3.是昔流芳 / 逃往放逐渊 / 重逢天青 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -1488.1, -0.1, -1236.9);
        giPlayerSetPos(1, -1460.5, -0.1, -1252.0);
        giPlayerSetPos(3, -1420.0, -0.1, -1238.6);
        giNpcSetPos("MN001", -1436.4, -0.1, -1004.4);
        giPlayerSetAng(0, 4.0);
        giPlayerSetAng(1, 8.0);
        giPlayerSetAng(3, 356.0);
        giNpcSetAng("MN001", 182.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("MN001", true);
        giMonsterSetHide("m16-01-04", false);
        giSetObjectVisible("save2", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(2.0);
        giCameraRunSingle("002", true);
        giWait(1.5);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giPlayerWalkTo(0, -1474.2, -0.1, -1091.4, false);
        giPlayerWalkTo(1, -1442.9, -0.1, -1103.0, false);
        giPlayerWalkTo(3, -1400.5, -0.1, -1094.0, false);
        giPlayerEndMove(0);
        giPlayerEndMove(1);
        giPlayerEndMove(3);
        giPlayerSetDir(0, 28.0, false);
        giPlayerSetDir(3, 356.0, false);
        giWait(0.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("227A", false);
        giTalk("壬癸：你们可算来了！", "45054");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(0.5);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giSetPortrait("227A", true);
        giTalk("壬癸：快点快点，<colour red=255 green=187 blue=0 alpha=255>穿过放逐渊，就是冥河，那条河上常有青竹船往来阴阳两界，</colour><dc0>你们到了那里，就跳上河边的船，一路回去人间吧！</dc0>", "45055");
        giWait(0.5);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：谢谢……可是，你为何会帮我们？", "45056");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giCameraRunSingle("005", false);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("227A", true);
        giTalk("壬癸：哈哈，这也算好人有好报吧，你们还记不记得即墨的夏元辰？", "45057");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：咦？你是夏书生的朋友？", "45058");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("227A", true);
        giTalk("壬癸：非也，我只是刚巧认识他的养女。", "45059");
        giWait(0.5);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：莲宝？！", "45060");
        giWait(0.5);
        giSetPortrait("227A", true);
        giTalk("壬癸：没错、没错！", "45061");
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("227A", true);
        giTalk("壬癸：说起来，我和那女人，对了，她这一世叫作“莲宝”，也已经有六世的交情了！", "45062");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：哎？六世？", "45063");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("227A", true);
        giTalk("壬癸：她前前后后死了六次，都是我去勾她的魂啊，后来我发觉那女人呆呆笨笨的，就不由得关照起她来了。", "45064");
        giSetPortrait("227A", true);
        giTalk("壬癸：她可真是个傻女人，明明和前世的恋人缘分都已经尽了，偏偏还不死心，转世六次，都要陪在他身边，有时是树、有时是鸟，总之没一次是人，到了这一世，终于成了人，偏偏又是个痴儿……唉！", "45065");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：慢慢慢慢——慢！你说、你说前世的恋人，难道莲宝就是静兰？！是夏书生的恋人转世？！", "45066");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("227A", true);
        giTalk("壬癸：没错、没错！小姑娘你真聪明，一点就通！", "45067");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(1.0);
        giSetPortrait("227A", true);
        giTalk("壬癸：我啊，就是放不开她，时常去看她，虽然她不做鬼时，也不记得我……", "45068");
        giSetPortrait("227A", true);
        giTalk("壬癸：上回我见你们救了她，这一次才会帮你们！", "45069");
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……她……肯定很痛苦吧，夏书生也不再认得她了，为什么……还要纠缠生生世世……", "45070");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("007", false);
        giSetPortrait("227A", true);
        giTalk("壬癸：唉，你问我，我又怎么知道，做鬼太久，早忘记做人时的感觉了。", "45071");
        giSetPortrait("227A", true);
        giTalk("壬癸：你们人的情爱本来就没什么道理可言，明知不可为，偏要去做的事，恐怕比天上的星星还多！", "45072");
        giWait(0.5);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：…………", "45073");
        giWait(0.5);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("227A", true);
        giTalk("壬癸：不说这个了，你们快走吧，我帮得了一时，帮不了一世啊！", "45074");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：多谢，今日的恩情无以为报—— ", "45075");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giSetPortrait("227A", true);
        giTalk("壬癸：不用不用～小事一桩，有什么可报的！", "45076");
        giWait(0.6);
        giNpcDoAction("MN001", "J01", -1, false);
        giSetPortrait("227A", true);
        giTalk("壬癸：不过嘛，你们要是方便，记得去了阳间多烧些纸钱给我！鬼差的俸禄也太少了，大家都是叫苦连天。", "45077");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giSetPortrait("227A", true);
        giTalk("壬癸：还有那三只鸟，他们叫风雅颂，是鬼界里最爱管闲事的鬼了，可惜运气不好，从来没正经差事派给他们。", "45078");
        giWait(1.2);
        giNpcWalkTo("MN001", -1430.5, -0.1, -890.2, true);
        giWait(0.8);
        giPlayerSetDir(0, 72.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：纸钱……？啥东西？", "45079");
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerSetDir(3, 276.0, false);
        giPlayerSetDir(1, 312.0, false);
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：有机会再说给你听，我们先离开这里吧！", "45080");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("008", true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("MN001", false);
        giMonsterSetHide("m16-01-04", true);
        giSetObjectVisible("save2", true);
        giPlayerCurrentSetPos(-1474.2, -0.1, -1091.4);
        giPlayerCurrentSetAng(16.0);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        global_mvar = 131000; // 0x0001FFB8, 第三章 / 8-2-4.是昔流芳 / 前往冥河
        giCameraSetMode(5, true);
        giFlushTailYAngle();
        giCameraSeekToPlayer();
        giTimeScript(180.0, "func9001");
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2002()
{
    if (global_mvar == 131000 /* 第三章 / 8-2-4.是昔流芳 / 前往冥河 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giFlashOutBlack(1.0, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giHideGASkillObject();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 1276.3, -0.1, 1130.9);
        giPlayerSetPos(1, 1313.9, -0.1, 1114.9);
        giPlayerSetPos(3, 1293.5, -0.1, 1080.2);
        giPlayerSetAng(0, 82.0);
        giPlayerSetAng(1, 84.0);
        giPlayerSetAng(3, 70.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("save1", false);
        giMonsterSetHide("m16-06-07", false);
        giMonsterSetHide("m16-05-03", false);
        giMonsterSetHide("m16-06-02", false);
        giMonsterSetHide("m16-06-01", false);
        giMonsterSetHide("m16-05-02", false);
        giMonsterSetHide("m16-04-03", false);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giCameraSetDistOptEnable(false);
        giFlashInBlack(1.5, false);
        giWait(2.0);
        giCameraRunSingle("002", false);
        giPlayerWalkTo(0, 1458.5, -0.1, 1164.3, false);
        giPlayerWalkTo(1, 1505.6, -0.1, 1149.6, false);
        giPlayerWalkTo(3, 1477.0, -0.1, 1107.7, true);
        giPlayerSetDir(3, 70.0, true);
        giCameraWait();
        giWait(1.5);
        giIMMBegin();
        giCameraSetDistOptEnable(true);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：那边！真的有船哎！", "45081");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：我们上船。", "45082");
        giWait(0.5);
        giSetPortrait("101B", true);
        giTalk("云天河：好！", "45083");
        giWait(0.8);
        giPlayerWalkTo(1, 1637.1, -0.1, 1181.9, false);
        giPlayerWalkTo(0, 1611.4, -0.1, 1200.3, false);
        giPlayerWalkTo(3, 1627.1, -0.1, 1139.5, false);
        giWait(1.5);
        giFlashOutBlack(0.5, true, true);
        giPlayerEndMove(1);
        giPlayerEndMove(0);
        giPlayerEndMove(3);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        global_mvar = 131001; // 0x0001FFB9
        giIMMEnd();
        giArenaLoad("Q12", "Q12", "", true);
    }
}

void func4001()
{
    giPlayerLock();
    giNpcPauseBeh("4001");
    giNpcFaceToCurrentPlayer("4001", true);
    giCurrentPlayerFaceToNpc("4001", true);
    giTalk("阿月：哎呀～我是不是眼花啦，怎么如今的鬼都是男的俊、女的俏，让我们这些老鬼多没面子……", "");
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
    giTalk("小古：你们也是来玩的吗？只要一敲墓碑，就会有人陪你玩游戏哦～我最喜欢来这里了～", "");
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
    giTalk("郝大刚：放逐渊游荡的都是孤魂野鬼，再往东边就是冥河了，你们几个新鬼怎么会跑来？！哈哈，我知道了，你们是不是想来给我填饱肚子的？！", "");
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
    giTalk("金夫人：夫君他念旧情，经常烧纸钱给我，我但愿他能再娶一个贤惠女子，好好过日子，却又舍不下他，不想去投胎……", "");
    giNpcResetDir("4004");
    giNpcResumeBeh("4004");
    giPlayerUnLock();
}

void func7001()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(9);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() <= 0)
    {
        var_ming = var_ming + 1;
        if (var_ming >= 2)
        {
            giOBJBlendOut("tomb01", 1.5, true);
            var_ming = 0;
            giEffectPlayWithCurrentPlayer("H_191", 1);
            gi2DSoundPlay("we043", 1);
            giWait(2.5);
            giAddCombatMonster(2560, 1);
            giAddCombatMonster(2560, 2);
            giAddCombatMonster(2560, 3);
            giAddCombatMonster(2562, 4);
            giStartCombat("M16");
        }
    }
    else
    {
        giOBJBlendOut("tomb01", 1.5, true);
        giEffectPlay("H_190", 1, -978.2, 36.9, 634.6);
        gi2DSoundPlay("we007", 1);
    }
    giPlayerUnLock();
}

void func7002()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(10);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() <= 0)
    {
        var_ming = var_ming + 1;
        if (var_ming >= 2)
        {
            giOBJBlendOut("tomb02", 1.5, true);
            var_ming = 0;
            giEffectPlayWithCurrentPlayer("H_191", 1);
            gi2DSoundPlay("we043", 1);
            giWait(2.5);
            giAddCombatMonster(2560, 1);
            giAddCombatMonster(2560, 2);
            giAddCombatMonster(2560, 3);
            giAddCombatMonster(2562, 4);
            giStartCombat("M16");
        }
    }
    else
    {
        giOBJBlendOut("tomb02", 1.5, true);
        giEffectPlay("H_190", 1, -978.2, 36.9, 634.6);
        gi2DSoundPlay("we007", 1);
    }
    giPlayerUnLock();
}

void func7003()
{
    int puzzle_game_result = 0;

    giPlayerLock();
    giWait(0.5);
    giStartJigsawGame(11);
    puzzle_game_result = giGetPuzzleGameResult();
    if (giGetPuzzleGameResult() <= 0)
    {
        var_ming = var_ming + 1;
        if (var_ming >= 2)
        {
            giOBJBlendOut("tomb03", 1.5, true);
            var_ming = 0;
            giEffectPlayWithCurrentPlayer("H_191", 1);
            gi2DSoundPlay("we043", 1);
            giWait(2.5);
            giAddCombatMonster(2560, 1);
            giAddCombatMonster(2560, 2);
            giAddCombatMonster(2560, 3);
            giAddCombatMonster(2562, 4);
            giStartCombat("M16");
        }
    }
    else
    {
        giOBJBlendOut("tomb03", 1.5, true);
        giEffectPlay("H_190", 1, 943.3, 54.8, 178.4);
        gi2DSoundPlay("we007", 1);
    }
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
