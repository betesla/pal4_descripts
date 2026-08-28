// Structured PAL4 reconstruction for M03.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M03_1_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giIMMBegin();
        giSetObjectVisible("enttrance0", false);
        giSetObjectVisible("enttrance4", false);
        giSetObjectVisible("enttrance1", true);
        giSetObjectVisible("enttrance2", true);
        giIMMEnd();
    }
    else
    {
        giIMMBegin();
        giSetObjectVisible("enttrance0", true);
        giSetObjectVisible("enttrance4", true);
        giSetObjectVisible("enttrance1", false);
        giSetObjectVisible("enttrance2", false);
        giIMMEnd();
    }
    if (global_mvar == 20600 /* 第一章 / 2-1-1.初涉红尘 / 回村无路 */)
    {
        func2001();
    }
    if (global_mvar == 21600 /* 第一章 / 2-1-4.初涉红尘 / 前去寿阳 / 露宿湖边 */)
    {
        giSetObjectVisible("MO003", true);
    }
    if (global_mvar == 110701 /* 第二章 / 7-2-2.相争难休 / 离开居巢国 / 水下居巢 */)
    {
        func2006();
    }
    if (global_mvar < 110400 /* 寻找漩涡 */)
    {
        giSetObjectVisible("enttrance3", false);
    }
    if (global_mvar < 110400 /* 寻找漩涡 */)
    {
        giEventVolumeVisible("ev_M03_1_13", false);
    }
    if (global_mvar < 110701 && global_mvar >= 110200 /* 第二章 / 7-2-2.相争难休 / 离开居巢国 / 水下居巢 */)
    {
        giOpenWeather(0);
    }
    if (global_mvar == 110701 /* 第二章 / 7-2-2.相争难休 / 离开居巢国 / 水下居巢 */)
    {
        giCloseWeather();
    }
    if (global_mvar == 110200 /* 第二章 / 6-5-2.非愿 / 前往巢湖 / 月夜惜别 */)
    {
        func2004();
    }
    giArenaReadyRestore();
}

void M03_3_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar < 110500 /* 第二章 / 7-1-2.水中妖界 / 潜水寻妖 */)
    {
        giSetObjectVisible("entrance01", false);
    }
    if (global_mvar < 110701 && global_mvar >= 110200 /* 第二章 / 7-2-2.相争难休 / 离开居巢国 / 水下居巢 */)
    {
        giOpenWeather(0);
    }
    if (global_mvar == 110701 /* 第二章 / 7-2-2.相争难休 / 离开居巢国 / 水下居巢 */)
    {
        giCloseWeather();
    }
    giArenaReadyRestore();
}

