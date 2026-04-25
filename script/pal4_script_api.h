#ifndef PAL4_SCRIPT_API_H
#define PAL4_SCRIPT_API_H

// Generated for editor navigation/completion against reconstructed PAL4 scripts.
// Source of truth: spec/native_api_signatures.json and spec/native_api_semantics.json.
// This header is for tooling only; it is not part of the original game build.

#ifndef __cplusplus
typedef int bool;
#ifndef true
#define true 1
#endif
#ifndef false
#define false 0
#endif
#endif

typedef const char* string;

// Script global variables recovered from registration order.

// index=-1; addr=0x90DEC0; init=scriptInitializeGlobalVariables
extern int global_mvar;

// index=-2; addr=0x90DEEC; init=scriptInitializeVarShu
extern int var_shu;

// index=-3; addr=0x90DEF0; init=scriptInitializeVarXia
extern int var_xia;

// index=-4; addr=0x90DEF4; init=scriptInitializeVarWu
extern int var_wu;

// index=-5; addr=0x90DEF8; init=scriptInitializeVarFeng
extern int var_feng;

// index=-6; addr=0x90DEFC; init=scriptInitializeVarZi
extern int var_zi;

// index=-7; addr=0x90DF00; init=scriptInitializeVarMo
extern int var_mo;

// index=-8; addr=0x90DF04; init=scriptInitializeVarMing
extern int var_ming;

// index=-9; addr=0x90DF08; init=scriptInitializeVarYan
extern int var_yan;

// index=-10; addr=0x90DF0C; init=scriptInitializeVarCha
extern int var_cha;

// index=-11; addr=0x90DF10; init=scriptInitializeVarStar
extern int var_star;

// index=-12; addr=0x90DF14; init=scriptInitializeNpcA
extern int npc_a;

// index=-13; addr=0x90DF18; init=scriptInitializeNpcB
extern int npc_b;

// index=-14; addr=0x90DF1C; init=scriptInitializeNpcC
extern int npc_c;

// index=-15; addr=0x90DF20; init=scriptInitializeNpcVariables
extern int npc_d;

// index=-16; addr=0x90DF24; init=scriptInitializeNpcE
extern int npc_e;

// index=-17; addr=0x90DF28; init=scriptInitializeNpcF
extern int npc_f;

// index=-18; addr=0x90DF2C; init=scriptInitializeNpcG
extern int npc_g;

// index=-19; addr=0x90DF30; init=scriptInitializeVarZhu
extern int var_zhu;

// index=-20; addr=0x90DF34; init=scriptInitializeVarShop031
extern int var_shop031;

// index=-21; addr=0x90DF38; init=scriptInitializeVarShop010
extern int var_shop010;

// index=-22; addr=0x90DF3C; init=scriptInitializeVarShop032
extern int var_shop032;

// index=-23; addr=0x90DF40; init=scriptInitializeVarShop021
extern int var_shop021;

// index=-24; addr=0x90DF44; init=scriptRegisterIntVarShop012
extern int var_shop012;

// index=-25; addr=0x90DF48; init=scriptRegisterIntVarShop034
extern int var_shop034;

// index=-26; addr=0x90DF4C; init=scriptRegisterIntVarShop037
extern int var_shop037;

// index=-27; addr=0x90DF50; init=scriptRegisterIntVarShop004
extern int var_shop004;

// index=-28; addr=0x90DF54; init=scriptRegisterIntVarShop024
extern int var_shop024;

// index=-29; addr=0x90DF58; init=scriptRegisterIntVarShop025
extern int var_shop025;

// index=-30; addr=0x90DF5C; init=scriptRegisterIntVarShop005
extern int var_shop005;

// index=-31; addr=0x90DF60; init=scriptRegisterIntVarShop035
extern int var_shop035;

// index=-32; addr=0x90DF64; init=scriptRegisterIntVarShop026
extern int var_shop026;

// index=-33; addr=0x90DF68; init=scriptRegisterIntVarShop006
extern int var_shop006;

// index=-34; addr=0x90DF6C; init=scriptRegisterIntVarShop027
extern int var_shop027;

// index=-35; addr=0x90DF70; init=scriptRegisterIntVarShop007
extern int var_shop007;

// index=-36; addr=0x90DF74; init=scriptRegisterIntVarShop029
extern int var_shop029;

// index=-37; addr=0x90DF78; init=scriptRegisterIntVarShop009
extern int var_shop009;

// index=-38; addr=0x90DF7C; init=scriptRegisterIntVarShop030
extern int var_shop030;

// index=-39; addr=0x90DEC4; init=scriptInitializeMazeVariables
extern int maze_var1;

// index=-40; addr=0x90DEC8; init=scriptInitializeMazeVar2
extern int maze_var2;

// index=-41; addr=0x90DECC; init=scriptInitializeMazeVar3
extern int maze_var3;

// index=-42; addr=0x90DED0; init=scriptInitializeMazeVar4
extern int maze_var4;

// index=-43; addr=0x90DED4; init=scriptInitializeMazeVar5
extern int maze_var5;

// index=-44; addr=0x90DED8; init=scriptInitializeMazeVar6
extern int maze_var6;

// index=-45; addr=0x90DEDC; init=scriptInitializeMazeVar7
extern int maze_var7;

// index=-46; addr=0x90DEE0; init=scriptInitializeMazeVar8
extern int maze_var8;

// index=-47; addr=0x90DEE4; init=scriptInitializeMazeVar9
extern int maze_var9;

// index=-48; addr=0x90DEE8; init=scriptInitializeMazeVar10
extern int maze_var10;

// gi2DSoundPlay: 播放一个二维音效
// source: name+signature+auto-param-notes; confidence: high
// params: sound_name=音效资源名; value2=音效播放整型参数
int gi2DSoundPlay(string sound_name, int value2);

// gi2DSoundStop: 停止二维音效播放
// source: name+signature; confidence: high
void gi2DSoundStop(void);

// gi2DSoundStopID: 按实例 ID 停止二维音效
// source: name+signature+auto-param-notes; confidence: high
// params: value=音效实例编号
void gi2DSoundStopID(int value);

// giAddCombatMonster: 向当前战斗中加入怪物
// source: name+signature+auto-param-notes; confidence: high
// params: monster_id=怪物编号; value=战斗附加整型参数
void giAddCombatMonster(int monster_id, int value);

// giAddEquipment: 添加一件装备
// source: name+signature+auto-param-notes; confidence: medium
// params: equip_id=装备编号; flag2=是否显示提示
void giAddEquipment(int equip_id, bool flag2);

// giAddMoney: 增加金钱
// source: name+signature+auto-param-notes; confidence: high
// params: value=金钱变化值; flag2=是否显示提示
void giAddMoney(int value, bool flag2);

// giAddPlayerEquip: 给指定玩家添加装备
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号; equip_id=装备编号
void giAddPlayerEquip(int player_id, int equip_id);

// giAddPlayerFavor: 调整角色之间的好感度或亲密度
// source: name+signature+ida-callback:Player_SetArrayValue; confidence: high
// params: player_a=角色编号 A; player_b=角色编号 B; value3=好感度变化值
void giAddPlayerFavor(int player_a, int player_b, int value3);

// giAddPrescription: 添加一个配方或图谱
// source: name+signature+auto-param-notes; confidence: medium
// params: value=配方编号; flag2=是否显示提示
void giAddPrescription(int value, bool flag2);

// giAddProperty: 添加一项属性或物品条目
// source: name+signature+ida-callback:Game_ObtainItemAndShowHint; confidence: high
// params: property_id=物品或属性编号; delta_count=数量变化值; show_gain_hint=是否显示获得提示
void giAddProperty(int property_id, int delta_count, bool show_gain_hint);

// giAddQuestComplatePercentage: 增加任务完成度百分比
// source: name+signature+auto-param-notes; confidence: medium
// params: value=附加整型参数
void giAddQuestComplatePercentage(int value);

// giAddRoundTimes: 增加一个全局回合或计数器次数
// source: ida-callback:GlobalData_IncrementCounter40; confidence: medium
void giAddRoundTimes(void);

// giAllPlayerGarb1: 批量切换全队玩家的另一套外观或装束状态
// source: name+signature; confidence: medium
void giAllPlayerGarb1(void);

