# Hex Of Steel - Complete API Reference

*Generated on: 2025-10-07 08:08:48*

This document contains a comprehensive reference of all public classes, methods, properties, and fields available in Hex Of Steel's modding API.

---

## Table of Contents

1. [AchievementElementUI](#achievementelementui)
2. [AchievementsUI](#achievementsui)
3. [ActionTypes](#actiontypes)
4. [AI](#ai)
5. [AirHeroes](#airheroes)
6. [AIWaitInstruction](#aiwaitinstruction)
7. [AllowedRotations](#allowedrotations)
8. [AsleepStates](#asleepstates)
9. [CameraGO](#camerago)
10. [CampaignMenu](#campaignmenu)
11. [CanvasRescaler](#canvasrescaler)
12. [ChartAndGraph.SelectScene](#chartandgraphselectscene)
13. [ChatMessageData](#chatmessagedata)
14. [CheckTypes](#checktypes)
15. [ClickableMessage](#clickablemessage)
16. [Cloud](#cloud)
17. [CloudManager](#cloudmanager)
18. [ConfirmationWindowGO](#confirmationwindowgo)
19. [ConnectedPlayerSlotGO](#connectedplayerslotgo)
20. [Coordinates](#coordinates)
21. [CountryEditor](#countryeditor)
22. [CustomCountries](#customcountries)
23. [CustomTiles](#customtiles)
24. [CustomUnits](#customunits)
25. [DamageTextGO](#damagetextgo)
26. [DamageTypes](#damagetypes)
27. [Database](#database)
28. [DataMigrator](#datamigrator)
29. [DentedPixel.LeanDummy](#dentedpixelleandummy)
30. [DeploySlotGO](#deployslotgo)
31. [DiplomacyGO](#diplomacygo)
32. [DiplomacySlotGO](#diplomacyslotgo)
33. [DiplomacyTooltipGO](#diplomacytooltipgo)
34. [DrawingManager](#drawingmanager)
35. [EndGameResults](#endgameresults)
36. [Event](#event)
37. [EventAction](#eventaction)
38. [EventActionSlotGO](#eventactionslotgo)
39. [EventData](#eventdata)
40. [EventListSlotGO](#eventlistslotgo)
41. [EventPanelGO](#eventpanelgo)
42. [Explosion](#explosion)
43. [FacingRotations](#facingrotations)
44. [FadeTileGO](#fadetilego)
45. [FCP_Persistence](#fcp_persistence)
46. [FCP_SpriteMeshEditor](#fcp_spritemesheditor)
47. [FlexibleColorPicker](#flexiblecolorpicker)
48. [ForecastType](#forecasttype)
49. [Game](#game)
50. [GameData](#gamedata)
51. [GameLanguages](#gamelanguages)
52. [GameModification](#gamemodification)
53. [GameResponse](#gameresponse)
54. [GameSettings](#gamesettings)
55. [GameStates](#gamestates)
56. [GraphPanelGO](#graphpanelgo)
57. [GroundHeroes](#groundheroes)
58. [Hero](#hero)
59. [HeroBonusesGO](#herobonusesgo)
60. [HeroesEditor](#heroeseditor)
61. [HoverUnitUI](#hoverunitui)
62. [IntegerInputfield](#integerinputfield)
63. [InvalidIronManReasons](#invalidironmanreasons)
64. [IronmanTooltip](#ironmantooltip)
65. [LanguageSlotUI](#languageslotui)
66. [LastTurnSummaryData](#lastturnsummarydata)
67. [LastTurnSummaryUI](#lastturnsummaryui)
68. [LeaderboardActions](#leaderboardactions)
69. [LeaderboardEntryUI](#leaderboardentryui)
70. [LeaderboardGO](#leaderboardgo)
71. [LeanAudio](#leanaudio)
72. [LeanAudioOptions](#leanaudiooptions)
73. [LeanAudioStream](#leanaudiostream)
74. [LeanProp](#leanprop)
75. [LeanSmooth](#leansmooth)
76. [LeanTest](#leantest)
77. [LeanTester](#leantester)
78. [LeanTween](#leantween)
79. [LeanTweenExt](#leantweenext)
80. [LeanTweenType](#leantweentype)
81. [Line](#line)
82. [LineData](#linedata)
83. [LoadingWheel](#loadingwheel)
84. [LoadMenu](#loadmenu)
85. [Locale_Base](#locale_base)
86. [Locale_BR](#locale_br)
87. [Locale_CA](#locale_ca)
88. [Locale_CNS](#locale_cns)
89. [Locale_CNT](#locale_cnt)
90. [Locale_CZ](#locale_cz)
91. [Locale_DE](#locale_de)
92. [Locale_EN](#locale_en)
93. [Locale_ES](#locale_es)
94. [Locale_FI](#locale_fi)
95. [Locale_FR](#locale_fr)
96. [Locale_GR](#locale_gr)
97. [Locale_IT](#locale_it)
98. [Locale_JP](#locale_jp)
99. [Locale_KR](#locale_kr)
100. [Locale_NL](#locale_nl)
101. [Locale_NO](#locale_no)
102. [Locale_PL](#locale_pl)
103. [Locale_PT](#locale_pt)
104. [Locale_RU](#locale_ru)
105. [Locale_SE](#locale_se)
106. [Locale_TR](#locale_tr)
107. [Locale_UA](#locale_ua)
108. [LocalizationManager](#localizationmanager)
109. [LocalizationUI](#localizationui)
110. [LocalizedText](#localizedtext)
111. [LTBezier](#ltbezier)
112. [LTBezierPath](#ltbezierpath)
113. [LTDescr](#ltdescr)
114. [LTDescrOptional](#ltdescroptional)
115. [LTEvent](#ltevent)
116. [LTGUI](#ltgui)
117. [LTRect](#ltrect)
118. [LTSeq](#ltseq)
119. [LTSpline](#ltspline)
120. [LTUtility](#ltutility)
121. [MainMenu](#mainmenu)
122. [ManpowerTooltipGO](#manpowertooltipgo)
123. [Map](#map)
124. [MapEditorGO](#mapeditorgo)
125. [MapEditorMenu](#mapeditormenu)
126. [MapGeneratorGO](#mapgeneratorgo)
127. [MapGO](#mapgo)
128. [MapOverlayManager](#mapoverlaymanager)
129. [MessageBoxGO](#messageboxgo)
130. [Mod](#mod)
131. [ModBase](#modbase)
132. [ModdedHeroes](#moddedheroes)
133. [ModifiedBaseTiles](#modifiedbasetiles)
134. [ModifiedBaseUnits](#modifiedbaseunits)
135. [ModManifest](#modmanifest)
136. [ModPanelGO](#modpanelgo)
137. [ModPropertyBag](#modpropertybag)
138. [ModSlotGO](#modslotgo)
139. [ModsManager](#modsmanager)
140. [MoneyTooltipGO](#moneytooltipgo)
141. [MoraleStates](#moralestates)
142. [MultiplayerChat](#multiplayerchat)
143. [MultiplayerManager](#multiplayermanager)
144. [MultiplayerMenu](#multiplayermenu)
145. [NavalHeroes](#navalheroes)
146. [NewMinimap](#newminimap)
147. [Notification](#notification)
148. [NotificationButtonGO](#notificationbuttongo)
149. [NotificationManager](#notificationmanager)
150. [NotificationTypes](#notificationtypes)
151. [OfficialTiles](#officialtiles)
152. [OfficialTilesORIGINAL](#officialtilesoriginal)
153. [OfficialUnits](#officialunits)
154. [OfficialUnitsORIGINAL](#officialunitsoriginal)
155. [OnlineGame](#onlinegame)
156. [OnlineUser](#onlineuser)
157. [OOBSlot](#oobslot)
158. [OrderOfBattleGO](#orderofbattlego)
159. [OwnerPanelEditorGO](#ownerpaneleditorgo)
160. [PaintMode](#paintmode)
161. [PasswordInputfieldUI](#passwordinputfieldui)
162. [Player](#player)
163. [PlayerSettings](#playersettings)
164. [PlayerSlotMapEditor](#playerslotmapeditor)
165. [Policies](#policies)
166. [PoliciesGO](#policiesgo)
167. [Policy](#policy)
168. [PolicySlotGO](#policyslotgo)
169. [PolicyTooltipGO](#policytooltipgo)
170. [PoliticalArea](#politicalarea)
171. [PoliticalHexRenderer](#politicalhexrenderer)
172. [PriorityQueue`1](#priorityqueue`1)
173. [ResearchMenu](#researchmenu)
174. [ResearchUnitSlot](#researchunitslot)
175. [ReservePanelGO](#reservepanelgo)
176. [Response](#response)
177. [ResupplyCostGO](#resupplycostgo)
178. [SaveMenu](#savemenu)
179. [SceneTranslator](#scenetranslator)
180. [SelectedUnitExtraStatsUI](#selectedunitextrastatsui)
181. [SelectedUnitUI](#selectedunitui)
182. [SettingsMenu](#settingsmenu)
183. [SimpleSlotUI](#simpleslotui)
184. [SoundManager](#soundmanager)
185. [StandaloneScenariosMenu](#standalonescenariosmenu)
186. [Statistic](#statistic)
187. [SteamLeaderboard](#steamleaderboard)
188. [SteamLeaderboardEntry](#steamleaderboardentry)
189. [SteamManager](#steammanager)
190. [SteamStatuses](#steamstatuses)
191. [SteamWorkshopMenu](#steamworkshopmenu)
192. [StoreGO](#storego)
193. [TargetGO](#targetgo)
194. [TechTreeTooltipGO](#techtreetooltipgo)
195. [testMarker](#testmarker)
196. [Tile](#tile)
197. [TileEditor](#tileeditor)
198. [TileEditorGO](#tileeditorgo)
199. [TileGO](#tilego)
200. [TileSeason](#tileseason)
201. [TilesManagerGO](#tilesmanagergo)
202. [TileTransferSlotGO](#tiletransferslotgo)
203. [TileTypes](#tiletypes)
204. [TooltipFlagGO](#tooltipflaggo)
205. [TooltipGO](#tooltipgo)
206. [TurnManager](#turnmanager)
207. [TutorialActions](#tutorialactions)
208. [TutorialManager](#tutorialmanager)
209. [TutorialPage](#tutorialpage)
210. [TutorialStepData](#tutorialstepdata)
211. [TutorialTask](#tutorialtask)
212. [TutorialTaskUI](#tutorialtaskui)
213. [TutorialWindow](#tutorialwindow)
214. [TweenAction](#tweenaction)
215. [UIManager](#uimanager)
216. [UIWindowController](#uiwindowcontroller)
217. [Unit](#unit)
218. [UnitCategories](#unitcategories)
219. [UnitEditor](#uniteditor)
220. [UnitGO](#unitgo)
221. [UnitModification](#unitmodification)
222. [UnitsFilterHelper](#unitsfilterhelper)
223. [UnitSlotStoreGO](#unitslotstorego)
224. [UnitStatsPanelUI](#unitstatspanelui)
225. [UnitStoreSlotGO](#unitstoreslotgo)
226. [Utils](#utils)
227. [WeatherPredictionData](#weatherpredictiondata)
228. [WeatherSlotGO](#weatherslotgo)
229. [WeatherTooltipGO](#weathertooltipgo)
230. [WeatherType](#weathertype)
231. [XPanimationGO](#xpanimationgo)

---


## AchievementElementUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Setup(Boolean p_unlocked, String p_name, String p_description)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## AchievementsUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void CloseMenu()`
- `Void OpenMenu()`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## ActionTypes

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static ActionTypes ADD_FIXED_INCOME`
- `static ActionTypes ADD_HQ_POINTS`
- `static ActionTypes ADD_MONEY`
- `static ActionTypes ADD_PLAYER`
- `static ActionTypes ADD_UNIT_RESERVE`
- `static ActionTypes ADD_VP`
- `static ActionTypes CAPITULATION`
- `static ActionTypes CHANGE_VP_OWNERSHIP`
- `static ActionTypes COUNTRY_CHANGE`
- `static ActionTypes DECLARE_WAR`
- `static ActionTypes DESTROY_TILE`
- `static ActionTypes FACTION_CHANGE`
- `static ActionTypes MAKE_ALLIANCE`
- `static ActionTypes MAKE_PEACE`
- `static ActionTypes MAKE_PEACE_FACTION`
- `static ActionTypes NONE`
- `static ActionTypes REMOVE_PLAYER`
- `static ActionTypes REMOVE_VP`
- `static ActionTypes RESET_INCOME`
- `static ActionTypes SET_FIXED_INCOME`
- `static ActionTypes SET_FIXED_INCOME_FROM_BASE_INCOME_PERCENT`
- `static ActionTypes SET_FIXED_INCOME_PERCENT`
- `static ActionTypes SET_TILE`
- `static ActionTypes SET_TILE_NAME`
- `static ActionTypes SHOW_MESSAGE`
- `static ActionTypes SPAWN_UNIT`
- `Int32 value__`

---


## AI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Boolean IsEuropeWithHistoricalFocus()`
- `Void PlayerControlAboutToChange(Player p_player)`

### Public Properties

*No public properties*

### Public Fields

- `GameObject AIplayingPanel`
- `static Queue`1 AIWaitInstructions`
- `static AI instance`
- `static Boolean isPlaying`
- `Slider loadingBar`
- `Boolean needToRefreshEnemyVPs`
- `static Player playerNeedsToRedeployItsUnitsNow`
- `Boolean startTurn`
- `Boolean supplyDepotNeeded`

---


## AirHeroes

### Public Methods

- `static List`1 GetHeroes(String p_country)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## AIWaitInstruction

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Single waitTime`

---


## AllowedRotations

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static AllowedRotations ALL`
- `static AllowedRotations LEFT_RIGHT`
- `static AllowedRotations NONE`
- `static AllowedRotations NOT_SETUP`
- `Byte value__`

---


## AsleepStates

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static AsleepStates NONE`
- `static AsleepStates SKIP`
- `static AsleepStates SLEEP`
- `Byte value__`

---


## CameraGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Boolean IsWithinFOV(Vector3 p_worldPoint)`
- `Void MoveCameraToPosition(Vector3 p_targetPosition)`

### Public Properties

*No public properties*

### Public Fields

- `Camera cam`
- `static CameraGO instance`
- `Single limitXMINUS`
- `Single limitXPLUS`
- `Single limitYMINUS`
- `Single limitYPLUS`
- `Int32 maxZoom`
- `Int32 minZoom`
- `Single targetZoom`
- `Single zoomFactor`
- `Single zoomLerpSpeed`

---


## CampaignMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void CloseCampaignPanel()`
- `Void SelectCountry_Toggle(String p_country)`
- `Void SelectDate_Toggle(String p_date)`
- `Void SelectFront_Toggle(String p_front)`
- `Void StartNewCampaign()`

### Public Properties

*No public properties*

### Public Fields

- `GameObject achievement`
- `Toggle[] countries_Toggles`
- `Toggle[] dates_Toggles`
- `Toggle[] fronts_Toggles`
- `static Boolean isNewCampaign`
- `Image map_Image`
- `GameObject NOironman`
- `TextMeshProUGUI scenarioName_Text`
- `String selectedCountry`
- `String selectedDate`
- `String selectedFront`
- `GameObject startCampaignButton`
- `GameObject YESironman`

---


## CanvasRescaler

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void RescaleCanvases()`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## ChartAndGraph.SelectScene

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Select(String scene)`
- `Void SelectMain()`

### Public Properties

*No public properties*

### Public Fields

- `Canvas BackCanvas`
- `Button ButtonPrefab`
- `GameObject EventSystem`
- `GameObject MainCamera`
- `Canvas MainCanvas`

---


## ChatMessageData

### Public Methods

- `String GenerateMessageContentForUIDisplay()`

### Public Properties

*No public properties*

### Public Fields

- `String content`
- `String hardwareID`
- `String senderNickname`
- `String timeSent`

---


## CheckTypes

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static CheckTypes ALLIANCE_MADE`
- `static CheckTypes DATE`
- `static CheckTypes NONE`
- `static CheckTypes TURN_COUNT`
- `static CheckTypes UNIT_DESTROYED`
- `Int32 value__`
- `static CheckTypes VP_LOSS`
- `static CheckTypes VPS_LOSSES`
- `static CheckTypes VPS_LOSSES_ONE_OF`
- `static CheckTypes WAR_DECLARATION`

---


## ClickableMessage

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerClick(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Cloud

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ProcessUpdate(Single p_opacity)`
- `Void Setup()`

### Public Properties

*No public properties*

### Public Fields

- `Int32 cloudScale`
- `Single cloudSpeedMax`
- `Single cloudSpeedMin`

---


## CloudManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void DeregisterCloud(Cloud p_cloud)`
- `Void RegisterCloud(Cloud p_cloud)`

### Public Properties

*No public properties*

### Public Fields

- `static CloudManager instance`
- `Int32 timeMaxBetweenSpawn`
- `Int32 timeMinBetweenSpawn`

---


## ConfirmationWindowGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `TextMeshProUGUI description_text`
- `Button no_button`
- `Button yes_button`

---


## ConnectedPlayerSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AddFriend()`
- `Void OnPointerClick(PointerEventData eventData)`
- `Void RemoveFriend()`

### Public Properties

*No public properties*

### Public Fields

- `GameObject addFriend_gameobject`
- `TextMeshProUGUI nickname_text`
- `Image status_image`

---


## Coordinates

**Base Class:** `System.ValueType`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Int16 posX`
- `Int16 posY`

---


## CountryEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AddCountryToList()`
- `Void CreateNewCountry()`
- `Void GenerateCountriesList()`
- `Void RefreshCountryList()`
- `Void RemoveCountry()`
- `Void SaveAll()`
- `Void SelectCountry(String country)`
- `Void SelectModToEdit()`
- `Void SetCountryName()`
- `Void ShowCountryName(String p_countryName)`

### Public Properties

*No public properties*

### Public Fields

- `Transform parentListOfCountries`
- `GameObject selectedCountry_Panel`

---


## CustomCountries

### Public Methods

- `Void CreateFileBaseMod(String p_path)`
- `List`1 get_ListOfCustomCountries()`
- `Void Save()`
- `Void set_ListOfCustomCountries(List`1 value)`

### Public Properties

- `List`1 ListOfCustomCountries` { get; set }

### Public Fields

- `String fileLocation`
- `static String FILENAME`

---


## CustomTiles

### Public Methods

- `Void CreateFileBaseMod(String path)`
- `List`1 get_ListOfCustomTiles()`
- `Void Load()`
- `Void Save()`
- `Void set_ListOfCustomTiles(List`1 value)`

### Public Properties

- `List`1 ListOfCustomTiles` { get; set }

### Public Fields

- `String fileLocation`
- `static String FILENAME`

---


## CustomUnits

### Public Methods

- `Void CreateFileBaseMod(String path)`
- `List`1 get_ListOfCustomUnits()`
- `Void PatchInvalidData()`
- `Void Save()`
- `Void set_ListOfCustomUnits(List`1 value)`

### Public Properties

- `List`1 ListOfCustomUnits` { get; set }

### Public Fields

- `String fileLocation`
- `static String FILENAME`

---


## DamageTextGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Animate()`

### Public Properties

*No public properties*

### Public Fields

- `TextMeshPro text`

---


## DamageTypes

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static DamageTypes AIR`
- `static DamageTypes HARD`
- `static DamageTypes NONE`
- `static DamageTypes SOFT`
- `Byte value__`

---


## Database

### Public Methods

- `static UnitModification get_atomBombOption()`
- `static UnitModification get_bombsOption()`
- `static List`1 get_Countries()`
- `static UnitModification get_dropTankOption()`
- `static UnitModification get_horseTowedOption()`
- `static HashSet`1 get_Majors()`
- `static UnitModification get_mechanizedOption()`
- `static HashSet`1 get_Minors()`
- `static UnitModification get_motorizedOption()`
- `static UnitModification get_mountaineersOption()`
- `static HashSet`1 get_NavalMajors()`
- `static HashSet`1 get_NavalMinors()`
- `static UnitModification get_planeTransportOption()`
- `static UnitModification get_politicalOption()`
- `static UnitModification get_rocketsOption()`
- `static UnitModification get_shipTransportOption()`
- `static UnitModification get_torpedoOption()`
- `static UnitModification get_trainTransportOption()`
- `static UnitModification get_winterTrainedOption()`

### Public Properties

- `static UnitModification atomBombOption` { get }
- `static UnitModification bombsOption` { get }
- `static List`1 Countries` { get }
- `static UnitModification dropTankOption` { get }
- `static UnitModification horseTowedOption` { get }
- `static HashSet`1 Majors` { get }
- `static UnitModification mechanizedOption` { get }
- `static HashSet`1 Minors` { get }
- `static UnitModification motorizedOption` { get }
- `static UnitModification mountaineersOption` { get }
- `static HashSet`1 NavalMajors` { get }
- `static HashSet`1 NavalMinors` { get }
- `static UnitModification planeTransportOption` { get }
- `static UnitModification politicalOption` { get }
- `static UnitModification rocketsOption` { get }
- `static UnitModification shipTransportOption` { get }
- `static UnitModification torpedoOption` { get }
- `static UnitModification trainTransportOption` { get }
- `static UnitModification winterTrainedOption` { get }

### Public Fields

- `static Int32 AtomBombCost`
- `static Int32 bombCost`
- `static Int32 dropTankCost`
- `static List`1 factions`
- `static Int32 horseCost`
- `static List`1 ideologies`
- `static Int32 mechanizeCost`
- `static Int32 motorizeCost`
- `static Int32 mountaineerCost`
- `static List`1 NATOtypes`
- `static Int32 politicalUnitCost`
- `static Int32 rocketsCost`
- `static List`1 seasons`
- `static Int32 torpedoCost`
- `static List`1 unitFilters`
- `static List`1 unitTypes`
- `static Int32 veteranUnitCost`
- `static Int32 winterCost`

---


## DataMigrator

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## DentedPixel.LeanDummy

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## DeploySlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void SetUpSlot()`

### Public Properties

*No public properties*

### Public Fields

- `Image atomBomb_image`
- `Image background_image`
- `Image bomb_image`
- `Sprite censoredSS_sprite`
- `Button delete_button`
- `Image dropTank_image`
- `Image flamethrower_image`
- `Sprite guards_sprite`
- `Image horse_image`
- `TextMeshProUGUI HP_text`
- `Image level_image`
- `Image mechanize_image`
- `Image mountaineer_image`
- `Image navalAircraft_image`
- `Image political_image`
- `Image productionTakesTime_image`
- `TextMeshProUGUI productionTime_text`
- `Image recon_image`
- `Image representation_image`
- `Image rocket_image`
- `Image seaplane_image`
- `Button slot_button`
- `Sprite SS_sprite`
- `Image torpedo_image`
- `Button transfer_button`
- `Image truck_image`
- `Unit unit`
- `TextMeshProUGUI unitName_text`
- `Button upgrade_button`
- `Image veteran`
- `Image winter_image`

---


## DiplomacyGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ClosePanel()`
- `Void CreateFaction()`
- `Void InviteToAlliance(DiplomacySlotGO p_diplomacySlotGO)`
- `Void JoinFaction()`
- `Void KickFromFaction(DiplomacySlotGO p_diplomacySlotGO)`
- `Void ManageCreateFactionPanel()`
- `Void ManageRelations(DiplomacySlotGO p_diplomacySlotGO)`
- `Void SendMoney(DiplomacySlotGO p_diplomacySlotGO)`
- `Void TransferVP_Button()`

### Public Properties

*No public properties*

### Public Fields

- `Button createFaction_button`
- `GameObject createFactionPanel`
- `DiplomacySlotGO diplomacySlotPrefab`
- `GameObject diplomacyTooltip`
- `TMP_Dropdown existingFactions_dropdown`
- `TMP_InputField factionNameInputfield`
- `static DiplomacyGO instance`
- `Transform parent`
- `Transform tooltip_alliances_parent`
- `Transform tooltip_atWar_parent`
- `TextMeshProUGUI tooltip_country_text`
- `Transform tooltip_truces_parent`
- `GameObject tooltipCountryPrefab`

---


## DiplomacySlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void SetUpDiplomacySlot(Player p_player)`

### Public Properties

*No public properties*

### Public Fields

- `Button inviteToAlliance_button`
- `Button kick_button`
- `Player player`
- `Button sendMoney_button`
- `TMP_InputField sendMoney_inputfield`
- `Button status_button`
- `Button swapPlayerConfiguration_button`

---


## DiplomacyTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## DrawingManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Boolean AreSegmentsIntersecting(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)`
- `Void DecreaseWidth()`
- `Void IncreaseWidth()`
- `Boolean IsErasingOrDrawing()`
- `Void SetDrawMode()`
- `Void SetEraseMode()`
- `Void SpawnLinesForPlayer(Player p_player)`

### Public Properties

*No public properties*

### Public Fields

- `static DrawingManager instance`

---


## EndGameResults

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static EndGameResults DEFEAT`
- `Int32 value__`
- `static EndGameResults VICTORY`

---


## Event

### Public Methods

- `Boolean AreAllVPsOccupied(Map p_map, Tile p_tile, Player p_playerCapturing)`
- `Event Clone()`
- `Boolean FullyProcessed()`
- `Boolean get_AIonly()`
- `Int32 get_Chance()`
- `DateTime get_CheckDate()`
- `Int16 get_CheckTileCoordinateX()`
- `Int16 get_CheckTileCoordinateY()`
- `Int16 get_CheckTurnCount()`
- `CheckTypes get_CheckType()`
- `Int32 get_CheckUnitID()`
- `DateTime get_DontCheckBeforeDate()`
- `Int16 get_DontCheckBeforeTurnCount()`
- `List`1 get_EventActions()`
- `Int32 get_ExecutionsLeft()`
- `Boolean get_ForceHumanApplyEvent()`
- `String get_Group()`
- `Boolean get_HistoricalFocusOnly()`
- `Boolean get_HumansOnly()`
- `Int32 get_ID()`
- `String get_MasterPlayer()`
- `Int32 get_MaxExecutions()`
- `String get_Name()`
- `String get_Player1Check()`
- `String get_Player2Check()`
- `Boolean get_TurnBasedEvent()`
- `List`1 get_VPsToBeLost()`
- `Boolean IsEventReady(Boolean p_includingActions)`
- `Boolean IsValidForLossTrigger(Tile p_tile)`
- `Void RemoveExecution()`
- `Void set_AIonly(Boolean value)`
- `Void set_Chance(Int32 value)`
- `Void set_CheckDate(DateTime value)`
- `Void set_CheckTileCoordinateX(Int16 value)`
- `Void set_CheckTileCoordinateY(Int16 value)`
- `Void set_CheckTurnCount(Int16 value)`
- `Void set_CheckUnitID(Int32 value)`
- `Void set_DontCheckBeforeDate(DateTime value)`
- `Void set_DontCheckBeforeTurnCount(Int16 value)`
- `Void set_EventActions(List`1 value)`
- `Void set_ExecutionsLeft(Int32 value)`
- `Void set_ForceHumanApplyEvent(Boolean value)`
- `Void set_Group(String value)`
- `Void set_HistoricalFocusOnly(Boolean value)`
- `Void set_HumansOnly(Boolean value)`
- `Void set_ID(Int32 value)`
- `Void set_MasterPlayer(String value)`
- `Void set_MaxExecutions(Int32 value)`
- `Void set_Name(String value)`
- `Void set_Player1Check(String value)`
- `Void set_Player2Check(String value)`
- `Void set_TurnBasedEvent(Boolean value)`
- `Void set_VPsToBeLost(List`1 value)`
- `Void SetCheckType(CheckTypes p_checkType)`
- `Void SetDefaultName()`
- `static String TranslateEventCheck(CheckTypes p_checkType)`

### Public Properties

- `Boolean AIonly` { get; set }
- `Int32 Chance` { get; set }
- `DateTime CheckDate` { get; set }
- `Int16 CheckTileCoordinateX` { get; set }
- `Int16 CheckTileCoordinateY` { get; set }
- `Int16 CheckTurnCount` { get; set }
- `CheckTypes CheckType` { get; set }
- `Int32 CheckUnitID` { get; set }
- `DateTime DontCheckBeforeDate` { get; set }
- `Int16 DontCheckBeforeTurnCount` { get; set }
- `List`1 EventActions` { get; set }
- `Int32 ExecutionsLeft` { get; set }
- `Boolean ForceHumanApplyEvent` { get; set }
- `String Group` { get; set }
- `Boolean HistoricalFocusOnly` { get; set }
- `Boolean HumansOnly` { get; set }
- `Int32 ID` { get; set }
- `String MasterPlayer` { get; set }
- `Int32 MaxExecutions` { get; set }
- `String Name` { get; set }
- `String Player1Check` { get; set }
- `String Player2Check` { get; set }
- `Boolean TurnBasedEvent` { get; set }
- `List`1 VPsToBeLost` { get; set }

### Public Fields

*No public fields*

---


## EventAction

### Public Methods

- `EventAction Clone()`
- `String get_CityName()`
- `Int16 get_HQPointsAmount()`
- `String get_MessageText()`
- `Int32 get_MoneyAmount()`
- `Boolean get_OriginalOwnerOnly()`
- `Byte get_PlayerIndex()`
- `Int32 get_PosX()`
- `Int32 get_PosY()`
- `Boolean get_Processed()`
- `String get_TargetCountryName()`
- `String get_TargetFactionName()`
- `String get_TargetIdeology()`
- `String get_TargetPlayerName1()`
- `String get_TargetPlayerName2()`
- `String get_TileName()`
- `String get_TileSeason()`
- `ActionTypes get_Type()`
- `Unit get_Unit()`
- `String get_UnitCountry()`
- `Byte get_UnitLevel()`
- `String get_UnitName()`
- `Boolean IsActionSetup()`
- `Void Process()`
- `Void ResetProcess()`
- `Void set_CityName(String value)`
- `Void set_HQPointsAmount(Int16 value)`
- `Void set_MessageText(String value)`
- `Void set_MoneyAmount(Int32 value)`
- `Void set_OriginalOwnerOnly(Boolean value)`
- `Void set_PlayerIndex(Byte value)`
- `Void set_PosX(Int32 value)`
- `Void set_PosY(Int32 value)`
- `Void set_Processed(Boolean value)`
- `Void set_TargetCountryName(String value)`
- `Void set_TargetFactionName(String value)`
- `Void set_TargetIdeology(String value)`
- `Void set_TargetPlayerName1(String value)`
- `Void set_TargetPlayerName2(String value)`
- `Void set_TileName(String value)`
- `Void set_TileSeason(String value)`
- `Void set_Type(ActionTypes value)`
- `Void set_Unit(Unit value)`
- `Void set_UnitCountry(String value)`
- `Void set_UnitLevel(Byte value)`
- `Void set_UnitName(String value)`
- `static String TranslateEventAction(ActionTypes p_actionType)`

### Public Properties

- `String CityName` { get; set }
- `Int16 HQPointsAmount` { get; set }
- `String MessageText` { get; set }
- `Int32 MoneyAmount` { get; set }
- `Boolean OriginalOwnerOnly` { get; set }
- `Byte PlayerIndex` { get; set }
- `Int32 PosX` { get; set }
- `Int32 PosY` { get; set }
- `Boolean Processed` { get; set }
- `String TargetCountryName` { get; set }
- `String TargetFactionName` { get; set }
- `String TargetIdeology` { get; set }
- `String TargetPlayerName1` { get; set }
- `String TargetPlayerName2` { get; set }
- `String TileName` { get; set }
- `String TileSeason` { get; set }
- `ActionTypes Type` { get; set }
- `Unit Unit` { get; set }
- `String UnitCountry` { get; set }
- `Byte UnitLevel` { get; set }
- `String UnitName` { get; set }

### Public Fields

*No public fields*

---


## EventActionSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void CloneAction_Button()`
- `Void DeleteAction_Button()`
- `EventAction GetEventAction()`
- `Void OnBoughtUnit()`
- `Void SetActionType()`
- `Void SetCheckOriginalOwner()`
- `Void SetCityName()`
- `Void SetEventPosXSpawnUnit()`
- `Void SetEventPosYSpawnUnit()`
- `Void SetEventSeason()`
- `Void SetEventTile()`
- `Void SetEventUnit()`
- `Void SetEventUnitCountry()`
- `Void SetHQpointsAmount()`
- `Void SetMoneyAmount()`
- `Void SetNewPlayerCountry()`
- `Void SetPlayerIndex()`
- `Void SetPlayerTarget1()`
- `Void SetPlayerTarget2()`
- `Void SetTargetCountry()`
- `Void SetTargetFaction()`
- `Void SetTargetIdeology()`
- `Void SetTextMessage()`
- `Void SetUnit()`
- `Void SetUnitLevel()`
- `Void Setup(Event p_event, EventAction p_eventAction)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## EventData

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Player playerCapturing`
- `Player playerLosing`

---


## EventListSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Button clone_button`
- `Button delete_button`
- `TextMeshProUGUI eventName_text`
- `Button select_button`
- `Image warning_image`

---


## EventPanelGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AddAction_Button()`
- `Void AddEvent_Button()`
- `Void AddEventVPLosses()`
- `Void CloneEvent()`
- `Void CloneEvent_Button(Event p_event)`
- `Void Close()`
- `Void DeleteEvent()`
- `Void DeleteEvent_Button(Event p_event)`
- `Void Open()`
- `Void RefreshActions()`
- `Void RefreshEventList()`
- `Void RemoveEventVPLosses()`
- `Void SelectEvent(Event p_event)`
- `Void SetAIOnlyEvent()`
- `Void SetEventChance()`
- `Void SetEventCheckDay()`
- `Void SetEventCheckMonth()`
- `Void SetEventCheckPosXSpawnUnitVPLoss()`
- `Void SetEventCheckPosYSpawnUnitVPLoss()`
- `Void SetEventCheckTurn()`
- `Void SetEventCheckType()`
- `Void SetEventCheckUnitID()`
- `Void SetEventCheckYear()`
- `Void SetEventGroup()`
- `Void SetEventHistoricalFocusOnly()`
- `Void SetEventMasterPlayer()`
- `Void SetEventMaxExecutions()`
- `Void SetEventName()`
- `Void SetEventNotBeforeDateDay()`
- `Void SetEventNotBeforeDateMonth()`
- `Void SetEventNotBeforeDateYear()`
- `Void SetEventNotBeforeTurn()`
- `Void SetEventPlayer1ActionCheck()`
- `Void SetEventPlayer2ActionCheck()`
- `Void SetForceHumanApplyEvent()`
- `Void SetHumanOnlyEvent()`

### Public Properties

*No public properties*

### Public Fields

- `static EventPanelGO instance`

---


## Explosion

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Animator Animator`

---


## FacingRotations

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static FacingRotations EAST`
- `static FacingRotations NORTH`
- `static FacingRotations NORTH_EAST`
- `static FacingRotations NORTH_WEST`
- `static FacingRotations SOUTH`
- `static FacingRotations SOUTH_EAST`
- `static FacingRotations SOUTH_WEST`
- `Byte value__`
- `static FacingRotations WEST`

---


## FadeTileGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void StartFade(TileGO p_tileGO)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## FCP_Persistence

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Boolean LoadColor(Color& c)`
- `Void SaveColor(Color c)`

### Public Properties

*No public properties*

### Public Fields

- `String saveName`
- `SaveStrategy saveStrategy`

---


## FCP_SpriteMeshEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `MeshType meshType`
- `Sprite sprite`
- `Int32 x`
- `Int32 y`

---


## FlexibleColorPicker

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ChangeMode(Int32 newMode)`
- `Void ChangeMode(MainPickingMode mode)`
- `Void FinishTypeHex(String input)`
- `Color get_color()`
- `Color GetColor()`
- `Color GetColorFullAlpha()`
- `static String GetSanitizedHex(String input, Boolean full)`
- `static Color HSVToRGB(Vector3 hsv)`
- `static Color HSVToRGB(Single h, Single s, Single v)`
- `static Color ParseHex(String input)`
- `static Color ParseHex(String input, Color defaultColor)`
- `Void PointerUpdate(BaseEventData e)`
- `static Vector3 RGBToHSV(Color color)`
- `static Vector3 RGBToHSV(Single r, Single g, Single b)`
- `Void set_color(Color value)`
- `Void SetColor(Color color)`
- `Void SetColorNoAlpha(Color color)`
- `Void SetPointerFocus(Int32 i)`
- `Void ShiftColor(Int32 type, Single delta)`
- `Void ShiftHue(Single delta)`
- `Void TypeHex(String input)`

### Public Properties

- `Color color` { get; set }

### Public Fields

- `AdvancedSettings advancedSettings`
- `Boolean multiInstance`
- `ColorUpdateEvent onColorChange`
- `Boolean staticMode`

---


## ForecastType

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static ForecastType CURRENT`
- `static ForecastType FULL`
- `static ForecastType NEXT`
- `Int32 value__`

---


## Game

### Public Methods

- `Int64 get_Appid()`
- `Boolean get_HasCommunityVisibleStats()`
- `String get_ImgIconUrl()`
- `String get_ImgLogoUrl()`
- `String get_Name()`
- `Nullable`1 get_Playtime2Weeks()`
- `Int64 get_PlaytimeForever()`
- `Int64 get_PlaytimeLinuxForever()`
- `Int64 get_PlaytimeMacForever()`
- `Int64 get_PlaytimeWindowsForever()`
- `Void set_Appid(Int64 value)`
- `Void set_HasCommunityVisibleStats(Boolean value)`
- `Void set_ImgIconUrl(String value)`
- `Void set_ImgLogoUrl(String value)`
- `Void set_Name(String value)`
- `Void set_Playtime2Weeks(Nullable`1 value)`
- `Void set_PlaytimeForever(Int64 value)`
- `Void set_PlaytimeLinuxForever(Int64 value)`
- `Void set_PlaytimeMacForever(Int64 value)`
- `Void set_PlaytimeWindowsForever(Int64 value)`

### Public Properties

- `Int64 Appid` { get; set }
- `Boolean HasCommunityVisibleStats` { get; set }
- `String ImgIconUrl` { get; set }
- `String ImgLogoUrl` { get; set }
- `String Name` { get; set }
- `Nullable`1 Playtime2Weeks` { get; set }
- `Int64 PlaytimeForever` { get; set }
- `Int64 PlaytimeLinuxForever` { get; set }
- `Int64 PlaytimeMacForever` { get; set }
- `Int64 PlaytimeWindowsForever` { get; set }

### Public Fields

*No public fields*

---


## GameData

### Public Methods

- `Void GenerateGameSettings(Boolean p_lockSaveFile)`
- `static GameData get_Instance()`
- `ModPropertyBag get_ModDataBag()`
- `Event GetEvent(Int32 p_ID)`
- `Boolean IsIronManModeON(List`1& o_ironManOFFReasons)`
- `Void Load(String p_filePath)`
- `static Void SanitizeData(GameData p_gameData)`
- `Void Save(FileInfo p_fileInfo)`
- `Void SaveToCloud(String p_fileName)`
- `Void SaveToMaps(String p_fileName)`
- `Void SaveToSaves(String p_fileName)`
- `Void SetData(GameData p_gameData)`
- `Void SetIronManMode(Boolean p_value)`
- `Boolean TryFindLocalPlayer(Player& o_localPlayer)`
- `Boolean TryFindPlayerByCountry(String p_country, Player& o_player)`
- `Boolean TryFindPlayerByName(String p_playerName, Player& o_player)`
- `Boolean TryFindPlayerByNickname(String p_playerNickname, Player& o_player)`

### Public Properties

- `static GameData Instance` { get }
- `ModPropertyBag ModDataBag` { get }

### Public Fields

- `Boolean endOfTurnPanelOpen`
- `static String EXTENSION_NAME`
- `Boolean gameFinishedButContinue`
- `GameSettings gameSettings`
- `Boolean ironManMode`
- `Boolean isFromMapEditor`
- `List`1 listOfPlayers`
- `Map map`
- `List`1 messages`
- `Boolean offlinePBEM`
- `Int32 tutorialStep`
- `Boolean violatedIronmanRule`

---


## GameLanguages

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static GameLanguages BR`
- `static GameLanguages CA`
- `static GameLanguages CNS`
- `static GameLanguages CNT`
- `static GameLanguages CZ`
- `static GameLanguages DE`
- `static GameLanguages EN`
- `static GameLanguages ES`
- `static GameLanguages FI`
- `static GameLanguages FR`
- `static GameLanguages GR`
- `static GameLanguages IT`
- `static GameLanguages JP`
- `static GameLanguages KR`
- `static GameLanguages NL`
- `static GameLanguages NO`
- `static GameLanguages PL`
- `static GameLanguages PT`
- `static GameLanguages RU`
- `static GameLanguages SE`
- `static GameLanguages TR`
- `static GameLanguages UA`
- `Int32 value__`

---


## GameModification

### Public Methods

- `Void OnModInitialization(Mod p_mod)`
- `Void OnModUnloaded()`

### Public Properties

*No public properties*

### Public Fields

- `Mod mod`

---


## GameResponse

### Public Methods

- `Response get_Response()`
- `Void set_Response(Response value)`

### Public Properties

- `Response Response` { get; set }

### Public Fields

*No public fields*

---


## GameSettings

**Base Class:** `System.ValueType`

### Public Methods

- `Void Backup()`
- `Void LoadBackup()`

### Public Properties

*No public properties*

### Public Fields

- `Boolean complexSuppliesON`
- `Boolean damageReductionRepeatedAttacks`
- `Int32 difficultyValue`
- `Boolean finiteManpower`
- `Boolean fogOfWarON`
- `Boolean historicalFocusON`
- `Boolean infiniteAmmoAndFuelON`
- `Boolean isBackup`
- `Boolean manpowerON`
- `Boolean moraleON`
- `Boolean noAAsupportDuringAirFight`
- `Boolean overrunON`
- `Boolean partisansON`
- `Boolean planeMoveAfterAttackON`
- `Boolean policiesON`
- `Boolean productionTakesTimeON`
- `Boolean prototypesDisabled`
- `Int32 randomDamageValue`
- `Boolean realisticPlanesON`
- `Boolean researchON`
- `Boolean saveLocked`
- `Boolean stricterFogOfWar`
- `Boolean upkeepON`
- `Boolean weatherON`
- `Int32 winterDamageValue`
- `Boolean zoneOfControlON`

---


## GameStates

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static GameStates DEFEAT`
- `static GameStates NOT_SETUP`
- `static GameStates ONGOING`
- `static GameStates TURN_LIMIT_REACHED`
- `Int32 value__`
- `static GameStates VICTORY`

---


## GraphPanelGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void GenerateBarChart(String p_statName)`
- `Void GenerateGraphChart(String p_statName)`
- `Void ManageGraphPanel()`
- `Void SwitchGraphBarChart()`

### Public Properties

*No public properties*

### Public Fields

- `Transform barChartGroup`
- `Material baseGraph_material`
- `Material baseGraphPoint_material`
- `CanvasBarChart canvasBarChart`
- `CategoryLabels categoryLabels`
- `GraphChart graphChart`
- `Transform graphChartGroup`
- `GameObject graphPanel`
- `TextMeshProUGUI graphTitle_text`
- `static GraphPanelGO instance`
- `ChartItemEffect lineOver`
- `ChartItemEffect pointOver`

---


## GroundHeroes

### Public Methods

- `static List`1 GetHeroes(String p_country)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Hero

### Public Methods

- `Int16 get_AirDamageBonus()`
- `String get_Country()`
- `Int16 get_HardDamageBonus()`
- `Byte get_MPBonus()`
- `String get_Name()`
- `Int16 get_SoftDamageBonus()`
- `String get_Type()`
- `Byte get_VisibilityBonus()`
- `Int16 get_YearStartAvailability()`
- `Int16 get_YearStopAvailability()`
- `Void set_AirDamageBonus(Int16 value)`
- `Void set_Country(String value)`
- `Void set_HardDamageBonus(Int16 value)`
- `Void set_MPBonus(Byte value)`
- `Void set_Name(String value)`
- `Void set_SoftDamageBonus(Int16 value)`
- `Void set_Type(String value)`
- `Void set_VisibilityBonus(Byte value)`
- `Void set_YearStartAvailability(Int16 value)`
- `Void set_YearStopAvailability(Int16 value)`

### Public Properties

- `Int16 AirDamageBonus` { get; set }
- `String Country` { get; set }
- `Int16 HardDamageBonus` { get; set }
- `Byte MPBonus` { get; set }
- `String Name` { get; set }
- `Int16 SoftDamageBonus` { get; set }
- `String Type` { get; set }
- `Byte VisibilityBonus` { get; set }
- `Int16 YearStartAvailability` { get; set }
- `Int16 YearStopAvailability` { get; set }

### Public Fields

*No public fields*

---


## HeroBonusesGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

- `GameObject airDamageHero_Text`
- `RectTransform canvas_RectTransform`
- `GameObject hardDamageHero_Text`
- `GameObject HeroBonus_Text`
- `GameObject HeroBonuses_Panel`
- `GameObject MPHero_Text`
- `static Hero selectedHero`
- `GameObject softDamageHero_Text`
- `GameObject visibilityHero_Text`

---


## HeroesEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AddNewHero()`
- `Void CreateHero()`
- `Void GenerateHeroesSlots()`
- `Void RefreshHeroesList()`
- `Void RemoveHero()`
- `Void SaveAll()`
- `Void SelectHero(Hero p_hero)`
- `Void SelectModToEdit()`
- `Void SetHeroCountry()`
- `Void SetHeroName()`
- `Void SetHeroStartYear()`
- `Void SetHeroStopYear()`
- `Void SetHeroType()`
- `Void ShowHeroStats()`

### Public Properties

*No public properties*

### Public Fields

- `Button add_Button`
- `Button delete_Button`
- `TMP_Dropdown filterCountry_Dropdown`
- `TMP_Dropdown filterType_Dropdown`
- `Image hero_Image`
- `TMP_Dropdown heroCountry_Dropdown`
- `GameObject heroImagebackground`
- `TMP_InputField heroName_inputfield`
- `GameObject heroSlotPrefab`
- `TMP_Dropdown heroType_Dropdown`
- `TMP_InputField heroYearStart_inputfield`
- `TMP_InputField heroYearStop_inputfield`
- `TMP_Dropdown mods_Dropdown`
- `Transform parentForListOfHeroes`
- `TMP_InputField search_inputField`
- `GameObject selectedHeroBackground`

---


## HoverUnitUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Close()`
- `Void Show(UnitGO p_unitGO)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## IntegerInputfield

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## InvalidIronManReasons

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static InvalidIronManReasons DIFFICULTY`
- `static InvalidIronManReasons FOW`
- `static InvalidIronManReasons HISTORICAL_FOCUS`
- `static InvalidIronManReasons INFINITE_AMMO_FUEL`
- `static InvalidIronManReasons MODS`
- `static InvalidIronManReasons NONE`
- `static InvalidIronManReasons OFFICIAL_MAP`
- `static InvalidIronManReasons PRODUCTION_TAKES_TIME`
- `static InvalidIronManReasons REALISTIC_SUPPLIES`
- `static InvalidIronManReasons SCENARIO_SETUP`
- `static InvalidIronManReasons UPKEEP`
- `Int32 value__`
- `static InvalidIronManReasons VIOLATED_RULE`
- `static InvalidIronManReasons WEATHER`
- `static InvalidIronManReasons ZOC`

---


## IronmanTooltip

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData p_eventData)`
- `Void OnPointerExit(PointerEventData p_eventData)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## LanguageSlotUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Button button`
- `Image image`

---


## LastTurnSummaryData

**Base Class:** `System.ValueType`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `String countryName`
- `Int32 moneyEarned`
- `Int32 moneySpent`
- `Int32 unitsBuilt`
- `Int32 unitsDestroyed`
- `Int32 unitsLost`

---


## LastTurnSummaryUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Setup(Player p_player)`

### Public Properties

*No public properties*

### Public Fields

- `LastTurnSummaryData lastTurnSummaryData`

---


## LeaderboardActions

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static LeaderboardActions FORCE_UPDATE`
- `static LeaderboardActions KEEP_BEST`
- `Int32 value__`

---


## LeaderboardEntryUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void SetNoEntry()`
- `Void Setup(SteamLeaderboardEntry p_steamLeaderboardEntry)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## LeaderboardGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void SelectScenario(String p_leaderboardName)`

### Public Properties

*No public properties*

### Public Fields

- `TextMeshProUGUI columnValues_text`
- `Transform leaderboard_parent`
- `GameObject leaderboardScenario_prefab`
- `LeaderboardEntryUI leaderboardSlot_prefab`
- `Transform listOfScenarios_Parent`

---


## LeanAudio

### Public Methods

- `static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)`
- `static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)`
- `static AudioClip generateAudioFromCurve(AnimationCurve curve, Int32 frequencyRate)`
- `static LeanAudioOptions options()`
- `static AudioSource play(AudioClip audio, Single volume)`
- `static AudioSource play(AudioClip audio)`
- `static AudioSource play(AudioClip audio, Vector3 pos)`
- `static AudioSource play(AudioClip audio, Vector3 pos, Single volume)`
- `static AudioSource playClipAt(AudioClip clip, Vector3 pos)`
- `static Void printOutAudioClip(AudioClip audioClip, AnimationCurve& curve, Single scaleX)`

### Public Properties

*No public properties*

### Public Fields

- `static Single[] generatedWaveDistances`
- `static Int32 generatedWaveDistancesCount`
- `static Single MIN_FREQEUNCY_PERIOD`
- `static Int32 PROCESSING_ITERATIONS_MAX`

---


## LeanAudioOptions

### Public Methods

- `LeanAudioOptions setFrequency(Int32 frequencyRate)`
- `LeanAudioOptions setVibrato(Vector3[] vibrato)`
- `LeanAudioOptions setWaveNoise()`
- `LeanAudioOptions setWaveNoiseInfluence(Single influence)`
- `LeanAudioOptions setWaveNoiseScale(Single waveScale)`
- `LeanAudioOptions setWaveSawtooth()`
- `LeanAudioOptions setWaveSine()`
- `LeanAudioOptions setWaveSquare()`
- `LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)`

### Public Properties

*No public properties*

### Public Fields

- `Int32 frequencyRate`
- `Vector3[] modulation`
- `LeanAudioStream stream`
- `Boolean useSetData`
- `Vector3[] vibrato`
- `Single waveNoiseInfluence`
- `Single waveNoiseScale`
- `LeanAudioWaveStyle waveStyle`

---


## LeanAudioStream

### Public Methods

- `Void OnAudioRead(Single[] data)`
- `Void OnAudioSetPosition(Int32 newPosition)`

### Public Properties

*No public properties*

### Public Fields

- `Single[] audioArr`
- `AudioClip audioClip`
- `Int32 position`

---


## LeanProp

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static LeanProp color`
- `static LeanProp localPosition`
- `static LeanProp localX`
- `static LeanProp localY`
- `static LeanProp localZ`
- `static LeanProp position`
- `static LeanProp scale`
- `Int32 value__`
- `static LeanProp x`
- `static LeanProp y`
- `static LeanProp z`

---


## LeanSmooth

### Public Methods

- `static Single bounceOut(Single current, Single target, Single& currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime, Single friction, Single accelRate, Single hitDamping)`
- `static Vector3 bounceOut(Vector3 current, Vector3 target, Vector3& currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime, Single friction, Single accelRate, Single hitDamping)`
- `static Color bounceOut(Color current, Color target, Color& currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime, Single friction, Single accelRate, Single hitDamping)`
- `static Single damp(Single current, Single target, Single& currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime)`
- `static Vector3 damp(Vector3 current, Vector3 target, Vector3& currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime)`
- `static Color damp(Color current, Color target, Color& currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime)`
- `static Single linear(Single current, Single target, Single moveSpeed, Single deltaTime)`
- `static Vector3 linear(Vector3 current, Vector3 target, Single moveSpeed, Single deltaTime)`
- `static Color linear(Color current, Color target, Single moveSpeed)`
- `static Single spring(Single current, Single target, Single& currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime, Single friction, Single accelRate)`
- `static Vector3 spring(Vector3 current, Vector3 target, Vector3& currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime, Single friction, Single accelRate)`
- `static Color spring(Color current, Color target, Color& currentVelocity, Single smoothTime, Single maxSpeed, Single deltaTime, Single friction, Single accelRate)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## LeanTest

### Public Methods

- `static Void debug(String name, Boolean didPass, String failExplaination)`
- `static Void expect(Boolean didPass, String definition, String failExplaination)`
- `static String formatB(String str)`
- `static String formatBC(String str, String color)`
- `static String formatC(String str, String color)`
- `static Void overview()`
- `static String padRight(Int32 len)`
- `static Single printOutLength(String str)`

### Public Properties

*No public properties*

### Public Fields

- `static Int32 expected`
- `static Boolean testsFinished`
- `static Single timeout`
- `static Boolean timeoutStarted`

---


## LeanTester

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Start()`

### Public Properties

*No public properties*

### Public Fields

- `Single timeout`

---


## LeanTween

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `static Vector3[] add(Vector3[] a, Vector3 b)`
- `static Void addListener(Int32 eventId, Action`1 callback)`
- `static Void addListener(GameObject caller, Int32 eventId, Action`1 callback)`
- `static LTDescr alpha(GameObject gameObject, Single to, Single time)`
- `static LTDescr alpha(LTRect ltRect, Single to, Single time)`
- `static LTDescr alpha(RectTransform rectTrans, Single to, Single time)`
- `static LTDescr alphaCanvas(CanvasGroup canvasGroup, Single to, Single time)`
- `static LTDescr alphaText(RectTransform rectTransform, Single to, Single time)`
- `static LTDescr alphaVertex(GameObject gameObject, Single to, Single time)`
- `static Void cancel(GameObject gameObject)`
- `static Void cancel(GameObject gameObject, Boolean callOnComplete)`
- `static Void cancel(RectTransform rect)`
- `static Void cancel(GameObject gameObject, Int32 uniqueId, Boolean callOnComplete)`
- `static Void cancel(LTRect ltRect, Int32 uniqueId)`
- `static Void cancel(Int32 uniqueId)`
- `static Void cancel(Int32 uniqueId, Boolean callOnComplete)`
- `static Void cancelAll()`
- `static Void cancelAll(Boolean callComplete)`
- `static Single clerp(Single start, Single end, Single val)`
- `static Single closestRot(Single from, Single to)`
- `static LTDescr color(GameObject gameObject, Color to, Single time)`
- `static LTDescr color(RectTransform rectTrans, Color to, Single time)`
- `static LTDescr colorText(RectTransform rectTransform, Color to, Single time)`
- `static LTDescr delayedCall(Single delayTime, Action callback)`
- `static LTDescr delayedCall(Single delayTime, Action`1 callback)`
- `static LTDescr delayedCall(GameObject gameObject, Single delayTime, Action callback)`
- `static LTDescr delayedCall(GameObject gameObject, Single delayTime, Action`1 callback)`
- `static LTDescr delayedSound(AudioClip audio, Vector3 pos, Single volume)`
- `static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, Single volume)`
- `static LTDescr descr(Int32 uniqueId)`
- `static LTDescr description(Int32 uniqueId)`
- `static LTDescr[] descriptions(GameObject gameObject)`
- `static LTDescr destroyAfter(LTRect rect, Single delayTime)`
- `static Void dispatchEvent(Int32 eventId)`
- `static Void dispatchEvent(Int32 eventId, Object data)`
- `static Void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, Single arrowSize, Transform arrowTransform)`
- `static Single easeInBack(Single start, Single end, Single val, Single overshoot)`
- `static Single easeInBounce(Single start, Single end, Single val)`
- `static Single easeInCirc(Single start, Single end, Single val)`
- `static Single easeInCubic(Single start, Single end, Single val)`
- `static Single easeInElastic(Single start, Single end, Single val, Single overshoot, Single period)`
- `static Single easeInExpo(Single start, Single end, Single val)`
- `static Single easeInOutBack(Single start, Single end, Single val, Single overshoot)`
- `static Single easeInOutBounce(Single start, Single end, Single val)`
- `static Single easeInOutCirc(Single start, Single end, Single val)`
- `static Single easeInOutCubic(Single start, Single end, Single val)`
- `static Single easeInOutElastic(Single start, Single end, Single val, Single overshoot, Single period)`
- `static Single easeInOutExpo(Single start, Single end, Single val)`
- `static Single easeInOutQuad(Single start, Single end, Single val)`
- `static Single easeInOutQuadOpt(Single start, Single diff, Single ratioPassed)`
- `static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, Single ratioPassed)`
- `static Single easeInOutQuadOpt2(Single start, Single diffBy2, Single val, Single val2)`
- `static Single easeInOutQuart(Single start, Single end, Single val)`
- `static Single easeInOutQuint(Single start, Single end, Single val)`
- `static Single easeInOutSine(Single start, Single end, Single val)`
- `static Single easeInQuad(Single start, Single end, Single val)`
- `static Single easeInQuadOpt(Single start, Single diff, Single ratioPassed)`
- `static Single easeInQuart(Single start, Single end, Single val)`
- `static Single easeInQuint(Single start, Single end, Single val)`
- `static Single easeInSine(Single start, Single end, Single val)`
- `static Single easeOutBack(Single start, Single end, Single val, Single overshoot)`
- `static Single easeOutBounce(Single start, Single end, Single val)`
- `static Single easeOutCirc(Single start, Single end, Single val)`
- `static Single easeOutCubic(Single start, Single end, Single val)`
- `static Single easeOutElastic(Single start, Single end, Single val, Single overshoot, Single period)`
- `static Single easeOutExpo(Single start, Single end, Single val)`
- `static Single easeOutQuad(Single start, Single end, Single val)`
- `static Single easeOutQuadOpt(Single start, Single diff, Single ratioPassed)`
- `static Single easeOutQuart(Single start, Single end, Single val)`
- `static Single easeOutQuint(Single start, Single end, Single val)`
- `static Single easeOutSine(Single start, Single end, Single val)`
- `static LTDescr followBounceOut(Transform trans, Transform target, LeanProp prop, Single smoothTime, Single maxSpeed, Single friction, Single accelRate, Single hitDamping)`
- `static LTDescr followDamp(Transform trans, Transform target, LeanProp prop, Single smoothTime, Single maxSpeed)`
- `static LTDescr followLinear(Transform trans, Transform target, LeanProp prop, Single moveSpeed)`
- `static LTDescr followSpring(Transform trans, Transform target, LeanProp prop, Single smoothTime, Single maxSpeed, Single friction, Single accelRate)`
- `static Int32 get_maxSearch()`
- `static Int32 get_maxSimulataneousTweens()`
- `static GameObject get_tweenEmpty()`
- `static Int32 get_tweensRunning()`
- `static Void init()`
- `static Void init(Int32 maxSimultaneousTweens)`
- `static Void init(Int32 maxSimultaneousTweens, Int32 maxSimultaneousSequences)`
- `static Boolean isPaused(GameObject gameObject)`
- `static Boolean isPaused(RectTransform rect)`
- `static Boolean isPaused(Int32 uniqueId)`
- `static Boolean isTweening(GameObject gameObject)`
- `static Boolean isTweening(RectTransform rect)`
- `static Boolean isTweening(Int32 uniqueId)`
- `static Boolean isTweening(LTRect ltRect)`
- `static Single linear(Single start, Single end, Single val)`
- `static Object logError(String error)`
- `static LTDescr move(GameObject gameObject, Vector3 to, Single time)`
- `static LTDescr move(GameObject gameObject, Vector2 to, Single time)`
- `static LTDescr move(GameObject gameObject, Vector3[] to, Single time)`
- `static LTDescr move(GameObject gameObject, LTBezierPath to, Single time)`
- `static LTDescr move(GameObject gameObject, LTSpline to, Single time)`
- `static LTDescr move(LTRect ltRect, Vector2 to, Single time)`
- `static LTDescr move(GameObject gameObject, Transform to, Single time)`
- `static LTDescr move(RectTransform rectTrans, Vector3 to, Single time)`
- `static LTDescr moveLocal(GameObject gameObject, Vector3 to, Single time)`
- `static LTDescr moveLocal(GameObject gameObject, Vector3[] to, Single time)`
- `static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, Single time)`
- `static LTDescr moveLocal(GameObject gameObject, LTSpline to, Single time)`
- `static LTDescr moveLocalX(GameObject gameObject, Single to, Single time)`
- `static LTDescr moveLocalY(GameObject gameObject, Single to, Single time)`
- `static LTDescr moveLocalZ(GameObject gameObject, Single to, Single time)`
- `static LTDescr moveMargin(LTRect ltRect, Vector2 to, Single time)`
- `static LTDescr moveSpline(GameObject gameObject, Vector3[] to, Single time)`
- `static LTDescr moveSpline(GameObject gameObject, LTSpline to, Single time)`
- `static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, Single time)`
- `static LTDescr moveX(GameObject gameObject, Single to, Single time)`
- `static LTDescr moveX(RectTransform rectTrans, Single to, Single time)`
- `static LTDescr moveY(GameObject gameObject, Single to, Single time)`
- `static LTDescr moveY(RectTransform rectTrans, Single to, Single time)`
- `static LTDescr moveZ(GameObject gameObject, Single to, Single time)`
- `static LTDescr moveZ(RectTransform rectTrans, Single to, Single time)`
- `static LTDescr options(LTDescr seed)`
- `static LTDescr options()`
- `static Void pause(GameObject gameObject, Int32 uniqueId)`
- `static Void pause(Int32 uniqueId)`
- `static Void pause(GameObject gameObject)`
- `static Void pauseAll()`
- `static LTDescr play(RectTransform rectTransform, Sprite[] sprites)`
- `static Boolean removeListener(Int32 eventId, Action`1 callback)`
- `static Boolean removeListener(Int32 eventId)`
- `static Boolean removeListener(GameObject caller, Int32 eventId, Action`1 callback)`
- `static Void removeTween(Int32 i, Int32 uniqueId)`
- `static Void removeTween(Int32 i)`
- `static Void reset()`
- `static Void resume(GameObject gameObject, Int32 uniqueId)`
- `static Void resume(Int32 uniqueId)`
- `static Void resume(GameObject gameObject)`
- `static Void resumeAll()`
- `static LTDescr rotate(GameObject gameObject, Vector3 to, Single time)`
- `static LTDescr rotate(LTRect ltRect, Single to, Single time)`
- `static LTDescr rotate(RectTransform rectTrans, Single to, Single time)`
- `static LTDescr rotate(RectTransform rectTrans, Vector3 to, Single time)`
- `static LTDescr rotateAround(GameObject gameObject, Vector3 axis, Single add, Single time)`
- `static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, Single to, Single time)`
- `static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, Single add, Single time)`
- `static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, Single to, Single time)`
- `static LTDescr rotateLocal(GameObject gameObject, Vector3 to, Single time)`
- `static LTDescr rotateX(GameObject gameObject, Single to, Single time)`
- `static LTDescr rotateY(GameObject gameObject, Single to, Single time)`
- `static LTDescr rotateZ(GameObject gameObject, Single to, Single time)`
- `static LTDescr scale(GameObject gameObject, Vector3 to, Single time)`
- `static LTDescr scale(LTRect ltRect, Vector2 to, Single time)`
- `static LTDescr scale(RectTransform rectTrans, Vector3 to, Single time)`
- `static LTDescr scaleX(GameObject gameObject, Single to, Single time)`
- `static LTDescr scaleY(GameObject gameObject, Single to, Single time)`
- `static LTDescr scaleZ(GameObject gameObject, Single to, Single time)`
- `static LTSeq sequence(Boolean initSequence)`
- `static LTDescr size(RectTransform rectTrans, Vector2 to, Single time)`
- `static Single spring(Single start, Single end, Single val)`
- `static LTDescr textAlpha(RectTransform rectTransform, Single to, Single time)`
- `static LTDescr textColor(RectTransform rectTransform, Color to, Single time)`
- `static Single tweenOnCurve(LTDescr tweenDescr, Single ratioPassed)`
- `static Vector3 tweenOnCurveVector(LTDescr tweenDescr, Single ratioPassed)`
- `static Void update()`
- `Void Update()`
- `static LTDescr value(GameObject gameObject, Single from, Single to, Single time)`
- `static LTDescr value(Single from, Single to, Single time)`
- `static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, Single time)`
- `static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, Single time)`
- `static LTDescr value(GameObject gameObject, Color from, Color to, Single time)`
- `static LTDescr value(GameObject gameObject, Action`1 callOnUpdate, Single from, Single to, Single time)`
- `static LTDescr value(GameObject gameObject, Action`2 callOnUpdateRatio, Single from, Single to, Single time)`
- `static LTDescr value(GameObject gameObject, Action`1 callOnUpdate, Color from, Color to, Single time)`
- `static LTDescr value(GameObject gameObject, Action`2 callOnUpdate, Color from, Color to, Single time)`
- `static LTDescr value(GameObject gameObject, Action`1 callOnUpdate, Vector2 from, Vector2 to, Single time)`
- `static LTDescr value(GameObject gameObject, Action`1 callOnUpdate, Vector3 from, Vector3 to, Single time)`
- `static LTDescr value(GameObject gameObject, Action`2 callOnUpdate, Single from, Single to, Single time)`

### Public Properties

- `static Int32 maxSearch` { get }
- `static Int32 maxSimulataneousTweens` { get }
- `static GameObject tweenEmpty` { get }
- `static Int32 tweensRunning` { get }

### Public Fields

- `static LTDescr d`
- `static Single dtActual`
- `static Single dtEstimated`
- `static Single dtManual`
- `static Int32 EVENTS_MAX`
- `static Int32 LISTENERS_MAX`
- `static Single PI_DIV2`
- `static AnimationCurve punch`
- `static AnimationCurve shake`
- `static Int32 startSearch`
- `static Single tau`
- `static Boolean throwErrors`

---


## LeanTweenExt

### Public Methods

- `static LTDescr LeanAlpha(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanAlpha(RectTransform rectTransform, Single to, Single time)`
- `static LTDescr LeanAlpha(CanvasGroup canvas, Single to, Single time)`
- `static LTDescr LeanAlphaText(RectTransform rectTransform, Single to, Single time)`
- `static LTDescr LeanAlphaVertex(GameObject gameObject, Single to, Single time)`
- `static Void LeanCancel(GameObject gameObject)`
- `static Void LeanCancel(GameObject gameObject, Boolean callOnComplete)`
- `static Void LeanCancel(GameObject gameObject, Int32 uniqueId, Boolean callOnComplete)`
- `static Void LeanCancel(RectTransform rectTransform)`
- `static LTDescr LeanColor(GameObject gameObject, Color to, Single time)`
- `static Color LeanColor(Transform transform)`
- `static LTDescr LeanColorText(RectTransform rectTransform, Color to, Single time)`
- `static LTDescr LeanDelayedCall(GameObject gameObject, Single delayTime, Action callback)`
- `static LTDescr LeanDelayedCall(GameObject gameObject, Single delayTime, Action`1 callback)`
- `static Boolean LeanIsPaused(GameObject gameObject)`
- `static Boolean LeanIsPaused(RectTransform rectTransform)`
- `static Boolean LeanIsTweening(GameObject gameObject)`
- `static LTDescr LeanMove(GameObject gameObject, Vector3 to, Single time)`
- `static LTDescr LeanMove(Transform transform, Vector3 to, Single time)`
- `static LTDescr LeanMove(RectTransform rectTransform, Vector3 to, Single time)`
- `static LTDescr LeanMove(GameObject gameObject, Vector2 to, Single time)`
- `static LTDescr LeanMove(Transform transform, Vector2 to, Single time)`
- `static LTDescr LeanMove(GameObject gameObject, Vector3[] to, Single time)`
- `static LTDescr LeanMove(GameObject gameObject, LTBezierPath to, Single time)`
- `static LTDescr LeanMove(GameObject gameObject, LTSpline to, Single time)`
- `static LTDescr LeanMove(Transform transform, Vector3[] to, Single time)`
- `static LTDescr LeanMove(Transform transform, LTBezierPath to, Single time)`
- `static LTDescr LeanMove(Transform transform, LTSpline to, Single time)`
- `static LTDescr LeanMoveLocal(GameObject gameObject, Vector3 to, Single time)`
- `static LTDescr LeanMoveLocal(GameObject gameObject, LTBezierPath to, Single time)`
- `static LTDescr LeanMoveLocal(GameObject gameObject, LTSpline to, Single time)`
- `static LTDescr LeanMoveLocal(Transform transform, Vector3 to, Single time)`
- `static LTDescr LeanMoveLocal(Transform transform, LTBezierPath to, Single time)`
- `static LTDescr LeanMoveLocal(Transform transform, LTSpline to, Single time)`
- `static LTDescr LeanMoveLocalX(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanMoveLocalX(Transform transform, Single to, Single time)`
- `static LTDescr LeanMoveLocalY(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanMoveLocalY(Transform transform, Single to, Single time)`
- `static LTDescr LeanMoveLocalZ(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanMoveLocalZ(Transform transform, Single to, Single time)`
- `static LTDescr LeanMoveSpline(GameObject gameObject, Vector3[] to, Single time)`
- `static LTDescr LeanMoveSpline(GameObject gameObject, LTSpline to, Single time)`
- `static LTDescr LeanMoveSpline(Transform transform, Vector3[] to, Single time)`
- `static LTDescr LeanMoveSpline(Transform transform, LTSpline to, Single time)`
- `static LTDescr LeanMoveSplineLocal(GameObject gameObject, Vector3[] to, Single time)`
- `static LTDescr LeanMoveSplineLocal(Transform transform, Vector3[] to, Single time)`
- `static LTDescr LeanMoveX(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanMoveX(Transform transform, Single to, Single time)`
- `static LTDescr LeanMoveX(RectTransform rectTransform, Single to, Single time)`
- `static LTDescr LeanMoveY(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanMoveY(Transform transform, Single to, Single time)`
- `static LTDescr LeanMoveY(RectTransform rectTransform, Single to, Single time)`
- `static LTDescr LeanMoveZ(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanMoveZ(Transform transform, Single to, Single time)`
- `static LTDescr LeanMoveZ(RectTransform rectTransform, Single to, Single time)`
- `static Void LeanPause(GameObject gameObject)`
- `static LTDescr LeanPlay(RectTransform rectTransform, Sprite[] sprites)`
- `static Void LeanResume(GameObject gameObject)`
- `static LTDescr LeanRotate(GameObject gameObject, Vector3 to, Single time)`
- `static LTDescr LeanRotate(Transform transform, Vector3 to, Single time)`
- `static LTDescr LeanRotate(RectTransform rectTransform, Vector3 to, Single time)`
- `static LTDescr LeanRotateAround(GameObject gameObject, Vector3 axis, Single add, Single time)`
- `static LTDescr LeanRotateAround(Transform transform, Vector3 axis, Single add, Single time)`
- `static LTDescr LeanRotateAround(RectTransform rectTransform, Vector3 axis, Single add, Single time)`
- `static LTDescr LeanRotateAroundLocal(GameObject gameObject, Vector3 axis, Single add, Single time)`
- `static LTDescr LeanRotateAroundLocal(Transform transform, Vector3 axis, Single add, Single time)`
- `static LTDescr LeanRotateAroundLocal(RectTransform rectTransform, Vector3 axis, Single add, Single time)`
- `static LTDescr LeanRotateX(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanRotateX(Transform transform, Single to, Single time)`
- `static LTDescr LeanRotateY(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanRotateY(Transform transform, Single to, Single time)`
- `static LTDescr LeanRotateZ(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanRotateZ(Transform transform, Single to, Single time)`
- `static LTDescr LeanScale(GameObject gameObject, Vector3 to, Single time)`
- `static LTDescr LeanScale(Transform transform, Vector3 to, Single time)`
- `static LTDescr LeanScale(RectTransform rectTransform, Vector3 to, Single time)`
- `static LTDescr LeanScaleX(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanScaleX(Transform transform, Single to, Single time)`
- `static LTDescr LeanScaleY(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanScaleY(Transform transform, Single to, Single time)`
- `static LTDescr LeanScaleZ(GameObject gameObject, Single to, Single time)`
- `static LTDescr LeanScaleZ(Transform transform, Single to, Single time)`
- `static Void LeanSetLocalPosX(Transform transform, Single val)`
- `static Void LeanSetLocalPosY(Transform transform, Single val)`
- `static Void LeanSetLocalPosZ(Transform transform, Single val)`
- `static Void LeanSetPosX(Transform transform, Single val)`
- `static Void LeanSetPosY(Transform transform, Single val)`
- `static Void LeanSetPosZ(Transform transform, Single val)`
- `static LTDescr LeanSize(RectTransform rectTransform, Vector2 to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Color from, Color to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Single from, Single to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Vector2 from, Vector2 to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Vector3 from, Vector3 to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Action`1 callOnUpdate, Single from, Single to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Action`2 callOnUpdate, Single from, Single to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Action`2 callOnUpdate, Single from, Single to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Action`1 callOnUpdate, Color from, Color to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Action`1 callOnUpdate, Vector2 from, Vector2 to, Single time)`
- `static LTDescr LeanValue(GameObject gameObject, Action`1 callOnUpdate, Vector3 from, Vector3 to, Single time)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## LeanTweenType

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static LeanTweenType animationCurve`
- `static LeanTweenType clamp`
- `static LeanTweenType easeInBack`
- `static LeanTweenType easeInBounce`
- `static LeanTweenType easeInCirc`
- `static LeanTweenType easeInCubic`
- `static LeanTweenType easeInElastic`
- `static LeanTweenType easeInExpo`
- `static LeanTweenType easeInOutBack`
- `static LeanTweenType easeInOutBounce`
- `static LeanTweenType easeInOutCirc`
- `static LeanTweenType easeInOutCubic`
- `static LeanTweenType easeInOutElastic`
- `static LeanTweenType easeInOutExpo`
- `static LeanTweenType easeInOutQuad`
- `static LeanTweenType easeInOutQuart`
- `static LeanTweenType easeInOutQuint`
- `static LeanTweenType easeInOutSine`
- `static LeanTweenType easeInQuad`
- `static LeanTweenType easeInQuart`
- `static LeanTweenType easeInQuint`
- `static LeanTweenType easeInSine`
- `static LeanTweenType easeOutBack`
- `static LeanTweenType easeOutBounce`
- `static LeanTweenType easeOutCirc`
- `static LeanTweenType easeOutCubic`
- `static LeanTweenType easeOutElastic`
- `static LeanTweenType easeOutExpo`
- `static LeanTweenType easeOutQuad`
- `static LeanTweenType easeOutQuart`
- `static LeanTweenType easeOutQuint`
- `static LeanTweenType easeOutSine`
- `static LeanTweenType easeShake`
- `static LeanTweenType easeSpring`
- `static LeanTweenType linear`
- `static LeanTweenType notUsed`
- `static LeanTweenType once`
- `static LeanTweenType pingPong`
- `static LeanTweenType punch`
- `Int32 value__`

---


## Line

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `LineData GenerateLineData()`
- `Void GenerateLineFromLineData(LineData p_lineData)`
- `Boolean IsInvalidLine()`
- `Void Setup(Color p_color, Single p_width)`
- `Void UpdateLine(Vector2 p_position)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## LineData

### Public Methods

- `Byte[] get_Color()`
- `Single[,][] get_Points()`
- `Byte get_Width()`
- `Void set_Color(Byte[] value)`
- `Void set_Points(Single[,][] value)`
- `Void set_Width(Byte value)`

### Public Properties

- `Byte[] Color` { get; set }
- `Single[,][] Points` { get; set }
- `Byte Width` { get; set }

### Public Fields

- `GameObject lineObject`

---


## LoadingWheel

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Single speed`

---


## LoadMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Browse()`
- `Void CloseLoadPanel()`
- `Void DeleteSave()`
- `Void Load()`
- `Void OpenLoadMenu()`
- `Void RenameSave()`
- `Void SetSaveChoice(FileInfo p_fileInfo)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_Base

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Dictionary`2 keyValuePairs`
- `GameLanguages language`
- `String translator`

---


## Locale_BR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_CA

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_CNS

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_CNT

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_CZ

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_DE

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_EN

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_ES

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_FI

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_FR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_GR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_IT

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_JP

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_KR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_NL

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_NO

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_PL

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_PT

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_RU

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_SE

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_TR

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Locale_UA

**Base Class:** `Locale_Base`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## LocalizationManager

### Public Methods

- `static String GetActiveLocaleTranslator()`
- `static CultureInfo GetCultureInfo()`
- `static Locale_Base GetLocale(GameLanguages p_gameLanguage)`
- `static String GetLocalizedCampaignSide(String p_countryName)`
- `static String GetLocalizedCountry(String p_countryName)`
- `static String GetLocalizedDate(DateTime p_customDateTime)`
- `static String GetLocalizedFaction(String p_factionName)`
- `static String GetLocalizedIdeology(String p_ideologyName)`
- `static String GetLocalizedScenario(String p_scenarioName)`
- `static String GetLocalizedScenario(FileInfo p_fileInfo)`
- `static String GetLocalizedShortDate(DateTime p_customDateTime)`
- `static String GetPolicyDescription(Policy p_policy)`
- `static String GetPolicyName(Policy p_policy)`
- `static GameLanguages GetSupportedLanguageCode()`
- `static Void SetActiveLocale(Locale_Base p_locale)`
- `static Void SetLanguage(GameLanguages p_gameLanguage)`
- `static String Translate(String p_key)`

### Public Properties

*No public properties*

### Public Fields

- `static Locale_Base activeLocale`

---


## LocalizationUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ManageLanguagesPanel()`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## LocalizedText

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Translate()`
- `Void Translate(TMP_FontAsset p_fontAsset)`

### Public Properties

*No public properties*

### Public Fields

- `Boolean hasTextComponentAssigned`
- `String key`
- `TextMeshProUGUI textMeshProUGUI`
- `Boolean translateOnAwake`
- `Boolean updateFontOnAwake`

---


## LTBezier

### Public Methods

- `Vector3 point(Single t)`

### Public Properties

*No public properties*

### Public Fields

- `Single length`

---


## LTBezierPath

### Public Methods

- `Single get_distance()`
- `Void gizmoDraw(Single t)`
- `Void place(Transform transform, Single ratio)`
- `Void place(Transform transform, Single ratio, Vector3 worldUp)`
- `Void place2d(Transform transform, Single ratio)`
- `Void placeLocal(Transform transform, Single ratio)`
- `Void placeLocal(Transform transform, Single ratio, Vector3 worldUp)`
- `Void placeLocal2d(Transform transform, Single ratio)`
- `Vector3 point(Single ratio)`
- `Single ratioAtPoint(Vector3 pt, Single precision)`
- `Void setPoints(Vector3[] pts_)`

### Public Properties

- `Single distance` { get }

### Public Fields

- `Single length`
- `Boolean orientToPath`
- `Boolean orientToPath2d`
- `Vector3[] pts`

---


## LTDescr

### Public Methods

- `Void callOnCompletes()`
- `LTDescr cancel(GameObject gameObject)`
- `ActionMethodDelegate get_easeInternal()`
- `Vector3 get_from()`
- `Int32 get_id()`
- `ActionMethodDelegate get_initInternal()`
- `LTDescrOptional get_optional()`
- `Vector3 get_to()`
- `Transform get_toTrans()`
- `Int32 get_uniqueId()`
- `LTDescr pause()`
- `Void reset()`
- `LTDescr resume()`
- `Void set_easeInternal(ActionMethodDelegate value)`
- `Void set_from(Vector3 value)`
- `Void set_initInternal(ActionMethodDelegate value)`
- `Void set_optional(LTDescrOptional value)`
- `Void set_to(Vector3 value)`
- `LTDescr setAlpha()`
- `LTDescr setAlphaVertex()`
- `LTDescr setAudio(Object audio)`
- `LTDescr setAxis(Vector3 axis)`
- `LTDescr setCallback()`
- `LTDescr setCallbackColor()`
- `LTDescr setCanvasAlpha()`
- `LTDescr setCanvasColor()`
- `LTDescr setCanvasGroupAlpha()`
- `LTDescr setCanvasMove()`
- `LTDescr setCanvasMoveX()`
- `LTDescr setCanvasMoveY()`
- `LTDescr setCanvasMoveZ()`
- `LTDescr setCanvasPlaySprite()`
- `LTDescr setCanvasRotateAround()`
- `LTDescr setCanvasRotateAroundLocal()`
- `LTDescr setCanvasScale()`
- `LTDescr setCanvasSizeDelta()`
- `LTDescr setColor()`
- `LTDescr setDelay(Single delay)`
- `LTDescr setDelayedSound()`
- `LTDescr setDestroyOnComplete(Boolean doesDestroy)`
- `LTDescr setDiff(Vector3 diff)`
- `LTDescr setDirection(Single direction)`
- `LTDescr setEase(LeanTweenType easeType)`
- `LTDescr setEase(AnimationCurve easeCurve)`
- `LTDescr setEaseInBack()`
- `LTDescr setEaseInBounce()`
- `LTDescr setEaseInCirc()`
- `LTDescr setEaseInCubic()`
- `LTDescr setEaseInElastic()`
- `LTDescr setEaseInExpo()`
- `LTDescr setEaseInOutBack()`
- `LTDescr setEaseInOutBounce()`
- `LTDescr setEaseInOutCirc()`
- `LTDescr setEaseInOutCubic()`
- `LTDescr setEaseInOutElastic()`
- `LTDescr setEaseInOutExpo()`
- `LTDescr setEaseInOutQuad()`
- `LTDescr setEaseInOutQuart()`
- `LTDescr setEaseInOutQuint()`
- `LTDescr setEaseInOutSine()`
- `LTDescr setEaseInQuad()`
- `LTDescr setEaseInQuart()`
- `LTDescr setEaseInQuint()`
- `LTDescr setEaseInSine()`
- `LTDescr setEaseLinear()`
- `LTDescr setEaseOutBack()`
- `LTDescr setEaseOutBounce()`
- `LTDescr setEaseOutCirc()`
- `LTDescr setEaseOutCubic()`
- `LTDescr setEaseOutElastic()`
- `LTDescr setEaseOutExpo()`
- `LTDescr setEaseOutQuad()`
- `LTDescr setEaseOutQuart()`
- `LTDescr setEaseOutQuint()`
- `LTDescr setEaseOutSine()`
- `LTDescr setEasePunch()`
- `LTDescr setEaseShake()`
- `LTDescr setEaseSpring()`
- `LTDescr setFollow()`
- `LTDescr setFrameRate(Single frameRate)`
- `LTDescr setFrom(Vector3 from)`
- `LTDescr setFrom(Single from)`
- `LTDescr setFromColor(Color col)`
- `LTDescr setGUIAlpha()`
- `LTDescr setGUIMove()`
- `LTDescr setGUIMoveMargin()`
- `LTDescr setGUIRotate()`
- `LTDescr setGUIScale()`
- `LTDescr setHasInitialized(Boolean has)`
- `LTDescr setId(UInt32 id, UInt32 global_counter)`
- `LTDescr setIgnoreTimeScale(Boolean useUnScaledTime)`
- `LTDescr setLoopClamp()`
- `LTDescr setLoopClamp(Int32 loops)`
- `LTDescr setLoopCount(Int32 loopCount)`
- `LTDescr setLoopOnce()`
- `LTDescr setLoopPingPong()`
- `LTDescr setLoopPingPong(Int32 loops)`
- `LTDescr setLoopType(LeanTweenType loopType)`
- `LTDescr setMove()`
- `LTDescr setMoveCurved()`
- `LTDescr setMoveCurvedLocal()`
- `LTDescr setMoveLocal()`
- `LTDescr setMoveLocalX()`
- `LTDescr setMoveLocalY()`
- `LTDescr setMoveLocalZ()`
- `LTDescr setMoveSpline()`
- `LTDescr setMoveSplineLocal()`
- `LTDescr setMoveToTransform()`
- `LTDescr setMoveX()`
- `LTDescr setMoveY()`
- `LTDescr setMoveZ()`
- `LTDescr setOffset(Vector3 offset)`
- `LTDescr setOnComplete(Action onComplete)`
- `LTDescr setOnComplete(Action`1 onComplete)`
- `LTDescr setOnComplete(Action`1 onComplete, Object onCompleteParam)`
- `LTDescr setOnCompleteOnRepeat(Boolean isOn)`
- `LTDescr setOnCompleteOnStart(Boolean isOn)`
- `LTDescr setOnCompleteParam(Object onCompleteParam)`
- `LTDescr setOnStart(Action onStart)`
- `LTDescr setOnUpdate(Action`1 onUpdate)`
- `LTDescr setOnUpdate(Action`1 onUpdate)`
- `LTDescr setOnUpdate(Action`2 onUpdate)`
- `LTDescr setOnUpdate(Action`2 onUpdate, Object onUpdateParam)`
- `LTDescr setOnUpdate(Action`2 onUpdate, Object onUpdateParam)`
- `LTDescr setOnUpdate(Action`1 onUpdate, Object onUpdateParam)`
- `LTDescr setOnUpdate(Action`1 onUpdate, Object onUpdateParam)`
- `LTDescr setOnUpdateColor(Action`1 onUpdate)`
- `LTDescr setOnUpdateColor(Action`2 onUpdate)`
- `LTDescr setOnUpdateObject(Action`2 onUpdate)`
- `LTDescr setOnUpdateParam(Object onUpdateParam)`
- `LTDescr setOnUpdateRatio(Action`2 onUpdate)`
- `LTDescr setOnUpdateVector2(Action`1 onUpdate)`
- `LTDescr setOnUpdateVector3(Action`1 onUpdate)`
- `LTDescr setOrientToPath(Boolean doesOrient)`
- `LTDescr setOrientToPath2d(Boolean doesOrient2d)`
- `LTDescr setOvershoot(Single overshoot)`
- `LTDescr setPassed(Single passed)`
- `LTDescr setPath(LTBezierPath path)`
- `LTDescr setPeriod(Single period)`
- `LTDescr setPoint(Vector3 point)`
- `LTDescr setRect(LTRect rect)`
- `LTDescr setRect(Rect rect)`
- `LTDescr setRect(RectTransform rect)`
- `LTDescr setRecursive(Boolean useRecursion)`
- `LTDescr setRepeat(Int32 repeat)`
- `LTDescr setRotate()`
- `LTDescr setRotateAround()`
- `LTDescr setRotateAroundLocal()`
- `LTDescr setRotateLocal()`
- `LTDescr setRotateX()`
- `LTDescr setRotateY()`
- `LTDescr setRotateZ()`
- `LTDescr setScale()`
- `LTDescr setScale(Single scale)`
- `LTDescr setScaleX()`
- `LTDescr setScaleY()`
- `LTDescr setScaleZ()`
- `LTDescr setSpeed(Single speed)`
- `LTDescr setSprites(Sprite[] sprites)`
- `LTDescr setTarget(Transform trans)`
- `LTDescr setTextAlpha()`
- `LTDescr setTextColor()`
- `LTDescr setTime(Single time)`
- `LTDescr setTo(Vector3 to)`
- `LTDescr setTo(Transform to)`
- `LTDescr setUseEstimatedTime(Boolean useEstimatedTime)`
- `LTDescr setUseFrames(Boolean useFrames)`
- `LTDescr setUseManualTime(Boolean useManualTime)`
- `LTDescr setValue3()`
- `String ToString()`
- `Boolean updateInternal()`
- `LTDescr updateNow()`

### Public Properties

- `ActionMethodDelegate easeInternal` { get; set }
- `Vector3 from` { get; set }
- `Int32 id` { get }
- `ActionMethodDelegate initInternal` { get; set }
- `LTDescrOptional optional` { get; set }
- `Vector3 to` { get; set }
- `Transform toTrans` { get }
- `Int32 uniqueId` { get }

### Public Fields

- `LTDescrOptional _optional`
- `UInt32 counter`
- `Single delay`
- `Boolean destroyOnComplete`
- `Single direction`
- `Single directionLast`
- `static Single dt`
- `EaseTypeDelegate easeMethod`
- `Boolean hasExtraOnCompletes`
- `Boolean hasInitiliazed`
- `Boolean hasPhysics`
- `Boolean hasUpdateCallback`
- `Single lastVal`
- `Int32 loopCount`
- `LeanTweenType loopType`
- `static Vector3 newVect`
- `Boolean onCompleteOnRepeat`
- `Boolean onCompleteOnStart`
- `Single overshoot`
- `Single passed`
- `Single period`
- `Single ratioPassed`
- `RawImage rawImage`
- `RectTransform rectTransform`
- `Single scale`
- `Single speed`
- `SpriteRenderer spriteRen`
- `Sprite[] sprites`
- `Single time`
- `Boolean toggle`
- `Transform trans`
- `TweenAction type`
- `Image uiImage`
- `Text uiText`
- `Boolean useEstimatedTime`
- `Boolean useFrames`
- `Boolean useManualTime`
- `Boolean useRecursion`
- `Boolean usesNormalDt`
- `static Single val`

---


## LTDescrOptional

### Public Methods

- `Void callOnUpdate(Single val, Single ratioPassed)`
- `Vector3 get_axis()`
- `Single get_lastVal()`
- `LTRect get_ltRect()`
- `Action get_onComplete()`
- `Action`1 get_onCompleteObject()`
- `Object get_onCompleteParam()`
- `Action get_onStart()`
- `Action`1 get_onUpdateColor()`
- `Action`2 get_onUpdateColorObject()`
- `Action`1 get_onUpdateFloat()`
- `Action`2 get_onUpdateFloatObject()`
- `Action`2 get_onUpdateFloatRatio()`
- `Object get_onUpdateParam()`
- `Action`1 get_onUpdateVector2()`
- `Action`1 get_onUpdateVector3()`
- `Action`2 get_onUpdateVector3Object()`
- `Quaternion get_origRotation()`
- `LTBezierPath get_path()`
- `Vector3 get_point()`
- `LTSpline get_spline()`
- `Transform get_toTrans()`
- `Void reset()`
- `Void set_axis(Vector3 value)`
- `Void set_lastVal(Single value)`
- `Void set_ltRect(LTRect value)`
- `Void set_onComplete(Action value)`
- `Void set_onCompleteObject(Action`1 value)`
- `Void set_onCompleteParam(Object value)`
- `Void set_onStart(Action value)`
- `Void set_onUpdateColor(Action`1 value)`
- `Void set_onUpdateColorObject(Action`2 value)`
- `Void set_onUpdateFloat(Action`1 value)`
- `Void set_onUpdateFloatObject(Action`2 value)`
- `Void set_onUpdateFloatRatio(Action`2 value)`
- `Void set_onUpdateParam(Object value)`
- `Void set_onUpdateVector2(Action`1 value)`
- `Void set_onUpdateVector3(Action`1 value)`
- `Void set_onUpdateVector3Object(Action`2 value)`
- `Void set_origRotation(Quaternion value)`
- `Void set_path(LTBezierPath value)`
- `Void set_point(Vector3 value)`
- `Void set_spline(LTSpline value)`
- `Void set_toTrans(Transform value)`

### Public Properties

- `Vector3 axis` { get; set }
- `Single lastVal` { get; set }
- `LTRect ltRect` { get; set }
- `Action onComplete` { get; set }
- `Action`1 onCompleteObject` { get; set }
- `Object onCompleteParam` { get; set }
- `Action onStart` { get; set }
- `Action`1 onUpdateColor` { get; set }
- `Action`2 onUpdateColorObject` { get; set }
- `Action`1 onUpdateFloat` { get; set }
- `Action`2 onUpdateFloatObject` { get; set }
- `Action`2 onUpdateFloatRatio` { get; set }
- `Object onUpdateParam` { get; set }
- `Action`1 onUpdateVector2` { get; set }
- `Action`1 onUpdateVector3` { get; set }
- `Action`2 onUpdateVector3Object` { get; set }
- `Quaternion origRotation` { get; set }
- `LTBezierPath path` { get; set }
- `Vector3 point` { get; set }
- `LTSpline spline` { get; set }
- `Transform toTrans` { get; set }

### Public Fields

- `AnimationCurve animationCurve`
- `Color color`
- `Int32 initFrameCount`

---


## LTEvent

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Object data`
- `Int32 id`

---


## LTGUI

### Public Methods

- `static Boolean checkOnScreen(Rect rect)`
- `static Boolean checkWithinRect(Vector2 vec2, Rect rect)`
- `static Void destroy(Int32 id)`
- `static Void destroyAll(Int32 depth)`
- `static LTRect element(LTRect rect, Int32 depth)`
- `static Vector2 firstTouch()`
- `static Boolean hasNoOverlap(Rect rect, Int32 depth)`
- `static Void init()`
- `static Void initRectCheck()`
- `static LTRect label(Rect rect, String label, Int32 depth)`
- `static LTRect label(LTRect rect, String label, Int32 depth)`
- `static Boolean pressedWithinRect(Rect rect)`
- `static Void reset()`
- `static LTRect texture(Rect rect, Texture texture, Int32 depth)`
- `static LTRect texture(LTRect rect, Texture texture, Int32 depth)`
- `static Void update(Int32 updateLevel)`

### Public Properties

*No public properties*

### Public Fields

- `static Int32 BUTTONS_MAX`
- `static Int32 RECT_LEVELS`
- `static Int32 RECTS_PER_LEVEL`

---


## LTRect

### Public Methods

- `Boolean get_hasInitiliazed()`
- `Single get_height()`
- `Int32 get_id()`
- `Rect get_rect()`
- `Single get_width()`
- `Single get_x()`
- `Single get_y()`
- `Void reset()`
- `Void resetForRotation()`
- `Void set_height(Single value)`
- `Void set_rect(Rect value)`
- `Void set_width(Single value)`
- `Void set_x(Single value)`
- `Void set_y(Single value)`
- `LTRect setAlpha(Single alpha)`
- `LTRect setColor(Color color)`
- `LTRect setFontScaleToFit(Boolean fontScaleToFit)`
- `Void setId(Int32 id, Int32 counter)`
- `LTRect setLabel(String str)`
- `LTRect setSizeByHeight(Boolean sizeByHeight)`
- `LTRect setStyle(GUIStyle style)`
- `LTRect setUseSimpleScale(Boolean useSimpleScale, Rect relativeRect)`
- `LTRect setUseSimpleScale(Boolean useSimpleScale)`
- `String ToString()`

### Public Properties

- `Boolean hasInitiliazed` { get }
- `Single height` { get; set }
- `Int32 id` { get }
- `Rect rect` { get; set }
- `Single width` { get; set }
- `Single x` { get; set }
- `Single y` { get; set }

### Public Fields

- `Rect _rect`
- `Single alpha`
- `Boolean alphaEnabled`
- `Color color`
- `static Boolean colorTouched`
- `Int32 counter`
- `Boolean fontScaleToFit`
- `String labelStr`
- `Vector2 margin`
- `Vector2 pivot`
- `Rect relativeRect`
- `Boolean rotateEnabled`
- `Boolean rotateFinished`
- `Single rotation`
- `Boolean sizeByHeight`
- `GUIStyle style`
- `Texture texture`
- `Element_Type type`
- `Boolean useColor`
- `Boolean useSimpleScale`

---


## LTSeq

### Public Methods

- `LTSeq append(Single delay)`
- `LTSeq append(Action callback)`
- `LTSeq append(Action`1 callback, Object obj)`
- `LTSeq append(GameObject gameObject, Action callback)`
- `LTSeq append(GameObject gameObject, Action`1 callback, Object obj)`
- `LTSeq append(LTDescr tween)`
- `Int32 get_id()`
- `Void init(UInt32 id, UInt32 global_counter)`
- `LTSeq insert(LTDescr tween)`
- `Void reset()`
- `LTSeq reverse()`
- `LTSeq setScale(Single timeScale)`

### Public Properties

- `Int32 id` { get }

### Public Fields

- `UInt32 counter`
- `LTSeq current`
- `LTSeq previous`
- `Single timeScale`
- `Boolean toggle`
- `Single totalDelay`
- `LTDescr tween`

---


## LTSpline

### Public Methods

- `Void drawGizmo(Color color)`
- `static Void drawGizmo(Transform[] arr, Color color)`
- `static Void drawLine(Transform[] arr, Single width, Color color)`
- `Void drawLinesGLLines(Material outlineMaterial, Color color, Single width)`
- `Vector3[] generateVectors()`
- `Void gizmoDraw(Single t)`
- `Vector3 interp(Single t)`
- `Vector3 map(Single u)`
- `Void place(Transform transform, Single ratio)`
- `Void place(Transform transform, Single ratio, Vector3 worldUp)`
- `Void place2d(Transform transform, Single ratio)`
- `Void placeLocal(Transform transform, Single ratio)`
- `Void placeLocal(Transform transform, Single ratio, Vector3 worldUp)`
- `Void placeLocal2d(Transform transform, Single ratio)`
- `Vector3 point(Single ratio)`
- `Single ratioAtPoint(Vector3 pt)`

### Public Properties

*No public properties*

### Public Fields

- `Boolean constantSpeed`
- `Single distance`
- `static Int32 DISTANCE_COUNT`
- `Boolean orientToPath`
- `Boolean orientToPath2d`
- `Vector3[] pts`
- `Vector3[] ptsAdj`
- `Int32 ptsAdjLength`
- `static Int32 SUBLINE_COUNT`

---


## LTUtility

### Public Methods

- `static Vector3[] reverse(Vector3[] arr)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## MainMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Android()`
- `Void BeastsOfSteel()`
- `Void ChooseMenu(String value)`
- `Void CloseAllPanel()`
- `Void ContinueLastSave()`
- `Void Discord()`
- `Void Donate()`
- `Void Facebook()`
- `Void GameplayTutorialVideo()`
- `static Void GetAllCustomUserMadeMaps(Boolean p_includeCampaigns)`
- `Void Instagram()`
- `Void iOS()`
- `Void MapEditorTutorialVideo()`
- `Void OpenCampaignPanel()`
- `Void OpenCountryEditorPanel()`
- `Void OpenGuide()`
- `Void OpenHeroesEditorPanel()`
- `Void OpenLeaderboardPanel()`
- `Void OpenMapEditorPanel()`
- `Void OpenMapGeneratorPanel()`
- `Void OpenModManagerPanel()`
- `Void OpenMultiplayerPanel()`
- `Void OpenQuickGamePanel()`
- `Void OpenSettings()`
- `Void OpenTileEditorPanel()`
- `Void OpenUnitEditorPanel()`
- `Void Quit()`
- `Void Reddit()`
- `Void Youtube()`

### Public Properties

*No public properties*

### Public Fields

- `Sprite baseWallapper_sprite`
- `static Color blackColor`
- `GameObject continue_button`
- `GameObject countryEditor_Panel`
- `GameObject demo_text`
- `GameObject editors_section`
- `static Color fogOfWarColor`
- `static GameSettings gameSettingsBackup`
- `TextMeshProUGUI gameVersion_text`
- `static Color greenColor`
- `static Color greyColor`
- `GameObject heroesEditor_Panel`
- `static MainMenu instance`
- `static Boolean isDemo`
- `static Boolean isEditor`
- `static Boolean isLoadedGame`
- `static Boolean isMainMenu`
- `static Boolean isTablet`
- `GameObject languageSelection_panel`
- `GameObject leaderboardGO_panel`
- `static List`1 listOfAllCampaigns`
- `static List`1 listOfAllMapsQuickGame`
- `static List`1 listOfPlayersToBeSavedBetweenCampaign`
- `LoadMenu loadGO`
- `GameObject loading_Panel`
- `Canvas mainCanvas`
- `GameObject mapEditor_Panel`
- `MapEditorMenu mapEditorMenu`
- `GameObject mapgGenerator_Panel`
- `GameObject menu_section`
- `GameObject modManager_Panel`
- `GameObject mods_Panel`
- `GameObject multiplayer_Panel`
- `static Boolean needsToLoadMultiplayerMenu`
- `GameObject newCampaignPanel`
- `GameObject play_section`
- `static Color redColor`
- `GameObject saveLoad_Panel`
- `static FileInfo selectedMap`
- `GameObject settings_Panel`
- `static Stopwatch stopwatchAttackMovement`
- `GameObject tileEditor_Panel`
- `GameObject tooltip`
- `StandaloneScenariosMenu twoPlayers`
- `GameObject twoPlayers_Panel`
- `Transform UI_parent`
- `GameObject unitEditor_Panel`
- `Image wallpaper_Image`
- `static Color yellowColor`

---


## ManpowerTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

- `TextMeshProUGUI airForces_text`
- `TextMeshProUGUI availableManpower_text`
- `TextMeshProUGUI currentManpower_text`
- `TextMeshProUGUI groundForces_text`
- `TextMeshProUGUI maxManpower_text`
- `TextMeshProUGUI navalForces_text`

---


## Map

### Public Methods

- `Void CheckIncorrectEvents()`
- `Void EventTriggerVPLoss(Tile p_tile, Player p_playerCapturing, Player p_playerLosing)`
- `Boolean FindTile(Int32 p_posX, Int32 p_posY, Tile& o_tile)`
- `Void GenerateDefaultWeatherTable()`
- `Boolean get_AllowSnowInWinter()`
- `String get_BackUpPlayerPlaying()`
- `Int32 get_BaseCoreUnitValue()`
- `Byte get_BaseWeatherPredictionAccuracy()`
- `Boolean get_CircularMap()`
- `Single get_CreationTotalTime()`
- `Byte get_DailyWeatherPredictionAccuracyLoss()`
- `String get_DamageToWinFaction()`
- `DateTime get_Date()`
- `Boolean get_DisableManpower()`
- `Boolean get_DisablePurchases()`
- `Boolean get_DisableResearch()`
- `Boolean get_DisableUpkeep()`
- `Boolean get_DisableWeather()`
- `Int32 get_EventIDs()`
- `List`1 get_Events()`
- `String get_FileName()`
- `String get_ID()`
- `Boolean get_InitializedManpower()`
- `Boolean get_IsCampaign()`
- `Boolean get_IsLastScenario()`
- `Boolean get_IsOfficial()`
- `Boolean get_IsOnlineGame()`
- `Boolean get_IsTutorial()`
- `Boolean get_IsWinter()`
- `Byte get_MaxTurnsPrediction()`
- `String get_NextMap()`
- `String get_NextMap2()`
- `String get_NextMap2Defeat()`
- `String get_NextMapDefeat()`
- `List`1 get_Notifications()`
- `Int32 get_NumberOfDamageToWin()`
- `Int32 get_NumberOfDaysThatGoesByPerTurn()`
- `Int32 get_NumberOfNewCoreUnitPerRank()`
- `Int32 get_NumberOfTilesToBombToWin()`
- `Int32 get_NumberOfTurnsToWin()`
- `String get_OriginalCampaignCountry()`
- `Single get_OverlayOpacity()`
- `String get_OverlayPath()`
- `Single get_OverlayPosX()`
- `Single get_OverlayPosY()`
- `Single get_OverlayScale()`
- `String get_Player1()`
- `String get_Player2()`
- `String get_ScenarioDefeatText()`
- `String get_ScenarioDescription()`
- `String get_ScenarioName()`
- `String get_ScenarioVictoryText()`
- `Int32 get_SizeX()`
- `Int32 get_SizeY()`
- `Tile[,] get_TilesTable()`
- `String get_TilesToBombFaction()`
- `Single get_timePlayed()`
- `Int32 get_turnCount()`
- `Byte[] get_WeatherChanceTable()`
- `Int32 get_WeatherSeed()`
- `Int32 get_XPperMajorVP()`
- `Int32 get_XPperNormalVP()`
- `Int32 get_XPPerScenario()`
- `Int32 get_XPperSecondaryVP()`
- `WeatherPredictionData GetCurrentTurnWeatherPredictionData()`
- `Int32 GetNewEventID()`
- `WeatherPredictionData GetNextTurnWeatherPredictionData()`
- `List`1 GetWeatherPredictionData(ForecastType p_forecastType)`
- `Boolean IsDateWinter(DateTime p_dateTime)`
- `Boolean IsPlayerOnTheMap(Player p_player)`
- `Void RemoveEvent(Int32 eventID)`
- `Void set_AllowSnowInWinter(Boolean value)`
- `Void set_BackUpPlayerPlaying(String value)`
- `Void set_BaseCoreUnitValue(Int32 value)`
- `Void set_BaseWeatherPredictionAccuracy(Byte value)`
- `Void set_CircularMap(Boolean value)`
- `Void set_CreationTotalTime(Single value)`
- `Void set_DailyWeatherPredictionAccuracyLoss(Byte value)`
- `Void set_DamageToWinFaction(String value)`
- `Void set_Date(DateTime value)`
- `Void set_DisableManpower(Boolean value)`
- `Void set_DisablePurchases(Boolean value)`
- `Void set_DisableResearch(Boolean value)`
- `Void set_DisableUpkeep(Boolean value)`
- `Void set_DisableWeather(Boolean value)`
- `Void set_EventIDs(Int32 value)`
- `Void set_Events(List`1 value)`
- `Void set_FileName(String value)`
- `Void set_ID(String value)`
- `Void set_InitializedManpower(Boolean value)`
- `Void set_IsCampaign(Boolean value)`
- `Void set_IsLastScenario(Boolean value)`
- `Void set_IsOfficial(Boolean value)`
- `Void set_IsOnlineGame(Boolean value)`
- `Void set_IsTutorial(Boolean value)`
- `Void set_IsWinter(Boolean value)`
- `Void set_MaxTurnsPrediction(Byte value)`
- `Void set_NextMap(String value)`
- `Void set_NextMap2(String value)`
- `Void set_NextMap2Defeat(String value)`
- `Void set_NextMapDefeat(String value)`
- `Void set_Notifications(List`1 value)`
- `Void set_NumberOfDamageToWin(Int32 value)`
- `Void set_NumberOfDaysThatGoesByPerTurn(Int32 value)`
- `Void set_NumberOfNewCoreUnitPerRank(Int32 value)`
- `Void set_NumberOfTilesToBombToWin(Int32 value)`
- `Void set_NumberOfTurnsToWin(Int32 value)`
- `Void set_OriginalCampaignCountry(String value)`
- `Void set_OverlayOpacity(Single value)`
- `Void set_OverlayPath(String value)`
- `Void set_OverlayPosX(Single value)`
- `Void set_OverlayPosY(Single value)`
- `Void set_OverlayScale(Single value)`
- `Void set_Player1(String value)`
- `Void set_Player2(String value)`
- `Void set_ScenarioDefeatText(String value)`
- `Void set_ScenarioDescription(String value)`
- `Void set_ScenarioName(String value)`
- `Void set_ScenarioVictoryText(String value)`
- `Void set_SizeX(Int32 value)`
- `Void set_SizeY(Int32 value)`
- `Void set_TilesTable(Tile[,] value)`
- `Void set_TilesToBombFaction(String value)`
- `Void set_timePlayed(Single value)`
- `Void set_turnCount(Int32 value)`
- `Void set_WeatherChanceTable(Byte[] value)`
- `Void set_WeatherSeed(Int32 value)`
- `Void set_XPperMajorVP(Int32 value)`
- `Void set_XPperNormalVP(Int32 value)`
- `Void set_XPPerScenario(Int32 value)`
- `Void set_XPperSecondaryVP(Int32 value)`
- `Void SetIsWinterBasedOnCurrentDate()`

### Public Properties

- `Boolean AllowSnowInWinter` { get; set }
- `String BackUpPlayerPlaying` { get; set }
- `Int32 BaseCoreUnitValue` { get; set }
- `Byte BaseWeatherPredictionAccuracy` { get; set }
- `Boolean CircularMap` { get; set }
- `Single CreationTotalTime` { get; set }
- `Byte DailyWeatherPredictionAccuracyLoss` { get; set }
- `String DamageToWinFaction` { get; set }
- `DateTime Date` { get; set }
- `Boolean DisableManpower` { get; set }
- `Boolean DisablePurchases` { get; set }
- `Boolean DisableResearch` { get; set }
- `Boolean DisableUpkeep` { get; set }
- `Boolean DisableWeather` { get; set }
- `Int32 EventIDs` { get; set }
- `List`1 Events` { get; set }
- `String FileName` { get; set }
- `String ID` { get; set }
- `Boolean InitializedManpower` { get; set }
- `Boolean IsCampaign` { get; set }
- `Boolean IsLastScenario` { get; set }
- `Boolean IsOfficial` { get; set }
- `Boolean IsOnlineGame` { get; set }
- `Boolean IsTutorial` { get; set }
- `Boolean IsWinter` { get; set }
- `Byte MaxTurnsPrediction` { get; set }
- `String NextMap` { get; set }
- `String NextMap2` { get; set }
- `String NextMap2Defeat` { get; set }
- `String NextMapDefeat` { get; set }
- `List`1 Notifications` { get; set }
- `Int32 NumberOfDamageToWin` { get; set }
- `Int32 NumberOfDaysThatGoesByPerTurn` { get; set }
- `Int32 NumberOfNewCoreUnitPerRank` { get; set }
- `Int32 NumberOfTilesToBombToWin` { get; set }
- `Int32 NumberOfTurnsToWin` { get; set }
- `String OriginalCampaignCountry` { get; set }
- `Single OverlayOpacity` { get; set }
- `String OverlayPath` { get; set }
- `Single OverlayPosX` { get; set }
- `Single OverlayPosY` { get; set }
- `Single OverlayScale` { get; set }
- `String Player1` { get; set }
- `String Player2` { get; set }
- `String ScenarioDefeatText` { get; set }
- `String ScenarioDescription` { get; set }
- `String ScenarioName` { get; set }
- `String ScenarioVictoryText` { get; set }
- `Int32 SizeX` { get; set }
- `Int32 SizeY` { get; set }
- `Tile[,] TilesTable` { get; set }
- `String TilesToBombFaction` { get; set }
- `Single timePlayed` { get; set }
- `Int32 turnCount` { get; set }
- `Byte[] WeatherChanceTable` { get; set }
- `Int32 WeatherSeed` { get; set }
- `Int32 XPperMajorVP` { get; set }
- `Int32 XPperNormalVP` { get; set }
- `Int32 XPPerScenario` { get; set }
- `Int32 XPperSecondaryVP` { get; set }

### Public Fields

- `Dictionary`2 listOfUnitsThatNeedToBeKilled`
- `Dictionary`2 listOfVPThatNeedsToBeHeld`
- `Dictionary`2 majorVPsPerFaction`

---


## MapEditorGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AddNewPlayer()`
- `Void AddTilesDOWN()`
- `Void AddTilesLEFT()`
- `Void AddTilesRIGHT()`
- `Void AddTilesUP()`
- `Void ChangeEntrenchmentLevelOnScenarioStart()`
- `Void ChangeHPmodifierOnScenarioStart()`
- `Void ChangePlayerFixedIncome(TMP_InputField inputField, Player p_player)`
- `Void ChangePlayerHQpoints(TMP_InputField inputField, Player p_player)`
- `Void ChangeSeasonOfAllTilesOnTheMap()`
- `Void ChangeTileSeason()`
- `Void ChangeUnitLevel()`
- `Void CheckMapReadyToPlay()`
- `Void CloseErrorPanel()`
- `Void CloseScenarioDescriptionMenu()`
- `Void CountCitiesOnTheMap()`
- `Void GenerateBorders()`
- `Void GenerateRoadsOnMap()`
- `Void ManageCampaignWindows()`
- `Void ManageEventsPanel_Button()`
- `Void ManageIsAlwaysWinter()`
- `Void ManageMapSettingsMenu()`
- `Void ManageSaveAsPanel()`
- `Void ManageScenarioDescription(String p_value)`
- `Void ManageStoreMenu()`
- `Void ManageUI()`
- `Void ManageWeatherPanel()`
- `Void PlaytestMap()`
- `Void QuitToMainMenu()`
- `Void RandomizeTerrain()`
- `Void RefreshScenarioTextValues()`
- `Void RemoveAllUnits_Button(Boolean p_fromVPsonly)`
- `Void RemovePlayer(Player p_player)`
- `Void RemoveTilesDOWN()`
- `Void RemoveTilesLEFT()`
- `Void RemoveTilesRIGHT()`
- `Void RemoveTilesUP()`
- `Void RenameSelectedUnit()`
- `Void ResetSaveToPlayableMap()`
- `Void ResetTerrain()`
- `Void SaveMapAs()`
- `Void SaveTheMap()`
- `Void SelectPlayer(Player p_player)`
- `Void SelectTile(Tile tile)`
- `Void SendUnitBackIntoReserve()`
- `Void SetBadWeatherMonthChance(TMP_InputField p_TMP_InputField)`
- `Void SetBaseCoreUnitValue()`
- `Void SetCircularMap_Toggle()`
- `Void SetCityName()`
- `Void SetCountryForPlayer(Player p_player, TMP_Dropdown p_Dropdown)`
- `Void SetDamageToWin()`
- `Void SetDayForMap()`
- `Void SetDisabledWeather_Toggle()`
- `Void SetDisableManpower_Toggle()`
- `Void SetDisablePurchases_Toggle()`
- `Void SetDisableResearch_Toggle()`
- `Void SetDisableUpkeep_Toggle()`
- `Void SetEditorIncomeOverwrite()`
- `Void SetEditorManpowerOverwrite()`
- `Void SetFactionDamageToWin(TMP_Dropdown p_dropdown)`
- `Void SetFactionTilesToBombToWin(TMP_Dropdown p_dropdown)`
- `Void SetFilter()`
- `Void SetIsCampaign_Toggle()`
- `Void SetIsOfficial_Toggle()`
- `Void SetMapYear()`
- `Void SetMoneyAmount(TMP_InputField inputField, Player player)`
- `Void SetMonthForMap()`
- `Void SetNextMap1()`
- `Void SetNextMap1Defeat()`
- `Void SetNextMap2()`
- `Void SetNextMap2Defeat()`
- `Void SetNumberOfDaysThatGoByPerTurn()`
- `Void SetNumberOfTurnsToWin()`
- `Void SetOriginalOwnerVP()`
- `Void SetOwner()`
- `Void SetPerRankCoreUnit()`
- `Void SetPlayerAsComputer(Player p_player)`
- `Void SetPlaysFirst(Player p_player)`
- `Void SetScenarioNameAndDescription()`
- `Void SetSnowInWinter_Toggle()`
- `Void SetTilesToBombToWin()`
- `Void SetWeatherBasePredictionAccuracy(TMP_InputField p_TMP_InputField)`
- `Void SetWeatherMaxTurnsPrediction(TMP_InputField p_TMP_InputField)`
- `Void SetWeatherPredictionDailyAccuracyLoss(TMP_InputField p_TMP_InputField)`
- `Void SetXPendScenario()`
- `Void SetXPSecondaryObjectives()`
- `Void ShowHideAllUnitsOnTheMap()`
- `Void ShowPlayerInfos(Player p_player)`
- `Void SpawnUnitsOnMap(Boolean p_garrisonOnly)`

### Public Properties

*No public properties*

### Public Fields

- `PlayerSlotMapEditor _playerSlot_prefab`
- `GameObject addLevelButton`
- `TMP_InputField baseCoreUnitsValue_InputField`
- `GameObject brush`
- `Image brush_image`
- `Sprite[] brusheTypes_sprites`
- `static Int32 brushSize`
- `TextMeshProUGUI brushSize_Text`
- `GameObject campaignBox`
- `Toggle circularMap_toggle`
- `Sprite city_DesertSprite`
- `Sprite city_SummerSprite`
- `Sprite city_WinterSprite`
- `GameObject cityGO`
- `GameObject cityName_Holder`
- `TMP_InputField cityName_InputField`
- `Sprite coast_DesertSprite`
- `Sprite coast_SummerSprite`
- `Sprite coast_WinterSprite`
- `GameObject coastGO`
- `TMP_InputField coreUnitsPerRank_InputField`
- `String country`
- `TMP_InputField customHealthForUnit_Inputfield`
- `TMP_InputField customIncome_Inputfield`
- `TMP_InputField customManpower_Inputfield`
- `TMP_InputField customNameForUnit_Inputfield`
- `TMP_Dropdown damageToWin_dropdown`
- `TMP_InputField damageToWin_InputField`
- `TMP_InputField dayMap_InputField`
- `Sprite defense_DesertSprite`
- `Sprite defense_SummerSprite`
- `Sprite defense_WinterSprite`
- `GameObject defenseGO`
- `GameObject devMenuPanel`
- `Toggle disableManpower`
- `Toggle disablePurchases`
- `Toggle disableResearch`
- `Toggle disableUpkeep`
- `TMP_InputField entrenchmentOnStart_Inputfield`
- `TextMeshProUGUI error_Description`
- `GameObject errorPanel`
- `EventPanelGO events_panel`
- `Transform eventsParent`
- `static String filter`
- `Sprite forest_SummerSprite`
- `Sprite forest_WinterSprite`
- `GameObject forestGO`
- `Sprite harbour_DesertSprite`
- `Sprite harbour_SummerSprite`
- `Sprite harbour_WinterSprite`
- `GameObject harbourGO`
- `TMP_InputField inputDaysThatGoByPerTurn_InputField`
- `static MapEditorGO instance`
- `static Boolean isAlwaysWinter`
- `Toggle isCampaign`
- `Toggle isOfficial`
- `Sprite junction_SummerSprite`
- `Sprite junction_WinterSprite`
- `GameObject junctionGO`
- `Transform listOfPlayersContainer`
- `static Map mapCopy`
- `TextMeshProUGUI mapCreationTime_text`
- `TextMeshProUGUI mapSize_Text`
- `TMP_InputField monthMap_InputField`
- `TMP_InputField newSizeDOWN`
- `TMP_InputField newSizeLEFT`
- `TMP_InputField newSizeRIGHT`
- `TMP_InputField newSizeUP`
- `TMP_InputField nextMapDefeat1_inputfield`
- `TMP_InputField nextMapDefeat2_inputfield`
- `TMP_InputField nextMapVictory1_inputfield`
- `TMP_InputField nextMapVictory2_inputfield`
- `GameObject noAmmoTurn1Button`
- `GameObject noEntrenchmentTurn1Button`
- `TMP_InputField numberOfTurnsToWin_InputField`
- `TMP_InputField originalOwnerCountry_inputfield`
- `static PaintMode paintMode`
- `GameObject parent`
- `TMP_Dropdown playerListScenarioTexts_dropdown`
- `static GameObject previousTile`
- `static String previousTileRoad`
- `Sprite RailroadBridge_DesertSprite`
- `Sprite RailroadBridge_SummerSprite`
- `Sprite RailroadBridge_WinterSprite`
- `GameObject RailroadBridgeGO`
- `Sprite railways_DesertSprite`
- `Sprite railways_SummerSprite`
- `Sprite railways_WinterSprite`
- `GameObject railwaysGO`
- `GameObject relocateUnitButton`
- `GameObject removeLevelButton`
- `GameObject removeUnitButton`
- `GameObject reserve_Panel`
- `GameObject rightClick_Panel`
- `Sprite river_DesertSprite`
- `Sprite river_SummerSprite`
- `Sprite river_WinterSprite`
- `GameObject riverGO`
- `Sprite road_DesertSprite`
- `Sprite road_SummerSprite`
- `Sprite road_WinterSprite`
- `Sprite roadBridge_DesertSprite`
- `Sprite roadBridge_SummerSprite`
- `Sprite roadBridge_WinterSprite`
- `GameObject roadBridgeGO`
- `GameObject roadGO`
- `TMP_InputField saveAs_inputField`
- `GameObject saveAsPanel`
- `TMP_InputField scenarioDescription_InputField`
- `GameObject scenarioDescription_panel`
- `TMP_InputField scenarioName_InputField`
- `GameObject scenarioSettings_Panel`
- `static String season`
- `static GameObject selectedPlacedTile`
- `static Tile selectedTile`
- `TextMeshProUGUI selectedTileCoordinates_text`
- `static GameObject selectedTileGO`
- `GameObject selectedTileIcon`
- `static Unit selectedUnitForRename`
- `static Boolean setTileValueBoolean`
- `GameObject setVpToBeHeldButton`
- `Toggle snowInWinter_toggle`
- `GameObject store_Panel`
- `TileEditorGO[,] TableOfAllTiles`
- `List`1 teamsDropdowns`
- `Sprite terrain_DesertSprite`
- `Sprite terrain_SummerSprite`
- `Sprite terrain_WinterSprite`
- `GameObject terrainGO`
- `GameObject tileChoiceContainer`
- `TileEditorGO tilePrefab`
- `TMP_Dropdown tilesToBombToWin_dropdown`
- `TMP_InputField tilesToBombToWin_InputField`
- `GameObject tooltip`
- `GameObject UI`
- `TMP_InputField unitID_Inputfield`
- `TMP_InputField unitLevelOnStart_Inputfield`
- `Transform unitParent`
- `GameObject unitPrefab`
- `Toggle weatherDisabled_toggle`
- `TMP_InputField XPperScenario_InputField`
- `TMP_InputField XPperSecondaryVP_InputField`
- `TMP_InputField yearMap_InputField`

---


## MapEditorMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Back()`
- `Void BrowseMaps()`
- `Void ConfirmDeleteMap()`
- `Void DeleteMap()`
- `Void ModifyMap()`
- `Void NewMap()`
- `Void RefreshListOfMaps()`

### Public Properties

*No public properties*

### Public Fields

- `Transform container`
- `static Boolean isLoadedMapEditor`
- `static String mapName`
- `static Int32 sizeX`
- `static Int32 sizeY`

---


## MapGeneratorGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ChangeAmountOfPlayers()`
- `Void ChangeBocageAmountSlider()`
- `Void ChangeCitiesAmountSlider()`
- `Void ChangeDesertRocksAmountSlider()`
- `Void ChangeDunesAmountSlider()`
- `Void ChangeHillsAmountSlider()`
- `Void ChangeMarshAmountSlider()`
- `Void ChangeMountainAmountSlider()`
- `Void ChangeThickForestAmountSlider()`
- `Void ChangeThinForestAmountSlider()`
- `Void ChangeWaterAmountSlider()`
- `Void ManagePanel()`
- `Void RefreshPlayersSlotUI()`
- `Void SelectCountryForPlayer()`
- `Void SelectFactionForPlayer()`
- `Void SetAIForAll()`
- `Void SetHorizontalLayout()`
- `Void SetIsAIForPlayer()`
- `Void SetPlaysFirstForPlayer()`
- `Void SetRandomCountryForAll()`
- `Void SetVerticalLayout()`
- `Void StartGame()`
- `Void StartGeneratingTheMap()`

### Public Properties

*No public properties*

### Public Fields

- `Transform parent`
- `GameObject slotPrefab`

---


## MapGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `static GameStates CheckEndOfScenarioHoldingAllMajorVPs()`
- `static GameStates CheckEndOfScenarioHoldingAllVPs()`
- `static GameStates CheckEndOfScenarioHoldingVPs()`
- `static GameStates CheckEndOfScenarioTargetsUnits()`
- `static Void CheckIfEndOfScenario()`
- `Void ClearCommanderTiles()`
- `static Void ClearTargetedUnits()`
- `static EndGameResults ConvertGameStateInGameResult(GameStates p_gameState)`
- `Void DestroyPotentialTilesAboveMap()`
- `Void DrawBordersOnMap()`
- `static GameStates HasReachedMaxDamageToDeal()`
- `static GameStates HasReachedMaxTilesToBomb()`
- `static GameStates HasReachedTurnLimit()`
- `static Boolean IsThereACertainTileAround(TileGO p_tileGO, String p_type, Boolean p_compareToGivenPlayer)`
- `static Void PlaceFogOfWarEverywhere()`
- `static Void RefreshAlliancesAndWarsForCurrentPlayers()`
- `Void RefreshPoliticalMap(Boolean p_overwriteBeingDisabled)`
- `static Void RemoveBordersFOW()`
- `static Void RemoveFogOfWarAroundUnits()`
- `static Void RemoveFogOfWarAroundVictoryPoint()`
- `static Void RemovePlayerSavedFOW()`
- `Void ShowPotentialtileColor(Boolean isDeployment)`
- `Void StartScenario()`
- `Void TogglePoliticalMap()`
- `Void UnselectUnit()`
- `Void UpdateCountryNamesOpacity()`
- `Void UpdateVpsList()`

### Public Properties

*No public properties*

### Public Fields

- `TMP_Text _politicalCountryName_textmesh`
- `PoliticalHexRenderer _politicalHexRenderer_prefab`
- `TileGO baseTilePrefab`
- `Transform commandersParent`
- `static Single DISTANCE_BETWEEN_TWO_TILES`
- `static Boolean INeedToMakeABackupOfTheCampaign`
- `static MapGO instance`
- `static Boolean IsAIOnly`
- `static Boolean isOver`
- `GameObject leftSideUI_Panel`
- `static List`1 listOfAllBridgesOnTheMap`
- `static List`1 listOfAllGeneralsOnTheMap`
- `List`1 listOfAllUnits`
- `static List`1 listOfAllVps`
- `static List`1 listOfCurrentPlayerVPs`
- `static List`1 listOfPotentialTilesAboveTheMap`
- `static HashSet`1 listOfSpawnableTiles`
- `static List`1 listOfTargetedUnit`
- `GameObject moreStatsPanel`
- `static Int32 numberOfCapturedMajorVPByFaction`
- `static Int32 numberOfMajorVP`
- `static Player onSaveLoadedHumanPlayer`
- `GameObject otherUnitStatsPanel`
- `GameObject panelAllStatsOtherUnit`
- `GameObject panelAllStatsSelectedUnit`
- `Transform politicalMap_parent`
- `GameObject potentialDamagePanel`
- `Transform potentialTiles_parent`
- `static HashSet`1 radarDetections`
- `static UnitGO selectedUnitGO`
- `GameObject selectedUnitIcon`
- `Vector3 selectedUnitIconOriginalScale`
- `Vector3 selectedUnitIconOriginalScaleBIG`
- `GameObject selectedUnitStatsPanel`
- `static HashSet`1 sonarDetections`
- `GameObject startScenario_Panel`
- `Transform targetsParent`
- `static Stopwatch timeElapsedSinceGameStarted`
- `static Unit unitBeforeRightClickStats`
- `UnitGO unitCorePrefab`
- `UnitGO unitPrefab`
- `Transform unitsParent`
- `GameObject unitStatsPanel`

---


## MapOverlayManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OpenFileManager()`

### Public Properties

*No public properties*

### Public Fields

- `String[] filePath`
- `SpriteRenderer spriteRenderer`

---


## MessageBoxGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void CloseMessageBox()`
- `Void Update()`

### Public Properties

*No public properties*

### Public Fields

- `TextMeshProUGUI message_Text`

---


## Mod

**Base Class:** `ModBase`

### Public Methods

- `Void LoadAssemblies()`
- `Void PatchMod()`
- `Void UnloadMod()`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## ModBase

### Public Methods

- `ModPropertyBag get_ModDataBag()`
- `Void LoadAssemblies()`
- `Void PatchMod()`
- `Void UnloadMod()`

### Public Properties

- `ModPropertyBag ModDataBag` { get }

### Public Fields

- `List`1 assemblies`
- `CustomCountries customCountries`
- `CustomTiles customTiles`
- `CustomUnits customUnits`
- `List`1 gameModifications`
- `String installLocation`
- `ModdedHeroes moddedHeroes`
- `ModifiedBaseTiles modifiedBaseTiles`
- `ModifiedBaseUnits modifiedBaseUnits`
- `String name`

---


## ModdedHeroes

### Public Methods

- `Void CreateFileBaseMod(String path)`
- `List`1 get_heroes()`
- `Void Save()`
- `Void set_heroes(List`1 value)`

### Public Properties

- `List`1 heroes` { get; set }

### Public Fields

- `String fileLocation`
- `static String FILENAME`

---


## ModifiedBaseTiles

### Public Methods

- `Void CreateFileBaseMod(String path)`
- `Dictionary`2 get_tiles()`
- `Void Save()`
- `Void set_tiles(Dictionary`2 value)`

### Public Properties

- `Dictionary`2 tiles` { get; set }

### Public Fields

- `String fileLocation`
- `static String FILENAME`

---


## ModifiedBaseUnits

### Public Methods

- `Void CheckInvalidAllowedRotations()`
- `Void ConvertToNewSystem()`
- `Void CreateFileBaseMod(String path)`
- `Dictionary`2 get_units()`
- `List`1 get_Units()`
- `Void RemoveDuplicates()`
- `Void Save()`
- `Void set_units(Dictionary`2 value)`
- `Void set_Units(List`1 value)`

### Public Properties

- `Dictionary`2 units` { get; set }
- `List`1 Units` { get; set }

### Public Fields

- `String fileLocation`
- `static String FILENAME`

---


## ModManifest

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `String dependencies`
- `String modAuthor`
- `String modDescription`
- `String modName`
- `String modVersion`
- `String supportedGameVersion`

---


## ModPanelGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ApplyChanges()`
- `Void CreateMod()`
- `Void OpenModsFolder()`
- `Void OpenTutorialYoutube()`
- `Void OpenWorkshopPanel()`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## ModPropertyBag

### Public Methods

- `Void Clear()`
- `Int32 get_CountKnowns()`
- `Int32 get_CountTotal()`
- `Int32 get_CountUnknowns()`
- `Boolean get_IsEmpty()`
- `Boolean HasKey(String p_key, Boolean p_includeUnknowns)`
- `Boolean Remove(String p_key)`
- `Boolean TryGet(String p_key, T& o_value)`
- `Boolean TrySet(String p_key, T p_value, Boolean preferKnownOverUnknown)`

### Public Properties

- `Int32 CountKnowns` { get }
- `Int32 CountTotal` { get }
- `Int32 CountUnknowns` { get }
- `Boolean IsEmpty` { get }

### Public Fields

*No public fields*

---


## ModSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Button deleteMod_button`
- `Single installSize`
- `Button manageMod_button`
- `Button mod_button`
- `TextMeshProUGUI modName_text`
- `Button openMod_button`

---


## ModsManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `static Void ApplyModdedTilesChanges()`
- `static Void ApplyModdedUnitsChanges()`
- `static Mod FindModByName(String p_modName)`
- `static Int32 get_ModdedCountriesCount()`
- `static List`1 GetModdedCountries(Boolean p_sort)`
- `static List`1 GetModdedTilesChanges()`
- `static List`1 GetModdedUnitsChanges()`
- `static Void GetUserSubscribedWorkshopMods()`
- `Void LoadAllMods()`
- `static Void SaveCountriesAllMods()`
- `static Void SaveHeroesAllMods()`
- `static Void SaveTilesAllMods()`
- `static Void SaveUnitsAllMods()`

### Public Properties

- `static Int32 ModdedCountriesCount` { get }

### Public Fields

- `static List`1 activeMods`
- `static String ATTACK`
- `static String CUSTOM_COUNTRIES`
- `static String CUSTOM_HEROES`
- `static String CUSTOM_TILES`
- `static String CUSTOM_UNITS`
- `static String FLAGS`
- `static String GRAPHICS`
- `static String HEROES`
- `static ModsManager instance`
- `static String LIBRARIES`
- `static String MAPS`
- `static Int32 MODDED_HEROES_SIZE`
- `static Int32 MODDED_TILES_SIZE`
- `static Int32 MODDED_UNITS_SIZE`
- `static List`1 moddedAttackSounds`
- `static List`1 moddedFlagsGraphics`
- `static List`1 moddedHeroesGraphics`
- `static List`1 moddedMaps`
- `static List`1 moddedMovementSounds`
- `static List`1 moddedMusics`
- `static List`1 moddedTilesGraphics`
- `static List`1 moddedUnitsGraphics`
- `static List`1 moddedVideos`
- `static List`1 moddedWallpapers`
- `static readonly String[] ModHierarchy`
- `static String MODIFIED_BASE_TILES`
- `static String MODIFIED_BASE_UNITS`
- `static String MOVEMENT`
- `static String MUSICS`
- `static Mod selectedMod`
- `static String SOUNDS`
- `static String TILES`
- `static String UNITS`
- `static String VIDEOS`
- `static String WALLPAPERS`
- `static Dictionary`2 workshopMods`
- `static Dictionary`2 workshopModsTitles`

---


## MoneyTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## MoraleStates

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static MoraleStates AWFUl`
- `static MoraleStates BAD`
- `static MoraleStates EXCELLENT`
- `static MoraleStates GOOD`
- `static MoraleStates NORMAL`
- `Byte value__`

---


## MultiplayerChat

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ChooseChannel(TMP_Dropdown p_TMP_Dropdown)`
- `Void ConnectChat()`
- `Boolean ContainsChineseCharacters(String p_text)`
- `Boolean ContainsJapaneseCharacters(String p_text)`
- `Boolean ContainsKoreanCharacters(String p_text)`
- `Boolean ContainsRussianCharacters(String p_text)`
- `Void DebugReturn(DebugLevel p_level, String p_message)`
- `Void Disconnect()`
- `Void JoinChannel(String p_channel)`
- `Void LeaveChannel(String p_channel)`
- `Void OnChatStateChange(ChatState p_state)`
- `Void OnConnected()`
- `Void OnDisconnected()`
- `Void OnGetMessages(String p_channelName, String[] p_senders, Object[] p_messages)`
- `Void OnPrivateMessage(String p_sender, Object p_message, String p_channelName)`
- `Void OnStatusUpdate(String p_user, Int32 p_status, Boolean p_gotMessage, Object p_message)`
- `Void OnSubscribed(String[] p_channels, Boolean[] p_results)`
- `Void OnUnsubscribed(String[] p_channels)`
- `Void OnUserSubscribed(String p_channel, String p_user)`
- `Void OnUserUnsubscribed(String p_channel, String p_user)`
- `Void Reconnect()`
- `Void RefreshConnectedUsers()`
- `Void SendMessage_button()`
- `Void TurnOFFPublicChatAndSubscribe()`

### Public Properties

*No public properties*

### Public Fields

- `static List`1 adminUsernames`
- `ChatClient chatClient`
- `GameObject friendManagement_gameobject`
- `static MultiplayerChat instance`
- `static Boolean isTyping`
- `GameObject notification`

---


## MultiplayerManager

**Base Class:** `Photon.Pun.MonoBehaviourPunCallbacks`

### Public Methods

- `Void ForceFullDataResync()`
- `static MultiplayerManager get_Instance()`
- `Void OnDisable()`
- `Void OnDisconnected(DisconnectCause p_cause)`
- `Void OnEnable()`
- `Void OnEvent(EventData p_photonEvent)`
- `Void OnMasterClientSwitched(Player p_player)`
- `Void OnPlayerEnteredRoom(Player p_player)`
- `Void OnPlayerLeftRoom(Player p_otherPlayer)`
- `static Void RaiseEvent(Byte eventCode, Object payload)`
- `static Void RaiseEvent(Byte eventCode, Object[] payloads)`
- `Void Reconnect()`
- `static Void RPC(String p_RPCname, Object[] p_args)`
- `Void RPC_AddPlayer(Byte[] p_bytes)`
- `Void RPC_AddUnit(Byte[] p_bytes)`
- `Void RPC_AllianceMade(Byte[] p_bytes)`
- `Void RPC_AttackUnit(Byte[] p_bytes)`
- `Void RPC_CaptureVP(Byte[] p_bytes)`
- `Void RPC_CountryChange(Byte[] p_bytes)`
- `Void RPC_DespawnUnit(Byte[] p_bytes)`
- `Void RPC_DisplayAmmoLoss(Byte[] p_bytes)`
- `Void RPC_DisplayFuelLoss(Byte[] p_bytes)`
- `Void RPC_DisplayLevelUp(Byte[] p_bytes)`
- `Void RPC_DisplayXP(Byte[] p_bytes)`
- `Void RPC_EmbarkDisembark(Byte[] p_bytes)`
- `Void RPC_EndTurn()`
- `Void RPC_KillUnit(Byte[] p_bytes)`
- `Void RPC_MoveUnit(Byte[] p_bytes)`
- `Void RPC_PlaySound(Byte[] p_bytes)`
- `Void RPC_RedeployUnit(Byte[] p_bytes)`
- `Void RPC_RemovePlayer(Byte[] p_bytes)`
- `Void RPC_RemoveUnit(Byte[] p_bytes)`
- `Void RPC_ShowDamage(Byte[] p_bytes)`
- `Void RPC_ShowRelationshipWindow(Byte[] p_bytes)`
- `Void RPC_SignedPeace(Byte[] p_bytes)`
- `Void RPC_SpawnUnit(Byte[] p_bytes)`
- `Void RPC_SwapUnits(Byte[] p_bytes)`
- `Void RPC_SyncAnything(Byte[] p_bytes)`
- `Void RPC_SyncEvents(Byte[] p_bytes)`
- `Void RPC_SyncLineDatas(Byte[] p_bytes)`
- `Void RPC_SyncNotifications(Byte[] p_bytes)`
- `Void RPC_SyncPlayer(Byte[] p_bytes)`
- `Void RPC_SyncPlayerData(Byte[] p_bytes)`
- `Void RPC_SyncTile(Byte[] p_bytes)`
- `Void RPC_SyncUnit(Byte[] p_bytes)`
- `Void RPC_SyncUnitData(Byte[] p_bytes)`
- `Void RPC_TransferUnit(Byte[] p_bytes)`
- `Void RPC_WarDeclaration(Byte[] p_bytes)`
- `Void RunRPC(String p_RPCname, String p_targetCode, Object[] p_args)`
- `Void RunRPC(String p_RPCname, RpcTarget p_target, Object[] p_args)`
- `Void RunRPC(String p_RPCname, Player p_player, Object[] p_args)`

### Public Properties

- `static MultiplayerManager Instance` { get; set }

### Public Fields

- `static Int32 CHUNK_SIZE`
- `static Byte EventCode_AI_loadingBar`
- `static Byte EventCode_ammoLoss_display`
- `static Byte EventCode_fuelLoss_display`
- `static Byte EventCode_MapChunk`
- `static Byte EventCode_XP_display`
- `static String IP`
- `static String VERSION`

---


## MultiplayerMenu

**Base Class:** `Photon.Pun.MonoBehaviourPunCallbacks`

### Public Methods

- `Void Browse()`
- `Void ChangeConfiguration(Player p_player, TMP_Dropdown p_dropdown)`
- `Void ChangePlayerIncome(Player p_player, Slider p_slider)`
- `Boolean CheckEmailAddress(String emailaddress)`
- `Void ChooseMap(OnlineGame game)`
- `Void CloseDeleteAccountPanel()`
- `Void CloseLobbiesPanel()`
- `Void ClosePasswordRequestPanel()`
- `Void CloseSignupPanel()`
- `Void ConnectToRegion()`
- `Void ContinueGame()`
- `Void CreateRoom()`
- `Void DeleteAccount()`
- `Void DeleteGame()`
- `Task GetAllGamesAsync()`
- `Task GetAllUsersAsync()`
- `Void Host()`
- `Void JoinOpenGame()`
- `Void JoinRoom(String p_roomName)`
- `Void KickPlayer_Button(Player p_player)`
- `Void LeaveRoom()`
- `Void ManageEULAPanel()`
- `Void ManageResetPanel()`
- `Void MapChoice(String p_mapPath)`
- `Void OnConnectedToMaster()`
- `Void OnDisable()`
- `Void OnDisconnected(DisconnectCause cause)`
- `Void OnEnable()`
- `Void OnJoinedRoom()`
- `Void OnJoinRoomFailed(Int16 returnCode, String message)`
- `Void OnMasterClientSwitched(Player p_player)`
- `Void OnPlayerEnteredRoom(Player p_photonPlayer)`
- `Void OnPlayerLeftRoom(Player p_photonPlayer)`
- `Void OnPlayerPropertiesUpdate(Player p_targetPlayer, Hashtable p_changedProps)`
- `Void OnRoomListUpdate(List`1 p_rooms)`
- `Void OpenAccount()`
- `Void OpenDeleteAccountPanel()`
- `Void OrganizeLeaderboard(String filter)`
- `Task Refresh()`
- `Void RefreshButton()`
- `Void RefreshListOfMaps()`
- `Void RequestNewPassword()`
- `Void SetComputer()`
- `Void SetFilter(String value)`
- `Void SetNewPassword()`
- `Void SetPlayerCountry_Dropdown(TMP_Dropdown p_countryDropdown)`
- `Void SetPlayerIsReady_Toggle(Toggle p_readyToggle)`
- `Void SetPlayerPlayingFirst(Toggle p_playingFirstToggle)`
- `Void SetPlaysFirst(Player p_player, Toggle p_toggle)`
- `Void SignIn()`
- `Void SignUp()`
- `Void StartGame_Button()`

### Public Properties

*No public properties*

### Public Fields

- `static readonly HttpClient client`
- `static String COMPLEXSUPPLIES_SETTING`
- `static String COUNTRIES`
- `static String DIFFICULTY_SETTING`
- `static String FOW_SETTING`
- `static String HOST`
- `static String INFINITE_AMMOFUEL_SETTING`
- `static String MANPOWER_SETTING`
- `static String MAPNAME`
- `static String MORALE_SETTING`
- `static String OVERRUN_SETTING`
- `static String PARTISANS_SETTING`
- `static String PLANES_ONE_MORE_MOVE_SETTING`
- `static String PLAYER_COUNTRY`
- `static String PLAYER_NAME`
- `static String PLAYER_PLAYING_FIRST`
- `static String PLAYER_READY`
- `static String PLAYERS`
- `static String POLICIES_SETTING`
- `static String PRODUCTIONTAKESTIME_SETTING`
- `static String RESEARCH_SETTING`
- `static String UPKEEP_SETTING`
- `static String WEATHER_SETTING`
- `static String WINTER_DAMAGE_SETTING`
- `static String ZONEOFCONTROL_SETTING`

---


## NavalHeroes

### Public Methods

- `static List`1 GetHeroes(String p_country)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## NewMinimap

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerDown(PointerEventData eventData)`
- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`
- `Void OnPointerUp(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

- `Camera minimapCamera`
- `RawImage RawImage`
- `SpriteRenderer rectangle`
- `RenderTexture texture`

---


## Notification

### Public Methods

- `Single get_Amount()`
- `String get_Description()`
- `Boolean get_HasBeenShown()`
- `Boolean get_IsImportant()`
- `String get_OwnerName()`
- `Single get_PosX()`
- `Single get_PosY()`
- `String get_SenderName()`
- `Int32 get_TurnCreated()`
- `NotificationTypes get_Type()`
- `String get_UnitResearchedFilterType()`
- `Void set_Amount(Single value)`
- `Void set_Description(String value)`
- `Void set_HasBeenShown(Boolean value)`
- `Void set_IsImportant(Boolean value)`
- `Void set_OwnerName(String value)`
- `Void set_PosX(Single value)`
- `Void set_PosY(Single value)`
- `Void set_SenderName(String value)`
- `Void set_TurnCreated(Int32 value)`
- `Void set_Type(NotificationTypes value)`
- `Void set_UnitResearchedFilterType(String value)`

### Public Properties

- `Single Amount` { get; set }
- `String Description` { get; set }
- `Boolean HasBeenShown` { get; set }
- `Boolean IsImportant` { get; set }
- `String OwnerName` { get; set }
- `Single PosX` { get; set }
- `Single PosY` { get; set }
- `String SenderName` { get; set }
- `Int32 TurnCreated` { get; set }
- `NotificationTypes Type` { get; set }
- `String UnitResearchedFilterType` { get; set }

### Public Fields

*No public fields*

---


## NotificationButtonGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void DestroyNotification()`
- `Void OnPointerClick(PointerEventData eventData)`
- `Void Setup(Notification p_notification)`

### Public Properties

*No public properties*

### Public Fields

- `TextMeshProUGUI description_text`
- `GameObject highlightRingPrefab`

---


## NotificationManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void CenterCameraOnMap(Vector3 endPos)`
- `Void CreateNewUInotification(Notification p_notification)`

### Public Properties

*No public properties*

### Public Fields

- `static NotificationManager instance`
- `Transform parent`

---


## NotificationTypes

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static NotificationTypes ALLIANCE_INVITATION`
- `static NotificationTypes ALLIANCE_PROPOSITION_ACCEPTED`
- `static NotificationTypes ALLIANCE_PROPOSITION_REJECTED`
- `static NotificationTypes COUNTRY_CHANGED`
- `static NotificationTypes DEFAULT`
- `static NotificationTypes MONEY_TRANSFER`
- `static NotificationTypes MONEY_TRANSFER_NEUTRALITY`
- `static NotificationTypes REINFORCEMENTS_ALLIES`
- `static NotificationTypes REINFORCEMENTS_ENEMIES`
- `static NotificationTypes REINFORCEMENTS_PLAYER`
- `static NotificationTypes RESEARCH_COMPLETE`
- `static NotificationTypes TERRITORY_GAIN`
- `static NotificationTypes TERRITORY_LOSS`
- `static NotificationTypes UNIT_AMBUSH`
- `static NotificationTypes UNIT_BLEW_UP`
- `static NotificationTypes UNIT_CANNOT_FIND_PATH`
- `static NotificationTypes UNIT_DESTROYED`
- `static NotificationTypes UNIT_KILLED`
- `static NotificationTypes UNIT_LOW_HEALTH`
- `static NotificationTypes UNIT_NO_SUPPLIES`
- `static NotificationTypes UNIT_PURCHASE`
- `static NotificationTypes UNIT_REACHED_DESTINATION`
- `static NotificationTypes UNIT_SHOT_DOWN`
- `static NotificationTypes UNIT_SUNK`
- `static NotificationTypes UNIT_SURRENDERED`
- `static NotificationTypes UNIT_TRANSFER`
- `static NotificationTypes UNIT_UNDER_ATTACK`
- `Byte value__`
- `static NotificationTypes VP_ANNEXED`
- `static NotificationTypes VP_LOST`
- `static NotificationTypes VP_OWNERSHIP_LOSS`
- `static NotificationTypes VP_RECEIVED`

---


## OfficialTiles

### Public Methods

- `List`1 get_Tiles()`
- `static OfficialTiles GetInstance()`
- `static Void Load()`
- `static Void Save()`
- `Void set_Tiles(List`1 value)`

### Public Properties

- `List`1 Tiles` { get; set }

### Public Fields

- `static readonly Object _myLock`
- `static OfficialTiles _officialTiles`
- `static String filePath`

---


## OfficialTilesORIGINAL

### Public Methods

- `List`1 get_Tiles()`
- `static OfficialTilesORIGINAL GetInstance()`
- `static Void Load()`
- `static Void Save()`
- `Void set_Tiles(List`1 value)`

### Public Properties

- `List`1 Tiles` { get; set }

### Public Fields

- `static readonly Object _myLock`
- `static OfficialTilesORIGINAL _officialTilesOriginal`
- `static String filePath`

---


## OfficialUnits

### Public Methods

- `List`1 get_Units()`
- `static OfficialUnits GetInstance()`
- `static Void Load()`
- `static Void Save()`
- `Void set_Units(List`1 value)`

### Public Properties

- `List`1 Units` { get; set }

### Public Fields

- `static readonly Object _myLock`
- `static OfficialUnits _officialUnits`
- `static String filePath`

---


## OfficialUnitsORIGINAL

### Public Methods

- `List`1 get_Units()`
- `static OfficialUnitsORIGINAL GetInstance()`
- `static Void Load()`
- `static Void Save()`
- `Void set_Units(List`1 value)`

### Public Properties

- `List`1 Units` { get; set }

### Public Fields

- `static readonly Object _myLock`
- `static OfficialUnitsORIGINAL _officialUnitsOriginal`
- `static String filePath`

---


## OnlineGame

### Public Methods

- `String get_created_on()`
- `String get_end()`
- `String get_last_turn()`
- `String get_mapID()`
- `String get_mapName()`
- `String get_mapNation()`
- `String get_mapSize()`
- `String get_mapYear()`
- `String get_start()`
- `String get_status()`
- `String get_totalTurns()`
- `String get_userHost()`
- `String get_userJoin()`
- `String get_userLost()`
- `String get_userTurn()`
- `String get_userWin()`
- `Void set_created_on(String value)`
- `Void set_end(String value)`
- `Void set_last_turn(String value)`
- `Void set_mapID(String value)`
- `Void set_mapName(String value)`
- `Void set_mapNation(String value)`
- `Void set_mapSize(String value)`
- `Void set_mapYear(String value)`
- `Void set_start(String value)`
- `Void set_status(String value)`
- `Void set_totalTurns(String value)`
- `Void set_userHost(String value)`
- `Void set_userJoin(String value)`
- `Void set_userLost(String value)`
- `Void set_userTurn(String value)`
- `Void set_userWin(String value)`

### Public Properties

- `String created_on` { get; set }
- `String end` { get; set }
- `String last_turn` { get; set }
- `String mapID` { get; set }
- `String mapName` { get; set }
- `String mapNation` { get; set }
- `String mapSize` { get; set }
- `String mapYear` { get; set }
- `String start` { get; set }
- `String status` { get; set }
- `String totalTurns` { get; set }
- `String userHost` { get; set }
- `String userJoin` { get; set }
- `String userLost` { get; set }
- `String userTurn` { get; set }
- `String userWin` { get; set }

### Public Fields

*No public fields*

---


## OnlineUser

### Public Methods

- `String get_created_on()`
- `String get_last_login()`
- `Int32 get_matchLost()`
- `Int32 get_matchWon()`
- `String get_platform()`
- `Single get_ratio()`
- `String get_username()`
- `Void set_created_on(String value)`
- `Void set_last_login(String value)`
- `Void set_matchLost(Int32 value)`
- `Void set_matchWon(Int32 value)`
- `Void set_platform(String value)`
- `Void set_ratio(Single value)`
- `Void set_username(String value)`

### Public Properties

- `String created_on` { get; set }
- `String last_login` { get; set }
- `Int32 matchLost` { get; set }
- `Int32 matchWon` { get; set }
- `String platform` { get; set }
- `Single ratio` { get; set }
- `String username` { get; set }

### Public Fields

*No public fields*

---


## OOBSlot

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ResetSlot()`
- `Void SetUpSlot()`

### Public Properties

*No public properties*

### Public Fields

- `Toggle autoSupplies_toggle`
- `Image backgroundForCoreUnit`
- `Image backgroundUnit`
- `Button delete_button`
- `TextMeshProUGUI heroName_text`
- `Button redeploy_button`
- `Image representation`
- `Button slot_button`
- `Button transfer_button`
- `Unit unit`
- `TextMeshProUGUI unitHP_text`
- `TextMeshProUGUI unitName_text`
- `TextMeshProUGUI unitRank_text`
- `TextMeshProUGUI unitXP_text`

---


## OrderOfBattleGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `IEnumerator CloseOOB()`
- `Void DisbandUnit(Unit p_unit, GameObject p_unitSlotToDestroy)`
- `Void GenerateAllSlots()`
- `Void ManageAutoSupplies(Unit p_unit)`
- `Void ManageAutoSuppliesForAll_Toggle(Toggle p_toggle)`
- `Void ManageOOB()`
- `Void ManageTransferPanel(Unit p_unit)`
- `Void RedeployUnit(Unit p_unit, GameObject p_unitSlotToDestroy)`
- `Void RefreshOrderSlots_Toggle()`
- `Void SelectUnit(Unit unit)`
- `Void ShowAllPlayersWeCanGiveUnitTo()`
- `Void ShowSelectedUnitInOOB()`
- `Void TransferUnit(Unit p_unit, Player p_player)`

### Public Properties

*No public properties*

### Public Fields

- `Animator animator`
- `Toggle autoSupplies_toggle`
- `TMP_Dropdown filter_dropdown`
- `String filterType`
- `static OrderOfBattleGO instance`
- `GameObject OOBPanel`
- `Transform parent`
- `Scrollbar scrollbar`
- `OOBSlot slotPrefab`
- `Toggle sortByCoreUnits_toggle`
- `Toggle sortByLowHealth_toggle`
- `Toggle sortByUpkeepCost_toggle`
- `GameObject transferPanel`
- `GameObject transferPlayerPrefab`
- `TMP_InputField unitName_inputfield`

---


## OwnerPanelEditorGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## PaintMode

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static PaintMode CAN_FREEZE`
- `static PaintMode CAN_SEASON_CHANGE`
- `static PaintMode TILE_PLACING`
- `static PaintMode UNIT_REMOVAL`
- `Int32 value__`

---


## PasswordInputfieldUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ChangePasswordVisibility()`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## Player

### Public Methods

- `Void AddAllianceWith(Player p_player, Boolean p_sendRPC)`
- `Void AddHQPoints(Int32 p_amount, Boolean p_sendRPC)`
- `Void AddLineData(LineData p_lineData, Boolean p_sendRPC)`
- `Void AddManpower(Int32 p_amount, Boolean p_doMarginCheck, Boolean p_sendRPC)`
- `Void AddMoney(Int32 p_amount, Boolean p_sendRPC)`
- `Void AddNewTurnManpower()`
- `Void AddPolicy(Policy p_policy, Boolean p_sendRPC)`
- `Void AddTruceWith(Player p_player, Boolean p_sendRPC)`
- `Void AddTurnStats()`
- `Void AddUnit(Unit p_unit, Boolean p_sendRPC)`
- `Void AddWarWith(Player p_player, Boolean p_actualDirectWarDeclaration, Boolean p_sendRPC)`
- `Boolean AreThereUnitsReadyForDeployment()`
- `Void AssignUnitCategoryID(Unit p_unit)`
- `Void BackupTurnStatsAndReset()`
- `Void CacheAllianceAndWarForGivenPlayer(Player p_player)`
- `Int32 CalculateMaxManpower()`
- `Int32 CalculateTotalUnitsUpkeep(Boolean p_applyReserveModifier)`
- `Int32 CalculateTurnIncome()`
- `Void CancelResearch(Unit p_unit, Boolean p_sendRPC)`
- `Void ChangeFaction(String p_newFactionName, Boolean p_getNewAllianceWars, Boolean p_sendRPC)`
- `Void CheckForMissingUnitsCategories()`
- `Int32 CountCurrCoreUnits()`
- `Int32 CountOurUnits()`
- `Int32 CountOurVPs()`
- `Void CountUnitTypesForStatistic(Statistic p_stat)`
- `Void DestroyAndResetAllUnits(Player p_playerTakingOver)`
- `HashSet`1 get_AlliedPlayers()`
- `List`1 get_ClearedFOW()`
- `String get_Country()`
- `Dictionary`2 get_CurrentUnitsResearch()`
- `Int32 get_EventMoneyToProcess()`
- `String get_Faction()`
- `Int32 get_FixedIncome()`
- `Int16 get_HighCommandPoints()`
- `String get_Ideology()`
- `Byte get_IncomeModifier()`
- `Boolean get_IsComputer()`
- `Boolean get_IsEndTurnPanel()`
- `Boolean get_IsPlaying()`
- `Boolean get_IsPlayingFirst()`
- `List`1 get_LineDatas()`
- `List`1 get_ListActivePolicies()`
- `List`1 get_ListOfUnits()`
- `List`1 get_ListOfUnitsResearched()`
- `String get_LocalPassword()`
- `Int32 get_ManpowerAvailable()`
- `Int32 get_MoneyAmount()`
- `String get_Name()`
- `String get_Nickname()`
- `Int16 get_NumberOfAvailableResearchPoints()`
- `Int16 get_NumberOfPartisansLost()`
- `Int32 get_NumberOfVPEverConquered()`
- `Boolean get_OOBautoSupplies()`
- `HashSet`1 get_PlayersAtWar()`
- `Dictionary`2 get_PurchasedUnits()`
- `Int32 get_Rank()`
- `Int32 get_SafariKillCount()`
- `String get_ScenarioDefeatText()`
- `String get_ScenarioDescription()`
- `String get_ScenarioVictoryText()`
- `Dictionary`2 get_Stats()`
- `Single get_TotalDamageDealt()`
- `Int32 get_TotalMoneyEarned()`
- `Int32 get_TotalMoneySpent()`
- `Single get_TotalTilesBombed()`
- `Int32 get_TotalUnitsBought()`
- `Int32 get_TotalUnitsDestroyed()`
- `Int32 get_TotalUnitsLost()`
- `Dictionary`2 get_Truces()`
- `Int32 get_TurnMoneyEarned()`
- `Int32 get_TurnMoneyEarnedBackup()`
- `Int32 get_TurnMoneySpent()`
- `Int32 get_TurnMoneySpentBackup()`
- `Int32 get_TurnUnitsBought()`
- `Int32 get_TurnUnitsBoughtBackup()`
- `Int32 get_TurnUnitsDestroyed()`
- `Int32 get_TurnUnitsDestroyedBackup()`
- `Int32 get_TurnUnitsLost()`
- `Int32 get_TurnUnitsLostBackup()`
- `Dictionary`2 get_UnitCategoriesQuantity()`
- `Int32 get_XP()`
- `Int32 get_XPNeededForNextRank()`
- `Int32 GetAvailableManpower()`
- `Int32 GetFactionChangeCost(String p_targetFaction)`
- `Int32 GetFieldedManpower()`
- `Int32 GetManpowerGrowth()`
- `Boolean HasPolicy(Policy p_policy)`
- `Boolean HasPolicy(Type p_type)`
- `Boolean HasReachedMaxPurchaseLimit(Unit p_unit)`
- `Boolean HasReachedUnitLimitCap(Unit p_unit)`
- `Boolean HasResearchedAllUnits()`
- `Boolean HasTruceWith(Player p_player)`
- `Boolean IsAlliedWith(Player p_player)`
- `Boolean IsAtWarWith(Player p_player)`
- `Boolean IsMajor()`
- `Boolean IsMinor()`
- `Boolean IsNaturalAllyOf(Player p_player)`
- `Boolean IsNavalMajor()`
- `Boolean IsNavalMinor()`
- `Void PurchasePolicy(Policy p_policy, Boolean p_sendRPC)`
- `Void PurchaseUnit(Unit p_unit, Boolean p_sendRPC)`
- `Void RemoveAllianceWith(Player p_player, Boolean p_sendRPC)`
- `Void RemoveHQpoints(Int32 p_amount, Boolean p_sendRPC)`
- `Void RemoveLineData(LineData p_lineData, Boolean p_sendRPC)`
- `Void RemoveManpower(Int32 p_amount, Boolean p_sendRPC)`
- `Void RemoveMoney(Int32 p_amount, Boolean p_sendRPC)`
- `Void RemovePolicy(Policy p_policy, Boolean p_sendRPC)`
- `Void RemovePolicy(Type p_type, Boolean p_sendRPC)`
- `Void RemoveTruceWith(Player p_player, Boolean p_sendRPC)`
- `Void RemoveUnit(Unit p_unit, Boolean p_sendRPC)`
- `Void RemoveUnitCategoryID(Unit p_unit)`
- `Void RemoveWarWith(Player p_player, Boolean p_sendRPC)`
- `Void set_AlliedPlayers(HashSet`1 value)`
- `Void set_ClearedFOW(List`1 value)`
- `Void set_Country(String value)`
- `Void set_CurrentUnitsResearch(Dictionary`2 value)`
- `Void set_EventMoneyToProcess(Int32 value)`
- `Void set_Faction(String value)`
- `Void set_FixedIncome(Int32 value)`
- `Void set_HighCommandPoints(Int16 value)`
- `Void set_Ideology(String value)`
- `Void set_IncomeModifier(Byte value)`
- `Void set_IsComputer(Boolean value)`
- `Void set_IsEndTurnPanel(Boolean value)`
- `Void set_IsPlaying(Boolean value)`
- `Void set_IsPlayingFirst(Boolean value)`
- `Void set_LineDatas(List`1 value)`
- `Void set_ListActivePolicies(List`1 value)`
- `Void set_ListOfUnits(List`1 value)`
- `Void set_ListOfUnitsResearched(List`1 value)`
- `Void set_LocalPassword(String value)`
- `Void set_MoneyAmount(Int32 value)`
- `Void set_Name(String value)`
- `Void set_Nickname(String value)`
- `Void set_NumberOfAvailableResearchPoints(Int16 value)`
- `Void set_NumberOfPartisansLost(Int16 value)`
- `Void set_NumberOfVPEverConquered(Int32 value)`
- `Void set_OOBautoSupplies(Boolean value)`
- `Void set_PlayersAtWar(HashSet`1 value)`
- `Void set_PurchasedUnits(Dictionary`2 value)`
- `Void set_Rank(Int32 value)`
- `Void set_SafariKillCount(Int32 value)`
- `Void set_ScenarioDefeatText(String value)`
- `Void set_ScenarioDescription(String value)`
- `Void set_ScenarioVictoryText(String value)`
- `Void set_Stats(Dictionary`2 value)`
- `Void set_TotalDamageDealt(Single value)`
- `Void set_TotalMoneyEarned(Int32 value)`
- `Void set_TotalMoneySpent(Int32 value)`
- `Void set_TotalTilesBombed(Single value)`
- `Void set_TotalUnitsBought(Int32 value)`
- `Void set_TotalUnitsDestroyed(Int32 value)`
- `Void set_TotalUnitsLost(Int32 value)`
- `Void set_Truces(Dictionary`2 value)`
- `Void set_TurnMoneyEarned(Int32 value)`
- `Void set_TurnMoneyEarnedBackup(Int32 value)`
- `Void set_TurnMoneySpent(Int32 value)`
- `Void set_TurnMoneySpentBackup(Int32 value)`
- `Void set_TurnUnitsBought(Int32 value)`
- `Void set_TurnUnitsBoughtBackup(Int32 value)`
- `Void set_TurnUnitsDestroyed(Int32 value)`
- `Void set_TurnUnitsDestroyedBackup(Int32 value)`
- `Void set_TurnUnitsLost(Int32 value)`
- `Void set_TurnUnitsLostBackup(Int32 value)`
- `Void set_UnitCategoriesQuantity(Dictionary`2 value)`
- `Void set_XP(Int32 value)`
- `Void set_XPNeededForNextRank(Int32 value)`
- `Void SetAvailableManpower(Int32 p_amount)`
- `Void SetDefaultIncomeModifier()`
- `Void SetDefaultResearchPointsAmount(List`1 p_gameUnits)`
- `Void SetupIdeology()`
- `Void StartResearch(Unit p_unit, Boolean p_sendRPC)`

### Public Properties

- `HashSet`1 AlliedPlayers` { get; set }
- `List`1 ClearedFOW` { get; set }
- `String Country` { get; set }
- `Dictionary`2 CurrentUnitsResearch` { get; set }
- `Int32 EventMoneyToProcess` { get; set }
- `String Faction` { get; set }
- `Int32 FixedIncome` { get; set }
- `Int16 HighCommandPoints` { get; set }
- `String Ideology` { get; set }
- `Byte IncomeModifier` { get; set }
- `Boolean IsComputer` { get; set }
- `Boolean IsEndTurnPanel` { get; set }
- `Boolean IsPlaying` { get; set }
- `Boolean IsPlayingFirst` { get; set }
- `List`1 LineDatas` { get; set }
- `List`1 ListActivePolicies` { get; set }
- `List`1 ListOfUnits` { get; set }
- `List`1 ListOfUnitsResearched` { get; set }
- `String LocalPassword` { get; set }
- `Int32 ManpowerAvailable` { get; set }
- `Int32 MoneyAmount` { get; set }
- `String Name` { get; set }
- `String Nickname` { get; set }
- `Int16 NumberOfAvailableResearchPoints` { get; set }
- `Int16 NumberOfPartisansLost` { get; set }
- `Int32 NumberOfVPEverConquered` { get; set }
- `Boolean OOBautoSupplies` { get; set }
- `HashSet`1 PlayersAtWar` { get; set }
- `Dictionary`2 PurchasedUnits` { get; set }
- `Int32 Rank` { get; set }
- `Int32 SafariKillCount` { get; set }
- `String ScenarioDefeatText` { get; set }
- `String ScenarioDescription` { get; set }
- `String ScenarioVictoryText` { get; set }
- `Dictionary`2 Stats` { get; set }
- `Single TotalDamageDealt` { get; set }
- `Int32 TotalMoneyEarned` { get; set }
- `Int32 TotalMoneySpent` { get; set }
- `Single TotalTilesBombed` { get; set }
- `Int32 TotalUnitsBought` { get; set }
- `Int32 TotalUnitsDestroyed` { get; set }
- `Int32 TotalUnitsLost` { get; set }
- `Dictionary`2 Truces` { get; set }
- `Int32 TurnMoneyEarned` { get; set }
- `Int32 TurnMoneyEarnedBackup` { get; set }
- `Int32 TurnMoneySpent` { get; set }
- `Int32 TurnMoneySpentBackup` { get; set }
- `Int32 TurnUnitsBought` { get; set }
- `Int32 TurnUnitsBoughtBackup` { get; set }
- `Int32 TurnUnitsDestroyed` { get; set }
- `Int32 TurnUnitsDestroyedBackup` { get; set }
- `Int32 TurnUnitsLost` { get; set }
- `Int32 TurnUnitsLostBackup` { get; set }
- `Dictionary`2 UnitCategoriesQuantity` { get; set }
- `Int32 XP` { get; set }
- `Int32 XPNeededForNextRank` { get; set }

### Public Fields

- `Int32 AirForces`
- `Int32 baseIncome`
- `Boolean canAIattackPlayer`
- `Int32 GroundForces`
- `Boolean isAlliedWithCurrentPlayer`
- `Boolean isAlliedWithGivenPlayer`
- `Boolean isAlliedWithHumanPlayer`
- `Boolean isAtWarWithCurrentPlayer`
- `Boolean isAtWarWithGivenPlayer`
- `Boolean isAtWarWithHumanPlayer`
- `Int32 ManpowerMax`
- `Int32 ManpowerUsed`
- `Int32 NavalForces`
- `Boolean noRelationWithCurrentPlayer`
- `Boolean noRelationWithGivenPlayer`
- `Boolean noRelationWithHumanPlayer`
- `Int32 NumberOfVPsOwned`
- `Single ratio`
- `Int32 tilesDestroyedIncomeLoss`
- `Int32 turnIncome`
- `static Single UNIT_LEND_LEASE_COST_MODIFIER`
- `Int32 upkeepCost`

---


## PlayerSettings

### Public Methods

- `static Void ApplyGameSettings(GameSettings p_gameSettings)`
- `Void CheckNeedRefreshChatMentions()`
- `List`1 get_ActiveMods()`
- `Int32 get_AntiAliasing()`
- `KeyCode get_AttackUnit()`
- `Boolean get_AutomaticallyHidePopups()`
- `Int32 get_AutosavesAmount()`
- `Int32 get_AutosavesCurrent()`
- `Int32 get_AutosavesFrequency()`
- `Boolean get_BlinkInactiveUnits()`
- `String get_CameraBackgroundColor()`
- `Boolean get_CensoredGermany()`
- `KeyCode get_ChangeParatroopersState()`
- `KeyCode get_ChangeSubmarineState()`
- `String get_ChatChannel()`
- `HashSet`1 get_ChatMentions()`
- `Boolean get_ColorBlindMode()`
- `Dictionary`2 get_CompletedScenarioz()`
- `Boolean get_ComplexSupplies()`
- `Boolean get_DamageReductionRepeatedAttacks()`
- `KeyCode get_DecreaseOverlayOpacity()`
- `String get_DefaultServerRegion()`
- `Int32 get_DifficultyLevel()`
- `Boolean get_DisableVanillaSoundtracks()`
- `KeyCode get_Disband()`
- `KeyCode get_Disengage()`
- `Boolean get_DisplayUnitsLevelOnCounter()`
- `KeyCode get_EndTurn()`
- `KeyCode get_EyedropperTile()`
- `Boolean get_FastAI()`
- `Boolean get_FastAllies()`
- `Boolean get_FiniteManpower()`
- `KeyCode get_FocusOnSelectedUnit()`
- `Boolean get_FollowAIMoves()`
- `List`1 get_Friends()`
- `Boolean get_Fullscreen()`
- `KeyCode get_HideAllUnits()`
- `Boolean get_HideBattlePreview()`
- `Boolean get_HideEnemyHP()`
- `Boolean get_HideUnitsStats()`
- `Boolean get_HideVisualCueCoreUnits()`
- `KeyCode get_IncreaseOverlayOpacity()`
- `Boolean get_InstantSeasonChange()`
- `Boolean get_InvertedMouseSroll()`
- `Boolean get_IsAISlowMode()`
- `Boolean get_IsFogOfWar()`
- `Boolean get_ISHistoricalFocus()`
- `Boolean get_IsInfiniteAmmoAndFuel()`
- `Boolean get_IsMorale()`
- `Boolean get_IsQuickMovement()`
- `Boolean get_IsWeather()`
- `Boolean get_IsWeatherParticles()`
- `KeyCode get_JumpDownSideMap()`
- `KeyCode get_JumpLeftSideMap()`
- `KeyCode get_JumpRightSideMap()`
- `KeyCode get_JumpUpSideMap()`
- `GameLanguages get_Language()`
- `DateTime get_LastChatMentionTime()`
- `KeyCode get_ManageMinimap()`
- `Boolean get_Manpower()`
- `Int32 get_MaxFramerate()`
- `Boolean get_MoreContrastSelectedUnit()`
- `KeyCode get_MoveCameraDown()`
- `KeyCode get_MoveCameraLeft()`
- `KeyCode get_MoveCameraRight()`
- `Boolean get_MoveCameraToMousePosWhenZooming()`
- `KeyCode get_MoveCameraUp()`
- `Boolean get_MoveCameraWithLeftClick()`
- `Boolean get_MoveCameraWithMouseOnEdge()`
- `KeyCode get_MoveOverlayDown()`
- `KeyCode get_MoveOverlayLeft()`
- `KeyCode get_MoveOverlayRight()`
- `KeyCode get_MoveOverlayUp()`
- `KeyCode get_MoveUnit()`
- `Single get_MusicVolume()`
- `KeyCode get_NextUnit()`
- `KeyCode get_NextUnitAir()`
- `KeyCode get_NextUnitGround()`
- `KeyCode get_NextUnitNaval()`
- `Boolean get_NoAAsupportDuringAirFight()`
- `KeyCode get_Objectives()`
- `Boolean get_OneMoreTilePlanes()`
- `Boolean get_Overrun()`
- `Boolean get_Partisans()`
- `String get_Password()`
- `KeyCode get_PauseGame()`
- `Boolean get_Policies()`
- `KeyCode get_PreviousUnit()`
- `Boolean get_ProductionTakesTime()`
- `Boolean get_PrototypesDisabled()`
- `Boolean get_PublicChatOFF()`
- `KeyCode get_PutUnitToSleep()`
- `Boolean get_Quick2RespondOption()`
- `KeyCode get_Quickload()`
- `KeyCode get_Quicksave()`
- `Int32 get_RandomDamageModifier()`
- `Boolean get_RealisticPlanes()`
- `Int32[,] get_Resolution()`
- `KeyCode get_ResupplyAmmo()`
- `KeyCode get_ResupplyAmmoAndFuel()`
- `KeyCode get_ResupplyFuel()`
- `KeyCode get_ResupplyManpower()`
- `KeyCode get_ScaleOverlayDown()`
- `KeyCode get_ScaleOverlayUp()`
- `KeyCode get_SelectEraser()`
- `KeyCode get_SelectPen()`
- `KeyCode get_SetDefensive()`
- `KeyCode get_SetUnitAsGoal()`
- `Boolean get_ShowBorders()`
- `KeyCode get_ShowBuilding()`
- `Boolean get_ShowClouds()`
- `KeyCode get_ShowHideGroundAirUnit()`
- `KeyCode get_ShowHideUI()`
- `Boolean get_ShowInfoTile()`
- `Boolean get_ShowTooltips()`
- `KeyCode get_ShowUnitHistory()`
- `Boolean get_ShowUnitMovePath()`
- `Boolean get_ShowUnitsNumbersOnCounters()`
- `Boolean get_ShuffleMusics()`
- `KeyCode get_SkipUnit()`
- `Boolean get_StricterFogOfWar()`
- `KeyCode get_SwitchNATOGraphics()`
- `Boolean get_TechTree()`
- `KeyCode get_TimeSlowDown()`
- `KeyCode get_TimeSpeedUp()`
- `KeyCode get_ToggleAISpeed()`
- `KeyCode get_ToggleOrderOfBattle()`
- `KeyCode get_ToggleOverlay()`
- `KeyCode get_TogglePoliticalMap()`
- `KeyCode get_ToggleReserve()`
- `KeyCode get_ToggleStore()`
- `Single get_UIScale()`
- `Single get_UIVolume()`
- `KeyCode get_Undo()`
- `Boolean get_UnitIsDoneIndicator()`
- `Boolean get_UnitsAlwaysBlink()`
- `Single get_UnitSize()`
- `Boolean get_UnitSuffix()`
- `Single get_UnitVolume()`
- `KeyCode get_UnselectUnit()`
- `Boolean get_Upkeep()`
- `Boolean get_UseNATObyDefault()`
- `String get_Username()`
- `Int32 get_VsyncValue()`
- `KeyCode get_Waypoints()`
- `Single get_WeatherVolume()`
- `Int32 get_WinterDamageValue()`
- `Boolean get_ZoneOfControl()`
- `Single get_ZoomFactor()`
- `KeyCode get_ZoomInCamera()`
- `KeyCode get_ZoomOutCamera()`
- `static PlayerSettings GetInstance()`
- `String GetLocalizedDifficulty(Int32 p_difficultyValue)`
- `Int32 GetNextAutosaveNumber()`
- `static Void Load()`
- `static Void ResetValuesToDefault()`
- `static Void Save()`
- `Void set_ActiveMods(List`1 value)`
- `Void set_AntiAliasing(Int32 value)`
- `Void set_AttackUnit(KeyCode value)`
- `Void set_AutomaticallyHidePopups(Boolean value)`
- `Void set_AutosavesAmount(Int32 value)`
- `Void set_AutosavesCurrent(Int32 value)`
- `Void set_AutosavesFrequency(Int32 value)`
- `Void set_BlinkInactiveUnits(Boolean value)`
- `Void set_CameraBackgroundColor(String value)`
- `Void set_CensoredGermany(Boolean value)`
- `Void set_ChangeParatroopersState(KeyCode value)`
- `Void set_ChangeSubmarineState(KeyCode value)`
- `Void set_ChatChannel(String value)`
- `Void set_ChatMentions(HashSet`1 value)`
- `Void set_ColorBlindMode(Boolean value)`
- `Void set_CompletedScenarioz(Dictionary`2 value)`
- `Void set_ComplexSupplies(Boolean value)`
- `Void set_DamageReductionRepeatedAttacks(Boolean value)`
- `Void set_DecreaseOverlayOpacity(KeyCode value)`
- `Void set_DefaultServerRegion(String value)`
- `Void set_DifficultyLevel(Int32 value)`
- `Void set_DisableVanillaSoundtracks(Boolean value)`
- `Void set_Disband(KeyCode value)`
- `Void set_Disengage(KeyCode value)`
- `Void set_DisplayUnitsLevelOnCounter(Boolean value)`
- `Void set_EndTurn(KeyCode value)`
- `Void set_EyedropperTile(KeyCode value)`
- `Void set_FastAI(Boolean value)`
- `Void set_FastAllies(Boolean value)`
- `Void set_FiniteManpower(Boolean value)`
- `Void set_FocusOnSelectedUnit(KeyCode value)`
- `Void set_FollowAIMoves(Boolean value)`
- `Void set_Friends(List`1 value)`
- `Void set_Fullscreen(Boolean value)`
- `Void set_HideAllUnits(KeyCode value)`
- `Void set_HideBattlePreview(Boolean value)`
- `Void set_HideEnemyHP(Boolean value)`
- `Void set_HideUnitsStats(Boolean value)`
- `Void set_HideVisualCueCoreUnits(Boolean value)`
- `Void set_IncreaseOverlayOpacity(KeyCode value)`
- `Void set_InstantSeasonChange(Boolean value)`
- `Void set_InvertedMouseSroll(Boolean value)`
- `Void set_IsAISlowMode(Boolean value)`
- `Void set_IsFogOfWar(Boolean value)`
- `Void set_ISHistoricalFocus(Boolean value)`
- `Void set_IsInfiniteAmmoAndFuel(Boolean value)`
- `Void set_IsMorale(Boolean value)`
- `Void set_IsQuickMovement(Boolean value)`
- `Void set_IsWeather(Boolean value)`
- `Void set_IsWeatherParticles(Boolean value)`
- `Void set_JumpDownSideMap(KeyCode value)`
- `Void set_JumpLeftSideMap(KeyCode value)`
- `Void set_JumpRightSideMap(KeyCode value)`
- `Void set_JumpUpSideMap(KeyCode value)`
- `Void set_Language(GameLanguages value)`
- `Void set_LastChatMentionTime(DateTime value)`
- `Void set_ManageMinimap(KeyCode value)`
- `Void set_Manpower(Boolean value)`
- `Void set_MaxFramerate(Int32 value)`
- `Void set_MoreContrastSelectedUnit(Boolean value)`
- `Void set_MoveCameraDown(KeyCode value)`
- `Void set_MoveCameraLeft(KeyCode value)`
- `Void set_MoveCameraRight(KeyCode value)`
- `Void set_MoveCameraToMousePosWhenZooming(Boolean value)`
- `Void set_MoveCameraUp(KeyCode value)`
- `Void set_MoveCameraWithLeftClick(Boolean value)`
- `Void set_MoveCameraWithMouseOnEdge(Boolean value)`
- `Void set_MoveOverlayDown(KeyCode value)`
- `Void set_MoveOverlayLeft(KeyCode value)`
- `Void set_MoveOverlayRight(KeyCode value)`
- `Void set_MoveOverlayUp(KeyCode value)`
- `Void set_MoveUnit(KeyCode value)`
- `Void set_MusicVolume(Single value)`
- `Void set_NextUnit(KeyCode value)`
- `Void set_NextUnitAir(KeyCode value)`
- `Void set_NextUnitGround(KeyCode value)`
- `Void set_NextUnitNaval(KeyCode value)`
- `Void set_NoAAsupportDuringAirFight(Boolean value)`
- `Void set_Objectives(KeyCode value)`
- `Void set_OneMoreTilePlanes(Boolean value)`
- `Void set_Overrun(Boolean value)`
- `Void set_Partisans(Boolean value)`
- `Void set_Password(String value)`
- `Void set_PauseGame(KeyCode value)`
- `Void set_Policies(Boolean value)`
- `Void set_PreviousUnit(KeyCode value)`
- `Void set_ProductionTakesTime(Boolean value)`
- `Void set_PrototypesDisabled(Boolean value)`
- `Void set_PublicChatOFF(Boolean value)`
- `Void set_PutUnitToSleep(KeyCode value)`
- `Void set_Quick2RespondOption(Boolean value)`
- `Void set_Quickload(KeyCode value)`
- `Void set_Quicksave(KeyCode value)`
- `Void set_RandomDamageModifier(Int32 value)`
- `Void set_RealisticPlanes(Boolean value)`
- `Void set_Resolution(Int32[,] value)`
- `Void set_ResupplyAmmo(KeyCode value)`
- `Void set_ResupplyAmmoAndFuel(KeyCode value)`
- `Void set_ResupplyFuel(KeyCode value)`
- `Void set_ResupplyManpower(KeyCode value)`
- `Void set_ScaleOverlayDown(KeyCode value)`
- `Void set_ScaleOverlayUp(KeyCode value)`
- `Void set_SelectEraser(KeyCode value)`
- `Void set_SelectPen(KeyCode value)`
- `Void set_SetDefensive(KeyCode value)`
- `Void set_SetUnitAsGoal(KeyCode value)`
- `Void set_ShowBorders(Boolean value)`
- `Void set_ShowBuilding(KeyCode value)`
- `Void set_ShowClouds(Boolean value)`
- `Void set_ShowHideGroundAirUnit(KeyCode value)`
- `Void set_ShowHideUI(KeyCode value)`
- `Void set_ShowInfoTile(Boolean value)`
- `Void set_ShowTooltips(Boolean value)`
- `Void set_ShowUnitHistory(KeyCode value)`
- `Void set_ShowUnitMovePath(Boolean value)`
- `Void set_ShowUnitsNumbersOnCounters(Boolean value)`
- `Void set_ShuffleMusics(Boolean value)`
- `Void set_SkipUnit(KeyCode value)`
- `Void set_StricterFogOfWar(Boolean value)`
- `Void set_SwitchNATOGraphics(KeyCode value)`
- `Void set_TechTree(Boolean value)`
- `Void set_TimeSlowDown(KeyCode value)`
- `Void set_TimeSpeedUp(KeyCode value)`
- `Void set_ToggleAISpeed(KeyCode value)`
- `Void set_ToggleOrderOfBattle(KeyCode value)`
- `Void set_ToggleOverlay(KeyCode value)`
- `Void set_TogglePoliticalMap(KeyCode value)`
- `Void set_ToggleReserve(KeyCode value)`
- `Void set_ToggleStore(KeyCode value)`
- `Void set_UIScale(Single value)`
- `Void set_UIVolume(Single value)`
- `Void set_Undo(KeyCode value)`
- `Void set_UnitIsDoneIndicator(Boolean value)`
- `Void set_UnitsAlwaysBlink(Boolean value)`
- `Void set_UnitSize(Single value)`
- `Void set_UnitSuffix(Boolean value)`
- `Void set_UnitVolume(Single value)`
- `Void set_UnselectUnit(KeyCode value)`
- `Void set_Upkeep(Boolean value)`
- `Void set_UseNATObyDefault(Boolean value)`
- `Void set_Username(String value)`
- `Void set_VsyncValue(Int32 value)`
- `Void set_Waypoints(KeyCode value)`
- `Void set_WeatherVolume(Single value)`
- `Void set_WinterDamageValue(Int32 value)`
- `Void set_ZoneOfControl(Boolean value)`
- `Void set_ZoomFactor(Single value)`
- `Void set_ZoomInCamera(KeyCode value)`
- `Void set_ZoomOutCamera(KeyCode value)`
- `Void SetLanguage(GameLanguages p_gameLanguage)`

### Public Properties

- `List`1 ActiveMods` { get; set }
- `Int32 AntiAliasing` { get; set }
- `KeyCode AttackUnit` { get; set }
- `Boolean AutomaticallyHidePopups` { get; set }
- `Int32 AutosavesAmount` { get; set }
- `Int32 AutosavesCurrent` { get; set }
- `Int32 AutosavesFrequency` { get; set }
- `Boolean BlinkInactiveUnits` { get; set }
- `String CameraBackgroundColor` { get; set }
- `Boolean CensoredGermany` { get; set }
- `KeyCode ChangeParatroopersState` { get; set }
- `KeyCode ChangeSubmarineState` { get; set }
- `String ChatChannel` { get; set }
- `HashSet`1 ChatMentions` { get; set }
- `Boolean ColorBlindMode` { get; set }
- `Dictionary`2 CompletedScenarioz` { get; set }
- `Boolean ComplexSupplies` { get; set }
- `Boolean DamageReductionRepeatedAttacks` { get; set }
- `KeyCode DecreaseOverlayOpacity` { get; set }
- `String DefaultServerRegion` { get; set }
- `Int32 DifficultyLevel` { get; set }
- `Boolean DisableVanillaSoundtracks` { get; set }
- `KeyCode Disband` { get; set }
- `KeyCode Disengage` { get; set }
- `Boolean DisplayUnitsLevelOnCounter` { get; set }
- `KeyCode EndTurn` { get; set }
- `KeyCode EyedropperTile` { get; set }
- `Boolean FastAI` { get; set }
- `Boolean FastAllies` { get; set }
- `Boolean FiniteManpower` { get; set }
- `KeyCode FocusOnSelectedUnit` { get; set }
- `Boolean FollowAIMoves` { get; set }
- `List`1 Friends` { get; set }
- `Boolean Fullscreen` { get; set }
- `KeyCode HideAllUnits` { get; set }
- `Boolean HideBattlePreview` { get; set }
- `Boolean HideEnemyHP` { get; set }
- `Boolean HideUnitsStats` { get; set }
- `Boolean HideVisualCueCoreUnits` { get; set }
- `KeyCode IncreaseOverlayOpacity` { get; set }
- `Boolean InstantSeasonChange` { get; set }
- `Boolean InvertedMouseSroll` { get; set }
- `Boolean IsAISlowMode` { get; set }
- `Boolean IsFogOfWar` { get; set }
- `Boolean ISHistoricalFocus` { get; set }
- `Boolean IsInfiniteAmmoAndFuel` { get; set }
- `Boolean IsMorale` { get; set }
- `Boolean IsQuickMovement` { get; set }
- `Boolean IsWeather` { get; set }
- `Boolean IsWeatherParticles` { get; set }
- `KeyCode JumpDownSideMap` { get; set }
- `KeyCode JumpLeftSideMap` { get; set }
- `KeyCode JumpRightSideMap` { get; set }
- `KeyCode JumpUpSideMap` { get; set }
- `GameLanguages Language` { get; set }
- `DateTime LastChatMentionTime` { get; set }
- `KeyCode ManageMinimap` { get; set }
- `Boolean Manpower` { get; set }
- `Int32 MaxFramerate` { get; set }
- `Boolean MoreContrastSelectedUnit` { get; set }
- `KeyCode MoveCameraDown` { get; set }
- `KeyCode MoveCameraLeft` { get; set }
- `KeyCode MoveCameraRight` { get; set }
- `Boolean MoveCameraToMousePosWhenZooming` { get; set }
- `KeyCode MoveCameraUp` { get; set }
- `Boolean MoveCameraWithLeftClick` { get; set }
- `Boolean MoveCameraWithMouseOnEdge` { get; set }
- `KeyCode MoveOverlayDown` { get; set }
- `KeyCode MoveOverlayLeft` { get; set }
- `KeyCode MoveOverlayRight` { get; set }
- `KeyCode MoveOverlayUp` { get; set }
- `KeyCode MoveUnit` { get; set }
- `Single MusicVolume` { get; set }
- `KeyCode NextUnit` { get; set }
- `KeyCode NextUnitAir` { get; set }
- `KeyCode NextUnitGround` { get; set }
- `KeyCode NextUnitNaval` { get; set }
- `Boolean NoAAsupportDuringAirFight` { get; set }
- `KeyCode Objectives` { get; set }
- `Boolean OneMoreTilePlanes` { get; set }
- `Boolean Overrun` { get; set }
- `Boolean Partisans` { get; set }
- `String Password` { get; set }
- `KeyCode PauseGame` { get; set }
- `Boolean Policies` { get; set }
- `KeyCode PreviousUnit` { get; set }
- `Boolean ProductionTakesTime` { get; set }
- `Boolean PrototypesDisabled` { get; set }
- `Boolean PublicChatOFF` { get; set }
- `KeyCode PutUnitToSleep` { get; set }
- `Boolean Quick2RespondOption` { get; set }
- `KeyCode Quickload` { get; set }
- `KeyCode Quicksave` { get; set }
- `Int32 RandomDamageModifier` { get; set }
- `Boolean RealisticPlanes` { get; set }
- `Int32[,] Resolution` { get; set }
- `KeyCode ResupplyAmmo` { get; set }
- `KeyCode ResupplyAmmoAndFuel` { get; set }
- `KeyCode ResupplyFuel` { get; set }
- `KeyCode ResupplyManpower` { get; set }
- `KeyCode ScaleOverlayDown` { get; set }
- `KeyCode ScaleOverlayUp` { get; set }
- `KeyCode SelectEraser` { get; set }
- `KeyCode SelectPen` { get; set }
- `KeyCode SetDefensive` { get; set }
- `KeyCode SetUnitAsGoal` { get; set }
- `Boolean ShowBorders` { get; set }
- `KeyCode ShowBuilding` { get; set }
- `Boolean ShowClouds` { get; set }
- `KeyCode ShowHideGroundAirUnit` { get; set }
- `KeyCode ShowHideUI` { get; set }
- `Boolean ShowInfoTile` { get; set }
- `Boolean ShowTooltips` { get; set }
- `KeyCode ShowUnitHistory` { get; set }
- `Boolean ShowUnitMovePath` { get; set }
- `Boolean ShowUnitsNumbersOnCounters` { get; set }
- `Boolean ShuffleMusics` { get; set }
- `KeyCode SkipUnit` { get; set }
- `Boolean StricterFogOfWar` { get; set }
- `KeyCode SwitchNATOGraphics` { get; set }
- `Boolean TechTree` { get; set }
- `KeyCode TimeSlowDown` { get; set }
- `KeyCode TimeSpeedUp` { get; set }
- `KeyCode ToggleAISpeed` { get; set }
- `KeyCode ToggleOrderOfBattle` { get; set }
- `KeyCode ToggleOverlay` { get; set }
- `KeyCode TogglePoliticalMap` { get; set }
- `KeyCode ToggleReserve` { get; set }
- `KeyCode ToggleStore` { get; set }
- `Single UIScale` { get; set }
- `Single UIVolume` { get; set }
- `KeyCode Undo` { get; set }
- `Boolean UnitIsDoneIndicator` { get; set }
- `Boolean UnitsAlwaysBlink` { get; set }
- `Single UnitSize` { get; set }
- `Boolean UnitSuffix` { get; set }
- `Single UnitVolume` { get; set }
- `KeyCode UnselectUnit` { get; set }
- `Boolean Upkeep` { get; set }
- `Boolean UseNATObyDefault` { get; set }
- `String Username` { get; set }
- `Int32 VsyncValue` { get; set }
- `KeyCode Waypoints` { get; set }
- `Single WeatherVolume` { get; set }
- `Int32 WinterDamageValue` { get; set }
- `Boolean ZoneOfControl` { get; set }
- `Single ZoomFactor` { get; set }
- `KeyCode ZoomInCamera` { get; set }
- `KeyCode ZoomOutCamera` { get; set }

### Public Fields

- `static readonly Object _myLock`
- `static PlayerSettings _playerSettings`
- `static String filePath`

---


## PlayerSlotMapEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void RefreshAIplaying()`
- `Void RefreshPlayingFirst()`
- `Void RefreshSelectedPlayer()`
- `Void Setup(Player p_player)`

### Public Properties

*No public properties*

### Public Fields

- `Toggle AI_toggle`
- `TMP_Dropdown country_dropdown`
- `TMP_Dropdown faction_dropdown`
- `TMP_InputField fixedIncome_inputfield`
- `TMP_Dropdown ideology_dropdown`
- `Button info_button`
- `Button playerSelection_button`
- `Toggle playingFirst_toggle`
- `TMP_InputField playOrder_inputfield`
- `Button removePlayer_button`
- `Color selected_color`
- `TMP_InputField startHQpoints_inputfield`
- `TMP_InputField startIncome_inputfield`
- `Color unselected_color`

---


## Policies

### Public Methods

- `static Void AddPolicy(Policy p_policy)`
- `static Void AddPolicy(String p_name, String p_description, Categories p_category, Type p_type, Byte p_highCommandPointsCost)`
- `static Void GeneratePolicies()`
- `static List`1 GetAllPolicies()`
- `static Policy GetPolicy(Type p_type)`
- `static Sprite GetPolicyIcon(Policy p_policy)`
- `static Void InitializePolicies()`

### Public Properties

*No public properties*

### Public Fields

- `static List`1 policies`

---


## PoliciesGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ClickOnPolicy(PolicySlotGO p_policySlotGO)`
- `Void ClosePoliciesPanel()`
- `Void ManagePoliciesPanel()`

### Public Properties

*No public properties*

### Public Fields

- `List`1 categories`
- `TextMeshProUGUI highCommandPoints_text`
- `static PoliciesGO instance`
- `PolicySlotGO policiesGO_prefab`
- `Transform policiesSlots_parent`
- `GameObject tooltip`

---


## Policy

### Public Methods

- `Categories get_Category()`
- `Type get_Type()`
- `Void set_Category(Categories value)`
- `Void set_Type(Type value)`

### Public Properties

- `Categories Category` { get; set }
- `Type Type` { get; set }

### Public Fields

- `String Description`
- `Byte HighCommandPointsCost`
- `String Name`

---


## PolicySlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void SetUpPolicySlot(Policy p_policy)`

### Public Properties

*No public properties*

### Public Fields

- `Button button`
- `Policy policy`
- `TextMeshProUGUI policyName_text`
- `Image representation_image`

---


## PolicyTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## PoliticalArea

**Base Class:** `System.ValueType`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Vector3 sumOfAllTilesWorldPositions`
- `Int32 tilesAmount`

---


## PoliticalHexRenderer

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Place(Vector3 p_vector3)`
- `Void SetSpriteAndColor(Color p_color, Boolean p_occupied)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## PriorityQueue`1

### Public Methods

- `T Dequeue()`
- `Void Enqueue(T p_item, Single p_priority)`
- `Int32 get_Count()`

### Public Properties

- `Int32 Count` { get }

### Public Fields

*No public fields*

---


## ResearchMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ManageTechTreePanel()`
- `Void SelectFilter(String p_filterName)`

### Public Properties

*No public properties*

### Public Fields

- `List`1 categoriesImages`
- `static ResearchMenu instance`
- `TextMeshProUGUI numberOfResearchPoints`
- `Transform parent`
- `List`1 selectedBackgrounds`
- `GameObject techTreeTooltip`
- `ResearchUnitSlot unitSlotPrefab`
- `GameObject yearSlotPrefab`

---


## ResearchUnitSlot

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Setup(Unit p_unit)`

### Public Properties

*No public properties*

### Public Fields

- `Button button`
- `Slider progress_slider`
- `TextMeshProUGUI progress_text`
- `Unit unit`

---


## ReservePanelGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `IEnumerator CloseReservePanel()`
- `Void DisbandUnit(Unit p_unit)`
- `Void EmptyButtonsList()`
- `Void GenerateButtonsList()`
- `Void GetUnit(Unit p_unit)`
- `Void ManageReserveMenu()`
- `Void ManageTransferPanel(Unit p_unit)`
- `Void PrepareSpawningZone(Unit p_unit)`
- `Void RefreshDeployNotification()`
- `Void SelectNextUnitToDeploy()`
- `Void ShowAllPlayersWeCanGiveUnitTo()`
- `Void TransferUnit(Unit p_unit, Player p_player)`

### Public Properties

*No public properties*

### Public Fields

- `GameObject countdownPrefab`
- `DeploySlotGO deploySlotPrefab`
- `static ReservePanelGO instance`
- `GameObject notification`
- `Text notification_text`
- `GameObject parent`
- `GameObject reservePanel`
- `Animator reservePanel_Animator`
- `static Unit selectedUnit`
- `GameObject transferPanel`
- `GameObject transferPlayerPrefab`
- `Transform unitParent`
- `GameObject unitsInProductionNotification`

---


## Response

### Public Methods

- `Int64 get_GameCount()`
- `Game[] get_Games()`
- `Void set_GameCount(Int64 value)`
- `Void set_Games(Game[] value)`

### Public Properties

- `Int64 GameCount` { get; set }
- `Game[] Games` { get; set }

### Public Fields

*No public fields*

---


## ResupplyCostGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

- `GameObject resupplyCost_Panel`

---


## SaveMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Browse()`
- `Void CloseSaveLoadPanel()`
- `Void DeleteSave()`
- `Void Load()`
- `Void OpenSaveLoadMenu()`
- `Void RenameSave()`
- `Void Save(Boolean p_cloudSave)`
- `Void SetSaveChoice(FileInfo p_fileInfo)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## SceneTranslator

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `TMP_FontAsset GetActiveFontAsset()`
- `Void TranslateScene()`

### Public Properties

*No public properties*

### Public Fields

- `static SceneTranslator instance`

---


## SelectedUnitExtraStatsUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Close()`
- `Void RefreshIfIsSelectedUnit(Unit p_unit)`
- `Void Show(UnitGO p_unitGO)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## SelectedUnitUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Close()`
- `Void RefreshIfIsSelectedUnit(Unit p_unit)`
- `Void Show(UnitGO p_unitGO)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## SettingsMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AutomaticallyHidePopups()`
- `Void ChangeMouseZoomSensivity()`
- `Void ChangeMusicVolume()`
- `Void ChangeUIVolume_Slider()`
- `Void ChangeUnitVolume()`
- `Void ChangeWeatherVolume()`
- `Void ChangeWinterDamage()`
- `Void ManageFullscreen()`
- `Void MoreContrast()`
- `Void OpenCustomMusicFolder()`
- `Void OpenCustomUnitSounds()`
- `Void RefreshUIScaleSliderValue()`
- `Void ResetSettingsToDefault()`
- `Void SelectSettingsCategory(GameObject p_settingsCategory)`
- `Void SetAISlowMode()`
- `Void SetAutosavesAmount()`
- `Void SetAutosavesFrequency()`
- `Void SetBlinkInactiveUnits()`
- `Void SetCameraBackgroundColor()`
- `Void SetCameraMovementTracking()`
- `Void SetCensoredGermany()`
- `Void SetColorBlindMode()`
- `Void SetComplexSupplies()`
- `Void SetConnectPublicChat()`
- `Void SetDamageReductionRepeatedAttacks()`
- `Void SetDisableVanillaSoundtracks()`
- `Void SetDisplayUnitsLevelOnCounter()`
- `Void SetEasierDifficulty()`
- `Void SetFastAI()`
- `Void SetFastAllies()`
- `Void SetFiniteManpower()`
- `Void SetFogOfWar()`
- `Void SetFramerate()`
- `Void SetHarderDifficulty()`
- `Void SetHideBattlePreview()`
- `Void SetHideEnemyHP()`
- `Void SetHideVisualCueForCoreUnits()`
- `Void SetHistoricalFocuses()`
- `Void SetInfiniteAmmoFuel()`
- `Void SetInstantWinter()`
- `Void SetInvertedMouseScroll()`
- `Void SetManpower()`
- `Void SetMorale()`
- `Void SetMoveCameraToMousePosWhenZooming()`
- `Void SetMoveCameraWithLeftClick()`
- `Void SetMoveCameraWithMouseOnEdge()`
- `Void SetNATOiconsByDefault()`
- `Void SetNewKey()`
- `Void SetNoAASupportDuringAirFight()`
- `Void SetOneMoreTilePlanes()`
- `Void SetOverrun()`
- `Void SetPartisans()`
- `Void SetPolicies()`
- `Void SetProductionTakesTime()`
- `Void SetPrototypesDisabled()`
- `Void SetQuick2RespondOption()`
- `Void SetQuickMovement()`
- `Void SetRandomDamageModifier()`
- `Void SetRealisticPlanesOption()`
- `Void SetResolution()`
- `Void SetShowBorders()`
- `Void SetShowInfoTile()`
- `Void SetShowTooltips()`
- `Void SetShowUnitMovePath()`
- `Void SetShowUnitNumberOnCounters()`
- `Void SetShowUnitsStats()`
- `Void SetStricterFogOfWar()`
- `Void SetTechTreeOption()`
- `Void SetUIScale()`
- `Void SetUnitIsDoneIndicator()`
- `Void SetUnitsAlwaysBlink()`
- `Void SetUnitSize()`
- `Void SetUnitSuffixOption()`
- `Void SetUpkeep()`
- `Void SetVSync()`
- `Void SetWeather()`
- `Void SetWeatherParticles()`
- `Void SetZoneOfControl()`
- `Void ShowClouds()`

### Public Properties

*No public properties*

### Public Fields

- `Slider antiAliasing_Slider`
- `Toggle automaticallyHidePopups_Toggle`
- `Slider autosavesAmount_slider`
- `Slider autosavesFrequency_slider`
- `Toggle blinkInactiveUnits_toggle`
- `Toggle borders_toggle`
- `InputField cameraBackgroundColor_inputfield`
- `Toggle cameraFollowAI_Toggle`
- `Toggle censoredGermany_toggle`
- `Toggle colorBlind_toggle`
- `Toggle complexSupplies_Toggle`
- `Toggle connectPublicChat_toggle`
- `Toggle damageReductionAttackFrequency_toggle`
- `Toggle disableVanillaSoundtracks_toggle`
- `Toggle displayUnitLevelOnCounter_toggle`
- `Toggle fastAI_toggle`
- `Toggle fastAIAllyOnly_toggle`
- `Toggle finiteManpower_toggle`
- `Toggle fogOfWar_Toggle`
- `Slider framerate_slider`
- `Toggle fullscreen_Toggle`
- `Toggle hideBattlePreview_toggle`
- `Toggle hideEnemyHP_toggle`
- `Toggle hideVisualCueForCoreUnits_toggle`
- `Toggle historicalFocus_Toggle`
- `Toggle infiniteFuelAmmo_Toggle`
- `Toggle instantWinter_toggle`
- `Toggle invertedMouseScroll_toggle`
- `GameObject keyBindingPanel`
- `List`1 keysButtonsElement`
- `String keyToChangeName`
- `static Boolean listeningForNewKeybind`
- `Toggle manpower_toggle`
- `Toggle morale_Toggle`
- `Toggle moreContrast_toggle`
- `Toggle moveCameraToMousePosZooming_toggle`
- `Toggle moveCameraWithEdge_Toggle`
- `Toggle moveCameraWithLeftClick_toggle`
- `Slider musicVolume_slider`
- `Toggle noAAsupportInAirBattles_toggle`
- `Toggle OneMoreTilePlanes_toggle`
- `Toggle overrun_toggle`
- `Toggle partisans_Toggle`
- `Toggle policies_toggle`
- `Toggle productionTakesTime_Toggle`
- `Toggle prototypesDisabled_toggle`
- `Toggle quick2Respond_Toggle`
- `Toggle quickMovement_Toggle`
- `Slider randomDamageModifier_slider`
- `Toggle realisticPlanes_Toggle`
- `TMP_Dropdown resolution_dropdown`
- `Toggle showClouds_Toggle`
- `Toggle showTileInfo_Toggle`
- `Toggle showTooltips_Toggle`
- `Toggle showUnitMovePath_toggle`
- `Toggle showUnitsNumberOnCounter_toggle`
- `Toggle showUnitsStats_Toggle`
- `Toggle slowAIMode_Toggle`
- `Toggle stricterFogOfWar_toggle`
- `Toggle techTree_Toggle`
- `Slider UIscale_slider`
- `Slider UIVolume_slider`
- `Toggle unitIsDoneIndicator_toggle`
- `Toggle unitsAlwaysBlink_toggle`
- `Slider unitSize_Slider`
- `Toggle unitSuffix_Toggle`
- `Slider unitVolume_slider`
- `Toggle upkeep_toggle`
- `Toggle useNATOiconsByDefault_toggle`
- `Slider vsync_Slider`
- `Toggle weather_Toggle`
- `Toggle weatherParticles_toggle`
- `Slider weatherVolume_slider`
- `Slider winterDamage_Slider`
- `Toggle zoneOfControl_toggle`
- `Slider zoom_Slider`

---


## SimpleSlotUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Button button`
- `TextMeshProUGUI textComponent`

---


## SoundManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ChangeMusicVolume()`
- `Void ChangeUIVolume_Slider()`
- `Void ChangeUnitVolume()`
- `Void ChangeWeatherVolume()`
- `static AudioClip GetAttackSound(String p_soundName)`
- `static AudioClip GetMovementSound(String p_soundName)`
- `static AudioClip GetUISound(String p_soundName)`
- `Void ManagePlaylistPanel()`
- `Void PlayDelayedUnitSound(Single p_delay, String p_soundName)`
- `Void PlayMusicByName(String p_musicName)`
- `Void PlayNextMusic()`
- `Void PlayPause()`
- `Void PlayPreviousMusic()`
- `Void PlayRandomMusic()`
- `Void SavingSoundSettings()`
- `Void ToggleShuffleMode()`

### Public Properties

*No public properties*

### Public Fields

- `Transform container`
- `static SoundManager instance`
- `List`1 listOfAllMusics`
- `AudioSource music_Source`
- `GameObject musicSlotPrefab`
- `Slider musicVolume_Slider`
- `GameObject playlist`
- `Toggle shuffle_toggle`
- `AudioSource UI_Source`
- `Slider UIVolume_slider`
- `AudioSource unit_Source`
- `Slider unitVolume_Slider`
- `AudioSource weather_Source`
- `Slider weatherVolume_Slider`

---


## StandaloneScenariosMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Browse()`
- `Void ChangeConfiguration(Player p_player, TMP_Dropdown p_dropdown, Slider p_incomeSlider)`
- `Void ChangePlayerIncome(Player p_player, Slider p_slider)`
- `Void MapChoice(FileInfo p_fileInfo)`
- `Void RefreshListOfMaps()`
- `Void SetPlaysFirst(Player p_player, Toggle p_toggle)`
- `Void Start2PlayersGame(Boolean p_ignoreConfirmationWindow)`
- `Void StartTutorial()`

### Public Properties

*No public properties*

### Public Fields

- `GameObject achievement`
- `Toggle FFAToggle`
- `GameObject loadingScenarioPanel`
- `Toggle lockFileToggle`
- `GameObject mapNameSlot`
- `TMP_InputField mapSearch_inputfield`
- `TextMeshProUGUI mapSizeText`
- `GameObject NOironman`
- `Toggle offlineMultiplayerToggle`
- `Transform parent`
- `Transform playerInfoContainer_Transform`
- `GameObject playerQuickGameSlot`
- `Button startButton`
- `GameObject YESironman`

---


## Statistic

### Public Methods

- `Int16 get_ArtilleryNumber()`
- `Byte get_HQpointsAMount()`
- `Int32 get_IncomeAmount()`
- `Int16 get_InfantryNumber()`
- `Int32 get_ManpowerAmount()`
- `Int32 get_MoneyAmount()`
- `Int16 get_NumberOfUnits()`
- `Int16 get_PlanesNumber()`
- `Int32 get_RealisticManpowerAmount()`
- `Int16 get_ShipsNumber()`
- `Int16 get_TanksNumber()`
- `Int16 get_VPsAmount()`
- `Void set_ArtilleryNumber(Int16 value)`
- `Void set_HQpointsAMount(Byte value)`
- `Void set_IncomeAmount(Int32 value)`
- `Void set_InfantryNumber(Int16 value)`
- `Void set_ManpowerAmount(Int32 value)`
- `Void set_MoneyAmount(Int32 value)`
- `Void set_NumberOfUnits(Int16 value)`
- `Void set_PlanesNumber(Int16 value)`
- `Void set_RealisticManpowerAmount(Int32 value)`
- `Void set_ShipsNumber(Int16 value)`
- `Void set_TanksNumber(Int16 value)`
- `Void set_VPsAmount(Int16 value)`

### Public Properties

- `Int16 ArtilleryNumber` { get; set }
- `Byte HQpointsAMount` { get; set }
- `Int32 IncomeAmount` { get; set }
- `Int16 InfantryNumber` { get; set }
- `Int32 ManpowerAmount` { get; set }
- `Int32 MoneyAmount` { get; set }
- `Int16 NumberOfUnits` { get; set }
- `Int16 PlanesNumber` { get; set }
- `Int32 RealisticManpowerAmount` { get; set }
- `Int16 ShipsNumber` { get; set }
- `Int16 TanksNumber` { get; set }
- `Int16 VPsAmount` { get; set }

### Public Fields

*No public fields*

---


## SteamLeaderboard

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `List`1 entries`
- `SteamLeaderboardEntry localPlayerEntry`
- `String name`

---


## SteamLeaderboardEntry

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `Boolean isLocalClient`
- `String nickname`
- `Int32 rank`
- `Int32 score`

---


## SteamManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AddPlayerStat(String p_statName, Int32 p_value)`
- `Void DeleteSteamCloudFile(String p_fileName)`
- `static Boolean get_IsSteamReady()`
- `static CSteamID get_LocalPlayerSteamID()`
- `List`1 GetLeaderboardsNames()`
- `Boolean GetPlayerStatInt(String p_statName, Int32& o_value)`
- `List`1 GetSteamCloudSaves()`
- `static String GetSteamCloudSavesLocation()`
- `static Boolean IsDLCInstalled(UInt32 p_DLCID)`
- `static Boolean OwnsDLC(AppId_t p_appId_T)`
- `Void RenameSteamCloudFile(String p_oldName, String p_newName)`
- `Void SetLeaderboard(Int32 p_score, String p_leaderboardName, LeaderboardActions p_leaderboardAction)`
- `Void SetPlayerStat(String p_statName, Int32 p_value)`
- `static Void SetRichPresenceStatus(SteamStatuses p_steamStatus)`
- `static Boolean ShouldApplyCensor()`
- `static Void UnlockAchievement(String p_ID)`
- `Void UploadSaveFileToSteamCloud(String p_fileName, GameData p_gameData)`

### Public Properties

- `static Boolean IsSteamReady` { get; set }
- `static CSteamID LocalPlayerSteamID` { get; set }

### Public Fields

- `static SteamManager instance`
- `static Byte MAX_LEADERBOARD_ENTRIES`

---


## SteamStatuses

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static SteamStatuses CREATING_MAP`
- `static SteamStatuses DEFAULT`
- `static SteamStatuses DIPLOMACY`
- `static SteamStatuses END_GAME_STATISTICS`
- `static SteamStatuses LEADERBOARD`
- `static SteamStatuses MAIN_MENU`
- `static SteamStatuses MODDING`
- `static SteamStatuses NONE`
- `static SteamStatuses RESEARCH`
- `static SteamStatuses SETTINGS`
- `static SteamStatuses STARTING_CAMPAIGN`
- `static SteamStatuses STARTING_QUICKGAME`
- `Int32 value__`

---


## SteamWorkshopMenu

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ClosePanel_Button()`
- `Void CreateMod()`
- `Void CreateModFolder()`
- `Void CreateTilesTemplates()`
- `Void CreateUnitsTemplates()`
- `Void DeleteMod()`
- `Void ModifyModName()`
- `Void RefreshListOfUserMadeMods()`
- `Void UpdateItem()`
- `Void UploadMod()`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## StoreGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void BuyAll()`
- `Void CalculateBasketTotalPrice()`
- `Void CloseStorePanel()`
- `Void DuplicateBasketUnit(Unit p_unit)`
- `Void EmptyAllUnitSlots()`
- `Void EmptyBasketSlots()`
- `Void EmptyComparisonStats()`
- `Unit GetUnitToUpgrade()`
- `Void OpenPanelInEventMode(EventActionSlotGO p_eventActionSlotGO)`
- `Void OpenPanelInPurchaseMode()`
- `Void OpenPanelInUpgradeMode(Unit p_unit)`
- `Void PopulateBasketSlots()`
- `Void RemoveUnitFromBasket(Unit p_unit)`
- `Void SelectFilter(String p_filter)`
- `Void SetCoreUnit()`
- `Void SetOptionUnit(UnitStoreSlotGO p_unitStoreSlotGO, String p_optionName)`
- `Void SetUnitPrice(Unit p_unit)`
- `Void ShowSelectedUnitStats(Unit unit)`

### Public Properties

*No public properties*

### Public Fields

- `TextMeshProUGUI airDamage`
- `TextMeshProUGUI airDamageComparison`
- `TextMeshProUGUI ammo`
- `TextMeshProUGUI ammoComparison`
- `TextMeshProUGUI armour`
- `TextMeshProUGUI armourComparison`
- `GameObject basketSlotCorePrefab`
- `GameObject basketSlotPrefab`
- `TextMeshProUGUI basketTotalPrice_Text`
- `Button buy_button`
- `TextMeshProUGUI buy_text`
- `List`1 categoriesImages`
- `GameObject coreUnit_Button`
- `TMP_Dropdown filterCountry_Dropdown`
- `String filterType`
- `TextMeshProUGUI fuel`
- `TextMeshProUGUI fuelComparison`
- `TextMeshProUGUI hardDamage`
- `TextMeshProUGUI hardDamageComparison`
- `TextMeshProUGUI HP`
- `TextMeshProUGUI HPcomparison`
- `TextMeshProUGUI HQPoints_text`
- `static StoreGO instance`
- `TextMeshProUGUI MP`
- `TextMeshProUGUI MPComparison`
- `Transform parentForBasket_Transform`
- `Transform parentForUnitsSlot_Transform`
- `TextMeshProUGUI productionYear`
- `TextMeshProUGUI Range`
- `TextMeshProUGUI rangeComparison`
- `Sprite selectedABomb_Sprite`
- `Sprite selectedBomb_Sprite`
- `List`1 selectedCategories`
- `Sprite selectedCensoredSS_Sprite`
- `Sprite selectedDropTank_Sprite`
- `Sprite selectedElite_Sprite`
- `Sprite selectedGuards_Sprite`
- `Sprite selectedHorse_Sprite`
- `Sprite selectedMechanized_Sprite`
- `Sprite selectedMotorized_Sprite`
- `Sprite selectedMountaineer_Sprite`
- `Sprite selectedRocket_Sprite`
- `Sprite selectedSS_Sprite`
- `Sprite selectedTorpedo_Sprite`
- `Unit selectedUnit`
- `Sprite selectedWinterSpecialized_Sprite`
- `TextMeshProUGUI softDamage`
- `TextMeshProUGUI softDamageComparison`
- `TextMeshProUGUI turnProduction`
- `TextMeshProUGUI turnProductionComparison`
- `GameObject turnToProduceBox`
- `List`1 unitsBasket`
- `UnitStoreSlotGO unitSlotPrefab`
- `Sprite unselectedABomb_Sprite`
- `Sprite unselectedBomb_Sprite`
- `Sprite unselectedCensoredSS_Sprite`
- `Sprite unselectedDropTank_Sprite`
- `Sprite unselectedElite_Sprite`
- `Sprite unselectedGuards_Sprite`
- `Sprite unselectedHorse_Sprite`
- `Sprite unselectedMechanized_Sprite`
- `Sprite unselectedMotorized_Sprite`
- `Sprite unselectedMountaineer_Sprite`
- `Sprite unselectedRocket_Sprite`
- `Sprite unselectedSS_Sprite`
- `Sprite unselectedTorpedo_Sprite`
- `Sprite unselectedWinterSpecialized_Sprite`
- `UnitStoreSlotGO upgradeFromUnit`
- `UnitStoreSlotGO upgradeIntoUnit`
- `Boolean upgradeMode`
- `TextMeshProUGUI upkeep`
- `GameObject upkeepBox`
- `TextMeshProUGUI upkeepComparison`
- `TextMeshProUGUI Visibility`
- `TextMeshProUGUI visibilityComparison`

---


## TargetGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Destroy()`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## TechTreeTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## testMarker

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `GameObject Place`

---


## Tile

### Public Methods

- `Void DestroyTile(Boolean p_sendRPC)`
- `Unit get_AirUnit()`
- `Boolean get_Bridge()`
- `Boolean get_CanFreezeInWinter()`
- `Boolean get_Capturable()`
- `String get_CityName()`
- `Int16 get_DamageModificator()`
- `Int16 get_EditorOverwrite_income()`
- `Int32 get_EditorOverwrite_manpower()`
- `String get_FilterType()`
- `Unit get_GroundUnit()`
- `Boolean get_IsBridgeDestroyed()`
- `Boolean get_IsOfficial()`
- `Boolean get_IsReinforcementTile()`
- `Boolean get_IsVictoryPoint()`
- `Int32 get_Manpower()`
- `Int16 get_MoneyProductionPerTurn()`
- `Int16 get_MoneyReward()`
- `Byte get_MPCost()`
- `String get_Name()`
- `Byte get_NumberOfTurnsAtLowProd()`
- `Byte get_NumberOfTurnsSinceVPGotCaptured()`
- `Int32 get_OccupiedManpower()`
- `Int16 get_OccupiedMoneyProductionPerTurn()`
- `String get_OriginalCountryOwner()`
- `String get_OwnerName()`
- `Boolean get_PrimaryObjective()`
- `Boolean get_Railroad()`
- `String get_Season()`
- `Boolean get_SeasonNeverChanges()`
- `Boolean get_SecondaryObjective()`
- `String get_Type()`
- `Int32 GetAnnexTileCost(Player p_playerRequesting)`
- `Coordinates GetCoord()`
- `Byte GetDestroyedTurnsAmount()`
- `String GetLocalizedDisplayName()`
- `Byte GetMinimumOccupancyForWork()`
- `Int32 GetRequestOwnershipCost(Player p_playerRequesting)`
- `Int32 GetTileSuppliesPenalty(Unit p_unit)`
- `Boolean HasEnemyAround(Unit p_unitToCheckWith)`
- `Boolean IsDestroyable()`
- `Boolean IsValidSupplySource()`
- `Boolean IsWW1TrenchTile()`
- `Void set_AirUnit(Unit value)`
- `Void set_Bridge(Boolean value)`
- `Void set_CanFreezeInWinter(Boolean value)`
- `Void set_Capturable(Boolean value)`
- `Void set_CityName(String value)`
- `Void set_DamageModificator(Int16 value)`
- `Void set_EditorOverwrite_income(Int16 value)`
- `Void set_EditorOverwrite_manpower(Int32 value)`
- `Void set_FilterType(String value)`
- `Void set_GroundUnit(Unit value)`
- `Void set_IsBridgeDestroyed(Boolean value)`
- `Void set_IsOfficial(Boolean value)`
- `Void set_IsReinforcementTile(Boolean value)`
- `Void set_IsVictoryPoint(Boolean value)`
- `Void set_Manpower(Int32 value)`
- `Void set_MoneyProductionPerTurn(Int16 value)`
- `Void set_MoneyReward(Int16 value)`
- `Void set_MPCost(Byte value)`
- `Void set_Name(String value)`
- `Void set_NumberOfTurnsAtLowProd(Byte value)`
- `Void set_NumberOfTurnsSinceVPGotCaptured(Byte value)`
- `Void set_OccupiedManpower(Int32 value)`
- `Void set_OccupiedMoneyProductionPerTurn(Int16 value)`
- `Void set_OriginalCountryOwner(String value)`
- `Void set_OwnerName(String value)`
- `Void set_PrimaryObjective(Boolean value)`
- `Void set_Railroad(Boolean value)`
- `Void set_Season(String value)`
- `Void set_SeasonNeverChanges(Boolean value)`
- `Void set_SecondaryObjective(Boolean value)`
- `Void set_Type(String value)`
- `Void SetBorderHex()`
- `Void SetRuntimeOptimizations()`
- `Void SetTileSeason()`
- `Void SetTileType()`
- `Void SetupForAStar()`

### Public Properties

- `Unit AirUnit` { get; set }
- `Boolean Bridge` { get; set }
- `Boolean CanFreezeInWinter` { get; set }
- `Boolean Capturable` { get; set }
- `String CityName` { get; set }
- `Int16 DamageModificator` { get; set }
- `Int16 EditorOverwrite_income` { get; set }
- `Int32 EditorOverwrite_manpower` { get; set }
- `String FilterType` { get; set }
- `Unit GroundUnit` { get; set }
- `Boolean IsBridgeDestroyed` { get; set }
- `Boolean IsOfficial` { get; set }
- `Boolean IsReinforcementTile` { get; set }
- `Boolean IsVictoryPoint` { get; set }
- `Int32 Manpower` { get; set }
- `Int16 MoneyProductionPerTurn` { get; set }
- `Int16 MoneyReward` { get; set }
- `Byte MPCost` { get; set }
- `String Name` { get; set }
- `Byte NumberOfTurnsAtLowProd` { get; set }
- `Byte NumberOfTurnsSinceVPGotCaptured` { get; set }
- `Int32 OccupiedManpower` { get; set }
- `Int16 OccupiedMoneyProductionPerTurn` { get; set }
- `String OriginalCountryOwner` { get; set }
- `String OwnerName` { get; set }
- `Boolean PrimaryObjective` { get; set }
- `Boolean Railroad` { get; set }
- `String Season` { get; set }
- `Boolean SeasonNeverChanges` { get; set }
- `Boolean SecondaryObjective` { get; set }
- `String Type` { get; set }

### Public Fields

- `Byte amountOfNeighbours`
- `Boolean applyZoneOfControl`
- `Int32 cost`
- `TileSeason enumSeason`
- `TileTypes enumType`
- `Boolean hasBeenLinked`
- `Boolean hasOwnerPlayer`
- `Boolean hasRoads`
- `Boolean hasTerrainOwnerPlayer`
- `Boolean isBorderHex`
- `Boolean isCoastLineTile`
- `Boolean isFrozen`
- `Boolean isJungleTile`
- `Boolean isLakeTile`
- `Boolean isNavalConvoyRoute`
- `Boolean isOccupied`
- `Boolean isPartOfArea`
- `Boolean isRADARtile`
- `Boolean isRoadOrPlain`
- `Boolean isShortestPath`
- `Boolean isSonarTile`
- `Boolean isValidHarbourForAI`
- `Boolean isVisible`
- `Nullable`1 landAreaIndex`
- `List`1 neighbours`
- `Boolean OnQueue`
- `Player ownerPlayer`
- `Tile parent`
- `Int16 PosX`
- `Int16 PosY`
- `Nullable`1 riverAreaIndex`
- `Nullable`1 seaAreaIndex`
- `Boolean searched`
- `Player terrainOwner`
- `String terrainOwnerName`
- `TileGO tileGO`
- `Boolean unreachable`
- `Boolean visited`

---


## TileEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AddOfficialTile()`
- `Void AddTile()`
- `Void CopyTile()`
- `Void CreateNewTile()`
- `Void GenerateTileList()`
- `Void PastTile()`
- `Void RefreshTilesList()`
- `Void RemoveTile()`
- `Void ResearchUnit()`
- `Void SaveAll()`
- `Void SelectModToEdit()`
- `Void SelectTile(Tile p_tile)`
- `Void SetBridge()`
- `Void SetCapturable()`
- `Void SetManpower()`
- `Void SetMapEditorCategory()`
- `Void SetOccupiedManpower()`
- `Void SetRailroad()`
- `Void SetReinforcement()`
- `Void SetTileCaptureMoneyReward()`
- `Void SetTileDamageModifier()`
- `Void SetTileMovemenCost()`
- `Void SetTileName()`
- `Void SetTileOccupiedProductionPerTurn()`
- `Void SetTileProductionPerTurn()`
- `Void SetTileSeason()`
- `Void SetTileType()`
- `Void ShowTileStats()`

### Public Properties

*No public properties*

### Public Fields

- `Button add_Button`
- `Button addOfficial_Button`
- `TMP_Dropdown biomeFilter_Dropdown`
- `Toggle bridge_toggle`
- `Toggle capturable_toggle`
- `TMP_InputField captureMoneyReward_InputField`
- `Button copy_button`
- `TMP_InputField damageModifier_InputField`
- `Button delete_Button`
- `TMP_InputField manpower_InputField`
- `TMP_Dropdown mods_Dropdown`
- `TMP_InputField moneyProductionPerTurn_InputField`
- `TMP_InputField movementPointCost_InputField`
- `TMP_InputField occupiedManpower_InputField`
- `TMP_InputField occupiedMoneyProductionPerTurn_InputField`
- `Transform parentForListOfTiles`
- `Button paste_button`
- `Toggle railroad_toggle`
- `Toggle reinforcement_toggle`
- `TMP_InputField research_InputField`
- `GameObject selectedTileBackground`
- `TMP_Dropdown tileMapEditorCategory_Dropdown`
- `TMP_InputField tileName_InputField`
- `Image tileRepresentation_Image`
- `TMP_Dropdown tileSeason_Dropdown`
- `GameObject tileSlotPrefab`
- `TMP_Dropdown tileType_Dropdown`
- `TextMeshProUGUI totalNumberOfTiles`
- `Scrollbar verticalScrollbar`

---


## TileEditorGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void DestroyFlag()`
- `Void ManageVPToBeHeld()`
- `Void RemoveUnits()`
- `Void SpawnUnit(Unit p_unit)`

### Public Properties

*No public properties*

### Public Fields

- `GameObject airUnitGO`
- `TextMeshPro cityName`
- `GameObject flag`
- `GameObject freezeIcon`
- `GameObject groundUnitGO`
- `LineRenderer lineRenderer`
- `GameObject seasonChangeIcon`
- `SpriteRenderer spriteRenderer`
- `Tile tile`

---


## TileGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ClearUnitSpotted()`
- `Void CopyTileGOFogOfWarSetting(TileGO p_sourceTileGO)`
- `Sprite GetSprite()`
- `Color GetSpriteColor()`
- `Void HighlightTile()`
- `Void RemoveFogOfWar()`
- `Void SetCityName()`
- `Void SetFogOfWar()`
- `Void SetSmoke()`
- `Void SetSprite()`
- `Void SetVPFlag()`
- `Boolean SpawnUnit(Unit p_unit, Boolean p_playSound, Boolean p_sendRPC, Boolean p_selectNextUnitToDeploy)`
- `Void SpotUnit(Unit p_unit)`

### Public Properties

*No public properties*

### Public Fields

- `UnitGO airUnitGO`
- `GameObject buildingIcon`
- `GameObject cityNameGO`
- `GameObject flagGO`
- `UnitGO groundUnitGO`
- `Boolean isInFogOfWar`
- `LineRenderer lineRenderer`
- `GameObject smoke`
- `Tile tile`
- `UnitGO unitGOmakingThisTileAvailableForDeployment`

---


## TileSeason

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static TileSeason DESERT`
- `static TileSeason SUMMER`
- `Int32 value__`
- `static TileSeason WINTER`

---


## TilesManagerGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AnnexTile(TileGO p_tileGO, Player p_player)`
- `Void ClickedOnTile(TileGO p_tileGO)`
- `Void DisableTilesManagerPanel()`
- `Void EnableTilesManagerPanel()`
- `GameObject GetTransferPanel()`
- `GameObject GetTransferSlot()`
- `Void RequestTile(TileGO p_tileGO)`
- `Void ToggleTilesManagerPanel()`
- `Void TransferTile(TileGO p_tileGO, Player p_player)`

### Public Properties

*No public properties*

### Public Fields

- `static TilesManagerGO instance`
- `static Boolean isOpen`

---


## TileTransferSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `TileGO GetTileGO()`
- `Boolean IsLinkedToTile(TileGO p_tileGO)`
- `Void Setup(TileGO p_tileGO)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## TileTypes

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static TileTypes AIRPORT`
- `static TileTypes CITY`
- `static TileTypes FACTORY`
- `static TileTypes FOREST`
- `static TileTypes HARBOUR`
- `static TileTypes HILL`
- `static TileTypes MARSH`
- `static TileTypes MOUNTAIN`
- `static TileTypes NONE`
- `static TileTypes PLAIN`
- `static TileTypes REFINERY`
- `static TileTypes RIVER`
- `static TileTypes ROAD`
- `static TileTypes SEA`
- `static TileTypes TRENCH`
- `Int32 value__`

---


## TooltipFlagGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData p_eventData)`
- `Void OnPointerExit(PointerEventData p_eventData)`

### Public Properties

*No public properties*

### Public Fields

- `Boolean ForceShowTooltip`

---


## TooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData p_eventData)`
- `Void OnPointerExit(PointerEventData p_eventData)`

### Public Properties

*No public properties*

### Public Fields

- `String forcedText`
- `Boolean ForceShowTooltip`
- `String localizationKey`

---


## TurnManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void ButtonNextTurn()`
- `Void CloseEndTurnPanel()`
- `Void DiplomacyChanged(Boolean p_refreshBorders)`
- `Void ManageWeather()`
- `Void NextTurn(Boolean p_sendRPC)`
- `Void ProcessSingleEvent(Event p_event, EventData eventData)`
- `Void ResetRadarSpottings()`
- `Void ScenarioStartAnimateHourglass()`
- `Void ShowHumanEndTurnPanel()`

### Public Properties

*No public properties*

### Public Fields

- `static Player currPlayer`
- `TextMeshProUGUI Date_Text`
- `GameObject endTurn_Panel`
- `FadeTileGO fadeTileGO_prefab`
- `static Player humanPlayer`
- `static TurnManager instance`
- `static Boolean isBadWeather`
- `Image nextHumanPlayer_image`
- `TextMeshProUGUI nextHumanPlayer_text`
- `OrderOfBattleGO OrderOfBattleGO`
- `TMP_InputField password_inputfield`
- `GameObject rainParticles`
- `AudioClip rainSound`
- `AnimationCurve researchRate`
- `GameObject rightSideUI_panel`
- `Animator sablierQuiTourne_Animator`
- `GameObject snowParticles`
- `AudioClip snowSound`
- `GameObject startmyturn_button`
- `TextMeshProUGUI turnNumber`
- `GameObject units`

---


## TutorialActions

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static TutorialActions ATTACK_ENEMY_UNIT`
- `static TutorialActions BOMBARD_ENEMY_UNIT`
- `static TutorialActions BUILD_SOMETHING`
- `static TutorialActions CAMERA_MOVE`
- `static TutorialActions CAMERA_ZOOM`
- `static TutorialActions CHECK_SUPPLIES_STATUS`
- `static TutorialActions DECLARE_WAR`
- `static TutorialActions DEPLOY_CARRIER_PLANE`
- `static TutorialActions DEPLOY_LAND_MINES`
- `static TutorialActions DEPLOY_MINES`
- `static TutorialActions DEPLOY_NAVAL_MINES`
- `static TutorialActions DEPLOY_UNIT`
- `static TutorialActions DESTROY_ENEMY_UNIT`
- `static TutorialActions DISBAND_UNIT`
- `static TutorialActions DROP_PARATROOPERS`
- `static TutorialActions EMBARK_IN_BOAT`
- `static TutorialActions EMBARK_IN_PLANE`
- `static TutorialActions EMBARK_IN_TRAIN`
- `static TutorialActions END_TURN`
- `static TutorialActions INVITE_TO_FACTION`
- `static TutorialActions MOVE_UNIT`
- `static TutorialActions NONE`
- `static TutorialActions OPEN_DAMAGE_BREAKDOWN`
- `static TutorialActions OPEN_DIPLOMACY_MENU`
- `static TutorialActions OPEN_FORECAST_WINDOW`
- `static TutorialActions OPEN_MANPOWER_WINDOW`
- `static TutorialActions OPEN_OBJECTIVE_WINDOW`
- `static TutorialActions OPEN_ORDER_OF_BATTLE_MENU`
- `static TutorialActions OPEN_POLICIES_MENU`
- `static TutorialActions OPEN_RESEARCH_MENU`
- `static TutorialActions OPEN_RESERVE_MENU`
- `static TutorialActions OPEN_UNIT_HISTORY`
- `static TutorialActions OPEN_UPKEEP_WINDOW`
- `static TutorialActions PERFORM_LANDING`
- `static TutorialActions PICK_POLICY`
- `static TutorialActions PURCHASE_UNIT`
- `static TutorialActions REDEPLOY_UNIT`
- `static TutorialActions REPAIR_BRIDGE`
- `static TutorialActions RESUPPLY_UNIT`
- `static TutorialActions SELECT_UNIT`
- `static TutorialActions START_RESEARCH`
- `static TutorialActions SUBMARINE_DIVE`
- `static TutorialActions TRANSFER_UNIT`
- `static TutorialActions UPGRADE_UNIT`
- `Int32 value__`

---


## TutorialManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void add_OnPageCompleted(Action`2 value)`
- `Void add_OnPageStarted(Action`2 value)`
- `Void add_OnStepCompleted(Action`1 value)`
- `Void add_OnTutorialCompleted(Action value)`
- `Void ClosedTutorialWindow()`
- `Void Continue()`
- `Void GoBack()`
- `static Boolean HasAction(TutorialActions p_action)`
- `Void OpenedTutorialWindow()`
- `static Void PerformAction(TutorialActions p_action, Boolean p_useInstance)`
- `Void remove_OnPageCompleted(Action`2 value)`
- `Void remove_OnPageStarted(Action`2 value)`
- `Void remove_OnStepCompleted(Action`1 value)`
- `Void remove_OnTutorialCompleted(Action value)`
- `Void SkipStep()`

### Public Properties

*No public properties*

### Public Fields

- `static TutorialManager instance`

---


## TutorialPage

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `String bodyLocalizationID`
- `List`1 tasks`
- `String titleLocalizationID`

---


## TutorialStepData

**Base Class:** `UnityEngine.ScriptableObject`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `List`1 pages`

---


## TutorialTask

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `TutorialActions action`
- `String localizationID`

---


## TutorialTaskUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Setup(String p_text, Boolean p_done)`
- `Void UpdateTaskStatus(Boolean p_done)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## TutorialWindow

**Base Class:** `UIWindowController`

### Public Methods

- `Void AddTask(TutorialTaskUI p_tutorialTaskUI)`
- `Void ClearTasks()`
- `Void SetBody(String p_text)`
- `Void SetTitle(String p_text)`

### Public Properties

*No public properties*

### Public Fields

- `GameObject nextButton`
- `GameObject prevButton`
- `GameObject skipButton`

---


## TweenAction

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static TweenAction ALPHA`
- `static TweenAction ALPHA_VERTEX`
- `static TweenAction CALLBACK`
- `static TweenAction CALLBACK_COLOR`
- `static TweenAction CANVAS_ALPHA`
- `static TweenAction CANVAS_COLOR`
- `static TweenAction CANVAS_MOVE`
- `static TweenAction CANVAS_MOVE_X`
- `static TweenAction CANVAS_MOVE_Y`
- `static TweenAction CANVAS_MOVE_Z`
- `static TweenAction CANVAS_PLAYSPRITE`
- `static TweenAction CANVAS_ROTATEAROUND`
- `static TweenAction CANVAS_ROTATEAROUND_LOCAL`
- `static TweenAction CANVAS_SCALE`
- `static TweenAction CANVAS_SIZEDELTA`
- `static TweenAction CANVASGROUP_ALPHA`
- `static TweenAction COLOR`
- `static TweenAction DELAYED_SOUND`
- `static TweenAction FOLLOW`
- `static TweenAction GUI_ALPHA`
- `static TweenAction GUI_MOVE`
- `static TweenAction GUI_MOVE_MARGIN`
- `static TweenAction GUI_ROTATE`
- `static TweenAction GUI_SCALE`
- `static TweenAction MOVE`
- `static TweenAction MOVE_CURVED`
- `static TweenAction MOVE_CURVED_LOCAL`
- `static TweenAction MOVE_LOCAL`
- `static TweenAction MOVE_LOCAL_X`
- `static TweenAction MOVE_LOCAL_Y`
- `static TweenAction MOVE_LOCAL_Z`
- `static TweenAction MOVE_SPLINE`
- `static TweenAction MOVE_SPLINE_LOCAL`
- `static TweenAction MOVE_TO_TRANSFORM`
- `static TweenAction MOVE_X`
- `static TweenAction MOVE_Y`
- `static TweenAction MOVE_Z`
- `static TweenAction ROTATE`
- `static TweenAction ROTATE_AROUND`
- `static TweenAction ROTATE_AROUND_LOCAL`
- `static TweenAction ROTATE_LOCAL`
- `static TweenAction ROTATE_X`
- `static TweenAction ROTATE_Y`
- `static TweenAction ROTATE_Z`
- `static TweenAction SCALE`
- `static TweenAction SCALE_X`
- `static TweenAction SCALE_Y`
- `static TweenAction SCALE_Z`
- `static TweenAction TEXT_ALPHA`
- `static TweenAction TEXT_COLOR`
- `Int32 value__`
- `static TweenAction VALUE3`

---


## UIManager

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void BlowUpRepairBridge()`
- `Void CenterCameraOnUnit()`
- `IEnumerator CenterCameraOnUnitCoroutine(Vector3 pos1, Vector3 pos2, Single duration)`
- `static Void CloseConfirmationWindow(GameObject p_confirmationWindow)`
- `Void CloseEndOfGameStatsPanel()`
- `static Void CloseRelationShipMessage(GameObject relationshipWindow)`
- `Void ContinuePlayingGameAfterEnd()`
- `Void DeleteAllWaypoints()`
- `Void DisbandSelectedUnit()`
- `Void DiveGoToSurface()`
- `Void DropParatroopers()`
- `Void EmbarkDisembark()`
- `Void EndOfGameMultiplayer()`
- `static Void EndTurnMultiplayer()`
- `Void FinishedRenamingUnit()`
- `Void GenerateCoreUnitsSlots()`
- `Void GenerateEndOfGameStatistics(String filter)`
- `Sprite GetWeatherSprite(WeatherPredictionData p_weatherPredictionData)`
- `Void GoToMainMenu()`
- `Void HandleMenuStacking(GameObject p_menuOpen)`
- `Void HideTooltip()`
- `static Void HideToolTip()`
- `IEnumerator HighlighTile(Single p_worldPosX, Single p_worldPosY)`
- `Void ManageChatBox()`
- `Void ManageCoreUnitsPanel()`
- `Void ManageDiplomacyPanel()`
- `Void ManageInGameMenu()`
- `Void ManageMinimap()`
- `Void ManageMoreStatsPanel()`
- `Void ManageObjectivesPanel()`
- `Void ManageSoundPanel()`
- `Void ManageStatsPanel()`
- `Void ManageUnitSleep()`
- `Void NextUnit()`
- `Void OpenStorePanel()`
- `Void OpenUnitStatsPanel()`
- `Void OpenUpgradePanel(Unit p_unit)`
- `Void OpenUpgradePanel_Button()`
- `Void PauseUnpause()`
- `Void PrevUnit()`
- `Void QuickSave()`
- `Void QuitGame()`
- `Void QuitToMapEditor()`
- `static Void ReceivedNewHero(UnitGO p_unitGO)`
- `Void RefreshCoreUnits()`
- `Void RefreshCurrentPlayerFlag()`
- `Void RefreshIncomePerTurnUI()`
- `Void RefreshManpower()`
- `Void RefreshMoneyAmountUI()`
- `Void RefreshTechTreeNotification()`
- `Void RenameUnit()`
- `Void ResignMultiplayerGame()`
- `Void ResupplyAmmo()`
- `Void ResupplyAmmoAndFuel()`
- `Void ResupplyFuel()`
- `Void ResupplyHP()`
- `Void SendMessage()`
- `Void SendSelectedUnitBackToReserve()`
- `Void ShowAllWaypoints()`
- `static GameObject ShowConfirmationWindow(String text, Action action)`
- `Void ShowEventMessageWindow(String p_text)`
- `Void ShowHideAirGroundUnit(Boolean doesSound)`
- `Void ShowHideAllIconsForBuildings()`
- `Void ShowHideAllUnits(Boolean p_show)`
- `Void SHowHideAllUnitsButton()`
- `static GameObject ShowMessage(String p_text, Single p_timeOverride)`
- `Void ShowPreviousTurnSummary(Boolean makeClickSound)`
- `static Void ShowRelationshipChangeMessage(String country1, String country2, String text)`
- `Void ShowStatsMidGame()`
- `Void ShowWaypoints(Unit p_unit)`
- `Void SortEndTurnSummary(String p_dataType)`
- `static Void SwitchNATOrepresentation()`
- `Void Undo()`
- `Void UpdateVPtext()`

### Public Properties

*No public properties*

### Public Fields

- `static GameObject activeConfirmationWindow`
- `Sprite awake_SPrite`
- `Sprite badWeather_rain`
- `Sprite badWeather_snow`
- `Button blowRepairBridge_Button`
- `Transform BOTTOM_parent`
- `GameObject buildingIconPrefab`
- `TMP_InputField chat_inputfield`
- `GameObject chat_Notification`
- `GameObject chat_panel`
- `Transform chat_parent`
- `Sprite clearWeather`
- `Button closeEndOfGameMenu_button`
- `GameObject continue_Button`
- `GameObject coreUnitPrefab`
- `GameObject coreUnitsPanel`
- `Transform coreUnitsParent`
- `Image currentPlayerFlag_image`
- `GameObject diplomacy_panel`
- `Sprite dive_sprite`
- `Button diveSurface_Button`
- `Button embarkDisembark_Button`
- `GameObject end_Panel`
- `TextMeshProUGUI endOfScenario_Text`
- `Transform endOfScenarioParent`
- `GameObject endOfScenarioPrefab`
- `GameObject entireUI`
- `Image frozenTile_Image`
- `GameObject heroStats_Panel`
- `GameObject highlightRingPrefab`
- `HoverUnitUI hoverUnitUI`
- `GameObject inGameMenu_Panel`
- `static UIManager instance`
- `static Boolean isNATO`
- `Boolean isSoundPanelOpen`
- `static Boolean isUIOpen`
- `LastTurnSummaryUI lastTurnSummarySlot_prefab`
- `static Single LeftClickTime`
- `GameObject leftUI_GO`
- `Canvas mainCanvas`
- `GameObject mainMenu_Button`
- `GameObject manpower_parent`
- `TextMeshProUGUI manpower_Text`
- `GameObject manpower_tooltip`
- `static EndGameResults matchResult`
- `GameObject message_prefab`
- `Button midGameStatisticsButton`
- `NewMinimap minimap`
- `GameObject money_tooltip`
- `GameObject moreStats_Panel`
- `static String nextMapChoice`
- `Button nextScenarioChoice1_Button`
- `Button nextScenarioChoice2_Button`
- `TextMeshProUGUI numberOfVP_Text`
- `GameObject objectives_Panel`
- `TextMeshProUGUI objectiveScenarioDescription_Text`
- `TextMeshProUGUI objectiveScenarioName_Text`
- `GameObject OOB_panel`
- `Image pause_image`
- `TextMeshProUGUI playerIncomePerTurn_text`
- `TextMeshProUGUI playerMoneyAmount_Text`
- `GameObject Policies_panel`
- `GameObject potentialDamagePanel`
- `GameObject previousTurnSummary_panel`
- `Transform previousTurnSummary_parent`
- `Button quitToMapEditorButton`
- `GameObject research_Notification`
- `GameObject reservePanel`
- `Button resupplyAmmo_Button`
- `Button resupplyBoth_Button`
- `GameObject resupplyCost_Panel`
- `Button resupplyFuel_Button`
- `Button resupplyHP_Button`
- `GameObject saveLoad_Panel`
- `TMP_InputField scenarioDescription_inputField`
- `TextMeshProUGUI scenarioName_text`
- `SelectedUnitExtraStatsUI SelectedUnitExtraStatsUI`
- `SelectedUnitUI selectedUnitUI`
- `static Boolean showAirUnit`
- `Button showDropZone_Button`
- `Sprite skip_sprite`
- `Image sleeping_Button`
- `Sprite sleeping_SPrite`
- `GameObject sound_Panel`
- `TextMeshProUGUI startResumeButton_text`
- `UnitStatsPanelUI stats_Panel`
- `GameObject store_Panel`
- `GameObject supplyLine`
- `Sprite surface_sprite`
- `GameObject techTree_panel`
- `TextMeshProUGUI tileCoordinates_Text`
- `TextMeshProUGUI tileDamageModifier_Text`
- `Image tileInfoOwnerCountry_Image`
- `Image tileInfoRepresentation_Image`
- `TextMeshProUGUI tileMPCost_Text`
- `TextMeshProUGUI tileProduction_text`
- `TextMeshProUGUI tileType_Text`
- `TextMeshProUGUI timePlayed_Text`
- `GameObject tooltip`
- `Image twoUnitsIndicator_image`
- `Sprite twoUnitsIndicatorAirGreen_sprite`
- `Sprite twoUnitsIndicatorGroundGreen_sprite`
- `Transform UI_parent`
- `Button undo_Button`
- `GameObject unitMovePath`
- `TMP_InputField unitName_InputField`
- `Transform unitsParent`
- `Sprite unpredictableWeather`
- `Button upgrade_button`
- `TextMeshProUGUI victoryDefeat_Text`
- `Transform waypointsParent`
- `Image weather_image`
- `TextMeshProUGUI weather_Text`

---


## UIWindowController

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void add_OnMaximized(Action value)`
- `Void add_OnMinimized(Action value)`
- `Void Close()`
- `Void Maximize()`
- `Void Minimize()`
- `Void OnBeginDrag(PointerEventData e)`
- `Void OnDrag(PointerEventData e)`
- `Void OnPointerDown(PointerEventData e)`
- `Void OnPointerEnter(PointerEventData e)`
- `Void OnPointerExit(PointerEventData e)`
- `Void OnPointerUp(PointerEventData e)`
- `Void Open()`
- `Void remove_OnMaximized(Action value)`
- `Void remove_OnMinimized(Action value)`

### Public Properties

*No public properties*

### Public Fields

- `Boolean canMinimizeMaximize`
- `Texture2D cursorMove`
- `Texture2D cursorResizeDiag1`
- `Texture2D cursorResizeDiag2`
- `Texture2D cursorResizeHorizontal`
- `Texture2D cursorResizeVertical`
- `Single dragBorderLeftRight`
- `Single dragBorderUpDown`
- `GameObject maximizeButton`
- `GameObject minimizeButton`
- `Vector2 minimizedSize`
- `Vector2 minWindowSize`
- `Texture2D regularCursor`
- `Single resizeBorder`
- `Boolean useCustomCursors`

---


## Unit

### Public Methods

- `Void AddMorale(Int32 p_amount)`
- `Void AddRemoveActionPoints(Int32 p_value)`
- `Void AddToHistory(String p_text, Boolean p_sendRPC)`
- `Void AddToKillCount(Unit p_unitKilled)`
- `Void AddXP(Int32 p_XPamount, Boolean p_canAddHero, Boolean p_showXPUI)`
- `Void ApplyModdedUnitModifications(Unit p_sourceUnit)`
- `Void ApplyModification(UnitModification p_modification)`
- `Void CacheUnitNameToLower()`
- `Void CalculateAndSetManpowerCost()`
- `Void CalculateAndSetUnitPrice()`
- `Void CalculateAndSetUpkeepValue()`
- `Boolean CanApplyZoneOfControl(Unit p_unit)`
- `Boolean CanMove()`
- `Boolean CanMoveOnMarshes()`
- `Boolean CanMoveOnRivers()`
- `Boolean CanMoveOverMountains()`
- `Unit Clone(Boolean p_generateNewID)`
- `Void EmbarkDisembarkBoat()`
- `Void EmbarkDisembarkPlane()`
- `Void EmbarkDisembarkTrain()`
- `Int32 GenerateNewID()`
- `UInt16 get_AAKill()`
- `Byte get_ActionPoints()`
- `Int16 get_AIPurchaseChanceOverride()`
- `Int16 get_AirDamage()`
- `AllowedRotations get_AllowedRotation()`
- `UInt16 get_AntitankKill()`
- `Int16 get_Armour()`
- `UInt16 get_ArtilleryKill()`
- `AsleepStates get_AsleepState()`
- `Byte get_AttackedAmountThisTurn()`
- `String get_AttackSound()`
- `Boolean get_AutoSupplies()`
- `Int16 get_BaseMaxAutonomy()`
- `UInt16 get_BoatKill()`
- `Boolean get_BuiltByEngineers()`
- `Boolean get_CanAttackShips()`
- `Boolean get_CanBeRefueledOnCarrier()`
- `Boolean get_CanCarryABomb()`
- `Boolean get_CanCarryBombs()`
- `Boolean get_CanCarryDropTank()`
- `Boolean get_CanCarryRockets()`
- `Boolean get_CanCarryTorpedo()`
- `Boolean get_CanCatapultPlanes()`
- `Boolean get_CanLayMines()`
- `UInt16 get_CASKill()`
- `Int16 get_CategoryID()`
- `Boolean get_CoastalBattery()`
- `String get_CommanderTargets()`
- `Int32 get_Cost()`
- `String get_Country()`
- `Int16 get_CurrAmmo()`
- `Int16 get_CurrAutonomy()`
- `Int32 get_CurrHP()`
- `Byte get_CurrMP()`
- `Int32 get_CustomCost()`
- `Int32 get_CustomManpowerCost()`
- `String get_CustomName()`
- `Byte get_CustomTurnProduction()`
- `Single get_CustomUpkeepValue()`
- `Int16 get_EndUseYear()`
- `Byte get_EntrenchmentLevel()`
- `Nullable`1 get_EntrenchmentLevelOnStart()`
- `FacingRotations get_FacingRotation()`
- `UInt16 get_FighterKill()`
- `String get_FilterType()`
- `String get_ForcedCustomName()`
- `Int16 get_HardDamage()`
- `Boolean get_HasABomb()`
- `Boolean get_HasAttacked()`
- `Boolean get_HasBombs()`
- `Boolean get_HasBuilt()`
- `Boolean get_HasDropTank()`
- `Boolean get_HasFlamethrower()`
- `Boolean get_HasMoved()`
- `Boolean get_HasOverrun()`
- `Boolean get_HasResuppliedAmmo()`
- `Boolean get_HasResuppliedFuel()`
- `Boolean get_HasRockets()`
- `Boolean get_HasSonar()`
- `Boolean get_HasTorpedo()`
- `UInt16 get_HeavyBomberKill()`
- `Hero get_Hero()`
- `Nullable`1 get_HPmodifierOnScenarioStart()`
- `Int32 get_ID()`
- `Boolean get_ImmuneToWinterDamage()`
- `UInt16 get_InfantryKill()`
- `Boolean get_IsAmphibious()`
- `Boolean get_IsArmouredTrain()`
- `Boolean get_IsArmourObstacle()`
- `Boolean get_IsCarrier()`
- `Boolean get_IsCatapultPlane()`
- `Boolean get_IsCavalry()`
- `Boolean get_IsCommander()`
- `Boolean get_IsConvoy()`
- `Boolean get_IsCoreUnit()`
- `Boolean get_IsDead()`
- `Boolean get_IsDefensive()`
- `Boolean get_IsDestroyer()`
- `Boolean get_IsDropable()`
- `Boolean get_IsEliteUnit()`
- `Boolean get_IsEngineers()`
- `Boolean get_IsHorsed()`
- `Boolean get_IsKillGoal()`
- `Boolean get_IsLaunchSite()`
- `Boolean get_IsMechanized()`
- `Boolean get_IsMine()`
- `Boolean get_IsMineFlail()`
- `Boolean get_IsMissile()`
- `Boolean get_IsMotorized()`
- `Boolean get_IsMountaineer()`
- `Boolean get_IsOnBoat()`
- `Boolean get_IsParatrooper()`
- `Boolean get_IsPartisans()`
- `Boolean get_IsPatrolBoat()`
- `Boolean get_IsPoliticalUnit()`
- `Boolean get_IsPontoonBridge()`
- `Boolean get_IsPrototype()`
- `Boolean get_IsRADAR()`
- `Boolean get_IsRecon()`
- `Boolean get_IsRemoved()`
- `Boolean get_IsReserve()`
- `Boolean get_IsSubmarine()`
- `Boolean get_IsSubmerged()`
- `Boolean get_IsSupplyDepot()`
- `Boolean get_IsSupplyShip()`
- `Boolean get_IsTrain()`
- `Boolean get_IsWinterSpecialized()`
- `Byte get_Lvl()`
- `Int16 get_MaxAmmo()`
- `Int16 get_MaxAutonomy()`
- `Int32 get_MaxHP()`
- `Byte get_MaxMP()`
- `Int16 get_MaxPurchaseTime()`
- `Byte get_Morale()`
- `String get_MovementSound()`
- `Boolean get_MoveOrAttack()`
- `String get_Name()`
- `Boolean get_NoAmmoTurn1()`
- `Boolean get_NoCapture()`
- `Boolean get_NoEntrenchmentTurn1()`
- `Boolean get_NoLendLease()`
- `Byte get_NumberOfTilesMovedDuringCurrentTurn()`
- `Int16 get_NumberOfTimesTheUnitMoved()`
- `Byte get_NumberOfTurnsUnderWater()`
- `String get_OwnerName()`
- `Boolean get_PermanentDeath()`
- `Byte get_ProductionMonth()`
- `Int16 get_ProductionYear()`
- `Int32 get_ProgressiveCost()`
- `Byte get_Range()`
- `Int16 get_SoftDamage()`
- `List`1 get_StuffThatHappened()`
- `Int16 get_TampAutonomy()`
- `Int16 get_TampMaxAutonomy()`
- `Byte get_TampMaxMP()`
- `Byte get_TampMP()`
- `UInt16 get_TankKill()`
- `Boolean get_TileBuilding()`
- `UInt16 get_TotalDistance()`
- `UInt16 get_TotalKill()`
- `Byte get_TurnToProduce()`
- `String get_Type()`
- `Byte get_Visibility()`
- `List`1 get_Waypoints()`
- `Int16 get_XP()`
- `Int32 GetArmour()`
- `static String GetAuthorizedRotationLocalizationKey(AllowedRotations p_allowedRotation)`
- `Int32 GetHealAmount()`
- `Int32 GetHealCost()`
- `Single GetHPPercent(Boolean p_forDamagePurposes)`
- `Void GetLevelAndXPToNext(Int32& o_level, Int32& o_XPToNextLevel)`
- `MoraleStates GetMoraleState()`
- `String GetMovementSound()`
- `String GetNameToLower()`
- `static Int32 GetNewID32()`
- `Int32 GetPotentialDamage(UnitGO p_targetUnitGO, Boolean p_isRetaliation, Boolean p_isSupportiveFire)`
- `Int32 GetRedeployCost()`
- `Int32 GetResupplyAmmoAndFuelCost()`
- `Int32 GetResupplyAmmoCost()`
- `Int32 GetResupplyFuelCost()`
- `Int32 GetResupplyManpowerCost(Int32 p_HPamount)`
- `String GetSuffix()`
- `UnitCategories GetUnitCategory()`
- `String GetUnitName()`
- `Byte GetUpgradeTurnProduction(Unit p_fromUnit, Byte p_currentProductionTime)`
- `Int32 GetUpkeepCost(Boolean p_getReserveCost)`
- `Int32 GetVeterancyOptionCost()`
- `Void Heal()`
- `Boolean IsConsideredHeavyEquipment()`
- `Boolean IsSpecialUnit()`
- `Void NextScenario()`
- `Void NextTurn()`
- `Void PatchOnNetworkReceived()`
- `Void RedeployUnit(Boolean p_removeMoney, Boolean p_sendRPC)`
- `Void ResupplyAmmo()`
- `Void ResupplyAmmoAndFuel()`
- `Void ResupplyFuel()`
- `Void RevertModification(UnitModification p_modification)`
- `Void set_AAKill(UInt16 value)`
- `Void set_ActionPoints(Byte value)`
- `Void set_AIPurchaseChanceOverride(Int16 value)`
- `Void set_AirDamage(Int16 value)`
- `Void set_AllowedRotation(AllowedRotations value)`
- `Void set_AntitankKill(UInt16 value)`
- `Void set_Armour(Int16 value)`
- `Void set_ArtilleryKill(UInt16 value)`
- `Void set_AsleepState(AsleepStates value)`
- `Void set_AttackedAmountThisTurn(Byte value)`
- `Void set_AttackSound(String value)`
- `Void set_AutoSupplies(Boolean value)`
- `Void set_BaseMaxAutonomy(Int16 value)`
- `Void set_BoatKill(UInt16 value)`
- `Void set_BuiltByEngineers(Boolean value)`
- `Void set_CanAttackShips(Boolean value)`
- `Void set_CanBeRefueledOnCarrier(Boolean value)`
- `Void set_CanCarryABomb(Boolean value)`
- `Void set_CanCarryBombs(Boolean value)`
- `Void set_CanCarryDropTank(Boolean value)`
- `Void set_CanCarryRockets(Boolean value)`
- `Void set_CanCarryTorpedo(Boolean value)`
- `Void set_CanCatapultPlanes(Boolean value)`
- `Void set_CanLayMines(Boolean value)`
- `Void set_CASKill(UInt16 value)`
- `Void set_CategoryID(Int16 value)`
- `Void set_CoastalBattery(Boolean value)`
- `Void set_CommanderTargets(String value)`
- `Void set_Cost(Int32 value)`
- `Void set_Country(String value)`
- `Void set_CurrAmmo(Int16 value)`
- `Void set_CurrAutonomy(Int16 value)`
- `Void set_CurrHP(Int32 value)`
- `Void set_CurrMP(Byte value)`
- `Void set_CustomCost(Int32 value)`
- `Void set_CustomManpowerCost(Int32 value)`
- `Void set_CustomName(String value)`
- `Void set_CustomTurnProduction(Byte value)`
- `Void set_CustomUpkeepValue(Single value)`
- `Void set_EndUseYear(Int16 value)`
- `Void set_EntrenchmentLevel(Byte value)`
- `Void set_EntrenchmentLevelOnStart(Nullable`1 value)`
- `Void set_FacingRotation(FacingRotations value)`
- `Void set_FighterKill(UInt16 value)`
- `Void set_FilterType(String value)`
- `Void set_ForcedCustomName(String value)`
- `Void set_HardDamage(Int16 value)`
- `Void set_HasABomb(Boolean value)`
- `Void set_HasAttacked(Boolean value)`
- `Void set_HasBombs(Boolean value)`
- `Void set_HasBuilt(Boolean value)`
- `Void set_HasDropTank(Boolean value)`
- `Void set_HasFlamethrower(Boolean value)`
- `Void set_HasMoved(Boolean value)`
- `Void set_HasOverrun(Boolean value)`
- `Void set_HasResuppliedAmmo(Boolean value)`
- `Void set_HasResuppliedFuel(Boolean value)`
- `Void set_HasRockets(Boolean value)`
- `Void set_HasSonar(Boolean value)`
- `Void set_HasTorpedo(Boolean value)`
- `Void set_HeavyBomberKill(UInt16 value)`
- `Void set_Hero(Hero value)`
- `Void set_HPmodifierOnScenarioStart(Nullable`1 value)`
- `Void set_ID(Int32 value)`
- `Void set_ImmuneToWinterDamage(Boolean value)`
- `Void set_InfantryKill(UInt16 value)`
- `Void set_IsAmphibious(Boolean value)`
- `Void set_IsArmouredTrain(Boolean value)`
- `Void set_IsArmourObstacle(Boolean value)`
- `Void set_IsCarrier(Boolean value)`
- `Void set_IsCatapultPlane(Boolean value)`
- `Void set_IsCavalry(Boolean value)`
- `Void set_IsCommander(Boolean value)`
- `Void set_IsConvoy(Boolean value)`
- `Void set_IsCoreUnit(Boolean value)`
- `Void set_IsDead(Boolean value)`
- `Void set_IsDefensive(Boolean value)`
- `Void set_IsDestroyer(Boolean value)`
- `Void set_IsDropable(Boolean value)`
- `Void set_IsEliteUnit(Boolean value)`
- `Void set_IsEngineers(Boolean value)`
- `Void set_IsHorsed(Boolean value)`
- `Void set_IsKillGoal(Boolean value)`
- `Void set_IsLaunchSite(Boolean value)`
- `Void set_IsMechanized(Boolean value)`
- `Void set_IsMine(Boolean value)`
- `Void set_IsMineFlail(Boolean value)`
- `Void set_IsMissile(Boolean value)`
- `Void set_IsMotorized(Boolean value)`
- `Void set_IsMountaineer(Boolean value)`
- `Void set_IsOnBoat(Boolean value)`
- `Void set_IsParatrooper(Boolean value)`
- `Void set_IsPartisans(Boolean value)`
- `Void set_IsPatrolBoat(Boolean value)`
- `Void set_IsPoliticalUnit(Boolean value)`
- `Void set_IsPontoonBridge(Boolean value)`
- `Void set_IsPrototype(Boolean value)`
- `Void set_IsRADAR(Boolean value)`
- `Void set_IsRecon(Boolean value)`
- `Void set_IsRemoved(Boolean value)`
- `Void set_IsReserve(Boolean value)`
- `Void set_IsSubmarine(Boolean value)`
- `Void set_IsSubmerged(Boolean value)`
- `Void set_IsSupplyDepot(Boolean value)`
- `Void set_IsSupplyShip(Boolean value)`
- `Void set_IsTrain(Boolean value)`
- `Void set_IsWinterSpecialized(Boolean value)`
- `Void set_Lvl(Byte value)`
- `Void set_MaxAmmo(Int16 value)`
- `Void set_MaxAutonomy(Int16 value)`
- `Void set_MaxHP(Int32 value)`
- `Void set_MaxMP(Byte value)`
- `Void set_MaxPurchaseTime(Int16 value)`
- `Void set_Morale(Byte value)`
- `Void set_MovementSound(String value)`
- `Void set_MoveOrAttack(Boolean value)`
- `Void set_Name(String value)`
- `Void set_NoAmmoTurn1(Boolean value)`
- `Void set_NoCapture(Boolean value)`
- `Void set_NoEntrenchmentTurn1(Boolean value)`
- `Void set_NoLendLease(Boolean value)`
- `Void set_NumberOfTilesMovedDuringCurrentTurn(Byte value)`
- `Void set_NumberOfTimesTheUnitMoved(Int16 value)`
- `Void set_NumberOfTurnsUnderWater(Byte value)`
- `Void set_OwnerName(String value)`
- `Void set_PermanentDeath(Boolean value)`
- `Void set_ProductionMonth(Byte value)`
- `Void set_ProductionYear(Int16 value)`
- `Void set_ProgressiveCost(Int32 value)`
- `Void set_Range(Byte value)`
- `Void set_SoftDamage(Int16 value)`
- `Void set_StuffThatHappened(List`1 value)`
- `Void set_TampAutonomy(Int16 value)`
- `Void set_TampMaxAutonomy(Int16 value)`
- `Void set_TampMaxMP(Byte value)`
- `Void set_TampMP(Byte value)`
- `Void set_TankKill(UInt16 value)`
- `Void set_TileBuilding(Boolean value)`
- `Void set_TotalDistance(UInt16 value)`
- `Void set_TotalKill(UInt16 value)`
- `Void set_TurnToProduce(Byte value)`
- `Void set_Type(String value)`
- `Void set_Visibility(Byte value)`
- `Void set_Waypoints(List`1 value)`
- `Void set_XP(Int16 value)`
- `Void SetCommissionDate()`
- `Void SetDefaultAuthorizedRotation()`
- `Void SetDefaultProductionTime()`
- `Void SetRedeploymentTime()`
- `Void SetUnitCustomName()`
- `Void SetVeterancyOptionCost(Int32 p_cost)`
- `Void SyncFromNetwork(Unit p_sourceUnit, Boolean p_refreshGraphics)`

### Public Properties

- `UInt16 AAKill` { get; set }
- `Byte ActionPoints` { get; set }
- `Int16 AIPurchaseChanceOverride` { get; set }
- `Int16 AirDamage` { get; set }
- `AllowedRotations AllowedRotation` { get; set }
- `UInt16 AntitankKill` { get; set }
- `Int16 Armour` { get; set }
- `UInt16 ArtilleryKill` { get; set }
- `AsleepStates AsleepState` { get; set }
- `Byte AttackedAmountThisTurn` { get; set }
- `String AttackSound` { get; set }
- `Boolean AutoSupplies` { get; set }
- `Int16 BaseMaxAutonomy` { get; set }
- `UInt16 BoatKill` { get; set }
- `Boolean BuiltByEngineers` { get; set }
- `Boolean CanAttackShips` { get; set }
- `Boolean CanBeRefueledOnCarrier` { get; set }
- `Boolean CanCarryABomb` { get; set }
- `Boolean CanCarryBombs` { get; set }
- `Boolean CanCarryDropTank` { get; set }
- `Boolean CanCarryRockets` { get; set }
- `Boolean CanCarryTorpedo` { get; set }
- `Boolean CanCatapultPlanes` { get; set }
- `Boolean CanLayMines` { get; set }
- `UInt16 CASKill` { get; set }
- `Int16 CategoryID` { get; set }
- `Boolean CoastalBattery` { get; set }
- `String CommanderTargets` { get; set }
- `Int32 Cost` { get; set }
- `String Country` { get; set }
- `Int16 CurrAmmo` { get; set }
- `Int16 CurrAutonomy` { get; set }
- `Int32 CurrHP` { get; set }
- `Byte CurrMP` { get; set }
- `Int32 CustomCost` { get; set }
- `Int32 CustomManpowerCost` { get; set }
- `String CustomName` { get; set }
- `Byte CustomTurnProduction` { get; set }
- `Single CustomUpkeepValue` { get; set }
- `Int16 EndUseYear` { get; set }
- `Byte EntrenchmentLevel` { get; set }
- `Nullable`1 EntrenchmentLevelOnStart` { get; set }
- `FacingRotations FacingRotation` { get; set }
- `UInt16 FighterKill` { get; set }
- `String FilterType` { get; set }
- `String ForcedCustomName` { get; set }
- `Int16 HardDamage` { get; set }
- `Boolean HasABomb` { get; set }
- `Boolean HasAttacked` { get; set }
- `Boolean HasBombs` { get; set }
- `Boolean HasBuilt` { get; set }
- `Boolean HasDropTank` { get; set }
- `Boolean HasFlamethrower` { get; set }
- `Boolean HasMoved` { get; set }
- `Boolean HasOverrun` { get; set }
- `Boolean HasResuppliedAmmo` { get; set }
- `Boolean HasResuppliedFuel` { get; set }
- `Boolean HasRockets` { get; set }
- `Boolean HasSonar` { get; set }
- `Boolean HasTorpedo` { get; set }
- `UInt16 HeavyBomberKill` { get; set }
- `Hero Hero` { get; set }
- `Nullable`1 HPmodifierOnScenarioStart` { get; set }
- `Int32 ID` { get; set }
- `Boolean ImmuneToWinterDamage` { get; set }
- `UInt16 InfantryKill` { get; set }
- `Boolean IsAmphibious` { get; set }
- `Boolean IsArmouredTrain` { get; set }
- `Boolean IsArmourObstacle` { get; set }
- `Boolean IsCarrier` { get; set }
- `Boolean IsCatapultPlane` { get; set }
- `Boolean IsCavalry` { get; set }
- `Boolean IsCommander` { get; set }
- `Boolean IsConvoy` { get; set }
- `Boolean IsCoreUnit` { get; set }
- `Boolean IsDead` { get; set }
- `Boolean IsDefensive` { get; set }
- `Boolean IsDestroyer` { get; set }
- `Boolean IsDropable` { get; set }
- `Boolean IsEliteUnit` { get; set }
- `Boolean IsEngineers` { get; set }
- `Boolean IsHorsed` { get; set }
- `Boolean IsKillGoal` { get; set }
- `Boolean IsLaunchSite` { get; set }
- `Boolean IsMechanized` { get; set }
- `Boolean IsMine` { get; set }
- `Boolean IsMineFlail` { get; set }
- `Boolean IsMissile` { get; set }
- `Boolean IsMotorized` { get; set }
- `Boolean IsMountaineer` { get; set }
- `Boolean IsOnBoat` { get; set }
- `Boolean IsParatrooper` { get; set }
- `Boolean IsPartisans` { get; set }
- `Boolean IsPatrolBoat` { get; set }
- `Boolean IsPoliticalUnit` { get; set }
- `Boolean IsPontoonBridge` { get; set }
- `Boolean IsPrototype` { get; set }
- `Boolean IsRADAR` { get; set }
- `Boolean IsRecon` { get; set }
- `Boolean IsRemoved` { get; set }
- `Boolean IsReserve` { get; set }
- `Boolean IsSubmarine` { get; set }
- `Boolean IsSubmerged` { get; set }
- `Boolean IsSupplyDepot` { get; set }
- `Boolean IsSupplyShip` { get; set }
- `Boolean IsTrain` { get; set }
- `Boolean IsWinterSpecialized` { get; set }
- `Byte Lvl` { get; set }
- `Int16 MaxAmmo` { get; set }
- `Int16 MaxAutonomy` { get; set }
- `Int32 MaxHP` { get; set }
- `Byte MaxMP` { get; set }
- `Int16 MaxPurchaseTime` { get; set }
- `Byte Morale` { get; set }
- `String MovementSound` { get; set }
- `Boolean MoveOrAttack` { get; set }
- `String Name` { get; set }
- `Boolean NoAmmoTurn1` { get; set }
- `Boolean NoCapture` { get; set }
- `Boolean NoEntrenchmentTurn1` { get; set }
- `Boolean NoLendLease` { get; set }
- `Byte NumberOfTilesMovedDuringCurrentTurn` { get; set }
- `Int16 NumberOfTimesTheUnitMoved` { get; set }
- `Byte NumberOfTurnsUnderWater` { get; set }
- `String OwnerName` { get; set }
- `Boolean PermanentDeath` { get; set }
- `Byte ProductionMonth` { get; set }
- `Int16 ProductionYear` { get; set }
- `Int32 ProgressiveCost` { get; set }
- `Byte Range` { get; set }
- `Int16 SoftDamage` { get; set }
- `List`1 StuffThatHappened` { get; set }
- `Int16 TampAutonomy` { get; set }
- `Int16 TampMaxAutonomy` { get; set }
- `Byte TampMaxMP` { get; set }
- `Byte TampMP` { get; set }
- `UInt16 TankKill` { get; set }
- `Boolean TileBuilding` { get; set }
- `UInt16 TotalDistance` { get; set }
- `UInt16 TotalKill` { get; set }
- `Byte TurnToProduce` { get; set }
- `String Type` { get; set }
- `Byte Visibility` { get; set }
- `List`1 Waypoints` { get; set }
- `Int16 XP` { get; set }

### Public Fields

- `Int32 armourBreakdown`
- `Int16 BaseAirDamage`
- `Int16 BaseArmour`
- `Int32 baseDamageBreakdown`
- `Int16 BaseHardDamage`
- `Int16 BaseMaxAmmo`
- `Int32 BaseMaxHP`
- `Byte BaseMaxMP`
- `Byte BaseRange`
- `Int16 BaseSoftDamage`
- `Int32 baseUnitCost`
- `Byte BaseVisibility`
- `Int32 biomeBreakdown`
- `Int32 combinedArmsBreakdown`
- `DamageTypes DamageDealingTypeForCommander`
- `Int32 destroyerVSsubmergedSubBreakdown`
- `Int32 encirclementBreakdown`
- `Int32 entrenchmentBreakdown`
- `Int32 FinalDamage`
- `Int32 flamethrowerBreakdown`
- `Int32 generalBreakdown`
- `Int32 heavyBomberVSshipsWithoutTorpedoBreakdown`
- `Int32 heroBreakdown`
- `Int32 hillBreakdown`
- `Int32 HPbreakdown`
- `Int32 landingBreakdown`
- `Int32 manpowerCost`
- `static Byte MAX_LEVEL`
- `static Byte MORALE_DEFAULT`
- `static Byte MORALE_ELITE`
- `Int32 moraleBreakdown`
- `Int32 mountaineerBreakdown`
- `String nameToLower`
- `static Byte NEW_HP_MAX_PER_LEVEL`
- `Int32 othersBreakdown`
- `Boolean OthersNeedUsAsBridge`
- `Boolean OthersNeedUsAsBridgeNotArtificially`
- `Player OwnerPlayer`
- `Int32 policyBreakdown`
- `Int32 politicalUnitsBreakdown`
- `Int32 reconBreakdown`
- `Int32 repeatedAttacksBreakdown`
- `static Single RETREAT_THRESHOLD`
- `Int32 riverBreakdown`
- `Int32 shipVSgroundUnitsBreakdown`
- `Boolean shouldMoveOutNow`
- `Boolean shouldPerformDirectSwap`
- `Int32 subVSlandingCraftBreakdown`
- `Single SupplyPercentage`
- `Int32 swapeeUnitID`
- `Int32 terrainArmouredBreakdown`
- `Int32 terrainBreakdown`
- `Int32 torpedoBreakdown`
- `UnitGO unitGO`
- `Single UpkeepValue`
- `Int32 veterancyBreakdown`
- `Int32 veterancyOptionCost`
- `Int32 weatherBreakdown`
- `Boolean willReplaceUnitMovingOut1`
- `Boolean willReplaceUnitMovingOut2`

---


## UnitCategories

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static UnitCategories AA`
- `static UnitCategories ARMOURED_TRAIN`
- `static UnitCategories ARTILLERY`
- `static UnitCategories AT`
- `static UnitCategories BATTLECRUISER`
- `static UnitCategories BATTLESHIP`
- `static UnitCategories BUILDING`
- `static UnitCategories CARRIER`
- `static UnitCategories CAVALRY`
- `static UnitCategories COMMANDER`
- `static UnitCategories DEFAULT`
- `static UnitCategories DESTROYER`
- `static UnitCategories DREADNOUGHT`
- `static UnitCategories ENGINEER`
- `static UnitCategories FIGHTER`
- `static UnitCategories GARRISON`
- `static UnitCategories GUNBOAT`
- `static UnitCategories HEAVY_BOMBER`
- `static UnitCategories HEAVY_CRUISER`
- `static UnitCategories INFANTRY`
- `static UnitCategories INFANTRY_AT`
- `static UnitCategories LIGHT_BOMBER`
- `static UnitCategories LIGHT_CRUISER`
- `static UnitCategories MARINE`
- `static UnitCategories MILITIA`
- `static UnitCategories PARATROOPER`
- `static UnitCategories PARTISAN`
- `static UnitCategories PROTO_AA`
- `static UnitCategories PROTO_ARTILLERY`
- `static UnitCategories PROTO_AT`
- `static UnitCategories PROTO_FIGHTER`
- `static UnitCategories PROTO_HEAVY_BOMBER`
- `static UnitCategories PROTO_INFANTRY`
- `static UnitCategories PROTO_LIGHT_BOMBER`
- `static UnitCategories PROTO_SHIP`
- `static UnitCategories PROTO_TANK`
- `static UnitCategories SHIP`
- `static UnitCategories SPECIAL_UNIT`
- `static UnitCategories SPG_AA`
- `static UnitCategories SPG_ARTY`
- `static UnitCategories SPG_AT`
- `static UnitCategories SUBMARINE`
- `static UnitCategories TANK`
- `Byte value__`

---


## UnitEditor

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void AddUnit()`
- `Void CopyUnit()`
- `Void CreateNewUnit()`
- `Void ExportCSV()`
- `Void GenerateUnitList(Boolean p_generateSlots)`
- `Void ImportCSV()`
- `Void PasteUnit()`
- `Void RefreshCommanderTargets()`
- `Void RefreshUnitGraphics()`
- `Void RefreshUnitList(Boolean p_generateSlots)`
- `Void RemoveUnit()`
- `Void ResearchUnit()`
- `Void ResetAllUnitsStats()`
- `Void ResetUnitStats()`
- `Void SaveAll()`
- `Void SelectModToEdit()`
- `Void SelectUnit(Unit p_unit, SimpleSlotUI p_simpleSlotUI)`
- `Void SetAmphibious()`
- `Void SetArmouredTrain()`
- `Void SetArmourObstacle()`
- `Void SetBuiltByEngineers()`
- `Void SetCanAttackShips()`
- `Void SetCanBeRefueldAtCarrier()`
- `Void SetCanCarryAbomb()`
- `Void SetCanCarryBombs()`
- `Void SetCanCarryDropTank()`
- `Void SetCanCarryRockets()`
- `Void SetCanCarryTorpedo()`
- `Void SetCanCatapultPlanes()`
- `Void SetCarrier()`
- `Void SetCatapultablePlane()`
- `Void SetCavalry()`
- `Void SetCoastalBattery()`
- `Void SetCommanderTarget(String p_filterType)`
- `Void SetConvoy()`
- `Void SetDestroyer()`
- `Void SetEndOfUseYear()`
- `Void SetEngineers()`
- `Void SetHasFlamethrower()`
- `Void SetHasSonar()`
- `Void SetImmuneToWinterDamage()`
- `Void SetIsCommander()`
- `Void SetIsParatrooper()`
- `Void SetIsPartisans()`
- `Void SetIsPrototype()`
- `Void SetIsRADAR()`
- `Void SetIsSubmarine()`
- `Void SetIsSupplyDepot()`
- `Void SetIsSupplyShip()`
- `Void SetLaunchSite()`
- `Void SetMine()`
- `Void SetMineFlail()`
- `Void SetMissile()`
- `Void SetMoveOrAttack()`
- `Void SetNoCapture()`
- `Void SetNoLendLease()`
- `Void SetPatrolBoat()`
- `Void SetPermanentDeath()`
- `Void SetPontoonBridge()`
- `Void SetProductionMonth()`
- `Void SetProductionYear()`
- `Void SetRecon()`
- `Void SetRemovedFromGame()`
- `Void SetTileBuilding()`
- `Void SetUnitAIPurchaseChanceOverride()`
- `Void SetUnitAirAttack()`
- `Void SetUnitAllowedFacingDirections()`
- `Void SetUnitArmour()`
- `Void SetUnitAttackSound()`
- `Void SetUnitCost()`
- `Void SetUnitCountry()`
- `Void SetUnitCustomManpowerCost()`
- `Void SetUnitCustomTurnProduction()`
- `Void SetUnitFilterType()`
- `Void SetUnitHardAttack()`
- `Void SetUnitMaxAmmo()`
- `Void SetUnitMaxFuel()`
- `Void SetUnitMaxHP()`
- `Void SetUnitMaxMP()`
- `Void SetUnitMaxPurchaseTimes()`
- `Void SetUnitMovementSound()`
- `Void SetUnitName()`
- `Void SetUnitProgressiveCost()`
- `Void SetUnitRange()`
- `Void SetUnitSoftAttack()`
- `Void SetUnitType()`
- `Void SetUnitVisibility()`
- `Void SetUpkeepOverride()`
- `Void ShowUnitStats()`

### Public Properties

*No public properties*

### Public Fields

- `Button add_Button`
- `TMP_InputField AIpurchaseChanceOverride_InputField`
- `TMP_Dropdown allowedRotations_Dropdown`
- `Image amphibious_Image`
- `Image armourObstacle_Image`
- `TMP_Dropdown attackSound_Dropdown`
- `Image builtByEngineers_Image`
- `Image canAttackShips_Image`
- `Image canBeRefueledAtCarier_Image`
- `Image canCarryAbomb_Image`
- `Image canCarryBombs_Image`
- `Image canCarryDropTank_Image`
- `Image canCarryRockets_Image`
- `Image canCarryTorpedo_Image`
- `Image canCatapultPlanes_Image`
- `Image coastalBattery_Image`
- `List`1 commanderTargets_toggles`
- `GameObject commanderTargetsContainer`
- `Button copy_Button`
- `Button delete_Button`
- `Image engineers_Image`
- `TMP_Dropdown filterCountry_Dropdown`
- `TMP_Dropdown filterType_Dropwdown`
- `Image hasFlamethrower_Image`
- `Image hasSonar_Image`
- `Image immuneToWinterDamage_Image`
- `Image isArmouredTrain_Image`
- `Image isCarrier_Image`
- `Image isCatapultPlane`
- `Image isCavalry_Image`
- `Image isCommander_Image`
- `Toggle isCommanderFilter_Toggle`
- `Image isConvoy_Image`
- `Image isDestroyer_Image`
- `Image isLaunchSite_Image`
- `Image isMineFlail_Image`
- `Image isMissle_Image`
- `Image isParatrooper_Image`
- `Image isPartisans_Image`
- `Image isPatrolBoat_Image`
- `Image isPrototype_Image`
- `Image isRadar_Image`
- `Image isRecon_Image`
- `Image isSubmarine_Image`
- `Image isSupplyDepot_Image`
- `Image isSupplyShip_Image`
- `TMP_InputField maxPurchaseTimes_InputField`
- `Image mine_Image`
- `Toggle moddedUnitsOnly_Toggle`
- `TMP_Dropdown mods_Dropdown`
- `TMP_Dropdown movementSound_Dropdown`
- `Image moveOrAttack_Image`
- `Image noCapture_Image`
- `Image noLendLease_Image`
- `Transform parentForListOfUnits`
- `Button paste_Button`
- `Image permanentDeath_Image`
- `Image pontoonBridge_Image`
- `TMP_InputField progressiveCost_InputField`
- `Image removedFromGame_Image`
- `TMP_InputField research_InputField`
- `Button reset_button`
- `Button resetAll_button`
- `GameObject selectedUnitBackground`
- `Sprite tickedOption_Image`
- `Image tileBuilding_Image`
- `TextMeshProUGUI totalNumberOfUnits_Text`
- `TMP_InputField unitAirDamage_InputField`
- `TMP_InputField unitArmour_InputField`
- `Image unitBackground_Image`
- `TMP_InputField unitCost_InputField`
- `TMP_Dropdown unitCountry_Dropdown`
- `TMP_InputField unitEndOfUseYear_InputField`
- `TMP_Dropdown unitFilterType_Dropdown`
- `TMP_InputField unitHardDamage_InputField`
- `TMP_InputField unitManpowerCost_InputField`
- `TMP_InputField unitMaxAmmo_InputField`
- `TMP_InputField unitMaxAutonomy_InputField`
- `TMP_InputField unitMaxHP_InputField`
- `TMP_InputField unitMaxMP_InputField`
- `TMP_InputField unitName_InputField`
- `TMP_InputField unitProductionMonth_InputField`
- `TMP_InputField unitProductionYear_InputField`
- `TMP_InputField unitRange_InputField`
- `Image unitRepresentation_Image`
- `SimpleSlotUI unitSlotPrefab`
- `TMP_InputField unitSoftDamage_InputField`
- `TMP_InputField unitTurnProduction_InputField`
- `TMP_Dropdown unitType_Dropdown`
- `TMP_InputField unitVisibility_InputField`
- `Sprite untickedOption_Image`
- `TMP_InputField upkeepOverride_InputField`
- `GameObject vertical_scrollbar`

---


## UnitGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Single ApplyCombinedArmsBonus(TileGO p_tileOfUnitBeingAttacked)`
- `Single ApplyCommandersBonuses()`
- `Single ApplyReconAttackBonus(TileGO p_targetTileGO)`
- `Void AttackTile(TileGO p_tileGO)`
- `Void AttackUnit(UnitGO p_unitGO, Boolean p_isRetaliationPossible, Boolean p_isSupportPossible, Boolean p_isAmbush)`
- `Int32 CalculateEncirclement()`
- `Void CalculateSupplyRoute(Boolean p_drawSupplyLine)`
- `Boolean CanRetreat(UnitGO p_attackerUnitGO)`
- `Boolean CanSwapUnits(UnitGO p_swapWithUnitGO)`
- `Void DestroyUnit(Boolean p_playAnimation, Boolean p_sendRPC)`
- `Void DisplayAmmoLoss(String p_value)`
- `Void DisplayDamage(UnitGO attackingUnitGO, UnitGO attackedUnitGO)`
- `Void DisplayFuelLoss(String p_value)`
- `Void DisplayLevelUp()`
- `Void DisplayXPGain(String p_value, Boolean p_sendRPC)`
- `Void DiveUndiveSubmarine(Boolean p_sendRPC)`
- `Void DropParatrooper(Boolean p_sendRPC)`
- `Void EmbarkDisembarkBoat(Boolean p_sendRPC)`
- `Void EmbarkDisembarkPlane()`
- `Void EmbarkDisembarkTrain(Boolean p_sendRPC)`
- `Void GetPathToTile(Tile p_targetTile, Boolean p_waypointPath, Boolean p_drawPath)`
- `Single GetRetreatThreshold()`
- `Boolean HasAvailableRailroadNearby()`
- `Void LoadParatrooper(Boolean p_sendRPC)`
- `Void ManageTwoUnitsIndicator()`
- `Void ManageUnitInfoContainer()`
- `Void MoveToWayPoint()`
- `Void MoveUnitToTile(TileGO p_targetTileGO)`
- `Void OpenStatsMenu()`
- `Void RemoveFogOfWarAroundUnit()`
- `Void ResupplyAlly(UnitGO p_supplyTargetUnitGO)`
- `Void RotateAttackedUnit(UnitGO p_unitGOtoRotate, UnitGO p_refUnitGO)`
- `Void RotateUnit(TileGO p_departureTileGO, TileGO p_arrivalTileGO)`
- `Void SelectUnit(Boolean p_playAnimation)`
- `Void SetSprite()`
- `Void SetUnitRotation()`
- `Void ShowPotentialPaths()`
- `Void ShowPotentialTargets()`
- `Void ShowSelectedUnitStats()`
- `Void SwapUnits(UnitGO p_swapWithUnitGO)`
- `Boolean TryCaptureTile(Tile p_tile, Boolean p_sendRPC)`
- `Void UpdateCounter()`

### Public Properties

*No public properties*

### Public Fields

- `GameObject ABomb_GO`
- `List`1 AIpathToVP`
- `TextMeshPro airAttack`
- `SpriteRenderer ammo_Sprite`
- `GameObject anchor_GO`
- `SpriteRenderer backgroundSprite`
- `Byte backupEntrenchmentLevel`
- `Boolean backupHasAttacked`
- `Byte backupHowManyTimesTilesTheUnitMoved`
- `Int16 backupHowManyTimesUnitMoved`
- `GameObject bomb_GO`
- `SpriteRenderer canAttack_Sprite`
- `SpriteRenderer canMove_Sprite`
- `Boolean canOverrun`
- `Boolean canUndo`
- `List`1 currentPath`
- `GameObject dropTank_GO`
- `GameObject elite_GO`
- `SpriteRenderer fuel_Sprite`
- `TileGO goal`
- `TextMeshPro hardAttack`
- `GameObject horse_GO`
- `TextMeshPro HP_TextMesh`
- `Int32 HPsavedForRetaliation`
- `Boolean isMoving`
- `Boolean isRetreating`
- `List`1 listOfNewlyDiscoveredTiles`
- `List`1 listOfpotentialTiles`
- `GameObject mechanized_GO`
- `Byte moraleBackupRetaliation`
- `GameObject motorized_GO`
- `GameObject mountaineer_GO`
- `TextMeshPro movementPoint`
- `TextMeshPro number_textMesh`
- `SpriteRenderer political_Sprite`
- `Int16 prevAutonomy`
- `Int32 prevHP`
- `Byte prevMP`
- `TileGO prevTile`
- `TextMeshPro range`
- `GameObject Recon_GO`
- `GameObject rocket_GO`
- `GameObject seaplane_GO`
- `Boolean showMine`
- `TextMeshPro softAttack`
- `Single spawnTime`
- `GameObject subContainer_GO`
- `List`1 supplyLine`
- `UnitGO targetedUnitGO`
- `TileGO tileGO`
- `GameObject torpedo_GO`
- `GameObject twoUnitsIndicatorGO`
- `Unit unit`
- `GameObject unitInfoContainer`
- `SpriteRenderer unitSprite`
- `GameObject winter_GO`

---


## UnitModification

### Public Methods

- `UnitModification Add(String propName, Double amount, Func`2 predicate)`
- `Void Apply(Unit u)`
- `UnitModification MultiplyAdd(String targetProp, String baseProp, Double factor, Func`2 predicate)`
- `Void Revert(Unit u)`
- `UnitModification Set(String propName, Object value, Func`2 predicate)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## UnitsFilterHelper

### Public Methods

- `static List`1 Filter(IEnumerable`1 source, String filterString)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## UnitSlotStoreGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

- `GameObject messagePopupPrefab`
- `UnitStoreSlotGO unitStoreSlotGO`

---


## UnitStatsPanelUI

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Open(UnitGO p_unitGO)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## UnitStoreSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void RefreshMaxPurchase(Boolean p_isUpgradeMode)`
- `Void RefreshValues()`
- `Void ResetOptions()`
- `Void SetUpSlot(Boolean p_isUpgradeMode)`

### Public Properties

*No public properties*

### Public Fields

- `Button atomBomb_button`
- `Image background_image`
- `Button bomb_button`
- `Button buy_button`
- `Button buyManpower_button`
- `GameObject carrier_option`
- `Image cost_image`
- `Image costManpower_image`
- `GameObject droppable_option`
- `Button dropTank_button`
- `Button elite_button`
- `GameObject flamethrower_option`
- `Button horse_button`
- `Image HQcost_image`
- `Image HQcostManpower_image`
- `Button ideologicalUnit_button`
- `Image limitReached_image`
- `TextMeshProUGUI manpowerCost_text`
- `Button mechanize_button`
- `Button mountaineer_button`
- `GameObject navalAircraft_option`
- `GameObject permanentDeath_option`
- `TextMeshProUGUI price_text`
- `TextMeshProUGUI priceManpower_text`
- `GameObject prototype_option`
- `GameObject radar_option`
- `GameObject recon_option`
- `Image representation_image`
- `Button rocket_button`
- `GameObject seaplane_option`
- `Button slot_button`
- `GameObject sonar_option`
- `Image tooExpensive_image`
- `Button torpedo_button`
- `Button truck_button`
- `Unit unit`
- `TextMeshProUGUI unitName_text`
- `TextMeshProUGUI unitPurchaseLimit_text`
- `TextMeshProUGUI unitPurchaseLimitAmount_text`
- `Button winter_button`

---


## Utils

### Public Methods

- `static Void AssignGeographicalAreas()`
- `static Object BlobToObject(Byte[] p_bytes)`
- `static Void ClearChildrenWith(Transform p_parent, Boolean p_includeInactive)`
- `static Byte[] Compress(Byte[] p_bytes)`
- `static UInt32 ComputeKeyID32(String p_key)`
- `static UInt64 ComputeKeyID64(String p_key)`
- `static Object ConvertByteArrayToObject(Byte[] p_bytes)`
- `static Byte[] ConvertObjectToByteArray(Object p_object)`
- `static Byte[] Decompress(Byte[] p_bytes)`
- `static String FormatReceivedTotal(Int64 p_receivedBytes, Int64 p_totalBytes, Boolean p_includePercent)`
- `static String FormatReceivedTotalBoth(Int64 p_receivedBytes, Int64 p_totalBytes)`
- `static Unit GenerateNewUnit(String p_unitName, String p_unitCountry)`
- `static List`1 GetAllHeroes()`
- `static List`1 GetAllTiles()`
- `static List`1 GetAllTilesInRadiusAround(Tile p_centerTile, Int32 p_radius)`
- `static Void GetAllTilesNeighbours()`
- `static List`1 GetAllUnits(Boolean p_includeRemovedUnits)`
- `static AudioType GetAudioType(String p_extension)`
- `static Double GetDirectorySize(String p_directoryPath)`
- `static String GetFileNameWithoutExtension(FileInfo p_fileInfo)`
- `static Sprite GetFlagSprite(Player p_player)`
- `static Sprite GetFlagSprite(String p_country)`
- `static Sprite GetHeroIconSprite(Unit p_unit)`
- `static Int32 GetHeuristicDistance(Tile p_tileA, Tile p_tileB)`
- `static Int32 GetIndexByLocalizedName(String p_value, List`1 p_values)`
- `static Int32 GetIndexByName(Dropdown p_dropDown, String p_name)`
- `static Int32 GetIndexByName(TMP_Dropdown p_dropDown, String p_name)`
- `static String GetManpowerForUI(Int32 p_manpowerValue)`
- `static Int32 GetMaxCoreUnitsNumber(Player p_player)`
- `static Sprite GetModdedHeroSprite(Hero p_hero)`
- `static List`1 GetModdedUnits()`
- `static Int32 GetMonthDifference(DateTime p_unitDate, DateTime p_currentDate, Boolean p_absoluteValue)`
- `static FileInfo GetMostRecentSaveFile()`
- `static Tile GetOriginalTile(Tile p_tileInstance)`
- `static Sprite GetPoliticalSprite(Unit p_unit)`
- `static Int32 GetRandomNumber(Byte p_numberOfSides)`
- `static String GetSizeInMB(Byte[] p_byteArray)`
- `static Sprite GetTileSprite(Tile p_tile)`
- `static Sprite GetUnitBackground(Unit p_unit, String p_notOriginalCountry)`
- `static Sprite GetUnitSprite(Unit p_unit)`
- `static Boolean HasNKVDAround(Tile p_tile, Unit p_unit)`
- `static Boolean IsMasterClient()`
- `static Boolean IsPointerOverUIObject()`
- `static Boolean IsRealtimeMultiplayer()`
- `static Boolean IsTileInsideRadius(Tile p_tileCheck, Tile p_sourceTile, Int32 p_radius)`
- `static Boolean IsTileInsideRadiusSimplified(Tile p_sourceTile, Tile p_tileCheck, Int32 p_radius)`
- `static Boolean IsUnitRegistered(Unit p_unit, Boolean p_officialOnly)`
- `static Void MakeScreenshot()`
- `static Byte[] ObjectToBlob(Object p_object)`
- `static Void PatchUnit(Unit p_unit)`
- `static Void PatchUnits(List`1 p_units)`
- `static Int32 RoundUp(Int32 p_number)`
- `static Void SetAutoCoasts(Tile p_tile)`
- `static String ShowStopWatch()`
- `static Void StartStopWatch()`
- `static Single Truncate(Single p_value, Int32 p_digits)`
- `static Void UpdateTileProperties(Tile p_targetTile, Tile p_sourceTile, Boolean p_nonDestructive)`
- `static Void UpdateTilesData(Boolean p_nonDestructive)`
- `static Void UpdateUnitStatsOnTurnOne(Unit p_unit, List`1 p_unitsDatabase)`

### Public Properties

*No public properties*

### Public Fields

- `static Double KB`
- `static Double MB`

---


## WeatherPredictionData

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `WeatherType actualWeather`
- `DateTime date`
- `WeatherType predictedWeather`
- `Single predictionAccuracy`
- `Int32 turnNumber`

---


## WeatherSlotGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void Setup(WeatherPredictionData p_weatherPredictionData)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## WeatherTooltipGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

- `Void OnPointerEnter(PointerEventData eventData)`
- `Void OnPointerExit(PointerEventData eventData)`

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


## WeatherType

**Base Class:** `System.Enum`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

- `static WeatherType BAD`
- `static WeatherType CLEAR`
- `Int32 value__`

---


## XPanimationGO

**Base Class:** `UnityEngine.MonoBehaviour`

### Public Methods

*No public methods*

### Public Properties

*No public properties*

### Public Fields

*No public fields*

---


---

## End of API Reference

*This documentation was automatically generated using APIExplorer*
