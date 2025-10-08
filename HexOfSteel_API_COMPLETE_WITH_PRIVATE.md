# Hex Of Steel - COMPLETE API Reference (Public + Private)

*Generated on: 2025-10-07 08:43:29*

This document contains a **comprehensive** reference of ALL classes (public, internal, and private)
and ALL their members (public AND private) available in Hex Of Steel.

**With Harmony, you can access and patch EVERYTHING in this document!**

---

## How to Use Private Members with Harmony

### Patching Private Methods
```csharp
[HarmonyPatch(typeof(ClassName), "PrivateMethodName")]
class MyPatch {
    static bool Prefix(ClassName __instance) {
        // Your code here
        return true; // return false to skip original method
    }
}
```

### Accessing Private Fields with Traverse
```csharp
var instance = GetYourInstance();
var privateValue = Traverse.Create(instance).Field("privateFieldName").GetValue<int>();
Traverse.Create(instance).Field("privateFieldName").SetValue(42);
```

### Accessing Private Fields with AccessTools
```csharp
var fieldInfo = AccessTools.Field(typeof(ClassName), "privateFieldName");
var value = fieldInfo.GetValue(instance);
fieldInfo.SetValue(instance, newValue);
```

### Calling Private Methods
```csharp
var methodInfo = AccessTools.Method(typeof(ClassName), "PrivateMethodName");
methodInfo.Invoke(instance, new object[] { param1, param2 });
```

---

## Table of Contents

**Total Classes: 234**

1. [<PrivateImplementationDetails>](#<privateimplementationdetails>) *(internal/private)*
2. [AchievementElementUI](#achievementelementui) *(public)*
3. [AchievementsUI](#achievementsui) *(public)*
4. [ActionTypes](#actiontypes) *(public)*
5. [AI](#ai) *(public)*
6. [AirHeroes](#airheroes) *(public)*
7. [AIWaitInstruction](#aiwaitinstruction) *(public)*
8. [AllowedRotations](#allowedrotations) *(public)*
9. [AsleepStates](#asleepstates) *(public)*
10. [CameraGO](#camerago) *(public)*
11. [CampaignMenu](#campaignmenu) *(public)*
12. [CanvasRescaler](#canvasrescaler) *(public)*
13. [ChartAndGraph.SelectScene](#chartandgraphselectscene) *(public)*
14. [ChatMessageData](#chatmessagedata) *(public)*
15. [CheckTypes](#checktypes) *(public)*
16. [ClickableMessage](#clickablemessage) *(public)*
17. [Cloud](#cloud) *(public)*
18. [CloudManager](#cloudmanager) *(public)*
19. [ConfirmationWindowGO](#confirmationwindowgo) *(public)*
20. [ConnectedPlayerSlotGO](#connectedplayerslotgo) *(public)*
21. [Coordinates](#coordinates) *(public)*
22. [CountryEditor](#countryeditor) *(public)*
23. [CustomCountries](#customcountries) *(public)*
24. [CustomTiles](#customtiles) *(public)*
25. [CustomUnits](#customunits) *(public)*
26. [DamageTextGO](#damagetextgo) *(public)*
27. [DamageTypes](#damagetypes) *(public)*
28. [Database](#database) *(public)*
29. [DataMigrator](#datamigrator) *(public)*
30. [DentedPixel.LeanDummy](#dentedpixelleandummy) *(public)*
31. [DeploySlotGO](#deployslotgo) *(public)*
32. [DiplomacyGO](#diplomacygo) *(public)*
33. [DiplomacySlotGO](#diplomacyslotgo) *(public)*
34. [DiplomacyTooltipGO](#diplomacytooltipgo) *(public)*
35. [DrawingManager](#drawingmanager) *(public)*
36. [EndGameResults](#endgameresults) *(public)*
37. [Event](#event) *(public)*
38. [EventAction](#eventaction) *(public)*
39. [EventActionSlotGO](#eventactionslotgo) *(public)*
40. [EventData](#eventdata) *(public)*
41. [EventListSlotGO](#eventlistslotgo) *(public)*
42. [EventPanelGO](#eventpanelgo) *(public)*
43. [Explosion](#explosion) *(public)*
44. [FacingRotations](#facingrotations) *(public)*
45. [FadeTileGO](#fadetilego) *(public)*
46. [FCP_Persistence](#fcp_persistence) *(public)*
47. [FCP_SpriteMeshEditor](#fcp_spritemesheditor) *(public)*
48. [FlexibleColorPicker](#flexiblecolorpicker) *(public)*
49. [ForecastType](#forecasttype) *(public)*
50. [Game](#game) *(public)*
51. [GameData](#gamedata) *(public)*
52. [GameLanguages](#gamelanguages) *(public)*
53. [GameModification](#gamemodification) *(public)*
54. [GameResponse](#gameresponse) *(public)*
55. [GameSettings](#gamesettings) *(public)*
56. [GameStates](#gamestates) *(public)*
57. [GraphPanelGO](#graphpanelgo) *(public)*
58. [GroundHeroes](#groundheroes) *(public)*
59. [Hero](#hero) *(public)*
60. [HeroBonusesGO](#herobonusesgo) *(public)*
61. [HeroesEditor](#heroeseditor) *(public)*
62. [HoverUnitUI](#hoverunitui) *(public)*
63. [IModProperty](#imodproperty) *(internal/private)*
64. [IntegerInputfield](#integerinputfield) *(public)*
65. [InvalidIronManReasons](#invalidironmanreasons) *(public)*
66. [IronmanTooltip](#ironmantooltip) *(public)*
67. [LanguageSlotUI](#languageslotui) *(public)*
68. [LastTurnSummaryData](#lastturnsummarydata) *(public)*
69. [LastTurnSummaryUI](#lastturnsummaryui) *(public)*
70. [LeaderboardActions](#leaderboardactions) *(public)*
71. [LeaderboardEntryUI](#leaderboardentryui) *(public)*
72. [LeaderboardGO](#leaderboardgo) *(public)*
73. [LeanAudio](#leanaudio) *(public)*
74. [LeanAudioOptions](#leanaudiooptions) *(public)*
75. [LeanAudioStream](#leanaudiostream) *(public)*
76. [LeanProp](#leanprop) *(public)*
77. [LeanSmooth](#leansmooth) *(public)*
78. [LeanTest](#leantest) *(public)*
79. [LeanTester](#leantester) *(public)*
80. [LeanTween](#leantween) *(public)*
81. [LeanTweenExt](#leantweenext) *(public)*
82. [LeanTweenType](#leantweentype) *(public)*
83. [Line](#line) *(public)*
84. [LineData](#linedata) *(public)*
85. [LoadingWheel](#loadingwheel) *(public)*
86. [LoadMenu](#loadmenu) *(public)*
87. [Locale_Base](#locale_base) *(public)*
88. [Locale_BR](#locale_br) *(public)*
89. [Locale_CA](#locale_ca) *(public)*
90. [Locale_CNS](#locale_cns) *(public)*
91. [Locale_CNT](#locale_cnt) *(public)*
92. [Locale_CZ](#locale_cz) *(public)*
93. [Locale_DE](#locale_de) *(public)*
94. [Locale_EN](#locale_en) *(public)*
95. [Locale_ES](#locale_es) *(public)*
96. [Locale_FI](#locale_fi) *(public)*
97. [Locale_FR](#locale_fr) *(public)*
98. [Locale_GR](#locale_gr) *(public)*
99. [Locale_IT](#locale_it) *(public)*
100. [Locale_JP](#locale_jp) *(public)*
101. [Locale_KR](#locale_kr) *(public)*
102. [Locale_NL](#locale_nl) *(public)*
103. [Locale_NO](#locale_no) *(public)*
104. [Locale_PL](#locale_pl) *(public)*
105. [Locale_PT](#locale_pt) *(public)*
106. [Locale_RU](#locale_ru) *(public)*
107. [Locale_SE](#locale_se) *(public)*
108. [Locale_TR](#locale_tr) *(public)*
109. [Locale_UA](#locale_ua) *(public)*
110. [LocalizationManager](#localizationmanager) *(public)*
111. [LocalizationUI](#localizationui) *(public)*
112. [LocalizedText](#localizedtext) *(public)*
113. [LTBezier](#ltbezier) *(public)*
114. [LTBezierPath](#ltbezierpath) *(public)*
115. [LTDescr](#ltdescr) *(public)*
116. [LTDescrOptional](#ltdescroptional) *(public)*
117. [LTEvent](#ltevent) *(public)*
118. [LTGUI](#ltgui) *(public)*
119. [LTRect](#ltrect) *(public)*
120. [LTSeq](#ltseq) *(public)*
121. [LTSpline](#ltspline) *(public)*
122. [LTUtility](#ltutility) *(public)*
123. [MainMenu](#mainmenu) *(public)*
124. [ManpowerTooltipGO](#manpowertooltipgo) *(public)*
125. [Map](#map) *(public)*
126. [MapEditorGO](#mapeditorgo) *(public)*
127. [MapEditorMenu](#mapeditormenu) *(public)*
128. [MapGeneratorGO](#mapgeneratorgo) *(public)*
129. [MapGO](#mapgo) *(public)*
130. [MapOverlayManager](#mapoverlaymanager) *(public)*
131. [MessageBoxGO](#messageboxgo) *(public)*
132. [Mod](#mod) *(public)*
133. [ModBase](#modbase) *(public)*
134. [ModdedHeroes](#moddedheroes) *(public)*
135. [ModifiedBaseTiles](#modifiedbasetiles) *(public)*
136. [ModifiedBaseUnits](#modifiedbaseunits) *(public)*
137. [ModManifest](#modmanifest) *(public)*
138. [ModPanelGO](#modpanelgo) *(public)*
139. [ModProperty`1](#modproperty1) *(internal/private)*
140. [ModPropertyBag](#modpropertybag) *(public)*
141. [ModSlotGO](#modslotgo) *(public)*
142. [ModsManager](#modsmanager) *(public)*
143. [MoneyTooltipGO](#moneytooltipgo) *(public)*
144. [MoraleStates](#moralestates) *(public)*
145. [MultiplayerChat](#multiplayerchat) *(public)*
146. [MultiplayerManager](#multiplayermanager) *(public)*
147. [MultiplayerMenu](#multiplayermenu) *(public)*
148. [NavalHeroes](#navalheroes) *(public)*
149. [NewMinimap](#newminimap) *(public)*
150. [Notification](#notification) *(public)*
151. [NotificationButtonGO](#notificationbuttongo) *(public)*
152. [NotificationManager](#notificationmanager) *(public)*
153. [NotificationTypes](#notificationtypes) *(public)*
154. [OfficialTiles](#officialtiles) *(public)*
155. [OfficialTilesORIGINAL](#officialtilesoriginal) *(public)*
156. [OfficialUnits](#officialunits) *(public)*
157. [OfficialUnitsORIGINAL](#officialunitsoriginal) *(public)*
158. [OnlineGame](#onlinegame) *(public)*
159. [OnlineUser](#onlineuser) *(public)*
160. [OOBSlot](#oobslot) *(public)*
161. [OrderOfBattleGO](#orderofbattlego) *(public)*
162. [OwnerPanelEditorGO](#ownerpaneleditorgo) *(public)*
163. [PaintMode](#paintmode) *(public)*
164. [PasswordInputfieldUI](#passwordinputfieldui) *(public)*
165. [Player](#player) *(public)*
166. [PlayerSettings](#playersettings) *(public)*
167. [PlayerSlotMapEditor](#playerslotmapeditor) *(public)*
168. [Policies](#policies) *(public)*
169. [PoliciesGO](#policiesgo) *(public)*
170. [Policy](#policy) *(public)*
171. [PolicySlotGO](#policyslotgo) *(public)*
172. [PolicyTooltipGO](#policytooltipgo) *(public)*
173. [PoliticalArea](#politicalarea) *(public)*
174. [PoliticalHexRenderer](#politicalhexrenderer) *(public)*
175. [PriorityQueue`1](#priorityqueue1) *(public)*
176. [ResearchMenu](#researchmenu) *(public)*
177. [ResearchUnitSlot](#researchunitslot) *(public)*
178. [ReservePanelGO](#reservepanelgo) *(public)*
179. [Response](#response) *(public)*
180. [ResupplyCostGO](#resupplycostgo) *(public)*
181. [SaveMenu](#savemenu) *(public)*
182. [SceneTranslator](#scenetranslator) *(public)*
183. [SelectedUnitExtraStatsUI](#selectedunitextrastatsui) *(public)*
184. [SelectedUnitUI](#selectedunitui) *(public)*
185. [SettingsMenu](#settingsmenu) *(public)*
186. [SimpleSlotUI](#simpleslotui) *(public)*
187. [SoundManager](#soundmanager) *(public)*
188. [StandaloneScenariosMenu](#standalonescenariosmenu) *(public)*
189. [Statistic](#statistic) *(public)*
190. [SteamLeaderboard](#steamleaderboard) *(public)*
191. [SteamLeaderboardEntry](#steamleaderboardentry) *(public)*
192. [SteamManager](#steammanager) *(public)*
193. [SteamStatuses](#steamstatuses) *(public)*
194. [SteamWorkshopMenu](#steamworkshopmenu) *(public)*
195. [StoreGO](#storego) *(public)*
196. [TargetGO](#targetgo) *(public)*
197. [TechTreeTooltipGO](#techtreetooltipgo) *(public)*
198. [testMarker](#testmarker) *(public)*
199. [Tile](#tile) *(public)*
200. [TileEditor](#tileeditor) *(public)*
201. [TileEditorGO](#tileeditorgo) *(public)*
202. [TileGO](#tilego) *(public)*
203. [TileSeason](#tileseason) *(public)*
204. [TilesManagerGO](#tilesmanagergo) *(public)*
205. [TileTransferSlotGO](#tiletransferslotgo) *(public)*
206. [TileTypes](#tiletypes) *(public)*
207. [TooltipFlagGO](#tooltipflaggo) *(public)*
208. [TooltipGO](#tooltipgo) *(public)*
209. [TurnManager](#turnmanager) *(public)*
210. [TutorialActions](#tutorialactions) *(public)*
211. [TutorialManager](#tutorialmanager) *(public)*
212. [TutorialPage](#tutorialpage) *(public)*
213. [TutorialStepData](#tutorialstepdata) *(public)*
214. [TutorialTask](#tutorialtask) *(public)*
215. [TutorialTaskUI](#tutorialtaskui) *(public)*
216. [TutorialWindow](#tutorialwindow) *(public)*
217. [TweenAction](#tweenaction) *(public)*
218. [UIManager](#uimanager) *(public)*
219. [UIWindowController](#uiwindowcontroller) *(public)*
220. [Unit](#unit) *(public)*
221. [UnitCategories](#unitcategories) *(public)*
222. [UnitEditor](#uniteditor) *(public)*
223. [UnitGO](#unitgo) *(public)*
224. [UnitModification](#unitmodification) *(public)*
225. [UnitsFilterHelper](#unitsfilterhelper) *(public)*
226. [UnitSlotStoreGO](#unitslotstorego) *(public)*
227. [UnitStatsPanelUI](#unitstatspanelui) *(public)*
228. [UnitStoreSlotGO](#unitstoreslotgo) *(public)*
229. [Utils](#utils) *(public)*
230. [WeatherPredictionData](#weatherpredictiondata) *(public)*
231. [WeatherSlotGO](#weatherslotgo) *(public)*
232. [WeatherTooltipGO](#weathertooltipgo) *(public)*
233. [WeatherType](#weathertype) *(public)*
234. [XPanimationGO](#xpanimationgo) *(public)*

---


## <PrivateImplementationDetails>

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private static UInt32 ComputeStringHash(String s)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private static readonly Int64 0EB2B65A0396BC0C88A6BBAFC8F741485AB4C51A927414C9C361667A6787BC43`
- `private static readonly __StaticArrayInitTypeSize=12 231898C2AB3DDCE65487C50851970834CE10A7CB6F15557D1C4C2D29829AD15D`
- `private static readonly Int64 4DCBC39111FDEFD8129D5310C7007ABE32F23DBBE69CB900AFBD0BB41130CCDD`
- `private static readonly __StaticArrayInitTypeSize=6 6889EC40F08A61A224D4C547770B42C6894735D2840479CD189016BE20559647`

### Nested Types

- `private class __StaticArrayInitTypeSize=12`
- `private class __StaticArrayInitTypeSize=6`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(<PrivateImplementationDetails>), "PrivateMethodName", MethodType.Normal)]
class Patch_<PrivateImplementationDetails>_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(<PrivateImplementationDetails>), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## AchievementElementUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Setup(Boolean p_unlocked, String p_name, String p_description)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Image _base_image`
- `private Text _description_text`
- `private Sprite _locked_sprite`
- `private Text _name_text`
- `private Sprite _unlocked_sprite`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(AchievementElementUI), "PrivateMethodName", MethodType.Normal)]
class Patch_AchievementElementUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(AchievementElementUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## AchievementsUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void CloseMenu()`
- `public Void OpenMenu()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void LoadAchievementData()`
- `private Void OnEnable()`
- `private Void UpdateAchievementList()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 _achievements`
- `private TextMeshProUGUI _achievements_text`
- `private AchievementElementUI _prefab`
- `private Transform _transform`

### Nested Types

- `private class <>c`
- `private class AchievementData`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(AchievementsUI), "PrivateMethodName", MethodType.Normal)]
class Patch_AchievementsUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(AchievementsUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ActionTypes

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const ActionTypes ADD_FIXED_INCOME`
- `public static const ActionTypes ADD_HQ_POINTS`
- `public static const ActionTypes ADD_MONEY`
- `public static const ActionTypes ADD_PLAYER`
- `public static const ActionTypes ADD_UNIT_RESERVE`
- `public static const ActionTypes ADD_VP`
- `public static const ActionTypes CAPITULATION`
- `public static const ActionTypes CHANGE_VP_OWNERSHIP`
- `public static const ActionTypes COUNTRY_CHANGE`
- `public static const ActionTypes DECLARE_WAR`
- `public static const ActionTypes DESTROY_TILE`
- `public static const ActionTypes FACTION_CHANGE`
- `public static const ActionTypes MAKE_ALLIANCE`
- `public static const ActionTypes MAKE_PEACE`
- `public static const ActionTypes MAKE_PEACE_FACTION`
- `public static const ActionTypes NONE`
- `public static const ActionTypes REMOVE_PLAYER`
- `public static const ActionTypes REMOVE_VP`
- `public static const ActionTypes RESET_INCOME`
- `public static const ActionTypes SET_FIXED_INCOME`
- `public static const ActionTypes SET_FIXED_INCOME_FROM_BASE_INCOME_PERCENT`
- `public static const ActionTypes SET_FIXED_INCOME_PERCENT`
- `public static const ActionTypes SET_TILE`
- `public static const ActionTypes SET_TILE_NAME`
- `public static const ActionTypes SHOW_MESSAGE`
- `public static const ActionTypes SPAWN_UNIT`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ActionTypes), "PrivateMethodName", MethodType.Normal)]
class Patch_ActionTypes_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ActionTypes), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## AI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Boolean IsEuropeWithHistoricalFocus()`
- `public Void PlayerControlAboutToChange(Player p_player)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Boolean AreThereEnemiesAround(TileGO p_tileGO, Int32 p_radius, Boolean p_includeAir, Boolean p_useFogOfWar)`
- `private Void Awake()`
- `private Void CalculateIncomeForAllPlayers()`
- `private Boolean CanDealDamage()`
- `private Boolean CanPlaneAttackSafely(Tile p_tile, Int32 p_ownDamageDealt)`
- `private Boolean CanPurchaseUnitsFromPlayer(Player p_player)`
- `private Void CheckForAttack()`
- `private Void CheckWinningWar()`
- `private Void CountEnemyUnits()`
- `private Void CountOurUnits()`
- `private IEnumerator CR_PlayAllUnits()`
- `private IEnumerator CR_SyncAIPlayingBar()`
- `private Void DeclareWarOnCountry(TileGO p_tileGO)`
- `private Void DeployUnits()`
- `private Void DisbandUnit(Unit p_unit)`
- `private Void DoResupply(Boolean p_ignoreHP)`
- `private Void GatherEnemyVictoryPoints()`
- `private Single GetAttackRiskRewardRatio(UnitGO p_attackingUnitGO, UnitGO p_enemyUnitGO)`
- `private Void GetClickedTile()`
- `private TileGO GetFurthestWalkableTileFromEnemy(UnitGO p_unitGO, Int32 p_checkRadius)`
- `private Void GetPathToGoal(RunTimes p_runTime)`
- `private Int32 GetSupportiveFireDamage(UnitGO p_attackingUnitGO, UnitGO p_defendingUnitGO)`
- `private Single GetUpkeepThresholdForAcceptingNewUnits()`
- `private Single GetUpkeepToBaseIncomeRatio()`
- `private TileGO GiveNewGoal(UnitGO p_unitGO)`
- `private Void GoToWar()`
- `private Void InitializePurchasableUnitsDatabase()`
- `private Void InvitePlayersToFaction()`
- `private Boolean IsEnemyOnTile(Tile p_tile)`
- `private Boolean IsPlaneEscorted(Tile p_tile)`
- `private Boolean IsThereSimilarUnitAround(Tile p_tile, Int32 p_radius, Unit p_unit)`
- `private Boolean IsThereSpecificEnemyUnitAround(Tile p_tile, Int32 p_radius, String p_type, Int32 p_damageValue = -1)`
- `private Boolean IsTileFreeFor(UnitGO p_unitGO, TileGO p_tileGO)`
- `private Void LateUpdate()`
- `private Void Move()`
- `private Void OnDestroy()`
- `private Void PickPolicies()`
- `private Void PurchaseUnits(Boolean p_initializeDatabase, String p_filterOverwrite = null)`
- `private Void RefreshCameraFollowAuthorization()`
- `private Void RepairOrBlowupBridge()`
- `private Void ResearchTechnologies()`
- `private Void SendMoneyToAllies()`
- `private Boolean ShouldAIWaitForFocusOnUnit()`
- `private Boolean ShouldDisbandUnit(Unit p_unit)`
- `private Boolean ShouldLeaveTileForSomeoneElse(UnitGO p_unitGO, TileGO p_tileGO, RunTimes p_runTime)`
- `private Boolean ShouldPurchaseUnit(Unit p_unit)`
- `private Boolean ShouldSendUnitBackToReserve(UnitGO p_unitGO)`
- `private Boolean ShouldTakeDefensivePosition(TileGO& o_tileGO)`
- `private Boolean ShouldUnitLeaveDefensiveMode(UnitGO p_unitGO)`
- `private Boolean ShouldWeAttackPlayer(String p_country)`
- `private Boolean ShouldWeBuy(String p_filterName)`
- `private List`1 SortUnitsForBestStrategicPlayOrder(List`1 p_units)`
- `private Void Start()`
- `private Void TransferVPs()`
- `private Void UpgradeDowngradeUnits()`
- `private Boolean ValidSelectedUnitGO()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject AIplayingPanel`
- `public static Queue`1 AIWaitInstructions`
- `public static AI instance`
- `public static Boolean isPlaying`
- `public Slider loadingBar`
- `public Boolean needToRefreshEnemyVPs`
- `public static Player playerNeedsToRedeployItsUnitsNow`
- `public Boolean startTurn`
- `public Boolean supplyDepotNeeded`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 _airTransports`
- `private Dictionary`2 _allAirportAndTheirDistance`
- `private Int32 _alliance_production`
- `private List`1 _antiAir`
- `private Boolean _areWeWinning`
- `private List`1 _artillery`
- `private Boolean _backupQuickmovementRule`
- `private Int32 _baseCoreTerritory`
- `private List`1 _bestPath`
- `private Boolean _boughtArmouredTrainThisTurn`
- `private Boolean _boughtCommanderThisTurn`
- `private Boolean _boughtSupplyDepotThisTurn`
- `private Boolean _cameraNeedFocusOnUnit`
- `private Boolean _canCameraFollowAI`
- `private Boolean _canPerformLandings`
- `private Dictionary`2 _carrierDamage`
- `private List`1 _carriers`
- `private Single _coreTerritoryPercent`
- `private DateTime _currDate`
- `private Int32 _currentAvailableManpower`
- `private Int32 _currentCoreTerritory`
- `private Int32 _currentTurnCount`
- `private Int32 _currentUpkeepCost`
- `private String _currPlayerCountry`
- `private Int32 _currYear`
- `private Single _desertTilesPercentage`
- `private Dictionary`2 _dicBbuildingDamage`
- `private Dictionary`2 _dicBomberDamage`
- `private Dictionary`2 _dicBuildingsToProtect`
- `private Dictionary`2 _dicFighterDamage`
- `private Dictionary`2 _dicGroundDamage`
- `private Dictionary`2 _dicOfDamagePerUnit`
- `private Dictionary`2 _dicOfPlayersAndTheirIncome`
- `private Dictionary`2 _dicOfUnitsWeCanKill`
- `private Dictionary`2 _dicPlayersIntact`
- `private Dictionary`2 _dicUnescortedBomberDamage`
- `private Int32 _difficultyLevel`
- `private Single _distanceCamToUnit`
- `private Int32 _enemies_production`
- `private Dictionary`2 _enemyVPsByDistance`
- `private HashSet`1 _enemyVPsGO`
- `private List`1 _engineers`
- `private Boolean _engineersNeeded`
- `private Boolean _fastAI`
- `private Boolean _fastAI_AlliesOnly`
- `private List`1 _fighters`
- `private List`1 _fightersCanAttack`
- `private Single _forestPercentage`
- `private List`1 _friendliesToEscort`
- `private List`1 _friendlyBombers`
- `private List`1 _generalsList`
- `private Tile _goal`
- `private Boolean _goingForRepair`
- `private Boolean _hasAA`
- `private Boolean _hasAirport`
- `private Boolean _hasArtillery`
- `private Boolean _hasAT`
- `private Boolean _hasATinfantry43`
- `private Boolean _hasBarrageBalloons`
- `private Boolean _hasCarefulPlanning`
- `private Boolean _hasCAS`
- `private Boolean _hasEngineers`
- `private Boolean _hasFighters`
- `private Boolean _hasHarbour`
- `private Boolean _hasHeavyProductionMeans`
- `private Boolean _hasInfantry`
- `private Boolean _hasShips`
- `private Boolean _hasStrategicBombers`
- `private Boolean _hasSupplyDepots`
- `private Boolean _hasTanks`
- `private Single _hillAndMountainsPercentage`
- `private Boolean _ignoreOrder`
- `private Boolean _isAllyPlaying`
- `private Boolean _isCampaign`
- `private Boolean _isEuropeScenario`
- `private Boolean _isHistoricalFocusON`
- `private Boolean _isMajor`
- `private Boolean _isMinor`
- `private Boolean _isNavalMinor`
- `private Boolean _isNavalPower`
- `private Boolean _isOfficialMapWithLandingControl`
- `private Boolean _isPacificScenario`
- `private Boolean _isRealTimeMultiplayer`
- `private Boolean _isTutorial`
- `private Boolean _isWorldScenario`
- `private Dictionary`2 _landingCraftsDamage`
- `private Int32 _lastPlayedUnitID`
- `private Int32 _lastUnitIDusingUnreachable`
- `private List`1 _listOfSonarSignals`
- `private List`1 _listOfUnitsWeCanKill`
- `private Boolean _manpowerSettingON`
- `private Int32 _mapSizeX`
- `private Int32 _mapSizeY`
- `private Int32 _maxUnitPurchaseAmount`
- `private List`1 _navalTransports`
- `private Tile _neighbour`
- `private Int32 _numberOfAlliedFighters`
- `private Int32 _numberOfDesertTiles`
- `private Int32 _numberOfEnemyAT`
- `private Int32 _numberOfEnemyFighters`
- `private Int32 _numberOfEnemyHeavyBombers`
- `private Int32 _numberOfEnemyLandMines`
- `private Int32 _numberOfEnemyLandVPs`
- `private Int32 _numberOfEnemyPlanes`
- `private Int32 _numberOfEnemyShips`
- `private Int32 _numberOfEnemySubmarines`
- `private Int32 _numberOfEnemyTanks`
- `private Int32 _numberOfEnemyTorpedoBombers`
- `private Int32 _numberOfEnemyVPs`
- `private Int32 _numberOfForestTiles`
- `private Int32 _numberOfHillsAndMountains`
- `private Int32 _numberOfOurAA`
- `private Int32 _numberOfOurAntitanks`
- `private Int32 _numberOfOurArmouredTrains`
- `private Int32 _numberOfOurArtillery`
- `private Int32 _numberOfOurATinfantry`
- `private Int32 _numberOfOurBombers`
- `private Int32 _numberOfOurCarriers`
- `private Int32 _numberOfOurCommanders`
- `private Int32 _numberOfOurDestroyers`
- `private Int32 _numberOfOurEngineers`
- `private Int32 _numberOfOurFighters`
- `private Int32 _numberOfOurInfantry`
- `private Int32 _numberOfOurLandingCrafts`
- `private Int32 _numberOfOurLaunchSites`
- `private Int32 _numberOfOurPlanes`
- `private Int32 _numberOfOurRadars`
- `private Int32 _numberOfOurShips`
- `private Int32 _numberOfOurSubmarines`
- `private Int32 _numberOfOurTanks`
- `private Int32 _numberOfRivers`
- `private Int32 _numberOfSeaTiles`
- `private List`1 _others`
- `private Int32 _our_money`
- `private Int32 _our_production`
- `private HashSet`1 _ourLandMassesIndexes`
- `private Single _ourPlanesToGroundUnitsRatio`
- `private Boolean _ownsEngineers`
- `private List`1 _paratroopersToEscort`
- `private Int32 _pathingCount`
- `private Int32 _playedSameUnitCount`
- `private Boolean _productionTakesTimeON`
- `private List`1 _purchasableUnits`
- `private AnimationCurve _purchase_curve`
- `private Int32 _purchasedUnits`
- `private Int32 _purchaseUnitsLoopCounter`
- `private List`1 _radarSignals`
- `private Int32 _randNumber`
- `private List`1 _reconUnits`
- `private HashSet`1 _scenariosWithLandingControl`
- `private Single _seaTilesPercentage`
- `private List`1 _ships`
- `private Tile _source`
- `private List`1 _stratBombers`
- `private List`1 _stratBombersCanAttack`
- `private Dictionary`2 _submarineDamage`
- `private List`1 _submarines`
- `private List`1 _tacticalBombers`
- `private List`1 _tacticalBombersCanAttack`
- `private TileGO _tileGOForAttack`
- `private TileGO _tileGOForMovement`
- `private Tile[,] _tiles`
- `private Int32 _totalMapSize`
- `private Boolean _upkeepSettingON`
- `private Dictionary`2 _VPdangerLevels`
- `private TileGO _VPGOfromNeighbourGoal`
- `private Single _warIncomeRatio`
- `private TextMeshProUGUI AIisPlaying_Text`
- `private GameObject leftUI_Panel`
- `private ReservePanelGO reservePanel`
- `private GameObject rightUI_Panel`
- `private GameObject rightUI_PaneliPad`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass198_0`
- `private class <CR_PlayAllUnits>d__193`
- `private class <CR_SyncAIPlayingBar>d__192`
- `private class RetreatTile`
- `private class RunTimes`
- `private class VPDangerData`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(AI), "PrivateMethodName", MethodType.Normal)]
class Patch_AI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(AI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## AirHeroes

### Public Methods

- `public static List`1 GetHeroes(String p_country)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(AirHeroes), "PrivateMethodName", MethodType.Normal)]
class Patch_AirHeroes_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(AirHeroes), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## AIWaitInstruction

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Single waitTime`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(AIWaitInstruction), "PrivateMethodName", MethodType.Normal)]
class Patch_AIWaitInstruction_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(AIWaitInstruction), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## AllowedRotations

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const AllowedRotations ALL`
- `public static const AllowedRotations LEFT_RIGHT`
- `public static const AllowedRotations NONE`
- `public static const AllowedRotations NOT_SETUP`
- `public Byte value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(AllowedRotations), "PrivateMethodName", MethodType.Normal)]
class Patch_AllowedRotations_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(AllowedRotations), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## AsleepStates

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const AsleepStates NONE`
- `public static const AsleepStates SKIP`
- `public static const AsleepStates SLEEP`
- `public Byte value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(AsleepStates), "PrivateMethodName", MethodType.Normal)]
class Patch_AsleepStates_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(AsleepStates), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## CameraGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Boolean IsWithinFOV(Vector3 p_worldPoint)`
- `public Void MoveCameraToPosition(Vector3 p_targetPosition)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void CheckKeyboardInput()`
- `private Void CheckMouseInput()`
- `private IEnumerator CR_LerpFromTo(Vector3 pos1, Vector3 pos2, Single duration)`
- `private IEnumerator CR_StartUnitsBlink()`
- `private Void JumpDownSideMap()`
- `private Void JumpLeftSideMap()`
- `private Void JumpRightSideMap()`
- `private Void JumpUpSideMap()`
- `private Void LimitPosition()`
- `private Void MoveCameraWithEdge()`
- `private Void Start()`
- `private Void StopUnitsBlink()`
- `private Void Update()`
- `private Void Zooming()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Camera cam`
- `public static CameraGO instance`
- `public Single limitXMINUS`
- `public Single limitXPLUS`
- `public Single limitYMINUS`
- `public Single limitYPLUS`
- `public Int32 maxZoom`
- `public Int32 minZoom`
- `public Single targetZoom`
- `public Single zoomFactor`
- `public Single zoomLerpSpeed`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private AnimationCurve _camSize_height`
- `private AnimationCurve _camSize_width`
- `private Boolean _isCRrunning`
- `private Single _maxMapSize`
- `private Single _maxZoomLevel`
- `private Single _minMapSize`
- `private Single _minZoomLevel`
- `private Vector2 _mouseClickPos`
- `private Vector2 _mouseCurrentPos`
- `private Boolean _panning`
- `private Vector3 _prevCamPos`
- `private Single _prevZoomValue`
- `private Boolean _retablishCamPos`
- `private Single _totalDistanceMoved`
- `private Single _totalZoom`
- `private Single camsize`
- `private Single camSpeed`
- `private Single camSpeedMultiplier`

### Nested Types

- `private class <CR_LerpFromTo>d__45`
- `private class <CR_StartUnitsBlink>d__37`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(CameraGO), "PrivateMethodName", MethodType.Normal)]
class Patch_CameraGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(CameraGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## CampaignMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void CloseCampaignPanel()`
- `public Void SelectCountry_Toggle(String p_country)`
- `public Void SelectDate_Toggle(String p_date)`
- `public Void SelectFront_Toggle(String p_front)`
- `public Void StartNewCampaign()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void RefreshIronMan()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject achievement`
- `public Toggle[] countries_Toggles`
- `public Toggle[] dates_Toggles`
- `public Toggle[] fronts_Toggles`
- `public static Boolean isNewCampaign`
- `public Image map_Image`
- `public GameObject NOironman`
- `public TextMeshProUGUI scenarioName_Text`
- `public String selectedCountry`
- `public String selectedDate`
- `public String selectedFront`
- `public GameObject startCampaignButton`
- `public GameObject YESironman`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(CampaignMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_CampaignMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(CampaignMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## CanvasRescaler

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void RescaleCanvases()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private CanvasScaler[] _canvasScalers`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(CanvasRescaler), "PrivateMethodName", MethodType.Normal)]
class Patch_CanvasRescaler_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(CanvasRescaler), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ChartAndGraph.SelectScene

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Select(String scene)`
- `public Void SelectMain()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void ChangeCanvas()`
- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Canvas BackCanvas`
- `public Button ButtonPrefab`
- `public GameObject EventSystem`
- `public GameObject MainCamera`
- `public Canvas MainCanvas`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private String[] Buttons`

### Nested Types

- `private class <>c__DisplayClass6_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SelectScene), "PrivateMethodName", MethodType.Normal)]
class Patch_SelectScene_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SelectScene), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ChatMessageData

### Public Methods

- `public String GenerateMessageContentForUIDisplay()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String content`
- `public String hardwareID`
- `public String senderNickname`
- `public String timeSent`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ChatMessageData), "PrivateMethodName", MethodType.Normal)]
class Patch_ChatMessageData_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ChatMessageData), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## CheckTypes

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const CheckTypes ALLIANCE_MADE`
- `public static const CheckTypes DATE`
- `public static const CheckTypes NONE`
- `public static const CheckTypes TURN_COUNT`
- `public static const CheckTypes UNIT_DESTROYED`
- `public Int32 value__`
- `public static const CheckTypes VP_LOSS`
- `public static const CheckTypes VPS_LOSSES`
- `public static const CheckTypes VPS_LOSSES_ONE_OF`
- `public static const CheckTypes WAR_DECLARATION`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(CheckTypes), "PrivateMethodName", MethodType.Normal)]
class Patch_CheckTypes_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(CheckTypes), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ClickableMessage

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerClick(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Boolean ContainsLink(String p_message)`
- `private Void FormatLink()`
- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private String _linkColorHex`
- `private TextMeshProUGUI _text`

### Nested Types

- `private class <>c__DisplayClass4_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ClickableMessage), "PrivateMethodName", MethodType.Normal)]
class Patch_ClickableMessage_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ClickableMessage), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Cloud

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ProcessUpdate(Single p_opacity)`
- `public Void Setup()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Int32 cloudScale`
- `public Single cloudSpeedMax`
- `public Single cloudSpeedMin`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Transform _cachedTransform`
- `private Single _cloudSpeed`
- `private Vector3 _currPos`
- `private Color _prevColor`
- `private SpriteRenderer _spriteRenderer`
- `private Single _xLimit`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Cloud), "PrivateMethodName", MethodType.Normal)]
class Patch_Cloud_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Cloud), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## CloudManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void DeregisterCloud(Cloud p_cloud)`
- `public Void RegisterCloud(Cloud p_cloud)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private IEnumerator CR_SpawnClouds()`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void SpawnCloudsOnStart()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static CloudManager instance`
- `public Int32 timeMaxBetweenSpawn`
- `public Int32 timeMinBetweenSpawn`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Camera _camera`
- `private Transform _cloudParent`
- `private GameObject _cloudParentObject`
- `private Cloud _cloudPrefab`
- `private List`1 _clouds`
- `private List`1 _cloudsAdditions`
- `private Single _cloudShowLimitCamSize`
- `private List`1 _cloudsRemovals`
- `private Boolean _disabled`
- `private Int32 _mapSize`
- `private Single _maxX`
- `private Single _maxY`
- `private AnimationCurve _opacityCurve`
- `private Random _random`

### Nested Types

- `private class <CR_SpawnClouds>d__25`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(CloudManager), "PrivateMethodName", MethodType.Normal)]
class Patch_CloudManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(CloudManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ConfirmationWindowGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public TextMeshProUGUI description_text`
- `public Button no_button`
- `public Button yes_button`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ConfirmationWindowGO), "PrivateMethodName", MethodType.Normal)]
class Patch_ConfirmationWindowGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ConfirmationWindowGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ConnectedPlayerSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AddFriend()`
- `public Void OnPointerClick(PointerEventData eventData)`
- `public Void RemoveFriend()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void LateUpdate()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject addFriend_gameobject`
- `public TextMeshProUGUI nickname_text`
- `public Image status_image`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ConnectedPlayerSlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_ConnectedPlayerSlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ConnectedPlayerSlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Coordinates

**Base Class:** `System.ValueType`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Int16 posX`
- `public Int16 posY`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Coordinates), "PrivateMethodName", MethodType.Normal)]
class Patch_Coordinates_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Coordinates), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## CountryEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AddCountryToList()`
- `public Void CreateNewCountry()`
- `public Void GenerateCountriesList()`
- `public Void RefreshCountryList()`
- `public Void RemoveCountry()`
- `public Void SaveAll()`
- `public Void SelectCountry(String country)`
- `public Void SelectModToEdit()`
- `public Void SetCountryName()`
- `public Void ShowCountryName(String p_countryName)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Transform parentListOfCountries`
- `public GameObject selectedCountry_Panel`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Button _add_Button`
- `private TMP_InputField _countryName_Inputfield`
- `private GameObject _countrySlot_prefab`
- `private Button _delete_Button`
- `private TMP_Dropdown _mods_Dropdown`
- `private String _selectedCountry`

### Nested Types

- `private class <>c__DisplayClass13_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(CountryEditor), "PrivateMethodName", MethodType.Normal)]
class Patch_CountryEditor_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(CountryEditor), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## CustomCountries

### Public Methods

- `public Void CreateFileBaseMod(String p_path)`
- `public Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public List`1 ListOfCustomCountries` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String fileLocation`
- `public static const String FILENAME`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 <ListOfCustomCountries>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(CustomCountries), "PrivateMethodName", MethodType.Normal)]
class Patch_CustomCountries_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(CustomCountries), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## CustomTiles

### Public Methods

- `public Void CreateFileBaseMod(String path)`
- `public Void Load()`
- `public Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public List`1 ListOfCustomTiles` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String fileLocation`
- `public static const String FILENAME`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 <ListOfCustomTiles>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(CustomTiles), "PrivateMethodName", MethodType.Normal)]
class Patch_CustomTiles_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(CustomTiles), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## CustomUnits

### Public Methods

- `public Void CreateFileBaseMod(String path)`
- `public Void PatchInvalidData()`
- `public Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public List`1 ListOfCustomUnits` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String fileLocation`
- `public static const String FILENAME`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 <ListOfCustomUnits>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(CustomUnits), "PrivateMethodName", MethodType.Normal)]
class Patch_CustomUnits_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(CustomUnits), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## DamageTextGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Animate()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Disappear()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public TextMeshPro text`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(DamageTextGO), "PrivateMethodName", MethodType.Normal)]
class Patch_DamageTextGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(DamageTextGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## DamageTypes

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const DamageTypes AIR`
- `public static const DamageTypes HARD`
- `public static const DamageTypes NONE`
- `public static const DamageTypes SOFT`
- `public Byte value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(DamageTypes), "PrivateMethodName", MethodType.Normal)]
class Patch_DamageTypes_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(DamageTypes), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Database

**Modifiers:** `static`

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public static UnitModification atomBombOption` { get }
- `public static UnitModification bombsOption` { get }
- `public static List`1 Countries` { get }
- `public static UnitModification dropTankOption` { get }
- `public static UnitModification horseTowedOption` { get }
- `public static HashSet`1 Majors` { get }
- `public static UnitModification mechanizedOption` { get }
- `public static HashSet`1 Minors` { get }
- `public static UnitModification motorizedOption` { get }
- `public static UnitModification mountaineersOption` { get }
- `public static HashSet`1 NavalMajors` { get }
- `public static HashSet`1 NavalMinors` { get }
- `public static UnitModification planeTransportOption` { get }
- `public static UnitModification politicalOption` { get }
- `public static UnitModification rocketsOption` { get }
- `public static UnitModification shipTransportOption` { get }
- `public static UnitModification torpedoOption` { get }
- `public static UnitModification trainTransportOption` { get }
- `public static UnitModification winterTrainedOption` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static Int32 AtomBombCost`
- `public static Int32 bombCost`
- `public static Int32 dropTankCost`
- `public static List`1 factions`
- `public static Int32 horseCost`
- `public static List`1 ideologies`
- `public static Int32 mechanizeCost`
- `public static Int32 motorizeCost`
- `public static Int32 mountaineerCost`
- `public static List`1 NATOtypes`
- `public static Int32 politicalUnitCost`
- `public static Int32 rocketsCost`
- `public static List`1 seasons`
- `public static Int32 torpedoCost`
- `public static List`1 unitFilters`
- `public static List`1 unitTypes`
- `public static Int32 veteranUnitCost`
- `public static Int32 winterCost`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Database), "PrivateMethodName", MethodType.Normal)]
class Patch_Database_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Database), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## DataMigrator

**Modifiers:** `static`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private static Void CopyRecursive(String sourceDir, String destDir)`
- `private static Void MigrateLegacyInstallLocation()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private static readonly String[] OldCompanyNames`

### Nested Types

- `private class <>c__DisplayClass1_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(DataMigrator), "PrivateMethodName", MethodType.Normal)]
class Patch_DataMigrator_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(DataMigrator), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## DentedPixel.LeanDummy

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanDummy), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanDummy_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanDummy), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## DeploySlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void SetUpSlot()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Image atomBomb_image`
- `public Image background_image`
- `public Image bomb_image`
- `public Sprite censoredSS_sprite`
- `public Button delete_button`
- `public Image dropTank_image`
- `public Image flamethrower_image`
- `public Sprite guards_sprite`
- `public Image horse_image`
- `public TextMeshProUGUI HP_text`
- `public Image level_image`
- `public Image mechanize_image`
- `public Image mountaineer_image`
- `public Image navalAircraft_image`
- `public Image political_image`
- `public Image productionTakesTime_image`
- `public TextMeshProUGUI productionTime_text`
- `public Image recon_image`
- `public Image representation_image`
- `public Image rocket_image`
- `public Image seaplane_image`
- `public Button slot_button`
- `public Sprite SS_sprite`
- `public Image torpedo_image`
- `public Button transfer_button`
- `public Image truck_image`
- `public Unit unit`
- `public TextMeshProUGUI unitName_text`
- `public Button upgrade_button`
- `public Image veteran`
- `public Image winter_image`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private ColorBlock _colorBlock`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(DeploySlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_DeploySlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(DeploySlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## DiplomacyGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ClosePanel()`
- `public Void CreateFaction()`
- `public Void InviteToAlliance(DiplomacySlotGO p_diplomacySlotGO)`
- `public Void JoinFaction()`
- `public Void KickFromFaction(DiplomacySlotGO p_diplomacySlotGO)`
- `public Void ManageCreateFactionPanel()`
- `public Void ManageRelations(DiplomacySlotGO p_diplomacySlotGO)`
- `public Void SendMoney(DiplomacySlotGO p_diplomacySlotGO)`
- `public Void TransferVP_Button()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void ConfirmJoinFaction()`
- `private Void DeclareWarConfirmation()`
- `private Void InviteToAllianceConfirmation()`
- `private Void MakePeaceConfirmation()`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void RefreshDiplomacy()`
- `private Void SendMoneyTo(String p_playerName, Int32 p_amount)`
- `private Void Start()`
- `private Void SwapPlayerConfiguration(Player p_player)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button createFaction_button`
- `public GameObject createFactionPanel`
- `public DiplomacySlotGO diplomacySlotPrefab`
- `public GameObject diplomacyTooltip`
- `public TMP_Dropdown existingFactions_dropdown`
- `public TMP_InputField factionNameInputfield`
- `public static DiplomacyGO instance`
- `public Transform parent`
- `public Transform tooltip_alliances_parent`
- `public Transform tooltip_atWar_parent`
- `public TextMeshProUGUI tooltip_country_text`
- `public Transform tooltip_truces_parent`
- `public GameObject tooltipCountryPrefab`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private GameObject _confirmationWindow`
- `private List`1 _diplomacySlotsGO`
- `private List`1 _existingFactions`
- `private Int32 _factionChangeCost`
- `private String _factionTarget`
- `private Int32 _moneyNeeded`
- `private Player _targetPlayer`

### Nested Types

- `private class <>c__DisplayClass30_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(DiplomacyGO), "PrivateMethodName", MethodType.Normal)]
class Patch_DiplomacyGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(DiplomacyGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## DiplomacySlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void SetUpDiplomacySlot(Player p_player)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button inviteToAlliance_button`
- `public Button kick_button`
- `public Player player`
- `public Button sendMoney_button`
- `public TMP_InputField sendMoney_inputfield`
- `public Button status_button`
- `public Button swapPlayerConfiguration_button`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Sprite _AI_sprite`
- `private Sprite _human_sprite`
- `private Color allied_color`
- `private Image country_image`
- `private TextMeshProUGUI countryName_text`
- `private Color currentPlayer_color`
- `private Color enemy_color`
- `private TextMeshProUGUI faction_text`
- `private TextMeshProUGUI ideology_text`
- `private Transform money_parent`
- `private Color normal_color`
- `private Sprite peace_sprite`
- `private Image playerSwapConfiguration_image`
- `private Image status_image`
- `private Sprite war_sprite`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(DiplomacySlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_DiplomacySlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(DiplomacySlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## DiplomacyTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void LateUpdate()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private Player _player`
- `private Boolean _rebuildCanvas`
- `private Boolean _rebuiltCanvas`
- `private GameObject _tooltip`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(DiplomacyTooltipGO), "PrivateMethodName", MethodType.Normal)]
class Patch_DiplomacyTooltipGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(DiplomacyTooltipGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## DrawingManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Boolean AreSegmentsIntersecting(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)`
- `public Void DecreaseWidth()`
- `public Void IncreaseWidth()`
- `public Boolean IsErasingOrDrawing()`
- `public Void SetDrawMode()`
- `public Void SetEraseMode()`
- `public Void SpawnLinesForPlayer(Player p_player)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void CheckEraserIntersection(Vector2 p_mousePosition)`
- `private Single CrossProduct2D(Vector2 a, Vector2 b)`
- `private Void RemovePreviousLine()`
- `private Void Start()`
- `private Void StartDrawing()`
- `private Void StartErasing()`
- `private Void StopDrawing()`
- `private Void StopErasing()`
- `private Void Update()`
- `private Void UpdateButtonsColors()`
- `private Void UpdateDrawing()`
- `private Void UpdateErasing()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static DrawingManager instance`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Line _activeLine`
- `private Camera _camera`
- `private Color _color`
- `private GameObject _contentPanel`
- `private Button _draw_button`
- `private Button _erase_button`
- `private List`1 _erasingPath`
- `private FlexibleColorPicker _flexibleColorPicker`
- `private Line _line_prefab`
- `private Transform _parent`
- `private Transform _parent_panel`
- `private Boolean _processDrawing`
- `private Boolean _processErasing`
- `private List`1 _spawnedLines`
- `private Single _width`
- `private TextMeshProUGUI _width_text`
- `private static const Single MIN_DISTANCE_THRESHOLD`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(DrawingManager), "PrivateMethodName", MethodType.Normal)]
class Patch_DrawingManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(DrawingManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## EndGameResults

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const EndGameResults DEFEAT`
- `public Int32 value__`
- `public static const EndGameResults VICTORY`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(EndGameResults), "PrivateMethodName", MethodType.Normal)]
class Patch_EndGameResults_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(EndGameResults), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Event

### Public Methods

- `public Boolean AreAllVPsOccupied(Map p_map, Tile p_tile, Player p_playerCapturing)`
- `public Event Clone()`
- `public Boolean FullyProcessed()`
- `public Boolean IsEventReady(Boolean p_includingActions)`
- `public Boolean IsValidForLossTrigger(Tile p_tile)`
- `public Void RemoveExecution()`
- `public Void SetCheckType(CheckTypes p_checkType)`
- `public Void SetDefaultName()`
- `public static String TranslateEventCheck(CheckTypes p_checkType)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*


### Public Properties

- `public Boolean AIonly` { get; set }
- `public Int32 Chance` { get; set }
- `public DateTime CheckDate` { get; set }
- `public Int16 CheckTileCoordinateX` { get; set }
- `public Int16 CheckTileCoordinateY` { get; set }
- `public Int16 CheckTurnCount` { get; set }
- `public CheckTypes CheckType` { get; set }
- `public Int32 CheckUnitID` { get; set }
- `public DateTime DontCheckBeforeDate` { get; set }
- `public Int16 DontCheckBeforeTurnCount` { get; set }
- `public List`1 EventActions` { get; set }
- `public Int32 ExecutionsLeft` { get; set }
- `public Boolean ForceHumanApplyEvent` { get; set }
- `public String Group` { get; set }
- `public Boolean HistoricalFocusOnly` { get; set }
- `public Boolean HumansOnly` { get; set }
- `public Int32 ID` { get; set }
- `public String MasterPlayer` { get; set }
- `public Int32 MaxExecutions` { get; set }
- `public String Name` { get; set }
- `public String Player1Check` { get; set }
- `public String Player2Check` { get; set }
- `public Boolean TurnBasedEvent` { get; set }
- `public List`1 VPsToBeLost` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean <AIonly>k__BackingField`
- `private Int32 <Chance>k__BackingField`
- `private DateTime <CheckDate>k__BackingField`
- `private Int16 <CheckTileCoordinateX>k__BackingField`
- `private Int16 <CheckTileCoordinateY>k__BackingField`
- `private Int16 <CheckTurnCount>k__BackingField`
- `private CheckTypes <CheckType>k__BackingField`
- `private Int32 <CheckUnitID>k__BackingField`
- `private DateTime <DontCheckBeforeDate>k__BackingField`
- `private Int16 <DontCheckBeforeTurnCount>k__BackingField`
- `private List`1 <EventActions>k__BackingField`
- `private Int32 <ExecutionsLeft>k__BackingField`
- `private Boolean <ForceHumanApplyEvent>k__BackingField`
- `private String <Group>k__BackingField`
- `private Boolean <HistoricalFocusOnly>k__BackingField`
- `private Boolean <HumansOnly>k__BackingField`
- `private Int32 <ID>k__BackingField`
- `private String <MasterPlayer>k__BackingField`
- `private Int32 <MaxExecutions>k__BackingField`
- `private String <Name>k__BackingField`
- `private String <Player1Check>k__BackingField`
- `private String <Player2Check>k__BackingField`
- `private Boolean <TurnBasedEvent>k__BackingField`
- `private List`1 <VPsToBeLost>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Event), "PrivateMethodName", MethodType.Normal)]
class Patch_Event_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Event), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## EventAction

### Public Methods

- `public EventAction Clone()`
- `public Boolean IsActionSetup()`
- `public Void Process()`
- `public Void ResetProcess()`
- `public static String TranslateEventAction(ActionTypes p_actionType)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public String CityName` { get; set }
- `public Int16 HQPointsAmount` { get; set }
- `public String MessageText` { get; set }
- `public Int32 MoneyAmount` { get; set }
- `public Boolean OriginalOwnerOnly` { get; set }
- `public Byte PlayerIndex` { get; set }
- `public Int32 PosX` { get; set }
- `public Int32 PosY` { get; set }
- `public Boolean Processed` { get; set }
- `public String TargetCountryName` { get; set }
- `public String TargetFactionName` { get; set }
- `public String TargetIdeology` { get; set }
- `public String TargetPlayerName1` { get; set }
- `public String TargetPlayerName2` { get; set }
- `public String TileName` { get; set }
- `public String TileSeason` { get; set }
- `public ActionTypes Type` { get; set }
- `public Unit Unit` { get; set }
- `public String UnitCountry` { get; set }
- `public Byte UnitLevel` { get; set }
- `public String UnitName` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private String <CityName>k__BackingField`
- `private Int16 <HQPointsAmount>k__BackingField`
- `private String <MessageText>k__BackingField`
- `private Int32 <MoneyAmount>k__BackingField`
- `private Boolean <OriginalOwnerOnly>k__BackingField`
- `private Byte <PlayerIndex>k__BackingField`
- `private Int32 <PosX>k__BackingField`
- `private Int32 <PosY>k__BackingField`
- `private Boolean <Processed>k__BackingField`
- `private String <TargetCountryName>k__BackingField`
- `private String <TargetFactionName>k__BackingField`
- `private String <TargetIdeology>k__BackingField`
- `private String <TargetPlayerName1>k__BackingField`
- `private String <TargetPlayerName2>k__BackingField`
- `private String <TileName>k__BackingField`
- `private String <TileSeason>k__BackingField`
- `private ActionTypes <Type>k__BackingField`
- `private Unit <Unit>k__BackingField`
- `private String <UnitCountry>k__BackingField`
- `private Byte <UnitLevel>k__BackingField`
- `private String <UnitName>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(EventAction), "PrivateMethodName", MethodType.Normal)]
class Patch_EventAction_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(EventAction), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## EventActionSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void CloneAction_Button()`
- `public Void DeleteAction_Button()`
- `public EventAction GetEventAction()`
- `public Void OnBoughtUnit()`
- `public Void SetActionType()`
- `public Void SetCheckOriginalOwner()`
- `public Void SetCityName()`
- `public Void SetEventPosXSpawnUnit()`
- `public Void SetEventPosYSpawnUnit()`
- `public Void SetEventSeason()`
- `public Void SetEventTile()`
- `public Void SetEventUnit()`
- `public Void SetEventUnitCountry()`
- `public Void SetHQpointsAmount()`
- `public Void SetMoneyAmount()`
- `public Void SetNewPlayerCountry()`
- `public Void SetPlayerIndex()`
- `public Void SetPlayerTarget1()`
- `public Void SetPlayerTarget2()`
- `public Void SetTargetCountry()`
- `public Void SetTargetFaction()`
- `public Void SetTargetIdeology()`
- `public Void SetTextMessage()`
- `public Void SetUnit()`
- `public Void SetUnitLevel()`
- `public Void Setup(Event p_event, EventAction p_eventAction)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void RefreshAllValues()`
- `private Void RefreshDropdownsOptions()`
- `private Void RefreshPossibilities()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 _availableScenariosCountries`
- `private Event _event`
- `private EventAction _eventAction`
- `private TMP_Dropdown actionType_dropdown`
- `private TMP_Dropdown allCountries_dropdown`
- `private Toggle checkOriginalOwner_toggle`
- `private TMP_InputField cityName_inputfield`
- `private TMP_Dropdown countriesUnit_dropdown`
- `private TMP_InputField HQpoints_inputfield`
- `private TMP_InputField moneyAmount_inputfield`
- `private TMP_InputField playerIndex_inputfield`
- `private TMP_Dropdown playerTarget1_dropdown`
- `private TMP_Dropdown playerTarget2_dropdown`
- `private TMP_InputField posX_inputfield`
- `private TMP_InputField posY_inputfield`
- `private TMP_Dropdown season_dropdown`
- `private TMP_InputField targetCountryChange_inputfield`
- `private TMP_InputField targetFaction_inputfield`
- `private TMP_InputField targetIdeology_inputfield`
- `private TMP_InputField textMessage_inputfield`
- `private TMP_Dropdown tiles_dropdown`
- `private Button unit_button`
- `private TMP_InputField unitLevel_inputfield`
- `private TMP_InputField unitName_inputfield`
- `private TMP_Dropdown units_dropdown`

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(EventActionSlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_EventActionSlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(EventActionSlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## EventData

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Player playerCapturing`
- `public Player playerLosing`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(EventData), "PrivateMethodName", MethodType.Normal)]
class Patch_EventData_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(EventData), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## EventListSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button clone_button`
- `public Button delete_button`
- `public TextMeshProUGUI eventName_text`
- `public Button select_button`
- `public Image warning_image`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(EventListSlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_EventListSlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(EventListSlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## EventPanelGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AddAction_Button()`
- `public Void AddEvent_Button()`
- `public Void AddEventVPLosses()`
- `public Void CloneEvent()`
- `public Void CloneEvent_Button(Event p_event)`
- `public Void Close()`
- `public Void DeleteEvent()`
- `public Void DeleteEvent_Button(Event p_event)`
- `public Void Open()`
- `public Void RefreshActions()`
- `public Void RefreshEventList()`
- `public Void RemoveEventVPLosses()`
- `public Void SelectEvent(Event p_event)`
- `public Void SetAIOnlyEvent()`
- `public Void SetEventChance()`
- `public Void SetEventCheckDay()`
- `public Void SetEventCheckMonth()`
- `public Void SetEventCheckPosXSpawnUnitVPLoss()`
- `public Void SetEventCheckPosYSpawnUnitVPLoss()`
- `public Void SetEventCheckTurn()`
- `public Void SetEventCheckType()`
- `public Void SetEventCheckUnitID()`
- `public Void SetEventCheckYear()`
- `public Void SetEventGroup()`
- `public Void SetEventHistoricalFocusOnly()`
- `public Void SetEventMasterPlayer()`
- `public Void SetEventMaxExecutions()`
- `public Void SetEventName()`
- `public Void SetEventNotBeforeDateDay()`
- `public Void SetEventNotBeforeDateMonth()`
- `public Void SetEventNotBeforeDateYear()`
- `public Void SetEventNotBeforeTurn()`
- `public Void SetEventPlayer1ActionCheck()`
- `public Void SetEventPlayer2ActionCheck()`
- `public Void SetForceHumanApplyEvent()`
- `public Void SetHumanOnlyEvent()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void OnEnable()`
- `private Void RefreshSelectedEventInfos()`
- `private Void RefreshVPsToBeLostDropdown()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static EventPanelGO instance`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Transform _actionList_parent`
- `private List`1 _availableScenariosCountries`
- `private EventActionSlotGO _eventActionSlot_prefab`
- `private Transform _eventList_parent`
- `private EventListSlotGO _eventListSlot_prefab`
- `private GameObject _notBeforeDateBox`
- `private TMP_InputField _notBeforeDateDay_inputfield`
- `private TMP_InputField _notBeforeDateMonth_inputfield`
- `private TMP_InputField _notBeforeDateYear_inputfield`
- `private TMP_InputField _notBeforeTurn_inputfield`
- `private GameObject _notBeforeTurnBox`
- `private Event _selectedEvent`
- `private GameObject _selectedEventStats`
- `private GameObject _separator_prefab`
- `private Button addVPLoss_button`
- `private Toggle AIonlyEvent_toggle`
- `private TMP_InputField chance_inputfield`
- `private TMP_Dropdown checkType_dropdown`
- `private TMP_InputField day_inputfield`
- `private TMP_InputField eventName_inputfield`
- `private TMP_InputField executions_inputfield`
- `private Toggle forceHumanApplyEvent_toggle`
- `private TMP_Dropdown group_dropdown`
- `private Toggle historicalFocus_toggle`
- `private Toggle humanOnlyEvent_toggle`
- `private TMP_Dropdown masterPlayer_dropdown`
- `private TMP_InputField month_inputfield`
- `private TMP_Dropdown player1check_dropdown`
- `private TMP_Dropdown player2check_dropdown`
- `private TMP_InputField posX_inputfield`
- `private TMP_InputField posY_inputfield`
- `private Button removeVPLoss_button`
- `private TMP_InputField turn_inputfield`
- `private TMP_InputField unitID_inputfield`
- `private TMP_Dropdown VPsToBeLost_dropdown`
- `private TMP_InputField year_inputfield`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass43_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(EventPanelGO), "PrivateMethodName", MethodType.Normal)]
class Patch_EventPanelGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(EventPanelGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Explosion

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Animator Animator`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Explosion), "PrivateMethodName", MethodType.Normal)]
class Patch_Explosion_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Explosion), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## FacingRotations

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const FacingRotations EAST`
- `public static const FacingRotations NORTH`
- `public static const FacingRotations NORTH_EAST`
- `public static const FacingRotations NORTH_WEST`
- `public static const FacingRotations SOUTH`
- `public static const FacingRotations SOUTH_EAST`
- `public static const FacingRotations SOUTH_WEST`
- `public Byte value__`
- `public static const FacingRotations WEST`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(FacingRotations), "PrivateMethodName", MethodType.Normal)]
class Patch_FacingRotations_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(FacingRotations), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## FadeTileGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void StartFade(TileGO p_tileGO)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private IEnumerator CR_Fade()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Single _fadeTime`
- `private SpriteRenderer _spriteRenderer`

### Nested Types

- `private class <CR_Fade>d__3`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(FadeTileGO), "PrivateMethodName", MethodType.Normal)]
class Patch_FadeTileGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(FadeTileGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## FCP_Persistence

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Boolean LoadColor(Color& c)`
- `public Void SaveColor(Color c)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private static String GenerateID()`
- `private Void InitStatic()`
- `private Void LoadDataFile()`
- `private Void OnDestroy()`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void SaveDataFile()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String saveName`
- `public SaveStrategy saveStrategy`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private FlexibleColorPicker fcp`
- `private static Dictionary`2 savedColors`
- `private static Boolean saveFileLoaded`
- `private static Boolean saveFileOutdated`
- `private static String saveFilePath`

### Nested Types

- `public class SaveStrategy`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(FCP_Persistence), "PrivateMethodName", MethodType.Normal)]
class Patch_FCP_Persistence_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(FCP_Persistence), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## FCP_SpriteMeshEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Int32 GetSettingHash()`
- `private Void MakeMesh(Sprite sprite, Int32 x, Int32 y, MeshType meshtype)`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public MeshType meshType`
- `public Sprite sprite`
- `public Int32 x`
- `public Int32 y`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Int32 bufferedHash`

### Nested Types

- `public class MeshType`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(FCP_SpriteMeshEditor), "PrivateMethodName", MethodType.Normal)]
class Patch_FCP_SpriteMeshEditor_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(FCP_SpriteMeshEditor), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## FlexibleColorPicker

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ChangeMode(Int32 newMode)`
- `public Void ChangeMode(MainPickingMode mode)`
- `public Void FinishTypeHex(String input)`
- `public Color GetColor()`
- `public Color GetColorFullAlpha()`
- `public static String GetSanitizedHex(String input, Boolean full)`
- `public static Color HSVToRGB(Vector3 hsv)`
- `public static Color HSVToRGB(Single h, Single s, Single v)`
- `public static Color ParseHex(String input)`
- `public static Color ParseHex(String input, Color defaultColor)`
- `public Void PointerUpdate(BaseEventData e)`
- `public static Vector3 RGBToHSV(Color color)`
- `public static Vector3 RGBToHSV(Single r, Single g, Single b)`
- `public Void SetColor(Color color)`
- `public Void SetColorNoAlpha(Color color)`
- `public Void SetPointerFocus(Int32 i)`
- `public Void ShiftColor(Int32 type, Single delta)`
- `public Void ShiftHue(Single delta)`
- `public Void TypeHex(String input)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Int32 GetGradientMode(PickerType type)`
- `private RectTransform GetMarker(Image picker, String search)`
- `private static Vector2 GetNormalizedPointerPosition(Canvas canvas, RectTransform rect, BaseEventData e)`
- `private static Vector2 GetNormScreenSpace(RectTransform rect, BaseEventData e)`
- `private static Vector2 GetNormWorldSpace(Canvas canvas, RectTransform rect, BaseEventData e)`
- `private Vector2 GetValue(PickerType type)`
- `private Vector2 GetValue(MainPickingMode mode)`
- `private Single GetValue1D(PickerType type)`
- `private static Boolean IsAlphaType(PickerType type)`
- `private static Boolean IsHorizontal(Picker p)`
- `private Boolean IsPickerAvailable(PickerType type)`
- `private Boolean IsPickerAvailable(Int32 index)`
- `private static Boolean IsPreviewType(PickerType type)`
- `private static Boolean IsValidHexChar(Char c)`
- `private Void MakeModeOptions()`
- `private Void OnEnable()`
- `private BufferedColor PickColor(BufferedColor color, PickerType type, Vector2 v)`
- `private BufferedColor PickColor1D(BufferedColor color, PickerType type, Vector2 v)`
- `private BufferedColor PickColor1D(BufferedColor color, PickerType type, Single value)`
- `private BufferedColor PickColor2D(BufferedColor color, PickerType type1, Single value1, PickerType type2, Single value2)`
- `private BufferedColor PickColorMain(BufferedColor color, Vector2 v)`
- `private BufferedColor PickColorMain(BufferedColor color, MainPickingMode mode, Vector2 v)`
- `private Void SeperateMaterials()`
- `private Void SetMarker(Image picker, Vector2 v, Boolean setX, Boolean setY)`
- `private Void TypeHex(String input, Boolean finish)`
- `private Void Update()`
- `private Void UpdateDynamic(PickerType type)`
- `private Void UpdateHex()`
- `private Void UpdateMarker(Picker picker, PickerType type, Vector2 v)`
- `private Void UpdateMarkers()`
- `private Void UpdateMode(MainPickingMode mode)`
- `private Void UpdateStatic(PickerType type)`
- `private Void UpdateTextures()`

### Public Properties

- `public Color color` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

- `private AdvancedSettings avs` { get }

### Public Fields

- `public AdvancedSettings advancedSettings`
- `public Boolean multiInstance`
- `public ColorUpdateEvent onColorChange`
- `public Boolean staticMode`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private BufferedColor bufferedColor`
- `private Canvas canvas`
- `private Picker focusedPicker`
- `private PickerType focusedPickerType`
- `private InputField hexInput`
- `private static const Single HUE_LOOP`
- `private MainPickingMode lastUpdatedMode`
- `private Boolean materialsSeperated`
- `private MainPickingMode mode`
- `private Dropdown modeDropdown`
- `private Picker[] pickers`
- `private static const String SHADER_C1`
- `private static const String SHADER_C2`
- `private static const String SHADER_DOUBLE_MODE`
- `private static const String SHADER_HSV`
- `private static const String SHADER_HSV_MAX`
- `private static const String SHADER_HSV_MIN`
- `private static const String SHADER_MODE`
- `private Color startingColor`
- `private Sprite[] staticSpriteMain`
- `private Boolean triggeredStaticMode`
- `private Boolean typeUpdate`

### Nested Types

- `public class AdvancedSettings`
- `private class BufferedColor`
- `public class ColorUpdateEvent`
- `public class MainPickingMode`
- `private class Picker`
- `private class PickerType`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(FlexibleColorPicker), "PrivateMethodName", MethodType.Normal)]
class Patch_FlexibleColorPicker_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(FlexibleColorPicker), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ForecastType

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const ForecastType CURRENT`
- `public static const ForecastType FULL`
- `public static const ForecastType NEXT`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ForecastType), "PrivateMethodName", MethodType.Normal)]
class Patch_ForecastType_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ForecastType), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Game

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Int64 Appid` { get; set }
- `public Boolean HasCommunityVisibleStats` { get; set }
- `public String ImgIconUrl` { get; set }
- `public String ImgLogoUrl` { get; set }
- `public String Name` { get; set }
- `public Nullable`1 Playtime2Weeks` { get; set }
- `public Int64 PlaytimeForever` { get; set }
- `public Int64 PlaytimeLinuxForever` { get; set }
- `public Int64 PlaytimeMacForever` { get; set }
- `public Int64 PlaytimeWindowsForever` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Int64 <Appid>k__BackingField`
- `private Boolean <HasCommunityVisibleStats>k__BackingField`
- `private String <ImgIconUrl>k__BackingField`
- `private String <ImgLogoUrl>k__BackingField`
- `private String <Name>k__BackingField`
- `private Nullable`1 <Playtime2Weeks>k__BackingField`
- `private Int64 <PlaytimeForever>k__BackingField`
- `private Int64 <PlaytimeLinuxForever>k__BackingField`
- `private Int64 <PlaytimeMacForever>k__BackingField`
- `private Int64 <PlaytimeWindowsForever>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Game), "PrivateMethodName", MethodType.Normal)]
class Patch_Game_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Game), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## GameData

### Public Methods

- `public Void GenerateGameSettings(Boolean p_lockSaveFile)`
- `public Event GetEvent(Int32 p_ID)`
- `public Boolean IsIronManModeON(List`1& o_ironManOFFReasons)`
- `public Void Load(String p_filePath)`
- `public static Void SanitizeData(GameData p_gameData)`
- `public Void Save(FileInfo p_fileInfo)`
- `public Void SaveToCloud(String p_fileName)`
- `public Void SaveToMaps(String p_fileName)`
- `public Void SaveToSaves(String p_fileName)`
- `public Void SetData(GameData p_gameData)`
- `public Void SetIronManMode(Boolean p_value)`
- `public Boolean TryFindLocalPlayer(Player& o_localPlayer)`
- `public Boolean TryFindPlayerByCountry(String p_country, Player& o_player)`
- `public Boolean TryFindPlayerByName(String p_playerName, Player& o_player)`
- `public Boolean TryFindPlayerByNickname(String p_playerNickname, Player& o_player)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void SaveData(String p_fullPath)`
- `private Task SaveDataAsync(String p_fullPath)`

### Public Properties

- `public static GameData Instance` { get }
- `public ModPropertyBag ModDataBag` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Boolean endOfTurnPanelOpen`
- `public static const String EXTENSION_NAME`
- `public Boolean gameFinishedButContinue`
- `public GameSettings gameSettings`
- `public Boolean ironManMode`
- `public Boolean isFromMapEditor`
- `public List`1 listOfPlayers`
- `public Map map`
- `public List`1 messages`
- `public Boolean offlinePBEM`
- `public Int32 tutorialStep`
- `public Boolean violatedIronmanRule`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private static GameData _instance`
- `private ModPropertyBag _modDataBag`

### Nested Types

- `private class <>c__DisplayClass31_0`
- `private class <SaveDataAsync>d__31`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(GameData), "PrivateMethodName", MethodType.Normal)]
class Patch_GameData_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(GameData), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## GameLanguages

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const GameLanguages BR`
- `public static const GameLanguages CA`
- `public static const GameLanguages CNS`
- `public static const GameLanguages CNT`
- `public static const GameLanguages CZ`
- `public static const GameLanguages DE`
- `public static const GameLanguages EN`
- `public static const GameLanguages ES`
- `public static const GameLanguages FI`
- `public static const GameLanguages FR`
- `public static const GameLanguages GR`
- `public static const GameLanguages IT`
- `public static const GameLanguages JP`
- `public static const GameLanguages KR`
- `public static const GameLanguages NL`
- `public static const GameLanguages NO`
- `public static const GameLanguages PL`
- `public static const GameLanguages PT`
- `public static const GameLanguages RU`
- `public static const GameLanguages SE`
- `public static const GameLanguages TR`
- `public static const GameLanguages UA`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(GameLanguages), "PrivateMethodName", MethodType.Normal)]
class Patch_GameLanguages_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(GameLanguages), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## GameModification

**Modifiers:** `abstract`

### Public Methods

- `public virtual abstract Void OnModInitialization(Mod p_mod)`
- `public virtual abstract Void OnModUnloaded()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Mod mod`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(GameModification), "PrivateMethodName", MethodType.Normal)]
class Patch_GameModification_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(GameModification), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## GameResponse

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Response Response` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Response <Response>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(GameResponse), "PrivateMethodName", MethodType.Normal)]
class Patch_GameResponse_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(GameResponse), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## GameSettings

**Base Class:** `System.ValueType`

**Modifiers:** `sealed`

### Public Methods

- `public Void Backup()`
- `public Void LoadBackup()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Boolean complexSuppliesON`
- `public Boolean damageReductionRepeatedAttacks`
- `public Int32 difficultyValue`
- `public Boolean finiteManpower`
- `public Boolean fogOfWarON`
- `public Boolean historicalFocusON`
- `public Boolean infiniteAmmoAndFuelON`
- `public Boolean isBackup`
- `public Boolean manpowerON`
- `public Boolean moraleON`
- `public Boolean noAAsupportDuringAirFight`
- `public Boolean overrunON`
- `public Boolean partisansON`
- `public Boolean planeMoveAfterAttackON`
- `public Boolean policiesON`
- `public Boolean productionTakesTimeON`
- `public Boolean prototypesDisabled`
- `public Int32 randomDamageValue`
- `public Boolean realisticPlanesON`
- `public Boolean researchON`
- `public Boolean saveLocked`
- `public Boolean stricterFogOfWar`
- `public Boolean upkeepON`
- `public Boolean weatherON`
- `public Int32 winterDamageValue`
- `public Boolean zoneOfControlON`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(GameSettings), "PrivateMethodName", MethodType.Normal)]
class Patch_GameSettings_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(GameSettings), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## GameStates

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const GameStates DEFEAT`
- `public static const GameStates NOT_SETUP`
- `public static const GameStates ONGOING`
- `public static const GameStates TURN_LIMIT_REACHED`
- `public Int32 value__`
- `public static const GameStates VICTORY`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(GameStates), "PrivateMethodName", MethodType.Normal)]
class Patch_GameStates_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(GameStates), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## GraphPanelGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void GenerateBarChart(String p_statName)`
- `public Void GenerateGraphChart(String p_statName)`
- `public Void ManageGraphPanel()`
- `public Void SwitchGraphBarChart()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Sprite GetBackgroundForColour(String p_country)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Transform barChartGroup`
- `public Material baseGraph_material`
- `public Material baseGraphPoint_material`
- `public CanvasBarChart canvasBarChart`
- `public CategoryLabels categoryLabels`
- `public GraphChart graphChart`
- `public Transform graphChartGroup`
- `public GameObject graphPanel`
- `public TextMeshProUGUI graphTitle_text`
- `public static GraphPanelGO instance`
- `public ChartItemEffect lineOver`
- `public ChartItemEffect pointOver`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(GraphPanelGO), "PrivateMethodName", MethodType.Normal)]
class Patch_GraphPanelGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(GraphPanelGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## GroundHeroes

### Public Methods

- `public static List`1 GetHeroes(String p_country)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(GroundHeroes), "PrivateMethodName", MethodType.Normal)]
class Patch_GroundHeroes_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(GroundHeroes), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Hero

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Int16 AirDamageBonus` { get; set }
- `public String Country` { get; set }
- `public Int16 HardDamageBonus` { get; set }
- `public Byte MPBonus` { get; set }
- `public String Name` { get; set }
- `public Int16 SoftDamageBonus` { get; set }
- `public String Type` { get; set }
- `public Byte VisibilityBonus` { get; set }
- `public Int16 YearStartAvailability` { get; set }
- `public Int16 YearStopAvailability` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Int16 <AirDamageBonus>k__BackingField`
- `private String <Country>k__BackingField`
- `private Int16 <HardDamageBonus>k__BackingField`
- `private Byte <MPBonus>k__BackingField`
- `private String <Name>k__BackingField`
- `private Int16 <SoftDamageBonus>k__BackingField`
- `private String <Type>k__BackingField`
- `private Byte <VisibilityBonus>k__BackingField`
- `private Int16 <YearStartAvailability>k__BackingField`
- `private Int16 <YearStopAvailability>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Hero), "PrivateMethodName", MethodType.Normal)]
class Patch_Hero_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Hero), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## HeroBonusesGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject airDamageHero_Text`
- `public RectTransform canvas_RectTransform`
- `public GameObject hardDamageHero_Text`
- `public GameObject HeroBonus_Text`
- `public GameObject HeroBonuses_Panel`
- `public GameObject MPHero_Text`
- `public static Hero selectedHero`
- `public GameObject softDamageHero_Text`
- `public GameObject visibilityHero_Text`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(HeroBonusesGO), "PrivateMethodName", MethodType.Normal)]
class Patch_HeroBonusesGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(HeroBonusesGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## HeroesEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AddNewHero()`
- `public Void CreateHero()`
- `public Void GenerateHeroesSlots()`
- `public Void RefreshHeroesList()`
- `public Void RemoveHero()`
- `public Void SaveAll()`
- `public Void SelectHero(Hero p_hero)`
- `public Void SelectModToEdit()`
- `public Void SetHeroCountry()`
- `public Void SetHeroName()`
- `public Void SetHeroStartYear()`
- `public Void SetHeroStopYear()`
- `public Void SetHeroType()`
- `public Void ShowHeroStats()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Boolean AreConditionsOKtoAddNewHero()`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void SetDropDownValue(TMP_Dropdown p_dropdown, String p_value)`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button add_Button`
- `public Button delete_Button`
- `public TMP_Dropdown filterCountry_Dropdown`
- `public TMP_Dropdown filterType_Dropdown`
- `public Image hero_Image`
- `public TMP_Dropdown heroCountry_Dropdown`
- `public GameObject heroImagebackground`
- `public TMP_InputField heroName_inputfield`
- `public GameObject heroSlotPrefab`
- `public TMP_Dropdown heroType_Dropdown`
- `public TMP_InputField heroYearStart_inputfield`
- `public TMP_InputField heroYearStop_inputfield`
- `public TMP_Dropdown mods_Dropdown`
- `public Transform parentForListOfHeroes`
- `public TMP_InputField search_inputField`
- `public GameObject selectedHeroBackground`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Hero _selectedHero`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass20_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(HeroesEditor), "PrivateMethodName", MethodType.Normal)]
class Patch_HeroesEditor_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(HeroesEditor), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## HoverUnitUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Close()`
- `public Void Show(UnitGO p_unitGO)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TextMeshProUGUI _airAttack_text`
- `private TextMeshProUGUI _armour_text`
- `private TextMeshProUGUI _entrenchment_text`
- `private Image _flag_image`
- `private TextMeshProUGUI _hardAttack_text`
- `private TextMeshProUGUI _HP_text`
- `private Unit _prevUnit`
- `private TextMeshProUGUI _range_text`
- `private Image _rank_image`
- `private TextMeshProUGUI _softAttack_text`
- `private TextMeshProUGUI _supplies_text`
- `private TextMeshProUGUI _unitName_text`
- `private Image _unitTypeIcon_image`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(HoverUnitUI), "PrivateMethodName", MethodType.Normal)]
class Patch_HoverUnitUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(HoverUnitUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## IModProperty

**Modifiers:** `abstract`

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Object BoxedValue` { get }
- `public Type ValueType` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(IModProperty), "PrivateMethodName", MethodType.Normal)]
class Patch_IModProperty_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(IModProperty), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## IntegerInputfield

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void OnDestroy()`
- `private Void Start()`
- `private Char ValidateIntegerInput(String text, Int32 charIndex, Char addedChar)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TMP_InputField _inputField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(IntegerInputfield), "PrivateMethodName", MethodType.Normal)]
class Patch_IntegerInputfield_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(IntegerInputfield), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## InvalidIronManReasons

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const InvalidIronManReasons DIFFICULTY`
- `public static const InvalidIronManReasons FOW`
- `public static const InvalidIronManReasons HISTORICAL_FOCUS`
- `public static const InvalidIronManReasons INFINITE_AMMO_FUEL`
- `public static const InvalidIronManReasons MODS`
- `public static const InvalidIronManReasons NONE`
- `public static const InvalidIronManReasons OFFICIAL_MAP`
- `public static const InvalidIronManReasons PRODUCTION_TAKES_TIME`
- `public static const InvalidIronManReasons REALISTIC_SUPPLIES`
- `public static const InvalidIronManReasons SCENARIO_SETUP`
- `public static const InvalidIronManReasons UPKEEP`
- `public Int32 value__`
- `public static const InvalidIronManReasons VIOLATED_RULE`
- `public static const InvalidIronManReasons WEATHER`
- `public static const InvalidIronManReasons ZOC`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(InvalidIronManReasons), "PrivateMethodName", MethodType.Normal)]
class Patch_InvalidIronManReasons_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(InvalidIronManReasons), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## IronmanTooltip

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData p_eventData)`
- `public Void OnPointerExit(PointerEventData p_eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void OnDisable()`
- `private Void RefreshValidations()`
- `private Void Update()`
- `private Void UpdateImage(Image p_image, Boolean p_isValid)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private Image _difficulty_image`
- `private Image _fow_image`
- `private Image _historicalFocus_image`
- `private Image _infiniteAmmoFuel_image`
- `private Color _invalid_color`
- `private Sprite _invalid_sprite`
- `private Image _mods_image`
- `private Image _officialScenario_image`
- `private Image _production_image`
- `private Image _scenarioSetup_image`
- `private Image _supplies_image`
- `private GameObject _tooltip`
- `private RectTransform _tooltipRectTransform`
- `private Image _upkeep_image`
- `private Color _valid_color`
- `private Sprite _valid_sprite`
- `private Image _weather_image`
- `private Image _zoc_image`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(IronmanTooltip), "PrivateMethodName", MethodType.Normal)]
class Patch_IronmanTooltip_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(IronmanTooltip), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LanguageSlotUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button button`
- `public Image image`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LanguageSlotUI), "PrivateMethodName", MethodType.Normal)]
class Patch_LanguageSlotUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LanguageSlotUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LastTurnSummaryData

**Base Class:** `System.ValueType`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String countryName`
- `public Int32 moneyEarned`
- `public Int32 moneySpent`
- `public Int32 unitsBuilt`
- `public Int32 unitsDestroyed`
- `public Int32 unitsLost`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LastTurnSummaryData), "PrivateMethodName", MethodType.Normal)]
class Patch_LastTurnSummaryData_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LastTurnSummaryData), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LastTurnSummaryUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Setup(Player p_player)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public LastTurnSummaryData lastTurnSummaryData`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TextMeshProUGUI _countryName_text`
- `private TextMeshProUGUI _moneyEarned_text`
- `private TextMeshProUGUI _moneySpent_text`
- `private TextMeshProUGUI _unitsBuilt_text`
- `private TextMeshProUGUI _unitsDestroyed_text`
- `private TextMeshProUGUI _unitsLost_text`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LastTurnSummaryUI), "PrivateMethodName", MethodType.Normal)]
class Patch_LastTurnSummaryUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LastTurnSummaryUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeaderboardActions

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const LeaderboardActions FORCE_UPDATE`
- `public static const LeaderboardActions KEEP_BEST`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeaderboardActions), "PrivateMethodName", MethodType.Normal)]
class Patch_LeaderboardActions_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeaderboardActions), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeaderboardEntryUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void SetNoEntry()`
- `public Void Setup(SteamLeaderboardEntry p_steamLeaderboardEntry)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TextMeshProUGUI _playerName_text`
- `private TextMeshProUGUI _rank_text`
- `private TextMeshProUGUI _score_text`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeaderboardEntryUI), "PrivateMethodName", MethodType.Normal)]
class Patch_LeaderboardEntryUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeaderboardEntryUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeaderboardGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void SelectScenario(String p_leaderboardName)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void DownloadLeaderboardEntries(SteamLeaderboard_t p_leaderboardHandle)`
- `private Void DownloadLocalPlayerEntry(SteamLeaderboard_t p_leaderboardHandle)`
- `private Void GetSteamLeaderboard(String p_leaderboardName)`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void OnLeaderboardFindResult(LeaderboardFindResult_t p_result, Boolean p_failure)`
- `private Void OnLeaderboardLocalPlayerScoresDownloaded(LeaderboardScoresDownloaded_t p_result, Boolean p_failure)`
- `private Void OnLeaderboardScoresDownloaded(LeaderboardScoresDownloaded_t p_result, Boolean p_failure)`
- `private Void RefreshLeaderboardEntries(SteamLeaderboard p_steamLeaderboard)`
- `private Void RefreshListOfScenarios()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public TextMeshProUGUI columnValues_text`
- `public Transform leaderboard_parent`
- `public GameObject leaderboardScenario_prefab`
- `public LeaderboardEntryUI leaderboardSlot_prefab`
- `public Transform listOfScenarios_Parent`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private SteamLeaderboard _steamLeaderboard`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass8_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeaderboardGO), "PrivateMethodName", MethodType.Normal)]
class Patch_LeaderboardGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeaderboardGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanAudio

### Public Methods

- `public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)`
- `public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)`
- `public static AudioClip generateAudioFromCurve(AnimationCurve curve, Int32 frequencyRate = 44100)`
- `public static LeanAudioOptions options()`
- `public static AudioSource play(AudioClip audio, Single volume)`
- `public static AudioSource play(AudioClip audio)`
- `public static AudioSource play(AudioClip audio, Vector3 pos)`
- `public static AudioSource play(AudioClip audio, Vector3 pos, Single volume)`
- `public static AudioSource playClipAt(AudioClip clip, Vector3 pos)`
- `public static Void printOutAudioClip(AudioClip audioClip, AnimationCurve& curve, Single scaleX = 1)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private static AudioClip createAudioFromWave(Int32 waveLength, LeanAudioOptions options)`
- `private static Int32 createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)`
- `private static Void OnAudioSetPosition(Int32 newPosition)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static Single[] generatedWaveDistances`
- `public static Int32 generatedWaveDistancesCount`
- `public static Single MIN_FREQEUNCY_PERIOD`
- `public static Int32 PROCESSING_ITERATIONS_MAX`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private static Single[] longList`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanAudio), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanAudio_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanAudio), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanAudioOptions

### Public Methods

- `public LeanAudioOptions setFrequency(Int32 frequencyRate)`
- `public LeanAudioOptions setVibrato(Vector3[] vibrato)`
- `public LeanAudioOptions setWaveNoise()`
- `public LeanAudioOptions setWaveNoiseInfluence(Single influence)`
- `public LeanAudioOptions setWaveNoiseScale(Single waveScale)`
- `public LeanAudioOptions setWaveSawtooth()`
- `public LeanAudioOptions setWaveSine()`
- `public LeanAudioOptions setWaveSquare()`
- `public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Int32 frequencyRate`
- `public Vector3[] modulation`
- `public LeanAudioStream stream`
- `public Boolean useSetData`
- `public Vector3[] vibrato`
- `public Single waveNoiseInfluence`
- `public Single waveNoiseScale`
- `public LeanAudioWaveStyle waveStyle`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Nested Types

- `public class LeanAudioWaveStyle`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanAudioOptions), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanAudioOptions_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanAudioOptions), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanAudioStream

### Public Methods

- `public Void OnAudioRead(Single[] data)`
- `public Void OnAudioSetPosition(Int32 newPosition)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Single[] audioArr`
- `public AudioClip audioClip`
- `public Int32 position`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanAudioStream), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanAudioStream_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanAudioStream), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanProp

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const LeanProp color`
- `public static const LeanProp localPosition`
- `public static const LeanProp localX`
- `public static const LeanProp localY`
- `public static const LeanProp localZ`
- `public static const LeanProp position`
- `public static const LeanProp scale`
- `public Int32 value__`
- `public static const LeanProp x`
- `public static const LeanProp y`
- `public static const LeanProp z`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanProp), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanProp_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanProp), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanSmooth

### Public Methods

- `public static Single bounceOut(Single current, Single target, Single& currentVelocity, Single smoothTime, Single maxSpeed = -1, Single deltaTime = -1, Single friction = 2, Single accelRate = 0.5, Single hitDamping = 0.9)`
- `public static Vector3 bounceOut(Vector3 current, Vector3 target, Vector3& currentVelocity, Single smoothTime, Single maxSpeed = -1, Single deltaTime = -1, Single friction = 2, Single accelRate = 0.5, Single hitDamping = 0.9)`
- `public static Color bounceOut(Color current, Color target, Color& currentVelocity, Single smoothTime, Single maxSpeed = -1, Single deltaTime = -1, Single friction = 2, Single accelRate = 0.5, Single hitDamping = 0.9)`
- `public static Single damp(Single current, Single target, Single& currentVelocity, Single smoothTime, Single maxSpeed = -1, Single deltaTime = -1)`
- `public static Vector3 damp(Vector3 current, Vector3 target, Vector3& currentVelocity, Single smoothTime, Single maxSpeed = -1, Single deltaTime = -1)`
- `public static Color damp(Color current, Color target, Color& currentVelocity, Single smoothTime, Single maxSpeed = -1, Single deltaTime = -1)`
- `public static Single linear(Single current, Single target, Single moveSpeed, Single deltaTime = -1)`
- `public static Vector3 linear(Vector3 current, Vector3 target, Single moveSpeed, Single deltaTime = -1)`
- `public static Color linear(Color current, Color target, Single moveSpeed)`
- `public static Single spring(Single current, Single target, Single& currentVelocity, Single smoothTime, Single maxSpeed = -1, Single deltaTime = -1, Single friction = 2, Single accelRate = 0.5)`
- `public static Vector3 spring(Vector3 current, Vector3 target, Vector3& currentVelocity, Single smoothTime, Single maxSpeed = -1, Single deltaTime = -1, Single friction = 2, Single accelRate = 0.5)`
- `public static Color spring(Color current, Color target, Color& currentVelocity, Single smoothTime, Single maxSpeed = -1, Single deltaTime = -1, Single friction = 2, Single accelRate = 0.5)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanSmooth), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanSmooth_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanSmooth), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanTest

### Public Methods

- `public static Void debug(String name, Boolean didPass, String failExplaination = null)`
- `public static Void expect(Boolean didPass, String definition, String failExplaination = null)`
- `public static String formatB(String str)`
- `public static String formatBC(String str, String color)`
- `public static String formatC(String str, String color)`
- `public static Void overview()`
- `public static String padRight(Int32 len)`
- `public static Single printOutLength(String str)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static Int32 expected`
- `public static Boolean testsFinished`
- `public static Single timeout`
- `public static Boolean timeoutStarted`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private static Int32 passes`
- `private static Int32 tests`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanTest), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanTest_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanTest), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanTester

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Start()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private IEnumerator timeoutCheck()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Single timeout`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Nested Types

- `private class <timeoutCheck>d__2`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanTester), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanTester_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanTester), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanTween

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public static Vector3[] add(Vector3[] a, Vector3 b)`
- `public static Void addListener(Int32 eventId, Action`1 callback)`
- `public static Void addListener(GameObject caller, Int32 eventId, Action`1 callback)`
- `public static LTDescr alpha(GameObject gameObject, Single to, Single time)`
- `public static LTDescr alpha(LTRect ltRect, Single to, Single time)`
- `public static LTDescr alpha(RectTransform rectTrans, Single to, Single time)`
- `public static LTDescr alphaCanvas(CanvasGroup canvasGroup, Single to, Single time)`
- `public static LTDescr alphaText(RectTransform rectTransform, Single to, Single time)`
- `public static LTDescr alphaVertex(GameObject gameObject, Single to, Single time)`
- `public static Void cancel(GameObject gameObject)`
- `public static Void cancel(GameObject gameObject, Boolean callOnComplete)`
- `public static Void cancel(RectTransform rect)`
- `public static Void cancel(GameObject gameObject, Int32 uniqueId, Boolean callOnComplete = False)`
- `public static Void cancel(LTRect ltRect, Int32 uniqueId)`
- `public static Void cancel(Int32 uniqueId)`
- `public static Void cancel(Int32 uniqueId, Boolean callOnComplete)`
- `public static Void cancelAll()`
- `public static Void cancelAll(Boolean callComplete)`
- `public static Single clerp(Single start, Single end, Single val)`
- `public static Single closestRot(Single from, Single to)`
- `public static LTDescr color(GameObject gameObject, Color to, Single time)`
- `public static LTDescr color(RectTransform rectTrans, Color to, Single time)`
- `public static LTDescr colorText(RectTransform rectTransform, Color to, Single time)`
- `public static LTDescr delayedCall(Single delayTime, Action callback)`
- `public static LTDescr delayedCall(Single delayTime, Action`1 callback)`
- `public static LTDescr delayedCall(GameObject gameObject, Single delayTime, Action callback)`
- `public static LTDescr delayedCall(GameObject gameObject, Single delayTime, Action`1 callback)`
- `public static LTDescr delayedSound(AudioClip audio, Vector3 pos, Single volume)`
- `public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, Single volume)`
- `public static LTDescr descr(Int32 uniqueId)`
- `public static LTDescr description(Int32 uniqueId)`
- `public static LTDescr[] descriptions(GameObject gameObject = null)`
- `public static LTDescr destroyAfter(LTRect rect, Single delayTime)`
- `public static Void dispatchEvent(Int32 eventId)`
- `public static Void dispatchEvent(Int32 eventId, Object data)`
- `public static Void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Single arrowSize = 0, Transform arrowTransform = null)`
- `public static Single easeInBack(Single start, Single end, Single val, Single overshoot = 1)`
- `public static Single easeInBounce(Single start, Single end, Single val)`
- `public static Single easeInCirc(Single start, Single end, Single val)`
- `public static Single easeInCubic(Single start, Single end, Single val)`
- `public static Single easeInElastic(Single start, Single end, Single val, Single overshoot = 1, Single period = 0.3)`
- `public static Single easeInExpo(Single start, Single end, Single val)`
- `public static Single easeInOutBack(Single start, Single end, Single val, Single overshoot = 1)`
- `public static Single easeInOutBounce(Single start, Single end, Single val)`
- `public static Single easeInOutCirc(Single start, Single end, Single val)`
- `public static Single easeInOutCubic(Single start, Single end, Single val)`
- `public static Single easeInOutElastic(Single start, Single end, Single val, Single overshoot = 1, Single period = 0.3)`
- `public static Single easeInOutExpo(Single start, Single end, Single val)`
- `public static Single easeInOutQuad(Single start, Single end, Single val)`
- `public static Single easeInOutQuadOpt(Single start, Single diff, Single ratioPassed)`
- `public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, Single ratioPassed)`
- `public static Single easeInOutQuadOpt2(Single start, Single diffBy2, Single val, Single val2)`
- `public static Single easeInOutQuart(Single start, Single end, Single val)`
- `public static Single easeInOutQuint(Single start, Single end, Single val)`
- `public static Single easeInOutSine(Single start, Single end, Single val)`
- `public static Single easeInQuad(Single start, Single end, Single val)`
- `public static Single easeInQuadOpt(Single start, Single diff, Single ratioPassed)`
- `public static Single easeInQuart(Single start, Single end, Single val)`
- `public static Single easeInQuint(Single start, Single end, Single val)`
- `public static Single easeInSine(Single start, Single end, Single val)`
- `public static Single easeOutBack(Single start, Single end, Single val, Single overshoot = 1)`
- `public static Single easeOutBounce(Single start, Single end, Single val)`
- `public static Single easeOutCirc(Single start, Single end, Single val)`
- `public static Single easeOutCubic(Single start, Single end, Single val)`
- `public static Single easeOutElastic(Single start, Single end, Single val, Single overshoot = 1, Single period = 0.3)`
- `public static Single easeOutExpo(Single start, Single end, Single val)`
- `public static Single easeOutQuad(Single start, Single end, Single val)`
- `public static Single easeOutQuadOpt(Single start, Single diff, Single ratioPassed)`
- `public static Single easeOutQuart(Single start, Single end, Single val)`
- `public static Single easeOutQuint(Single start, Single end, Single val)`
- `public static Single easeOutSine(Single start, Single end, Single val)`
- `public static LTDescr followBounceOut(Transform trans, Transform target, LeanProp prop, Single smoothTime, Single maxSpeed = -1, Single friction = 2, Single accelRate = 0.5, Single hitDamping = 0.9)`
- `public static LTDescr followDamp(Transform trans, Transform target, LeanProp prop, Single smoothTime, Single maxSpeed = -1)`
- `public static LTDescr followLinear(Transform trans, Transform target, LeanProp prop, Single moveSpeed)`
- `public static LTDescr followSpring(Transform trans, Transform target, LeanProp prop, Single smoothTime, Single maxSpeed = -1, Single friction = 2, Single accelRate = 0.5)`
- `public static Void init()`
- `public static Void init(Int32 maxSimultaneousTweens)`
- `public static Void init(Int32 maxSimultaneousTweens, Int32 maxSimultaneousSequences)`
- `public static Boolean isPaused(GameObject gameObject = null)`
- `public static Boolean isPaused(RectTransform rect)`
- `public static Boolean isPaused(Int32 uniqueId)`
- `public static Boolean isTweening(GameObject gameObject = null)`
- `public static Boolean isTweening(RectTransform rect)`
- `public static Boolean isTweening(Int32 uniqueId)`
- `public static Boolean isTweening(LTRect ltRect)`
- `public static Single linear(Single start, Single end, Single val)`
- `public static Object logError(String error)`
- `public static LTDescr move(GameObject gameObject, Vector3 to, Single time)`
- `public static LTDescr move(GameObject gameObject, Vector2 to, Single time)`
- `public static LTDescr move(GameObject gameObject, Vector3[] to, Single time)`
- `public static LTDescr move(GameObject gameObject, LTBezierPath to, Single time)`
- `public static LTDescr move(GameObject gameObject, LTSpline to, Single time)`
- `public static LTDescr move(LTRect ltRect, Vector2 to, Single time)`
- `public static LTDescr move(GameObject gameObject, Transform to, Single time)`
- `public static LTDescr move(RectTransform rectTrans, Vector3 to, Single time)`
- `public static LTDescr moveLocal(GameObject gameObject, Vector3 to, Single time)`
- `public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, Single time)`
- `public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, Single time)`
- `public static LTDescr moveLocal(GameObject gameObject, LTSpline to, Single time)`
- `public static LTDescr moveLocalX(GameObject gameObject, Single to, Single time)`
- `public static LTDescr moveLocalY(GameObject gameObject, Single to, Single time)`
- `public static LTDescr moveLocalZ(GameObject gameObject, Single to, Single time)`
- `public static LTDescr moveMargin(LTRect ltRect, Vector2 to, Single time)`
- `public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, Single time)`
- `public static LTDescr moveSpline(GameObject gameObject, LTSpline to, Single time)`
- `public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, Single time)`
- `public static LTDescr moveX(GameObject gameObject, Single to, Single time)`
- `public static LTDescr moveX(RectTransform rectTrans, Single to, Single time)`
- `public static LTDescr moveY(GameObject gameObject, Single to, Single time)`
- `public static LTDescr moveY(RectTransform rectTrans, Single to, Single time)`
- `public static LTDescr moveZ(GameObject gameObject, Single to, Single time)`
- `public static LTDescr moveZ(RectTransform rectTrans, Single to, Single time)`
- `public static LTDescr options(LTDescr seed)`
- `public static LTDescr options()`
- `public static Void pause(GameObject gameObject, Int32 uniqueId)`
- `public static Void pause(Int32 uniqueId)`
- `public static Void pause(GameObject gameObject)`
- `public static Void pauseAll()`
- `public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)`
- `public static Boolean removeListener(Int32 eventId, Action`1 callback)`
- `public static Boolean removeListener(Int32 eventId)`
- `public static Boolean removeListener(GameObject caller, Int32 eventId, Action`1 callback)`
- `public static Void removeTween(Int32 i, Int32 uniqueId)`
- `public static Void removeTween(Int32 i)`
- `public static Void reset()`
- `public static Void resume(GameObject gameObject, Int32 uniqueId)`
- `public static Void resume(Int32 uniqueId)`
- `public static Void resume(GameObject gameObject)`
- `public static Void resumeAll()`
- `public static LTDescr rotate(GameObject gameObject, Vector3 to, Single time)`
- `public static LTDescr rotate(LTRect ltRect, Single to, Single time)`
- `public static LTDescr rotate(RectTransform rectTrans, Single to, Single time)`
- `public static LTDescr rotate(RectTransform rectTrans, Vector3 to, Single time)`
- `public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, Single add, Single time)`
- `public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, Single to, Single time)`
- `public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, Single add, Single time)`
- `public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, Single to, Single time)`
- `public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, Single time)`
- `public static LTDescr rotateX(GameObject gameObject, Single to, Single time)`
- `public static LTDescr rotateY(GameObject gameObject, Single to, Single time)`
- `public static LTDescr rotateZ(GameObject gameObject, Single to, Single time)`
- `public static LTDescr scale(GameObject gameObject, Vector3 to, Single time)`
- `public static LTDescr scale(LTRect ltRect, Vector2 to, Single time)`
- `public static LTDescr scale(RectTransform rectTrans, Vector3 to, Single time)`
- `public static LTDescr scaleX(GameObject gameObject, Single to, Single time)`
- `public static LTDescr scaleY(GameObject gameObject, Single to, Single time)`
- `public static LTDescr scaleZ(GameObject gameObject, Single to, Single time)`
- `public static LTSeq sequence(Boolean initSequence = True)`
- `public static LTDescr size(RectTransform rectTrans, Vector2 to, Single time)`
- `public static Single spring(Single start, Single end, Single val)`
- `public static LTDescr textAlpha(RectTransform rectTransform, Single to, Single time)`
- `public static LTDescr textColor(RectTransform rectTransform, Color to, Single time)`
- `public static Single tweenOnCurve(LTDescr tweenDescr, Single ratioPassed)`
- `public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, Single ratioPassed)`
- `public static Void update()`
- `public Void Update()`
- `public static LTDescr value(GameObject gameObject, Single from, Single to, Single time)`
- `public static LTDescr value(Single from, Single to, Single time)`
- `public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, Single time)`
- `public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, Single time)`
- `public static LTDescr value(GameObject gameObject, Color from, Color to, Single time)`
- `public static LTDescr value(GameObject gameObject, Action`1 callOnUpdate, Single from, Single to, Single time)`
- `public static LTDescr value(GameObject gameObject, Action`2 callOnUpdateRatio, Single from, Single to, Single time)`
- `public static LTDescr value(GameObject gameObject, Action`1 callOnUpdate, Color from, Color to, Single time)`
- `public static LTDescr value(GameObject gameObject, Action`2 callOnUpdate, Color from, Color to, Single time)`
- `public static LTDescr value(GameObject gameObject, Action`1 callOnUpdate, Vector2 from, Vector2 to, Single time)`
- `public static LTDescr value(GameObject gameObject, Action`1 callOnUpdate, Vector3 from, Vector3 to, Single time)`
- `public static LTDescr value(GameObject gameObject, Action`2 callOnUpdate, Single from, Single to, Single time)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private static Void internalOnLevelWasLoaded(Int32 lvl)`
- `private static Void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)`
- `private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, Single time, LTDescr tween)`

### Public Properties

- `public static Int32 maxSearch` { get }
- `public static Int32 maxSimulataneousTweens` { get }
- `public static GameObject tweenEmpty` { get }
- `public static Int32 tweensRunning` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static LTDescr d`
- `public static Single dtActual`
- `public static Single dtEstimated`
- `public static Single dtManual`
- `public static Int32 EVENTS_MAX`
- `public static Int32 LISTENERS_MAX`
- `public static Single PI_DIV2`
- `public static AnimationCurve punch`
- `public static AnimationCurve shake`
- `public static Int32 startSearch`
- `public static Single tau`
- `public static Boolean throwErrors`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private static GameObject _tweenEmpty`
- `private static Action`1[] eventListeners`
- `private static Int32 eventsMaxSearch`
- `private static Int32 finishedCnt`
- `private static Int32 frameRendered`
- `private static UInt32 global_counter`
- `private static GameObject[] goListeners`
- `private static Int32 i`
- `private static Int32 INIT_LISTENERS_MAX`
- `private static Int32 j`
- `private static Int32 maxSequences`
- `private static Int32 maxTweenReached`
- `private static Int32 maxTweens`
- `private static LTSeq[] sequences`
- `private static LTDescr tween`
- `private static Int32 tweenMaxSearch`
- `private static LTDescr[] tweens`
- `private static Int32[] tweensFinished`
- `private static Int32[] tweensFinishedIds`

### Nested Types

- `private class <>c__DisplayClass193_0`
- `private class <>c__DisplayClass194_0`
- `private class <>c__DisplayClass195_0`
- `private class <>c__DisplayClass196_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanTween), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanTween_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanTween), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanTweenExt

**Modifiers:** `static`

### Public Methods

- `public static LTDescr LeanAlpha(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanAlpha(RectTransform rectTransform, Single to, Single time)`
- `public static LTDescr LeanAlpha(CanvasGroup canvas, Single to, Single time)`
- `public static LTDescr LeanAlphaText(RectTransform rectTransform, Single to, Single time)`
- `public static LTDescr LeanAlphaVertex(GameObject gameObject, Single to, Single time)`
- `public static Void LeanCancel(GameObject gameObject)`
- `public static Void LeanCancel(GameObject gameObject, Boolean callOnComplete)`
- `public static Void LeanCancel(GameObject gameObject, Int32 uniqueId, Boolean callOnComplete = False)`
- `public static Void LeanCancel(RectTransform rectTransform)`
- `public static LTDescr LeanColor(GameObject gameObject, Color to, Single time)`
- `public static Color LeanColor(Transform transform)`
- `public static LTDescr LeanColorText(RectTransform rectTransform, Color to, Single time)`
- `public static LTDescr LeanDelayedCall(GameObject gameObject, Single delayTime, Action callback)`
- `public static LTDescr LeanDelayedCall(GameObject gameObject, Single delayTime, Action`1 callback)`
- `public static Boolean LeanIsPaused(GameObject gameObject)`
- `public static Boolean LeanIsPaused(RectTransform rectTransform)`
- `public static Boolean LeanIsTweening(GameObject gameObject)`
- `public static LTDescr LeanMove(GameObject gameObject, Vector3 to, Single time)`
- `public static LTDescr LeanMove(Transform transform, Vector3 to, Single time)`
- `public static LTDescr LeanMove(RectTransform rectTransform, Vector3 to, Single time)`
- `public static LTDescr LeanMove(GameObject gameObject, Vector2 to, Single time)`
- `public static LTDescr LeanMove(Transform transform, Vector2 to, Single time)`
- `public static LTDescr LeanMove(GameObject gameObject, Vector3[] to, Single time)`
- `public static LTDescr LeanMove(GameObject gameObject, LTBezierPath to, Single time)`
- `public static LTDescr LeanMove(GameObject gameObject, LTSpline to, Single time)`
- `public static LTDescr LeanMove(Transform transform, Vector3[] to, Single time)`
- `public static LTDescr LeanMove(Transform transform, LTBezierPath to, Single time)`
- `public static LTDescr LeanMove(Transform transform, LTSpline to, Single time)`
- `public static LTDescr LeanMoveLocal(GameObject gameObject, Vector3 to, Single time)`
- `public static LTDescr LeanMoveLocal(GameObject gameObject, LTBezierPath to, Single time)`
- `public static LTDescr LeanMoveLocal(GameObject gameObject, LTSpline to, Single time)`
- `public static LTDescr LeanMoveLocal(Transform transform, Vector3 to, Single time)`
- `public static LTDescr LeanMoveLocal(Transform transform, LTBezierPath to, Single time)`
- `public static LTDescr LeanMoveLocal(Transform transform, LTSpline to, Single time)`
- `public static LTDescr LeanMoveLocalX(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanMoveLocalX(Transform transform, Single to, Single time)`
- `public static LTDescr LeanMoveLocalY(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanMoveLocalY(Transform transform, Single to, Single time)`
- `public static LTDescr LeanMoveLocalZ(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanMoveLocalZ(Transform transform, Single to, Single time)`
- `public static LTDescr LeanMoveSpline(GameObject gameObject, Vector3[] to, Single time)`
- `public static LTDescr LeanMoveSpline(GameObject gameObject, LTSpline to, Single time)`
- `public static LTDescr LeanMoveSpline(Transform transform, Vector3[] to, Single time)`
- `public static LTDescr LeanMoveSpline(Transform transform, LTSpline to, Single time)`
- `public static LTDescr LeanMoveSplineLocal(GameObject gameObject, Vector3[] to, Single time)`
- `public static LTDescr LeanMoveSplineLocal(Transform transform, Vector3[] to, Single time)`
- `public static LTDescr LeanMoveX(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanMoveX(Transform transform, Single to, Single time)`
- `public static LTDescr LeanMoveX(RectTransform rectTransform, Single to, Single time)`
- `public static LTDescr LeanMoveY(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanMoveY(Transform transform, Single to, Single time)`
- `public static LTDescr LeanMoveY(RectTransform rectTransform, Single to, Single time)`
- `public static LTDescr LeanMoveZ(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanMoveZ(Transform transform, Single to, Single time)`
- `public static LTDescr LeanMoveZ(RectTransform rectTransform, Single to, Single time)`
- `public static Void LeanPause(GameObject gameObject)`
- `public static LTDescr LeanPlay(RectTransform rectTransform, Sprite[] sprites)`
- `public static Void LeanResume(GameObject gameObject)`
- `public static LTDescr LeanRotate(GameObject gameObject, Vector3 to, Single time)`
- `public static LTDescr LeanRotate(Transform transform, Vector3 to, Single time)`
- `public static LTDescr LeanRotate(RectTransform rectTransform, Vector3 to, Single time)`
- `public static LTDescr LeanRotateAround(GameObject gameObject, Vector3 axis, Single add, Single time)`
- `public static LTDescr LeanRotateAround(Transform transform, Vector3 axis, Single add, Single time)`
- `public static LTDescr LeanRotateAround(RectTransform rectTransform, Vector3 axis, Single add, Single time)`
- `public static LTDescr LeanRotateAroundLocal(GameObject gameObject, Vector3 axis, Single add, Single time)`
- `public static LTDescr LeanRotateAroundLocal(Transform transform, Vector3 axis, Single add, Single time)`
- `public static LTDescr LeanRotateAroundLocal(RectTransform rectTransform, Vector3 axis, Single add, Single time)`
- `public static LTDescr LeanRotateX(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanRotateX(Transform transform, Single to, Single time)`
- `public static LTDescr LeanRotateY(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanRotateY(Transform transform, Single to, Single time)`
- `public static LTDescr LeanRotateZ(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanRotateZ(Transform transform, Single to, Single time)`
- `public static LTDescr LeanScale(GameObject gameObject, Vector3 to, Single time)`
- `public static LTDescr LeanScale(Transform transform, Vector3 to, Single time)`
- `public static LTDescr LeanScale(RectTransform rectTransform, Vector3 to, Single time)`
- `public static LTDescr LeanScaleX(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanScaleX(Transform transform, Single to, Single time)`
- `public static LTDescr LeanScaleY(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanScaleY(Transform transform, Single to, Single time)`
- `public static LTDescr LeanScaleZ(GameObject gameObject, Single to, Single time)`
- `public static LTDescr LeanScaleZ(Transform transform, Single to, Single time)`
- `public static Void LeanSetLocalPosX(Transform transform, Single val)`
- `public static Void LeanSetLocalPosY(Transform transform, Single val)`
- `public static Void LeanSetLocalPosZ(Transform transform, Single val)`
- `public static Void LeanSetPosX(Transform transform, Single val)`
- `public static Void LeanSetPosY(Transform transform, Single val)`
- `public static Void LeanSetPosZ(Transform transform, Single val)`
- `public static LTDescr LeanSize(RectTransform rectTransform, Vector2 to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Color from, Color to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Single from, Single to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Vector2 from, Vector2 to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Vector3 from, Vector3 to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Action`1 callOnUpdate, Single from, Single to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Action`2 callOnUpdate, Single from, Single to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Action`2 callOnUpdate, Single from, Single to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Action`1 callOnUpdate, Color from, Color to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Action`1 callOnUpdate, Vector2 from, Vector2 to, Single time)`
- `public static LTDescr LeanValue(GameObject gameObject, Action`1 callOnUpdate, Vector3 from, Vector3 to, Single time)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanTweenExt), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanTweenExt_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanTweenExt), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LeanTweenType

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const LeanTweenType animationCurve`
- `public static const LeanTweenType clamp`
- `public static const LeanTweenType easeInBack`
- `public static const LeanTweenType easeInBounce`
- `public static const LeanTweenType easeInCirc`
- `public static const LeanTweenType easeInCubic`
- `public static const LeanTweenType easeInElastic`
- `public static const LeanTweenType easeInExpo`
- `public static const LeanTweenType easeInOutBack`
- `public static const LeanTweenType easeInOutBounce`
- `public static const LeanTweenType easeInOutCirc`
- `public static const LeanTweenType easeInOutCubic`
- `public static const LeanTweenType easeInOutElastic`
- `public static const LeanTweenType easeInOutExpo`
- `public static const LeanTweenType easeInOutQuad`
- `public static const LeanTweenType easeInOutQuart`
- `public static const LeanTweenType easeInOutQuint`
- `public static const LeanTweenType easeInOutSine`
- `public static const LeanTweenType easeInQuad`
- `public static const LeanTweenType easeInQuart`
- `public static const LeanTweenType easeInQuint`
- `public static const LeanTweenType easeInSine`
- `public static const LeanTweenType easeOutBack`
- `public static const LeanTweenType easeOutBounce`
- `public static const LeanTweenType easeOutCirc`
- `public static const LeanTweenType easeOutCubic`
- `public static const LeanTweenType easeOutElastic`
- `public static const LeanTweenType easeOutExpo`
- `public static const LeanTweenType easeOutQuad`
- `public static const LeanTweenType easeOutQuart`
- `public static const LeanTweenType easeOutQuint`
- `public static const LeanTweenType easeOutSine`
- `public static const LeanTweenType easeShake`
- `public static const LeanTweenType easeSpring`
- `public static const LeanTweenType linear`
- `public static const LeanTweenType notUsed`
- `public static const LeanTweenType once`
- `public static const LeanTweenType pingPong`
- `public static const LeanTweenType punch`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LeanTweenType), "PrivateMethodName", MethodType.Normal)]
class Patch_LeanTweenType_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LeanTweenType), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Line

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public LineData GenerateLineData()`
- `public Void GenerateLineFromLineData(LineData p_lineData)`
- `public Boolean IsInvalidLine()`
- `public Void Setup(Color p_color, Single p_width)`
- `public Void UpdateLine(Vector2 p_position)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void SetPoint(Vector2 p_point)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Color _color`
- `private LineRenderer _lineRenderer`
- `private List`1 _points`
- `private Single _width`
- `private static const Single MIN_DISTANCE_THRESHOLD`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Line), "PrivateMethodName", MethodType.Normal)]
class Patch_Line_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Line), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LineData

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Byte[] Color` { get; set }
- `public Single[,][] Points` { get; set }
- `public Byte Width` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject lineObject`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Byte[] <Color>k__BackingField`
- `private Single[,][] <Points>k__BackingField`
- `private Byte <Width>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LineData), "PrivateMethodName", MethodType.Normal)]
class Patch_LineData_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LineData), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LoadingWheel

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Single speed`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LoadingWheel), "PrivateMethodName", MethodType.Normal)]
class Patch_LoadingWheel_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LoadingWheel), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LoadMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Browse()`
- `public Void CloseLoadPanel()`
- `public Void DeleteSave()`
- `public Void Load()`
- `public Void OpenLoadMenu()`
- `public Void RenameSave()`
- `public Void SetSaveChoice(FileInfo p_fileInfo)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private IEnumerator CR_PollSaves()`
- `private Void OnEnable()`
- `private Void RefreshSaveList()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Byte[] _filesCheckSum`
- `private Single _lastClickTime`
- `private String _savesPath`
- `private FileInfo _selectedFileInfo`
- `private GameObject deleteButton`
- `private TMP_InputField inputField`
- `private GameObject loadButton`
- `private Transform parent`
- `private GameObject renameButton`
- `private GameObject saveSlot_Prefab`
- `private GameObject saveSlotCloud_Prefab`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass16_0`
- `private class <CR_PollSaves>d__22`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LoadMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_LoadMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LoadMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_Base

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Dictionary`2 keyValuePairs`
- `public GameLanguages language`
- `public String translator`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_Base), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_Base_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_Base), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_BR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_BR), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_BR_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_BR), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_CA

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_CA), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_CA_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_CA), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_CNS

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_CNS), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_CNS_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_CNS), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_CNT

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_CNT), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_CNT_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_CNT), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_CZ

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_CZ), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_CZ_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_CZ), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_DE

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_DE), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_DE_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_DE), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_EN

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_EN), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_EN_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_EN), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_ES

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_ES), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_ES_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_ES), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_FI

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_FI), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_FI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_FI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_FR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_FR), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_FR_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_FR), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_GR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_GR), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_GR_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_GR), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_IT

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_IT), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_IT_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_IT), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_JP

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_JP), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_JP_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_JP), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_KR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_KR), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_KR_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_KR), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_NL

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_NL), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_NL_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_NL), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_NO

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_NO), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_NO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_NO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_PL

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_PL), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_PL_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_PL), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_PT

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_PT), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_PT_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_PT), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_RU

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_RU), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_RU_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_RU), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_SE

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_SE), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_SE_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_SE), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_TR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_TR), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_TR_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_TR), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Locale_UA

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Locale_UA), "PrivateMethodName", MethodType.Normal)]
class Patch_Locale_UA_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Locale_UA), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LocalizationManager

### Public Methods

- `public static String GetActiveLocaleTranslator()`
- `public static CultureInfo GetCultureInfo()`
- `public static Locale_Base GetLocale(GameLanguages p_gameLanguage)`
- `public static String GetLocalizedCampaignSide(String p_countryName)`
- `public static String GetLocalizedCountry(String p_countryName)`
- `public static String GetLocalizedDate(DateTime p_customDateTime)`
- `public static String GetLocalizedFaction(String p_factionName)`
- `public static String GetLocalizedIdeology(String p_ideologyName)`
- `public static String GetLocalizedScenario(String p_scenarioName)`
- `public static String GetLocalizedScenario(FileInfo p_fileInfo)`
- `public static String GetLocalizedShortDate(DateTime p_customDateTime)`
- `public static String GetPolicyDescription(Policy p_policy)`
- `public static String GetPolicyName(Policy p_policy)`
- `public static GameLanguages GetSupportedLanguageCode()`
- `public static Void SetActiveLocale(Locale_Base p_locale)`
- `public static Void SetLanguage(GameLanguages p_gameLanguage)`
- `public static String Translate(String p_key)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static Locale_Base activeLocale`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LocalizationManager), "PrivateMethodName", MethodType.Normal)]
class Patch_LocalizationManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LocalizationManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LocalizationUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ManageLanguagesPanel()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void ClearSlots()`
- `private Void CloseLanguageMenu()`
- `private Void GenerateSlot(String p_ISOcode)`
- `private Void GenerateSlots()`
- `private Sprite GetLocaleIcon(String p_ISOcode)`
- `private Void OpenLanguageMenu()`
- `private Void SelectLanguage(String p_languageISOcode)`
- `private Void Start()`
- `private Void UpdateActiveLocaleInfos()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Image _activeLocaleIcon_image`
- `private LanguageSlotUI _languageOption_prefab`
- `private Transform _languages_container`
- `private GameObject _languageSelectionMenu`
- `private TextMeshProUGUI _translator_text`

### Nested Types

- `private class <>c__DisplayClass12_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LocalizationUI), "PrivateMethodName", MethodType.Normal)]
class Patch_LocalizationUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LocalizationUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LocalizedText

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Translate()`
- `public Void Translate(TMP_FontAsset p_fontAsset)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Boolean hasTextComponentAssigned`
- `public String key`
- `public TextMeshProUGUI textMeshProUGUI`
- `public Boolean translateOnAwake`
- `public Boolean updateFontOnAwake`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LocalizedText), "PrivateMethodName", MethodType.Normal)]
class Patch_LocalizedText_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LocalizedText), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTBezier

### Public Methods

- `public Vector3 point(Single t)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Vector3 bezierPoint(Single t)`
- `private Single map(Single u)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Single length`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Vector3 a`
- `private Vector3 aa`
- `private Single[] arcLengths`
- `private Vector3 bb`
- `private Vector3 cc`
- `private Single len`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTBezier), "PrivateMethodName", MethodType.Normal)]
class Patch_LTBezier_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTBezier), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTBezierPath

### Public Methods

- `public Void gizmoDraw(Single t = -1)`
- `public Void place(Transform transform, Single ratio)`
- `public Void place(Transform transform, Single ratio, Vector3 worldUp)`
- `public Void place2d(Transform transform, Single ratio)`
- `public Void placeLocal(Transform transform, Single ratio)`
- `public Void placeLocal(Transform transform, Single ratio, Vector3 worldUp)`
- `public Void placeLocal2d(Transform transform, Single ratio)`
- `public Vector3 point(Single ratio)`
- `public Single ratioAtPoint(Vector3 pt, Single precision = 0.01)`
- `public Void setPoints(Vector3[] pts_)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Single distance` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Single length`
- `public Boolean orientToPath`
- `public Boolean orientToPath2d`
- `public Vector3[] pts`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private LTBezier[] beziers`
- `private Int32 currentBezier`
- `private Single[] lengthRatio`
- `private Int32 previousBezier`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTBezierPath), "PrivateMethodName", MethodType.Normal)]
class Patch_LTBezierPath_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTBezierPath), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTDescr

### Public Methods

- `public Void callOnCompletes()`
- `public LTDescr cancel(GameObject gameObject)`
- `public LTDescr pause()`
- `public Void reset()`
- `public LTDescr resume()`
- `public LTDescr setAlpha()`
- `public LTDescr setAlphaVertex()`
- `public LTDescr setAudio(Object audio)`
- `public LTDescr setAxis(Vector3 axis)`
- `public LTDescr setCallback()`
- `public LTDescr setCallbackColor()`
- `public LTDescr setCanvasAlpha()`
- `public LTDescr setCanvasColor()`
- `public LTDescr setCanvasGroupAlpha()`
- `public LTDescr setCanvasMove()`
- `public LTDescr setCanvasMoveX()`
- `public LTDescr setCanvasMoveY()`
- `public LTDescr setCanvasMoveZ()`
- `public LTDescr setCanvasPlaySprite()`
- `public LTDescr setCanvasRotateAround()`
- `public LTDescr setCanvasRotateAroundLocal()`
- `public LTDescr setCanvasScale()`
- `public LTDescr setCanvasSizeDelta()`
- `public LTDescr setColor()`
- `public LTDescr setDelay(Single delay)`
- `public LTDescr setDelayedSound()`
- `public LTDescr setDestroyOnComplete(Boolean doesDestroy)`
- `public LTDescr setDiff(Vector3 diff)`
- `public LTDescr setDirection(Single direction)`
- `public LTDescr setEase(LeanTweenType easeType)`
- `public LTDescr setEase(AnimationCurve easeCurve)`
- `public LTDescr setEaseInBack()`
- `public LTDescr setEaseInBounce()`
- `public LTDescr setEaseInCirc()`
- `public LTDescr setEaseInCubic()`
- `public LTDescr setEaseInElastic()`
- `public LTDescr setEaseInExpo()`
- `public LTDescr setEaseInOutBack()`
- `public LTDescr setEaseInOutBounce()`
- `public LTDescr setEaseInOutCirc()`
- `public LTDescr setEaseInOutCubic()`
- `public LTDescr setEaseInOutElastic()`
- `public LTDescr setEaseInOutExpo()`
- `public LTDescr setEaseInOutQuad()`
- `public LTDescr setEaseInOutQuart()`
- `public LTDescr setEaseInOutQuint()`
- `public LTDescr setEaseInOutSine()`
- `public LTDescr setEaseInQuad()`
- `public LTDescr setEaseInQuart()`
- `public LTDescr setEaseInQuint()`
- `public LTDescr setEaseInSine()`
- `public LTDescr setEaseLinear()`
- `public LTDescr setEaseOutBack()`
- `public LTDescr setEaseOutBounce()`
- `public LTDescr setEaseOutCirc()`
- `public LTDescr setEaseOutCubic()`
- `public LTDescr setEaseOutElastic()`
- `public LTDescr setEaseOutExpo()`
- `public LTDescr setEaseOutQuad()`
- `public LTDescr setEaseOutQuart()`
- `public LTDescr setEaseOutQuint()`
- `public LTDescr setEaseOutSine()`
- `public LTDescr setEasePunch()`
- `public LTDescr setEaseShake()`
- `public LTDescr setEaseSpring()`
- `public LTDescr setFollow()`
- `public LTDescr setFrameRate(Single frameRate)`
- `public LTDescr setFrom(Vector3 from)`
- `public LTDescr setFrom(Single from)`
- `public LTDescr setFromColor(Color col)`
- `public LTDescr setGUIAlpha()`
- `public LTDescr setGUIMove()`
- `public LTDescr setGUIMoveMargin()`
- `public LTDescr setGUIRotate()`
- `public LTDescr setGUIScale()`
- `public LTDescr setHasInitialized(Boolean has)`
- `public LTDescr setId(UInt32 id, UInt32 global_counter)`
- `public LTDescr setIgnoreTimeScale(Boolean useUnScaledTime)`
- `public LTDescr setLoopClamp()`
- `public LTDescr setLoopClamp(Int32 loops)`
- `public LTDescr setLoopCount(Int32 loopCount)`
- `public LTDescr setLoopOnce()`
- `public LTDescr setLoopPingPong()`
- `public LTDescr setLoopPingPong(Int32 loops)`
- `public LTDescr setLoopType(LeanTweenType loopType)`
- `public LTDescr setMove()`
- `public LTDescr setMoveCurved()`
- `public LTDescr setMoveCurvedLocal()`
- `public LTDescr setMoveLocal()`
- `public LTDescr setMoveLocalX()`
- `public LTDescr setMoveLocalY()`
- `public LTDescr setMoveLocalZ()`
- `public LTDescr setMoveSpline()`
- `public LTDescr setMoveSplineLocal()`
- `public LTDescr setMoveToTransform()`
- `public LTDescr setMoveX()`
- `public LTDescr setMoveY()`
- `public LTDescr setMoveZ()`
- `public LTDescr setOffset(Vector3 offset)`
- `public LTDescr setOnComplete(Action onComplete)`
- `public LTDescr setOnComplete(Action`1 onComplete)`
- `public LTDescr setOnComplete(Action`1 onComplete, Object onCompleteParam)`
- `public LTDescr setOnCompleteOnRepeat(Boolean isOn)`
- `public LTDescr setOnCompleteOnStart(Boolean isOn)`
- `public LTDescr setOnCompleteParam(Object onCompleteParam)`
- `public LTDescr setOnStart(Action onStart)`
- `public LTDescr setOnUpdate(Action`1 onUpdate)`
- `public LTDescr setOnUpdate(Action`1 onUpdate)`
- `public LTDescr setOnUpdate(Action`2 onUpdate)`
- `public LTDescr setOnUpdate(Action`2 onUpdate, Object onUpdateParam = null)`
- `public LTDescr setOnUpdate(Action`2 onUpdate, Object onUpdateParam = null)`
- `public LTDescr setOnUpdate(Action`1 onUpdate, Object onUpdateParam = null)`
- `public LTDescr setOnUpdate(Action`1 onUpdate, Object onUpdateParam = null)`
- `public LTDescr setOnUpdateColor(Action`1 onUpdate)`
- `public LTDescr setOnUpdateColor(Action`2 onUpdate)`
- `public LTDescr setOnUpdateObject(Action`2 onUpdate)`
- `public LTDescr setOnUpdateParam(Object onUpdateParam)`
- `public LTDescr setOnUpdateRatio(Action`2 onUpdate)`
- `public LTDescr setOnUpdateVector2(Action`1 onUpdate)`
- `public LTDescr setOnUpdateVector3(Action`1 onUpdate)`
- `public LTDescr setOrientToPath(Boolean doesOrient)`
- `public LTDescr setOrientToPath2d(Boolean doesOrient2d)`
- `public LTDescr setOvershoot(Single overshoot)`
- `public LTDescr setPassed(Single passed)`
- `public LTDescr setPath(LTBezierPath path)`
- `public LTDescr setPeriod(Single period)`
- `public LTDescr setPoint(Vector3 point)`
- `public LTDescr setRect(LTRect rect)`
- `public LTDescr setRect(Rect rect)`
- `public LTDescr setRect(RectTransform rect)`
- `public LTDescr setRecursive(Boolean useRecursion)`
- `public LTDescr setRepeat(Int32 repeat)`
- `public LTDescr setRotate()`
- `public LTDescr setRotateAround()`
- `public LTDescr setRotateAroundLocal()`
- `public LTDescr setRotateLocal()`
- `public LTDescr setRotateX()`
- `public LTDescr setRotateY()`
- `public LTDescr setRotateZ()`
- `public LTDescr setScale()`
- `public LTDescr setScale(Single scale)`
- `public LTDescr setScaleX()`
- `public LTDescr setScaleY()`
- `public LTDescr setScaleZ()`
- `public LTDescr setSpeed(Single speed)`
- `public LTDescr setSprites(Sprite[] sprites)`
- `public LTDescr setTarget(Transform trans)`
- `public LTDescr setTextAlpha()`
- `public LTDescr setTextColor()`
- `public LTDescr setTime(Single time)`
- `public LTDescr setTo(Vector3 to)`
- `public LTDescr setTo(Transform to)`
- `public LTDescr setUseEstimatedTime(Boolean useEstimatedTime)`
- `public LTDescr setUseFrames(Boolean useFrames)`
- `public LTDescr setUseManualTime(Boolean useManualTime)`
- `public LTDescr setValue3()`
- `public virtual String ToString()`
- `public Boolean updateInternal()`
- `public LTDescr updateNow()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private static Void alphaRecursive(Transform transform, Single val, Boolean useRecursion = True)`
- `private static Void alphaRecursive(RectTransform rectTransform, Single val, Int32 recursiveLevel = 0)`
- `private static Void alphaRecursiveSprite(Transform transform, Single val)`
- `private Void callback()`
- `private static Void colorRecursive(Transform transform, Color toColor, Boolean useRecursion = True)`
- `private static Void colorRecursive(RectTransform rectTransform, Color toColor)`
- `private static Void colorRecursiveSprite(Transform transform, Color toColor)`
- `private Vector3 easeInBack()`
- `private Vector3 easeInBounce()`
- `private Vector3 easeInCirc()`
- `private Vector3 easeInCubic()`
- `private Vector3 easeInElastic()`
- `private Vector3 easeInExpo()`
- `private Vector3 easeInOutBack()`
- `private Vector3 easeInOutBounce()`
- `private Vector3 easeInOutCirc()`
- `private Vector3 easeInOutCubic()`
- `private Vector3 easeInOutElastic()`
- `private Vector3 easeInOutExpo()`
- `private Vector3 easeInOutQuad()`
- `private Vector3 easeInOutQuart()`
- `private Vector3 easeInOutQuint()`
- `private Vector3 easeInOutSine()`
- `private Vector3 easeInQuad()`
- `private Vector3 easeInQuart()`
- `private Vector3 easeInQuint()`
- `private Vector3 easeInSine()`
- `private Vector3 easeLinear()`
- `private Vector3 easeOutBack()`
- `private Vector3 easeOutBounce()`
- `private Vector3 easeOutCirc()`
- `private Vector3 easeOutCubic()`
- `private Vector3 easeOutElastic()`
- `private Vector3 easeOutExpo()`
- `private Vector3 easeOutQuad()`
- `private Vector3 easeOutQuart()`
- `private Vector3 easeOutQuint()`
- `private Vector3 easeOutSine()`
- `private Vector3 easeSpring()`
- `private Void init()`
- `private Void initCanvasRotateAround()`
- `private Void initFromInternal()`
- `private Void initSpeed()`
- `private static Void textAlphaChildrenRecursive(Transform trans, Single val, Boolean useRecursion = True)`
- `private static Void textAlphaRecursive(Transform trans, Single val, Boolean useRecursion = True)`
- `private static Void textColorRecursive(Transform trans, Color toColor)`
- `private static Color tweenColor(LTDescr tween, Single val)`
- `private Vector3 tweenOnCurve()`

### Public Properties

- `public ActionMethodDelegate easeInternal` { get; set }
- `public Vector3 from` { get; set }
- `public Int32 id` { get }
- `public ActionMethodDelegate initInternal` { get; set }
- `public LTDescrOptional optional` { get; set }
- `public Vector3 to` { get; set }
- `public Transform toTrans` { get }
- `public Int32 uniqueId` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public LTDescrOptional _optional`
- `public UInt32 counter`
- `public Single delay`
- `public Boolean destroyOnComplete`
- `public Single direction`
- `public Single directionLast`
- `public static Single dt`
- `public EaseTypeDelegate easeMethod`
- `public Boolean hasExtraOnCompletes`
- `public Boolean hasInitiliazed`
- `public Boolean hasPhysics`
- `public Boolean hasUpdateCallback`
- `public Single lastVal`
- `public Int32 loopCount`
- `public LeanTweenType loopType`
- `public static Vector3 newVect`
- `public Boolean onCompleteOnRepeat`
- `public Boolean onCompleteOnStart`
- `public Single overshoot`
- `public Single passed`
- `public Single period`
- `public Single ratioPassed`
- `public RawImage rawImage`
- `public RectTransform rectTransform`
- `public Single scale`
- `public Single speed`
- `public SpriteRenderer spriteRen`
- `public Sprite[] sprites`
- `public Single time`
- `public Boolean toggle`
- `public Transform trans`
- `public TweenAction type`
- `public Image uiImage`
- `public Text uiText`
- `public Boolean useEstimatedTime`
- `public Boolean useFrames`
- `public Boolean useManualTime`
- `public Boolean useRecursion`
- `public Boolean usesNormalDt`
- `public static Single val`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private UInt32 _id`
- `private ActionMethodDelegate <easeInternal>k__BackingField`
- `private ActionMethodDelegate <initInternal>k__BackingField`
- `private Vector3 diff`
- `private Vector3 diffDiv2`
- `private LeanTweenType easeType`
- `private Vector3 fromInternal`
- `private Vector3 toInternal`

### Nested Types

- `private class <>c`
- `public class ActionMethodDelegate`
- `public class EaseTypeDelegate`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTDescr), "PrivateMethodName", MethodType.Normal)]
class Patch_LTDescr_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTDescr), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTDescrOptional

### Public Methods

- `public Void callOnUpdate(Single val, Single ratioPassed)`
- `public Void reset()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Vector3 axis` { get; set }
- `public Single lastVal` { get; set }
- `public LTRect ltRect` { get; set }
- `public Action onComplete` { get; set }
- `public Action`1 onCompleteObject` { get; set }
- `public Object onCompleteParam` { get; set }
- `public Action onStart` { get; set }
- `public Action`1 onUpdateColor` { get; set }
- `public Action`2 onUpdateColorObject` { get; set }
- `public Action`1 onUpdateFloat` { get; set }
- `public Action`2 onUpdateFloatObject` { get; set }
- `public Action`2 onUpdateFloatRatio` { get; set }
- `public Object onUpdateParam` { get; set }
- `public Action`1 onUpdateVector2` { get; set }
- `public Action`1 onUpdateVector3` { get; set }
- `public Action`2 onUpdateVector3Object` { get; set }
- `public Quaternion origRotation` { get; set }
- `public LTBezierPath path` { get; set }
- `public Vector3 point` { get; set }
- `public LTSpline spline` { get; set }
- `public Transform toTrans` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public AnimationCurve animationCurve`
- `public Color color`
- `public Int32 initFrameCount`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Vector3 <axis>k__BackingField`
- `private Single <lastVal>k__BackingField`
- `private LTRect <ltRect>k__BackingField`
- `private Action <onComplete>k__BackingField`
- `private Action`1 <onCompleteObject>k__BackingField`
- `private Object <onCompleteParam>k__BackingField`
- `private Action <onStart>k__BackingField`
- `private Action`1 <onUpdateColor>k__BackingField`
- `private Action`2 <onUpdateColorObject>k__BackingField`
- `private Action`1 <onUpdateFloat>k__BackingField`
- `private Action`2 <onUpdateFloatObject>k__BackingField`
- `private Action`2 <onUpdateFloatRatio>k__BackingField`
- `private Object <onUpdateParam>k__BackingField`
- `private Action`1 <onUpdateVector2>k__BackingField`
- `private Action`1 <onUpdateVector3>k__BackingField`
- `private Action`2 <onUpdateVector3Object>k__BackingField`
- `private Quaternion <origRotation>k__BackingField`
- `private LTBezierPath <path>k__BackingField`
- `private Vector3 <point>k__BackingField`
- `private LTSpline <spline>k__BackingField`
- `private Transform <toTrans>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTDescrOptional), "PrivateMethodName", MethodType.Normal)]
class Patch_LTDescrOptional_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTDescrOptional), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTEvent

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Object data`
- `public Int32 id`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTEvent), "PrivateMethodName", MethodType.Normal)]
class Patch_LTEvent_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTEvent), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTGUI

### Public Methods

- `public static Boolean checkOnScreen(Rect rect)`
- `public static Boolean checkWithinRect(Vector2 vec2, Rect rect)`
- `public static Void destroy(Int32 id)`
- `public static Void destroyAll(Int32 depth)`
- `public static LTRect element(LTRect rect, Int32 depth)`
- `public static Vector2 firstTouch()`
- `public static Boolean hasNoOverlap(Rect rect, Int32 depth)`
- `public static Void init()`
- `public static Void initRectCheck()`
- `public static LTRect label(Rect rect, String label, Int32 depth)`
- `public static LTRect label(LTRect rect, String label, Int32 depth)`
- `public static Boolean pressedWithinRect(Rect rect)`
- `public static Void reset()`
- `public static LTRect texture(Rect rect, Texture texture, Int32 depth)`
- `public static LTRect texture(LTRect rect, Texture texture, Int32 depth)`
- `public static Void update(Int32 updateLevel)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static Int32 BUTTONS_MAX`
- `public static Int32 RECT_LEVELS`
- `public static Int32 RECTS_PER_LEVEL`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private static Int32[] buttonLastFrame`
- `private static Int32[] buttonLevels`
- `private static Rect[] buttons`
- `private static Color color`
- `private static Int32 global_counter`
- `private static Boolean isGUIEnabled`
- `private static Int32[] levelDepths`
- `private static LTRect[] levels`
- `private static LTRect r`

### Nested Types

- `public class Element_Type`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTGUI), "PrivateMethodName", MethodType.Normal)]
class Patch_LTGUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTGUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTRect

### Public Methods

- `public Void reset()`
- `public Void resetForRotation()`
- `public LTRect setAlpha(Single alpha)`
- `public LTRect setColor(Color color)`
- `public LTRect setFontScaleToFit(Boolean fontScaleToFit)`
- `public Void setId(Int32 id, Int32 counter)`
- `public LTRect setLabel(String str)`
- `public LTRect setSizeByHeight(Boolean sizeByHeight)`
- `public LTRect setStyle(GUIStyle style)`
- `public LTRect setUseSimpleScale(Boolean useSimpleScale, Rect relativeRect)`
- `public LTRect setUseSimpleScale(Boolean useSimpleScale)`
- `public virtual String ToString()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Boolean hasInitiliazed` { get }
- `public Single height` { get; set }
- `public Int32 id` { get }
- `public Rect rect` { get; set }
- `public Single width` { get; set }
- `public Single x` { get; set }
- `public Single y` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Rect _rect`
- `public Single alpha`
- `public Boolean alphaEnabled`
- `public Color color`
- `public static Boolean colorTouched`
- `public Int32 counter`
- `public Boolean fontScaleToFit`
- `public String labelStr`
- `public Vector2 margin`
- `public Vector2 pivot`
- `public Rect relativeRect`
- `public Boolean rotateEnabled`
- `public Boolean rotateFinished`
- `public Single rotation`
- `public Boolean sizeByHeight`
- `public GUIStyle style`
- `public Texture texture`
- `public Element_Type type`
- `public Boolean useColor`
- `public Boolean useSimpleScale`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Int32 _id`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTRect), "PrivateMethodName", MethodType.Normal)]
class Patch_LTRect_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTRect), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTSeq

### Public Methods

- `public LTSeq append(Single delay)`
- `public LTSeq append(Action callback)`
- `public LTSeq append(Action`1 callback, Object obj)`
- `public LTSeq append(GameObject gameObject, Action callback)`
- `public LTSeq append(GameObject gameObject, Action`1 callback, Object obj)`
- `public LTSeq append(LTDescr tween)`
- `public Void init(UInt32 id, UInt32 global_counter)`
- `public LTSeq insert(LTDescr tween)`
- `public Void reset()`
- `public LTSeq reverse()`
- `public LTSeq setScale(Single timeScale)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private LTSeq addOn()`
- `private Single addPreviousDelays()`
- `private Void setScaleRecursive(LTSeq seq, Single timeScale, Int32 count)`

### Public Properties

- `public Int32 id` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public UInt32 counter`
- `public LTSeq current`
- `public LTSeq previous`
- `public Single timeScale`
- `public Boolean toggle`
- `public Single totalDelay`
- `public LTDescr tween`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private UInt32 _id`
- `private Int32 debugIter`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTSeq), "PrivateMethodName", MethodType.Normal)]
class Patch_LTSeq_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTSeq), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTSpline

### Public Methods

- `public Void drawGizmo(Color color)`
- `public static Void drawGizmo(Transform[] arr, Color color)`
- `public static Void drawLine(Transform[] arr, Single width, Color color)`
- `public Void drawLinesGLLines(Material outlineMaterial, Color color, Single width)`
- `public Vector3[] generateVectors()`
- `public Void gizmoDraw(Single t = -1)`
- `public Vector3 interp(Single t)`
- `public Vector3 map(Single u)`
- `public Void place(Transform transform, Single ratio)`
- `public Void place(Transform transform, Single ratio, Vector3 worldUp)`
- `public Void place2d(Transform transform, Single ratio)`
- `public Void placeLocal(Transform transform, Single ratio)`
- `public Void placeLocal(Transform transform, Single ratio, Vector3 worldUp)`
- `public Void placeLocal2d(Transform transform, Single ratio)`
- `public Vector3 point(Single ratio)`
- `public Single ratioAtPoint(Vector3 pt)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void init(Vector3[] pts, Boolean constantSpeed)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Boolean constantSpeed`
- `public Single distance`
- `public static Int32 DISTANCE_COUNT`
- `public Boolean orientToPath`
- `public Boolean orientToPath2d`
- `public Vector3[] pts`
- `public Vector3[] ptsAdj`
- `public Int32 ptsAdjLength`
- `public static Int32 SUBLINE_COUNT`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Int32 currPt`
- `private Int32 numSections`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTSpline), "PrivateMethodName", MethodType.Normal)]
class Patch_LTSpline_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTSpline), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## LTUtility

### Public Methods

- `public static Vector3[] reverse(Vector3[] arr)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(LTUtility), "PrivateMethodName", MethodType.Normal)]
class Patch_LTUtility_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(LTUtility), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MainMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Android()`
- `public Void BeastsOfSteel()`
- `public Void ChooseMenu(String value)`
- `public Void CloseAllPanel()`
- `public Void ContinueLastSave()`
- `public Void Discord()`
- `public Void Donate()`
- `public Void Facebook()`
- `public Void GameplayTutorialVideo()`
- `public static Void GetAllCustomUserMadeMaps(Boolean p_includeCampaigns)`
- `public Void Instagram()`
- `public Void iOS()`
- `public Void MapEditorTutorialVideo()`
- `public Void OpenCampaignPanel()`
- `public Void OpenCountryEditorPanel()`
- `public Void OpenGuide()`
- `public Void OpenHeroesEditorPanel()`
- `public Void OpenLeaderboardPanel()`
- `public Void OpenMapEditorPanel()`
- `public Void OpenMapGeneratorPanel()`
- `public Void OpenModManagerPanel()`
- `public Void OpenMultiplayerPanel()`
- `public Void OpenQuickGamePanel()`
- `public Void OpenSettings()`
- `public Void OpenTileEditorPanel()`
- `public Void OpenUnitEditorPanel()`
- `public Void Quit()`
- `public Void Reddit()`
- `public Void Youtube()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void CheckContinueButton()`
- `private Void CreateAllDirectories()`
- `private Void GetAllOfficialCampaignMaps()`
- `private Void OnApplicationQuit()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Sprite baseWallapper_sprite`
- `public static Color blackColor`
- `public GameObject continue_button`
- `public GameObject countryEditor_Panel`
- `public GameObject demo_text`
- `public GameObject editors_section`
- `public static Color fogOfWarColor`
- `public static GameSettings gameSettingsBackup`
- `public TextMeshProUGUI gameVersion_text`
- `public static Color greenColor`
- `public static Color greyColor`
- `public GameObject heroesEditor_Panel`
- `public static MainMenu instance`
- `public static Boolean isDemo`
- `public static Boolean isEditor`
- `public static Boolean isLoadedGame`
- `public static Boolean isMainMenu`
- `public static Boolean isTablet`
- `public GameObject languageSelection_panel`
- `public GameObject leaderboardGO_panel`
- `public static List`1 listOfAllCampaigns`
- `public static List`1 listOfAllMapsQuickGame`
- `public static List`1 listOfPlayersToBeSavedBetweenCampaign`
- `public LoadMenu loadGO`
- `public GameObject loading_Panel`
- `public Canvas mainCanvas`
- `public GameObject mapEditor_Panel`
- `public MapEditorMenu mapEditorMenu`
- `public GameObject mapgGenerator_Panel`
- `public GameObject menu_section`
- `public GameObject modManager_Panel`
- `public GameObject mods_Panel`
- `public GameObject multiplayer_Panel`
- `public static Boolean needsToLoadMultiplayerMenu`
- `public GameObject newCampaignPanel`
- `public GameObject play_section`
- `public static Color redColor`
- `public GameObject saveLoad_Panel`
- `public static FileInfo selectedMap`
- `public GameObject settings_Panel`
- `public static Stopwatch stopwatchAttackMovement`
- `public GameObject tileEditor_Panel`
- `public GameObject tooltip`
- `public StandaloneScenariosMenu twoPlayers`
- `public GameObject twoPlayers_Panel`
- `public Transform UI_parent`
- `public GameObject unitEditor_Panel`
- `public Image wallpaper_Image`
- `public static Color yellowColor`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean _isDemo`
- `private VideoPlayer _videoPlayer`

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MainMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_MainMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MainMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ManpowerTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void OnDisable()`
- `private Void Start()`
- `private Void Update()`
- `private Void UpdateManpowerText(TextMeshProUGUI p_text, String p_localizationKey, Int32 p_value)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public TextMeshProUGUI airForces_text`
- `public TextMeshProUGUI availableManpower_text`
- `public TextMeshProUGUI currentManpower_text`
- `public TextMeshProUGUI groundForces_text`
- `public TextMeshProUGUI maxManpower_text`
- `public TextMeshProUGUI navalForces_text`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private GameObject _tooltip`
- `private RectTransform _tooltipRectTransform`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ManpowerTooltipGO), "PrivateMethodName", MethodType.Normal)]
class Patch_ManpowerTooltipGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ManpowerTooltipGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Map

### Public Methods

- `public Void CheckIncorrectEvents()`
- `public Void EventTriggerVPLoss(Tile p_tile, Player p_playerCapturing, Player p_playerLosing)`
- `public Boolean FindTile(Int32 p_posX, Int32 p_posY, Tile& o_tile)`
- `public Void GenerateDefaultWeatherTable()`
- `public WeatherPredictionData GetCurrentTurnWeatherPredictionData()`
- `public Int32 GetNewEventID()`
- `public WeatherPredictionData GetNextTurnWeatherPredictionData()`
- `public List`1 GetWeatherPredictionData(ForecastType p_forecastType)`
- `public Boolean IsDateWinter(DateTime p_dateTime)`
- `public Boolean IsPlayerOnTheMap(Player p_player)`
- `public Void RemoveEvent(Int32 eventID)`
- `public Void SetIsWinterBasedOnCurrentDate()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Boolean AllowSnowInWinter` { get; set }
- `public String BackUpPlayerPlaying` { get; set }
- `public Int32 BaseCoreUnitValue` { get; set }
- `public Byte BaseWeatherPredictionAccuracy` { get; set }
- `public Boolean CircularMap` { get; set }
- `public Single CreationTotalTime` { get; set }
- `public Byte DailyWeatherPredictionAccuracyLoss` { get; set }
- `public String DamageToWinFaction` { get; set }
- `public DateTime Date` { get; set }
- `public Boolean DisableManpower` { get; set }
- `public Boolean DisablePurchases` { get; set }
- `public Boolean DisableResearch` { get; set }
- `public Boolean DisableUpkeep` { get; set }
- `public Boolean DisableWeather` { get; set }
- `public Int32 EventIDs` { get; set }
- `public List`1 Events` { get; set }
- `public String FileName` { get; set }
- `public String ID` { get; set }
- `public Boolean InitializedManpower` { get; set }
- `public Boolean IsCampaign` { get; set }
- `public Boolean IsLastScenario` { get; set }
- `public Boolean IsOfficial` { get; set }
- `public Boolean IsOnlineGame` { get; set }
- `public Boolean IsTutorial` { get; set }
- `public Boolean IsWinter` { get; set }
- `public Byte MaxTurnsPrediction` { get; set }
- `public String NextMap` { get; set }
- `public String NextMap2` { get; set }
- `public String NextMap2Defeat` { get; set }
- `public String NextMapDefeat` { get; set }
- `public List`1 Notifications` { get; set }
- `public Int32 NumberOfDamageToWin` { get; set }
- `public Int32 NumberOfDaysThatGoesByPerTurn` { get; set }
- `public Int32 NumberOfNewCoreUnitPerRank` { get; set }
- `public Int32 NumberOfTilesToBombToWin` { get; set }
- `public Int32 NumberOfTurnsToWin` { get; set }
- `public String OriginalCampaignCountry` { get; set }
- `public Single OverlayOpacity` { get; set }
- `public String OverlayPath` { get; set }
- `public Single OverlayPosX` { get; set }
- `public Single OverlayPosY` { get; set }
- `public Single OverlayScale` { get; set }
- `public String Player1` { get; set }
- `public String Player2` { get; set }
- `public String ScenarioDefeatText` { get; set }
- `public String ScenarioDescription` { get; set }
- `public String ScenarioName` { get; set }
- `public String ScenarioVictoryText` { get; set }
- `public Int32 SizeX` { get; set }
- `public Int32 SizeY` { get; set }
- `public Tile[,] TilesTable` { get; set }
- `public String TilesToBombFaction` { get; set }
- `public Single timePlayed` { get; set }
- `public Int32 turnCount` { get; set }
- `public Byte[] WeatherChanceTable` { get; set }
- `public Int32 WeatherSeed` { get; set }
- `public Int32 XPperMajorVP` { get; set }
- `public Int32 XPperNormalVP` { get; set }
- `public Int32 XPPerScenario` { get; set }
- `public Int32 XPperSecondaryVP` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Dictionary`2 listOfUnitsThatNeedToBeKilled`
- `public Dictionary`2 listOfVPThatNeedsToBeHeld`
- `public Dictionary`2 majorVPsPerFaction`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean <AllowSnowInWinter>k__BackingField`
- `private String <BackUpPlayerPlaying>k__BackingField`
- `private Int32 <BaseCoreUnitValue>k__BackingField`
- `private Byte <BaseWeatherPredictionAccuracy>k__BackingField`
- `private Boolean <CircularMap>k__BackingField`
- `private Single <CreationTotalTime>k__BackingField`
- `private Byte <DailyWeatherPredictionAccuracyLoss>k__BackingField`
- `private String <DamageToWinFaction>k__BackingField`
- `private DateTime <Date>k__BackingField`
- `private Boolean <DisableManpower>k__BackingField`
- `private Boolean <DisablePurchases>k__BackingField`
- `private Boolean <DisableResearch>k__BackingField`
- `private Boolean <DisableUpkeep>k__BackingField`
- `private Boolean <DisableWeather>k__BackingField`
- `private Int32 <EventIDs>k__BackingField`
- `private List`1 <Events>k__BackingField`
- `private String <FileName>k__BackingField`
- `private String <ID>k__BackingField`
- `private Boolean <InitializedManpower>k__BackingField`
- `private Boolean <IsCampaign>k__BackingField`
- `private Boolean <IsLastScenario>k__BackingField`
- `private Boolean <IsOfficial>k__BackingField`
- `private Boolean <IsOnlineGame>k__BackingField`
- `private Boolean <IsTutorial>k__BackingField`
- `private Boolean <IsWinter>k__BackingField`
- `private Byte <MaxTurnsPrediction>k__BackingField`
- `private String <NextMap>k__BackingField`
- `private String <NextMap2>k__BackingField`
- `private String <NextMap2Defeat>k__BackingField`
- `private String <NextMapDefeat>k__BackingField`
- `private List`1 <Notifications>k__BackingField`
- `private Int32 <NumberOfDamageToWin>k__BackingField`
- `private Int32 <NumberOfDaysThatGoesByPerTurn>k__BackingField`
- `private Int32 <NumberOfNewCoreUnitPerRank>k__BackingField`
- `private Int32 <NumberOfTilesToBombToWin>k__BackingField`
- `private Int32 <NumberOfTurnsToWin>k__BackingField`
- `private String <OriginalCampaignCountry>k__BackingField`
- `private Single <OverlayOpacity>k__BackingField`
- `private String <OverlayPath>k__BackingField`
- `private Single <OverlayPosX>k__BackingField`
- `private Single <OverlayPosY>k__BackingField`
- `private Single <OverlayScale>k__BackingField`
- `private String <Player1>k__BackingField`
- `private String <Player2>k__BackingField`
- `private String <ScenarioDefeatText>k__BackingField`
- `private String <ScenarioDescription>k__BackingField`
- `private String <ScenarioName>k__BackingField`
- `private String <ScenarioVictoryText>k__BackingField`
- `private Int32 <SizeX>k__BackingField`
- `private Int32 <SizeY>k__BackingField`
- `private Tile[,] <TilesTable>k__BackingField`
- `private String <TilesToBombFaction>k__BackingField`
- `private Single <timePlayed>k__BackingField`
- `private Int32 <turnCount>k__BackingField`
- `private Byte[] <WeatherChanceTable>k__BackingField`
- `private Int32 <WeatherSeed>k__BackingField`
- `private Int32 <XPperMajorVP>k__BackingField`
- `private Int32 <XPperNormalVP>k__BackingField`
- `private Int32 <XPPerScenario>k__BackingField`
- `private Int32 <XPperSecondaryVP>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Map), "PrivateMethodName", MethodType.Normal)]
class Patch_Map_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Map), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MapEditorGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AddNewPlayer()`
- `public Void AddTilesDOWN()`
- `public Void AddTilesLEFT()`
- `public Void AddTilesRIGHT()`
- `public Void AddTilesUP()`
- `public Void ChangeEntrenchmentLevelOnScenarioStart()`
- `public Void ChangeHPmodifierOnScenarioStart()`
- `public Void ChangePlayerFixedIncome(TMP_InputField inputField, Player p_player)`
- `public Void ChangePlayerHQpoints(TMP_InputField inputField, Player p_player)`
- `public Void ChangeSeasonOfAllTilesOnTheMap()`
- `public Void ChangeTileSeason()`
- `public Void ChangeUnitLevel()`
- `public Void CheckMapReadyToPlay()`
- `public Void CloseErrorPanel()`
- `public Void CloseScenarioDescriptionMenu()`
- `public Void CountCitiesOnTheMap()`
- `public Void GenerateBorders()`
- `public Void GenerateRoadsOnMap()`
- `public Void ManageCampaignWindows()`
- `public Void ManageEventsPanel_Button()`
- `public Void ManageIsAlwaysWinter()`
- `public Void ManageMapSettingsMenu()`
- `public Void ManageSaveAsPanel()`
- `public Void ManageScenarioDescription(String p_value)`
- `public Void ManageStoreMenu()`
- `public Void ManageUI()`
- `public Void ManageWeatherPanel()`
- `public Void PlaytestMap()`
- `public Void QuitToMainMenu()`
- `public Void RandomizeTerrain()`
- `public Void RefreshScenarioTextValues()`
- `public Void RemoveAllUnits_Button(Boolean p_fromVPsonly)`
- `public Void RemovePlayer(Player p_player)`
- `public Void RemoveTilesDOWN()`
- `public Void RemoveTilesLEFT()`
- `public Void RemoveTilesRIGHT()`
- `public Void RemoveTilesUP()`
- `public Void RenameSelectedUnit()`
- `public Void ResetSaveToPlayableMap()`
- `public Void ResetTerrain()`
- `public Void SaveMapAs()`
- `public Void SaveTheMap()`
- `public Void SelectPlayer(Player p_player)`
- `public Void SelectTile(Tile tile)`
- `public Void SendUnitBackIntoReserve()`
- `public Void SetBadWeatherMonthChance(TMP_InputField p_TMP_InputField)`
- `public Void SetBaseCoreUnitValue()`
- `public Void SetCircularMap_Toggle()`
- `public Void SetCityName()`
- `public Void SetCountryForPlayer(Player p_player, TMP_Dropdown p_Dropdown)`
- `public Void SetDamageToWin()`
- `public Void SetDayForMap()`
- `public Void SetDisabledWeather_Toggle()`
- `public Void SetDisableManpower_Toggle()`
- `public Void SetDisablePurchases_Toggle()`
- `public Void SetDisableResearch_Toggle()`
- `public Void SetDisableUpkeep_Toggle()`
- `public Void SetEditorIncomeOverwrite()`
- `public Void SetEditorManpowerOverwrite()`
- `public Void SetFactionDamageToWin(TMP_Dropdown p_dropdown)`
- `public Void SetFactionTilesToBombToWin(TMP_Dropdown p_dropdown)`
- `public Void SetFilter()`
- `public Void SetIsCampaign_Toggle()`
- `public Void SetIsOfficial_Toggle()`
- `public Void SetMapYear()`
- `public Void SetMoneyAmount(TMP_InputField inputField, Player player)`
- `public Void SetMonthForMap()`
- `public Void SetNextMap1()`
- `public Void SetNextMap1Defeat()`
- `public Void SetNextMap2()`
- `public Void SetNextMap2Defeat()`
- `public Void SetNumberOfDaysThatGoByPerTurn()`
- `public Void SetNumberOfTurnsToWin()`
- `public Void SetOriginalOwnerVP()`
- `public Void SetOwner()`
- `public Void SetPerRankCoreUnit()`
- `public Void SetPlayerAsComputer(Player p_player)`
- `public Void SetPlaysFirst(Player p_player)`
- `public Void SetScenarioNameAndDescription()`
- `public Void SetSnowInWinter_Toggle()`
- `public Void SetTilesToBombToWin()`
- `public Void SetWeatherBasePredictionAccuracy(TMP_InputField p_TMP_InputField)`
- `public Void SetWeatherMaxTurnsPrediction(TMP_InputField p_TMP_InputField)`
- `public Void SetWeatherPredictionDailyAccuracyLoss(TMP_InputField p_TMP_InputField)`
- `public Void SetXPendScenario()`
- `public Void SetXPSecondaryObjectives()`
- `public Void ShowHideAllUnitsOnTheMap()`
- `public Void ShowPlayerInfos(Player p_player)`
- `public Void SpawnUnitsOnMap(Boolean p_garrisonOnly)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void AutoCloseSavePopup()`
- `private Void Awake()`
- `private Void ChangeBrushSize()`
- `private Void CreateTheMap()`
- `private Void OnApplicationQuit()`
- `private Void Populate()`
- `private Void QuitToMainMenuConfirmation()`
- `private Void RefreshLandOwners()`
- `private Void RefreshListOfPlayerSlots()`
- `private Void RemoveAllUnits(Boolean p_fromVPsonly)`
- `private Void RemoveAllUnitsConfirmation()`
- `private Void ReOrderPlayers(Player p_player, TMP_InputField p_TMP_InputField)`
- `private Void ResetTerrainConfirmation()`
- `private Void SaveBackupMapResize()`
- `private Void SetFactionForPlayer(Player p_player, TMP_Dropdown p_Dropdown)`
- `private Void SetflagForVP(Player pOwner)`
- `private Void SetIdeologyForPlayer(Player p_player, TMP_Dropdown p_Dropdown)`
- `private Void SetMiniatureFilter()`
- `private Void SetPaintMode(PaintMode p_paintMode)`
- `private Void SpawnTheUnit(Unit unitToSpawn, GameObject tile)`
- `private Void Start()`
- `private Void Update()`
- `private Void UpdateMapCreationTime()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public PlayerSlotMapEditor _playerSlot_prefab`
- `public GameObject addLevelButton`
- `public TMP_InputField baseCoreUnitsValue_InputField`
- `public GameObject brush`
- `public Image brush_image`
- `public Sprite[] brusheTypes_sprites`
- `public static Int32 brushSize`
- `public TextMeshProUGUI brushSize_Text`
- `public GameObject campaignBox`
- `public Toggle circularMap_toggle`
- `public Sprite city_DesertSprite`
- `public Sprite city_SummerSprite`
- `public Sprite city_WinterSprite`
- `public GameObject cityGO`
- `public GameObject cityName_Holder`
- `public TMP_InputField cityName_InputField`
- `public Sprite coast_DesertSprite`
- `public Sprite coast_SummerSprite`
- `public Sprite coast_WinterSprite`
- `public GameObject coastGO`
- `public TMP_InputField coreUnitsPerRank_InputField`
- `public String country`
- `public TMP_InputField customHealthForUnit_Inputfield`
- `public TMP_InputField customIncome_Inputfield`
- `public TMP_InputField customManpower_Inputfield`
- `public TMP_InputField customNameForUnit_Inputfield`
- `public TMP_Dropdown damageToWin_dropdown`
- `public TMP_InputField damageToWin_InputField`
- `public TMP_InputField dayMap_InputField`
- `public Sprite defense_DesertSprite`
- `public Sprite defense_SummerSprite`
- `public Sprite defense_WinterSprite`
- `public GameObject defenseGO`
- `public GameObject devMenuPanel`
- `public Toggle disableManpower`
- `public Toggle disablePurchases`
- `public Toggle disableResearch`
- `public Toggle disableUpkeep`
- `public TMP_InputField entrenchmentOnStart_Inputfield`
- `public TextMeshProUGUI error_Description`
- `public GameObject errorPanel`
- `public EventPanelGO events_panel`
- `public Transform eventsParent`
- `public static String filter`
- `public Sprite forest_SummerSprite`
- `public Sprite forest_WinterSprite`
- `public GameObject forestGO`
- `public Sprite harbour_DesertSprite`
- `public Sprite harbour_SummerSprite`
- `public Sprite harbour_WinterSprite`
- `public GameObject harbourGO`
- `public TMP_InputField inputDaysThatGoByPerTurn_InputField`
- `public static MapEditorGO instance`
- `public static Boolean isAlwaysWinter`
- `public Toggle isCampaign`
- `public Toggle isOfficial`
- `public Sprite junction_SummerSprite`
- `public Sprite junction_WinterSprite`
- `public GameObject junctionGO`
- `public Transform listOfPlayersContainer`
- `public static Map mapCopy`
- `public TextMeshProUGUI mapCreationTime_text`
- `public TextMeshProUGUI mapSize_Text`
- `public TMP_InputField monthMap_InputField`
- `public TMP_InputField newSizeDOWN`
- `public TMP_InputField newSizeLEFT`
- `public TMP_InputField newSizeRIGHT`
- `public TMP_InputField newSizeUP`
- `public TMP_InputField nextMapDefeat1_inputfield`
- `public TMP_InputField nextMapDefeat2_inputfield`
- `public TMP_InputField nextMapVictory1_inputfield`
- `public TMP_InputField nextMapVictory2_inputfield`
- `public GameObject noAmmoTurn1Button`
- `public GameObject noEntrenchmentTurn1Button`
- `public TMP_InputField numberOfTurnsToWin_InputField`
- `public TMP_InputField originalOwnerCountry_inputfield`
- `public static PaintMode paintMode`
- `public GameObject parent`
- `public TMP_Dropdown playerListScenarioTexts_dropdown`
- `public static GameObject previousTile`
- `public static String previousTileRoad`
- `public Sprite RailroadBridge_DesertSprite`
- `public Sprite RailroadBridge_SummerSprite`
- `public Sprite RailroadBridge_WinterSprite`
- `public GameObject RailroadBridgeGO`
- `public Sprite railways_DesertSprite`
- `public Sprite railways_SummerSprite`
- `public Sprite railways_WinterSprite`
- `public GameObject railwaysGO`
- `public GameObject relocateUnitButton`
- `public GameObject removeLevelButton`
- `public GameObject removeUnitButton`
- `public GameObject reserve_Panel`
- `public GameObject rightClick_Panel`
- `public Sprite river_DesertSprite`
- `public Sprite river_SummerSprite`
- `public Sprite river_WinterSprite`
- `public GameObject riverGO`
- `public Sprite road_DesertSprite`
- `public Sprite road_SummerSprite`
- `public Sprite road_WinterSprite`
- `public Sprite roadBridge_DesertSprite`
- `public Sprite roadBridge_SummerSprite`
- `public Sprite roadBridge_WinterSprite`
- `public GameObject roadBridgeGO`
- `public GameObject roadGO`
- `public TMP_InputField saveAs_inputField`
- `public GameObject saveAsPanel`
- `public TMP_InputField scenarioDescription_InputField`
- `public GameObject scenarioDescription_panel`
- `public TMP_InputField scenarioName_InputField`
- `public GameObject scenarioSettings_Panel`
- `public static String season`
- `public static GameObject selectedPlacedTile`
- `public static Tile selectedTile`
- `public TextMeshProUGUI selectedTileCoordinates_text`
- `public static GameObject selectedTileGO`
- `public GameObject selectedTileIcon`
- `public static Unit selectedUnitForRename`
- `public static Boolean setTileValueBoolean`
- `public GameObject setVpToBeHeldButton`
- `public Toggle snowInWinter_toggle`
- `public GameObject store_Panel`
- `public TileEditorGO[,] TableOfAllTiles`
- `public List`1 teamsDropdowns`
- `public Sprite terrain_DesertSprite`
- `public Sprite terrain_SummerSprite`
- `public Sprite terrain_WinterSprite`
- `public GameObject terrainGO`
- `public GameObject tileChoiceContainer`
- `public TileEditorGO tilePrefab`
- `public TMP_Dropdown tilesToBombToWin_dropdown`
- `public TMP_InputField tilesToBombToWin_InputField`
- `public GameObject tooltip`
- `public GameObject UI`
- `public TMP_InputField unitID_Inputfield`
- `public TMP_InputField unitLevelOnStart_Inputfield`
- `public Transform unitParent`
- `public GameObject unitPrefab`
- `public Toggle weatherDisabled_toggle`
- `public TMP_InputField XPperScenario_InputField`
- `public TMP_InputField XPperSecondaryVP_InputField`
- `public TMP_InputField yearMap_InputField`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 _availableTeamsSecondary`
- `private String _buttonChoice`
- `private Int32 _citiesCount`
- `private Boolean _confirmationParameter1`
- `private Vector3 _lastMousePosition`
- `private List`1 _listOfTilesToChooseFrom`
- `private Single _mapCreationTimer`
- `private String _selectedTextEdition`
- `private List`1 _weatherMonths_inputfields`
- `private GameObject _weatherPanel`
- `private TMP_InputField _weatherPrediction_baseAccuracyValue_inputfield`
- `private TMP_InputField _weatherPrediction_dailyAccuracyLoss_inputfield`
- `private TMP_InputField _weatherPrediction_maxTurnsForecast_inputfield`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass199_0`
- `private class <>c__DisplayClass199_1`
- `private class <>c__DisplayClass262_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MapEditorGO), "PrivateMethodName", MethodType.Normal)]
class Patch_MapEditorGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MapEditorGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MapEditorMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Back()`
- `public Void BrowseMaps()`
- `public Void ConfirmDeleteMap()`
- `public Void DeleteMap()`
- `public Void ModifyMap()`
- `public Void NewMap()`
- `public Void RefreshListOfMaps()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private IEnumerator CR_CheckFiles()`
- `private Void MapChoice(FileInfo p_fileInfo)`
- `private Void OnEnable()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Transform container`
- `public static Boolean isLoadedMapEditor`
- `public static String mapName`
- `public static Int32 sizeX`
- `public static Int32 sizeY`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private String _mapsPath`
- `private Button delete_Button`
- `private Int32 fileCount`
- `private TMP_InputField inputX`
- `private TMP_InputField inputY`
- `private Single lastClick`
- `private TMP_InputField mapName_inputfield`
- `private SimpleSlotUI mapSlot_Prefab`
- `private Button modify_button`
- `private Button newMap_button`
- `private TMP_InputField searchInputfield`
- `private TextMeshProUGUI selectedMap_name`

### Nested Types

- `private class <>c__DisplayClass23_0`
- `private class <CR_CheckFiles>d__20`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MapEditorMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_MapEditorMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MapEditorMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MapGeneratorGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ChangeAmountOfPlayers()`
- `public Void ChangeBocageAmountSlider()`
- `public Void ChangeCitiesAmountSlider()`
- `public Void ChangeDesertRocksAmountSlider()`
- `public Void ChangeDunesAmountSlider()`
- `public Void ChangeHillsAmountSlider()`
- `public Void ChangeMarshAmountSlider()`
- `public Void ChangeMountainAmountSlider()`
- `public Void ChangeThickForestAmountSlider()`
- `public Void ChangeThinForestAmountSlider()`
- `public Void ChangeWaterAmountSlider()`
- `public Void ManagePanel()`
- `public Void RefreshPlayersSlotUI()`
- `public Void SelectCountryForPlayer()`
- `public Void SelectFactionForPlayer()`
- `public Void SetAIForAll()`
- `public Void SetHorizontalLayout()`
- `public Void SetIsAIForPlayer()`
- `public Void SetPlaysFirstForPlayer()`
- `public Void SetRandomCountryForAll()`
- `public Void SetVerticalLayout()`
- `public Void StartGame()`
- `public Void StartGeneratingTheMap()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Boolean AreWeGoodToStartGenerating()`
- `private Void GenerateRoads()`
- `private Void GenerateTheMap()`
- `private Void GiveMoneyToPlayers()`
- `private Void OnEnable()`
- `private Void PlaceAirfield(Tile p_Tile)`
- `private Void PlaceBocage(Tile p_tile)`
- `private Void PlaceCities(Tile p_tile)`
- `private Void PlaceDesertRocks(Tile p_tile)`
- `private Void PlaceDunes(Tile p_tile)`
- `private Void PlaceFactory(Tile p_Tile)`
- `private Void PlaceHarbour(Tile p_Tile)`
- `private Void PlaceHills(Tile p_tile)`
- `private Void PlaceMarsh(Tile p_tile)`
- `private Void PlaceMountains(Tile p_tile)`
- `private Void PlaceThickForests(Tile p_tile)`
- `private Void PlaceThinForests(Tile p_tile)`
- `private Void PlaceVictoryPoints(Tile p_Tile)`
- `private Void PlaceWater(Tile p_tile)`
- `private Void SaveTheMap()`
- `private Void SpawnUnits()`
- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Transform parent`
- `public GameObject slotPrefab`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TMP_Dropdown _biome_dropdown`
- `private Slider _bocage_slider`
- `private TextMeshProUGUI _bocageAmount_text`
- `private Int32 _bocageChance`
- `private Slider _cities_slider`
- `private TextMeshProUGUI _citiesAmount_text`
- `private Int32 _cityChance`
- `private TMP_InputField _day_inputfield`
- `private TMP_InputField _daysPerTurn_inputfield`
- `private Slider _desertRock_slider`
- `private TextMeshProUGUI _desertRockAmount_text`
- `private Int32 _desertRocksChance`
- `private Slider _dunes_slider`
- `private TextMeshProUGUI _dunesAmount_text`
- `private Int32 _dunesChance`
- `private Slider _hillsAmount_slider`
- `private TextMeshProUGUI _hillsAmount_text`
- `private Int32 _hillsChance`
- `private Slider _marsh_sider`
- `private TextMeshProUGUI _marshAmount_text`
- `private TMP_InputField _month_nputfield`
- `private Slider _mountain_slider`
- `private TextMeshProUGUI _mountainAmount_text`
- `private TMP_InputField _numberOfPlayers_inputfield`
- `private Int32 _playersAmount`
- `private Int32 _seaChance`
- `private String _season`
- `private TMP_InputField _sizeX_inputfield`
- `private TMP_InputField _sizeY_inputfield`
- `private Slider _thickForestAmount_slider`
- `private TextMeshProUGUI _thickForestAmount_text`
- `private Int32 _thickForestsChance`
- `private Slider _thinForestAmount_slider`
- `private TextMeshProUGUI _thinForestAmount_text`
- `private Int32 _thinForestsChance`
- `private Int32 _totalVPsOnMap`
- `private Int32 _townChance`
- `private Int32 _villageChance`
- `private Int32 _VPperPlayer`
- `private Slider _waterAmount_slider`
- `private TextMeshProUGUI _waterAmount_text`
- `private TMP_InputField _year_inputfield`
- `private Toggle AIonlyToggle`
- `private Toggle airfieldGenerationToggle`
- `private Toggle bocagePropagationToggle`
- `private Toggle desertRockPropagationToggle`
- `private Toggle dunesPropagationToggle`
- `private Toggle factoriesGenerationToggle`
- `private Toggle hillsPropagationToggle`
- `private Toggle horizontalLayout_toggle`
- `private Toggle islandsOnlyToggle`
- `private Toggle marshPropagationToggle`
- `private Toggle mountainPropagationToggle`
- `private Toggle randomizedCountriesToggle`
- `private Toggle randomizedFactionToggle`
- `private Toggle roadGenerationToggle`
- `private Toggle spawnUnitsToggle`
- `private Toggle thickForestPropagationToggle`
- `private Toggle thinForestPropagationToggle`
- `private Toggle verticalLayout_toggle`
- `private Toggle waterPropagationToggle`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MapGeneratorGO), "PrivateMethodName", MethodType.Normal)]
class Patch_MapGeneratorGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MapGeneratorGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MapGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public static GameStates CheckEndOfScenarioHoldingAllMajorVPs()`
- `public static GameStates CheckEndOfScenarioHoldingAllVPs()`
- `public static GameStates CheckEndOfScenarioHoldingVPs()`
- `public static GameStates CheckEndOfScenarioTargetsUnits()`
- `public static Void CheckIfEndOfScenario()`
- `public Void ClearCommanderTiles()`
- `public static Void ClearTargetedUnits()`
- `public static EndGameResults ConvertGameStateInGameResult(GameStates p_gameState)`
- `public Void DestroyPotentialTilesAboveMap()`
- `public Void DrawBordersOnMap()`
- `public static GameStates HasReachedMaxDamageToDeal()`
- `public static GameStates HasReachedMaxTilesToBomb()`
- `public static GameStates HasReachedTurnLimit()`
- `public static Boolean IsThereACertainTileAround(TileGO p_tileGO, String p_type, Boolean p_compareToGivenPlayer = False)`
- `public static Void PlaceFogOfWarEverywhere()`
- `public static Void RefreshAlliancesAndWarsForCurrentPlayers()`
- `public Void RefreshPoliticalMap(Boolean p_overwriteBeingDisabled)`
- `public static Void RemoveBordersFOW()`
- `public static Void RemoveFogOfWarAroundUnits()`
- `public static Void RemoveFogOfWarAroundVictoryPoint()`
- `public static Void RemovePlayerSavedFOW()`
- `public Void ShowPotentialtileColor(Boolean isDeployment)`
- `public Void StartScenario()`
- `public Void TogglePoliticalMap()`
- `public Void UnselectUnit()`
- `public Void UpdateCountryNamesOpacity()`
- `public Void UpdateVpsList()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void AssignGeographicalAreas()`
- `private Void Awake()`
- `private Void ClearCountryNames()`
- `private Void GenerateCountryNames()`
- `private Void GenerateMapAndInitializePlayers()`
- `private Void GeneratePoliticalMap()`
- `private Void LoadPrevCampaignPlayers()`
- `private Void MakeUnitsFaceRightDirection()`
- `private Void OnApplicationQuit()`
- `private Void RespawnPlayerUnits(TileGO p_tileGO, Unit p_unit)`
- `private Void SetupDiplomacyOnMapStarts()`
- `private Void SetupValidHarboursForAI()`
- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public TMP_Text _politicalCountryName_textmesh`
- `public PoliticalHexRenderer _politicalHexRenderer_prefab`
- `public TileGO baseTilePrefab`
- `public Transform commandersParent`
- `public static const Single DISTANCE_BETWEEN_TWO_TILES`
- `public static Boolean INeedToMakeABackupOfTheCampaign`
- `public static MapGO instance`
- `public static Boolean IsAIOnly`
- `public static Boolean isOver`
- `public GameObject leftSideUI_Panel`
- `public static List`1 listOfAllBridgesOnTheMap`
- `public static List`1 listOfAllGeneralsOnTheMap`
- `public List`1 listOfAllUnits`
- `public static List`1 listOfAllVps`
- `public static List`1 listOfCurrentPlayerVPs`
- `public static List`1 listOfPotentialTilesAboveTheMap`
- `public static HashSet`1 listOfSpawnableTiles`
- `public static List`1 listOfTargetedUnit`
- `public GameObject moreStatsPanel`
- `public static Int32 numberOfCapturedMajorVPByFaction`
- `public static Int32 numberOfMajorVP`
- `public static Player onSaveLoadedHumanPlayer`
- `public GameObject otherUnitStatsPanel`
- `public GameObject panelAllStatsOtherUnit`
- `public GameObject panelAllStatsSelectedUnit`
- `public Transform politicalMap_parent`
- `public GameObject potentialDamagePanel`
- `public Transform potentialTiles_parent`
- `public static HashSet`1 radarDetections`
- `public static UnitGO selectedUnitGO`
- `public GameObject selectedUnitIcon`
- `public Vector3 selectedUnitIconOriginalScale`
- `public Vector3 selectedUnitIconOriginalScaleBIG`
- `public GameObject selectedUnitStatsPanel`
- `public static HashSet`1 sonarDetections`
- `public GameObject startScenario_Panel`
- `public Transform targetsParent`
- `public static Stopwatch timeElapsedSinceGameStarted`
- `public static Unit unitBeforeRightClickStats`
- `public UnitGO unitCorePrefab`
- `public UnitGO unitPrefab`
- `public Transform unitsParent`
- `public GameObject unitStatsPanel`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 _countryNames`
- `private AnimationCurve _countryNamesOpacity_curve`
- `private PoliticalHexRenderer[,] _politicalHexRenderers`
- `private Slider _politicalMapOpacity_slider`
- `private GameObject _politicalMapOpacityBox`
- `private AnimationCurve _politicalNameSize_curve`

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MapGO), "PrivateMethodName", MethodType.Normal)]
class Patch_MapGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MapGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MapOverlayManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OpenFileManager()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Cancel()`
- `private IEnumerator CR_LoadOverlay(Boolean p_isAutoLoad)`
- `private Void Start()`
- `private Void Success(String[] p_values)`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String[] filePath`
- `public SpriteRenderer spriteRenderer`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean _inputFieldSelected`
- `private static const Single DEFAULT_SCALE`

### Nested Types

- `private class <CR_LoadOverlay>d__9`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MapOverlayManager), "PrivateMethodName", MethodType.Normal)]
class Patch_MapOverlayManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MapOverlayManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MessageBoxGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void CloseMessageBox()`
- `public Void Update()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public TextMeshProUGUI message_Text`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MessageBoxGO), "PrivateMethodName", MethodType.Normal)]
class Patch_MessageBoxGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MessageBoxGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Mod

**Base Class:** `ModBase`

### Public Methods

- `public virtual Void LoadAssemblies()`
- `public virtual Void PatchMod()`
- `public virtual Void UnloadMod()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Mod), "PrivateMethodName", MethodType.Normal)]
class Patch_Mod_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Mod), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModBase

**Modifiers:** `abstract`

### Public Methods

- `public virtual abstract Void LoadAssemblies()`
- `public virtual abstract Void PatchMod()`
- `public virtual abstract Void UnloadMod()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public ModPropertyBag ModDataBag` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public List`1 assemblies`
- `public CustomCountries customCountries`
- `public CustomTiles customTiles`
- `public CustomUnits customUnits`
- `public List`1 gameModifications`
- `public String installLocation`
- `public ModdedHeroes moddedHeroes`
- `public ModifiedBaseTiles modifiedBaseTiles`
- `public ModifiedBaseUnits modifiedBaseUnits`
- `public String name`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private readonly ModPropertyBag <ModDataBag>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModBase), "PrivateMethodName", MethodType.Normal)]
class Patch_ModBase_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModBase), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModdedHeroes

### Public Methods

- `public Void CreateFileBaseMod(String path)`
- `public Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public List`1 heroes` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String fileLocation`
- `public static const String FILENAME`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 <heroes>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModdedHeroes), "PrivateMethodName", MethodType.Normal)]
class Patch_ModdedHeroes_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModdedHeroes), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModifiedBaseTiles

### Public Methods

- `public Void CreateFileBaseMod(String path)`
- `public Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Dictionary`2 tiles` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String fileLocation`
- `public static const String FILENAME`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Dictionary`2 <tiles>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModifiedBaseTiles), "PrivateMethodName", MethodType.Normal)]
class Patch_ModifiedBaseTiles_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModifiedBaseTiles), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModifiedBaseUnits

### Public Methods

- `public Void CheckInvalidAllowedRotations()`
- `public Void ConvertToNewSystem()`
- `public Void CreateFileBaseMod(String path)`
- `public Void RemoveDuplicates()`
- `public Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Dictionary`2 units` { get; set }
- `public List`1 Units` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String fileLocation`
- `public static const String FILENAME`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Dictionary`2 <units>k__BackingField`
- `private List`1 <Units>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModifiedBaseUnits), "PrivateMethodName", MethodType.Normal)]
class Patch_ModifiedBaseUnits_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModifiedBaseUnits), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModManifest

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String dependencies`
- `public String modAuthor`
- `public String modDescription`
- `public String modName`
- `public String modVersion`
- `public String supportedGameVersion`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModManifest), "PrivateMethodName", MethodType.Normal)]
class Patch_ModManifest_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModManifest), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModPanelGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ApplyChanges()`
- `public Void CreateMod()`
- `public Void OpenModsFolder()`
- `public Void OpenTutorialYoutube()`
- `public Void OpenWorkshopPanel()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void ClearImage()`
- `private Void ClickOnMod(FileInfo p_fileInfo)`
- `private Void ConfirmDeleteMod()`
- `private Void CopyIfExists(String sourceRelative, String destAbsolute)`
- `private IEnumerator CR_CheckFiles()`
- `private IEnumerator CR_LoadThumbnail(String p_thumbnailPath)`
- `private Void DeleteMod(FileInfo p_fileInfo)`
- `private Void InstantiateSlot(ModItem p_modItem, ModSlotGO p_prefab, Transform p_parent)`
- `private Void OnEnable()`
- `private Void OnUGCDetailsResult(SteamUGCRequestUGCDetailsResult_t p_result, Boolean p_IOFailure)`
- `private Void OpenModFolder(FileInfo p_fileInfo)`
- `private Void RefreshMods()`
- `private Void RetrieveModInfos(PublishedFileId_t p_publishedFileID)`
- `private Void ToggleMod(String p_modName)`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Transform _activeModsContainer`
- `private ModSlotGO _activeModSlot_prefab`
- `private Transform _availableModsContainer`
- `private ModSlotGO _availableModSlot_prefab`
- `private Button _create_button`
- `private Byte[] _filesCheckSum`
- `private TextMeshProUGUI _modAuthor_text`
- `private TextMeshProUGUI _modDependencies_text`
- `private TextMeshProUGUI _modDescription_text`
- `private GameObject _modInformationWindow`
- `private TMP_InputField _modName_inputfield`
- `private String _modsPath`
- `private TextMeshProUGUI _modSupportedVersion_text`
- `private TextMeshProUGUI _modVersion_text`
- `private FileInfo _selectedMod`
- `private SteamWorkshopMenu _steamWorkshopMenu`
- `private Image _thumbnail_image`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass27_0`
- `private class <>c__DisplayClass28_0`
- `private class <CR_CheckFiles>d__38`
- `private class <CR_LoadThumbnail>d__36`
- `private class ModItem`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModPanelGO), "PrivateMethodName", MethodType.Normal)]
class Patch_ModPanelGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModPanelGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModProperty`1

**Modifiers:** `sealed`

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Object BoxedValue` { get }
- `public T Value` { get }
- `public Type ValueType` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private readonly T <Value>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModProperty`1), "PrivateMethodName", MethodType.Normal)]
class Patch_ModProperty`1_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModProperty`1), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModPropertyBag

**Modifiers:** `sealed`

### Public Methods

- `public Void Clear()`
- `public Boolean HasKey(String p_key, Boolean p_includeUnknowns = False)`
- `public Boolean Remove(String p_key)`
- `public Boolean TryGet(String p_key, T& o_value)`
- `public Boolean TrySet(String p_key, T p_value, Boolean preferKnownOverUnknown = False)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private static Object DeserializeKnown(DataTypes p_dataType, Byte[] p_payload)`
- `private Boolean RemoveUnknownByID(UInt32 p_ID)`
- `private static Byte[] SerializeKnown(DataTypes p_dataType, Object p_object)`
- `private Void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo p_info, StreamingContext p_context)`
- `private static Boolean TryDeserializeCustom(Byte[] p_blob, Object& o_value)`
- `private static Boolean TryGetSystemType(DataTypes p_dataType, Type& o_type)`
- `private static Boolean TryGetTypeCode(Type p_type, DataTypes& o_dataType)`

### Public Properties

- `public Int32 CountKnowns` { get }
- `public Int32 CountTotal` { get }
- `public Int32 CountUnknowns` { get }
- `public Boolean IsEmpty` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

- `private Dictionary`2 FirstKeyString` { get }

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Dictionary`2 _firstKeyString`
- `private readonly Dictionary`2 _propertiesByID`
- `private readonly List`1 _unknownEntries`
- `private static const Int32 MaxEntries`
- `private static const Int32 MaxTotalSize`

### Nested Types

- `private class <>c`
- `private class DataTypes`
- `private class DTO`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModPropertyBag), "PrivateMethodName", MethodType.Normal)]
class Patch_ModPropertyBag_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModPropertyBag), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button deleteMod_button`
- `public Single installSize`
- `public Button manageMod_button`
- `public Button mod_button`
- `public TextMeshProUGUI modName_text`
- `public Button openMod_button`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModSlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_ModSlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModSlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ModsManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public static Void ApplyModdedTilesChanges()`
- `public static Void ApplyModdedUnitsChanges()`
- `public static Mod FindModByName(String p_modName)`
- `public static List`1 GetModdedCountries(Boolean p_sort)`
- `public static List`1 GetModdedTilesChanges()`
- `public static List`1 GetModdedUnitsChanges()`
- `public static Void GetUserSubscribedWorkshopMods()`
- `public Void LoadAllMods()`
- `public static Void SaveCountriesAllMods()`
- `public static Void SaveHeroesAllMods()`
- `public static Void SaveTilesAllMods()`
- `public static Void SaveUnitsAllMods()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void ChangeWallpaperVideo()`
- `private IEnumerator CR_ChangeWallpaper()`
- `private IEnumerator CR_LoadContent()`
- `private Void PlayRandomModdedMusic()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

- `public static Int32 ModdedCountriesCount` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static List`1 activeMods`
- `public static const String ATTACK`
- `public static const String CUSTOM_COUNTRIES`
- `public static const String CUSTOM_HEROES`
- `public static const String CUSTOM_TILES`
- `public static const String CUSTOM_UNITS`
- `public static const String FLAGS`
- `public static const String GRAPHICS`
- `public static const String HEROES`
- `public static ModsManager instance`
- `public static const String LIBRARIES`
- `public static const String MAPS`
- `public static const Int32 MODDED_HEROES_SIZE`
- `public static const Int32 MODDED_TILES_SIZE`
- `public static const Int32 MODDED_UNITS_SIZE`
- `public static List`1 moddedAttackSounds`
- `public static List`1 moddedFlagsGraphics`
- `public static List`1 moddedHeroesGraphics`
- `public static List`1 moddedMaps`
- `public static List`1 moddedMovementSounds`
- `public static List`1 moddedMusics`
- `public static List`1 moddedTilesGraphics`
- `public static List`1 moddedUnitsGraphics`
- `public static List`1 moddedVideos`
- `public static List`1 moddedWallpapers`
- `public static readonly String[] ModHierarchy`
- `public static const String MODIFIED_BASE_TILES`
- `public static const String MODIFIED_BASE_UNITS`
- `public static const String MOVEMENT`
- `public static const String MUSICS`
- `public static Mod selectedMod`
- `public static const String SOUNDS`
- `public static const String TILES`
- `public static const String UNITS`
- `public static const String VIDEOS`
- `public static const String WALLPAPERS`
- `public static Dictionary`2 workshopMods`
- `public static Dictionary`2 workshopModsTitles`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private readonly List`1 _authorizedExtensionsForModding`
- `private Slider _contentLoading_slider`
- `private AudioClip _defaultSoundtrack`
- `private Sprite _defaultWallpaper`
- `private String _fileBeingLoaded`
- `private TextMeshProUGUI _fileLoaded_text`
- `private static Boolean _hasLoadedAllMods`
- `private Boolean _isContentBeingLoaded`
- `private GameObject _loadingContent_window`
- `private String _modBeingLoaded`
- `private TextMeshProUGUI _modBeingLoaded_text`
- `private Int32 _numberOfFilesLoaded`
- `private Int32 _numberOfFilesToLoad`
- `private GameObject _video_panel`
- `private VideoPlayer _videoPlayer`
- `private Image _wallpaper_Image`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass66_0`
- `private class <>c__DisplayClass71_0`
- `private class <>c__DisplayClass71_1`
- `private class <CR_ChangeWallpaper>d__73`
- `private class <CR_LoadContent>d__71`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ModsManager), "PrivateMethodName", MethodType.Normal)]
class Patch_ModsManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ModsManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MoneyTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void OnDisable()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private GameObject _tooltip`
- `private TextMeshProUGUI antiairUpkeep_text`
- `private TextMeshProUGUI antitankUpkeep_text`
- `private TextMeshProUGUI artilleryUpkeep_text`
- `private TextMeshProUGUI baseIncome_text`
- `private TextMeshProUGUI buildingsUpkeep_text`
- `private TextMeshProUGUI CASbombersUpkeep_text`
- `private TextMeshProUGUI destroyedCost_text`
- `private TextMeshProUGUI fightersUpkeep_text`
- `private TextMeshProUGUI finalIncomeValue_text`
- `private TextMeshProUGUI heavyBombersUpkeep_text`
- `private TextMeshProUGUI infantryUpkeep_text`
- `private TextMeshProUGUI noWar_text`
- `private TextMeshProUGUI shipsUpkeep_text`
- `private TextMeshProUGUI tanksUpkeep_text`
- `private TextMeshProUGUI upkeepCost_text`
- `private GameObject upkeepPart`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MoneyTooltipGO), "PrivateMethodName", MethodType.Normal)]
class Patch_MoneyTooltipGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MoneyTooltipGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MoraleStates

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const MoraleStates AWFUl`
- `public static const MoraleStates BAD`
- `public static const MoraleStates EXCELLENT`
- `public static const MoraleStates GOOD`
- `public static const MoraleStates NORMAL`
- `public Byte value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MoraleStates), "PrivateMethodName", MethodType.Normal)]
class Patch_MoraleStates_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MoraleStates), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MultiplayerChat

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ChooseChannel(TMP_Dropdown p_TMP_Dropdown)`
- `public Void ConnectChat()`
- `public Boolean ContainsChineseCharacters(String p_text)`
- `public Boolean ContainsJapaneseCharacters(String p_text)`
- `public Boolean ContainsKoreanCharacters(String p_text)`
- `public Boolean ContainsRussianCharacters(String p_text)`
- `public Void DebugReturn(DebugLevel p_level, String p_message)`
- `public Void Disconnect()`
- `public Void JoinChannel(String p_channel)`
- `public Void LeaveChannel(String p_channel)`
- `public Void OnChatStateChange(ChatState p_state)`
- `public Void OnConnected()`
- `public Void OnDisconnected()`
- `public Void OnGetMessages(String p_channelName, String[] p_senders, Object[] p_messages)`
- `public Void OnPrivateMessage(String p_sender, Object p_message, String p_channelName)`
- `public Void OnStatusUpdate(String p_user, Int32 p_status, Boolean p_gotMessage, Object p_message)`
- `public Void OnSubscribed(String[] p_channels, Boolean[] p_results)`
- `public Void OnUnsubscribed(String[] p_channels)`
- `public Void OnUserSubscribed(String p_channel, String p_user)`
- `public Void OnUserUnsubscribed(String p_channel, String p_user)`
- `public Void Reconnect()`
- `public Void RefreshConnectedUsers()`
- `public Void SendMessage_button()`
- `public Void TurnOFFPublicChatAndSubscribe()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void ClearMessages()`
- `private IEnumerator CR_Reconnect()`
- `private Boolean IsChineseCharacter(Char c)`
- `private Boolean IsJapaneseCharacter(Char c)`
- `private Boolean IsKoreanCharacter(Char c)`
- `private Boolean IsRussianCharacter(Char c)`
- `private Void OnApplicationQuit()`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void Start()`
- `private Void SubscribeToChannel(String p_channel)`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static List`1 adminUsernames`
- `public ChatClient chatClient`
- `public GameObject friendManagement_gameobject`
- `public static MultiplayerChat instance`
- `public static Boolean isTyping`
- `public GameObject notification`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Color _admin_color`
- `private HashSet`1 _bannedPeople`
- `private Boolean _isReconnectCRRunning`
- `private Color _localClient_color`
- `private String _localPlayerUsername`
- `private Color _mention_color`
- `private Color _regular_color`
- `private TMP_Dropdown channel_dropdown`
- `private Transform connectedUsers_parent`
- `private static const Int32 HISTORY_SIZE`
- `private TMP_InputField message_inputfield`
- `private TextMeshProUGUI message_prefab`
- `private RectTransform message_rectTransform`
- `private Transform messages_parent`
- `private ConnectedPlayerSlotGO playerOnline_prefab`

### Nested Types

- `private class <>c`
- `private class <CR_Reconnect>d__39`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MultiplayerChat), "PrivateMethodName", MethodType.Normal)]
class Patch_MultiplayerChat_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MultiplayerChat), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MultiplayerManager

**Base Class:** `Photon.Pun.MonoBehaviourPunCallbacks`

### Public Methods

- `public Void ForceFullDataResync()`
- `public virtual Void OnDisable()`
- `public virtual Void OnDisconnected(DisconnectCause p_cause)`
- `public virtual Void OnEnable()`
- `public Void OnEvent(EventData p_photonEvent)`
- `public virtual Void OnMasterClientSwitched(Player p_player)`
- `public virtual Void OnPlayerEnteredRoom(Player p_player)`
- `public virtual Void OnPlayerLeftRoom(Player p_otherPlayer)`
- `public static Void RaiseEvent(Byte eventCode, Object payload)`
- `public static Void RaiseEvent(Byte eventCode, Object[] payloads)`
- `public Void Reconnect()`
- `public static Void RPC(String p_RPCname, Object[] p_args)`
- `public Void RPC_AddPlayer(Byte[] p_bytes)`
- `public Void RPC_AddUnit(Byte[] p_bytes)`
- `public Void RPC_AllianceMade(Byte[] p_bytes)`
- `public Void RPC_AttackUnit(Byte[] p_bytes)`
- `public Void RPC_CaptureVP(Byte[] p_bytes)`
- `public Void RPC_CountryChange(Byte[] p_bytes)`
- `public Void RPC_DespawnUnit(Byte[] p_bytes)`
- `public Void RPC_DisplayAmmoLoss(Byte[] p_bytes)`
- `public Void RPC_DisplayFuelLoss(Byte[] p_bytes)`
- `public Void RPC_DisplayLevelUp(Byte[] p_bytes)`
- `public Void RPC_DisplayXP(Byte[] p_bytes)`
- `public Void RPC_EmbarkDisembark(Byte[] p_bytes)`
- `public Void RPC_EndTurn()`
- `public Void RPC_KillUnit(Byte[] p_bytes)`
- `public Void RPC_MoveUnit(Byte[] p_bytes)`
- `public Void RPC_PlaySound(Byte[] p_bytes)`
- `public Void RPC_RedeployUnit(Byte[] p_bytes)`
- `public Void RPC_RemovePlayer(Byte[] p_bytes)`
- `public Void RPC_RemoveUnit(Byte[] p_bytes)`
- `public Void RPC_ShowDamage(Byte[] p_bytes)`
- `public Void RPC_ShowRelationshipWindow(Byte[] p_bytes)`
- `public Void RPC_SignedPeace(Byte[] p_bytes)`
- `public Void RPC_SpawnUnit(Byte[] p_bytes)`
- `public Void RPC_SwapUnits(Byte[] p_bytes)`
- `public Void RPC_SyncAnything(Byte[] p_bytes)`
- `public Void RPC_SyncEvents(Byte[] p_bytes)`
- `public Void RPC_SyncLineDatas(Byte[] p_bytes)`
- `public Void RPC_SyncNotifications(Byte[] p_bytes)`
- `public Void RPC_SyncPlayer(Byte[] p_bytes)`
- `public Void RPC_SyncPlayerData(Byte[] p_bytes)`
- `public Void RPC_SyncTile(Byte[] p_bytes)`
- `public Void RPC_SyncUnit(Byte[] p_bytes)`
- `public Void RPC_SyncUnitData(Byte[] p_bytes)`
- `public Void RPC_TransferUnit(Byte[] p_bytes)`
- `public Void RPC_WarDeclaration(Byte[] p_bytes)`
- `public Void RunRPC(String p_RPCname, String p_targetCode, Object[] p_args)`
- `public Void RunRPC(String p_RPCname, RpcTarget p_target, Object[] p_args)`
- `public Void RunRPC(String p_RPCname, Player p_player, Object[] p_args)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private IEnumerator CR_ExpireAfter(String p_transferID, Single p_seconds)`
- `private IEnumerator CR_MoveUnitToTile(Unit p_unit, List`1 p_coordinates)`
- `private IEnumerator CR_ReconnectCoroutine()`
- `private IEnumerator CR_SendChunksCoroutine(String p_transferID, Int32 p_totalChunks, Byte[] p_payload)`
- `private Void DataChunkReceived(Object p_object)`
- `private Void DispatchRPC(String p_RPCname, RpcTarget p_target, Object[] p_args)`
- `private Void DispatchRPC(String p_RPCname, Player p_player, Object[] p_args)`
- `private Void DisplayXPchange(Object p_object)`
- `private Void LogError(String p_message, Boolean p_displayOnUI)`
- `private Void OnApplicationQuit()`
- `private Void ProcessEvent(Byte p_eventCode, Object p_object)`
- `private static Void RaiseInternal(Byte p_eventCode, Object p_content)`
- `private Void UpdateAILoadingBar(Object p_object)`

### Public Properties

- `public static MultiplayerManager Instance` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const Int32 CHUNK_SIZE`
- `public static const Byte EventCode_AI_loadingBar`
- `public static const Byte EventCode_ammoLoss_display`
- `public static const Byte EventCode_fuelLoss_display`
- `public static const Byte EventCode_MapChunk`
- `public static const Byte EventCode_XP_display`
- `public static const String IP`
- `public static const String VERSION`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private readonly Dictionary`2 _buffers`
- `private readonly Dictionary`2 _expectedChunks`
- `private Boolean _isRealtimeMultiplayer`
- `private PhotonView _photonView`
- `private Int32 _receivedBytes`
- `private readonly Dictionary`2 _totalBytes`
- `private static MultiplayerManager <Instance>k__BackingField`
- `private static const Byte RELIABLE_CHANNEL`
- `private static const Single SYNC_EXPIRE_TIME`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass33_0`
- `private class <CR_ExpireAfter>d__81`
- `private class <CR_MoveUnitToTile>d__82`
- `private class <CR_ReconnectCoroutine>d__83`
- `private class <CR_SendChunksCoroutine>d__75`
- `public class SyncActions`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MultiplayerManager), "PrivateMethodName", MethodType.Normal)]
class Patch_MultiplayerManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MultiplayerManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## MultiplayerMenu

**Base Class:** `Photon.Pun.MonoBehaviourPunCallbacks`

### Public Methods

- `public Void Browse()`
- `public Void ChangeConfiguration(Player p_player, TMP_Dropdown p_dropdown)`
- `public Void ChangePlayerIncome(Player p_player, Slider p_slider)`
- `public Boolean CheckEmailAddress(String emailaddress)`
- `public Void ChooseMap(OnlineGame game)`
- `public Void CloseDeleteAccountPanel()`
- `public Void CloseLobbiesPanel()`
- `public Void ClosePasswordRequestPanel()`
- `public Void CloseSignupPanel()`
- `public Void ConnectToRegion()`
- `public Void ContinueGame()`
- `public Void CreateRoom()`
- `public Void DeleteAccount()`
- `public Void DeleteGame()`
- `public Task GetAllGamesAsync()`
- `public Task GetAllUsersAsync()`
- `public Void Host()`
- `public Void JoinOpenGame()`
- `public Void JoinRoom(String p_roomName)`
- `public Void KickPlayer_Button(Player p_player)`
- `public Void LeaveRoom()`
- `public Void ManageEULAPanel()`
- `public Void ManageResetPanel()`
- `public Void MapChoice(String p_mapPath)`
- `public virtual Void OnConnectedToMaster()`
- `public virtual Void OnDisable()`
- `public virtual Void OnDisconnected(DisconnectCause cause)`
- `public virtual Void OnEnable()`
- `public virtual Void OnJoinedRoom()`
- `public virtual Void OnJoinRoomFailed(Int16 returnCode, String message)`
- `public virtual Void OnMasterClientSwitched(Player p_player)`
- `public virtual Void OnPlayerEnteredRoom(Player p_photonPlayer)`
- `public virtual Void OnPlayerLeftRoom(Player p_photonPlayer)`
- `public virtual Void OnPlayerPropertiesUpdate(Player p_targetPlayer, Hashtable p_changedProps)`
- `public virtual Void OnRoomListUpdate(List`1 p_rooms)`
- `public Void OpenAccount()`
- `public Void OpenDeleteAccountPanel()`
- `public Void OrganizeLeaderboard(String filter)`
- `public Task Refresh()`
- `public Void RefreshButton()`
- `public Void RefreshListOfMaps()`
- `public Void RequestNewPassword()`
- `public Void SetComputer()`
- `public Void SetFilter(String value)`
- `public Void SetNewPassword()`
- `public Void SetPlayerCountry_Dropdown(TMP_Dropdown p_countryDropdown)`
- `public Void SetPlayerIsReady_Toggle(Toggle p_readyToggle)`
- `public Void SetPlayerPlayingFirst(Toggle p_playingFirstToggle)`
- `public Void SetPlaysFirst(Player p_player, Toggle p_toggle)`
- `public Void SignIn()`
- `public Void SignUp()`
- `public Void StartGame_Button()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void CalculateAndOrderUsersRatio(Dictionary`2 dicOfUnorderedUsers)`
- `private Boolean CheckForStartButton()`
- `private Void CheckIfCanHost()`
- `private Void ClearAllSlotsInParent()`
- `private Void ConnectToMultiplayer()`
- `private IEnumerator CR_StartGameCoroutine()`
- `private Void FreeDownloadBuffer()`
- `private Void GenerateAllSlotsUI()`
- `private IEnumerator RefreshPlayerCount()`
- `private Void RefreshPlayersSlots()`
- `private Void RefreshRoomsSlots()`
- `private Void RPC_KickPlayer()`
- `private Void RPC_ReceiveGameStateChunk(Byte[] p_chunk, Int32 p_chunkIndex, Int32 p_totalChunks, Int32 p_totalBytes)`
- `private static String sha256(String value)`
- `private Void Start()`
- `private Void UpdateCachedRoomList(List`1 p_rooms)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static readonly HttpClient client`
- `public static const String COMPLEXSUPPLIES_SETTING`
- `public static const String COUNTRIES`
- `public static const String DIFFICULTY_SETTING`
- `public static const String FOW_SETTING`
- `public static const String HOST`
- `public static const String INFINITE_AMMOFUEL_SETTING`
- `public static const String MANPOWER_SETTING`
- `public static const String MAPNAME`
- `public static const String MORALE_SETTING`
- `public static const String OVERRUN_SETTING`
- `public static const String PARTISANS_SETTING`
- `public static const String PLANES_ONE_MORE_MOVE_SETTING`
- `public static const String PLAYER_COUNTRY`
- `public static const String PLAYER_NAME`
- `public static const String PLAYER_PLAYING_FIRST`
- `public static const String PLAYER_READY`
- `public static const String PLAYERS`
- `public static const String POLICIES_SETTING`
- `public static const String PRODUCTIONTAKESTIME_SETTING`
- `public static const String RESEARCH_SETTING`
- `public static const String UPKEEP_SETTING`
- `public static const String WEATHER_SETTING`
- `public static const String WINTER_DAMAGE_SETTING`
- `public static const String ZONEOFCONTROL_SETTING`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Dictionary`2 _cachedRoomList`
- `private Boolean _changingRegion`
- `private GameObject _loadingWheel`
- `private Byte[] _rxBuffer`
- `private Int64 _rxReceivedBytes`
- `private Int32 _rxReceivedChunks`
- `private Int32 _rxTotalBytes`
- `private Int32 _rxTotalChunks`
- `private TMP_Dropdown _serverRegion_dropdown`
- `private GameObject archivedGame_prefab`
- `private Boolean ascending`
- `private GameObject bubbleHostedGames`
- `private GameObject chat_panel`
- `private GameObject continue_button`
- `private GameObject continueGame_prefab`
- `private GameObject delete_button`
- `private GameObject deleteAccount_panel`
- `private TMP_InputField deleteAccount_password_inputfield`
- `private TMP_InputField deleteAccount_username_inputfield`
- `private Button deleteAccountButton`
- `private TMP_InputField email_reset_inputfield`
- `private GameObject eula_panel`
- `private Toggle eula_toggle`
- `private Toggle FFAToggle`
- `private String gameFilter`
- `private Dictionary`2 games`
- `private GameObject header_all_players`
- `private GameObject header_archivedGames`
- `private GameObject header_continueGames`
- `private GameObject header_openGames`
- `private GameObject header_photonPlayers`
- `private GameObject header_photonRooms`
- `private Text hostedGamesNumber`
- `private GameObject hostPanel`
- `private GameObject hostPBEM_button`
- `private GameObject hostRealtime_button`
- `private GameObject join_button`
- `private GameObject leaveRoom_button`
- `private Transform listOfMapContainerParent`
- `private GameObject lobbies_panel`
- `private GameObject lobbyContainerBackground`
- `private TextMeshProUGUI loserFriday_text`
- `private TextMeshProUGUI multiplayerVersion_text`
- `private TMP_InputField new_password_confirmation_inputfield`
- `private TextMeshProUGUI new_password_confirmation_text`
- `private TMP_InputField new_password_inputfield`
- `private TextMeshProUGUI new_password_text`
- `private TextMeshProUGUI noGameHosted_text`
- `private TextMeshProUGUI numberOfPlayers_text`
- `private GameObject openGame_prefab`
- `private Transform parent`
- `private GameObject password_reset_panel`
- `private TMP_InputField pin_inputfield`
- `private TextMeshProUGUI pin_text`
- `private String platform`
- `private Transform playerInfoContainer_Transform`
- `private GameObject playerSlot_prefab`
- `private GameObject playerSlotScenario_prefab`
- `private Button requestPasswordResetButton`
- `private GameObject roomSlot_prefab`
- `private TMP_InputField scenarios_inputfield`
- `private GameObject scenariosSlot_prefab`
- `private OnlineGame selectedPBEMgame`
- `private GameObject set_new_password_button`
- `private Button setNewPasswordButton`
- `private GameObject signin_panel`
- `private TMP_InputField signin_password_inputfield`
- `private TMP_InputField signin_username_inputfield`
- `private Button signinButton`
- `private TMP_InputField signup_email_inputfield`
- `private GameObject signup_panel`
- `private TMP_InputField signup_password_inputfield`
- `private TMP_InputField signup_username_inputfield`
- `private Button signupButton`
- `private GameObject start_button`
- `private GameObject user_prefab`
- `private TMP_InputField username_reset_inputfield`
- `private Dictionary`2 users`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass107_0`
- `private class <>c__DisplayClass107_1`
- `private class <>c__DisplayClass107_2`
- `private class <>c__DisplayClass108_0`
- `private class <>c__DisplayClass108_1`
- `private class <>c__DisplayClass118_0`
- `private class <>c__DisplayClass156_0`
- `private class <>c__DisplayClass156_1`
- `private class <>c__DisplayClass163_0`
- `private class <ContinueGame>d__122`
- `private class <CR_StartGameCoroutine>d__153`
- `private class <DeleteAccount>d__171`
- `private class <DeleteGame>d__131`
- `private class <GetAllGamesAsync>d__117`
- `private class <GetAllUsersAsync>d__105`
- `private class <Host>d__114`
- `private class <JoinOpenGame>d__121`
- `private class <Refresh>d__129`
- `private class <RefreshPlayerCount>d__138`
- `private class <RequestNewPassword>d__125`
- `private class <SetNewPassword>d__126`
- `private class <SignIn>d__123`
- `private class <SignUp>d__124`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(MultiplayerMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_MultiplayerMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(MultiplayerMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## NavalHeroes

### Public Methods

- `public static List`1 GetHeroes(String p_country)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(NavalHeroes), "PrivateMethodName", MethodType.Normal)]
class Patch_NavalHeroes_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(NavalHeroes), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## NewMinimap

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerDown(PointerEventData eventData)`
- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`
- `public Void OnPointerUp(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private IEnumerator LerpFromTo(Vector3 pos1, Vector3 pos2, Single duration)`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Camera minimapCamera`
- `public RawImage RawImage`
- `public SpriteRenderer rectangle`
- `public RenderTexture texture`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private AnimationCurve _camSize_height`
- `private AnimationCurve _camSize_width`
- `private Single _clickDownTime`
- `private Single _clickUpTime`
- `private Boolean _dragging`
- `private Boolean _isMouseOverMiniMap`
- `private Single _maxMapSize`
- `private Single _maxZoomLevel`
- `private Single _minMapSize`
- `private Single _minZoomLevel`

### Nested Types

- `private class <LerpFromTo>d__22`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(NewMinimap), "PrivateMethodName", MethodType.Normal)]
class Patch_NewMinimap_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(NewMinimap), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Notification

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Single Amount` { get; set }
- `public String Description` { get; set }
- `public Boolean HasBeenShown` { get; set }
- `public Boolean IsImportant` { get; set }
- `public String OwnerName` { get; set }
- `public Single PosX` { get; set }
- `public Single PosY` { get; set }
- `public String SenderName` { get; set }
- `public Int32 TurnCreated` { get; set }
- `public NotificationTypes Type` { get; set }
- `public String UnitResearchedFilterType` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Single <Amount>k__BackingField`
- `private String <Description>k__BackingField`
- `private Boolean <HasBeenShown>k__BackingField`
- `private Boolean <IsImportant>k__BackingField`
- `private String <OwnerName>k__BackingField`
- `private Single <PosX>k__BackingField`
- `private Single <PosY>k__BackingField`
- `private String <SenderName>k__BackingField`
- `private Int32 <TurnCreated>k__BackingField`
- `private NotificationTypes <Type>k__BackingField`
- `private String <UnitResearchedFilterType>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Notification), "PrivateMethodName", MethodType.Normal)]
class Patch_Notification_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Notification), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## NotificationButtonGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void DestroyNotification()`
- `public Void OnPointerClick(PointerEventData eventData)`
- `public Void Setup(Notification p_notification)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void ConfirmJoinFaction()`
- `private IEnumerator CR_ChangeRingOpacity()`
- `private IEnumerator CR_HighlighTile(Single posX, Single posY)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public TextMeshProUGUI description_text`
- `public GameObject highlightRingPrefab`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Notification _notification`
- `private GameObject _ringInstance_object`

### Nested Types

- `private class <CR_ChangeRingOpacity>d__9`
- `private class <CR_HighlighTile>d__8`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(NotificationButtonGO), "PrivateMethodName", MethodType.Normal)]
class Patch_NotificationButtonGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(NotificationButtonGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## NotificationManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void CenterCameraOnMap(Vector3 endPos)`
- `public Void CreateNewUInotification(Notification p_notification)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private IEnumerator CR_LerpFromTo(Vector3 pos1, Vector3 pos2, Single duration)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static NotificationManager instance`
- `public Transform parent`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private NotificationButtonGO _importantNotification_prefab`
- `private Transform _notificationPanel`
- `private NotificationButtonGO _regularNotification_prefab`
- `private Transform _targetParent`

### Nested Types

- `private class <CR_LerpFromTo>d__8`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(NotificationManager), "PrivateMethodName", MethodType.Normal)]
class Patch_NotificationManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(NotificationManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## NotificationTypes

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const NotificationTypes ALLIANCE_INVITATION`
- `public static const NotificationTypes ALLIANCE_PROPOSITION_ACCEPTED`
- `public static const NotificationTypes ALLIANCE_PROPOSITION_REJECTED`
- `public static const NotificationTypes COUNTRY_CHANGED`
- `public static const NotificationTypes DEFAULT`
- `public static const NotificationTypes MONEY_TRANSFER`
- `public static const NotificationTypes MONEY_TRANSFER_NEUTRALITY`
- `public static const NotificationTypes REINFORCEMENTS_ALLIES`
- `public static const NotificationTypes REINFORCEMENTS_ENEMIES`
- `public static const NotificationTypes REINFORCEMENTS_PLAYER`
- `public static const NotificationTypes RESEARCH_COMPLETE`
- `public static const NotificationTypes TERRITORY_GAIN`
- `public static const NotificationTypes TERRITORY_LOSS`
- `public static const NotificationTypes UNIT_AMBUSH`
- `public static const NotificationTypes UNIT_BLEW_UP`
- `public static const NotificationTypes UNIT_CANNOT_FIND_PATH`
- `public static const NotificationTypes UNIT_DESTROYED`
- `public static const NotificationTypes UNIT_KILLED`
- `public static const NotificationTypes UNIT_LOW_HEALTH`
- `public static const NotificationTypes UNIT_NO_SUPPLIES`
- `public static const NotificationTypes UNIT_PURCHASE`
- `public static const NotificationTypes UNIT_REACHED_DESTINATION`
- `public static const NotificationTypes UNIT_SHOT_DOWN`
- `public static const NotificationTypes UNIT_SUNK`
- `public static const NotificationTypes UNIT_SURRENDERED`
- `public static const NotificationTypes UNIT_TRANSFER`
- `public static const NotificationTypes UNIT_UNDER_ATTACK`
- `public Byte value__`
- `public static const NotificationTypes VP_ANNEXED`
- `public static const NotificationTypes VP_LOST`
- `public static const NotificationTypes VP_OWNERSHIP_LOSS`
- `public static const NotificationTypes VP_RECEIVED`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(NotificationTypes), "PrivateMethodName", MethodType.Normal)]
class Patch_NotificationTypes_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(NotificationTypes), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## OfficialTiles

### Public Methods

- `public static OfficialTiles GetInstance()`
- `public static Void Load()`
- `public static Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public List`1 Tiles` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static readonly Object _myLock`
- `public static OfficialTiles _officialTiles`
- `public static String filePath`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 <Tiles>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(OfficialTiles), "PrivateMethodName", MethodType.Normal)]
class Patch_OfficialTiles_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(OfficialTiles), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## OfficialTilesORIGINAL

### Public Methods

- `public static OfficialTilesORIGINAL GetInstance()`
- `public static Void Load()`
- `public static Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public List`1 Tiles` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static readonly Object _myLock`
- `public static OfficialTilesORIGINAL _officialTilesOriginal`
- `public static String filePath`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 <Tiles>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(OfficialTilesORIGINAL), "PrivateMethodName", MethodType.Normal)]
class Patch_OfficialTilesORIGINAL_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(OfficialTilesORIGINAL), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## OfficialUnits

### Public Methods

- `public static OfficialUnits GetInstance()`
- `public static Void Load()`
- `public static Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public List`1 Units` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static readonly Object _myLock`
- `public static OfficialUnits _officialUnits`
- `public static String filePath`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 <Units>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(OfficialUnits), "PrivateMethodName", MethodType.Normal)]
class Patch_OfficialUnits_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(OfficialUnits), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## OfficialUnitsORIGINAL

### Public Methods

- `public static OfficialUnitsORIGINAL GetInstance()`
- `public static Void Load()`
- `public static Void Save()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public List`1 Units` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static readonly Object _myLock`
- `public static OfficialUnitsORIGINAL _officialUnitsOriginal`
- `public static String filePath`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 <Units>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(OfficialUnitsORIGINAL), "PrivateMethodName", MethodType.Normal)]
class Patch_OfficialUnitsORIGINAL_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(OfficialUnitsORIGINAL), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## OnlineGame

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public String created_on` { get; set }
- `public String end` { get; set }
- `public String last_turn` { get; set }
- `public String mapID` { get; set }
- `public String mapName` { get; set }
- `public String mapNation` { get; set }
- `public String mapSize` { get; set }
- `public String mapYear` { get; set }
- `public String start` { get; set }
- `public String status` { get; set }
- `public String totalTurns` { get; set }
- `public String userHost` { get; set }
- `public String userJoin` { get; set }
- `public String userLost` { get; set }
- `public String userTurn` { get; set }
- `public String userWin` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private String <created_on>k__BackingField`
- `private String <end>k__BackingField`
- `private String <last_turn>k__BackingField`
- `private String <mapID>k__BackingField`
- `private String <mapName>k__BackingField`
- `private String <mapNation>k__BackingField`
- `private String <mapSize>k__BackingField`
- `private String <mapYear>k__BackingField`
- `private String <start>k__BackingField`
- `private String <status>k__BackingField`
- `private String <totalTurns>k__BackingField`
- `private String <userHost>k__BackingField`
- `private String <userJoin>k__BackingField`
- `private String <userLost>k__BackingField`
- `private String <userTurn>k__BackingField`
- `private String <userWin>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(OnlineGame), "PrivateMethodName", MethodType.Normal)]
class Patch_OnlineGame_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(OnlineGame), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## OnlineUser

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public String created_on` { get; set }
- `public String last_login` { get; set }
- `public Int32 matchLost` { get; set }
- `public Int32 matchWon` { get; set }
- `public String platform` { get; set }
- `public Single ratio` { get; set }
- `public String username` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private String <created_on>k__BackingField`
- `private String <last_login>k__BackingField`
- `private Int32 <matchLost>k__BackingField`
- `private Int32 <matchWon>k__BackingField`
- `private String <platform>k__BackingField`
- `private Single <ratio>k__BackingField`
- `private String <username>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(OnlineUser), "PrivateMethodName", MethodType.Normal)]
class Patch_OnlineUser_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(OnlineUser), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## OOBSlot

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ResetSlot()`
- `public Void SetUpSlot()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Toggle autoSupplies_toggle`
- `public Image backgroundForCoreUnit`
- `public Image backgroundUnit`
- `public Button delete_button`
- `public TextMeshProUGUI heroName_text`
- `public Button redeploy_button`
- `public Image representation`
- `public Button slot_button`
- `public Button transfer_button`
- `public Unit unit`
- `public TextMeshProUGUI unitHP_text`
- `public TextMeshProUGUI unitName_text`
- `public TextMeshProUGUI unitRank_text`
- `public TextMeshProUGUI unitXP_text`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private ColorBlock _colorBlock`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(OOBSlot), "PrivateMethodName", MethodType.Normal)]
class Patch_OOBSlot_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(OOBSlot), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## OrderOfBattleGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public IEnumerator CloseOOB()`
- `public Void DisbandUnit(Unit p_unit, GameObject p_unitSlotToDestroy)`
- `public Void GenerateAllSlots()`
- `public Void ManageAutoSupplies(Unit p_unit)`
- `public Void ManageAutoSuppliesForAll_Toggle(Toggle p_toggle)`
- `public Void ManageOOB()`
- `public Void ManageTransferPanel(Unit p_unit)`
- `public Void RedeployUnit(Unit p_unit, GameObject p_unitSlotToDestroy)`
- `public Void RefreshOrderSlots_Toggle()`
- `public Void SelectUnit(Unit unit)`
- `public Void ShowAllPlayersWeCanGiveUnitTo()`
- `public Void ShowSelectedUnitInOOB()`
- `public Void TransferUnit(Unit p_unit, Player p_player)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void ConfirmRedeployUnit()`
- `private IEnumerator CR_HighlightUnit(GameObject p_gameObject)`
- `private Void DeleteAllSlots()`
- `private IEnumerator LerpFromTo(Vector3 pos1, Vector3 pos2, Single duration)`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Animator animator`
- `public Toggle autoSupplies_toggle`
- `public TMP_Dropdown filter_dropdown`
- `public String filterType`
- `public static OrderOfBattleGO instance`
- `public GameObject OOBPanel`
- `public Transform parent`
- `public Scrollbar scrollbar`
- `public OOBSlot slotPrefab`
- `public Toggle sortByCoreUnits_toggle`
- `public Toggle sortByLowHealth_toggle`
- `public Toggle sortByUpkeepCost_toggle`
- `public GameObject transferPanel`
- `public GameObject transferPlayerPrefab`
- `public TMP_InputField unitName_inputfield`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean _ignoreHighlightUnit`
- `private List`1 _OOBslots`
- `private Unit _redeployUnitCache`
- `private GameObject _redeployUnitSlotCache`
- `private AnimationCurve _selectionAnimationCurve`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass22_0`
- `private class <>c__DisplayClass35_0`
- `private class <>c__DisplayClass35_1`
- `private class <CloseOOB>d__39`
- `private class <CR_HighlightUnit>d__24`
- `private class <LerpFromTo>d__37`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(OrderOfBattleGO), "PrivateMethodName", MethodType.Normal)]
class Patch_OrderOfBattleGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(OrderOfBattleGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## OwnerPanelEditorGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void LateUpdate()`
- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform rectTransform`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(OwnerPanelEditorGO), "PrivateMethodName", MethodType.Normal)]
class Patch_OwnerPanelEditorGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(OwnerPanelEditorGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PaintMode

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const PaintMode CAN_FREEZE`
- `public static const PaintMode CAN_SEASON_CHANGE`
- `public static const PaintMode TILE_PLACING`
- `public static const PaintMode UNIT_REMOVAL`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PaintMode), "PrivateMethodName", MethodType.Normal)]
class Patch_PaintMode_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PaintMode), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PasswordInputfieldUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ChangePasswordVisibility()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Sprite _hidden_sprite`
- `private TMP_InputField _inputfield`
- `private Image _visibility_image`
- `private Sprite _visible_sprite`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PasswordInputfieldUI), "PrivateMethodName", MethodType.Normal)]
class Patch_PasswordInputfieldUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PasswordInputfieldUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Player

### Public Methods

- `public Void AddAllianceWith(Player p_player, Boolean p_sendRPC)`
- `public Void AddHQPoints(Int32 p_amount, Boolean p_sendRPC)`
- `public Void AddLineData(LineData p_lineData, Boolean p_sendRPC)`
- `public Void AddManpower(Int32 p_amount, Boolean p_doMarginCheck, Boolean p_sendRPC)`
- `public Void AddMoney(Int32 p_amount, Boolean p_sendRPC)`
- `public Void AddNewTurnManpower()`
- `public Void AddPolicy(Policy p_policy, Boolean p_sendRPC)`
- `public Void AddTruceWith(Player p_player, Boolean p_sendRPC)`
- `public Void AddTurnStats()`
- `public Void AddUnit(Unit p_unit, Boolean p_sendRPC)`
- `public Void AddWarWith(Player p_player, Boolean p_actualDirectWarDeclaration, Boolean p_sendRPC)`
- `public Boolean AreThereUnitsReadyForDeployment()`
- `public Void AssignUnitCategoryID(Unit p_unit)`
- `public Void BackupTurnStatsAndReset()`
- `public Void CacheAllianceAndWarForGivenPlayer(Player p_player)`
- `public Int32 CalculateMaxManpower()`
- `public Int32 CalculateTotalUnitsUpkeep(Boolean p_applyReserveModifier)`
- `public Int32 CalculateTurnIncome()`
- `public Void CancelResearch(Unit p_unit, Boolean p_sendRPC)`
- `public Void ChangeFaction(String p_newFactionName, Boolean p_getNewAllianceWars, Boolean p_sendRPC)`
- `public Void CheckForMissingUnitsCategories()`
- `public Int32 CountCurrCoreUnits()`
- `public Int32 CountOurUnits()`
- `public Int32 CountOurVPs()`
- `public Void CountUnitTypesForStatistic(Statistic p_stat)`
- `public Void DestroyAndResetAllUnits(Player p_playerTakingOver)`
- `public Int32 GetAvailableManpower()`
- `public Int32 GetFactionChangeCost(String p_targetFaction)`
- `public Int32 GetFieldedManpower()`
- `public Int32 GetManpowerGrowth()`
- `public Boolean HasPolicy(Policy p_policy)`
- `public Boolean HasPolicy(Type p_type)`
- `public Boolean HasReachedMaxPurchaseLimit(Unit p_unit)`
- `public Boolean HasReachedUnitLimitCap(Unit p_unit)`
- `public Boolean HasResearchedAllUnits()`
- `public Boolean HasTruceWith(Player p_player)`
- `public Boolean IsAlliedWith(Player p_player)`
- `public Boolean IsAtWarWith(Player p_player)`
- `public Boolean IsMajor()`
- `public Boolean IsMinor()`
- `public Boolean IsNaturalAllyOf(Player p_player)`
- `public Boolean IsNavalMajor()`
- `public Boolean IsNavalMinor()`
- `public Void PurchasePolicy(Policy p_policy, Boolean p_sendRPC)`
- `public Void PurchaseUnit(Unit p_unit, Boolean p_sendRPC)`
- `public Void RemoveAllianceWith(Player p_player, Boolean p_sendRPC)`
- `public Void RemoveHQpoints(Int32 p_amount, Boolean p_sendRPC)`
- `public Void RemoveLineData(LineData p_lineData, Boolean p_sendRPC)`
- `public Void RemoveManpower(Int32 p_amount, Boolean p_sendRPC)`
- `public Void RemoveMoney(Int32 p_amount, Boolean p_sendRPC)`
- `public Void RemovePolicy(Policy p_policy, Boolean p_sendRPC)`
- `public Void RemovePolicy(Type p_type, Boolean p_sendRPC)`
- `public Void RemoveTruceWith(Player p_player, Boolean p_sendRPC)`
- `public Void RemoveUnit(Unit p_unit, Boolean p_sendRPC)`
- `public Void RemoveUnitCategoryID(Unit p_unit)`
- `public Void RemoveWarWith(Player p_player, Boolean p_sendRPC)`
- `public Void SetAvailableManpower(Int32 p_amount)`
- `public Void SetDefaultIncomeModifier()`
- `public Void SetDefaultResearchPointsAmount(List`1 p_gameUnits)`
- `public Void SetupIdeology()`
- `public Void StartResearch(Unit p_unit, Boolean p_sendRPC)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void ApplyPolicyEffects(Policy p_policy)`
- `private Void RemovePolicyEffects(Policy p_policy)`

### Public Properties

- `public HashSet`1 AlliedPlayers` { get; set }
- `public List`1 ClearedFOW` { get; set }
- `public String Country` { get; set }
- `public Dictionary`2 CurrentUnitsResearch` { get; set }
- `public Int32 EventMoneyToProcess` { get; set }
- `public String Faction` { get; set }
- `public Int32 FixedIncome` { get; set }
- `public Int16 HighCommandPoints` { get; set }
- `public String Ideology` { get; set }
- `public Byte IncomeModifier` { get; set }
- `public Boolean IsComputer` { get; set }
- `public Boolean IsEndTurnPanel` { get; set }
- `public Boolean IsPlaying` { get; set }
- `public Boolean IsPlayingFirst` { get; set }
- `public List`1 LineDatas` { get; set }
- `public List`1 ListActivePolicies` { get; set }
- `public List`1 ListOfUnits` { get; set }
- `public List`1 ListOfUnitsResearched` { get; set }
- `public String LocalPassword` { get; set }
- `public Int32 ManpowerAvailable` { get; set }
- `public Int32 MoneyAmount` { get; set }
- `public String Name` { get; set }
- `public String Nickname` { get; set }
- `public Int16 NumberOfAvailableResearchPoints` { get; set }
- `public Int16 NumberOfPartisansLost` { get; set }
- `public Int32 NumberOfVPEverConquered` { get; set }
- `public Boolean OOBautoSupplies` { get; set }
- `public HashSet`1 PlayersAtWar` { get; set }
- `public Dictionary`2 PurchasedUnits` { get; set }
- `public Int32 Rank` { get; set }
- `public Int32 SafariKillCount` { get; set }
- `public String ScenarioDefeatText` { get; set }
- `public String ScenarioDescription` { get; set }
- `public String ScenarioVictoryText` { get; set }
- `public Dictionary`2 Stats` { get; set }
- `public Single TotalDamageDealt` { get; set }
- `public Int32 TotalMoneyEarned` { get; set }
- `public Int32 TotalMoneySpent` { get; set }
- `public Single TotalTilesBombed` { get; set }
- `public Int32 TotalUnitsBought` { get; set }
- `public Int32 TotalUnitsDestroyed` { get; set }
- `public Int32 TotalUnitsLost` { get; set }
- `public Dictionary`2 Truces` { get; set }
- `public Int32 TurnMoneyEarned` { get; set }
- `public Int32 TurnMoneyEarnedBackup` { get; set }
- `public Int32 TurnMoneySpent` { get; set }
- `public Int32 TurnMoneySpentBackup` { get; set }
- `public Int32 TurnUnitsBought` { get; set }
- `public Int32 TurnUnitsBoughtBackup` { get; set }
- `public Int32 TurnUnitsDestroyed` { get; set }
- `public Int32 TurnUnitsDestroyedBackup` { get; set }
- `public Int32 TurnUnitsLost` { get; set }
- `public Int32 TurnUnitsLostBackup` { get; set }
- `public Dictionary`2 UnitCategoriesQuantity` { get; set }
- `public Int32 XP` { get; set }
- `public Int32 XPNeededForNextRank` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Int32 AirForces`
- `public Int32 baseIncome`
- `public Boolean canAIattackPlayer`
- `public Int32 GroundForces`
- `public Boolean isAlliedWithCurrentPlayer`
- `public Boolean isAlliedWithGivenPlayer`
- `public Boolean isAlliedWithHumanPlayer`
- `public Boolean isAtWarWithCurrentPlayer`
- `public Boolean isAtWarWithGivenPlayer`
- `public Boolean isAtWarWithHumanPlayer`
- `public Int32 ManpowerMax`
- `public Int32 ManpowerUsed`
- `public Int32 NavalForces`
- `public Boolean noRelationWithCurrentPlayer`
- `public Boolean noRelationWithGivenPlayer`
- `public Boolean noRelationWithHumanPlayer`
- `public Int32 NumberOfVPsOwned`
- `public Single ratio`
- `public Int32 tilesDestroyedIncomeLoss`
- `public Int32 turnIncome`
- `public static const Single UNIT_LEND_LEASE_COST_MODIFIER`
- `public Int32 upkeepCost`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private HashSet`1 <AlliedPlayers>k__BackingField`
- `private List`1 <ClearedFOW>k__BackingField`
- `private String <Country>k__BackingField`
- `private Dictionary`2 <CurrentUnitsResearch>k__BackingField`
- `private Int32 <EventMoneyToProcess>k__BackingField`
- `private String <Faction>k__BackingField`
- `private Int32 <FixedIncome>k__BackingField`
- `private Int16 <HighCommandPoints>k__BackingField`
- `private String <Ideology>k__BackingField`
- `private Byte <IncomeModifier>k__BackingField`
- `private Boolean <IsComputer>k__BackingField`
- `private Boolean <IsEndTurnPanel>k__BackingField`
- `private Boolean <IsPlaying>k__BackingField`
- `private Boolean <IsPlayingFirst>k__BackingField`
- `private List`1 <LineDatas>k__BackingField`
- `private List`1 <ListActivePolicies>k__BackingField`
- `private List`1 <ListOfUnits>k__BackingField`
- `private List`1 <ListOfUnitsResearched>k__BackingField`
- `private String <LocalPassword>k__BackingField`
- `private Int32 <ManpowerAvailable>k__BackingField`
- `private Int32 <MoneyAmount>k__BackingField`
- `private String <Name>k__BackingField`
- `private String <Nickname>k__BackingField`
- `private Int16 <NumberOfAvailableResearchPoints>k__BackingField`
- `private Int16 <NumberOfPartisansLost>k__BackingField`
- `private Int32 <NumberOfVPEverConquered>k__BackingField`
- `private Boolean <OOBautoSupplies>k__BackingField`
- `private HashSet`1 <PlayersAtWar>k__BackingField`
- `private Dictionary`2 <PurchasedUnits>k__BackingField`
- `private Int32 <Rank>k__BackingField`
- `private Int32 <SafariKillCount>k__BackingField`
- `private String <ScenarioDefeatText>k__BackingField`
- `private String <ScenarioDescription>k__BackingField`
- `private String <ScenarioVictoryText>k__BackingField`
- `private Dictionary`2 <Stats>k__BackingField`
- `private Single <TotalDamageDealt>k__BackingField`
- `private Int32 <TotalMoneyEarned>k__BackingField`
- `private Int32 <TotalMoneySpent>k__BackingField`
- `private Single <TotalTilesBombed>k__BackingField`
- `private Int32 <TotalUnitsBought>k__BackingField`
- `private Int32 <TotalUnitsDestroyed>k__BackingField`
- `private Int32 <TotalUnitsLost>k__BackingField`
- `private Dictionary`2 <Truces>k__BackingField`
- `private Int32 <TurnMoneyEarned>k__BackingField`
- `private Int32 <TurnMoneyEarnedBackup>k__BackingField`
- `private Int32 <TurnMoneySpent>k__BackingField`
- `private Int32 <TurnMoneySpentBackup>k__BackingField`
- `private Int32 <TurnUnitsBought>k__BackingField`
- `private Int32 <TurnUnitsBoughtBackup>k__BackingField`
- `private Int32 <TurnUnitsDestroyed>k__BackingField`
- `private Int32 <TurnUnitsDestroyedBackup>k__BackingField`
- `private Int32 <TurnUnitsLost>k__BackingField`
- `private Int32 <TurnUnitsLostBackup>k__BackingField`
- `private Dictionary`2 <UnitCategoriesQuantity>k__BackingField`
- `private Int32 <XP>k__BackingField`
- `private Int32 <XPNeededForNextRank>k__BackingField`

### Nested Types

- `private class <>c__DisplayClass261_0`
- `private class <>c__DisplayClass263_0`
- `private class <>c__DisplayClass265_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Player), "PrivateMethodName", MethodType.Normal)]
class Patch_Player_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Player), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PlayerSettings

### Public Methods

- `public static Void ApplyGameSettings(GameSettings p_gameSettings)`
- `public Void CheckNeedRefreshChatMentions()`
- `public static PlayerSettings GetInstance()`
- `public String GetLocalizedDifficulty(Int32 p_difficultyValue)`
- `public Int32 GetNextAutosaveNumber()`
- `public static Void Load()`
- `public static Void ResetValuesToDefault()`
- `public static Void Save()`
- `public Void SetLanguage(GameLanguages p_gameLanguage)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public List`1 ActiveMods` { get; set }
- `public Int32 AntiAliasing` { get; set }
- `public KeyCode AttackUnit` { get; set }
- `public Boolean AutomaticallyHidePopups` { get; set }
- `public Int32 AutosavesAmount` { get; set }
- `public Int32 AutosavesCurrent` { get; set }
- `public Int32 AutosavesFrequency` { get; set }
- `public Boolean BlinkInactiveUnits` { get; set }
- `public String CameraBackgroundColor` { get; set }
- `public Boolean CensoredGermany` { get; set }
- `public KeyCode ChangeParatroopersState` { get; set }
- `public KeyCode ChangeSubmarineState` { get; set }
- `public String ChatChannel` { get; set }
- `public HashSet`1 ChatMentions` { get; set }
- `public Boolean ColorBlindMode` { get; set }
- `public Dictionary`2 CompletedScenarioz` { get; set }
- `public Boolean ComplexSupplies` { get; set }
- `public Boolean DamageReductionRepeatedAttacks` { get; set }
- `public KeyCode DecreaseOverlayOpacity` { get; set }
- `public String DefaultServerRegion` { get; set }
- `public Int32 DifficultyLevel` { get; set }
- `public Boolean DisableVanillaSoundtracks` { get; set }
- `public KeyCode Disband` { get; set }
- `public KeyCode Disengage` { get; set }
- `public Boolean DisplayUnitsLevelOnCounter` { get; set }
- `public KeyCode EndTurn` { get; set }
- `public KeyCode EyedropperTile` { get; set }
- `public Boolean FastAI` { get; set }
- `public Boolean FastAllies` { get; set }
- `public Boolean FiniteManpower` { get; set }
- `public KeyCode FocusOnSelectedUnit` { get; set }
- `public Boolean FollowAIMoves` { get; set }
- `public List`1 Friends` { get; set }
- `public Boolean Fullscreen` { get; set }
- `public KeyCode HideAllUnits` { get; set }
- `public Boolean HideBattlePreview` { get; set }
- `public Boolean HideEnemyHP` { get; set }
- `public Boolean HideUnitsStats` { get; set }
- `public Boolean HideVisualCueCoreUnits` { get; set }
- `public KeyCode IncreaseOverlayOpacity` { get; set }
- `public Boolean InstantSeasonChange` { get; set }
- `public Boolean InvertedMouseSroll` { get; set }
- `public Boolean IsAISlowMode` { get; set }
- `public Boolean IsFogOfWar` { get; set }
- `public Boolean ISHistoricalFocus` { get; set }
- `public Boolean IsInfiniteAmmoAndFuel` { get; set }
- `public Boolean IsMorale` { get; set }
- `public Boolean IsQuickMovement` { get; set }
- `public Boolean IsWeather` { get; set }
- `public Boolean IsWeatherParticles` { get; set }
- `public KeyCode JumpDownSideMap` { get; set }
- `public KeyCode JumpLeftSideMap` { get; set }
- `public KeyCode JumpRightSideMap` { get; set }
- `public KeyCode JumpUpSideMap` { get; set }
- `public GameLanguages Language` { get; set }
- `public DateTime LastChatMentionTime` { get; set }
- `public KeyCode ManageMinimap` { get; set }
- `public Boolean Manpower` { get; set }
- `public Int32 MaxFramerate` { get; set }
- `public Boolean MoreContrastSelectedUnit` { get; set }
- `public KeyCode MoveCameraDown` { get; set }
- `public KeyCode MoveCameraLeft` { get; set }
- `public KeyCode MoveCameraRight` { get; set }
- `public Boolean MoveCameraToMousePosWhenZooming` { get; set }
- `public KeyCode MoveCameraUp` { get; set }
- `public Boolean MoveCameraWithLeftClick` { get; set }
- `public Boolean MoveCameraWithMouseOnEdge` { get; set }
- `public KeyCode MoveOverlayDown` { get; set }
- `public KeyCode MoveOverlayLeft` { get; set }
- `public KeyCode MoveOverlayRight` { get; set }
- `public KeyCode MoveOverlayUp` { get; set }
- `public KeyCode MoveUnit` { get; set }
- `public Single MusicVolume` { get; set }
- `public KeyCode NextUnit` { get; set }
- `public KeyCode NextUnitAir` { get; set }
- `public KeyCode NextUnitGround` { get; set }
- `public KeyCode NextUnitNaval` { get; set }
- `public Boolean NoAAsupportDuringAirFight` { get; set }
- `public KeyCode Objectives` { get; set }
- `public Boolean OneMoreTilePlanes` { get; set }
- `public Boolean Overrun` { get; set }
- `public Boolean Partisans` { get; set }
- `public String Password` { get; set }
- `public KeyCode PauseGame` { get; set }
- `public Boolean Policies` { get; set }
- `public KeyCode PreviousUnit` { get; set }
- `public Boolean ProductionTakesTime` { get; set }
- `public Boolean PrototypesDisabled` { get; set }
- `public Boolean PublicChatOFF` { get; set }
- `public KeyCode PutUnitToSleep` { get; set }
- `public Boolean Quick2RespondOption` { get; set }
- `public KeyCode Quickload` { get; set }
- `public KeyCode Quicksave` { get; set }
- `public Int32 RandomDamageModifier` { get; set }
- `public Boolean RealisticPlanes` { get; set }
- `public Int32[,] Resolution` { get; set }
- `public KeyCode ResupplyAmmo` { get; set }
- `public KeyCode ResupplyAmmoAndFuel` { get; set }
- `public KeyCode ResupplyFuel` { get; set }
- `public KeyCode ResupplyManpower` { get; set }
- `public KeyCode ScaleOverlayDown` { get; set }
- `public KeyCode ScaleOverlayUp` { get; set }
- `public KeyCode SelectEraser` { get; set }
- `public KeyCode SelectPen` { get; set }
- `public KeyCode SetDefensive` { get; set }
- `public KeyCode SetUnitAsGoal` { get; set }
- `public Boolean ShowBorders` { get; set }
- `public KeyCode ShowBuilding` { get; set }
- `public Boolean ShowClouds` { get; set }
- `public KeyCode ShowHideGroundAirUnit` { get; set }
- `public KeyCode ShowHideUI` { get; set }
- `public Boolean ShowInfoTile` { get; set }
- `public Boolean ShowTooltips` { get; set }
- `public KeyCode ShowUnitHistory` { get; set }
- `public Boolean ShowUnitMovePath` { get; set }
- `public Boolean ShowUnitsNumbersOnCounters` { get; set }
- `public Boolean ShuffleMusics` { get; set }
- `public KeyCode SkipUnit` { get; set }
- `public Boolean StricterFogOfWar` { get; set }
- `public KeyCode SwitchNATOGraphics` { get; set }
- `public Boolean TechTree` { get; set }
- `public KeyCode TimeSlowDown` { get; set }
- `public KeyCode TimeSpeedUp` { get; set }
- `public KeyCode ToggleAISpeed` { get; set }
- `public KeyCode ToggleOrderOfBattle` { get; set }
- `public KeyCode ToggleOverlay` { get; set }
- `public KeyCode TogglePoliticalMap` { get; set }
- `public KeyCode ToggleReserve` { get; set }
- `public KeyCode ToggleStore` { get; set }
- `public Single UIScale` { get; set }
- `public Single UIVolume` { get; set }
- `public KeyCode Undo` { get; set }
- `public Boolean UnitIsDoneIndicator` { get; set }
- `public Boolean UnitsAlwaysBlink` { get; set }
- `public Single UnitSize` { get; set }
- `public Boolean UnitSuffix` { get; set }
- `public Single UnitVolume` { get; set }
- `public KeyCode UnselectUnit` { get; set }
- `public Boolean Upkeep` { get; set }
- `public Boolean UseNATObyDefault` { get; set }
- `public String Username` { get; set }
- `public Int32 VsyncValue` { get; set }
- `public KeyCode Waypoints` { get; set }
- `public Single WeatherVolume` { get; set }
- `public Int32 WinterDamageValue` { get; set }
- `public Boolean ZoneOfControl` { get; set }
- `public Single ZoomFactor` { get; set }
- `public KeyCode ZoomInCamera` { get; set }
- `public KeyCode ZoomOutCamera` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static readonly Object _myLock`
- `public static PlayerSettings _playerSettings`
- `public static String filePath`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 <ActiveMods>k__BackingField`
- `private Int32 <AntiAliasing>k__BackingField`
- `private KeyCode <AttackUnit>k__BackingField`
- `private Boolean <AutomaticallyHidePopups>k__BackingField`
- `private Int32 <AutosavesAmount>k__BackingField`
- `private Int32 <AutosavesCurrent>k__BackingField`
- `private Int32 <AutosavesFrequency>k__BackingField`
- `private Boolean <BlinkInactiveUnits>k__BackingField`
- `private String <CameraBackgroundColor>k__BackingField`
- `private Boolean <CensoredGermany>k__BackingField`
- `private KeyCode <ChangeParatroopersState>k__BackingField`
- `private KeyCode <ChangeSubmarineState>k__BackingField`
- `private String <ChatChannel>k__BackingField`
- `private HashSet`1 <ChatMentions>k__BackingField`
- `private Boolean <ColorBlindMode>k__BackingField`
- `private Dictionary`2 <CompletedScenarioz>k__BackingField`
- `private Boolean <ComplexSupplies>k__BackingField`
- `private Boolean <DamageReductionRepeatedAttacks>k__BackingField`
- `private KeyCode <DecreaseOverlayOpacity>k__BackingField`
- `private String <DefaultServerRegion>k__BackingField`
- `private Int32 <DifficultyLevel>k__BackingField`
- `private Boolean <DisableVanillaSoundtracks>k__BackingField`
- `private KeyCode <Disband>k__BackingField`
- `private KeyCode <Disengage>k__BackingField`
- `private Boolean <DisplayUnitsLevelOnCounter>k__BackingField`
- `private KeyCode <EndTurn>k__BackingField`
- `private KeyCode <EyedropperTile>k__BackingField`
- `private Boolean <FastAI>k__BackingField`
- `private Boolean <FastAllies>k__BackingField`
- `private Boolean <FiniteManpower>k__BackingField`
- `private KeyCode <FocusOnSelectedUnit>k__BackingField`
- `private Boolean <FollowAIMoves>k__BackingField`
- `private List`1 <Friends>k__BackingField`
- `private Boolean <Fullscreen>k__BackingField`
- `private KeyCode <HideAllUnits>k__BackingField`
- `private Boolean <HideBattlePreview>k__BackingField`
- `private Boolean <HideEnemyHP>k__BackingField`
- `private Boolean <HideUnitsStats>k__BackingField`
- `private Boolean <HideVisualCueCoreUnits>k__BackingField`
- `private KeyCode <IncreaseOverlayOpacity>k__BackingField`
- `private Boolean <InstantSeasonChange>k__BackingField`
- `private Boolean <InvertedMouseSroll>k__BackingField`
- `private Boolean <IsAISlowMode>k__BackingField`
- `private Boolean <IsFogOfWar>k__BackingField`
- `private Boolean <ISHistoricalFocus>k__BackingField`
- `private Boolean <IsInfiniteAmmoAndFuel>k__BackingField`
- `private Boolean <IsMorale>k__BackingField`
- `private Boolean <IsQuickMovement>k__BackingField`
- `private Boolean <IsWeather>k__BackingField`
- `private Boolean <IsWeatherParticles>k__BackingField`
- `private KeyCode <JumpDownSideMap>k__BackingField`
- `private KeyCode <JumpLeftSideMap>k__BackingField`
- `private KeyCode <JumpRightSideMap>k__BackingField`
- `private KeyCode <JumpUpSideMap>k__BackingField`
- `private GameLanguages <Language>k__BackingField`
- `private DateTime <LastChatMentionTime>k__BackingField`
- `private KeyCode <ManageMinimap>k__BackingField`
- `private Boolean <Manpower>k__BackingField`
- `private Int32 <MaxFramerate>k__BackingField`
- `private Boolean <MoreContrastSelectedUnit>k__BackingField`
- `private KeyCode <MoveCameraDown>k__BackingField`
- `private KeyCode <MoveCameraLeft>k__BackingField`
- `private KeyCode <MoveCameraRight>k__BackingField`
- `private Boolean <MoveCameraToMousePosWhenZooming>k__BackingField`
- `private KeyCode <MoveCameraUp>k__BackingField`
- `private Boolean <MoveCameraWithLeftClick>k__BackingField`
- `private Boolean <MoveCameraWithMouseOnEdge>k__BackingField`
- `private KeyCode <MoveOverlayDown>k__BackingField`
- `private KeyCode <MoveOverlayLeft>k__BackingField`
- `private KeyCode <MoveOverlayRight>k__BackingField`
- `private KeyCode <MoveOverlayUp>k__BackingField`
- `private KeyCode <MoveUnit>k__BackingField`
- `private Single <MusicVolume>k__BackingField`
- `private KeyCode <NextUnit>k__BackingField`
- `private KeyCode <NextUnitAir>k__BackingField`
- `private KeyCode <NextUnitGround>k__BackingField`
- `private KeyCode <NextUnitNaval>k__BackingField`
- `private Boolean <NoAAsupportDuringAirFight>k__BackingField`
- `private KeyCode <Objectives>k__BackingField`
- `private Boolean <OneMoreTilePlanes>k__BackingField`
- `private Boolean <Overrun>k__BackingField`
- `private Boolean <Partisans>k__BackingField`
- `private String <Password>k__BackingField`
- `private KeyCode <PauseGame>k__BackingField`
- `private Boolean <Policies>k__BackingField`
- `private KeyCode <PreviousUnit>k__BackingField`
- `private Boolean <ProductionTakesTime>k__BackingField`
- `private Boolean <PrototypesDisabled>k__BackingField`
- `private Boolean <PublicChatOFF>k__BackingField`
- `private KeyCode <PutUnitToSleep>k__BackingField`
- `private Boolean <Quick2RespondOption>k__BackingField`
- `private KeyCode <Quickload>k__BackingField`
- `private KeyCode <Quicksave>k__BackingField`
- `private Int32 <RandomDamageModifier>k__BackingField`
- `private Boolean <RealisticPlanes>k__BackingField`
- `private Int32[,] <Resolution>k__BackingField`
- `private KeyCode <ResupplyAmmo>k__BackingField`
- `private KeyCode <ResupplyAmmoAndFuel>k__BackingField`
- `private KeyCode <ResupplyFuel>k__BackingField`
- `private KeyCode <ResupplyManpower>k__BackingField`
- `private KeyCode <ScaleOverlayDown>k__BackingField`
- `private KeyCode <ScaleOverlayUp>k__BackingField`
- `private KeyCode <SelectEraser>k__BackingField`
- `private KeyCode <SelectPen>k__BackingField`
- `private KeyCode <SetDefensive>k__BackingField`
- `private KeyCode <SetUnitAsGoal>k__BackingField`
- `private Boolean <ShowBorders>k__BackingField`
- `private KeyCode <ShowBuilding>k__BackingField`
- `private Boolean <ShowClouds>k__BackingField`
- `private KeyCode <ShowHideGroundAirUnit>k__BackingField`
- `private KeyCode <ShowHideUI>k__BackingField`
- `private Boolean <ShowInfoTile>k__BackingField`
- `private Boolean <ShowTooltips>k__BackingField`
- `private KeyCode <ShowUnitHistory>k__BackingField`
- `private Boolean <ShowUnitMovePath>k__BackingField`
- `private Boolean <ShowUnitsNumbersOnCounters>k__BackingField`
- `private Boolean <ShuffleMusics>k__BackingField`
- `private KeyCode <SkipUnit>k__BackingField`
- `private Boolean <StricterFogOfWar>k__BackingField`
- `private KeyCode <SwitchNATOGraphics>k__BackingField`
- `private Boolean <TechTree>k__BackingField`
- `private KeyCode <TimeSlowDown>k__BackingField`
- `private KeyCode <TimeSpeedUp>k__BackingField`
- `private KeyCode <ToggleAISpeed>k__BackingField`
- `private KeyCode <ToggleOrderOfBattle>k__BackingField`
- `private KeyCode <ToggleOverlay>k__BackingField`
- `private KeyCode <TogglePoliticalMap>k__BackingField`
- `private KeyCode <ToggleReserve>k__BackingField`
- `private KeyCode <ToggleStore>k__BackingField`
- `private Single <UIScale>k__BackingField`
- `private Single <UIVolume>k__BackingField`
- `private KeyCode <Undo>k__BackingField`
- `private Boolean <UnitIsDoneIndicator>k__BackingField`
- `private Boolean <UnitsAlwaysBlink>k__BackingField`
- `private Single <UnitSize>k__BackingField`
- `private Boolean <UnitSuffix>k__BackingField`
- `private Single <UnitVolume>k__BackingField`
- `private KeyCode <UnselectUnit>k__BackingField`
- `private Boolean <Upkeep>k__BackingField`
- `private Boolean <UseNATObyDefault>k__BackingField`
- `private String <Username>k__BackingField`
- `private Int32 <VsyncValue>k__BackingField`
- `private KeyCode <Waypoints>k__BackingField`
- `private Single <WeatherVolume>k__BackingField`
- `private Int32 <WinterDamageValue>k__BackingField`
- `private Boolean <ZoneOfControl>k__BackingField`
- `private Single <ZoomFactor>k__BackingField`
- `private KeyCode <ZoomInCamera>k__BackingField`
- `private KeyCode <ZoomOutCamera>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PlayerSettings), "PrivateMethodName", MethodType.Normal)]
class Patch_PlayerSettings_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PlayerSettings), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PlayerSlotMapEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void RefreshAIplaying()`
- `public Void RefreshPlayingFirst()`
- `public Void RefreshSelectedPlayer()`
- `public Void Setup(Player p_player)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Toggle AI_toggle`
- `public TMP_Dropdown country_dropdown`
- `public TMP_Dropdown faction_dropdown`
- `public TMP_InputField fixedIncome_inputfield`
- `public TMP_Dropdown ideology_dropdown`
- `public Button info_button`
- `public Button playerSelection_button`
- `public Toggle playingFirst_toggle`
- `public TMP_InputField playOrder_inputfield`
- `public Button removePlayer_button`
- `public Color selected_color`
- `public TMP_InputField startHQpoints_inputfield`
- `public TMP_InputField startIncome_inputfield`
- `public Color unselected_color`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Player _player`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PlayerSlotMapEditor), "PrivateMethodName", MethodType.Normal)]
class Patch_PlayerSlotMapEditor_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PlayerSlotMapEditor), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Policies

**Modifiers:** `static`

### Public Methods

- `public static Void AddPolicy(Policy p_policy)`
- `public static Void AddPolicy(String p_name, String p_description, Categories p_category, Type p_type, Byte p_highCommandPointsCost)`
- `public static Void GeneratePolicies()`
- `public static List`1 GetAllPolicies()`
- `public static Policy GetPolicy(Type p_type)`
- `public static Sprite GetPolicyIcon(Policy p_policy)`
- `public static Void InitializePolicies()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static List`1 policies`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Nested Types

- `private class <>c`
- `public class Categories`
- `public class Type`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Policies), "PrivateMethodName", MethodType.Normal)]
class Patch_Policies_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Policies), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PoliciesGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ClickOnPolicy(PolicySlotGO p_policySlotGO)`
- `public Void ClosePoliciesPanel()`
- `public Void ManagePoliciesPanel()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void DeleteAllPoliciesSlots()`
- `private Void OnConfirmCancelPolicy()`
- `private Void OnEnable()`
- `private Void RefreshHighCommandpoints()`
- `private Void RefreshPolicies()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public List`1 categories`
- `public TextMeshProUGUI highCommandPoints_text`
- `public static PoliciesGO instance`
- `public PolicySlotGO policiesGO_prefab`
- `public Transform policiesSlots_parent`
- `public GameObject tooltip`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Policy _confirmationPolicy`

### Nested Types

- `private class <>c__DisplayClass11_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PoliciesGO), "PrivateMethodName", MethodType.Normal)]
class Patch_PoliciesGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PoliciesGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Policy

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Categories Category` { get; set }
- `public Type Type` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String Description`
- `public Byte HighCommandPointsCost`
- `public String Name`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Categories <Category>k__BackingField`
- `private Type <Type>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Policy), "PrivateMethodName", MethodType.Normal)]
class Patch_Policy_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Policy), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PolicySlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void SetUpPolicySlot(Policy p_policy)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button button`
- `public Policy policy`
- `public TextMeshProUGUI policyName_text`
- `public Image representation_image`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Color _active_color`
- `private Color _tooExpensive_color`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PolicySlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_PolicySlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PolicySlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PolicyTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void OnDisable()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private TextMeshProUGUI _policyCost_text`
- `private TextMeshProUGUI _policyDescription_text`
- `private TextMeshProUGUI _policyName_text`
- `private PolicySlotGO _policySlotGO`
- `private GameObject _tooltip`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PolicyTooltipGO), "PrivateMethodName", MethodType.Normal)]
class Patch_PolicyTooltipGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PolicyTooltipGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PoliticalArea

**Base Class:** `System.ValueType`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Vector3 sumOfAllTilesWorldPositions`
- `public Int32 tilesAmount`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PoliticalArea), "PrivateMethodName", MethodType.Normal)]
class Patch_PoliticalArea_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PoliticalArea), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PoliticalHexRenderer

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Place(Vector3 p_vector3)`
- `public Void SetSpriteAndColor(Color p_color, Boolean p_occupied)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean _isOccupiedSprite`
- `private Sprite _normal_sprite`
- `private Sprite _occupied_sprite`
- `private SpriteRenderer _spriteRenderer`
- `private Transform _transform`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PoliticalHexRenderer), "PrivateMethodName", MethodType.Normal)]
class Patch_PoliticalHexRenderer_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PoliticalHexRenderer), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## PriorityQueue`1

### Public Methods

- `public T Dequeue()`
- `public Void Enqueue(T p_item, Single p_priority)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void HeapifyDown(Int32 index)`
- `private Void HeapifyUp(Int32 index)`
- `private Void Swap(Int32 indexA, Int32 indexB)`

### Public Properties

- `public Int32 Count` { get }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private readonly List`1 elements`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(PriorityQueue`1), "PrivateMethodName", MethodType.Normal)]
class Patch_PriorityQueue`1_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(PriorityQueue`1), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ResearchMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ManageTechTreePanel()`
- `public Void SelectFilter(String p_filterName)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void DeleteEverything()`
- `private Void GetResearchSetup(Int32& o_minYear, Int32& o_maxYear, Int32& o_timeStep)`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void RefreshAllSlots()`
- `private Void SelectResearch(ResearchUnitSlot p_researchUnitSlot)`
- `private Void SetupUnitsHeader()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public List`1 categoriesImages`
- `public static ResearchMenu instance`
- `public TextMeshProUGUI numberOfResearchPoints`
- `public Transform parent`
- `public List`1 selectedBackgrounds`
- `public GameObject techTreeTooltip`
- `public ResearchUnitSlot unitSlotPrefab`
- `public GameObject yearSlotPrefab`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private String _selectedFilter`

### Nested Types

- `private class <>c__DisplayClass15_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ResearchMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_ResearchMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ResearchMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ResearchUnitSlot

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Setup(Unit p_unit)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button button`
- `public Slider progress_slider`
- `public TextMeshProUGUI progress_text`
- `public Unit unit`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Image unitBackground_image`
- `private TextMeshProUGUI unitName_text`
- `private Image unitRepresentation_image`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ResearchUnitSlot), "PrivateMethodName", MethodType.Normal)]
class Patch_ResearchUnitSlot_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ResearchUnitSlot), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ReservePanelGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public IEnumerator CloseReservePanel()`
- `public Void DisbandUnit(Unit p_unit)`
- `public Void EmptyButtonsList()`
- `public Void GenerateButtonsList()`
- `public Void GetUnit(Unit p_unit)`
- `public Void ManageReserveMenu()`
- `public Void ManageTransferPanel(Unit p_unit)`
- `public Void PrepareSpawningZone(Unit p_unit)`
- `public Void RefreshDeployNotification()`
- `public Void SelectNextUnitToDeploy()`
- `public Void ShowAllPlayersWeCanGiveUnitTo()`
- `public Void TransferUnit(Unit p_unit, Player p_player)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void DestroyAllCountdowns()`
- `private Boolean IsTileBesieged(Tile p_tile, Unit p_unit)`
- `private Void Start()`
- `private Void Update()`
- `private Void UpgradeUnit(Unit p_unit)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject countdownPrefab`
- `public DeploySlotGO deploySlotPrefab`
- `public static ReservePanelGO instance`
- `public GameObject notification`
- `public Text notification_text`
- `public GameObject parent`
- `public GameObject reservePanel`
- `public Animator reservePanel_Animator`
- `public static Unit selectedUnit`
- `public GameObject transferPanel`
- `public GameObject transferPlayerPrefab`
- `public Transform unitParent`
- `public GameObject unitsInProductionNotification`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Dictionary`2 _countdownsData`
- `private List`1 _countdownsGameObjects`
- `private List`1 _deploySlotGOs`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass26_0`
- `private class <>c__DisplayClass26_1`
- `private class <>c__DisplayClass30_0`
- `private class <CloseReservePanel>d__28`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ReservePanelGO), "PrivateMethodName", MethodType.Normal)]
class Patch_ReservePanelGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ReservePanelGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Response

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Int64 GameCount` { get; set }
- `public Game[] Games` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Int64 <GameCount>k__BackingField`
- `private Game[] <Games>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Response), "PrivateMethodName", MethodType.Normal)]
class Patch_Response_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Response), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## ResupplyCostGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void LateUpdate()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject resupplyCost_Panel`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private TextMeshProUGUI _HP_text`
- `private TextMeshProUGUI _manpowerCost_text`
- `private TextMeshProUGUI _moneyCost_text`
- `private Vector3 _tooltipPosition`
- `private RectTransform _tooltipRectTransform`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(ResupplyCostGO), "PrivateMethodName", MethodType.Normal)]
class Patch_ResupplyCostGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(ResupplyCostGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SaveMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Browse()`
- `public Void CloseSaveLoadPanel()`
- `public Void DeleteSave()`
- `public Void Load()`
- `public Void OpenSaveLoadMenu()`
- `public Void RenameSave()`
- `public Void Save(Boolean p_cloudSave)`
- `public Void SetSaveChoice(FileInfo p_fileInfo)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private IEnumerator CR_PollSaves()`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void RefreshSaveList()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Byte[] _filesCheckSum`
- `private Single _lastSaveClick`
- `private String _savesPath`
- `private FileInfo _selectedFileInfo`
- `private GameObject deleteButton`
- `private TMP_InputField inputField`
- `private GameObject loadButton`
- `private Transform parent`
- `private GameObject renameButton`
- `private GameObject saveButton`
- `private GameObject saveLoadPanel`
- `private GameObject saveSlot_Prefab`
- `private GameObject saveSlotCloud_Prefab`
- `private GameObject saveToCloudButton`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass21_0`
- `private class <CR_PollSaves>d__27`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SaveMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_SaveMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SaveMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SceneTranslator

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public TMP_FontAsset GetActiveFontAsset()`
- `public Void TranslateScene()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private TMP_FontAsset GetFontToUse(GameLanguages p_gameLanguage)`
- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static SceneTranslator instance`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TMP_FontAsset _activeFontAsset`
- `private TMP_FontAsset _CN_font`
- `private TMP_FontAsset _EU_font`
- `private TMP_FontAsset _JP_font`
- `private TMP_FontAsset _KR_font`
- `private LocalizedText[] _localizedTexts`
- `private GameLanguages _previousGameLanguage`
- `private Boolean _translateSceneOnStart`
- `private Transform _UI_parent`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SceneTranslator), "PrivateMethodName", MethodType.Normal)]
class Patch_SceneTranslator_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SceneTranslator), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SelectedUnitExtraStatsUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Close()`
- `public Void RefreshIfIsSelectedUnit(Unit p_unit)`
- `public Void Show(UnitGO p_unitGO)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Boolean IsUnitShown(Unit p_unit)`
- `private Void RefreshInfos()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TextMeshProUGUI _airAttack_text`
- `private TextMeshProUGUI _hardAttack_text`
- `private TextMeshProUGUI _range_text`
- `private TextMeshProUGUI _softAttack_text`
- `private TextMeshProUGUI _terrainModifier_text`
- `private Unit _unit`
- `private UnitGO _unitGO`
- `private TextMeshProUGUI _visibility_text`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SelectedUnitExtraStatsUI), "PrivateMethodName", MethodType.Normal)]
class Patch_SelectedUnitExtraStatsUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SelectedUnitExtraStatsUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SelectedUnitUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Close()`
- `public Void RefreshIfIsSelectedUnit(Unit p_unit)`
- `public Void Show(UnitGO p_unitGO)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Boolean IsUnitShown(Unit p_unit)`
- `private Void RefreshInfos()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TextMeshProUGUI _ammo_text`
- `private TextMeshProUGUI _armour_text`
- `private TextMeshProUGUI _entrenchment_text`
- `private Image _flag_image`
- `private TextMeshProUGUI _fuel_text`
- `private TextMeshProUGUI _HP_text`
- `private TextMeshProUGUI _MP_text`
- `private Image _rank_image`
- `private TextMeshProUGUI _supplies_text`
- `private Unit _unit`
- `private UnitGO _unitGO`
- `private TMP_InputField _unitName_inputField`
- `private Image _unitTypeIcon_image`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SelectedUnitUI), "PrivateMethodName", MethodType.Normal)]
class Patch_SelectedUnitUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SelectedUnitUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SettingsMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AutomaticallyHidePopups()`
- `public Void ChangeMouseZoomSensivity()`
- `public Void ChangeMusicVolume()`
- `public Void ChangeUIVolume_Slider()`
- `public Void ChangeUnitVolume()`
- `public Void ChangeWeatherVolume()`
- `public Void ChangeWinterDamage()`
- `public Void ManageFullscreen()`
- `public Void MoreContrast()`
- `public Void OpenCustomMusicFolder()`
- `public Void OpenCustomUnitSounds()`
- `public Void RefreshUIScaleSliderValue()`
- `public Void ResetSettingsToDefault()`
- `public Void SelectSettingsCategory(GameObject p_settingsCategory)`
- `public Void SetAISlowMode()`
- `public Void SetAutosavesAmount()`
- `public Void SetAutosavesFrequency()`
- `public Void SetBlinkInactiveUnits()`
- `public Void SetCameraBackgroundColor()`
- `public Void SetCameraMovementTracking()`
- `public Void SetCensoredGermany()`
- `public Void SetColorBlindMode()`
- `public Void SetComplexSupplies()`
- `public Void SetConnectPublicChat()`
- `public Void SetDamageReductionRepeatedAttacks()`
- `public Void SetDisableVanillaSoundtracks()`
- `public Void SetDisplayUnitsLevelOnCounter()`
- `public Void SetEasierDifficulty()`
- `public Void SetFastAI()`
- `public Void SetFastAllies()`
- `public Void SetFiniteManpower()`
- `public Void SetFogOfWar()`
- `public Void SetFramerate()`
- `public Void SetHarderDifficulty()`
- `public Void SetHideBattlePreview()`
- `public Void SetHideEnemyHP()`
- `public Void SetHideVisualCueForCoreUnits()`
- `public Void SetHistoricalFocuses()`
- `public Void SetInfiniteAmmoFuel()`
- `public Void SetInstantWinter()`
- `public Void SetInvertedMouseScroll()`
- `public Void SetManpower()`
- `public Void SetMorale()`
- `public Void SetMoveCameraToMousePosWhenZooming()`
- `public Void SetMoveCameraWithLeftClick()`
- `public Void SetMoveCameraWithMouseOnEdge()`
- `public Void SetNATOiconsByDefault()`
- `public Void SetNewKey()`
- `public Void SetNoAASupportDuringAirFight()`
- `public Void SetOneMoreTilePlanes()`
- `public Void SetOverrun()`
- `public Void SetPartisans()`
- `public Void SetPolicies()`
- `public Void SetProductionTakesTime()`
- `public Void SetPrototypesDisabled()`
- `public Void SetQuick2RespondOption()`
- `public Void SetQuickMovement()`
- `public Void SetRandomDamageModifier()`
- `public Void SetRealisticPlanesOption()`
- `public Void SetResolution()`
- `public Void SetShowBorders()`
- `public Void SetShowInfoTile()`
- `public Void SetShowTooltips()`
- `public Void SetShowUnitMovePath()`
- `public Void SetShowUnitNumberOnCounters()`
- `public Void SetShowUnitsStats()`
- `public Void SetStricterFogOfWar()`
- `public Void SetTechTreeOption()`
- `public Void SetUIScale()`
- `public Void SetUnitIsDoneIndicator()`
- `public Void SetUnitsAlwaysBlink()`
- `public Void SetUnitSize()`
- `public Void SetUnitSuffixOption()`
- `public Void SetUpkeep()`
- `public Void SetVSync()`
- `public Void SetWeather()`
- `public Void SetWeatherParticles()`
- `public Void SetZoneOfControl()`
- `public Void ShowClouds()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void ConfirmResetSettings()`
- `private Void ListenForNewKey()`
- `private Void RefreshDifficultyValue()`
- `private Void RefreshSettings()`
- `private Void SetAutosavesAmountOnGameOpens()`
- `private Void SetAutosavesFrequencyOnGameOpens()`
- `private Void SetKeyBindingsOnGameOpens()`
- `private Void SetMaxFramerateOnGameOpens()`
- `private Void SetRandomDamageModifierOnGameOpens()`
- `private Void SetResolutionOnGameOpens()`
- `private Void SetUIScaleOnGameOpens()`
- `private Void SetUnitSizeOnGameOpens()`
- `private Void SetVolumeOnGameOpens()`
- `private Void SetVsyncOnGameOpens()`
- `private Void SetWinterDamageOnGameOpens()`
- `private Void SetZoomSpeedOnGameOpens()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Slider antiAliasing_Slider`
- `public Toggle automaticallyHidePopups_Toggle`
- `public Slider autosavesAmount_slider`
- `public Slider autosavesFrequency_slider`
- `public Toggle blinkInactiveUnits_toggle`
- `public Toggle borders_toggle`
- `public InputField cameraBackgroundColor_inputfield`
- `public Toggle cameraFollowAI_Toggle`
- `public Toggle censoredGermany_toggle`
- `public Toggle colorBlind_toggle`
- `public Toggle complexSupplies_Toggle`
- `public Toggle connectPublicChat_toggle`
- `public Toggle damageReductionAttackFrequency_toggle`
- `public Toggle disableVanillaSoundtracks_toggle`
- `public Toggle displayUnitLevelOnCounter_toggle`
- `public Toggle fastAI_toggle`
- `public Toggle fastAIAllyOnly_toggle`
- `public Toggle finiteManpower_toggle`
- `public Toggle fogOfWar_Toggle`
- `public Slider framerate_slider`
- `public Toggle fullscreen_Toggle`
- `public Toggle hideBattlePreview_toggle`
- `public Toggle hideEnemyHP_toggle`
- `public Toggle hideVisualCueForCoreUnits_toggle`
- `public Toggle historicalFocus_Toggle`
- `public Toggle infiniteFuelAmmo_Toggle`
- `public Toggle instantWinter_toggle`
- `public Toggle invertedMouseScroll_toggle`
- `public GameObject keyBindingPanel`
- `public List`1 keysButtonsElement`
- `public String keyToChangeName`
- `public static Boolean listeningForNewKeybind`
- `public Toggle manpower_toggle`
- `public Toggle morale_Toggle`
- `public Toggle moreContrast_toggle`
- `public Toggle moveCameraToMousePosZooming_toggle`
- `public Toggle moveCameraWithEdge_Toggle`
- `public Toggle moveCameraWithLeftClick_toggle`
- `public Slider musicVolume_slider`
- `public Toggle noAAsupportInAirBattles_toggle`
- `public Toggle OneMoreTilePlanes_toggle`
- `public Toggle overrun_toggle`
- `public Toggle partisans_Toggle`
- `public Toggle policies_toggle`
- `public Toggle productionTakesTime_Toggle`
- `public Toggle prototypesDisabled_toggle`
- `public Toggle quick2Respond_Toggle`
- `public Toggle quickMovement_Toggle`
- `public Slider randomDamageModifier_slider`
- `public Toggle realisticPlanes_Toggle`
- `public TMP_Dropdown resolution_dropdown`
- `public Toggle showClouds_Toggle`
- `public Toggle showTileInfo_Toggle`
- `public Toggle showTooltips_Toggle`
- `public Toggle showUnitMovePath_toggle`
- `public Toggle showUnitsNumberOnCounter_toggle`
- `public Toggle showUnitsStats_Toggle`
- `public Toggle slowAIMode_Toggle`
- `public Toggle stricterFogOfWar_toggle`
- `public Toggle techTree_Toggle`
- `public Slider UIscale_slider`
- `public Slider UIVolume_slider`
- `public Toggle unitIsDoneIndicator_toggle`
- `public Toggle unitsAlwaysBlink_toggle`
- `public Slider unitSize_Slider`
- `public Toggle unitSuffix_Toggle`
- `public Slider unitVolume_slider`
- `public Toggle upkeep_toggle`
- `public Toggle useNATOiconsByDefault_toggle`
- `public Slider vsync_Slider`
- `public Toggle weather_Toggle`
- `public Toggle weatherParticles_toggle`
- `public Slider weatherVolume_slider`
- `public Slider winterDamage_Slider`
- `public Toggle zoneOfControl_toggle`
- `public Slider zoom_Slider`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 _settingsCategoriesPanels`
- `private TextMeshProUGUI autosavesAmount_text`
- `private TextMeshProUGUI autosavesFrequency_text`
- `private TextMeshProUGUI difficulty_Text`
- `private TextMeshProUGUI framerate_text`
- `private TextMeshProUGUI masterVolume_text`
- `private TextMeshProUGUI musicVolume_text`
- `private TextMeshProUGUI randomDamageModifier_text`
- `private TextMeshProUGUI UIscale_text`
- `private TextMeshProUGUI UIvolume_text`
- `private TextMeshProUGUI unitsSize_text`
- `private TextMeshProUGUI unitsVolume_text`
- `private TextMeshProUGUI vsync_Text`
- `private TextMeshProUGUI weatherVolume_text`
- `private TextMeshProUGUI winterDamage_Text`
- `private TextMeshProUGUI zoomSpeed_text`

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SettingsMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_SettingsMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SettingsMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SimpleSlotUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button button`
- `public TextMeshProUGUI textComponent`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SimpleSlotUI), "PrivateMethodName", MethodType.Normal)]
class Patch_SimpleSlotUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SimpleSlotUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SoundManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ChangeMusicVolume()`
- `public Void ChangeUIVolume_Slider()`
- `public Void ChangeUnitVolume()`
- `public Void ChangeWeatherVolume()`
- `public static AudioClip GetAttackSound(String p_soundName)`
- `public static AudioClip GetMovementSound(String p_soundName)`
- `public static AudioClip GetUISound(String p_soundName)`
- `public Void ManagePlaylistPanel()`
- `public Void PlayDelayedUnitSound(Single p_delay, String p_soundName)`
- `public Void PlayMusicByName(String p_musicName)`
- `public Void PlayNextMusic()`
- `public Void PlayPause()`
- `public Void PlayPreviousMusic()`
- `public Void PlayRandomMusic()`
- `public Void SavingSoundSettings()`
- `public Void ToggleShuffleMode()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private IEnumerator CR_PlayDelayedUnitSound(Single p_delay, String p_soundName)`
- `private Void OnApplicationFocus(Boolean focus)`
- `private Void OnApplicationQuit()`
- `private Void RefreshPlayingIcon()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Transform container`
- `public static SoundManager instance`
- `public List`1 listOfAllMusics`
- `public AudioSource music_Source`
- `public GameObject musicSlotPrefab`
- `public Slider musicVolume_Slider`
- `public GameObject playlist`
- `public Toggle shuffle_toggle`
- `public AudioSource UI_Source`
- `public Slider UIVolume_slider`
- `public AudioSource unit_Source`
- `public Slider unitVolume_Slider`
- `public AudioSource weather_Source`
- `public Slider weatherVolume_Slider`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean _hasBeenPaused`
- `private Boolean _isGameScene`
- `private Int32 _lastMusicIndex`
- `private Int32 _musicIndex`
- `private AnimationCurve _soundVolumeByDistance`

### Nested Types

- `private class <>c__DisplayClass23_0`
- `private class <CR_PlayDelayedUnitSound>d__40`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SoundManager), "PrivateMethodName", MethodType.Normal)]
class Patch_SoundManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SoundManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## StandaloneScenariosMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Browse()`
- `public Void ChangeConfiguration(Player p_player, TMP_Dropdown p_dropdown, Slider p_incomeSlider)`
- `public Void ChangePlayerIncome(Player p_player, Slider p_slider)`
- `public Void MapChoice(FileInfo p_fileInfo)`
- `public Void RefreshListOfMaps()`
- `public Void SetPlaysFirst(Player p_player, Toggle p_toggle)`
- `public Void Start2PlayersGame(Boolean p_ignoreConfirmationWindow)`
- `public Void StartTutorial()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private IEnumerator CR_CheckFiles()`
- `private IEnumerator CR_LoadMap(FileInfo p_fileInfo)`
- `private Void OnEnable()`
- `private Void RefreshIronMan()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject achievement`
- `public Toggle FFAToggle`
- `public GameObject loadingScenarioPanel`
- `public Toggle lockFileToggle`
- `public GameObject mapNameSlot`
- `public TMP_InputField mapSearch_inputfield`
- `public TextMeshProUGUI mapSizeText`
- `public GameObject NOironman`
- `public Toggle offlineMultiplayerToggle`
- `public Transform parent`
- `public Transform playerInfoContainer_Transform`
- `public GameObject playerQuickGameSlot`
- `public Button startButton`
- `public GameObject YESironman`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Coroutine _CR_loadingMap`
- `private Byte[] _filesCheckSum`
- `private String _filesPath`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass21_0`
- `private class <>c__DisplayClass21_1`
- `private class <>c__DisplayClass27_0`
- `private class <>c__DisplayClass27_1`
- `private class <CR_CheckFiles>d__29`
- `private class <CR_LoadMap>d__27`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(StandaloneScenariosMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_StandaloneScenariosMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(StandaloneScenariosMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Statistic

### Public Methods


### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Int16 ArtilleryNumber` { get; set }
- `public Byte HQpointsAMount` { get; set }
- `public Int32 IncomeAmount` { get; set }
- `public Int16 InfantryNumber` { get; set }
- `public Int32 ManpowerAmount` { get; set }
- `public Int32 MoneyAmount` { get; set }
- `public Int16 NumberOfUnits` { get; set }
- `public Int16 PlanesNumber` { get; set }
- `public Int32 RealisticManpowerAmount` { get; set }
- `public Int16 ShipsNumber` { get; set }
- `public Int16 TanksNumber` { get; set }
- `public Int16 VPsAmount` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Int16 <ArtilleryNumber>k__BackingField`
- `private Byte <HQpointsAMount>k__BackingField`
- `private Int32 <IncomeAmount>k__BackingField`
- `private Int16 <InfantryNumber>k__BackingField`
- `private Int32 <ManpowerAmount>k__BackingField`
- `private Int32 <MoneyAmount>k__BackingField`
- `private Int16 <NumberOfUnits>k__BackingField`
- `private Int16 <PlanesNumber>k__BackingField`
- `private Int32 <RealisticManpowerAmount>k__BackingField`
- `private Int16 <ShipsNumber>k__BackingField`
- `private Int16 <TanksNumber>k__BackingField`
- `private Int16 <VPsAmount>k__BackingField`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Statistic), "PrivateMethodName", MethodType.Normal)]
class Patch_Statistic_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Statistic), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SteamLeaderboard

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public List`1 entries`
- `public SteamLeaderboardEntry localPlayerEntry`
- `public String name`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SteamLeaderboard), "PrivateMethodName", MethodType.Normal)]
class Patch_SteamLeaderboard_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SteamLeaderboard), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SteamLeaderboardEntry

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Boolean isLocalClient`
- `public String nickname`
- `public Int32 rank`
- `public Int32 score`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SteamLeaderboardEntry), "PrivateMethodName", MethodType.Normal)]
class Patch_SteamLeaderboardEntry_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SteamLeaderboardEntry), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SteamManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AddPlayerStat(String p_statName, Int32 p_value)`
- `public Void DeleteSteamCloudFile(String p_fileName)`
- `public List`1 GetLeaderboardsNames()`
- `public Boolean GetPlayerStatInt(String p_statName, Int32& o_value)`
- `public List`1 GetSteamCloudSaves()`
- `public static String GetSteamCloudSavesLocation()`
- `public static Boolean IsDLCInstalled(UInt32 p_DLCID)`
- `public static Boolean OwnsDLC(AppId_t p_appId_T)`
- `public Void RenameSteamCloudFile(String p_oldName, String p_newName)`
- `public Void SetLeaderboard(Int32 p_score, String p_leaderboardName, LeaderboardActions p_leaderboardAction)`
- `public Void SetPlayerStat(String p_statName, Int32 p_value)`
- `public static Void SetRichPresenceStatus(SteamStatuses p_steamStatus)`
- `public static Boolean ShouldApplyCensor()`
- `public static Void UnlockAchievement(String p_ID)`
- `public Void UploadSaveFileToSteamCloud(String p_fileName, GameData p_gameData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private static String BuildLocalPath(String p_root, String p_cloudName)`
- `private IEnumerator CR_UploadLeaderboardsAndStats()`
- `private Void DownloadAndWriteToDiskSteamCloudSaveFiles()`
- `private Void DownloadLeaderboardEntries(SteamLeaderboard_t p_leaderboardHandle)`
- `private Void DownloadLocalPlayerEntry(SteamLeaderboard_t p_leaderboardHandle)`
- `private static String GetStatusString(SteamStatuses p_steamStatus)`
- `private ELeaderboardUploadScoreMethod GetUploadTypeAction(LeaderboardActions p_leaderboardAction)`
- `private Void InitializePlayerStats()`
- `private static Boolean IsLocalUpToDate(String p_localPath, String p_cloudName)`
- `private Void OnApplicationQuit()`
- `private Void OnLeaderboardFindResult(LeaderboardFindResult_t p_result, Boolean p_failure)`
- `private Void OnLeaderboardLocalPlayerScoresDownloaded(LeaderboardScoresDownloaded_t p_result, Boolean p_failure)`
- `private Void OnLeaderboardScoresDownloaded(LeaderboardScoresDownloaded_t p_result, Boolean p_failure)`
- `private Void OnLeaderboardScoresUploaded(LeaderboardScoreUploaded_t p_result, Boolean p_failure)`
- `private Void OnSceneLoaded(Scene p_scene, LoadSceneMode p_loadSceneMode)`
- `private Void ProcessLoadedMainMenu()`
- `private Void RefreshLeaderboards()`
- `private Void RetrieveAndCacheLeaderboard(String p_leaderboardName)`
- `private Void Update()`
- `private Void UploadUserScoresAndStats()`

### Public Properties

- `public static Boolean IsSteamReady` { get; set }
- `public static CSteamID LocalPlayerSteamID` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static SteamManager instance`
- `public static const Byte MAX_LEADERBOARD_ENTRIES`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean _areLeaderboardsReady`
- `private List`1 _leaderboardNames`
- `private Dictionary`2 _leaderboardNameToHandle`
- `private Int32 _leaderboardsAmount`
- `private Int32 _leaderboardsRetrievedAmount`
- `private static SteamStatuses _prevStatus`
- `private List`1 _statsNames`
- `private Dictionary`2 _steamLeaderboardToObject`
- `private static Boolean <IsSteamReady>k__BackingField`
- `private static CSteamID <LocalPlayerSteamID>k__BackingField`
- `private static readonly TimeSpan TimestampSkew`

### Nested Types

- `private class <CR_UploadLeaderboardsAndStats>d__45`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SteamManager), "PrivateMethodName", MethodType.Normal)]
class Patch_SteamManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SteamManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SteamStatuses

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const SteamStatuses CREATING_MAP`
- `public static const SteamStatuses DEFAULT`
- `public static const SteamStatuses DIPLOMACY`
- `public static const SteamStatuses END_GAME_STATISTICS`
- `public static const SteamStatuses LEADERBOARD`
- `public static const SteamStatuses MAIN_MENU`
- `public static const SteamStatuses MODDING`
- `public static const SteamStatuses NONE`
- `public static const SteamStatuses RESEARCH`
- `public static const SteamStatuses SETTINGS`
- `public static const SteamStatuses STARTING_CAMPAIGN`
- `public static const SteamStatuses STARTING_QUICKGAME`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SteamStatuses), "PrivateMethodName", MethodType.Normal)]
class Patch_SteamStatuses_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SteamStatuses), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## SteamWorkshopMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ClosePanel_Button()`
- `public Void CreateMod()`
- `public Void CreateModFolder()`
- `public Void CreateTilesTemplates()`
- `public Void CreateUnitsTemplates()`
- `public Void DeleteMod()`
- `public Void ModifyModName()`
- `public Void RefreshListOfUserMadeMods()`
- `public Void UpdateItem()`
- `public Void UploadMod()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void ClearModsListUI()`
- `private Single ComputeNormalizedTarget(EItemUpdateStatus status, UInt64 processed, UInt64 total)`
- `private Void CopyUnitTemplate(String fileName, String toFolder)`
- `private Void CreateModSlot(SteamUGCDetails_t details)`
- `private Void EmptyForm()`
- `private Void OnCreateItemResult(CreateItemResult_t result, Boolean ioFailure)`
- `private Void OnDeleteItemResult(DeleteItemResult_t result, Boolean ioFailure)`
- `private Void OnDisable()`
- `private Void OnSingleModQueryCompleted(SteamUGCQueryCompleted_t result, Boolean ioFailure)`
- `private Void OnSubmitItemUpdateResult(SubmitItemUpdateResult_t result, Boolean ioFailure)`
- `private Void OnTagToggleChanged(Toggle toggle, Boolean isOn)`
- `private Void OnUserModsQueryCompleted(SteamUGCQueryCompleted_t result, Boolean ioFailure)`
- `private Void SelectModSlot(GameObject slotGO, PublishedFileId_t fileId)`
- `private Void SetAllTagToggles(Boolean isOn)`
- `private Void SetUploadUI(Boolean visible)`
- `private Void SetupUIListeners()`
- `private Void TryCopyFromStreamingAssets(String relativeSource, String destination)`
- `private Void Update()`
- `private Void UpdateFormState()`
- `private Void UpdateModPathLabel()`
- `private Boolean ValidateModFolderExists()`
- `private Boolean ValidateThumbnail()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

- `private String CurrentModFolderPath` { get }
- `private String SafeModName` { get }

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private GameObject _activeCheckmark`
- `private CallResult`1 _createItemResult`
- `private CallResult`1 _deleteItemResult`
- `private Single _displayedProgress01`
- `private Single _progressVelocity`
- `private PublishedFileId_t _publishedFileID`
- `private HashSet`1 _selectedTags`
- `private CallResult`1 _singleModQueryResult`
- `private CallResult`1 _submitItemUpdateResult`
- `private Single _targetProgress01`
- `private UGCUpdateHandle_t _updateHandle`
- `private UGCQueryHandle_t _userModsQueryHandle`
- `private CallResult`1 _userModsQueryResult`
- `private TMP_InputField changeLog_InputField`
- `private Transform containerForAllMods`
- `private GameObject createModPanel`
- `private GameObject createTemplatesTilesButton`
- `private GameObject createTemplatesUnitsButton`
- `private GameObject deleteMod_Button`
- `private GameObject invalidUploadBig_Button`
- `private GameObject invalidUploadSmall_Button`
- `private static const Int64 MAX_THUMBNAIL_BYTES`
- `private static const String MOD_FOLDER_PATH_LABEL`
- `private TMP_InputField modDescription_InputField`
- `private TMP_InputField modName_Inputfield`
- `private TextMeshProUGUI modPath_Text`
- `private static const String MODS_DIR_NAME`
- `private GameObject modSlotPrefab`
- `private Single progressSmoothTime`
- `private Toggle publicPrivate_Toggle`
- `private GameObject submitMod_Button`
- `private List`1 tags_toggles`
- `private static const String THUMBNAIL_FILE`
- `private GameObject updateMod_Button`
- `private GameObject upload_Panel`
- `private Slider upload_Slider`
- `private Image uploadProgress_image`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass40_0`
- `private class <>c__DisplayClass59_0`
- `private class <>c__DisplayClass61_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(SteamWorkshopMenu), "PrivateMethodName", MethodType.Normal)]
class Patch_SteamWorkshopMenu_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(SteamWorkshopMenu), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## StoreGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void BuyAll()`
- `public Void CalculateBasketTotalPrice()`
- `public Void CloseStorePanel()`
- `public Void DuplicateBasketUnit(Unit p_unit)`
- `public Void EmptyAllUnitSlots()`
- `public Void EmptyBasketSlots()`
- `public Void EmptyComparisonStats()`
- `public Unit GetUnitToUpgrade()`
- `public Void OpenPanelInEventMode(EventActionSlotGO p_eventActionSlotGO)`
- `public Void OpenPanelInPurchaseMode()`
- `public Void OpenPanelInUpgradeMode(Unit p_unit)`
- `public Void PopulateBasketSlots()`
- `public Void RemoveUnitFromBasket(Unit p_unit)`
- `public Void SelectFilter(String p_filter)`
- `public Void SetCoreUnit()`
- `public Void SetOptionUnit(UnitStoreSlotGO p_unitStoreSlotGO, String p_optionName)`
- `public Void SetUnitPrice(Unit p_unit)`
- `public Void ShowSelectedUnitStats(Unit unit)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void AddToBasket(Unit p_unit)`
- `private Void Awake()`
- `private Boolean CheckAccessories(Unit unit)`
- `private Void CheckAchievements(Unit unit)`
- `private Void EmptyAllStatsText()`
- `private Void EmptyBasket()`
- `private Void ManageUpgradeUI()`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void PopulateAllUnitSlots()`
- `private Void RefreshBuyButtonText()`
- `private Void RefreshUnitCost(Unit p_unit)`
- `private Void RefreshUpgradeFromIntoUI()`
- `private Void RefreshUpgradePrice()`
- `private Void SelectCountryFilter(TMP_Dropdown p_dropdown)`
- `private Void SelectUnit(Unit p_unit, UnitStoreSlotGO p_unitStoreSlotGO)`
- `private Void SetupUnitsHeader()`
- `private Void Update()`
- `private Void UpgradeUnit()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public TextMeshProUGUI airDamage`
- `public TextMeshProUGUI airDamageComparison`
- `public TextMeshProUGUI ammo`
- `public TextMeshProUGUI ammoComparison`
- `public TextMeshProUGUI armour`
- `public TextMeshProUGUI armourComparison`
- `public GameObject basketSlotCorePrefab`
- `public GameObject basketSlotPrefab`
- `public TextMeshProUGUI basketTotalPrice_Text`
- `public Button buy_button`
- `public TextMeshProUGUI buy_text`
- `public List`1 categoriesImages`
- `public GameObject coreUnit_Button`
- `public TMP_Dropdown filterCountry_Dropdown`
- `public String filterType`
- `public TextMeshProUGUI fuel`
- `public TextMeshProUGUI fuelComparison`
- `public TextMeshProUGUI hardDamage`
- `public TextMeshProUGUI hardDamageComparison`
- `public TextMeshProUGUI HP`
- `public TextMeshProUGUI HPcomparison`
- `public TextMeshProUGUI HQPoints_text`
- `public static StoreGO instance`
- `public TextMeshProUGUI MP`
- `public TextMeshProUGUI MPComparison`
- `public Transform parentForBasket_Transform`
- `public Transform parentForUnitsSlot_Transform`
- `public TextMeshProUGUI productionYear`
- `public TextMeshProUGUI Range`
- `public TextMeshProUGUI rangeComparison`
- `public Sprite selectedABomb_Sprite`
- `public Sprite selectedBomb_Sprite`
- `public List`1 selectedCategories`
- `public Sprite selectedCensoredSS_Sprite`
- `public Sprite selectedDropTank_Sprite`
- `public Sprite selectedElite_Sprite`
- `public Sprite selectedGuards_Sprite`
- `public Sprite selectedHorse_Sprite`
- `public Sprite selectedMechanized_Sprite`
- `public Sprite selectedMotorized_Sprite`
- `public Sprite selectedMountaineer_Sprite`
- `public Sprite selectedRocket_Sprite`
- `public Sprite selectedSS_Sprite`
- `public Sprite selectedTorpedo_Sprite`
- `public Unit selectedUnit`
- `public Sprite selectedWinterSpecialized_Sprite`
- `public TextMeshProUGUI softDamage`
- `public TextMeshProUGUI softDamageComparison`
- `public TextMeshProUGUI turnProduction`
- `public TextMeshProUGUI turnProductionComparison`
- `public GameObject turnToProduceBox`
- `public List`1 unitsBasket`
- `public UnitStoreSlotGO unitSlotPrefab`
- `public Sprite unselectedABomb_Sprite`
- `public Sprite unselectedBomb_Sprite`
- `public Sprite unselectedCensoredSS_Sprite`
- `public Sprite unselectedDropTank_Sprite`
- `public Sprite unselectedElite_Sprite`
- `public Sprite unselectedGuards_Sprite`
- `public Sprite unselectedHorse_Sprite`
- `public Sprite unselectedMechanized_Sprite`
- `public Sprite unselectedMotorized_Sprite`
- `public Sprite unselectedMountaineer_Sprite`
- `public Sprite unselectedRocket_Sprite`
- `public Sprite unselectedSS_Sprite`
- `public Sprite unselectedTorpedo_Sprite`
- `public Sprite unselectedWinterSpecialized_Sprite`
- `public UnitStoreSlotGO upgradeFromUnit`
- `public UnitStoreSlotGO upgradeIntoUnit`
- `public Boolean upgradeMode`
- `public TextMeshProUGUI upkeep`
- `public GameObject upkeepBox`
- `public TextMeshProUGUI upkeepComparison`
- `public TextMeshProUGUI Visibility`
- `public TextMeshProUGUI visibilityComparison`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private String _activeCountryDropdownValue`
- `private List`1 _allUnits`
- `private List`1 _availableCountries`
- `private EventActionSlotGO _eventActionSlotGO`
- `private Player _lastPlayerOpenedStore`
- `private Byte _productionTimeOnStoreOpening`
- `private UnitStoreSlotGO _selectedStoreSlot`
- `private List`1 _unitStoreSlotGOs`
- `private List`1 _unitsWeAreAllowedToBuy`
- `private Unit _unitToUpgrade`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass112_0`
- `private class <>c__DisplayClass99_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(StoreGO), "PrivateMethodName", MethodType.Normal)]
class Patch_StoreGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(StoreGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TargetGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Destroy()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private IEnumerator CR_ChangeAlpha(Boolean p_fadeIn)`
- `private Void OnEnable()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Single fadeTime`
- `private Boolean scaleChange`
- `private SpriteRenderer spriteRenderer`

### Nested Types

- `private class <CR_ChangeAlpha>d__5`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TargetGO), "PrivateMethodName", MethodType.Normal)]
class Patch_TargetGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TargetGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TechTreeTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void OnDisable()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private Int32 _researchTime`
- `private GameObject _tooltip`
- `private Unit _unitBeingResearched`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TechTreeTooltipGO), "PrivateMethodName", MethodType.Normal)]
class Patch_TechTreeTooltipGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TechTreeTooltipGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## testMarker

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject Place`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(testMarker), "PrivateMethodName", MethodType.Normal)]
class Patch_testMarker_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(testMarker), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Tile

### Public Methods

- `public Void DestroyTile(Boolean p_sendRPC)`
- `public Int32 GetAnnexTileCost(Player p_playerRequesting)`
- `public Coordinates GetCoord()`
- `public Byte GetDestroyedTurnsAmount()`
- `public String GetLocalizedDisplayName()`
- `public Byte GetMinimumOccupancyForWork()`
- `public Int32 GetRequestOwnershipCost(Player p_playerRequesting)`
- `public Int32 GetTileSuppliesPenalty(Unit p_unit)`
- `public Boolean HasEnemyAround(Unit p_unitToCheckWith)`
- `public Boolean IsDestroyable()`
- `public Boolean IsValidSupplySource()`
- `public Boolean IsWW1TrenchTile()`
- `public Void SetBorderHex()`
- `public Void SetRuntimeOptimizations()`
- `public Void SetTileSeason()`
- `public Void SetTileType()`
- `public Void SetupForAStar()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

- `public Unit AirUnit` { get; set }
- `public Boolean Bridge` { get; set }
- `public Boolean CanFreezeInWinter` { get; set }
- `public Boolean Capturable` { get; set }
- `public String CityName` { get; set }
- `public Int16 DamageModificator` { get; set }
- `public Int16 EditorOverwrite_income` { get; set }
- `public Int32 EditorOverwrite_manpower` { get; set }
- `public String FilterType` { get; set }
- `public Unit GroundUnit` { get; set }
- `public Boolean IsBridgeDestroyed` { get; set }
- `public Boolean IsOfficial` { get; set }
- `public Boolean IsReinforcementTile` { get; set }
- `public Boolean IsVictoryPoint` { get; set }
- `public Int32 Manpower` { get; set }
- `public Int16 MoneyProductionPerTurn` { get; set }
- `public Int16 MoneyReward` { get; set }
- `public Byte MPCost` { get; set }
- `public String Name` { get; set }
- `public Byte NumberOfTurnsAtLowProd` { get; set }
- `public Byte NumberOfTurnsSinceVPGotCaptured` { get; set }
- `public Int32 OccupiedManpower` { get; set }
- `public Int16 OccupiedMoneyProductionPerTurn` { get; set }
- `public String OriginalCountryOwner` { get; set }
- `public String OwnerName` { get; set }
- `public Boolean PrimaryObjective` { get; set }
- `public Boolean Railroad` { get; set }
- `public String Season` { get; set }
- `public Boolean SeasonNeverChanges` { get; set }
- `public Boolean SecondaryObjective` { get; set }
- `public String Type` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Byte amountOfNeighbours`
- `public Boolean applyZoneOfControl`
- `public Int32 cost`
- `public TileSeason enumSeason`
- `public TileTypes enumType`
- `public Boolean hasBeenLinked`
- `public Boolean hasOwnerPlayer`
- `public Boolean hasRoads`
- `public Boolean hasTerrainOwnerPlayer`
- `public Boolean isBorderHex`
- `public Boolean isCoastLineTile`
- `public Boolean isFrozen`
- `public Boolean isJungleTile`
- `public Boolean isLakeTile`
- `public Boolean isNavalConvoyRoute`
- `public Boolean isOccupied`
- `public Boolean isPartOfArea`
- `public Boolean isRADARtile`
- `public Boolean isRoadOrPlain`
- `public Boolean isShortestPath`
- `public Boolean isSonarTile`
- `public Boolean isValidHarbourForAI`
- `public Boolean isVisible`
- `public Nullable`1 landAreaIndex`
- `public List`1 neighbours`
- `public Boolean OnQueue`
- `public Player ownerPlayer`
- `public Tile parent`
- `public Int16 PosX`
- `public Int16 PosY`
- `public Nullable`1 riverAreaIndex`
- `public Nullable`1 seaAreaIndex`
- `public Boolean searched`
- `public Player terrainOwner`
- `public String terrainOwnerName`
- `public TileGO tileGO`
- `public Boolean unreachable`
- `public Boolean visited`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Unit <AirUnit>k__BackingField`
- `private Boolean <Bridge>k__BackingField`
- `private Boolean <CanFreezeInWinter>k__BackingField`
- `private Boolean <Capturable>k__BackingField`
- `private String <CityName>k__BackingField`
- `private Int16 <DamageModificator>k__BackingField`
- `private Int16 <EditorOverwrite_income>k__BackingField`
- `private Int32 <EditorOverwrite_manpower>k__BackingField`
- `private String <FilterType>k__BackingField`
- `private Unit <GroundUnit>k__BackingField`
- `private Boolean <IsBridgeDestroyed>k__BackingField`
- `private Boolean <IsOfficial>k__BackingField`
- `private Boolean <IsReinforcementTile>k__BackingField`
- `private Boolean <IsVictoryPoint>k__BackingField`
- `private Int32 <Manpower>k__BackingField`
- `private Int16 <MoneyProductionPerTurn>k__BackingField`
- `private Int16 <MoneyReward>k__BackingField`
- `private Byte <MPCost>k__BackingField`
- `private String <Name>k__BackingField`
- `private Byte <NumberOfTurnsAtLowProd>k__BackingField`
- `private Byte <NumberOfTurnsSinceVPGotCaptured>k__BackingField`
- `private Int32 <OccupiedManpower>k__BackingField`
- `private Int16 <OccupiedMoneyProductionPerTurn>k__BackingField`
- `private String <OriginalCountryOwner>k__BackingField`
- `private String <OwnerName>k__BackingField`
- `private Boolean <PrimaryObjective>k__BackingField`
- `private Boolean <Railroad>k__BackingField`
- `private String <Season>k__BackingField`
- `private Boolean <SeasonNeverChanges>k__BackingField`
- `private Boolean <SecondaryObjective>k__BackingField`
- `private String <Type>k__BackingField`

### Nested Types

- `public class Coordinates`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Tile), "PrivateMethodName", MethodType.Normal)]
class Patch_Tile_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Tile), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TileEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AddOfficialTile()`
- `public Void AddTile()`
- `public Void CopyTile()`
- `public Void CreateNewTile()`
- `public Void GenerateTileList()`
- `public Void PastTile()`
- `public Void RefreshTilesList()`
- `public Void RemoveTile()`
- `public Void ResearchUnit()`
- `public Void SaveAll()`
- `public Void SelectModToEdit()`
- `public Void SelectTile(Tile p_tile)`
- `public Void SetBridge()`
- `public Void SetCapturable()`
- `public Void SetManpower()`
- `public Void SetMapEditorCategory()`
- `public Void SetOccupiedManpower()`
- `public Void SetRailroad()`
- `public Void SetReinforcement()`
- `public Void SetTileCaptureMoneyReward()`
- `public Void SetTileDamageModifier()`
- `public Void SetTileMovemenCost()`
- `public Void SetTileName()`
- `public Void SetTileOccupiedProductionPerTurn()`
- `public Void SetTileProductionPerTurn()`
- `public Void SetTileSeason()`
- `public Void SetTileType()`
- `public Void ShowTileStats()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void CheckSelectedTileChanges()`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void RefreshTotalTiles()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button add_Button`
- `public Button addOfficial_Button`
- `public TMP_Dropdown biomeFilter_Dropdown`
- `public Toggle bridge_toggle`
- `public Toggle capturable_toggle`
- `public TMP_InputField captureMoneyReward_InputField`
- `public Button copy_button`
- `public TMP_InputField damageModifier_InputField`
- `public Button delete_Button`
- `public TMP_InputField manpower_InputField`
- `public TMP_Dropdown mods_Dropdown`
- `public TMP_InputField moneyProductionPerTurn_InputField`
- `public TMP_InputField movementPointCost_InputField`
- `public TMP_InputField occupiedManpower_InputField`
- `public TMP_InputField occupiedMoneyProductionPerTurn_InputField`
- `public Transform parentForListOfTiles`
- `public Button paste_button`
- `public Toggle railroad_toggle`
- `public Toggle reinforcement_toggle`
- `public TMP_InputField research_InputField`
- `public GameObject selectedTileBackground`
- `public TMP_Dropdown tileMapEditorCategory_Dropdown`
- `public TMP_InputField tileName_InputField`
- `public Image tileRepresentation_Image`
- `public TMP_Dropdown tileSeason_Dropdown`
- `public GameObject tileSlotPrefab`
- `public TMP_Dropdown tileType_Dropdown`
- `public TextMeshProUGUI totalNumberOfTiles`
- `public Scrollbar verticalScrollbar`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private List`1 _availableSeasons`
- `private Tile _copiedTile`
- `private String _prevSelectedUnitCheckSum`
- `private Tile _selectedTile`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass41_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TileEditor), "PrivateMethodName", MethodType.Normal)]
class Patch_TileEditor_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TileEditor), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TileEditorGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void DestroyFlag()`
- `public Void ManageVPToBeHeld()`
- `public Void RemoveUnits()`
- `public Void SpawnUnit(Unit p_unit)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void ChangeParatrooperState()`
- `private Void ChangeSubmarineState()`
- `private Void ConnectRoadToCityOnEnd()`
- `private List`1 FindNeighboursWithBrushSize()`
- `private Void GenerateLittleIconOverUnit(Unit unit)`
- `private Void ManageLittleIconOverUnit(String p_parameter)`
- `private Void OnMouseOver()`
- `private Void RightClickOnTile()`
- `private Void SetAutoRailroads()`
- `private Void SetAutoRivers()`
- `private Void SetAutoRoads()`
- `private Void SetTile(Boolean p_isAutoRoad)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject airUnitGO`
- `public TextMeshPro cityName`
- `public GameObject flag`
- `public GameObject freezeIcon`
- `public GameObject groundUnitGO`
- `public LineRenderer lineRenderer`
- `public GameObject seasonChangeIcon`
- `public SpriteRenderer spriteRenderer`
- `public Tile tile`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private GameObject _defensiveIcon`
- `private List`1 _listOfNeighbours`
- `private GameObject _targetIcon`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TileEditorGO), "PrivateMethodName", MethodType.Normal)]
class Patch_TileEditorGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TileEditorGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TileGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ClearUnitSpotted()`
- `public Void CopyTileGOFogOfWarSetting(TileGO p_sourceTileGO)`
- `public Sprite GetSprite()`
- `public Color GetSpriteColor()`
- `public Void HighlightTile()`
- `public Void RemoveFogOfWar()`
- `public Void SetCityName()`
- `public Void SetFogOfWar()`
- `public Void SetSmoke()`
- `public Void SetSprite()`
- `public Void SetVPFlag()`
- `public Boolean SpawnUnit(Unit p_unit, Boolean p_playSound, Boolean p_sendRPC, Boolean p_selectNextUnitToDeploy = False)`
- `public Void SpotUnit(Unit p_unit)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void BuildTile(Unit p_unit)`
- `private IEnumerator CR_HighlightTile()`
- `private Void ManageWaypoints()`
- `private Void OnMouseEnter()`
- `private Void OnMouseOver()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public UnitGO airUnitGO`
- `public GameObject buildingIcon`
- `public GameObject cityNameGO`
- `public GameObject flagGO`
- `public UnitGO groundUnitGO`
- `public Boolean isInFogOfWar`
- `public LineRenderer lineRenderer`
- `public GameObject smoke`
- `public Tile tile`
- `public UnitGO unitGOmakingThisTileAvailableForDeployment`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Color _clearColor`
- `private Color _fogOfWarColor`
- `private GameObject _spottedUnitIcon`
- `private SpriteRenderer _spriteRenderer`

### Nested Types

- `private class <>c__DisplayClass19_0`
- `private class <CR_HighlightTile>d__31`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TileGO), "PrivateMethodName", MethodType.Normal)]
class Patch_TileGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TileGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TileSeason

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const TileSeason DESERT`
- `public static const TileSeason SUMMER`
- `public Int32 value__`
- `public static const TileSeason WINTER`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TileSeason), "PrivateMethodName", MethodType.Normal)]
class Patch_TileSeason_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TileSeason), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TilesManagerGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AnnexTile(TileGO p_tileGO, Player p_player)`
- `public Void ClickedOnTile(TileGO p_tileGO)`
- `public Void DisableTilesManagerPanel()`
- `public Void EnableTilesManagerPanel()`
- `public GameObject GetTransferPanel()`
- `public GameObject GetTransferSlot()`
- `public Void RequestTile(TileGO p_tileGO)`
- `public Void ToggleTilesManagerPanel()`
- `public Void TransferTile(TileGO p_tileGO, Player p_player)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void CheckForCapitulationEvents(TileGO p_tileGO)`
- `private Void ClearAllSlots()`
- `private Void OnTileOwnershipChanged(TileGO p_tileGO)`
- `private Void ProcessTileAddition(TileGO p_tileGO)`
- `private Void ProcessTileRemoval(TileGO p_tileGO)`
- `private Void ReorganizeSlots()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static TilesManagerGO instance`
- `public static Boolean isOpen`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private GameObject _annexationSeparator`
- `private Transform _content`
- `private GameObject _panel`
- `private GameObject _requestSeparator`
- `private List`1 _selectedTiles`
- `private TileTransferSlotGO _tileTransferSlotGO`
- `private List`1 _tileTransferSlotGOs`
- `private GameObject _transferPanel`
- `private GameObject _transferSeparator`
- `private GameObject _transferSlot`

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TilesManagerGO), "PrivateMethodName", MethodType.Normal)]
class Patch_TilesManagerGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TilesManagerGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TileTransferSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public TileGO GetTileGO()`
- `public Boolean IsLinkedToTile(TileGO p_tileGO)`
- `public Void Setup(TileGO p_tileGO)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Annex()`
- `private Void ConfirmAnnex()`
- `private Void ConfirmRequest()`
- `private Void Delete()`
- `private Void Focus()`
- `private Void OnDestroy()`
- `private Void Request()`
- `private Void Start()`
- `private Void Transfer()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Button _annex_button`
- `private Button _delete_button`
- `private GameObject _highlight`
- `private Image _image`
- `private Button _request_button`
- `private Button _slot_button`
- `private TMP_Text _text`
- `private TileGO _tileGO`
- `private Button _transfer_button`

### Nested Types

- `private class <>c__DisplayClass15_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TileTransferSlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_TileTransferSlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TileTransferSlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TileTypes

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const TileTypes AIRPORT`
- `public static const TileTypes CITY`
- `public static const TileTypes FACTORY`
- `public static const TileTypes FOREST`
- `public static const TileTypes HARBOUR`
- `public static const TileTypes HILL`
- `public static const TileTypes MARSH`
- `public static const TileTypes MOUNTAIN`
- `public static const TileTypes NONE`
- `public static const TileTypes PLAIN`
- `public static const TileTypes REFINERY`
- `public static const TileTypes RIVER`
- `public static const TileTypes ROAD`
- `public static const TileTypes SEA`
- `public static const TileTypes TRENCH`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TileTypes), "PrivateMethodName", MethodType.Normal)]
class Patch_TileTypes_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TileTypes), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TooltipFlagGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData p_eventData)`
- `public Void OnPointerExit(PointerEventData p_eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void OnDisable()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Boolean ForceShowTooltip`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private Image _image`
- `private Boolean _mouseOverTooltip`
- `private Single _timeAboveTooltip`
- `private GameObject _tooltip`
- `private TextMeshProUGUI _tooltip_text`
- `private RectTransform _tooltipRectTransform`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TooltipFlagGO), "PrivateMethodName", MethodType.Normal)]
class Patch_TooltipFlagGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TooltipFlagGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData p_eventData)`
- `public Void OnPointerExit(PointerEventData p_eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private String GetDynamicText(String p_originalText)`
- `private Void OnDisable()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String forcedText`
- `public Boolean ForceShowTooltip`
- `public String localizationKey`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private Boolean _mouseOverTooltip`
- `private Single _timeAboveTooltip`
- `private GameObject _tooltip`
- `private TextMeshProUGUI _tooltip_text`
- `private RectTransform _tooltipRectTransform`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TooltipGO), "PrivateMethodName", MethodType.Normal)]
class Patch_TooltipGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TooltipGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TurnManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ButtonNextTurn()`
- `public Void CloseEndTurnPanel()`
- `public Void DiplomacyChanged(Boolean p_refreshBorders)`
- `public Void ManageWeather()`
- `public Void NextTurn(Boolean p_sendRPC)`
- `public Void ProcessSingleEvent(Event p_event, EventData eventData = null)`
- `public Void ResetRadarSpottings()`
- `public Void ScenarioStartAnimateHourglass()`
- `public Void ShowHumanEndTurnPanel()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Player AddPlayer(String p_country, String p_faction, Boolean p_AIcontrolled, Int32 p_insertionIndex)`
- `private Void Awake()`
- `private IEnumerator CR_AddEventAsync(Event p_event)`
- `private IEnumerator CR_ChangeSeason()`
- `private IEnumerator CR_MoveUnitsWaypoints()`
- `private IEnumerator CR_RotateHourglass()`
- `private Void CreateCroatia(Player p_playerCapturing, Player p_playerLosing)`
- `private Void CreateVichyFrance(Player p_playerCapturing, Player p_playerLosing)`
- `private Void DoMapFogOfWar()`
- `private Void DoPlayerResearch()`
- `private Void ManageAutoResupply(Boolean p_endOfTurn)`
- `private Void ManageMoneyAndDestroyedTiles()`
- `private Void ManageNotifications()`
- `private Void MolotovRibbentropPact(Player p_playerCapturing, Player p_playerLosing)`
- `private Void NextTurnConfirmation()`
- `private Void ProcessEvents()`
- `private Void ProcessTruces()`
- `private Void RefreshTurnWeatherUI()`
- `private Void SetNextPlayerPlaying()`
- `private Void ShowTurnNumberAndDate()`
- `private Void SpawnPartisans()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static Player currPlayer`
- `public TextMeshProUGUI Date_Text`
- `public GameObject endTurn_Panel`
- `public FadeTileGO fadeTileGO_prefab`
- `public static Player humanPlayer`
- `public static TurnManager instance`
- `public static Boolean isBadWeather`
- `public Image nextHumanPlayer_image`
- `public TextMeshProUGUI nextHumanPlayer_text`
- `public OrderOfBattleGO OrderOfBattleGO`
- `public TMP_InputField password_inputfield`
- `public GameObject rainParticles`
- `public AudioClip rainSound`
- `public AnimationCurve researchRate`
- `public GameObject rightSideUI_panel`
- `public Animator sablierQuiTourne_Animator`
- `public GameObject snowParticles`
- `public AudioClip snowSound`
- `public GameObject startmyturn_button`
- `public TextMeshProUGUI turnNumber`
- `public GameObject units`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Coroutine _CR_changingSeason`
- `private Boolean _isRealtimeMultiplayer`
- `private GameObject weatherGO`

### Nested Types

- `private class <>c`
- `private class <CR_AddEventAsync>d__43`
- `private class <CR_ChangeSeason>d__29`
- `private class <CR_MoveUnitsWaypoints>d__36`
- `private class <CR_RotateHourglass>d__50`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TurnManager), "PrivateMethodName", MethodType.Normal)]
class Patch_TurnManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TurnManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TutorialActions

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const TutorialActions ATTACK_ENEMY_UNIT`
- `public static const TutorialActions BOMBARD_ENEMY_UNIT`
- `public static const TutorialActions BUILD_SOMETHING`
- `public static const TutorialActions CAMERA_MOVE`
- `public static const TutorialActions CAMERA_ZOOM`
- `public static const TutorialActions CHECK_SUPPLIES_STATUS`
- `public static const TutorialActions DECLARE_WAR`
- `public static const TutorialActions DEPLOY_CARRIER_PLANE`
- `public static const TutorialActions DEPLOY_LAND_MINES`
- `public static const TutorialActions DEPLOY_MINES`
- `public static const TutorialActions DEPLOY_NAVAL_MINES`
- `public static const TutorialActions DEPLOY_UNIT`
- `public static const TutorialActions DESTROY_ENEMY_UNIT`
- `public static const TutorialActions DISBAND_UNIT`
- `public static const TutorialActions DROP_PARATROOPERS`
- `public static const TutorialActions EMBARK_IN_BOAT`
- `public static const TutorialActions EMBARK_IN_PLANE`
- `public static const TutorialActions EMBARK_IN_TRAIN`
- `public static const TutorialActions END_TURN`
- `public static const TutorialActions INVITE_TO_FACTION`
- `public static const TutorialActions MOVE_UNIT`
- `public static const TutorialActions NONE`
- `public static const TutorialActions OPEN_DAMAGE_BREAKDOWN`
- `public static const TutorialActions OPEN_DIPLOMACY_MENU`
- `public static const TutorialActions OPEN_FORECAST_WINDOW`
- `public static const TutorialActions OPEN_MANPOWER_WINDOW`
- `public static const TutorialActions OPEN_OBJECTIVE_WINDOW`
- `public static const TutorialActions OPEN_ORDER_OF_BATTLE_MENU`
- `public static const TutorialActions OPEN_POLICIES_MENU`
- `public static const TutorialActions OPEN_RESEARCH_MENU`
- `public static const TutorialActions OPEN_RESERVE_MENU`
- `public static const TutorialActions OPEN_UNIT_HISTORY`
- `public static const TutorialActions OPEN_UPKEEP_WINDOW`
- `public static const TutorialActions PERFORM_LANDING`
- `public static const TutorialActions PICK_POLICY`
- `public static const TutorialActions PURCHASE_UNIT`
- `public static const TutorialActions REDEPLOY_UNIT`
- `public static const TutorialActions REPAIR_BRIDGE`
- `public static const TutorialActions RESUPPLY_UNIT`
- `public static const TutorialActions SELECT_UNIT`
- `public static const TutorialActions START_RESEARCH`
- `public static const TutorialActions SUBMARINE_DIVE`
- `public static const TutorialActions TRANSFER_UNIT`
- `public static const TutorialActions UPGRADE_UNIT`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TutorialActions), "PrivateMethodName", MethodType.Normal)]
class Patch_TutorialActions_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TutorialActions), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TutorialManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void ClosedTutorialWindow()`
- `public Void Continue()`
- `public Void GoBack()`
- `public static Boolean HasAction(TutorialActions p_action)`
- `public Void OpenedTutorialWindow()`
- `public static Void PerformAction(TutorialActions p_action, Boolean p_useInstance = True)`
- `public Void SkipStep()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void AutoAdvanceIfAllowed()`
- `private Void Awake()`
- `private Boolean CanGoNextWithoutTasks()`
- `private Void CompletePage()`
- `private Void CompleteStep()`
- `private Void CompleteTutorial()`
- `private TutorialPage GetCurrentPage()`
- `private TutorialStepData GetCurrentStep()`
- `private TutorialStepData GetStep(Int32 idx)`
- `private Void PerformAction(TutorialActions p_action)`
- `private Void ProcessSkipButton()`
- `private Boolean ShouldProcessTutorial()`
- `private Void Start()`
- `private Void StartPage(Int32 stepIdx, Int32 pageIdx)`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static TutorialManager instance`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Single _activeTaskTime`
- `private Int32 _currentPage`
- `private Int32 _currentStep`
- `private Boolean _isTutorialActive`
- `private HashSet`1 _pendingActions`
- `private TutorialTaskUI _taskItemPrefab`
- `private Dictionary`2 _taskWidgets`
- `private GameObject _tutorialButton`
- `private List`1 _tutorialSteps`
- `private TutorialWindow _tutorialWindow`
- `private static const Single MIN_SKIP_TIME`
- `private Action`2 OnPageCompleted`
- `private Action`2 OnPageStarted`
- `private Action`1 OnStepCompleted`
- `private Action OnTutorialCompleted`

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TutorialManager), "PrivateMethodName", MethodType.Normal)]
class Patch_TutorialManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TutorialManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TutorialPage

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public String bodyLocalizationID`
- `public List`1 tasks`
- `public String titleLocalizationID`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TutorialPage), "PrivateMethodName", MethodType.Normal)]
class Patch_TutorialPage_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TutorialPage), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TutorialStepData

**Base Class:** `UnityEngine.ScriptableObject`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public List`1 pages`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TutorialStepData), "PrivateMethodName", MethodType.Normal)]
class Patch_TutorialStepData_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TutorialStepData), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TutorialTask

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public TutorialActions action`
- `public String localizationID`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TutorialTask), "PrivateMethodName", MethodType.Normal)]
class Patch_TutorialTask_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TutorialTask), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TutorialTaskUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Setup(String p_text, Boolean p_done)`
- `public Void UpdateTaskStatus(Boolean p_done)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void AnimateFulfilled()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private GameObject _fulfilledIcon`
- `private TextMeshProUGUI _label`
- `private GameObject _pendingIcon`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TutorialTaskUI), "PrivateMethodName", MethodType.Normal)]
class Patch_TutorialTaskUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TutorialTaskUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TutorialWindow

**Base Class:** `UIWindowController`

### Public Methods

- `public Void AddTask(TutorialTaskUI p_tutorialTaskUI)`
- `public Void ClearTasks()`
- `public Void SetBody(String p_text)`
- `public Void SetTitle(String p_text)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Maximized()`
- `private Void Minimized()`
- `private virtual Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject nextButton`
- `public GameObject prevButton`
- `public GameObject skipButton`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TextMeshProUGUI _bodyText`
- `private GameObject _content`
- `private Transform _tasksParent`
- `private TextMeshProUGUI _titleText`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TutorialWindow), "PrivateMethodName", MethodType.Normal)]
class Patch_TutorialWindow_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TutorialWindow), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## TweenAction

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const TweenAction ALPHA`
- `public static const TweenAction ALPHA_VERTEX`
- `public static const TweenAction CALLBACK`
- `public static const TweenAction CALLBACK_COLOR`
- `public static const TweenAction CANVAS_ALPHA`
- `public static const TweenAction CANVAS_COLOR`
- `public static const TweenAction CANVAS_MOVE`
- `public static const TweenAction CANVAS_MOVE_X`
- `public static const TweenAction CANVAS_MOVE_Y`
- `public static const TweenAction CANVAS_MOVE_Z`
- `public static const TweenAction CANVAS_PLAYSPRITE`
- `public static const TweenAction CANVAS_ROTATEAROUND`
- `public static const TweenAction CANVAS_ROTATEAROUND_LOCAL`
- `public static const TweenAction CANVAS_SCALE`
- `public static const TweenAction CANVAS_SIZEDELTA`
- `public static const TweenAction CANVASGROUP_ALPHA`
- `public static const TweenAction COLOR`
- `public static const TweenAction DELAYED_SOUND`
- `public static const TweenAction FOLLOW`
- `public static const TweenAction GUI_ALPHA`
- `public static const TweenAction GUI_MOVE`
- `public static const TweenAction GUI_MOVE_MARGIN`
- `public static const TweenAction GUI_ROTATE`
- `public static const TweenAction GUI_SCALE`
- `public static const TweenAction MOVE`
- `public static const TweenAction MOVE_CURVED`
- `public static const TweenAction MOVE_CURVED_LOCAL`
- `public static const TweenAction MOVE_LOCAL`
- `public static const TweenAction MOVE_LOCAL_X`
- `public static const TweenAction MOVE_LOCAL_Y`
- `public static const TweenAction MOVE_LOCAL_Z`
- `public static const TweenAction MOVE_SPLINE`
- `public static const TweenAction MOVE_SPLINE_LOCAL`
- `public static const TweenAction MOVE_TO_TRANSFORM`
- `public static const TweenAction MOVE_X`
- `public static const TweenAction MOVE_Y`
- `public static const TweenAction MOVE_Z`
- `public static const TweenAction ROTATE`
- `public static const TweenAction ROTATE_AROUND`
- `public static const TweenAction ROTATE_AROUND_LOCAL`
- `public static const TweenAction ROTATE_LOCAL`
- `public static const TweenAction ROTATE_X`
- `public static const TweenAction ROTATE_Y`
- `public static const TweenAction ROTATE_Z`
- `public static const TweenAction SCALE`
- `public static const TweenAction SCALE_X`
- `public static const TweenAction SCALE_Y`
- `public static const TweenAction SCALE_Z`
- `public static const TweenAction TEXT_ALPHA`
- `public static const TweenAction TEXT_COLOR`
- `public Int32 value__`
- `public static const TweenAction VALUE3`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(TweenAction), "PrivateMethodName", MethodType.Normal)]
class Patch_TweenAction_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(TweenAction), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UIManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void BlowUpRepairBridge()`
- `public Void CenterCameraOnUnit()`
- `public IEnumerator CenterCameraOnUnitCoroutine(Vector3 pos1, Vector3 pos2, Single duration)`
- `public static Void CloseConfirmationWindow(GameObject p_confirmationWindow)`
- `public Void CloseEndOfGameStatsPanel()`
- `public static Void CloseRelationShipMessage(GameObject relationshipWindow)`
- `public Void ContinuePlayingGameAfterEnd()`
- `public Void DeleteAllWaypoints()`
- `public Void DisbandSelectedUnit()`
- `public Void DiveGoToSurface()`
- `public Void DropParatroopers()`
- `public Void EmbarkDisembark()`
- `public Void EndOfGameMultiplayer()`
- `public static Void EndTurnMultiplayer()`
- `public Void FinishedRenamingUnit()`
- `public Void GenerateCoreUnitsSlots()`
- `public Void GenerateEndOfGameStatistics(String filter)`
- `public Sprite GetWeatherSprite(WeatherPredictionData p_weatherPredictionData)`
- `public Void GoToMainMenu()`
- `public Void HandleMenuStacking(GameObject p_menuOpen)`
- `public Void HideTooltip()`
- `public static Void HideToolTip()`
- `public IEnumerator HighlighTile(Single p_worldPosX, Single p_worldPosY)`
- `public Void ManageChatBox()`
- `public Void ManageCoreUnitsPanel()`
- `public Void ManageDiplomacyPanel()`
- `public Void ManageInGameMenu()`
- `public Void ManageMinimap()`
- `public Void ManageMoreStatsPanel()`
- `public Void ManageObjectivesPanel()`
- `public Void ManageSoundPanel()`
- `public Void ManageStatsPanel()`
- `public Void ManageUnitSleep()`
- `public Void NextUnit()`
- `public Void OpenStorePanel()`
- `public Void OpenUnitStatsPanel()`
- `public Void OpenUpgradePanel(Unit p_unit)`
- `public Void OpenUpgradePanel_Button()`
- `public Void PauseUnpause()`
- `public Void PrevUnit()`
- `public Void QuickSave()`
- `public Void QuitGame()`
- `public Void QuitToMapEditor()`
- `public static Void ReceivedNewHero(UnitGO p_unitGO)`
- `public Void RefreshCoreUnits()`
- `public Void RefreshCurrentPlayerFlag()`
- `public Void RefreshIncomePerTurnUI()`
- `public Void RefreshManpower()`
- `public Void RefreshMoneyAmountUI()`
- `public Void RefreshTechTreeNotification()`
- `public Void RenameUnit()`
- `public Void ResignMultiplayerGame()`
- `public Void ResupplyAmmo()`
- `public Void ResupplyAmmoAndFuel()`
- `public Void ResupplyFuel()`
- `public Void ResupplyHP()`
- `public Void SendMessage()`
- `public Void SendSelectedUnitBackToReserve()`
- `public Void ShowAllWaypoints()`
- `public static GameObject ShowConfirmationWindow(String text, Action action)`
- `public Void ShowEventMessageWindow(String p_text)`
- `public Void ShowHideAirGroundUnit(Boolean doesSound)`
- `public Void ShowHideAllIconsForBuildings()`
- `public Void ShowHideAllUnits(Boolean p_show)`
- `public Void SHowHideAllUnitsButton()`
- `public static GameObject ShowMessage(String p_text, Single p_timeOverride = 2)`
- `public Void ShowPreviousTurnSummary(Boolean makeClickSound)`
- `public static Void ShowRelationshipChangeMessage(String country1, String country2, String text)`
- `public Void ShowStatsMidGame()`
- `public Void ShowWaypoints(Unit p_unit)`
- `public Void SortEndTurnSummary(String p_dataType)`
- `public static Void SwitchNATOrepresentation()`
- `public Void Undo()`
- `public Void UpdateVPtext()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void CenterCameraOnCoreUnit(Int32 unit_ID)`
- `private IEnumerator ChangeRingOpacity(GameObject instantiatedRing)`
- `private Void CheckAchievements()`
- `private Void ClearAllCoreUnitsSlots()`
- `private Void ConfirmDisbandUnit()`
- `private IEnumerator CR_QuitToMainMenu()`
- `private Void DisableInGameMenu()`
- `private Void EnableInGameMenu()`
- `private Void EndTheGame()`
- `private Void HideSpeedWindow()`
- `private Boolean IsLegitVictory()`
- `private Void LoadNextScenario(String p_campaignScenarioName)`
- `private Void ManageNextScenarioButtons()`
- `private IEnumerator ShowHidePausePanel()`
- `private Void SpawnVPindicator(Vector3 position, Boolean majorVP)`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static GameObject activeConfirmationWindow`
- `public Sprite awake_SPrite`
- `public Sprite badWeather_rain`
- `public Sprite badWeather_snow`
- `public Button blowRepairBridge_Button`
- `public Transform BOTTOM_parent`
- `public GameObject buildingIconPrefab`
- `public TMP_InputField chat_inputfield`
- `public GameObject chat_Notification`
- `public GameObject chat_panel`
- `public Transform chat_parent`
- `public Sprite clearWeather`
- `public Button closeEndOfGameMenu_button`
- `public GameObject continue_Button`
- `public GameObject coreUnitPrefab`
- `public GameObject coreUnitsPanel`
- `public Transform coreUnitsParent`
- `public Image currentPlayerFlag_image`
- `public GameObject diplomacy_panel`
- `public Sprite dive_sprite`
- `public Button diveSurface_Button`
- `public Button embarkDisembark_Button`
- `public GameObject end_Panel`
- `public TextMeshProUGUI endOfScenario_Text`
- `public Transform endOfScenarioParent`
- `public GameObject endOfScenarioPrefab`
- `public GameObject entireUI`
- `public Image frozenTile_Image`
- `public GameObject heroStats_Panel`
- `public GameObject highlightRingPrefab`
- `public HoverUnitUI hoverUnitUI`
- `public GameObject inGameMenu_Panel`
- `public static UIManager instance`
- `public static Boolean isNATO`
- `public Boolean isSoundPanelOpen`
- `public static Boolean isUIOpen`
- `public LastTurnSummaryUI lastTurnSummarySlot_prefab`
- `public static Single LeftClickTime`
- `public GameObject leftUI_GO`
- `public Canvas mainCanvas`
- `public GameObject mainMenu_Button`
- `public GameObject manpower_parent`
- `public TextMeshProUGUI manpower_Text`
- `public GameObject manpower_tooltip`
- `public static EndGameResults matchResult`
- `public GameObject message_prefab`
- `public Button midGameStatisticsButton`
- `public NewMinimap minimap`
- `public GameObject money_tooltip`
- `public GameObject moreStats_Panel`
- `public static String nextMapChoice`
- `public Button nextScenarioChoice1_Button`
- `public Button nextScenarioChoice2_Button`
- `public TextMeshProUGUI numberOfVP_Text`
- `public GameObject objectives_Panel`
- `public TextMeshProUGUI objectiveScenarioDescription_Text`
- `public TextMeshProUGUI objectiveScenarioName_Text`
- `public GameObject OOB_panel`
- `public Image pause_image`
- `public TextMeshProUGUI playerIncomePerTurn_text`
- `public TextMeshProUGUI playerMoneyAmount_Text`
- `public GameObject Policies_panel`
- `public GameObject potentialDamagePanel`
- `public GameObject previousTurnSummary_panel`
- `public Transform previousTurnSummary_parent`
- `public Button quitToMapEditorButton`
- `public GameObject research_Notification`
- `public GameObject reservePanel`
- `public Button resupplyAmmo_Button`
- `public Button resupplyBoth_Button`
- `public GameObject resupplyCost_Panel`
- `public Button resupplyFuel_Button`
- `public Button resupplyHP_Button`
- `public GameObject saveLoad_Panel`
- `public TMP_InputField scenarioDescription_inputField`
- `public TextMeshProUGUI scenarioName_text`
- `public SelectedUnitExtraStatsUI SelectedUnitExtraStatsUI`
- `public SelectedUnitUI selectedUnitUI`
- `public static Boolean showAirUnit`
- `public Button showDropZone_Button`
- `public Sprite skip_sprite`
- `public Image sleeping_Button`
- `public Sprite sleeping_SPrite`
- `public GameObject sound_Panel`
- `public TextMeshProUGUI startResumeButton_text`
- `public UnitStatsPanelUI stats_Panel`
- `public GameObject store_Panel`
- `public GameObject supplyLine`
- `public Sprite surface_sprite`
- `public GameObject techTree_panel`
- `public TextMeshProUGUI tileCoordinates_Text`
- `public TextMeshProUGUI tileDamageModifier_Text`
- `public Image tileInfoOwnerCountry_Image`
- `public Image tileInfoRepresentation_Image`
- `public TextMeshProUGUI tileMPCost_Text`
- `public TextMeshProUGUI tileProduction_text`
- `public TextMeshProUGUI tileType_Text`
- `public TextMeshProUGUI timePlayed_Text`
- `public GameObject tooltip`
- `public Image twoUnitsIndicator_image`
- `public Sprite twoUnitsIndicatorAirGreen_sprite`
- `public Sprite twoUnitsIndicatorGroundGreen_sprite`
- `public Transform UI_parent`
- `public Button undo_Button`
- `public GameObject unitMovePath`
- `public TMP_InputField unitName_InputField`
- `public Transform unitsParent`
- `public Sprite unpredictableWeather`
- `public Button upgrade_button`
- `public TextMeshProUGUI victoryDefeat_Text`
- `public Transform waypointsParent`
- `public Image weather_image`
- `public TextMeshProUGUI weather_Text`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean _ascending`
- `private Int32 _count`
- `private Boolean _hasStartedEndOfScenario`
- `private Boolean _isShowingAllWaypoints`
- `private Boolean _quittingToMainMenu`
- `private Boolean _showBuildingsIcons`
- `private Boolean _surrendered`
- `private TextMeshProUGUI coreUnit_Text`
- `private TextMeshProUGUI coreUnit2_Text`
- `private GameObject CoreUnitsBox_parent`
- `private static Single resetDelay`
- `private TextMeshProUGUI timeSpeed_text`
- `private GameObject timeSpeedWindow`
- `private List`1 VPindicators`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass126_0`
- `private class <>c__DisplayClass132_0`
- `private class <>c__DisplayClass188_0`
- `private class <>c__DisplayClass207_0`
- `private class <CenterCameraOnUnitCoroutine>d__204`
- `private class <ChangeRingOpacity>d__202`
- `private class <CR_QuitToMainMenu>d__216`
- `private class <EndOfGameMultiplayer>d__186`
- `private class <EndTurnMultiplayer>d__184`
- `private class <HighlighTile>d__201`
- `private class <ResignMultiplayerGame>d__185`
- `private class <ShowHidePausePanel>d__143`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UIManager), "PrivateMethodName", MethodType.Normal)]
class Patch_UIManager_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UIManager), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UIWindowController

**Base Class:** `UnityEngine.MonoBehaviour`

**Modifiers:** `abstract`

### Public Methods

- `public Void Close()`
- `public Void Maximize()`
- `public Void Minimize()`
- `public Void OnBeginDrag(PointerEventData e)`
- `public Void OnDrag(PointerEventData e)`
- `public Void OnPointerDown(PointerEventData e)`
- `public Void OnPointerEnter(PointerEventData e)`
- `public Void OnPointerExit(PointerEventData e)`
- `public Void OnPointerUp(PointerEventData e)`
- `public Void Open()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private virtual Void Awake()`
- `private Void ClampToParent()`
- `private Void OnStateChanged()`
- `private Void RefreshSizeButtons()`
- `private Void ResetCursor()`
- `private Void ResetEdges()`
- `private Void Resize(Vector2 pointerDelta)`
- `private Void ResolveActionAndEdges(PointerEventData e, Actions& act, Boolean& l, Boolean& r, Boolean& t, Boolean& b)`
- `private Void SetPivotAndHeightKeepTop(RectTransform rt, Single pivotY, Vector2 newSize)`
- `private Void SetResizeCursor(Boolean l, Boolean r, Boolean t, Boolean b)`
- `private virtual Void Start()`
- `private Void Update()`
- `private Void UpdateCursor(PointerEventData e)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Boolean canMinimizeMaximize`
- `public Texture2D cursorMove`
- `public Texture2D cursorResizeDiag1`
- `public Texture2D cursorResizeDiag2`
- `public Texture2D cursorResizeHorizontal`
- `public Texture2D cursorResizeVertical`
- `public Single dragBorderLeftRight`
- `public Single dragBorderUpDown`
- `public GameObject maximizeButton`
- `public GameObject minimizeButton`
- `public Vector2 minimizedSize`
- `public Vector2 minWindowSize`
- `public Texture2D regularCursor`
- `public Single resizeBorder`
- `public Boolean useCustomCursors`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Boolean bottom`
- `private Actions currentAction`
- `private States currentState`
- `private Boolean left`
- `private Action OnMaximized`
- `private Action OnMinimized`
- `private Boolean pointerInside`
- `private Vector2 prevPointerPos`
- `private Vector2 prevSizeDelta`
- `private RectTransform rect`
- `private Boolean right`
- `private Canvas rootCanvas`
- `private Boolean top`

### Nested Types

- `private class Actions`
- `private class States`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UIWindowController), "PrivateMethodName", MethodType.Normal)]
class Patch_UIWindowController_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UIWindowController), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Unit

### Public Methods

- `public Void AddMorale(Int32 p_amount)`
- `public Void AddRemoveActionPoints(Int32 p_value)`
- `public Void AddToHistory(String p_text, Boolean p_sendRPC)`
- `public Void AddToKillCount(Unit p_unitKilled)`
- `public Void AddXP(Int32 p_XPamount, Boolean p_canAddHero, Boolean p_showXPUI)`
- `public Void ApplyModdedUnitModifications(Unit p_sourceUnit)`
- `public Void ApplyModification(UnitModification p_modification)`
- `public Void CacheUnitNameToLower()`
- `public Void CalculateAndSetManpowerCost()`
- `public Void CalculateAndSetUnitPrice()`
- `public Void CalculateAndSetUpkeepValue()`
- `public Boolean CanApplyZoneOfControl(Unit p_unit)`
- `public Boolean CanMove()`
- `public Boolean CanMoveOnMarshes()`
- `public Boolean CanMoveOnRivers()`
- `public Boolean CanMoveOverMountains()`
- `public Unit Clone(Boolean p_generateNewID)`
- `public Void EmbarkDisembarkBoat()`
- `public Void EmbarkDisembarkPlane()`
- `public Void EmbarkDisembarkTrain()`
- `public Int32 GenerateNewID()`
- `public Int32 GetArmour()`
- `public static String GetAuthorizedRotationLocalizationKey(AllowedRotations p_allowedRotation)`
- `public Int32 GetHealAmount()`
- `public Int32 GetHealCost()`
- `public Single GetHPPercent(Boolean p_forDamagePurposes)`
- `public Void GetLevelAndXPToNext(Int32& o_level, Int32& o_XPToNextLevel)`
- `public MoraleStates GetMoraleState()`
- `public String GetMovementSound()`
- `public String GetNameToLower()`
- `public static Int32 GetNewID32()`
- `public Int32 GetPotentialDamage(UnitGO p_targetUnitGO, Boolean p_isRetaliation, Boolean p_isSupportiveFire)`
- `public Int32 GetRedeployCost()`
- `public Int32 GetResupplyAmmoAndFuelCost()`
- `public Int32 GetResupplyAmmoCost()`
- `public Int32 GetResupplyFuelCost()`
- `public Int32 GetResupplyManpowerCost(Int32 p_HPamount)`
- `public String GetSuffix()`
- `public UnitCategories GetUnitCategory()`
- `public String GetUnitName()`
- `public Byte GetUpgradeTurnProduction(Unit p_fromUnit, Byte p_currentProductionTime)`
- `public Int32 GetUpkeepCost(Boolean p_getReserveCost)`
- `public Int32 GetVeterancyOptionCost()`
- `public Void Heal()`
- `public Boolean IsConsideredHeavyEquipment()`
- `public Boolean IsSpecialUnit()`
- `public Void NextScenario()`
- `public Void NextTurn()`
- `public Void PatchOnNetworkReceived()`
- `public Void RedeployUnit(Boolean p_removeMoney, Boolean p_sendRPC)`
- `public Void ResupplyAmmo()`
- `public Void ResupplyAmmoAndFuel()`
- `public Void ResupplyFuel()`
- `public Void RevertModification(UnitModification p_modification)`
- `public Void SetCommissionDate()`
- `public Void SetDefaultAuthorizedRotation()`
- `public Void SetDefaultProductionTime()`
- `public Void SetRedeploymentTime()`
- `public Void SetUnitCustomName()`
- `public Void SetVeterancyOptionCost(Int32 p_cost)`
- `public Void SyncFromNetwork(Unit p_sourceUnit, Boolean p_refreshGraphics)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void AddHero()`
- `private Void CheckAchievements()`
- `private Void GenerateHerostats()`

### Public Properties

- `public UInt16 AAKill` { get; set }
- `public Byte ActionPoints` { get; set }
- `public Int16 AIPurchaseChanceOverride` { get; set }
- `public Int16 AirDamage` { get; set }
- `public AllowedRotations AllowedRotation` { get; set }
- `public UInt16 AntitankKill` { get; set }
- `public Int16 Armour` { get; set }
- `public UInt16 ArtilleryKill` { get; set }
- `public AsleepStates AsleepState` { get; set }
- `public Byte AttackedAmountThisTurn` { get; set }
- `public String AttackSound` { get; set }
- `public Boolean AutoSupplies` { get; set }
- `public Int16 BaseMaxAutonomy` { get; set }
- `public UInt16 BoatKill` { get; set }
- `public Boolean BuiltByEngineers` { get; set }
- `public Boolean CanAttackShips` { get; set }
- `public Boolean CanBeRefueledOnCarrier` { get; set }
- `public Boolean CanCarryABomb` { get; set }
- `public Boolean CanCarryBombs` { get; set }
- `public Boolean CanCarryDropTank` { get; set }
- `public Boolean CanCarryRockets` { get; set }
- `public Boolean CanCarryTorpedo` { get; set }
- `public Boolean CanCatapultPlanes` { get; set }
- `public Boolean CanLayMines` { get; set }
- `public UInt16 CASKill` { get; set }
- `public Int16 CategoryID` { get; set }
- `public Boolean CoastalBattery` { get; set }
- `public String CommanderTargets` { get; set }
- `public Int32 Cost` { get; set }
- `public String Country` { get; set }
- `public Int16 CurrAmmo` { get; set }
- `public Int16 CurrAutonomy` { get; set }
- `public Int32 CurrHP` { get; set }
- `public Byte CurrMP` { get; set }
- `public Int32 CustomCost` { get; set }
- `public Int32 CustomManpowerCost` { get; set }
- `public String CustomName` { get; set }
- `public Byte CustomTurnProduction` { get; set }
- `public Single CustomUpkeepValue` { get; set }
- `public Int16 EndUseYear` { get; set }
- `public Byte EntrenchmentLevel` { get; set }
- `public Nullable`1 EntrenchmentLevelOnStart` { get; set }
- `public FacingRotations FacingRotation` { get; set }
- `public UInt16 FighterKill` { get; set }
- `public String FilterType` { get; set }
- `public String ForcedCustomName` { get; set }
- `public Int16 HardDamage` { get; set }
- `public Boolean HasABomb` { get; set }
- `public Boolean HasAttacked` { get; set }
- `public Boolean HasBombs` { get; set }
- `public Boolean HasBuilt` { get; set }
- `public Boolean HasDropTank` { get; set }
- `public Boolean HasFlamethrower` { get; set }
- `public Boolean HasMoved` { get; set }
- `public Boolean HasOverrun` { get; set }
- `public Boolean HasResuppliedAmmo` { get; set }
- `public Boolean HasResuppliedFuel` { get; set }
- `public Boolean HasRockets` { get; set }
- `public Boolean HasSonar` { get; set }
- `public Boolean HasTorpedo` { get; set }
- `public UInt16 HeavyBomberKill` { get; set }
- `public Hero Hero` { get; set }
- `public Nullable`1 HPmodifierOnScenarioStart` { get; set }
- `public Int32 ID` { get; set }
- `public Boolean ImmuneToWinterDamage` { get; set }
- `public UInt16 InfantryKill` { get; set }
- `public Boolean IsAmphibious` { get; set }
- `public Boolean IsArmouredTrain` { get; set }
- `public Boolean IsArmourObstacle` { get; set }
- `public Boolean IsCarrier` { get; set }
- `public Boolean IsCatapultPlane` { get; set }
- `public Boolean IsCavalry` { get; set }
- `public Boolean IsCommander` { get; set }
- `public Boolean IsConvoy` { get; set }
- `public Boolean IsCoreUnit` { get; set }
- `public Boolean IsDead` { get; set }
- `public Boolean IsDefensive` { get; set }
- `public Boolean IsDestroyer` { get; set }
- `public Boolean IsDropable` { get; set }
- `public Boolean IsEliteUnit` { get; set }
- `public Boolean IsEngineers` { get; set }
- `public Boolean IsHorsed` { get; set }
- `public Boolean IsKillGoal` { get; set }
- `public Boolean IsLaunchSite` { get; set }
- `public Boolean IsMechanized` { get; set }
- `public Boolean IsMine` { get; set }
- `public Boolean IsMineFlail` { get; set }
- `public Boolean IsMissile` { get; set }
- `public Boolean IsMotorized` { get; set }
- `public Boolean IsMountaineer` { get; set }
- `public Boolean IsOnBoat` { get; set }
- `public Boolean IsParatrooper` { get; set }
- `public Boolean IsPartisans` { get; set }
- `public Boolean IsPatrolBoat` { get; set }
- `public Boolean IsPoliticalUnit` { get; set }
- `public Boolean IsPontoonBridge` { get; set }
- `public Boolean IsPrototype` { get; set }
- `public Boolean IsRADAR` { get; set }
- `public Boolean IsRecon` { get; set }
- `public Boolean IsRemoved` { get; set }
- `public Boolean IsReserve` { get; set }
- `public Boolean IsSubmarine` { get; set }
- `public Boolean IsSubmerged` { get; set }
- `public Boolean IsSupplyDepot` { get; set }
- `public Boolean IsSupplyShip` { get; set }
- `public Boolean IsTrain` { get; set }
- `public Boolean IsWinterSpecialized` { get; set }
- `public Byte Lvl` { get; set }
- `public Int16 MaxAmmo` { get; set }
- `public Int16 MaxAutonomy` { get; set }
- `public Int32 MaxHP` { get; set }
- `public Byte MaxMP` { get; set }
- `public Int16 MaxPurchaseTime` { get; set }
- `public Byte Morale` { get; set }
- `public String MovementSound` { get; set }
- `public Boolean MoveOrAttack` { get; set }
- `public String Name` { get; set }
- `public Boolean NoAmmoTurn1` { get; set }
- `public Boolean NoCapture` { get; set }
- `public Boolean NoEntrenchmentTurn1` { get; set }
- `public Boolean NoLendLease` { get; set }
- `public Byte NumberOfTilesMovedDuringCurrentTurn` { get; set }
- `public Int16 NumberOfTimesTheUnitMoved` { get; set }
- `public Byte NumberOfTurnsUnderWater` { get; set }
- `public String OwnerName` { get; set }
- `public Boolean PermanentDeath` { get; set }
- `public Byte ProductionMonth` { get; set }
- `public Int16 ProductionYear` { get; set }
- `public Int32 ProgressiveCost` { get; set }
- `public Byte Range` { get; set }
- `public Int16 SoftDamage` { get; set }
- `public List`1 StuffThatHappened` { get; set }
- `public Int16 TampAutonomy` { get; set }
- `public Int16 TampMaxAutonomy` { get; set }
- `public Byte TampMaxMP` { get; set }
- `public Byte TampMP` { get; set }
- `public UInt16 TankKill` { get; set }
- `public Boolean TileBuilding` { get; set }
- `public UInt16 TotalDistance` { get; set }
- `public UInt16 TotalKill` { get; set }
- `public Byte TurnToProduce` { get; set }
- `public String Type` { get; set }
- `public Byte Visibility` { get; set }
- `public List`1 Waypoints` { get; set }
- `public Int16 XP` { get; set }

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Int32 armourBreakdown`
- `public Int16 BaseAirDamage`
- `public Int16 BaseArmour`
- `public Int32 baseDamageBreakdown`
- `public Int16 BaseHardDamage`
- `public Int16 BaseMaxAmmo`
- `public Int32 BaseMaxHP`
- `public Byte BaseMaxMP`
- `public Byte BaseRange`
- `public Int16 BaseSoftDamage`
- `public Int32 baseUnitCost`
- `public Byte BaseVisibility`
- `public Int32 biomeBreakdown`
- `public Int32 combinedArmsBreakdown`
- `public DamageTypes DamageDealingTypeForCommander`
- `public Int32 destroyerVSsubmergedSubBreakdown`
- `public Int32 encirclementBreakdown`
- `public Int32 entrenchmentBreakdown`
- `public Int32 FinalDamage`
- `public Int32 flamethrowerBreakdown`
- `public Int32 generalBreakdown`
- `public Int32 heavyBomberVSshipsWithoutTorpedoBreakdown`
- `public Int32 heroBreakdown`
- `public Int32 hillBreakdown`
- `public Int32 HPbreakdown`
- `public Int32 landingBreakdown`
- `public Int32 manpowerCost`
- `public static Byte MAX_LEVEL`
- `public static Byte MORALE_DEFAULT`
- `public static Byte MORALE_ELITE`
- `public Int32 moraleBreakdown`
- `public Int32 mountaineerBreakdown`
- `public String nameToLower`
- `public static Byte NEW_HP_MAX_PER_LEVEL`
- `public Int32 othersBreakdown`
- `public Boolean OthersNeedUsAsBridge`
- `public Boolean OthersNeedUsAsBridgeNotArtificially`
- `public Player OwnerPlayer`
- `public Int32 policyBreakdown`
- `public Int32 politicalUnitsBreakdown`
- `public Int32 reconBreakdown`
- `public Int32 repeatedAttacksBreakdown`
- `public static Single RETREAT_THRESHOLD`
- `public Int32 riverBreakdown`
- `public Int32 shipVSgroundUnitsBreakdown`
- `public Boolean shouldMoveOutNow`
- `public Boolean shouldPerformDirectSwap`
- `public Int32 subVSlandingCraftBreakdown`
- `public Single SupplyPercentage`
- `public Int32 swapeeUnitID`
- `public Int32 terrainArmouredBreakdown`
- `public Int32 terrainBreakdown`
- `public Int32 torpedoBreakdown`
- `public UnitGO unitGO`
- `public Single UpkeepValue`
- `public Int32 veterancyBreakdown`
- `public Int32 veterancyOptionCost`
- `public Int32 weatherBreakdown`
- `public Boolean willReplaceUnitMovingOut1`
- `public Boolean willReplaceUnitMovingOut2`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private UInt16 <AAKill>k__BackingField`
- `private Byte <ActionPoints>k__BackingField`
- `private Int16 <AIPurchaseChanceOverride>k__BackingField`
- `private Int16 <AirDamage>k__BackingField`
- `private AllowedRotations <AllowedRotation>k__BackingField`
- `private UInt16 <AntitankKill>k__BackingField`
- `private Int16 <Armour>k__BackingField`
- `private UInt16 <ArtilleryKill>k__BackingField`
- `private AsleepStates <AsleepState>k__BackingField`
- `private Byte <AttackedAmountThisTurn>k__BackingField`
- `private String <AttackSound>k__BackingField`
- `private Boolean <AutoSupplies>k__BackingField`
- `private Int16 <BaseMaxAutonomy>k__BackingField`
- `private UInt16 <BoatKill>k__BackingField`
- `private Boolean <BuiltByEngineers>k__BackingField`
- `private Boolean <CanAttackShips>k__BackingField`
- `private Boolean <CanBeRefueledOnCarrier>k__BackingField`
- `private Boolean <CanCarryABomb>k__BackingField`
- `private Boolean <CanCarryBombs>k__BackingField`
- `private Boolean <CanCarryDropTank>k__BackingField`
- `private Boolean <CanCarryRockets>k__BackingField`
- `private Boolean <CanCarryTorpedo>k__BackingField`
- `private Boolean <CanCatapultPlanes>k__BackingField`
- `private Boolean <CanLayMines>k__BackingField`
- `private UInt16 <CASKill>k__BackingField`
- `private Int16 <CategoryID>k__BackingField`
- `private Boolean <CoastalBattery>k__BackingField`
- `private String <CommanderTargets>k__BackingField`
- `private Int32 <Cost>k__BackingField`
- `private String <Country>k__BackingField`
- `private Int16 <CurrAmmo>k__BackingField`
- `private Int16 <CurrAutonomy>k__BackingField`
- `private Int32 <CurrHP>k__BackingField`
- `private Byte <CurrMP>k__BackingField`
- `private Int32 <CustomCost>k__BackingField`
- `private Int32 <CustomManpowerCost>k__BackingField`
- `private String <CustomName>k__BackingField`
- `private Byte <CustomTurnProduction>k__BackingField`
- `private Single <CustomUpkeepValue>k__BackingField`
- `private Int16 <EndUseYear>k__BackingField`
- `private Byte <EntrenchmentLevel>k__BackingField`
- `private Nullable`1 <EntrenchmentLevelOnStart>k__BackingField`
- `private FacingRotations <FacingRotation>k__BackingField`
- `private UInt16 <FighterKill>k__BackingField`
- `private String <FilterType>k__BackingField`
- `private String <ForcedCustomName>k__BackingField`
- `private Int16 <HardDamage>k__BackingField`
- `private Boolean <HasABomb>k__BackingField`
- `private Boolean <HasAttacked>k__BackingField`
- `private Boolean <HasBombs>k__BackingField`
- `private Boolean <HasBuilt>k__BackingField`
- `private Boolean <HasDropTank>k__BackingField`
- `private Boolean <HasFlamethrower>k__BackingField`
- `private Boolean <HasMoved>k__BackingField`
- `private Boolean <HasOverrun>k__BackingField`
- `private Boolean <HasResuppliedAmmo>k__BackingField`
- `private Boolean <HasResuppliedFuel>k__BackingField`
- `private Boolean <HasRockets>k__BackingField`
- `private Boolean <HasSonar>k__BackingField`
- `private Boolean <HasTorpedo>k__BackingField`
- `private UInt16 <HeavyBomberKill>k__BackingField`
- `private Hero <Hero>k__BackingField`
- `private Nullable`1 <HPmodifierOnScenarioStart>k__BackingField`
- `private Int32 <ID>k__BackingField`
- `private Boolean <ImmuneToWinterDamage>k__BackingField`
- `private UInt16 <InfantryKill>k__BackingField`
- `private Boolean <IsAmphibious>k__BackingField`
- `private Boolean <IsArmouredTrain>k__BackingField`
- `private Boolean <IsArmourObstacle>k__BackingField`
- `private Boolean <IsCarrier>k__BackingField`
- `private Boolean <IsCatapultPlane>k__BackingField`
- `private Boolean <IsCavalry>k__BackingField`
- `private Boolean <IsCommander>k__BackingField`
- `private Boolean <IsConvoy>k__BackingField`
- `private Boolean <IsCoreUnit>k__BackingField`
- `private Boolean <IsDead>k__BackingField`
- `private Boolean <IsDefensive>k__BackingField`
- `private Boolean <IsDestroyer>k__BackingField`
- `private Boolean <IsDropable>k__BackingField`
- `private Boolean <IsEliteUnit>k__BackingField`
- `private Boolean <IsEngineers>k__BackingField`
- `private Boolean <IsHorsed>k__BackingField`
- `private Boolean <IsKillGoal>k__BackingField`
- `private Boolean <IsLaunchSite>k__BackingField`
- `private Boolean <IsMechanized>k__BackingField`
- `private Boolean <IsMine>k__BackingField`
- `private Boolean <IsMineFlail>k__BackingField`
- `private Boolean <IsMissile>k__BackingField`
- `private Boolean <IsMotorized>k__BackingField`
- `private Boolean <IsMountaineer>k__BackingField`
- `private Boolean <IsOnBoat>k__BackingField`
- `private Boolean <IsParatrooper>k__BackingField`
- `private Boolean <IsPartisans>k__BackingField`
- `private Boolean <IsPatrolBoat>k__BackingField`
- `private Boolean <IsPoliticalUnit>k__BackingField`
- `private Boolean <IsPontoonBridge>k__BackingField`
- `private Boolean <IsPrototype>k__BackingField`
- `private Boolean <IsRADAR>k__BackingField`
- `private Boolean <IsRecon>k__BackingField`
- `private Boolean <IsRemoved>k__BackingField`
- `private Boolean <IsReserve>k__BackingField`
- `private Boolean <IsSubmarine>k__BackingField`
- `private Boolean <IsSubmerged>k__BackingField`
- `private Boolean <IsSupplyDepot>k__BackingField`
- `private Boolean <IsSupplyShip>k__BackingField`
- `private Boolean <IsTrain>k__BackingField`
- `private Boolean <IsWinterSpecialized>k__BackingField`
- `private Byte <Lvl>k__BackingField`
- `private Int16 <MaxAmmo>k__BackingField`
- `private Int16 <MaxAutonomy>k__BackingField`
- `private Int32 <MaxHP>k__BackingField`
- `private Byte <MaxMP>k__BackingField`
- `private Int16 <MaxPurchaseTime>k__BackingField`
- `private Byte <Morale>k__BackingField`
- `private String <MovementSound>k__BackingField`
- `private Boolean <MoveOrAttack>k__BackingField`
- `private String <Name>k__BackingField`
- `private Boolean <NoAmmoTurn1>k__BackingField`
- `private Boolean <NoCapture>k__BackingField`
- `private Boolean <NoEntrenchmentTurn1>k__BackingField`
- `private Boolean <NoLendLease>k__BackingField`
- `private Byte <NumberOfTilesMovedDuringCurrentTurn>k__BackingField`
- `private Int16 <NumberOfTimesTheUnitMoved>k__BackingField`
- `private Byte <NumberOfTurnsUnderWater>k__BackingField`
- `private String <OwnerName>k__BackingField`
- `private Boolean <PermanentDeath>k__BackingField`
- `private Byte <ProductionMonth>k__BackingField`
- `private Int16 <ProductionYear>k__BackingField`
- `private Int32 <ProgressiveCost>k__BackingField`
- `private Byte <Range>k__BackingField`
- `private Int16 <SoftDamage>k__BackingField`
- `private List`1 <StuffThatHappened>k__BackingField`
- `private Int16 <TampAutonomy>k__BackingField`
- `private Int16 <TampMaxAutonomy>k__BackingField`
- `private Byte <TampMaxMP>k__BackingField`
- `private Byte <TampMP>k__BackingField`
- `private UInt16 <TankKill>k__BackingField`
- `private Boolean <TileBuilding>k__BackingField`
- `private UInt16 <TotalDistance>k__BackingField`
- `private UInt16 <TotalKill>k__BackingField`
- `private Byte <TurnToProduce>k__BackingField`
- `private String <Type>k__BackingField`
- `private Byte <Visibility>k__BackingField`
- `private List`1 <Waypoints>k__BackingField`
- `private Int16 <XP>k__BackingField`

### Nested Types

- `private class <>c`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Unit), "PrivateMethodName", MethodType.Normal)]
class Patch_Unit_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Unit), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UnitCategories

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const UnitCategories AA`
- `public static const UnitCategories ARMOURED_TRAIN`
- `public static const UnitCategories ARTILLERY`
- `public static const UnitCategories AT`
- `public static const UnitCategories BATTLECRUISER`
- `public static const UnitCategories BATTLESHIP`
- `public static const UnitCategories BUILDING`
- `public static const UnitCategories CARRIER`
- `public static const UnitCategories CAVALRY`
- `public static const UnitCategories COMMANDER`
- `public static const UnitCategories DEFAULT`
- `public static const UnitCategories DESTROYER`
- `public static const UnitCategories DREADNOUGHT`
- `public static const UnitCategories ENGINEER`
- `public static const UnitCategories FIGHTER`
- `public static const UnitCategories GARRISON`
- `public static const UnitCategories GUNBOAT`
- `public static const UnitCategories HEAVY_BOMBER`
- `public static const UnitCategories HEAVY_CRUISER`
- `public static const UnitCategories INFANTRY`
- `public static const UnitCategories INFANTRY_AT`
- `public static const UnitCategories LIGHT_BOMBER`
- `public static const UnitCategories LIGHT_CRUISER`
- `public static const UnitCategories MARINE`
- `public static const UnitCategories MILITIA`
- `public static const UnitCategories PARATROOPER`
- `public static const UnitCategories PARTISAN`
- `public static const UnitCategories PROTO_AA`
- `public static const UnitCategories PROTO_ARTILLERY`
- `public static const UnitCategories PROTO_AT`
- `public static const UnitCategories PROTO_FIGHTER`
- `public static const UnitCategories PROTO_HEAVY_BOMBER`
- `public static const UnitCategories PROTO_INFANTRY`
- `public static const UnitCategories PROTO_LIGHT_BOMBER`
- `public static const UnitCategories PROTO_SHIP`
- `public static const UnitCategories PROTO_TANK`
- `public static const UnitCategories SHIP`
- `public static const UnitCategories SPECIAL_UNIT`
- `public static const UnitCategories SPG_AA`
- `public static const UnitCategories SPG_ARTY`
- `public static const UnitCategories SPG_AT`
- `public static const UnitCategories SUBMARINE`
- `public static const UnitCategories TANK`
- `public Byte value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UnitCategories), "PrivateMethodName", MethodType.Normal)]
class Patch_UnitCategories_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UnitCategories), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UnitEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void AddUnit()`
- `public Void CopyUnit()`
- `public Void CreateNewUnit()`
- `public Void ExportCSV()`
- `public Void GenerateUnitList(Boolean p_generateSlots)`
- `public Void ImportCSV()`
- `public Void PasteUnit()`
- `public Void RefreshCommanderTargets()`
- `public Void RefreshUnitGraphics()`
- `public Void RefreshUnitList(Boolean p_generateSlots)`
- `public Void RemoveUnit()`
- `public Void ResearchUnit()`
- `public Void ResetAllUnitsStats()`
- `public Void ResetUnitStats()`
- `public Void SaveAll()`
- `public Void SelectModToEdit()`
- `public Void SelectUnit(Unit p_unit, SimpleSlotUI p_simpleSlotUI = null)`
- `public Void SetAmphibious()`
- `public Void SetArmouredTrain()`
- `public Void SetArmourObstacle()`
- `public Void SetBuiltByEngineers()`
- `public Void SetCanAttackShips()`
- `public Void SetCanBeRefueldAtCarrier()`
- `public Void SetCanCarryAbomb()`
- `public Void SetCanCarryBombs()`
- `public Void SetCanCarryDropTank()`
- `public Void SetCanCarryRockets()`
- `public Void SetCanCarryTorpedo()`
- `public Void SetCanCatapultPlanes()`
- `public Void SetCarrier()`
- `public Void SetCatapultablePlane()`
- `public Void SetCavalry()`
- `public Void SetCoastalBattery()`
- `public Void SetCommanderTarget(String p_filterType)`
- `public Void SetConvoy()`
- `public Void SetDestroyer()`
- `public Void SetEndOfUseYear()`
- `public Void SetEngineers()`
- `public Void SetHasFlamethrower()`
- `public Void SetHasSonar()`
- `public Void SetImmuneToWinterDamage()`
- `public Void SetIsCommander()`
- `public Void SetIsParatrooper()`
- `public Void SetIsPartisans()`
- `public Void SetIsPrototype()`
- `public Void SetIsRADAR()`
- `public Void SetIsSubmarine()`
- `public Void SetIsSupplyDepot()`
- `public Void SetIsSupplyShip()`
- `public Void SetLaunchSite()`
- `public Void SetMine()`
- `public Void SetMineFlail()`
- `public Void SetMissile()`
- `public Void SetMoveOrAttack()`
- `public Void SetNoCapture()`
- `public Void SetNoLendLease()`
- `public Void SetPatrolBoat()`
- `public Void SetPermanentDeath()`
- `public Void SetPontoonBridge()`
- `public Void SetProductionMonth()`
- `public Void SetProductionYear()`
- `public Void SetRecon()`
- `public Void SetRemovedFromGame()`
- `public Void SetTileBuilding()`
- `public Void SetUnitAIPurchaseChanceOverride()`
- `public Void SetUnitAirAttack()`
- `public Void SetUnitAllowedFacingDirections()`
- `public Void SetUnitArmour()`
- `public Void SetUnitAttackSound()`
- `public Void SetUnitCost()`
- `public Void SetUnitCountry()`
- `public Void SetUnitCustomManpowerCost()`
- `public Void SetUnitCustomTurnProduction()`
- `public Void SetUnitFilterType()`
- `public Void SetUnitHardAttack()`
- `public Void SetUnitMaxAmmo()`
- `public Void SetUnitMaxFuel()`
- `public Void SetUnitMaxHP()`
- `public Void SetUnitMaxMP()`
- `public Void SetUnitMaxPurchaseTimes()`
- `public Void SetUnitMovementSound()`
- `public Void SetUnitName()`
- `public Void SetUnitProgressiveCost()`
- `public Void SetUnitRange()`
- `public Void SetUnitSoftAttack()`
- `public Void SetUnitType()`
- `public Void SetUnitVisibility()`
- `public Void SetUpkeepOverride()`
- `public Void ShowUnitStats()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void Awake()`
- `private Void Cancel()`
- `private Void CheckSelectedUnitChanges()`
- `private Void ConfirmRemoveUnit()`
- `private Void ConfirmResetAllUnitsStats()`
- `private Void ConfirmResetSelectedUnitStats()`
- `private static String Csv(String s)`
- `private Char DetectDelimiter(String p_headerLine)`
- `private static String E(Object v)`
- `private List`1 GetFilteredUnits(Int32& o_uniqueUnitsAmount)`
- `private Boolean IsBaseGameUnit(Unit p_unit)`
- `private Boolean IsCurrentUnitIdenticalToOfficialUnit()`
- `private Void OnDisable()`
- `private Void OnEnable()`
- `private Void ResetUIOnDisable()`
- `private Void SetupUIOnEnable()`
- `private Void Success(String[] p_values)`
- `private Void Update()`
- `private Boolean WasUnitAlreadyAdded(Unit p_unit, Unit& p_originalUnit)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button add_Button`
- `public TMP_InputField AIpurchaseChanceOverride_InputField`
- `public TMP_Dropdown allowedRotations_Dropdown`
- `public Image amphibious_Image`
- `public Image armourObstacle_Image`
- `public TMP_Dropdown attackSound_Dropdown`
- `public Image builtByEngineers_Image`
- `public Image canAttackShips_Image`
- `public Image canBeRefueledAtCarier_Image`
- `public Image canCarryAbomb_Image`
- `public Image canCarryBombs_Image`
- `public Image canCarryDropTank_Image`
- `public Image canCarryRockets_Image`
- `public Image canCarryTorpedo_Image`
- `public Image canCatapultPlanes_Image`
- `public Image coastalBattery_Image`
- `public List`1 commanderTargets_toggles`
- `public GameObject commanderTargetsContainer`
- `public Button copy_Button`
- `public Button delete_Button`
- `public Image engineers_Image`
- `public TMP_Dropdown filterCountry_Dropdown`
- `public TMP_Dropdown filterType_Dropwdown`
- `public Image hasFlamethrower_Image`
- `public Image hasSonar_Image`
- `public Image immuneToWinterDamage_Image`
- `public Image isArmouredTrain_Image`
- `public Image isCarrier_Image`
- `public Image isCatapultPlane`
- `public Image isCavalry_Image`
- `public Image isCommander_Image`
- `public Toggle isCommanderFilter_Toggle`
- `public Image isConvoy_Image`
- `public Image isDestroyer_Image`
- `public Image isLaunchSite_Image`
- `public Image isMineFlail_Image`
- `public Image isMissle_Image`
- `public Image isParatrooper_Image`
- `public Image isPartisans_Image`
- `public Image isPatrolBoat_Image`
- `public Image isPrototype_Image`
- `public Image isRadar_Image`
- `public Image isRecon_Image`
- `public Image isSubmarine_Image`
- `public Image isSupplyDepot_Image`
- `public Image isSupplyShip_Image`
- `public TMP_InputField maxPurchaseTimes_InputField`
- `public Image mine_Image`
- `public Toggle moddedUnitsOnly_Toggle`
- `public TMP_Dropdown mods_Dropdown`
- `public TMP_Dropdown movementSound_Dropdown`
- `public Image moveOrAttack_Image`
- `public Image noCapture_Image`
- `public Image noLendLease_Image`
- `public Transform parentForListOfUnits`
- `public Button paste_Button`
- `public Image permanentDeath_Image`
- `public Image pontoonBridge_Image`
- `public TMP_InputField progressiveCost_InputField`
- `public Image removedFromGame_Image`
- `public TMP_InputField research_InputField`
- `public Button reset_button`
- `public Button resetAll_button`
- `public GameObject selectedUnitBackground`
- `public Sprite tickedOption_Image`
- `public Image tileBuilding_Image`
- `public TextMeshProUGUI totalNumberOfUnits_Text`
- `public TMP_InputField unitAirDamage_InputField`
- `public TMP_InputField unitArmour_InputField`
- `public Image unitBackground_Image`
- `public TMP_InputField unitCost_InputField`
- `public TMP_Dropdown unitCountry_Dropdown`
- `public TMP_InputField unitEndOfUseYear_InputField`
- `public TMP_Dropdown unitFilterType_Dropdown`
- `public TMP_InputField unitHardDamage_InputField`
- `public TMP_InputField unitManpowerCost_InputField`
- `public TMP_InputField unitMaxAmmo_InputField`
- `public TMP_InputField unitMaxAutonomy_InputField`
- `public TMP_InputField unitMaxHP_InputField`
- `public TMP_InputField unitMaxMP_InputField`
- `public TMP_InputField unitName_InputField`
- `public TMP_InputField unitProductionMonth_InputField`
- `public TMP_InputField unitProductionYear_InputField`
- `public TMP_InputField unitRange_InputField`
- `public Image unitRepresentation_Image`
- `public SimpleSlotUI unitSlotPrefab`
- `public TMP_InputField unitSoftDamage_InputField`
- `public TMP_InputField unitTurnProduction_InputField`
- `public TMP_Dropdown unitType_Dropdown`
- `public TMP_InputField unitVisibility_InputField`
- `public Sprite untickedOption_Image`
- `public TMP_InputField upkeepOverride_InputField`
- `public GameObject vertical_scrollbar`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Unit _copiedUnit`
- `private List`1 _listOfAllAttackSounds`
- `private List`1 _listOfAllMovementSounds`
- `private List`1 _officialUnitsList`
- `private String _prevSelectedUnitCheckSum`
- `private String _researchUnitInput`
- `private Unit _selectedUnit`
- `private SimpleSlotUI _selectedUnitSlotUI`

### Nested Types

- `private class <>c`
- `private class <>c__DisplayClass116_0`
- `private class <>c__DisplayClass202_0`
- `private class <>c__DisplayClass205_0`
- `private class <>c__DisplayClass208_0`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UnitEditor), "PrivateMethodName", MethodType.Normal)]
class Patch_UnitEditor_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UnitEditor), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UnitGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Single ApplyCombinedArmsBonus(TileGO p_tileOfUnitBeingAttacked)`
- `public Single ApplyCommandersBonuses()`
- `public Single ApplyReconAttackBonus(TileGO p_targetTileGO)`
- `public Void AttackTile(TileGO p_tileGO)`
- `public Void AttackUnit(UnitGO p_unitGO, Boolean p_isRetaliationPossible, Boolean p_isSupportPossible, Boolean p_isAmbush)`
- `public Int32 CalculateEncirclement()`
- `public Void CalculateSupplyRoute(Boolean p_drawSupplyLine)`
- `public Boolean CanRetreat(UnitGO p_attackerUnitGO)`
- `public Boolean CanSwapUnits(UnitGO p_swapWithUnitGO)`
- `public Void DestroyUnit(Boolean p_playAnimation, Boolean p_sendRPC)`
- `public Void DisplayAmmoLoss(String p_value)`
- `public Void DisplayDamage(UnitGO attackingUnitGO, UnitGO attackedUnitGO)`
- `public Void DisplayFuelLoss(String p_value)`
- `public Void DisplayLevelUp()`
- `public Void DisplayXPGain(String p_value, Boolean p_sendRPC)`
- `public Void DiveUndiveSubmarine(Boolean p_sendRPC)`
- `public Void DropParatrooper(Boolean p_sendRPC)`
- `public Void EmbarkDisembarkBoat(Boolean p_sendRPC)`
- `public Void EmbarkDisembarkPlane()`
- `public Void EmbarkDisembarkTrain(Boolean p_sendRPC)`
- `public Void GetPathToTile(Tile p_targetTile, Boolean p_waypointPath = False, Boolean p_drawPath = False)`
- `public Single GetRetreatThreshold()`
- `public Boolean HasAvailableRailroadNearby()`
- `public Void LoadParatrooper(Boolean p_sendRPC)`
- `public Void ManageTwoUnitsIndicator()`
- `public Void ManageUnitInfoContainer()`
- `public Void MoveToWayPoint()`
- `public Void MoveUnitToTile(TileGO p_targetTileGO)`
- `public Void OpenStatsMenu()`
- `public Void RemoveFogOfWarAroundUnit()`
- `public Void ResupplyAlly(UnitGO p_supplyTargetUnitGO)`
- `public Void RotateAttackedUnit(UnitGO p_unitGOtoRotate, UnitGO p_refUnitGO)`
- `public Void RotateUnit(TileGO p_departureTileGO, TileGO p_arrivalTileGO)`
- `public Void SelectUnit(Boolean p_playAnimation)`
- `public Void SetSprite()`
- `public Void SetUnitRotation()`
- `public Void ShowPotentialPaths()`
- `public Void ShowPotentialTargets()`
- `public Void ShowSelectedUnitStats()`
- `public Void SwapUnits(UnitGO p_swapWithUnitGO)`
- `public Boolean TryCaptureTile(Tile p_tile, Boolean p_sendRPC)`
- `public Void UpdateCounter()`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void AssignUnitToTile(TileGO p_tileGO)`
- `private Void Attack(UnitGO p_targetUnitGO)`
- `private Single CalculateSupplyEncirclement()`
- `private Void CheckAAattackDroppedParatroopers()`
- `private Void CheckAchievements()`
- `private Void CheckEventTrigger()`
- `private Boolean CheckForAmbush(TileGO p_tileAboutToEnterGO, TileGO p_targetMoveTileGO, Boolean p_weakToObstacles)`
- `private Void CheckForDefenseSupport(UnitGO p_attackingUnitGO)`
- `private Void CheckPlaneFuel()`
- `private IEnumerator CR_Ambush(UnitGO p_unitGOambushing)`
- `private IEnumerator CR_MoveUnitToAllTilesOfItsPath(TileGO p_targetTileGO)`
- `private IEnumerator CR_SupportAttackedUnit(UnitGO p_targetUnitGO)`
- `private Void DelayOverrunWindow()`
- `private IEnumerator DoMoveAnimation()`
- `private Void DrawSupplyLine()`
- `private Void OnMouseExit()`
- `private Void OnMouseOver()`
- `private Void Overrun()`
- `private Void Retaliate(UnitGO p_attackerUnitGO, Single p_distance)`
- `private Void Retreat(UnitGO p_attackerUnitGO)`
- `private Void SetUnitMovementSpeed()`
- `private Void ShowMovementPath(List`1 p_tileGOs)`
- `private Void ShowPotentialDamage()`
- `private Void ShowRangedRadius()`
- `private Void Surrender(UnitGO p_toUnitGO)`
- `private Void UpdateCounterValues()`
- `private Void UpdateMorale()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject ABomb_GO`
- `public List`1 AIpathToVP`
- `public TextMeshPro airAttack`
- `public SpriteRenderer ammo_Sprite`
- `public GameObject anchor_GO`
- `public SpriteRenderer backgroundSprite`
- `public Byte backupEntrenchmentLevel`
- `public Boolean backupHasAttacked`
- `public Byte backupHowManyTimesTilesTheUnitMoved`
- `public Int16 backupHowManyTimesUnitMoved`
- `public GameObject bomb_GO`
- `public SpriteRenderer canAttack_Sprite`
- `public SpriteRenderer canMove_Sprite`
- `public Boolean canOverrun`
- `public Boolean canUndo`
- `public List`1 currentPath`
- `public GameObject dropTank_GO`
- `public GameObject elite_GO`
- `public SpriteRenderer fuel_Sprite`
- `public TileGO goal`
- `public TextMeshPro hardAttack`
- `public GameObject horse_GO`
- `public TextMeshPro HP_TextMesh`
- `public Int32 HPsavedForRetaliation`
- `public Boolean isMoving`
- `public Boolean isRetreating`
- `public List`1 listOfNewlyDiscoveredTiles`
- `public List`1 listOfpotentialTiles`
- `public GameObject mechanized_GO`
- `public Byte moraleBackupRetaliation`
- `public GameObject motorized_GO`
- `public GameObject mountaineer_GO`
- `public TextMeshPro movementPoint`
- `public TextMeshPro number_textMesh`
- `public SpriteRenderer political_Sprite`
- `public Int16 prevAutonomy`
- `public Int32 prevHP`
- `public Byte prevMP`
- `public TileGO prevTile`
- `public TextMeshPro range`
- `public GameObject Recon_GO`
- `public GameObject rocket_GO`
- `public GameObject seaplane_GO`
- `public Boolean showMine`
- `public TextMeshPro softAttack`
- `public Single spawnTime`
- `public GameObject subContainer_GO`
- `public List`1 supplyLine`
- `public UnitGO targetedUnitGO`
- `public TileGO tileGO`
- `public GameObject torpedo_GO`
- `public GameObject twoUnitsIndicatorGO`
- `public Unit unit`
- `public GameObject unitInfoContainer`
- `public SpriteRenderer unitSprite`
- `public GameObject winter_GO`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Byte _ammoIconColor`
- `private Boolean _captured`
- `private Boolean _convoyArrived`
- `private Boolean _counterValuesShown`
- `private Byte _fuelIconColor`
- `private Vector3 _heroIconNATOoff_position`
- `private Vector3 _heroIconNATOon_position`
- `private Boolean _hidingHP`
- `private Single _HPperc`
- `private Boolean _isAmmoUIshown`
- `private Boolean _isCanAttackUIShown`
- `private Boolean _isCanMoveUIShown`
- `private Boolean _isFuelUIshown`
- `private Boolean _isSubcontainerUIshown`
- `private Single _journeyLength`
- `private SpriteRenderer _levelIcon_spriteRenderer`
- `private Boolean _missileArrived`
- `private Boolean _moraleUIShown`
- `private Sprite _noCoreIcon_sprite`
- `private Double _prevAirAttackTextValue`
- `private Boolean _prevCoreValue`
- `private Double _prevHardAttackTextValue`
- `private Int32 _prevHPtextValue`
- `private Int32 _prevMPtextValue`
- `private Int32 _prevRangeTextValue`
- `private Double _prevSoftAttackTextValue`
- `private Int32 _prevSuffixTextValue`
- `private Int16 _prevUnitLevel`
- `private Sprite _roundCoreIcon_sprite`
- `private Single _speed`
- `private Sprite _squareCoreIcon_sprite`
- `private Boolean _surrendered`
- `private Boolean _textObjectsShown`
- `private Boolean _twoUnitsIndicatorShown`
- `private Transform attackerTransform`
- `private SpriteRenderer coreUnitOutline_sprite`
- `private Transform defenserTransform`
- `private Vector3 endPos`
- `private SpriteRenderer heroIcon_Sprite`
- `private GameObject levelIconGO`
- `private SpriteRenderer morale_GO`
- `private Boolean overrunning`
- `private Vector3 startPos`
- `private Single startTime`
- `private TileGO tileToOverrun`
- `private SpriteRenderer twoUnitsIndicator_spriteRenderer`

### Nested Types

- `private class <>c`
- `private class <CR_Ambush>d__121`
- `private class <CR_MoveUnitToAllTilesOfItsPath>d__115`
- `private class <CR_SupportAttackedUnit>d__127`
- `private class <DoMoveAnimation>d__118`
- `private class SupplyRouteData`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UnitGO), "PrivateMethodName", MethodType.Normal)]
class Patch_UnitGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UnitGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UnitModification

### Public Methods

- `public UnitModification Add(String propName, Double amount, Func`2 predicate = null)`
- `public Void Apply(Unit u)`
- `public UnitModification MultiplyAdd(String targetProp, String baseProp, Double factor, Func`2 predicate = null)`
- `public Void Revert(Unit u)`
- `public UnitModification Set(String propName, Object value, Func`2 predicate = null)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private readonly List`1 _ops`

### Nested Types

- `private class AddOp`
- `private class IOperation`
- `private class MultiplyAddOp`
- `private class OperationBase`
- `private class SetOp`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UnitModification), "PrivateMethodName", MethodType.Normal)]
class Patch_UnitModification_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UnitModification), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UnitsFilterHelper

**Modifiers:** `static`

### Public Methods

- `public static List`1 Filter(IEnumerable`1 source, String filterString)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private static Boolean Compare(Object leftObj, String op, String rawRight, Type t)`
- `private static Boolean Eval(T item, Condition cond, Dictionary`2 props)`
- `private static Boolean IsNumeric(Type t)`
- `private static Condition ParseCondition(String raw)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Nested Types

- `private class <>c__2`1`
- `private class Condition`
- `private class LogicOp`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UnitsFilterHelper), "PrivateMethodName", MethodType.Normal)]
class Patch_UnitsFilterHelper_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UnitsFilterHelper), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UnitSlotStoreGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void OnDestroy()`
- `private Void OnDisable()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public GameObject messagePopupPrefab`
- `public UnitStoreSlotGO unitStoreSlotGO`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private GameObject _deploymentTooltip`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UnitSlotStoreGO), "PrivateMethodName", MethodType.Normal)]
class Patch_UnitSlotStoreGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UnitSlotStoreGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UnitStatsPanelUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Open(UnitGO p_unitGO)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private TextMeshProUGUI _AAKills_text`
- `private TextMeshProUGUI _ArtilleryKills_text`
- `private TextMeshProUGUI _ATKills_text`
- `private TextMeshProUGUI _fighterKills_text`
- `private Image _flagImage`
- `private TextMeshProUGUI _heavyBombersKills_text`
- `private Image _hero_image`
- `private TextMeshProUGUI _heroName_text`
- `private Transform _history_parent`
- `private TextMeshProUGUI _historyElement_prefab`
- `private TextMeshProUGUI _infantryKills_text`
- `private TextMeshProUGUI _level_text`
- `private TextMeshProUGUI _lightBombersKills_text`
- `private TextMeshProUGUI _shipKills_text`
- `private TextMeshProUGUI _tankKills_text`
- `private TextMeshProUGUI _unitName_text`
- `private TextMeshProUGUI _XP_text`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UnitStatsPanelUI), "PrivateMethodName", MethodType.Normal)]
class Patch_UnitStatsPanelUI_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UnitStatsPanelUI), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## UnitStoreSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void RefreshMaxPurchase(Boolean p_isUpgradeMode)`
- `public Void RefreshValues()`
- `public Void ResetOptions()`
- `public Void SetUpSlot(Boolean p_isUpgradeMode)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Boolean IsRocketAvailable()`
- `private Void SetUpUpgradeSlot()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public Button atomBomb_button`
- `public Image background_image`
- `public Button bomb_button`
- `public Button buy_button`
- `public Button buyManpower_button`
- `public GameObject carrier_option`
- `public Image cost_image`
- `public Image costManpower_image`
- `public GameObject droppable_option`
- `public Button dropTank_button`
- `public Button elite_button`
- `public GameObject flamethrower_option`
- `public Button horse_button`
- `public Image HQcost_image`
- `public Image HQcostManpower_image`
- `public Button ideologicalUnit_button`
- `public Image limitReached_image`
- `public TextMeshProUGUI manpowerCost_text`
- `public Button mechanize_button`
- `public Button mountaineer_button`
- `public GameObject navalAircraft_option`
- `public GameObject permanentDeath_option`
- `public TextMeshProUGUI price_text`
- `public TextMeshProUGUI priceManpower_text`
- `public GameObject prototype_option`
- `public GameObject radar_option`
- `public GameObject recon_option`
- `public Image representation_image`
- `public Button rocket_button`
- `public GameObject seaplane_option`
- `public Button slot_button`
- `public GameObject sonar_option`
- `public Image tooExpensive_image`
- `public Button torpedo_button`
- `public Button truck_button`
- `public Unit unit`
- `public TextMeshProUGUI unitName_text`
- `public TextMeshProUGUI unitPurchaseLimit_text`
- `public TextMeshProUGUI unitPurchaseLimitAmount_text`
- `public Button winter_button`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(UnitStoreSlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_UnitStoreSlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(UnitStoreSlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## Utils

### Public Methods

- `public static Void AssignGeographicalAreas()`
- `public static Object BlobToObject(Byte[] p_bytes)`
- `public static Void ClearChildrenWith(Transform p_parent, Boolean p_includeInactive = False)`
- `public static Byte[] Compress(Byte[] p_bytes)`
- `public static UInt32 ComputeKeyID32(String p_key)`
- `public static UInt64 ComputeKeyID64(String p_key)`
- `public static Object ConvertByteArrayToObject(Byte[] p_bytes)`
- `public static Byte[] ConvertObjectToByteArray(Object p_object)`
- `public static Byte[] Decompress(Byte[] p_bytes)`
- `public static String FormatReceivedTotal(Int64 p_receivedBytes, Int64 p_totalBytes, Boolean p_includePercent = True)`
- `public static String FormatReceivedTotalBoth(Int64 p_receivedBytes, Int64 p_totalBytes)`
- `public static Unit GenerateNewUnit(String p_unitName, String p_unitCountry)`
- `public static List`1 GetAllHeroes()`
- `public static List`1 GetAllTiles()`
- `public static List`1 GetAllTilesInRadiusAround(Tile p_centerTile, Int32 p_radius)`
- `public static Void GetAllTilesNeighbours()`
- `public static List`1 GetAllUnits(Boolean p_includeRemovedUnits = False)`
- `public static AudioType GetAudioType(String p_extension)`
- `public static Double GetDirectorySize(String p_directoryPath)`
- `public static String GetFileNameWithoutExtension(FileInfo p_fileInfo)`
- `public static Sprite GetFlagSprite(Player p_player)`
- `public static Sprite GetFlagSprite(String p_country)`
- `public static Sprite GetHeroIconSprite(Unit p_unit)`
- `public static Int32 GetHeuristicDistance(Tile p_tileA, Tile p_tileB)`
- `public static Int32 GetIndexByLocalizedName(String p_value, List`1 p_values)`
- `public static Int32 GetIndexByName(Dropdown p_dropDown, String p_name)`
- `public static Int32 GetIndexByName(TMP_Dropdown p_dropDown, String p_name)`
- `public static String GetManpowerForUI(Int32 p_manpowerValue)`
- `public static Int32 GetMaxCoreUnitsNumber(Player p_player)`
- `public static Sprite GetModdedHeroSprite(Hero p_hero)`
- `public static List`1 GetModdedUnits()`
- `public static Int32 GetMonthDifference(DateTime p_unitDate, DateTime p_currentDate, Boolean p_absoluteValue = False)`
- `public static FileInfo GetMostRecentSaveFile()`
- `public static Tile GetOriginalTile(Tile p_tileInstance)`
- `public static Sprite GetPoliticalSprite(Unit p_unit)`
- `public static Int32 GetRandomNumber(Byte p_numberOfSides)`
- `public static String GetSizeInMB(Byte[] p_byteArray)`
- `public static Sprite GetTileSprite(Tile p_tile)`
- `public static Sprite GetUnitBackground(Unit p_unit, String p_notOriginalCountry)`
- `public static Sprite GetUnitSprite(Unit p_unit)`
- `public static Boolean HasNKVDAround(Tile p_tile, Unit p_unit)`
- `public static Boolean IsMasterClient()`
- `public static Boolean IsPointerOverUIObject()`
- `public static Boolean IsRealtimeMultiplayer()`
- `public static Boolean IsTileInsideRadius(Tile p_tileCheck, Tile p_sourceTile, Int32 p_radius)`
- `public static Boolean IsTileInsideRadiusSimplified(Tile p_sourceTile, Tile p_tileCheck, Int32 p_radius)`
- `public static Boolean IsUnitRegistered(Unit p_unit, Boolean p_officialOnly = False)`
- `public static Void MakeScreenshot()`
- `public static Byte[] ObjectToBlob(Object p_object)`
- `public static Void PatchUnit(Unit p_unit)`
- `public static Void PatchUnits(List`1 p_units)`
- `public static Int32 RoundUp(Int32 p_number)`
- `public static Void SetAutoCoasts(Tile p_tile)`
- `public static String ShowStopWatch()`
- `public static Void StartStopWatch()`
- `public static Single Truncate(Single p_value, Int32 p_digits)`
- `public static Void UpdateTileProperties(Tile p_targetTile, Tile p_sourceTile, Boolean p_nonDestructive)`
- `public static Void UpdateTilesData(Boolean p_nonDestructive)`
- `public static Void UpdateUnitStatsOnTurnOne(Unit p_unit, List`1 p_unitsDatabase)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private static ValueTuple`2 ConvertToAxial(Tile p_tile)`
- `private static Void FloodFill(Tile p_startTile, Int16 p_index, FloodFillTypes p_floodFillType)`
- `private static Boolean IsFairRoll(Byte p_roll, Byte p_numSides)`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const Double KB`
- `public static const Double MB`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private static RNGCryptoServiceProvider RNGcsp`
- `private static Stopwatch stopwatch`

### Nested Types

- `private class <>c`
- `private class FloodFillTypes`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(Utils), "PrivateMethodName", MethodType.Normal)]
class Patch_Utils_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(Utils), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## WeatherPredictionData

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public WeatherType actualWeather`
- `public DateTime date`
- `public WeatherType predictedWeather`
- `public Single predictionAccuracy`
- `public Int32 turnNumber`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(WeatherPredictionData), "PrivateMethodName", MethodType.Normal)]
class Patch_WeatherPredictionData_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(WeatherPredictionData), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## WeatherSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void Setup(WeatherPredictionData p_weatherPredictionData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Image _image`
- `private TextMeshProUGUI _predictionAccuracy_text`
- `private TextMeshProUGUI _turnCount_text`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(WeatherSlotGO), "PrivateMethodName", MethodType.Normal)]
class Patch_WeatherSlotGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(WeatherSlotGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## WeatherTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `public Void OnPointerEnter(PointerEventData eventData)`
- `public Void OnPointerExit(PointerEventData eventData)`

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private Void OnDisable()`
- `private Void Start()`
- `private Void Update()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private RectTransform _canvas_RectTransform`
- `private Transform _parentForSlots`
- `private GameObject _tooltip`
- `private WeatherSlotGO _weatherSlot_prefab`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(WeatherTooltipGO), "PrivateMethodName", MethodType.Normal)]
class Patch_WeatherTooltipGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(WeatherTooltipGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## WeatherType

**Base Class:** `System.Enum`

**Modifiers:** `sealed`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

*No private methods*

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

- `public static const WeatherType BAD`
- `public static const WeatherType CLEAR`
- `public Int32 value__`

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

*No private fields*

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(WeatherType), "PrivateMethodName", MethodType.Normal)]
class Patch_WeatherType_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(WeatherType), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


## XPanimationGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Private Methods

*These methods can be patched using Harmony's AccessTools*

- `private IEnumerator CR_FadeAlpha()`
- `private Void Start()`

### Public Properties

*No public properties*

### Private Properties

*These properties can be accessed using Harmony's Traverse or AccessTools*

*No private properties*

### Public Fields

*No public fields*

### Private Fields

*These fields can be accessed using Harmony's Traverse or AccessTools*

- `private Single delay`
- `private Single fadeTime`
- `private SpriteRenderer[] spriteRenderers`
- `private TextMeshPro[] texts`

### Nested Types

- `private class <CR_FadeAlpha>d__5`

### Harmony Usage Examples

```csharp
// Patching a private method:
[HarmonyPatch(typeof(XPanimationGO), "PrivateMethodName", MethodType.Normal)]
class Patch_XPanimationGO_PrivateMethod { }

// Accessing a private field:
var instance = GetInstanceSomehow();
var privateField = Traverse.Create(instance).Field("privateFieldName").GetValue<Type>();

// Or using AccessTools:
var fieldInfo = AccessTools.Field(typeof(XPanimationGO), "privateFieldName");
var value = fieldInfo.GetValue(instance);
```

---


---

## End of Complete API Reference

*This documentation includes ALL classes and members (public and private)*

*Generated using APIExplorerComplete with Harmony reflection support*