// giAllPlayerGarb2: 批量切换全队玩家的一套外观或装束状态
// source: ida-callback:Quest_InitializeScenePlayers; confidence: medium
void giAllPlayerGarb2(void);

// giAlwaysJump: 切换角色控制中的常驻跳跃状态
// source: ida-callback:ActorControl_SetState+auto-param-notes; confidence: medium
// params: enabled=是否启用持续跳跃
void giAlwaysJump(bool enabled);

// giArenaComeFromHere: 设置场景切换后的进入点来自当前位置
// source: name+signature+auto-param-notes; confidence: medium
// params: text=附加字符串参数1; text2=附加字符串参数2
int giArenaComeFromHere(string text, string text2);

// giArenaGetArea: 读取当前场景区域名
// source: name+signature; confidence: high
string giArenaGetArea(void);

// giArenaGetName: 读取当前场景名
// source: name+signature; confidence: high
string giArenaGetName(void);

// giArenaHint: 显示场景提示信息
// source: name+signature; confidence: medium
void giArenaHint(void);

// giArenaLoad: 加载或切换到指定场景与区域
// source: signature+script-usage; confidence: high
// params: module_name=地图或关卡包名; scene_name=场景名; area_name=子区域或入口名; immediate=是否立即切换
void giArenaLoad(string module_name, string scene_name, string area_name, bool immediate);

// giArenaMusicStop: 停止当前场景背景音乐
// source: name+signature+auto-param-notes; confidence: high
// params: value=附加浮点参数
void giArenaMusicStop(float value);

// giArenaReady: 让当前场景进入 ready 状态
// source: name+script-usage; confidence: high
void giArenaReady(void);

// giArenaReadyRestore: 恢复场景 ready 状态并回到正常场景流程
// source: ida-callback:Game_ConditionalMainLoopEntry; confidence: high
void giArenaReadyRestore(void);

// giArenaSkillEnable: 启用或关闭场景技能相关界面或功能
// source: ida-callback:UI_SetFrameFlag+auto-param-notes; confidence: medium
// params: enabled=是否启用场景技能
void giArenaSkillEnable(bool enabled);

// giBGMConfigIsInArea: 比较当前区域标识是否等于指定字符串
// source: signature+ida-callback:GameArena_CompareString; confidence: high
// params: area_name=区域标识字符串
bool giBGMConfigIsInArea(string area_name);

// giBGMConfigSetMusic: 写入背景音乐播放器的目标曲名
// source: signature+ida-callback:Music_SetBuffer+ida-callchain:SetBackgroundMusic; confidence: high
// params: music_name=背景音乐资源名
void giBGMConfigSetMusic(string music_name);

// giCameraAutoSeek: 启用或关闭相机自动跟随
// source: name+signature; confidence: high
// params: enabled=是否启用自动跟随
void giCameraAutoSeek(bool enabled);

// giCameraCtrlDist: 直接控制相机距离
// source: name+signature+ida-callback:Camera_AdjustScalarParameter+ida-call:Camera_UpdateMatrix; confidence: high
// params: distance=距离 D; keep_look_at=是否保持当前注视点（true=固定 look-at 反算相机位置；false=固定当前位置并重算注视点）
void giCameraCtrlDist(float distance, bool keep_look_at);

// giCameraCtrlYPR: 直接控制相机偏航、俯仰和翻滚
// source: name+signature+ida-callback:Camera_InitializeAndSetPosition+ida-call:Camera_UpdateMatrix; confidence: high
// params: yaw=偏航角 Y; pitch=俯仰角 P; roll=滚转角 R; keep_look_at=是否保持当前注视点（true=固定 look-at 反算相机位置；false=固定当前位置并重算注视点）
void giCameraCtrlYPR(float yaw, float pitch, float roll, bool keep_look_at);

// giCameraCtrlYPRD: 直接控制相机偏航、俯仰、翻滚和距离
// source: name+signature+ida-callback:Camera_AdjustRotationAndPosition+ida-call:Camera_UpdateMatrix; confidence: high
// params: yaw=偏航角 Y; pitch=俯仰角 P; roll=滚转角 R; distance=距离 D; keep_look_at=是否保持当前注视点（true=固定 look-at 反算相机位置；false=固定当前位置并重算注视点）
void giCameraCtrlYPRD(float yaw, float pitch, float roll, float distance, bool keep_look_at);

// giCameraGetDist: 读取当前相机距离
// source: name+signature; confidence: high
float giCameraGetDist(void);

// giCameraGetPitch: 读取当前相机俯仰角
// source: name+signature; confidence: high
float giCameraGetPitch(void);

// giCameraGetRoll: 读取当前相机翻滚角
// source: name+signature; confidence: high
float giCameraGetRoll(void);

// giCameraGetYaw: 读取当前相机偏航角
// source: name+signature; confidence: high
float giCameraGetYaw(void);

// giCameraPrepare: 准备一组镜头资源或镜头路径
// source: name+script-usage; confidence: high
// params: camera_path=镜头资源或路径名
int giCameraPrepare(string camera_path);

// giCameraRunCircle: 播放一段环绕镜头或循环镜头序列
// source: ida-callback:Camera_RunSequence+script-handler-wait-mode; confidence: high
// params: wait_until_done=是否等待镜头播放完成（true=阻塞脚本直到镜头结束；false=启动后立即继续）
int giCameraRunCircle(bool wait_until_done);

// giCameraRunSingle: 播放一段单镜头
// source: name+signature+ida-callback:Camera_RunSingleSequence+script-handler-wait-mode; confidence: high
// params: sequence_name=镜头序列名; wait_until_done=是否等待镜头播放完成（true=阻塞脚本直到镜头结束；false=启动后立即继续）
int giCameraRunSingle(string sequence_name, bool wait_until_done);

// giCameraSeekToPlayer: 让相机重新对准玩家
// source: name+script-usage; confidence: high
void giCameraSeekToPlayer(void);

// giCameraSetCollide: 启用或关闭相机碰撞
// source: name+signature; confidence: high
// params: enabled=是否启用相机碰撞
void giCameraSetCollide(bool enabled);

// giCameraSetDistOptEnable: 启用或关闭相机距离优化
// source: name+signature; confidence: high
// params: enabled=是否启用距离优化
void giCameraSetDistOptEnable(bool enabled);

// giCameraSetMode: 切换相机模式
// source: name+signature+ida-callback:Camera_SetupModeAndPlayerState+ida-call:palPlayerManager_SetPlayerState; confidence: high
// params: mode_index=相机模式编号; sync_player_state=是否同步玩家状态（true=把当前玩家状态设为 1，并在非自由相机模式下刷新相机 look-at；false=把当前玩家状态设为 0）
void giCameraSetMode(int mode_index, bool sync_player_state);

// giCameraWait: 等待当前镜头播放结束
// source: name+script-usage; confidence: high
void giCameraWait(void);

// giCGEffPlay: 播放一段 CG 特效
// source: name+signature+ida-callback:Effect_HandleScriptCallback; confidence: high
// params: cg_effect_id=CG 特效编号
void giCGEffPlay(int cg_effect_id);

// giCGEffStop: 停止当前 CG 特效
// source: name+signature; confidence: medium
void giCGEffStop(void);

// giCheckEquipInInventory: 检查背包中是否存在指定装备
// source: name+signature; confidence: high
// params: equip_id=装备编号
bool giCheckEquipInInventory(int equip_id);

// giCheckMagicMastered: 检查当前目标是否已完成仙术领悟
// source: signature+name; confidence: high
bool giCheckMagicMastered(void);

// giCheckPackProperty: 检查背包中是否存在指定物品或属性
// source: name+signature; confidence: medium
// params: property_id=物品或属性编号; required_count=需求数量
bool giCheckPackProperty(int property_id, int required_count);

// giClearUiTimer: 清除一个 UI 计时器
// source: name+signature; confidence: medium
void giClearUiTimer(void);

// giCloseWeather: 关闭当前天气效果
// source: name+signature; confidence: high
void giCloseWeather(void);

// giCommonDialogGetLastSelect: 读取通用对话框最后选中的项
// source: name+signature; confidence: high
int giCommonDialogGetLastSelect(void);