void M03_1Y_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar != 20900 /* 第一章 / 2-1-3.初涉红尘 / 夜半猎熊 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giIMMBegin();
        giSetObjectVisible("MO003", true);
        giSetObjectVisible("sound004", true);
        giScriptMusicPlay("P23", 0, 2.5, 0.0);
        giPlayerSetPos(1, 573.9, -19.1, -1328.7);
        giPlayerSetAng(1, 303.0);
        giPlayerSetVisible(1, true);
        giIMMEnd();
        giPlayerDoAction(1, "C11", 0, false);
        giPlayerAttachCollision(1);
        giPlayerSetEmotion(1, "103_hm");
        giArenaReadyRestore();
    }
}

void EarthBall()
{
    if (global_mvar != 110701 /* 第二章 / 7-2-2.相争难休 / 离开居巢国 / 水下居巢 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.0, true, true);
        if (!giBGMConfigIsInArea("1"))
        {
            giArenaLoad("M03", "1", "", true);
        }
        giPlayerCurrentSetPos(-1631.8, -33.8, -1961.8);
        giPlayerCurrentSetAng(80.0);
        giCameraSetMode(5, true);
        giFlashInBlack(1.0, true);
        giArenaReady();
        giPlayerUnLock();
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.0, true, true);
        giArenaLoad("M03", "1", "", true);
    }
}

void func1001()
{
    if (global_mvar >= 110400 /* 寻找漩涡 */)
    {
        giArenaLoad("M03", "3", "", true);
        giPlayerCurrentSetPos(-39.0, 0.0, 149.0);
        giPlayerCurrentSetAng(170.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1002()
{
    if (global_mvar != 110701 /* 第二章 / 7-2-2.相争难休 / 离开居巢国 / 水下居巢 */)
    {
        giArenaLoad("M03", "1", "", true);
        giPlayerCurrentSetPos(-1014.9, -52.5, -1860.0);
        giPlayerCurrentSetAng(298.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("M03", "1", "", true);
    }
}

void func1003()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerWalkTo(0, 2122.7, -21.3, 2560.8, true);
            giPlayerSetDir(0, 213.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(5, true);
            giSetPortrait("101E", true);
            giTalk("云天河：菱纱说我们要离开这地方了，那些人好像也不想我们留下来……", "");
            giPlayerUnLock();
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
                giPlayerWalkTo(leader_player_id, 2144.5, -21.3, 2562.3, true);
                giPlayerSetDir(leader_player_id, 212.0, true);
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
            giArenaLoad("Q02", "Q02", "", true);
            giPlayerCurrentSetPos(-1931.6, -79.8, -1697.6);
            giPlayerCurrentSetAng(6.0);
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
        if (global_mvar != 21600 /* 第一章 / 2-1-4.初涉红尘 / 前去寿阳 / 露宿湖边 */)
        {
            giArenaLoad("Q03", "Q03S", "", true);
            giPlayerCurrentSetPos(-1.6, -13.6, 2784.6);
            giPlayerCurrentSetAng(180.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        else
        {
            giArenaLoad("Q03", "Q03S", "", true);
        }
    }
    else
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giSelectDialogAddItem("1.去寿阳城  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去寿阳城</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -1770.8, -36.8, -1994.8, true);
                giPlayerSetDir(leader_player_id, 80.0, true);
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
            giArenaLoad("Q03", "Q03S", "", true);
            giPlayerCurrentSetPos(-1.6, -13.6, 2784.6);
            giPlayerCurrentSetAng(180.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1005()
{
    if (global_mvar != 110500 /* 第二章 / 7-1-2.水中妖界 / 潜水寻妖 */)
    {
        giArenaLoad("Q10", "Q10", "", true);
        giPlayerCurrentSetPos(-902.2, -23.2, -29.5);
        giPlayerCurrentSetAng(85.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q10", "Q10", "", true);
    }
}

void func2001()
{
    giPlayerLock();
    giScriptMusicPlay("P23", 2, 0.0, 0.0);
    giTimeScriptTerminate();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, 2149.2, -21.4, 2498.7);
    giPlayerSetAng(0, 226.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 2160.5, -21.3, 2571.4);
    giPlayerSetAng(1, 217.0);
    giPlayerSetVisible(1, true);
    giMonsterSetHide("m02-01-01", false);
    giMonsterSetHide("m03-05-04", false);
    giSetObjectVisible("save1", false);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.5, false);
    giArenaReady();
    giPlayerWalkTo(1, 2056.6, -22.9, 2437.5, false);
    giWait(4.0);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：讨厌～昨天明明翻过黄历，怎么大吉也会变大凶？", "40577");
    giPlayerEndMove(1);
    giPlayerSetDir(1, 53.0, false);
    giCameraRunSingle("002", false);
    giWait(1.0);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：唔……瞧你五官端正、眉清目秀，看不出晦气这么重，真是人不可貌相。", "40578");
    giCameraSetDistOptEnable(false);
    giWait(0.3);
    giPlayerWalkTo(0, 2099.4, -21.3, 2462.8, false);
    giCameraRunSingle("003", true);
    giPlayerEndMove(0);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：菱纱，他们干嘛要赶我们走？是因为我射死了那只胖鸟？那胖鸟的名字叫“鸡”？", "40579");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：怎么可能～那只笨鸟和你爹一比根本不够看嘛，也不知他老人家什么来头，搞得天怒人怨……", "40580");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：尤其那个凶巴巴村长，都过了好多年，气还没消的样子……", "40581");
    giSetPortrait("101A", false);
    giTalk("云天河：他说的那些我爹的事情，到底什么意思？", "40582");
    giSetPortrait("103A", true);
    giTalk("韩菱纱：…………", "40583");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：哎呀～也没怎么样啦！听他唠唠叨叨说一堆，其实就是你爹个性和别人不太一样，后来四处闯荡去了。", "40584");
    giPlayerEndAction(1);
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101A", false);
    giTalk("云天河：哦……", "40585");
    giPlayerEndAction(0);
    giPlayerSetDir(0, 33.0, true);
    giWait(1.5);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：呵呵～", "40586");
    giPlayerEndAction(0);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：傻笑什么？怪人……", "40587");
    giSetPortrait("101B", false);
    giTalk("云天河：菱纱，你不觉得很棒吗？", "40588");
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：原来我爹以前待过这里，离青鸾峰还这么近！", "40589");
    giSetPortrait("103A", true);
    giTalk("韩菱纱：……", "40590");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：喂，如果…………", "40591");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetDir(0, 226.0, true);
    giSetPortrait("101C", false);
    giTalk("云天河：什么？", "40592");
    giCameraRunSingle("004", false);
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：我是说假如……你爹他是个大恶人，你还会像现在这样喜欢他吗？", "40593");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101D", false);
    giTalk("云天河：大恶人？", "40594");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：就是做了很多不好的事，大家都很讨厌他的那种人。", "40595");
    giSetPortrait("101B", false);
    giTalk("云天河：别人干嘛讨厌我爹？我就很喜欢他啊！", "40596");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：……好啦好啦，不说你爹，就说假如有个人是这样——", "40597");
    giSetPortrait("101H", false);
    giTalk("云天河：不会吧？有人这么可怜？", "40598");
    giPlayerDoAction(0, "J16", 1, false);
    giSetPortrait("101H", false);
    giTalk("云天河：那我更要帮他了！", "40599");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：傻瓜，你干嘛突然热血起来？！那人说不定是自作自受，做了坏事才会受罚——", "40600");
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：呵呵，这个我懂，以前我做错事，也会被爹罚，但他对我还是很好。", "40601");
    giSetPortrait("101B", false);
    giTalk("云天河：如果有个人，别人都对他不好，那他一个怎么可能打赢那么多个，我当然要帮忙，爹说过要保护弱小嘛！", "40602");
    giPlayerDoAction(1, "J04", -1, false);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：你……哈哈哈，不错不错，锄强扶弱，有当大侠的潜质！", "40603");
    giSetPortrait("103E", true);
    giTalk("韩菱纱：（才怪……）", "40604");
    giSetPortrait("101C", false);
    giTalk("云天河：大侠？是什么？ ", "40605");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：哎？这个说来话长，先不说了，<colour red=255 green=187 blue=0 alpha=255>我们要在天黑前赶到巢湖边，</colour><dc0>我可不要睡树林！</dc0>", "40606");
    giSetPortrait("101B", false);
    giTalk("云天河：呵呵，树林也没什么不好，打猎多方便～", "40607");
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：哼，以为别人都和你一样是野人啊……", "40608");
    giPlayerEndAction(1);
    giPlayerWalkTo(1, 1974.0, -21.3, 2427.8, false);
    giCameraRunSingle("005", true);
    giWait(1.0);
    giPlayerSetDir(0, 251.0, false);
    giPlayerEndMove(1);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：喂，山顶野人！", "40609");
    giSetPortrait("101A", false);
    giTalk("云天河：啊？", "40610");
    giPlayerSetDir(1, 74.0, true);
    giWait(0.3);
    giSetPortrait("103J", true);
    giTalk("韩菱纱：你不是说树林好吗？这里野兽多，你在前面开路吧！", "40611");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101K", false);
    giTalk("云天河：行呀，我开路，哈哈～～～", "40612");
    giPlayerEndAction(0);
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：（唉，真受不了他……一副傻样……）", "40613");
    giFlashOutBlack(1.5, true, true);
    giIMMBegin();
    giCameraSetDistOptEnable(true);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(0, false);
    giMonsterSetHide("m02-01-01", true);
    giMonsterSetHide("m03-05-04", true);
    giSetObjectVisible("save1", true);
    giIMMEnd();
    global_mvar = 20800; // 0x00005140, 湖边过夜
    giPlayerSetLeader(0);
    giPlayerCurrentSetPos(1884.2, -21.3, 2317.3);
    giPlayerCurrentSetAng(229.0);
    giPlayerCurrentSetVisible(true);
    giCameraSetMode(5, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giScriptMusicStop(0, 2.5);
    giTimeScript(180.0, "func9001");
    giPlayerUnLock();
}

void func2002()
{
    if (global_mvar == 20800 /* 湖边过夜 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giScriptMusicPlay("P23", 0, 2.5, 0.0);
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, -269.9, -27.9, -1309.8);
        giPlayerSetAng(0, 162.0483);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, -397.7, -21.3, -1132.5);
        giPlayerSetAng(1, 159.6911);
        giPlayerSetVisible(1, true);
        giSetObjectVisible("MO001", true);
        giSetObjectVisible("MO002", true);
        giSetObjectVisible("MO005", true);
        giMonsterSetHide("m03-05-02", false);
        giHideGASkillObject();
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giPlayerWalkTo(1, -341.0, -22.9, -1304.6, false);
        giWait(0.7);
        giPlayerRunTo(0, -181.4, -36.6, -1574.5, false);
        giFlashInBlack(2.0, true);
        giPlayerEndMove(0);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：哟嚯～～好大的水潭！！这就是“海”吗？！", "40614");
        giPlayerEndMove(1);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：（没听见，没听见，没听见，懒得理你……）", "40615");
        giWait(0.5);
        giCameraRunSingle("002", true);
        giPlayerSetPos(1, -124.8, -24.9, -1483.0);
        giPlayerSetAng(1, 117.0);
        giPlayerWalkTo(1, 49.0, -43.1, -1578.7, true);
        giPlayerSetDir(1, 196.0, true);
        giPlayerDoAction(1, "J03", -1, false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetPos(0, -140.6, -31.3, -1529.4);
        giPlayerSetAng(0, 91.0992);
        giPlayerWalkTo(0, -13.6, -35.3, -1535.9, true);
        giPlayerSetDir(0, 125.0, true);
        giSetPortrait("101C", true);
        giTalk("云天河：咦？菱纱你做什么？", "40616");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：生火啊……不知怎么了，今天特别累，早点歇息吧。天色都暗下来了，赶夜路不安全。", "40617");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：这样，能生火吗？", "40618");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：啰嗦，不然怎么办，打火石被我弄丢了……应该也不会很难吧？没听说那些大侠在野外还有生不起火的。", "40619");
        giSetPortrait("101B", true);
        giTalk("云天河：菱纱，你搞错了！", "40620");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 325.0, true);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：什么搞错了？", "40621");
        giSetPortrait("101B", true);
        giTalk("云天河：你在这里等一下！", "40622");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("003", false);
        giPlayerSetAng(0, 331.0);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "J13", 1, true);
        giWait(0.3);
        giPlayerRunTo(0, -174.1, -21.3, -1063.2, false);
        giWait(1.2);
        giPlayerEndMove(0);
        giPlayerDoAction(0, "J03", -1, true);
        giWait(0.5);
        giSetObjectVisible("MO001", false);
        giWait(1.0);
        giSetObjectVisible("MO002", false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 105.0, true);
        giWait(0.5);
        giPlayerRunTo(0, 159.3, 2.6, -1243.1, false);
        giWait(1.5);
        giPlayerSetDir(1, 26.0, false);
        giPlayerEndMove(0);
        giPlayerDoAction(0, "J03", -1, true);
        giWait(0.5);
        giSetObjectVisible("MO005", false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerRunTo(0, 294.8, -7.8, -1333.4, true);
        giIMMBegin();
        giPlayerSetPos(0, 503.3, -12.3, -1367.3);
        giPlayerSetAng(0, 247.0);
        giSetObjectVisible("MO003", true);
        giIMMEnd();
        giSetPortrait("101B", true);
        giTalk("云天河：菱纱，来这边！", "40623");
        giPlayerSetDir(1, 72.0, false);
        giCameraRunSingle("004", true);
        giWait(0.3);
        giPlayerDoAction(0, "J19", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：这里、这里～～", "40624");
        giWait(0.3);
        giCameraRunSingle("005", true);
        giPlayerSetDir(0, 102.0, true);
        giPlayerDoAction(0, "J03", -1, true);
        giPlayerSetPos(1, 236.5, -10.1, -1357.3);
        giPlayerSetAng(1, 86.0);
        giWait(0.7);
        giPlayerWalkTo(1, 451.1, -10.2, -1339.1, true);
        giPlayerSetDir(1, 116.0, true);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：这是……？", "40625");
        giSetPortrait("101B", true);
        giTalk("云天河：想睡觉的话，一定不要在上风处，不然野兽的鼻子那么灵，等你一觉醒来说不定已经在它肚子里了～", "40626");
        giSetPortrait("101B", true);
        giTalk("云天河：太靠近水边的木头也不好，不容易点着，就算点起来，烟都熏得够呛了。", "40627");
        giSetPortrait("101K", true);
        giTalk("云天河：好了，你看！", "40628");
        giSetObjectVisible("Jeffect001", true);
        giSetObjectVisible("sound004", true);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerWalkTo(0, 472.1, -8.8, -1389.3, true);
        giPlayerSetDir(0, 330.0, true);
        giWait(1.2);
        giPlayerSetDir(1, 155.0, true);
        giCameraRunSingle("006", false);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：这些，都是你爹教的吗？！", "40629");
        giSetPortrait("101A", true);
        giTalk("云天河：啊？爹教过一些吧，还有我自己发现的。", "40630");
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：好厉害，难怪你能做山顶野人这么多年！", "40631");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101C", true);
        giTalk("云天河：……？", "40632");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：啊，不，我这绝对是夸你！ ", "40633");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：会吗？这些都很平常啊，没什么、没什么，哈哈哈～", "40634");
        giWait(3.0);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：听到没？好怪的声音，像很大只的虫子。", "40635");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101F", true);
        giTalk("云天河：不是虫子……是我肚子叫，我饿了。", "40636");
        giSetPortrait("103M", false);
        giTalk("韩菱纱：嘻嘻，不早说，那我们吃干粮吧。", "40637");
        giSetPortrait("101D", true);
        giTalk("云天河：干粮？是什么？", "40638");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（可恶……刚才还觉得他懂很多东西，很了不起……结果该懂的还是不懂……）", "40639");
        giPlayerEndAction(1);
        giSetPortrait("101A", true);
        giTalk("云天河：菱纱，“干粮”到底是什么？", "40640");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：那，这个给你。", "40641");
        giSetObjectVisible("MO008", true);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：我带的干粮，可以吃，我们分着吃。", "40642");
        giWait(0.5);
        giSetObjectVisible("MO008", false);
        giWait(0.3);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101B", true);
        giTalk("云天河：原来这就叫作干粮呀！", "40643");
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：耶～不用饿肚子，太好了！", "40644");
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("005", true);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giSetObjectVisible("MO003", false);
        giSetObjectVisible("Jeffect001", false);
        giSetObjectVisible("sound004", false);
        giIMMEnd();
        giArenaLoad("M03", "1Y", "", false);
        giPlayerLock();
        giCameraSetCollide(false);
        giPlayerCurrentSetVisible(false);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giArenaReady();
        giIMMBegin();
        giPlayerSetPos(0, 601.7, -16.7, -1399.5);
        giPlayerSetAng(0, 314.0);
        giPlayerSetPos(1, 595.7, -18.9, -1361.8);
        giPlayerSetAng(1, 235.0);
        giSetObjectVisible("MO003", true);
        giSetObjectVisible("Jeffect001", true);
        giSetObjectVisible("MO001", true);
        giSetObjectVisible("MO002", true);
        giSetObjectVisible("MO004", true);
        giSetObjectVisible("MO005", true);
        giSetObjectVisible("MO006", true);
        giSetObjectVisible("MO007", true);
        giSetObjectVisible("MO008", true);
        giSetObjectVisible("MO009", true);
        giSetObjectVisible("save", false);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giIMMEnd();
        giPlayerDoAction(0, "J11", 0, false);
        giPlayerDoAction(1, "J11", 0, false);
        giFlashInBlack(1.5, false);
        giSetObjectVisible("sound004", true);
        giWait(1.0);
        giCameraRunSingle("002", false);
        giSetPortrait("101E", false);
        giTalk("云天河：……唔，这个“干粮”怎么比那个粽子还难吃，又干又硬，吃得好噎……", "40645");
        giPlayerDoAction(1, "C10", 0, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：出门在外能填饱肚子就行了，哪来这么多挑剔。", "40646");
        giSetPortrait("101E", false);
        giTalk("云天河：……唔，我还没饱。", "40647");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：还说呢，要不是你爹把太平村的人都得罪了，你又这么活宝，我们哪会沦落至此啊！", "40648");
        giPlayerDoAction(0, "C10", 0, false);
        giSetPortrait("101E", false);
        giTalk("云天河：是山下的人太古怪，一下要那个什么“钱”，一下又乱说话，杀不杀鸟自己都没想清楚，爹肯定也是受不了他们，才住到山里去的。", "40649");
        giSetPortrait("103B", true);
        giTalk("韩菱纱：笨笨笨！人家凭什么白给你东西，吃的用的，都要拿钱去换。", "40650");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：哼，这回算是运气好，万一在城里遇上官差，把你抓到衙门关起来，看你怎么办！", "40651");
        giPlayerDoAction(0, "J11", 0, false);
        giCameraRunSingle("003", true);
        giCameraRunSingle("004", false);
        giSetPortrait("101D", true);
        giTalk("云天河：关豺是啥？牙门又是什么东西？", "40652");
        giSetPortrait("103D", false);
        giTalk("韩菱纱：你还真是什么都不懂啊……如果有人不守法令，就会被抓去关起来，严重一点说不定还要被杀头，负责抓人的就是官差，关人的地方就是衙门。", "40653");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：至于法令嘛，是皇帝定的，他说什么大家都得听。", "40654");
        giSetPortrait("101B", true);
        giTalk("云天河：呵呵，那个关豺又不一定打得赢我，遇上他我也不怕～", "40655");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：我不是说过吗？别总比谁的拳头硬。要跟官府对上，就凭你一个人，有几条命都不够。", "40656");
        giCameraRunSingle("005", true);
        giPlayerDoAction(0, "C10", 0, false);
        giIMMBegin();
        giSetObjectVisible("MO002", false);
        giSetObjectVisible("MO004", false);
        giSetObjectVisible("MO005", false);
        giSetObjectVisible("MO006", false);
        giSetObjectVisible("MO007", false);
        giSetObjectVisible("MO008", false);
        giSetObjectVisible("MO009", false);
        giIMMEnd();
        giCameraRunSingle("006", false);
        giSetPortrait("101B", false);
        giTalk("云天河：一个人？不是还有你吗？加一起两条命。", "40657");
        giSetPortrait("103D", true);
        giTalk("韩菱纱：你！……", "40658");
        giSetPortrait("103G", true);
        giTalk("韩菱纱：你少乱说！我、我又和你没什么关系，干嘛帮你……", "40659");
        giSetPortrait("101C", false);
        giTalk("云天河：菱纱，你怎么脸红了？", "40660");
        giSetPortrait("103G", true);
        giTalk("韩菱纱：多话！是火光，才不是我脸红！", "40661");
        giSetPortrait("103G", true);
        giTalk("韩菱纱：……总之如果有人告诉你那东西是拿来卖的，你想要就得拿钱去换！没钱问我要好了，太多我可不帮你出。", "40662");
        giSetPortrait("101B", false);
        giTalk("云天河：哦。", "40663");
        giSetPortrait("101B", false);
        giTalk("云天河：呵呵，菱纱你对我真好，除了爹以外，你是对我最好的人。", "40664");
        giSetPortrait("103G", true);
        giTalk("韩菱纱：胡说什么，你这辈子才认识几个人，又哪里知道谁是真正对你好。", "40665");
        giSetPortrait("101B", false);
        giTalk("云天河：我当然知道。", "40666");
        giSetPortrait("101B", false);
        giTalk("云天河：爹说过，对你好的人，不一定看得出来，要用心去体会，这和学剑术是一个道理，不能只看外表。", "40667");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……你爹虽然过世得早，可教了你很多东西，不像我，连话都没和爹说上几句……", "40668");
        giSetPortrait("101B", false);
        giTalk("云天河：天天在一起，怎么可能不说话？", "40669");
        giSetPortrait("103H", true);
        giTalk("韩菱纱：就算爹娘在世的时候，我们也不住一起……只有伯父对我好……", "40670");
        giSetPortrait("101A", false);
        giTalk("云天河：……", "40671");
        giSetPortrait("103H", true);
        giTalk("韩菱纱：哎，瞧你那副呆呆的样子，天底下什么事都有，只是你没见过罢了。", "40672");
        giWait(0.6);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 177.0, true);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：不说了，今天不知为什么，就是觉得比平时累，早点睡吧。", "40673");
        giPlayerEndAction(0);
        giPlayerSetDir(0, 345.0, true);
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：这就睡了吗？", "40674");
        giCameraRunSingle("008", false);
        giPlayerWalkTo(1, 599.1, -19.1, -1291.9, false);
        giWait(0.3);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：对啊，养足精神，<colour red=255 green=187 blue=0 alpha=255>明天一早赶去附近的寿阳城，</colour><dc0>不管要办什么事，都还是大城里方便些。</dc0>", "40675");
        giPlayerEndMove(1);
        giPlayerFaceToPlayer(0, 1, true);
        giPlayerSetAng(1, 284.0);
        giPlayerDoAction(1, "C11", 0, false);
        giWait(1.4);
        giPlayerDoAction(0, "J14", 1, false);
        giCameraRunSingle("009", false);
        giSetPortrait("101C", true);
        giTalk("云天河：可是……我还没怎么吃饱……", "40676");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：没吃饱就再吃啊，这种事还要问我？", "40677");
        giSetPortrait("101E", true);
        giTalk("云天河：但是干粮没了。", "40678");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你烦不烦呐？我要睡觉，安静点好吗？", "40679");
        giCameraRunSingle("010", true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：哦……", "40680");
        giPlayerEndAction(1);
        giPlayerFaceToPlayer(1, 0, false);
        giWait(0.7);
        giCameraRunSingle("011", false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：等等！你说什么？！干粮没了？", "40681");
        giCameraWait();
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你！简直是饭桶！饭桶猪！三天的干粮被你一顿就吃完了，还～没～吃～饱？", "40682");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：也不是一点没饱，就是怕夜里会饿……", "40683");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：哼，干粮我都没吃几口，全被你吃光，要喊饿也该我先喊。", "40684");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：真是懒得理你了，我要睡觉……", "40685");
        giFlashOutBlack(2.0, true, true);
        giIMMBegin();
        giSetObjectVisible("MO001", false);
        giPlayerSetPos(0, 526.1, -10.6, -1415.7);
        giPlayerSetAng(0, 287.0);
        giPlayerSetPos(1, 573.9, -19.1, -1328.7);
        giPlayerSetAng(1, 303.0);
        giPlayerSetVisible(1, true);
        giIMMEnd();
        giPlayerDoAction(1, "C11", 0, false);
        giPlayerDoAction(0, "C11", 0, false);
        giCameraRunSingle("014", true);
        giPlayerSetEmotion(0, "101_by");
        giPlayerSetEmotion(1, "103_hm");
        giFlashInBlack(2.5, false);
        giWait(1.0);
        giCameraRunSingle("013", false);
        giWait(2.0);
        giPlayerSetEmotion(0, "101_zc");
        giWait(4.5);
        giSetPortrait("101E", true);
        giTalk("云天河：（饿醒了，睡不着……）", "40686");
        giPlayerDoAction(0, "J20", -1, true);
        giSetPortrait("101B", true);
        giTalk("云天河：（……干脆去树林里猎熊，呵呵，烤熊掌～）", "40687");
        giFlashOutBlack(1.5, true, true);
        giSetObjectVisible("save", true);
        giPlayerOutTeam(1, false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "C01", 1, false);
        global_mvar = 20900; // 0x000051A4, 第一章 / 2-1-3.初涉红尘 / 夜半猎熊
        giPlayerSetLeader(0);
        giPlayerCurrentSetPos(514.8, -10.2, -1410.3);
        giPlayerCurrentSetAng(287.0);
        giMonsterSetHide("m03-05-02", true);
        giPlayerCurrentSetVisible(true);
        giArenaSkillEnable(false);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giIMMBegin();
        giPlayerSetPos(1, 573.9, -19.1, -1328.7);
        giPlayerSetAng(1, 303.0);
        giPlayerSetVisible(1, true);
        giIMMEnd();
        giPlayerDoAction(1, "C11", 0, false);
        giPlayerAttachCollision(1);
        giWait(0.5);
        giFlashInBlack(1.5, true);
        giScriptMusicStop(1, 2.5);
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
    }
}

void func2003()
{
    if (global_mvar == 20900 /* 第一章 / 2-1-3.初涉红尘 / 夜半猎熊 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetPos(485.7, -9.0, -1398.6);
        giPlayerCurrentSetAng(279.0);
        giPlayerSetPos(1, 575.9, -18.0, -1334.8);
        giPlayerSetAng(1, 269.0);
        giMonsterSetHide("m03-05-02", false);
        giPlayerSetVisible(1, true);
        giSetObjectVisible("save", false);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giPlayerDetachCollision(1);
        giPlayerWalkTo(0, 280.2, -10.2, -1360.1, false);
        giPlayerSetEmotion(1, "103_zc");
        giFlashInBlack(1.5, false);
        giWait(3.0);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……咦？你要去哪？", "40688");
        giPlayerEndMove(0);
        giPlayerDoAction(1, "C10", 0, false);
        giPlayerSetDir(0, 88.0, false);
        giCameraRunSingle("002", true);
        giWait(1.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：我、我去猎熊，那个干粮吃得不过瘾，又饿了。", "40689");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：荒郊野外，又是大半夜的，太危险了吧？！", "40690");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：不会不会～熊就是夜里才出来比较多。你在这等我。", "40691");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：可是，这又不是青鸾峰，你对附近不熟……你别去了，我——", "40692");
        giPlayerEndAction(0);
        giCameraRunSingle("003", false);
        giPlayerWalkTo(0, 391.3, -4.5, -1349.2, false);
        giSetPortrait("101C", false);
        giTalk("云天河：什么……？", "40693");
        giPlayerEndMove(0);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：我——", "40694");
        giScriptMusicPlay("P24", 2, 0.0, 0.0);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：呵呵，我懂了～爹说女孩子胆子都很小，你一个人待在这会害怕吧？", "40695");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101K", false);
        giTalk("云天河：放心，我不去了，肚子饿最多再想别的办法，我先保护好你。", "40696");
        giSetPortrait("103G", true);
        giTalk("韩菱纱：你懂什么懂，自作聪明的傻瓜！我……我自己……才没那么娇气呢～", "40697");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", false);
        giTalk("云天河：娇气？……不懂……", "40698");
        giSetPortrait("103G", true);
        giTalk("韩菱纱：……懒得跟你解释，老是问东问西的……", "40699");
        giSetPortrait("101E", false);
        giTalk("云天河：我……", "40700");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：唉……算了，不说这个了……", "40701");
        giWait(0.5);
        giCameraRunSingle("004", true);
        giWait(0.4);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：嘻，你看！", "40702");
        giWait(0.5);
        giIMMBegin();
        giSetObjectVisible("MO010", true);
        giSetObjectVisible("MO011", true);
        giSetObjectVisible("MO012", true);
        giSetObjectVisible("MO013", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("101D", true);
        giTalk("云天河：……粽子？！", "40703");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：哼哼～吓一跳吧？姑娘我顺手牵羊，不不不，是神机妙算，早就准备好了。", "40704");
        giSetPortrait("103M", false);
        giTalk("韩菱纱：那个摊主好讨厌，明明说了要给钱，他还纠缠不休，摆明欺负人！", "40705");
        giCameraRunSingle("005", false);
        giPlayerWalkTo(0, 489.8, -13.3, -1338.8, false);
        giWait(0.5);
        giSetPortrait("101C", true);
        giTalk("云天河：可是……你拿了粽子，我没见你给他“钱”。", "40706");
        giPlayerEndMove(0);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：都说顺手拿的了，还给什么钱？", "40707");
        giSetPortrait("103M", false);
        giTalk("韩菱纱：对了！先说好，你可不能学我，这次是那些村民错在先，他们不仁，我们也就不义！", "40708");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：哦……蛮公平的嘛，先不仁后不义，我知道了。但是这个粽子不好吃，里面还好，外面的壳嚼不烂！", "40709");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：原来……哈哈，怎么会有人连粽叶也吃下去！", "40710");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：来来来，你过来，看我大发善心，帮你把粽叶剥了，你再尝尝！", "40711");
        giFlashOutBlack(1.5, true, true);
        giPlayerSetPos(0, 524.3, -15.5, -1339.9);
        giPlayerSetAng(0, 83.0);
        giPlayerDoAction(0, "C10", 0, false);
        giCameraRunSingle("006", true);
        giFlashInBlack(2.0, false);
        giWait(0.5);
        giCameraRunSingle("007", false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：……这样……再这样……好，大功告成～", "40712");
        giPlayerDoAction(0, "J11", 0, false);
        giSetPortrait("101K", false);
        giTalk("云天河：……唔……好香！", "40713");
        giSetObjectVisible("MO011", false);
        giSetPortrait("101K", false);
        giTalk("云天河：不错！和烤的肉不太一样。 ", "40714");
        giSetObjectVisible("MO012", false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：嘻～饥时百味香，有三只粽子也是好的——", "40715");
        giSetObjectVisible("MO013", false);
        giPlayerDoAction(0, "C10", 0, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：咦？你、你又全部吃完了？！", "40716");
        giSetPortrait("101K", false);
        giTalk("云天河：是、是吗？实在很好吃，我一不小心就……呵呵。", "40717");
        giWait(0.4);
        giPlayerEndAction(1);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：傻笑什么？！想蒙混过去？", "40718");
        giSetPortrait("103F", true);
        giTalk("韩菱纱：我可是一口还没吃，肚子咕咕叫呢！", "40719");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101C", false);
        giTalk("云天河：没、没有啦！", "40720");
        giSetPortrait("101B", false);
        giTalk("云天河：啊！这样吧，菱纱你别气，我让好吃的自己送上门来！", "40721");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：你？你那木鱼脑袋，除了气我，还能想出什么妙计？", "40722");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101K", false);
        giTalk("云天河：看我的！", "40723");
        giCameraRunSingle("008", true);
        giPlayerEndAction(0);
        giIMMBegin();
        giSetObjectVisible("MO010", false);
        giPlayerSetPos(0, -422.9, -41.7, -1399.4);
        giPlayerSetAng(0, 266.0);
        giPlayerSetPos(1, -431.5, -42.0, -1376.2);
        giPlayerSetAng(1, 269.0);
        giIMMEnd();
        giPlayerWalkTo(0, -668.4, -59.0, -1388.6, true);
        giWait(0.5);
        giPlayerSetDir(0, 212.0, true);
        giPlayerDoAction(0, "J13", 1, true);
        giPlayerSetDir(0, 299.0, true);
        giPlayerDoAction(0, "J13", 1, true);
        giWait(0.5);
        giPlayerDoAction(0, "J23", -1, false);
        gi2DSoundPlay("WJ011", 1);
        giWait(0.8);
        giWait(1.0);
        giPlayerRunTo(1, -640.8, -60.0, -1381.6, true);
        giPlayerSetDir(1, 274.0, true);
        giPlayerDoAction(1, "J20", 1, false);
        giWait(0.2);
        gi2DSoundPlay("WJ012", 1);
        giSetPortrait("101E", false);
        giTalk("云天河：哎哟，痛！", "40724");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 83.0, true);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：三更半夜的，杀猪啊！", "40725");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：不是，刚才我学母山猪叫，公山猪听到这个声音就会被引过来，呵呵～", "40726");
        giSetPortrait("101B", false);
        giTalk("云天河：春天这招特别管用，就不知道夏天灵不灵了。", "40727");
        giSetPortrait("103G", true);
        giTalk("韩菱纱：什么？母……公……引过来……春天……", "40728");
        giPlayerDoAction(1, "J15", 1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：你！……好粗俗！！", "40729");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P56", 2, 0.0, 0.0);
        giPlayerSetDir(0, 299.0, false);
        giSetPortrait("101J", false);
        giTalk("云天河：慢——你听，有动静了！", "40730");
        giPlayerSetDir(1, 307.0, true);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：来了来了，烤山猪！", "40731");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……真、真的吗？", "40732");
        giWait(0.3);
        gi2DSoundPlay("WJ013", 1);
        giWait(1.0);
        giPlayerEndAction(0);
        gi2DSoundPlay("WJ014", 1);
        giWait(1.0);
        giEffectPlayWithNPC("H_126", 1, "MN001");
        giNpcBlendIn("MN001", 2.0, true);
        giEffectPlayWithNPC("H_126", 1, "MN002");
        giNpcBlendIn("MN002", 2.0, true);
        giWait(0.7);
        giIMMEnd();
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：呀！是妖怪！！", "40733");
        giSetPortrait("101D", false);
        giTalk("云天河：啊？怎么会这样？春天夏天真的不一样啊！", "40734");
        giPlayerDoAction(1, "Z01", 0, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：早说你笨了！再这样下去，迟早被你害死！", "40735");
        giSetPortrait("103K", true);
        giTalk("韩菱纱：可恶！从山上一路下来，我受了多少气，你可不可以别再气我了呀？！", "40736");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：……话是这么说没错，但我真的不是故意的………", "40737");
        giFlashOutBlack(1.0, true, true);
        giPlayerInTeam(1, false);
        giPlayerDoAction(0, "C01", 0, false);
        giIMMBegin();
        giPlayerSetPos(0, -592.9, -59.7, -1417.3);
        giPlayerSetAng(0, 285.0);
        giPlayerSetPos(1, -600.5, -61.8, -1457.1);
        giPlayerSetAng(1, 303.0);
        giNpcSetPos("MN001", -652.7, -53.6, -1334.6);
        giNpcSetAng("MN001", 84.0);
        giNpcSetPos("MN002", -750.2, -50.3, -1387.1);
        giNpcSetAng("MN002", 173.0);
        giIMMEnd();
        giPlayerDoAction(1, "Z11", 0, false);
        giNpcDoAction("MN001", "J01", 0, false);
        giNpcDoAction("MN002", "J01", 0, false);
        giSetFullHP();
        giSetFullMP();
        giAddCombatMonster(2582, 1);
        giAddCombatMonster(2582, 0);
        giConfigCombatBgm("P39");
        giConfigCombatCamera("CA7");
        giConfigCombatGroundCamera("CA13");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M03B");
        giScriptMusicPlay("P56", 2, 0.0, 0.0);
        giCameraRunSingle("010", true);
        giLINGSHALegsInjured("103_2 (ss)");
        giFlashInBlack(1.0, true);
        giSetPortrait("101B", true);
        giTalk("云天河：呼～～这两只挺厉害的嘛，差一点就打不过。", "40738");
        giPlayerSetDir(0, 192.0, true);
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：菱纱，你受伤了？！这么多血，有没有伤到骨头？", "40739");
        giSetPortrait("103H", true);
        giTalk("韩菱纱：好晕……别大呼小叫，扶我到火堆边上……", "40740");
        gi2DSoundPlay("WJ014", 1);
        giIMMBegin();
        giSetNpcVisible("MN003", true);
        giSetNpcVisible("MN004", true);
        giSetNpcVisible("MN005", true);
        giEffectPlayWithNPC("H_126", 1, "MN003");
        giEffectPlayWithNPC("H_126", 1, "MN004");
        giEffectPlayWithNPC("H_126", 1, "MN005");
        giIMMEnd();
        giPlayerSetDir(0, 236.0, false);
        giCameraRunSingle("011", false);
        giWait(1.2);
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：糟了！！", "40741");
        giCameraWait();
        giPlayerEndAction(0);
        giPlayerRunTo(0, -689.5, -51.7, -1487.5, true);
        giPlayerSetDir(0, 227.0, true);
        giPlayerDoAction(0, "Z01", 0, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……天河，你快跑吧！", "40742");
        giSetPortrait("103H", true);
        giTalk("韩菱纱：往东边跑，快！！", "40743");
        giSetPortrait("101J", false);
        giTalk("云天河：……", "40744");
        giSetPortrait("101J", false);
        giTalk("云天河：我不走！你没有不仁，我不可以对你不义！", "40745");
        giSetPortrait("103H", true);
        giTalk("韩菱纱：你……你这笨蛋倒学得快……真要你我两条命搁这儿了吗……", "40746");
        giNpcDoAction("MN004", "X02", 1, false);
        gi2DSoundPlay("WJ014", 1);
        giWait(0.5);
        giFlashOutBlack(1.2, true, true);
        giScriptMusicPause();
        giPlayMovie("2L.bik");
        giOpenMovieFlag(3);
        giScriptMusicResume();
        giScriptMusicPlay("P57", 2, 0.0, 0.0);
        giIMMBegin();
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN004", false);
        giSetNpcVisible("MN005", false);
        giSetNpcVisible("MN006", true);
        giLINGSHALegsHealing();
        giIMMEnd();
        giPlayerDoAction(0, "C01", 0, false);
        giPlayerDoAction(1, "C01", 0, false);
        giCameraRunSingle("012", true);
        giFlashInBlack(1.5, false);
        giSetPortrait("202D", false);
        giTalk("？？：紫英师叔，等一下，等等我嘛！", "40747");
        gi2DSoundPlay("WJ059", 1);
        giNpcRunTo("MN006", -542.7, -21.3, -841.9, true);
        giNpcSetDir("MN006", 188.0, true);
        giWait(1.0);
        giCameraRunSingle("013", true);
        giWait(0.6);
        giNpcDoAction("MN006", "J01", 1, false);
        giSetPortrait("202C", false);
        giTalk("？？：真是的，又没追上！", "40748");
        giSetPortrait("203C", false);
        giTalk("？？：璇玑，你慢点……", "40749");
        giSetNpcVisible("MN007", true);
        giWait(0.8);
        giIMMBegin();
        giCameraRunSingle("014", false);
        giNpcSetAng("MN006", 310.0);
        giIMMEnd();
        giWait(0.6);
        giSetPortrait("202C", true);
        giTalk("璇玑：怀～朔～师～兄，要不是你慢慢吞吞，我们怎么可能把紫英师叔追丢了！", "40750");
        giNpcWalkTo("MN007", -584.7, -21.3, -807.0, false);
        giSetPortrait("203A", false);
        giTalk("怀朔：璇玑，别忘了，你我之前收妖时不慎中了禁咒，四十八个时辰内无法施展御剑之术，光凭两条腿，如何追得上紫英师叔啊？", "40751");
        giNpcEndMove("MN007");
        giSetPortrait("203A", false);
        giTalk("怀朔：何况师叔他本次下山，也是有正事要办，你这样一味跟着，又算什么？", "40752");
        giNpcDoAction("MN006", "J01", 1, false);
        giSetPortrait("202C", true);
        giTalk("璇玑：我不管～我就喜欢跟着他！你陪我去陈州，现在就去！", "40753");
        giSetPortrait("202C", true);
        giTalk("璇玑：师叔说过要去陈州察看那里的先天八卦阵有无乱象，我们去了就能遇到他！", "40754");
        giNpcEndAction("MN006", false);
        giNpcDoAction("MN007", "C08", 1, false);
        giSetPortrait("203A", false);
        giTalk("怀朔：好好好，都依你。", "40755");
        giSetPortrait("203A", false);
        giTalk("怀朔：先找个地方歇脚，待御剑术恢复之后，关山万里也不过瞬息而至，又何必急在一时呢？", "40756");
        giSetPortrait("202A", true);
        giTalk("璇玑：嗯～你说话要算数！", "40757");
        giNpcWalkTo("MN006", -479.3, -21.3, -906.5, true);
        giSetNpcVisible("MN006", false);
        giNpcDoAction("MN007", "C09", 1, false);
        giSetPortrait("203A", false);
        giTalk("怀朔：这小师妹，真是……唉……", "40758");
        giNpcEndAction("MN007", true);
        giNpcSetDir("MN007", 204.0, true);
        giIMMBegin();
        giPlayerSetPos(0, -628.6, -21.7, -953.4);
        giPlayerSetAng(0, 12.0);
        giPlayerSetPos(1, -648.8, -21.3, -916.9);
        giPlayerSetAng(1, 36.0);
        giIMMEnd();
        giCameraRunSingle("015", true);
        giWait(1.0);
        giNpcWalkTo("MN007", -605.7, -21.3, -853.2, true);
        giWait(0.5);
        giNpcDoAction("MN007", "J01", 1, false);
        giSetPortrait("203B", true);
        giTalk("怀朔：抱歉，惊扰二位。", "40759");
        giNpcEndAction("MN007", false);
        giCameraRunSingle("016", true);
        giCameraRunSingle("017", false);
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：哪、哪里，是我们该道谢才对。", "40760");
        giSetPortrait("103M", false);
        giTalk("韩菱纱：要不是刚才那位剑……剑仙前辈出手相助，我们怕是已经进了妖怪的肚子。", "40761");
        giSetPortrait("203B", true);
        giTalk("怀朔：哈哈，师叔的年纪其实与你们相仿，我还虚长他几岁，不过剑术进境却是望尘莫及的。", "40762");
        giSetPortrait("203B", true);
        giTalk("怀朔：师叔最是嫉恶如仇，适才想必也是举手之劳，两位不必放在心上。", "40763");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：他那一招……用几把剑同时砍中妖怪，真是厉害！", "40764");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("203B", true);
        giTalk("怀朔：紫英师叔已臻“以气成剑”之境，剑气收发，有形而无质，区区几只小妖，自然应付自如。", "40765");
        giSetPortrait("203B", true);
        giTalk("怀朔：如今这附近妖气已除，二位安心即可。", "40766");
        giSetPortrait("103M", false);
        giTalk("韩菱纱：还没请教尊姓大名？", "40767");
        giSetPortrait("203B", true);
        giTalk("怀朔：在下怀朔，相逢自是有缘，二位气质不凡，不知不觉与你们多说了几句。", "40768");
        giNpcDoAction("MN007", "J01", 1, false);
        giSetPortrait("203B", true);
        giTalk("怀朔：我也该去追我那小师妹了，告辞！", "40769");
        giNpcEndAction("MN007", true);
        giCameraRunSingle("018", true);
        giNpcWalkTo("MN007", -512.4, -21.3, -1038.3, false);
        giCameraRunSingle("019", false);
        giWait(2.3);
        giIMMBegin();
        giPlayerSetDir(0, 100.0, false);
        giPlayerSetDir(1, 117.0, false);
        giIMMEnd();
        giNpcEndMove("MN007");
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：哎，害我紧张得要命～真不敢相信，我刚才是在和剑仙说话耶！", "40770");
        giPlayerEndAction(1);
        giSetPortrait("101C", true);
        giTalk("云天河：剑仙？", "40771");
        giPlayerSetDir(1, 150.0, false);
        giCameraRunSingle("020", true);
        giWait(0.5);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：你也看清楚了吧？尤其那个“师叔”，不但一下就打倒难缠的妖怪，还治好了我的腿伤，修仙的时日肯定不短。", "40772");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：我想想～他们说要去陈州，不如我们也赶去那里碰碰运气，那个怀朔看起来很好讲话，要是肯收你我入剑仙门下，就再好不过了！", "40773");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：喂，你有没有在听我说话？倒是回一句啊！", "40774");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P23", 2, 2.5, 0.0);
        giPlayerSetDir(0, 324.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：……菱纱，为什么只有一开始那人是用飞的，其他两个都用走的？还有，要怎么样才能站在剑上飞？", "40775");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：嘻嘻，那个就是我和你提过的御剑术，修仙之人几乎都会。", "40776");
        giSetPortrait("101K", false);
        giTalk("云天河：真的吗？", "40777");
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：那我也要修仙！！学会御剑术之后，如果想去山里打猎吃烤肉，“嗖”的一下就到了，多快！而且还可以像老鹰一样从空中往下看，这样就很容易发现山猪啦，哈哈！", "40778");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：（……三句不离山猪……这人真是……嗜猪成性……）", "40779");
        giPlayerEndAction(1);
        giSetPortrait("101K", false);
        giTalk("云天河：这么好玩的事，爹以前怎么都不告诉我！ ", "40780");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：…………", "40781");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：（大傻瓜一个……）", "40782");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：爹……咦？不对呀……", "40783");
        giSetPortrait("101D", false);
        giTalk("云天河：菱纱，那几个人衣服上的花纹我觉得很眼熟……", "40784");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：嘻，别说笑了，你又没什么见识，虽说那个图案是挺特别的——", "40785");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：咦？——等等！快把那块古玉拿出来，墓室里的那个！", "40786");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.2);
        giSetObjectVisible("MO014", true);
        giSetPortrait("101D", false);
        giTalk("云天河：怎么了？", "40787");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：笨，看上面的图案，一模一样！！", "40788");
        giSetPortrait("101D", false);
        giTalk("云天河：真的……这……是不是说明他们认识我爹和我娘？", "40789");
        giWait(0.3);
        giSetObjectVisible("MO014", false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：也不一定吧，要是你爹娘在山上隐居好多年，以年纪来算，不太可能是相识的，不过说不定他们和这个修仙门派有什么关系呢。", "40790");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：（看来我估计的没错，这野人的爹应该是剑仙，真是太好了！）", "40791");
        giCameraRunSingle("021", true);
        giSetPortrait("101D", false);
        giTalk("云天河：门牌？啥东西？", "40792");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：受不了你……是门“派”，简单说就是很多人聚在一起练功，那他们都算这一派的人，你爹也许就是哦。", "40793");
        giSetPortrait("101B", false);
        giTalk("云天河：好，我们马上去那个门派，问清楚！", "40794");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：唉，你刚才果然没听我讲话，都已经说了要去陈州找怀朔，运气好点说不定就拜入他们的门派修仙，这下可好了，还能顺便查你爹娘的事。", "40795");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：时间嘛，我知道寿阳城有条近路可以去陈州，只好拼一拼啰！", "40796");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：菱纱，你好像什么都懂，真厉害！", "40797");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：哼哼～山里你是山大王，下山后还是多听我的为好——", "40798");
        giPlayerEndAction(1);
        giWait(1.0);
        giSetPortrait("101C", false);
        giTalk("云天河：什么声音？", "40799");
        giCameraRunSingle("022", true);
        giSetNpcVisible("MN007", false);
        giWait(0.3);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103G", true);
        giTalk("韩菱纱：没、没有啊，你听错了吧？", "40800");
        giPlayerEndAction(1);
        giSetPortrait("101B", false);
        giTalk("云天河：明明是肚子叫的声音，我肚子没叫，那——", "40801");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103G", true);
        giTalk("韩菱纱：……干粮粽子都被吃光了，我肚子饿也不行吗？", "40802");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101K", false);
        giTalk("云天河：呵呵，差点忘了，你等一下！我马上把这两只死妖怪烤了，保证香喷喷！", "40803");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：你你你！你到底有没有常识啊？！妖怪怎么能吃？！", "40804");
        giSetPortrait("101B", false);
        giTalk("云天河：怎么不能吃？和山猪一样，有皮有肉，没差多少。", "40805");
        giSetPortrait("103I", true);
        giTalk("韩菱纱：差很多好不好？你这山顶野人……", "40806");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：算了，我睡了。", "40807");
        giCameraRunSingle("023", false);
        giPlayerWalkTo(1, -499.8, -21.3, -904.5, false);
        giWait(1.5);
        giPlayerSetDir(0, 61.0, false);
        giWait(1.0);
        giSetPortrait("101C", false);
        giTalk("云天河：可是饿着肚子很难受吧？", "40808");
        giPlayerEndMove(0);
        giPlayerSetDir(1, 256.0, true);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：要我吃那些东西，我宁可饿死算了！", "40809");
        giPlayerWalkTo(1, -392.7, -21.3, -880.2, false);
        giWait(1.2);
        giFlashOutBlack(1.0, true, true);
        giIMMBegin();
        giPlayerSetPos(0, 544.5, -9.9, -1431.2);
        giPlayerSetAng(0, 16.0);
        giPlayerSetPos(1, 603.5, -18.9, -1336.9);
        giPlayerSetAng(1, 305.0);
        giIMMEnd();
        giPlayerDoAction(0, "C10", 0, false);
        giPlayerDoAction(1, "C11", 0, false);
        giCameraRunSingle("024", true);
        giFlashInBlack(2.0, false);
        giWait(0.8);
        giCameraRunSingle("025", false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……喂，如果下次再遇到危险，我让你先逃，你动作要快点哦，少婆婆妈妈的。", "40810");
        giSetPortrait("101J", true);
        giTalk("云天河：不行，我不能丢下女孩子！", "40811");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：可笑！打不过你留下来一样打不过，又没什么江湖经验，乖乖听我的才对。", "40812");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：这样，至少以后还有报仇的机会。", "40813");
        giSetPortrait("101J", true);
        giTalk("云天河：但是……就算报了仇，已经死的人也不会再活过来了吧？", "40814");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：当然呐，又不是僵尸。所以才说人命宝贵，何必多拖累一个人呢？", "40815");
        giSetPortrait("101J", true);
        giTalk("云天河：话是这么说没错，但是丢下你，我做不到就是做不到！", "40816");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：你？……", "40817");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：简直太傻了，世上怎么会有你这样的傻瓜……", "40818");
        giWait(3.0);
        giSetPortrait("101C", true);
        giTalk("云天河：菱纱？", "40819");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……", "40820");
        giSetPortrait("101C", true);
        giTalk("云天河：你睡了吗？", "40821");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：…………", "40822");
        giWait(0.5);
        giFlashOutBlack(2.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giIMMEnd();
        giSetObjectVisible("Jeffect001", false);
        giScriptMusicStop(1, 2.5);
        giArenaLoad("M03", "1", "", false);
        giSetObjectVisible("sound004", false);
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 507.7, -10.3, -1401.1);
        giPlayerSetAng(0, 196.0);
        giPlayerSetPos(1, 588.1, -17.8, -1338.0);
        giPlayerSetAng(1, 316.0);
        giSetObjectVisible("MO003", true);
        giSetObjectVisible("MO006", true);
        giSetObjectVisible("MO007", true);
        giSetObjectVisible("Jeffect002", true);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giIMMEnd();
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giArenaReady();
        giPlayerDoAction(0, "J08", -1, false);
        giPlayerDoAction(1, "C11", 0, false);
        giSetObjectVisible("Jeffect001", false);
        giFlashInBlack(1.5, true);
        giWait(1.2);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……唔……天亮了吗？……奇怪……又累又饿，以前不会这样的，我是不是生病了……", "40823");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……什么味道？烟？……", "40824");
        giWait(0.6);
        giCameraRunSingle("002", true);
        giWait(2.3);
        giPlayerDoAction(1, "C01", 0, false);
        giIMMBegin();
        giPlayerSetPos(1, 577.3, -17.8, -1349.9);
        giPlayerSetAng(1, 229.0);
        giIMMEnd();
        giSetPortrait("103A", false);
        giTalk("韩菱纱：我说，大清早的，你在干嘛？！ ", "40825");
        giCameraRunSingle("003", true);
        giWait(0.3);
        giSetPortrait("101B", true);
        giTalk("云天河：爹说过，早晚三柱香，我可不能忘了。", "40826");
        giSetPortrait("101B", true);
        giTalk("云天河：呵呵，老爹看到我这么听他的话，说不定就晚几天来找我算帐了，你瞧他昨晚就没来～", "40827");
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：……是啊，他老人家大概有别的事在忙，哈、哈哈。", "40828");
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 48.0, true);
        giSetPortrait("101K", true);
        giTalk("云天河：菱纱，我有好东西给你，你看——", "40829");
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.3);
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：呀——！！！！！这……黑黑的，这不是蜻蜓吗？！", "40830");
        giSetPortrait("101K", true);
        giTalk("云天河：原来这东西叫“青亭”，我以前都不知道名字。烤过以后味道还不错，你尝尝！", "40831");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：不要不要不要～拿开啦！", "40832");
        giCameraRunSingle("004", false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101B", true);
        giTalk("云天河：怎么了？", "40833");
        giPlayerDoAction(1, "J14", 1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你还问？看起来好恶心，怎么能吃？！", "40834");
        giSetPortrait("101B", true);
        giTalk("云天河：烤熟了，怎么不能吃？", "40835");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：跟你这野人说不清，反正一般人不可能吃那种东西的！", "40836");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：……明明你自己说过的，出门在外，能填饱肚子就行了，别挑三捡四……你不吃，我自己吃啰？不能浪费。", "40837");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：少废话，被你气都气饱了！", "40838");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：快点收拾东西，<colour red=255 green=187 blue=0 alpha=255>我们去寿阳城，</colour><dc0>立刻！马上！</dc0>", "40839");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerWalkTo(1, 303.3, -3.1, -1313.3, false);
        giWait(1.6);
        giPlayerSetDir(0, 292.0, true);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：哎，你等一等！我不能把我爹丢在——不，是不能把爹的牌位丢在这里啊！", "40840");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：哼，谁管你啊～～", "40841");
        giWait(0.5);
        giPlayerSetDir(0, 192.0, true);
        giPlayerDoAction(0, "J03", -1, true);
        giWait(0.5);
        giSetObjectVisible("Jeffect002", false);
        giSetObjectVisible("MO007", false);
        giWait(0.6);
        giSetObjectVisible("MO006", false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerRunTo(0, 334.8, -2.4, -1326.9, false);
        giWait(1.5);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("001", true);
        giPlayerEndMove(1);
        giPlayerEndMove(0);
        global_mvar = 21600; // 0x00005460, 第一章 / 2-1-4.初涉红尘 / 前去寿阳 / 露宿湖边
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giArenaSkillEnable(true);
        giPlayerSetLeader(0);
        giPlayerCurrentSetPos(285.1, -10.1, -1359.7);
        giPlayerCurrentSetAng(267.0);
        giPlayerCurrentSetVisible(true);
        giMonsterSetHide("m03-05-02", true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
    }
}

void func2004()
{
    if (global_mvar == 110200 /* 第二章 / 6-5-2.非愿 / 前往巢湖 / 月夜惜别 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, -1136.2, -51.7, -1772.4);
        giPlayerSetPos(1, -1135.6, -51.4, -1832.3);
        giPlayerSetPos(2, -1087.7, -52.6, -1948.4);
        giPlayerSetPos(3, -1155.2, -48.9, -1861.4);
        giPlayerSetAng(1, 76.0);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(3, true);
        giMonsterSetHide("m03-05-02", false);
        giSetObjectVisible("enttrance2", false);
        giSetObjectVisible("enttrance4", false);
        giIMMEnd();
        giCameraPrepare("MC004");
        giCameraRunSingle("002", false);
        giArenaReady();
        giNpcDoAction("MN002", "J01", -1, false);
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("MN001", true);
        giWait(1.0);
        giFlashInBlack(1.5, true);
        giTalk("渔民甲：醒醒！你醒醒啊！ ", "44119");
        giCameraWait();
        giWait(1.0);
        giPlayerWalkTo(1, -1039.3, -48.2, -1803.5, true);
        giPlayerSetAng(1, 75.0);
        giWait(0.3);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：这是……怎么一回事？", "44120");
        giNpcEndAction("MN002", true);
        giNpcSetDir("MN002", 259.0, true);
        giTalk("渔民甲：哇！仙女？！", "44121");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：什么仙女，你快告诉我们，这个人是不是溺水了？", "44122");
        giPlayerWalkTo(3, -1032.7, -51.2, -1852.8, false);
        giPlayerWalkTo(2, -1000.3, -53.3, -1867.2, false);
        giPlayerWalkTo(0, -1043.8, -45.9, -1770.3, false);
        giPlayerEndMove(3);
        giPlayerSetDir(3, 36.0, true);
        giTalk("渔民甲：他、他这不是溺水，是被湖里的水妖害了！", "44123");
        giSetPortrait("105C", true);
        giTalk("慕容紫英：水妖？现在何处？！", "44124");
        giNpcSetDir("MN002", 223.0, true);
        giTalk("渔民甲：这、我也不知道啊……", "44125");
        giIMMBegin();
        giPlayerSetPos(1, -1049.6, -49.0, -1812.4);
        giPlayerSetAng(1, 91.0);
        giPlayerSetAng(3, 64.0);
        giNpcSetPos("MN002", -948.5, -48.5, -1754.4);
        giNpcSetAng("MN002", 223.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giTalk("渔民甲：以前我们在湖里打渔，从来都是太太平平，这段日子却总有人失踪，没过几日就被发现昏倒在岸边……肯定是被水妖害的……", "44126");
        giPlayerEndMove(2);
        giPlayerEndMove(0);
        giIMMBegin();
        giPlayerSetDir(2, 44.0, false);
        giPlayerSetDir(0, 104.0, false);
        giIMMEnd();
        giWait(1.0);
        giPlayerDoAction(2, "J12", 1, true);
        giWait(0.5);
        giSetObjectVisible("Jeffect003", true);
        giWait(0.5);
        giNpcSetDir("MN002", 170.0, true);
        giWait(0.8);
        giTalk("渔民乙：唔……妖怪……", "44127");
        giTalk("渔民甲：他醒了！", "44128");
        giWait(0.7);
        giIMMBegin();
        giCameraRunSingle("005", false);
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN003", true);
        giNpcSetAng("MN002", 223.0);
        giIMMEnd();
        giSetObjectVisible("Jeffect003", false);
        giWait(0.6);
        giTalk("渔民甲：……你们、你们真的是仙人？！", "44129");
        giWait(0.5);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：请问，你可记得是如何遇见妖怪的？", "44130");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giWait(0.8);
        giTalk("渔民乙：我……我记不太清了……", "44131");
        giTalk("渔民乙：我把船划到百翎洲边上，就被大漩涡卷了进去……船没了……水下好像有很多长相吓人的妖怪……", "44132");
        giTalk("渔民乙：后来……后来我就醒了……", "44133");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(2, false);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：我只听过巢湖的百翎洲上住着奇怪的大鸟，倒不知这里的水下有妖怪……", "44134");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：难道……和那个遗迹有关？", "44135");
        giWait(0.5);
        giPlayerSetDir(3, 345.0, true);
        giWait(0.3);
        giPlayerEndAction(1);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：什么遗迹？", "44136");
        giPlayerSetDir(1, 163.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：……据说巢湖边曾有一个小国，因为触怒了神明，被罚整个国家都沉入湖底，不过那是很久以前、殷商时候的事，也不知真假……", "44137");
        giSetPortrait("104A", true);
        giTalk("韩菱纱：这一类的古迹，要是年月久了，风水生变，最容易成为精怪盘踞的地方……", "44138");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：不管真假，我们都要过去一探！若真有妖物盘踞在此，实为一大祸害！", "44139");
        giWait(0.5);
        giCameraRunSingle("007", true);
        giWait(0.5);
        giTalk("渔民甲：仙、仙人……你们是、是、是要去除妖？", "44140");
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(2, true);
        giPlayerSetAng(1, 76.0);
        giPlayerSetAng(3, 49.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：二位快些离开吧，此地不宜久留。", "44141");
        giTalk("渔民乙：是、是，多谢仙人救命之恩～", "44142");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：哎，等一下！", "44143");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("渔民甲：仙女还有什么吩咐？", "44144");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：你有没有船借来用用？<colour red=255 green=187 blue=0 alpha=255>我们想去巢湖的百翎洲附近看看，</colour><dc0>既然说水妖常害渔民，我倒是要瞧瞧水妖能拿我们怎么样？嘻～</dc0>", "44145");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("渔民甲：有，当然有！一条破船，我只怕配不上仙女！", "44146");
        giTalk("渔民甲：船就停在这岸边！ ", "44147");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：……要给你们多少钱？", "44148");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("渔民甲：不用不用，仙人要去除妖，我们老百姓感激都来不及了，怎么还能要钱？", "44149");
        giTalk("渔民乙：是啊！我们赶紧去告诉其他人这个好消息。", "44150");
        giWait(1.0);
        giNpcWalkTo("MN002", -937.9, -27.8, -1638.6, false);
        giWait(0.4);
        giNpcWalkTo("MN003", -937.9, -27.8, -1638.6, false);
        giWait(1.8);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：不要钱？……真不错～那等一下办完事，把船搬回去，说不定以后还有用。", "44151");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetPos(0, -1016.8, -46.5, -1767.8);
        giPlayerSetAng(0, 60.0);
        giPlayerSetPos(1, -1029.9, -49.0, -1812.2);
        giPlayerSetAng(1, 30.0);
        giPlayerSetPos(2, -955.3, -52.0, -1837.7);
        giPlayerSetAng(2, 318.0);
        giPlayerSetPos(3, -1005.8, -52.7, -1862.5);
        giPlayerSetAng(3, 351.0);
        giCameraRunSingle("009", false);
        giIMMEnd();
        giWait(0.3);
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("107C", true);
        giTalk("柳梦璃：嘻～云公子不会想御船而飞吧。", "44152");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 138.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "J16", -1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：对啊！我怎没想到，还是梦璃厉害，嗯……好像很好玩的样子！", "44153");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(2, "C09", 1, false);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：（……忍住，不要跟他说话，省得自己被气死……）", "44154");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……上船吧。", "44155");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：嗯。", "44156");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(1);
        global_mvar = 110400; // 0x0001AF40, 寻找漩涡
        giMonsterSetHide("m03-05-02", true);
        giArenaLoad("M03", "3", "", true);
        giSetObjectVisible("enttrance3", true);
        giSetObjectVisible("enttrance4", true);
        giEventVolumeVisible("ev_M03_1_13", true);
        giPlayerCurrentSetPos(-39.0, 0.0, 149.0);
        giPlayerCurrentSetAng(170.0);
        giCameraSetMode(5, true);
        giArenaReady();
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2005()
{
    if (global_mvar == 110400 /* 寻找漩涡 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giMonsterStopPursuit();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giHideGASkillObject();
        giMonsterSetHide("m03-01-01", false);
        giPlayerSetPos(0, 872.9, 38.4, -2010.4);
        giPlayerSetAng(0, 48.0);
        giPlayerSetPos(1, 896.4, 35.1, -1969.7);
        giPlayerSetAng(1, 68.0);
        giPlayerSetPos(2, 869.9, 39.5, -1893.7);
        giPlayerSetAng(2, 96.0);
        giPlayerSetPos(3, 795.4, 37.6, -1937.6);
        giPlayerSetAng(3, 86.0);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(3, true);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giCameraRunSingle("002", false);
        giFlashInBlack(1.5, true);
        giCameraWait();
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：那个人说的大漩涡，就是这里吧？", "44157");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("102A", true);
        giTalk("云天河：……我们就这样等着，妖怪会不会自己上来？", "44158");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：谁知道，总不能直接跳下去吧……", "44159");
        giPlayerEndAction(0);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：<colour red=255 green=187 blue=0 alpha=255>我们正是要潜入水中——</colour>", "44160");
        giIMMBegin();
        giPlayerSetAng(0, 335.0);
        giPlayerSetAng(1, 301.0);
        giPlayerSetAng(2, 229.0);
        giPlayerSetAng(3, 110.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.3);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", false);
        giTalk("韩菱纱：咦咦咦？！不是吧？", "44161");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：勿要慌张。我会传你们琼华派水息之术，在水中可保口鼻呼气如常。", "44162");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：哈哈，有这么好玩的东西？紫英你干嘛不早说！", "44163");
        giPlayerEndAction(0);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：事不宜迟，你们且听好——", "44164");
        giFlashOutBlack(2.0, true, true);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetAng(0, 26.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(1.0);
        giFlashInBlack(2.0, false);
        giWait(1.5);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：水息之术～听起来蛮简单的，我来试试！", "44165");
        giWait(0.3);
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(763.0, 39.0, -1961.7);
        giPlayerCurrentSetAng(81.0);
        giCameraSetCollide(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 110500; // 0x0001AFA4, 第二章 / 7-1-2.水中妖界 / 潜水寻妖
        giMonsterSetHide("m03-01-01", true);
        giSetObjectVisible("entrance01", true);
        giShowSignpost();
        giIMMEnd();
        giTimeScript(180.0, "func9001");
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2006()
{
    if (global_mvar == 110701 /* 第二章 / 7-2-2.相争难休 / 离开居巢国 / 水下居巢 */)
    {
        giPlayerLock();
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, -1046.2, -53.5, -1885.0);
        giPlayerSetAng(0, 320.0);
        giPlayerSetPos(1, -1057.2, -52.0, -1823.0);
        giPlayerSetAng(1, 254.0);
        giPlayerSetPos(2, -1099.3, -53.8, -1835.7);
        giPlayerSetAng(2, 73.0);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(0, true);
        giMonsterSetHide("m03-05-02", false);
        giSetObjectVisible("enttrance3", false);
        giIMMEnd();
        giCameraPrepare("MC005");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(0.5);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：那，我先回寿阳一趟了。", "44280");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：好，你多保重，替我和天河向柳府的人问好哦。", "44281");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：嗯，一定。", "44282");
        giCameraRunSingle("002", false);
        giWait(0.5);
        giPlayerSetDir(2, 129.0, false);
        giWait(1.5);
        giSetPortrait("102E", false);
        giTalk("云天河：……", "44283");
        giSetPortrait("107A", true);
        giTalk("柳梦璃：云公子……", "44284");
        giSetPortrait("102D", false);
        giTalk("云天河：啊？什么？", "44285");
        giWait(0.3);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：（云公子心神不定，一定是在担心紫英的事……）", "44286");
        giSetPortrait("107B", true);
        giTalk("柳梦璃：……云公子请多保重，梦璃先回寿阳了。", "44287");
        giCameraRunSingle("003", true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：保重……你、你也要保重，我很好，没事的。", "44288");
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.8);
        giPlayerWalkTo(2, -1172.8, -49.3, -1821.8, false);
        giWait(1.2);
        giPlayerOutTeam(2, true);
        giWait(2.5);
        giCameraRunSingle("004", false);
        giPlayerSetDir(1, 170.0, true);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：天河，我们也走吧！ ", "44289");
        giWait(0.3);
        giPlayerSetDir(0, 352.0, true);
        giWait(0.6);
        giSetPortrait("102E", true);
        giTalk("云天河：……", "44290");
        giSetPortrait("104C", false);
        giTalk("韩菱纱：……你怎么了？从刚才开始就闷闷不乐的，是不是……是不是还在想紫英的事？", "44291");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：……菱纱，你告诉我，刚才那样，就叫作“吵架”吗？", "44292");
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：……！", "44293");
        giCameraRunSingle("005", false);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102G", true);
        giTalk("云天河：我听说……吵过架的人……可能一辈子都不会再说话了……", "44294");
        giSetPortrait("102G", true);
        giTalk("云天河：可是，在我心里……还是把紫英当成朋友……虽然他想杀槐米它们，我很生气……", "44295");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：傻瓜……其实，我心里也很慌啊，等一下回了琼华派，万一见到紫英，我都不知该说什么话才好……", "44296");
        giSetPortrait("104E", false);
        giTalk("韩菱纱：我想……梦璃也不好受吧，可是她还挂心着附近百姓的安危，说不定回到柳府，她为了不让别人担心，又要强颜欢笑……", "44297");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("102G", true);
        giTalk("云天河：话是这么说没错，但是……", "44298");
        giSetPortrait("104A", false);
        giTalk("韩菱纱：至少，<colour red=255 green=187 blue=0 alpha=255>我们先回琼华派去，</colour><dc0>一直在这里难过，也没办法和紫英和好啊……</dc0>", "44299");
        giWait(0.8);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102G", true);
        giTalk("云天河：……你说的对，我们走吧。", "44300");
        giPlayerEndAction(0);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("001", true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-1221.2, -45.3, -1828.9);
        giPlayerCurrentSetAng(253.0);
        giCameraSetCollide(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giMonsterSetHide("m03-05-02", true);
        global_mvar = 120100; // 0x0001D524, 第二章 / 7-2-3.相争难休 / 送寒器回琼华
        giSetObjectVisible("enttrance3", true);
        giIMMEnd();
        giTimeScript(180.0, "func9001");
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func3001()
{
    if (var_shop025 == 0)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giFlashOutBlack(0.5, true, true);
        giSetFullHP();
        giSetFullMP();
        giPlayerCurrentSetVisible(false);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giSetObjectVisible("MO001", true);
        giWait(2.5);
        gi2DSoundPlay("WE137", 1);
        giNpcBlendIn("MN001", 2.5, false);
        giWait(3.5);
        giCameraRunSingle("003", true);
        giFlashOutBlack(0.1, true, true);
        giAddCombatMonster(2591, 4);
        giAddCombatMonster(2555, 0);
        giAddCombatMonster(2555, 2);
        giConfigCombatCamera("CA8");
        giConfigCombatGroundCamera("CA14");
        giConfigCombatParam(true, 0, 0, 1);
        giStartCombat("M03C");
        giSetNpcVisible("MN001", false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(140.3, -107.6, -1488.2);
        giPlayerCurrentSetAng(234.0);
        var_shop025 = 1;
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giCameraSetMode(5, true);
        giFlashInBlack(1.5, true);
    }
}

void func8001()
{
    bool flag_visible = false;
    int random_1_10 = 0;
    int local_4 = 0;
    int random_0_5 = 0;

    flag_visible = giGetVisibleObject("flag");
    random_1_10 = giGetRandnum(1, 10);
    if (giGetVisibleObject("flag") && random_1_10 <= 7)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giSetObjectVisible("flag", false);
        giSetObjectVisible("calMst", false);
        giSetObjectVisible("calMst", true);
        random_0_5 = giGetRandnum(0, 5);
        while (local_4 > 0)
        {
            giAddCombatMonster(2555, random_0_5);
            local_4 = local_4 - 1;
        }
        giStartCombat("M03C");
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
    }
}

void danger()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.3);
    giFlashOutBlack(1.5, true, true);
    giWait(0.5);
    giResetPlayerToJumpStart();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(1.5, false);
    giWait(0.15);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.3);
    giPlayerBlendIn(leader_player_id, 0.5, false);
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