// giConfigCombatBgm: 配置战斗背景音乐
// source: name+signature; confidence: high
// params: music_name=战斗背景音乐资源名
void giConfigCombatBgm(string music_name);

// giConfigCombatCamera: 配置战斗镜头参数
// source: name+signature; confidence: high
// params: camera_config=战斗镜头配置名
void giConfigCombatCamera(string camera_config);

// giConfigCombatGroundCamera: 配置战斗地面镜头参数
// source: name+signature+auto-param-notes; confidence: medium
// params: text=战斗地面镜头配置名
void giConfigCombatGroundCamera(string text);

// giConfigCombatParam: 配置战斗参数
// source: name+signature+ida-callback:CombatSystem_SetProperties+auto-param-notes; confidence: high
// params: enabled=主开关布尔值; value2=战斗整型参数1; value3=战斗整型参数2; value4=战斗整型参数3
void giConfigCombatParam(bool enabled, int value2, int value3, int value4);

// giConfigCombatVipMonster: 配置战斗中的特殊或 VIP 怪物参数
// source: ida-callback:Combat_SetProperty+auto-param-notes; confidence: medium
// params: value=战斗首领怪配置值
void giConfigCombatVipMonster(int value);

// giCurrentPlayerEndMove: 结束当前玩家移动
// source: name+signature; confidence: high
void giCurrentPlayerEndMove(void);

// giCurrentPlayerFaceToNpc: 让当前玩家朝向指定 NPC
// source: ida-callback:CurrentPlayer_FaceToNpc+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giCurrentPlayerFaceToNpc(string npc_id, bool wait_until_done);

// giDelProperty: 删除一项属性或物品条目
// source: name+signature+ida-callback:Game_RemoveItemAndShowHint; confidence: high
// params: property_id=物品或属性编号; delta_count=数量变化值; show_loss_hint=是否显示失去提示
void giDelProperty(int property_id, int delta_count, bool show_loss_hint);

// giEffectAttachToCurrentPlayer: 将特效附着到当前玩家
// source: name+signature+auto-param-notes; confidence: high
// params: effect_name=特效资源名; flag=附加布尔控制标志
void giEffectAttachToCurrentPlayer(string effect_name, bool flag);

// giEffectAttachToNpc: 将特效附着到指定 NPC 身上
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号; effect_name=特效资源名; flag=附加布尔控制标志
void giEffectAttachToNpc(string npc_id, string effect_name, bool flag);

// giEffectAttachToPlayer: 将特效附着到指定玩家身上
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号; effect_name=特效资源名; flag=附加布尔控制标志
void giEffectAttachToPlayer(int player_id, string effect_name, bool flag);

// giEffectDetachFromCurrentPlayer: 将特效从当前玩家解除附着
// source: name+signature; confidence: high
void giEffectDetachFromCurrentPlayer(void);

// giEffectDetachFromNpc: 将特效从指定 NPC 身上解除附着
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号
void giEffectDetachFromNpc(string npc_id);

// giEffectDetachFromPlayer: 将特效从指定玩家身上解除附着
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号
void giEffectDetachFromPlayer(int player_id);

// giEffectPlay: 播放一个特效
// source: name+signature+auto-param-notes; confidence: high
// params: effect_name=特效资源名; effect_arg=特效附加整型参数; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标
void giEffectPlay(string effect_name, int effect_arg, float target_x, float target_y, float target_z);

// giEffectPlayWithCurrentPlayer: 在当前玩家身上播放特效
// source: name+signature+script-usage+auto-param-notes; confidence: high
// params: effect_name=特效资源名; effect_arg=特效附加整型参数
void giEffectPlayWithCurrentPlayer(string effect_name, int effect_arg);

// giEffectPlayWithNPC: 在指定 NPC 身上播放特效
// source: name+signature+auto-param-notes; confidence: high
// params: effect_name=特效资源名; effect_arg=特效附加整型参数; npc_id=NPC 名称或编号
void giEffectPlayWithNPC(string effect_name, int effect_arg, string npc_id);

// giEffectPlayWithOBJ: 在指定场景对象上播放特效
// source: name+signature+auto-param-notes; confidence: high
// params: effect_name=特效资源名; effect_arg=特效附加整型参数; gob_name=游戏对象名
void giEffectPlayWithOBJ(string effect_name, int effect_arg, string gob_name);

// giEffectPlayWithPlayer: 在指定玩家身上播放特效
// source: name+signature+auto-param-notes; confidence: high
// params: effect_name=特效资源名; effect_arg=特效附加整型参数; player_id=玩家编号
void giEffectPlayWithPlayer(string effect_name, int effect_arg, int player_id);

// giEffectStopWithOBJ: 停止指定场景对象上的特效
// source: name+signature+auto-param-notes; confidence: high
// params: text=附加字符串参数
void giEffectStopWithOBJ(string text);

// giEnableShadow: 启用或关闭阴影效果
// source: name+signature+auto-param-notes; confidence: high
// params: enabled=是否启用阴影
void giEnableShadow(bool enabled);

// giEnableSTS: 启用或关闭 STS 相关系统
// source: name+signature+auto-param-notes; confidence: medium
// params: value=系统状态值
void giEnableSTS(int value);

// giEventVolumeVisible: 启用或禁用指定事件触发体
// source: ida-callback:Object_ToggleScript; confidence: high
// params: event_volume_name=事件触发体名; enabled=是否启用
void giEventVolumeVisible(string event_volume_name, bool enabled);

// giFlashInBlack: 执行黑场淡入
// source: name+signature+ida-callback:Effect_FlashInBlack+script-handler-wait-mode; confidence: high
// params: duration=持续时长; wait_until_done=是否等待淡入完成（true=阻塞脚本直到黑场淡入结束；false=启动淡入后立即继续）
void giFlashInBlack(float duration, bool wait_until_done);

// giFlashInRed: 执行红场淡入效果
// source: ida-callback:Effect_FlashInRed+ida-call:PalScreenEffect_StartFade+script-handler-wait-mode; confidence: high
// params: duration=持续时长; reserved_flag=保留布尔参数（当前 callback 未消费；true/false 在现有 exe 中无可见差异）; wait_until_done=是否等待淡入完成（true=阻塞脚本直到红场淡入结束；false=启动淡入后立即继续）
void giFlashInRed(float duration, bool reserved_flag, bool wait_until_done);

// giFlashInWhite: 执行白场淡入
// source: name+signature+ida-callback:Effect_FlashInWhite+script-handler-wait-mode; confidence: high
// params: duration=持续时长; wait_until_done=是否等待淡入完成（true=阻塞脚本直到白场淡入结束；false=启动淡入后立即继续）
void giFlashInWhite(float duration, bool wait_until_done);

// giFlashOutBlack: 执行黑场淡出
// source: name+signature+ida-callback:Effect_FlashOutBlack+ida-call:PalScreenEffect_StartFade+script-handler-wait-mode; confidence: high
// params: duration=持续时长; hold_black_screen=是否在淡出结束后保持黑场覆盖（true=保持纯黑遮罩；false=淡出结束后立即结束该遮罩效果）; wait_until_done=是否等待淡出完成（true=阻塞脚本直到黑场淡出结束；false=启动淡出后立即继续）
void giFlashOutBlack(float duration, bool hold_black_screen, bool wait_until_done);

// giFlashOutRed: 执行红场淡出效果
// source: ida-callback:Effect_FlashOutRed+ida-call:PalScreenEffect_StartFade+script-handler-wait-mode; confidence: high
// params: duration=持续时长; hold_red_screen=是否在淡出结束后保持红场覆盖（true=保持纯红遮罩；false=淡出结束后立即结束该遮罩效果）; wait_until_done=是否等待淡出完成（true=阻塞脚本直到红场淡出结束；false=启动淡出后立即继续）
void giFlashOutRed(float duration, bool hold_red_screen, bool wait_until_done);

// giFlashOutWhite: 执行白场淡出
// source: name+signature+ida-callback:Effect_FlashOutWhite+ida-call:PalScreenEffect_StartFade+script-handler-wait-mode; confidence: high
// params: duration=持续时长; hold_white_screen=是否在淡出结束后保持白场覆盖（true=保持纯白遮罩；false=淡出结束后立即结束该遮罩效果）; wait_until_done=是否等待淡出完成（true=阻塞脚本直到白场淡出结束；false=启动淡出后立即继续）
void giFlashOutWhite(float duration, bool hold_white_screen, bool wait_until_done);

// giFlushTailYAngle: 刷新镜头尾部 Y 角并更新相机位置
// source: ida-callback:UpdateCameraPosition; confidence: high
void giFlushTailYAngle(void);

// giGameObjectSetResearch: 设置物件是否可调查或可交互
// source: ida-callback:Dialog_CreateAndSetProperty+auto-param-notes; confidence: medium
// params: gob_name=游戏对象名; flag2=是否可调查或交互
void giGameObjectSetResearch(string gob_name, bool flag2);

// giGetGoodsOpenCondition: 读取商品或商店开放条件
// source: name+signature+auto-param-notes; confidence: medium
// params: value=商品编号
int giGetGoodsOpenCondition(int value);

// giGetInnDialogResult: 读取住宿或客栈对话框结果
// source: name+signature; confidence: medium
int giGetInnDialogResult(void);

// giGetMoney: 读取当前金钱数量
// source: name+signature; confidence: high
int giGetMoney(void);

// giGetPalTestResult: 读取一个全局测试或调试结果值
// source: ida-callback:GlobalData_Get+auto-param-notes; confidence: medium
// params: value=测试项编号
int giGetPalTestResult(int value);

// giGetPlayerLevel: 读取玩家等级
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号
int giGetPlayerLevel(int player_id);

// giGetPropertyNumb: 读取某项属性或物品数量
// source: name+signature; confidence: medium
// params: property_id=物品或属性编号
int giGetPropertyNumb(int property_id);

// giGetPuzzleGameResult: 读取解谜小游戏结果
// source: name+signature; confidence: high
int giGetPuzzleGameResult(void);

// giGetQuestDialogResult: 读取任务对话框结果
// source: name+signature; confidence: high
int giGetQuestDialogResult(void);

// giGetRandnum: 获取一个随机数
// source: name+signature; confidence: high
// params: min_value=最小值; max_value=最大值
int giGetRandnum(int min_value, int max_value);

// giGetVisibleMonster: 查询指定怪物当前是否可见
// source: name+signature+auto-param-notes; confidence: high
// params: text=怪物名称或编号
bool giGetVisibleMonster(string text);

// giGetVisibleObject: 查询指定场景对象当前是否可见
// source: name+signature; confidence: high
// params: object_name=场景对象名
bool giGetVisibleObject(string object_name);

// giGOBAttachToCurrentPlayer: 将游戏对象附着到当前玩家
// source: name+signature+auto-param-notes; confidence: medium
// params: gob_name=游戏对象名; text2=挂点或附着点名; flag=附加布尔控制标志
void giGOBAttachToCurrentPlayer(string gob_name, string text2, bool flag);

// giGOBAttachToNpc: 将游戏对象附着到指定 NPC
// source: name+signature+auto-param-notes; confidence: medium
// params: gob_name=游戏对象名; text2=挂点或附着点名; npc_id=NPC 名称或编号; flag=附加布尔控制标志
void giGOBAttachToNpc(string gob_name, string text2, string npc_id, bool flag);

// giGOBAttachToPlayer: 将游戏对象附着到指定玩家
// source: name+signature+auto-param-notes; confidence: medium
// params: gob_name=游戏对象名; text2=挂点或附着点名; player_id=玩家编号; flag=附加布尔控制标志
void giGOBAttachToPlayer(string gob_name, string text2, int player_id, bool flag);

// giGOBDetachFromCurrentPlayer: 将游戏对象从当前玩家解除附着
// source: name+signature; confidence: medium
void giGOBDetachFromCurrentPlayer(void);

// giGOBDetachFromNPC: 将游戏对象从指定 NPC 身上解除附着
// source: name+signature+auto-param-notes; confidence: medium
// params: npc_id=NPC 名称或编号
void giGOBDetachFromNPC(string npc_id);

// giGOBDetachFromPlayer: 将游戏对象从指定玩家身上解除附着
// source: name+signature+auto-param-notes; confidence: medium
// params: player_id=玩家编号
void giGOBDetachFromPlayer(int player_id);

// giGOBMovment: 让指定游戏对象执行一段移动或位移动画
// source: signature+name+ida-callback:Dialog_Create_4+auto-param-notes; confidence: high
// params: gob_name=游戏对象名; value2=移动时长; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; flag=附加布尔控制标志
void giGOBMovment(string gob_name, float value2, float target_x, float target_y, float target_z, bool flag);

// giGOBReset: 重置指定游戏对象状态
// source: name+signature+auto-param-notes; confidence: medium
// params: gob_name=游戏对象名
void giGOBReset(string gob_name);

// giGOBScale: 调整指定游戏对象的缩放
// source: name+signature+auto-param-notes; confidence: high
// params: gob_name=游戏对象名; value2=缩放浮点参数1; value3=缩放浮点参数2; flag=附加布尔控制标志
void giGOBScale(string gob_name, float value2, float value3, bool flag);

// giGOBSetPosition: 设置游戏对象位置
// source: name+signature+auto-param-notes; confidence: medium
// params: gob_name=游戏对象名; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标
void giGOBSetPosition(string gob_name, float target_x, float target_y, float target_z);

// giGOMTouch: 触发与指定游戏对象的接触或交互对话
// source: ida-callback:Dialog_CreateForPlayer+script-usage; confidence: high
// params: gob_name=游戏对象名
void giGOMTouch(string gob_name);

// giGotoLogo: 切换回 Logo 或标题界面
// source: name+signature; confidence: high
void giGotoLogo(void);

// giGotoLogoWait: 切换到 Logo 界面并等待完成
// source: name+signature; confidence: medium
void giGotoLogoWait(void);

// giGrantMagicSystem: 解锁或授予仙术系统功能
// source: name+signature+auto-param-notes; confidence: medium
// params: flag=系统开关标志1; flag2=系统开关标志2
void giGrantMagicSystem(bool flag, bool flag2);

// giGrantSmithSystem: 解锁或授予锻造系统功能
// source: name+signature+auto-param-notes; confidence: medium
// params: flag=系统开关标志1; flag2=系统开关标志2; flag3=系统开关标志3; flag4=系统开关标志4
void giGrantSmithSystem(bool flag, bool flag2, bool flag3, bool flag4);

// giGrantSystemUi: 解锁或授予某个系统界面功能
// source: name+signature+auto-param-notes; confidence: medium
// params: value=系统界面编号; enabled=是否启用或解锁
void giGrantSystemUi(int value, bool enabled);

// giHideGASkillObject: 隐藏技能相关对象
// source: name+signature; confidence: medium
void giHideGASkillObject(void);

// giIMMBegin: 开始一组即时场景修改
// source: name+script-usage; confidence: high
void giIMMBegin(void);

// giIMMEnd: 结束一组即时场景修改
// source: name+script-usage; confidence: high
void giIMMEnd(void);

// giIsNightTime: 判断当前区域标识是否为夜景标识 "Y"
// source: signature+ida-callback:GameArena_IsY; confidence: medium
bool giIsNightTime(void);

// giLINGSHALegsHealing: 恢复菱纱腿部正常材质或外观状态
// source: ida-callback:Player_ApplyMaterialTexture2; confidence: medium
void giLINGSHALegsHealing(void);

// giLINGSHALegsInjured: 切换菱纱腿部受伤材质或外观状态
// source: ida-callback:Player_SetMaterialTexture2+auto-param-notes; confidence: medium
// params: npc_id=NPC 名称或编号
void giLINGSHALegsInjured(string npc_id);

// giMonsterSetHide: 设置怪物隐藏状态
// source: name+signature; confidence: high
// params: text=怪物名称或编号; hidden=是否隐藏
void giMonsterSetHide(string text, bool hidden);

// giMonsterSetVisible: 设置怪物是否可见
// source: name+signature+auto-param-notes; confidence: high
// params: text=怪物名称或编号; visible=是否可见
void giMonsterSetVisible(string text, bool visible);

// giMonsterStopPursuit: 停止怪物当前的追击行为
// source: name+signature; confidence: high
void giMonsterStopPursuit(void);

// giMstAttachEffect: 将特效附着到 MST 对象
// source: name+signature+auto-param-notes; confidence: medium
// params: text=怪物名称或编号; effect_name=特效资源名; effect_arg=特效附加整型参数
void giMstAttachEffect(string text, string effect_name, int effect_arg);

// giMSTBlendIn: 让指定对象执行 MST 淡入效果
// source: name+signature+auto-param-notes; confidence: medium
// params: text=怪物名称或编号; value2=淡入时长; flag=附加布尔控制标志
void giMSTBlendIn(string text, float value2, bool flag);

// giMSTBlendOut: 让指定对象执行 MST 淡出效果
// source: name+signature+auto-param-notes; confidence: medium
// params: text=怪物名称或编号; value2=渐隐时长; flag=附加布尔控制标志
void giMSTBlendOut(string text, float value2, bool flag);

// giMstDetachEffect: 将特效从 MST 对象解除附着
// source: name+signature+auto-param-notes; confidence: medium
// params: text=怪物名称或编号
void giMstDetachEffect(string text);

// giNewGame: 开始新游戏流程
// source: name+signature; confidence: high
void giNewGame(void);

// giNpcAttachEffect: 将特效附着到指定 NPC
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号; effect_name=特效资源名; effect_arg=特效附加整型参数
void giNpcAttachEffect(string npc_id, string effect_name, int effect_arg);

// giNpcBackTo: 让指定 NPC 返回到指定位置
// source: ida-callback:Npc_BackTo+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; wait_until_done=是否等待移动完成（true=阻塞脚本直到返回动作结束；false=发起返回后立即继续）
void giNpcBackTo(string npc_id, float target_x, float target_y, float target_z, bool wait_until_done);

// giNpcBlendIn: 让指定 NPC 执行淡入或显现效果
// source: name+signature+ida-callback:Npc_BlendIn+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; duration=淡入时长; wait_until_done=是否等待淡入完成（true=阻塞脚本直到显现结束；false=启动淡入后立即继续）
void giNpcBlendIn(string npc_id, float duration, bool wait_until_done);

// giNpcBlendOut: 让指定 NPC 执行淡出或渐隐效果
// source: name+signature+ida-callback:Npc_BlendOut+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; duration=渐隐时长; wait_until_done=是否等待淡出完成（true=阻塞脚本直到渐隐结束；false=启动渐隐后立即继续）
void giNpcBlendOut(string npc_id, float duration, bool wait_until_done);

// giNpcCreate: 创建一个 NPC
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号; text2=NPC 模板或资源名; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标
void giNpcCreate(string npc_id, string text2, float target_x, float target_y, float target_z);

// giNpcDelete: 删除一个 NPC
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号
void giNpcDelete(string npc_id);

// giNpcDetachEffect: 将特效从指定 NPC 解除附着
// source: name+signature+auto-param-notes; confidence: high
// params: text=附加字符串参数
void giNpcDetachEffect(string text);

// giNpcDoAction: 让指定 NPC 执行动作
// source: name+signature+ida-callback:Npc_ActionHandler+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; action_name=动作名; action_arg=动作附加整型参数; wait_until_done=是否等待动作完成（true=阻塞脚本直到动作结束；false=启动后立即继续）
void giNpcDoAction(string npc_id, string action_name, int action_arg, bool wait_until_done);

// giNpcDoActionRepeat: 让指定 NPC 重复执行某个动作
// source: name+signature+ida-callback:Npc_ActionHandler_Repeat; confidence: high
// params: npc_id=NPC 名称或编号; action_name=动作名
void giNpcDoActionRepeat(string npc_id, string action_name);

// giNpcEndAction: 结束指定 NPC 的当前动作
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号; flag=附加布尔控制标志
void giNpcEndAction(string npc_id, bool flag);

// giNpcEndActionRepeat: 结束指定 NPC 的重复动作
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号
void giNpcEndActionRepeat(string npc_id);

// giNpcEndMove: 结束指定 NPC 的当前移动
// source: name+signature; confidence: high
// params: npc_id=NPC 名称或编号
void giNpcEndMove(string npc_id);

// giNpcFaceToCurrentPlayer: 让指定 NPC 朝向当前玩家
// source: ida-callback:Npc_FaceToCurrentPlayer+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giNpcFaceToCurrentPlayer(string npc_id, bool wait_until_done);

// giNpcFaceToNpc: 让一个 NPC 朝向另一个 NPC
// source: name+signature+ida-callback:Npc_FaceToNpc+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; target_npc_id=目标 NPC 名称或编号; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giNpcFaceToNpc(string npc_id, string target_npc_id, bool wait_until_done);

// giNpcFaceToPlayer: 让指定 NPC 朝向指定玩家
// source: name+signature+ida-callback:Npc_FaceToPlayer+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; player_id=玩家编号; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giNpcFaceToPlayer(string npc_id, int player_id, bool wait_until_done);

// giNPCFlyTo: 让指定 NPC 飞向目标位置
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; flag=附加布尔控制标志
void giNPCFlyTo(string npc_id, float target_x, float target_y, float target_z, bool flag);

// giNpcPauseBeh: 暂停指定 NPC 的行为逻辑
// source: name+signature; confidence: high
// params: npc_id=NPC 名称或编号
void giNpcPauseBeh(string npc_id);

// giNpcResetDir: 重置指定 NPC 朝向到默认状态
// source: name+signature; confidence: medium
// params: npc_id=NPC 名称或编号
void giNpcResetDir(string npc_id);

// giNpcResetEmotion: 重置指定 NPC 的表情状态
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号
void giNpcResetEmotion(string npc_id);

// giNpcResumeBeh: 恢复指定 NPC 的行为逻辑
// source: name+signature; confidence: high
// params: npc_id=NPC 名称或编号
void giNpcResumeBeh(string npc_id);

// giNpcRunTo: 让指定 NPC 跑向指定位置
// source: name+signature+ida-callback:Npc_RunTo+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; wait_until_done=是否等待移动完成（true=阻塞脚本直到跑动结束；false=发起跑动后立即继续）
void giNpcRunTo(string npc_id, float target_x, float target_y, float target_z, bool wait_until_done);

// giNpcSetAng: 设置指定 NPC 朝向角度
// source: name+signature; confidence: high
// params: npc_id=NPC 名称或编号; angle=朝向角度
void giNpcSetAng(string npc_id, float angle);

// giNpcSetDir: 让指定 NPC 转向指定方向
// source: name+signature+ida-callback:Npc_TurnToDirection+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; direction=方向角度; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giNpcSetDir(string npc_id, float direction, bool wait_until_done);

// giNpcSetEmotion: 设置指定 NPC 的表情状态
// source: name+signature; confidence: high
// params: npc_id=NPC 名称或编号; emotion_name=表情状态名
void giNpcSetEmotion(string npc_id, string emotion_name);

// giNpcSetPos: 设置指定 NPC 位置
// source: name+signature; confidence: high
// params: npc_id=NPC 名称或编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标
void giNpcSetPos(string npc_id, float target_x, float target_y, float target_z);

// giNpcSetRot: 设置指定 NPC 旋转角度
// source: name+signature+auto-param-notes; confidence: high
// params: npc_id=NPC 名称或编号; text2=旋转配置名
void giNpcSetRot(string npc_id, string text2);

// giNpcUnHoldAct: 清除指定 NPC 当前保持或挂起的动作效果
// source: name+signature; confidence: high
// params: npc_id=NPC 名称或编号
void giNpcUnHoldAct(string npc_id);

// giNpcWalkTo: 让指定 NPC 步行到指定位置
// source: name+signature+ida-callback:Npc_WalkTo+script-handler-wait-mode; confidence: high
// params: npc_id=NPC 名称或编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; wait_until_done=是否等待移动完成（true=阻塞脚本直到步行结束；false=发起步行后立即继续）
void giNpcWalkTo(string npc_id, float target_x, float target_y, float target_z, bool wait_until_done);

// giOBJBlendIn: 让指定场景对象执行淡入或显现效果
// source: name+signature+auto-param-notes; confidence: high
// params: object_name=场景对象名; value2=淡入时长; flag=附加布尔控制标志
void giOBJBlendIn(string object_name, float value2, bool flag);

// giOBJBlendOut: 让指定场景对象执行淡出或渐隐效果
// source: name+signature+auto-param-notes; confidence: high
// params: object_name=场景对象名; value2=渐隐时长; flag=附加布尔控制标志
void giOBJBlendOut(string object_name, float value2, bool flag);

// giObjectDoAction: 让指定对象执行一个动作
// source: name+signature+auto-param-notes; confidence: medium
// params: object_name=场景对象名; action_name=动作名; action_arg=动作附加整型参数; flag=附加布尔控制标志
void giObjectDoAction(string object_name, string action_name, int action_arg, bool flag);

// giOpenMovieFlag: 设置过场动画相关标志位
// source: signature+name; confidence: high
// params: movie_flag=过场动画标志值
void giOpenMovieFlag(int movie_flag);

// giOpenSystemUi: 打开某个系统界面
// source: name+signature+auto-param-notes; confidence: high
// params: value=系统界面编号
void giOpenSystemUi(int value);

// giOpenWeather: 开启指定天气效果
// source: name+signature+auto-param-notes; confidence: high
// params: value=天气状态编号
void giOpenWeather(int value);

// giPauseUiTimer: 暂停或移除当前 UI 计时器
// source: ida-callback:UI_RemoveTimerFrame; confidence: high
void giPauseUiTimer(void);

// giPayMoney: 扣除金钱
// source: name+signature+auto-param-notes; confidence: high
// params: value=金钱变化值; flag2=是否显示提示
void giPayMoney(int value, bool flag2);

// giPetShow: 显示宠物或召唤物
// source: name+signature+auto-param-notes; confidence: medium
// params: flag=是否显示宠物
void giPetShow(bool flag);

// giPlayerAddSkill: 给指定玩家添加技能
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号; value2=技能编号; flag=附加布尔控制标志
void giPlayerAddSkill(int player_id, int value2, bool flag);

// giPlayerAttachCollision: 为指定玩家附加碰撞体
// source: name+signature+auto-param-notes; confidence: medium
// params: player_id=玩家编号
void giPlayerAttachCollision(int player_id);

// giPlayerBackTo: 让指定玩家返回到指定位置
// source: ida-callback:Player_BackTo+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; wait_until_done=是否等待移动完成（true=阻塞脚本直到返回动作结束；false=发起返回后立即继续）
void giPlayerBackTo(int player_id, float target_x, float target_y, float target_z, bool wait_until_done);

// giPlayerBlendIn: 让指定玩家执行淡入或显现效果
// source: name+signature+ida-callback:Player_BlendIn+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; duration=淡入时长; wait_until_done=是否等待淡入完成（true=阻塞脚本直到显现结束；false=启动淡入后立即继续）
void giPlayerBlendIn(int player_id, float duration, bool wait_until_done);

// giPlayerBlendOut: 让指定玩家执行淡出或渐隐效果
// source: name+signature+ida-callback:Player_BlendOut+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; duration=渐隐时长; wait_until_done=是否等待淡出完成（true=阻塞脚本直到渐隐结束；false=启动渐隐后立即继续）
void giPlayerBlendOut(int player_id, float duration, bool wait_until_done);

// giPlayerCurrentDoAction: 让当前玩家执行一个动作
// source: name+signature+ida-callback:PlayerAction_Handler+script-handler-wait-mode; confidence: high
// params: action_name=动作名; action_arg=动作附加整型参数; wait_until_done=是否等待动作完成（true=阻塞脚本直到动作结束；false=启动后立即继续）
void giPlayerCurrentDoAction(string action_name, int action_arg, bool wait_until_done);

// giPlayerCurrentEndAction: 结束当前玩家动作
// source: name+signature; confidence: high
void giPlayerCurrentEndAction(void);

// giPlayerCurrentFaceToGOB: 让当前玩家朝向指定游戏对象
// source: name+signature+ida-callback:CurrentPlayer_FaceToGOB+script-handler-wait-mode; confidence: medium
// params: gob_name=游戏对象名; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giPlayerCurrentFaceToGOB(string gob_name, bool wait_until_done);

// giPlayerCurrentGetPosX: 读取当前玩家 X 坐标
// source: name+signature; confidence: high
float giPlayerCurrentGetPosX(void);

// giPlayerCurrentGetPosY: 读取当前玩家 Y 坐标
// source: name+signature; confidence: high
float giPlayerCurrentGetPosY(void);

// giPlayerCurrentGetPosZ: 读取当前玩家 Z 坐标
// source: name+signature; confidence: high
float giPlayerCurrentGetPosZ(void);

// giPlayerCurrentMovment: 让当前玩家执行一段移动
// source: name+signature+ida-callback:CurrentPlayer_Movement+script-handler-wait-mode; confidence: medium
// params: duration=移动时长; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; wait_until_done=是否等待移动完成（true=阻塞脚本直到移动结束；false=发起移动后立即继续）
void giPlayerCurrentMovment(float duration, float target_x, float target_y, float target_z, bool wait_until_done);

// giPlayerCurrentRandomPosition: 在给定范围内为当前玩家寻找随机位置并移动过去
// source: ida-callback:Player_MoveToWithCollision+auto-param-notes; confidence: medium
// params: value=随机浮点参数1; value2=随机浮点参数2
void giPlayerCurrentRandomPosition(float value, float value2);

// giPlayerCurrentResetEmotion: 重置当前玩家表情状态
// source: name+signature; confidence: high
void giPlayerCurrentResetEmotion(void);

// giPlayerCurrentSetAng: 设置当前玩家朝向
// source: name+signature; confidence: high
// params: angle=朝向角度
void giPlayerCurrentSetAng(float angle);

// giPlayerCurrentSetEmotion: 设置当前玩家表情状态
// source: name+signature+auto-param-notes; confidence: high
// params: text=附加字符串参数
void giPlayerCurrentSetEmotion(string text);

// giPlayerCurrentSetPos: 设置当前玩家位置
// source: name+signature; confidence: high
// params: target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标
void giPlayerCurrentSetPos(float target_x, float target_y, float target_z);

// giPlayerCurrentSetVisible: 设置当前玩家是否可见
// source: name+signature; confidence: high
// params: visible=是否可见
void giPlayerCurrentSetVisible(bool visible);

// giPlayerCurrentWalkTo: 让当前玩家步行到指定位置
// source: name+signature+ida-callback:Player_CurrentPlayerWalkTo+script-handler-wait-mode; confidence: high
// params: target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; wait_until_done=是否等待移动完成（true=阻塞脚本直到步行结束；false=发起步行后立即继续）
void giPlayerCurrentWalkTo(float target_x, float target_y, float target_z, bool wait_until_done);

// giPlayerDetachCollision: 移除指定玩家的碰撞体
// source: name+signature+auto-param-notes; confidence: medium
// params: player_id=玩家编号
void giPlayerDetachCollision(int player_id);

// giPlayerDetachEffect: 将特效从指定玩家解除附着
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号
void giPlayerDetachEffect(int player_id);

// giPlayerDoAction: 让指定玩家执行一个动作
// source: name+signature+ida-callback:ProxyClass_Vtable40+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; action_name=动作名; action_arg=动作附加整型参数; wait_until_done=是否等待动作完成（true=阻塞脚本直到动作结束；false=启动后立即继续）
void giPlayerDoAction(int player_id, string action_name, int action_arg, bool wait_until_done);

// giPlayerDoActionRepeat: 让指定玩家重复执行某个动作
// source: name+signature+ida-callback:PlayerAction_Handler_Repeat; confidence: high
// params: player_id=玩家编号; action_name=动作名
void giPlayerDoActionRepeat(int player_id, string action_name);

// giPlayerEndAction: 结束当前玩家动作
// source: name+script-usage; confidence: high
// params: player_id=玩家编号
void giPlayerEndAction(int player_id);

// giPlayerEndActionRepeat: 结束指定玩家的重复动作
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号
void giPlayerEndActionRepeat(int player_id);

// giPlayerEndMove: 结束指定玩家当前移动
// source: name+signature; confidence: high
// params: player_id=玩家编号
void giPlayerEndMove(int player_id);

// giPlayerFaceToCurrentPlayer: 让指定玩家朝向当前玩家
// source: name+signature+ida-callback:Player_FaceToCurrentPlayer+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giPlayerFaceToCurrentPlayer(int player_id, bool wait_until_done);

// giPlayerFaceToNpc: 让指定玩家朝向指定 NPC
// source: name+signature+ida-callback:Player_FaceToNpc+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; npc_id=NPC 名称或编号; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giPlayerFaceToNpc(int player_id, string npc_id, bool wait_until_done);

// giPlayerFaceToPlayer: 让指定玩家朝向另一名玩家
// source: name+signature+ida-callback:Player_FaceToPlayer+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; target_player_id=目标玩家编号; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giPlayerFaceToPlayer(int player_id, int target_player_id, bool wait_until_done);

// giPlayerForbidenSkill: 禁用指定玩家的技能或技能使用
// source: name+signature+auto-param-notes; confidence: medium
// params: player_id=玩家编号; value2=技能编号; flag3=是否禁用技能
void giPlayerForbidenSkill(int player_id, int value2, bool flag3);

// giPlayerGarb1: 切换指定玩家的一套外观或材质状态
// source: ida-callback:Quest_UpdatePlayerStateByIndex2+auto-param-notes; confidence: medium
// params: player_id=玩家编号
void giPlayerGarb1(int player_id);

// giPlayerGarb2: 切换指定玩家的第二套外观或装束状态
// source: name+signature+auto-param-notes; confidence: medium
// params: player_id=玩家编号
void giPlayerGarb2(int player_id);

// giPlayerGetLeader: 读取当前队伍领队编号
// source: name+signature; confidence: high
int giPlayerGetLeader(void);

// giPlayerHookEffect: 将钩挂类特效绑定到指定玩家
// source: name+signature+auto-param-notes; confidence: medium
// params: player_id=玩家编号; effect_name=特效资源名; effect_arg=特效附加整型参数
void giPlayerHookEffect(int player_id, string effect_name, int effect_arg);

// giPlayerInTeam: 将角色加入当前队伍
// source: name+signature+ida-callback:Player_AddToParty; confidence: high
// params: player_id=玩家编号; show_join_hint=是否显示入队提示
void giPlayerInTeam(int player_id, bool show_join_hint);

// giPlayerLock: 锁定玩家控制
// source: name+signature; confidence: high
void giPlayerLock(void);

// giPlayerOutTeam: 将角色移出当前队伍
// source: name+signature+ida-callback:Player_RemoveFromParty; confidence: high
// params: player_id=玩家编号; show_leave_hint=是否显示离队提示
void giPlayerOutTeam(int player_id, bool show_leave_hint);

// giPlayerRandomPosition: 为指定玩家在给定范围内寻找随机位置
// source: name+signature+auto-param-notes; confidence: medium
// params: player_id=玩家编号; value2=随机浮点参数1; value3=随机浮点参数2
void giPlayerRandomPosition(int player_id, float value2, float value3);

// giPlayerResetEmotion: 重置指定玩家的表情状态
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号
void giPlayerResetEmotion(int player_id);

// giPlayerRunTo: 让指定玩家跑向指定位置
// source: name+signature+ida-callback:Player_RunTo+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; wait_until_done=是否等待移动完成（true=阻塞脚本直到跑动结束；false=发起跑动后立即继续）
void giPlayerRunTo(int player_id, float target_x, float target_y, float target_z, bool wait_until_done);

// giPlayerSetAng: 设置指定玩家朝向
// source: name+signature; confidence: high
// params: player_id=玩家编号; angle=朝向角度
void giPlayerSetAng(int player_id, float angle);

// giPlayerSetAttr: 设置指定玩家属性值
// source: name+signature+auto-param-notes; confidence: medium
// params: player_id=玩家编号; value2=属性编号; value3=属性值
void giPlayerSetAttr(int player_id, int value2, int value3);

// giPlayerSetDir: 让指定玩家转向指定方向
// source: name+signature+ida-callback:Player_TurnToDirection+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; direction=方向角度; wait_until_done=是否等待转向完成（true=阻塞脚本直到转向结束；false=启动转向后立即继续）
void giPlayerSetDir(int player_id, float direction, bool wait_until_done);

// giPlayerSetEmotion: 设置指定玩家的表情状态
// source: name+signature+ida-callback:Player_SetMaterialTexture; confidence: high
// params: player_id=玩家编号; emotion_name=表情状态名
void giPlayerSetEmotion(int player_id, string emotion_name);

// giPlayerSetLeader: 设置当前队伍领队
// source: name+signature; confidence: high
// params: player_id=领队玩家编号
void giPlayerSetLeader(int player_id);

// giPlayerSetPos: 设置指定玩家位置
// source: name+signature; confidence: high
// params: player_id=玩家编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标
void giPlayerSetPos(int player_id, float target_x, float target_y, float target_z);

// giPlayerSetPosRot: 设置指定玩家的位置和朝向
// source: ida-callback:Player_SetPosition+auto-param-notes; confidence: high
// params: player_id=玩家编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; angle=朝向角度
void giPlayerSetPosRot(int player_id, float target_x, float target_y, float target_z, float angle);

// giPlayerSetRot: 设置指定玩家旋转角度
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号; text2=旋转配置名
void giPlayerSetRot(int player_id, string text2);

// giPlayerSetVisible: 设置指定玩家是否可见
// source: name+signature; confidence: high
// params: player_id=玩家编号; visible=是否可见
void giPlayerSetVisible(int player_id, bool visible);

// giPlayerTakeARest: 让玩家休息并触发休息效果
// source: name+signature; confidence: medium
void giPlayerTakeARest(void);

// giPlayerUnHoldAct: 清除角色当前保持或挂起的动作效果
// source: ida-callback:Player_ClearEffects; confidence: high
// params: player_id=玩家编号
void giPlayerUnHoldAct(int player_id);

// giPlayerUnLock: 解除玩家控制锁定
// source: name+signature; confidence: high
void giPlayerUnLock(void);

// giPlayerWalkTo: 让指定玩家步行到指定位置
// source: name+signature+ida-callback:Player_WalkTo+script-handler-wait-mode; confidence: high
// params: player_id=玩家编号; target_x=目标 X 坐标; target_y=目标 Y 坐标; target_z=目标 Z 坐标; wait_until_done=是否等待移动完成（true=阻塞脚本直到步行结束；false=发起步行后立即继续）
void giPlayerWalkTo(int player_id, float target_x, float target_y, float target_z, bool wait_until_done);

// giPlayMovie: 播放一段过场视频
// source: signature+name; confidence: high
// params: movie_name=视频资源名
void giPlayMovie(string movie_name);

// giPlayMovieFinal: 播放结局或特殊版本的过场视频
// source: ida-callback:Movie_Play_2+auto-param-notes; confidence: high
// params: text=附加字符串参数
void giPlayMovieFinal(string text);

// giRandTalk: 从随机对白池触发一条对白
// source: signature+script-usage; confidence: medium
void giRandTalk(void);

// giRandTalkPush: 向随机对白池压入一条候选对白
// source: signature+script-usage; confidence: high
// params: text=候选对白文本
void giRandTalkPush(string text);

// giRandTalkRelease: 清空并释放随机对白池
// source: signature+script-usage; confidence: medium
void giRandTalkRelease(void);

// giRemoveEquipment: 移除一件装备
// source: name+signature+auto-param-notes; confidence: high
// params: equip_id=装备编号; flag2=是否显示提示
void giRemoveEquipment(int equip_id, bool flag2);

// giResetPlayerToJumpStart: 将玩家重置回跳跃起点或默认跳跃状态
// source: name+ida-callback:ActorControl_Sputn; confidence: medium
void giResetPlayerToJumpStart(void);

// giResumeUiTimer: 恢复 UI 计时器
// source: name+signature; confidence: medium
void giResumeUiTimer(void);

// giScriptClearCTXButCurrent: 清理脚本上下文并保留当前上下文
// source: name+signature; confidence: medium
void giScriptClearCTXButCurrent(void);

// giScriptMusicMute: 静音脚本控制的音乐
// source: name+signature+auto-param-notes; confidence: high
// params: flag=附加布尔控制标志
void giScriptMusicMute(bool flag);

// giScriptMusicPause: 暂停脚本控制的音乐
// source: name+signature; confidence: high
void giScriptMusicPause(void);

// giScriptMusicPlay: 播放脚本控制的音乐
// source: name+signature+ida-callback:PAL_ScriptMusicPlay_Impl+auto-param-notes; confidence: high
// params: text=音乐资源名; value2=播放模式编号; value1=附加浮点参数1; value2_2=附加浮点参数2
void giScriptMusicPlay(string text, int value2, float value1, float value2_2);

// giScriptMusicResume: 恢复脚本控制的音乐
// source: name+signature; confidence: high
void giScriptMusicResume(void);

// giScriptMusicStop: 停止脚本控制的音乐
// source: name+signature+ida-callback:Music_SetPlaybackParameters; confidence: medium
// params: value=播放参数模式编号; value2=过渡时长或音量参数
void giScriptMusicStop(int value, float value2);

// giSelectDialogAddItem: 向选择对话框添加一个选项
// source: name+signature; confidence: high
// params: item_text=选项文本
void giSelectDialogAddItem(string item_text);

// giSelectDialogGetLastSelect: 读取选择对话框最后选中的项
// source: name+signature; confidence: high
int giSelectDialogGetLastSelect(void);

// giSelectDialogSetDefaultSelect: 设置选择对话框默认选项
// source: name+signature; confidence: high
// params: default_index=默认选项索引
void giSelectDialogSetDefaultSelect(int default_index);

// giSetFullHP: 回满生命值
// source: name+signature; confidence: high
void giSetFullHP(void);

// giSetFullMP: 回满法力值
// source: name+signature; confidence: high
void giSetFullMP(void);

// giSetFullRage: 将角色怒气或对应战斗槽位补满
// source: name+ida-wrapper; confidence: medium
void giSetFullRage(void);

// giSetGoodsOpenCondition: 设置商品或商店开放条件
// source: name+signature+auto-param-notes; confidence: medium
// params: value=商品编号; value2=开启条件值
void giSetGoodsOpenCondition(int value, int value2);

// giSetMinimapExpmode: 设置小地图探索显示模式
// source: name+signature+auto-param-notes; confidence: medium
// params: value=小地图探索模式值
void giSetMinimapExpmode(int value);

// giSetMinimapLevel: 设置小地图层级或楼层
// source: name+signature+auto-param-notes; confidence: high
// params: value=小地图层级值
void giSetMinimapLevel(int value);

// giSetNpcVisible: 设置 NPC 是否可见
// source: name+signature; confidence: high
// params: npc_id=NPC 名称或编号; visible=是否可见
void giSetNpcVisible(string npc_id, bool visible);

// giSetObjectVisible: 设置场景对象是否可见
// source: name+signature; confidence: high
// params: object_name=场景对象名; visible=是否可见
void giSetObjectVisible(string object_name, bool visible);

// giSetPlayerLevel: 设置玩家等级
// source: name+signature+auto-param-notes; confidence: high
// params: player_id=玩家编号; value2=等级值
void giSetPlayerLevel(int player_id, int value2);

// giSetPortrait: 设置当前对话头像及显示状态
// source: name+script-usage; confidence: high
// params: portrait_name=头像资源名; show_portrait=是否显示头像
void giSetPortrait(string portrait_name, bool show_portrait);

// giSetTempGameState: 设置临时游戏状态
// source: name+signature+auto-param-notes; confidence: medium
// params: value=临时游戏状态值
void giSetTempGameState(int value);

// giShowCommonDialog: 显示通用对话框
// source: ida-callback:Dialog_ShowCommon+auto-param-notes; confidence: high
// params: text=对话文本; value2=对话框浮点参数1; value3=对话框浮点参数2
void giShowCommonDialog(string text, float value2, float value3);

// giShowCommonDialogInSelectMode: 以选择模式显示通用对话框
// source: name+signature+auto-param-notes; confidence: medium
// params: text=对话文本; value2=对话框浮点参数1; value3=对话框浮点参数2
void giShowCommonDialogInSelectMode(string text, float value2, float value3);

// giShowHint: 显示一条提示信息
// source: name+signature+ida-callback:Hint_ShowText+auto-param-notes; confidence: high
// params: hint_text=提示文本; value2=提示窗口浮点参数1; value3=提示窗口浮点参数2
void giShowHint(string hint_text, float value2, float value3);

// giShowInnDialog: 显示住宿或客栈对话框
// source: name+signature+auto-param-notes; confidence: medium
// params: flag=附加布尔控制标志
void giShowInnDialog(bool flag);

// giShowPoetry: 显示诗词或诗句界面
// source: name+signature+auto-param-notes; confidence: medium
// params: value=诗词编号; flag=附加布尔控制标志
void giShowPoetry(int value, bool flag);

// giShowQuestDialog: 显示任务对话框
// source: name+signature; confidence: high
// params: quest_text=任务对话文本
void giShowQuestDialog(string quest_text);

// giShowSelectDialog: 显示选择对话框
// source: signature+name; confidence: high
// params: dialog_text=对话框文本
void giShowSelectDialog(string dialog_text);

// giShowSignpost: 显示路牌或提示牌信息
// source: name+signature; confidence: medium
void giShowSignpost(void);

// giShowTutorial: 显示教程提示
// source: name+signature+auto-param-notes; confidence: high
// params: ikey=教程编号
void giShowTutorial(int ikey);

// giShowWorldMap: 显示世界地图界面
// source: name+signature; confidence: high
void giShowWorldMap(void);

// giStartCombat: 开始一场战斗
// source: name+signature; confidence: high
// params: combat_name=战斗配置或战斗脚本名
void giStartCombat(string combat_name);

// giStartJigsawGame: 启动拼图小游戏
// source: name+signature+auto-param-notes; confidence: medium
// params: value=小游戏编号
void giStartJigsawGame(int value);

// giStartPuzzleGame: 启动解谜小游戏
// source: name+signature+auto-param-notes; confidence: medium
// params: value=小游戏编号
void giStartPuzzleGame(int value);

// giStartTradeSystem: 打开交易系统或交易界面
// source: name+signature+ida-callback:Trade_SetItemInfo; confidence: high
// params: shop_id=商店编号; trade_context=交易附加信息或业务脚本名
void giStartTradeSystem(string shop_id, string trade_context);

// giStartUiTimer: 启动一个 UI 计时器
// source: name+signature; confidence: medium
// params: timer_save_data=计时器保存数据; callback_name=回调函数名
void giStartUiTimer(int timer_save_data, string callback_name);

// giSystemExchange: 切换系统状态或系统界面
// source: name+signature+auto-param-notes; confidence: medium
// params: value=系统交换模式编号
void giSystemExchange(int value);

// giTalk: 显示对白
// source: signature+script-usage; confidence: high
// params: text=对白文本; voice_id=语音或文本编号
void giTalk(string text, string voice_id);

// giTalkWait: 等待当前对白播放或显示结束
// source: name+signature; confidence: high
void giTalkWait(void);

// giTimeScript: 启动一个定时脚本回调
// source: ida-callback:scriptInitializeState+script-usage; confidence: high
// params: value=触发延时秒数; callback_name=回调函数名
void giTimeScript(float value, string callback_name);

// giTimeScriptTerminate: 停止当前定时脚本
// source: ida-callback:scriptResetState; confidence: medium
void giTimeScriptTerminate(void);

// giUiTimerGetSaveData: 读取 UI 计时器的存档数据
// source: ida-callback:GameData_GetEntry70; confidence: medium
int giUiTimerGetSaveData(void);

// giWait: 等待指定时长
// source: signature+name; confidence: high
// params: seconds=等待秒数
void giWait(double seconds);

// giWorldMapSetState: 设置世界地图状态
// source: name+signature+ida-callback:WorldMapUI_SetExternalButtonVisibility; confidence: high
// params: map_node=世界地图地点名; state=按钮可见性状态值
void giWorldMapSetState(string map_node, int state);

#endif
