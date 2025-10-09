// ==================================================================================
// Division Enablers UI
//
// Creates an in-game UI panel for requesting enablers from Division HQ
// Displays available enablers, costs, cooldowns, and remaining uses
//
// ==================================================================================

using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using DivisionEnablersMod;

public class DivisionEnablersUI
{
    static GameObject _mainPanel;
    static bool _isPanelOpen = false;
    static bool _isMinimized = false;
    static Canvas _modCanvas = null;
    static UnityEngine.UI.GraphicRaycaster _graphicRaycaster = null;

    // Colors
    static readonly Color PANEL_BG = new Color(0.1f, 0.1f, 0.12f, 0.95f);
    static readonly Color HEADER_BG = new Color(0.15f, 0.3f, 0.2f, 1f);
    static readonly Color BUTTON_AVAILABLE = new Color(0.2f, 0.6f, 0.3f, 1f);
    static readonly Color BUTTON_UNAVAILABLE = new Color(0.3f, 0.3f, 0.3f, 1f);
    static readonly Color BUTTON_COOLDOWN = new Color(0.6f, 0.4f, 0.2f, 1f);
    static readonly Color TEXT_WHITE = Color.white;
    static readonly Color TEXT_GREY = new Color(0.7f, 0.7f, 0.7f, 1f);

    public static void Initialize()
    {
        Debug.Log("[DivisionEnablers] UI Initialized");
    }

    public static bool IsPanelOpen()
    {
        return _isPanelOpen;
    }

    public static void TogglePanel()
    {
        Debug.Log($"[DivisionEnablers] TogglePanel called - isPanelOpen={_isPanelOpen}");
        if (_isPanelOpen)
            ClosePanel();
        else
            OpenPanel();
    }

    public static void OpenPanel()
    {
        Debug.Log($"[DivisionEnablers] OpenPanel called - isPanelOpen={_isPanelOpen}, GameData={GameData.Instance != null}");

        if (_isPanelOpen)
        {
            Debug.Log("[DivisionEnablers] Panel already open, skipping");
            return;
        }

        if (GameData.Instance == null)
        {
            Debug.LogWarning("[DivisionEnablers] GameData.Instance is null");
            return;
        }

        Player currentPlayer = TurnManager.currPlayer;
        if (currentPlayer == null)
        {
            Debug.LogWarning("[DivisionEnablers] TurnManager.currPlayer is null");
            return;
        }

        // IMPORTANT: Don't set UIManager.isUIOpen to true
        // This would hide all counters on the map
        Debug.Log($"[DivisionEnablers] Creating panel for {currentPlayer.Country}");

        CreatePanel(currentPlayer);
        _isPanelOpen = true;

        Debug.Log($"[DivisionEnablers] Panel created - _mainPanel null? {_mainPanel == null}, active? {_mainPanel?.activeSelf}");
    }

    public static void ClosePanel()
    {
        Debug.Log($"[DivisionEnablers] ClosePanel called - _mainPanel null? {_mainPanel == null}");

        if (_mainPanel != null)
        {
            Object.Destroy(_mainPanel);
            _mainPanel = null;
        }

        // Destroy the canvas entirely so game doesn't see it
        if (_modCanvas != null)
        {
            Object.Destroy(_modCanvas.gameObject);
            _modCanvas = null;
            _graphicRaycaster = null;
            Debug.Log("[DivisionEnablers] Destroyed canvas");
        }

        _isPanelOpen = false;

        Debug.Log($"[DivisionEnablers] Panel closed - isPanelOpen={_isPanelOpen}");
    }

    static void CreatePanel(Player player)
    {
        Canvas canvas = GetCanvas();
        if (canvas == null)
        {
            Debug.LogWarning("[DivisionEnablers] No canvas found");
            return;
        }

        Debug.Log($"[DivisionEnablers] Found canvas: {canvas.name}, renderMode: {canvas.renderMode}");

        // Main panel container
        _mainPanel = new GameObject("DivisionEnablersPanel", typeof(RectTransform), typeof(Image), typeof(CanvasGroup));
        _mainPanel.transform.SetParent(canvas.transform, false);

        Debug.Log($"[DivisionEnablers] Created panel GameObject, parent: {_mainPanel.transform.parent?.name}");

        RectTransform panelRT = _mainPanel.GetComponent<RectTransform>();
        panelRT.anchorMin = new Vector2(1f, 0.5f);  // Anchor to right side
        panelRT.anchorMax = new Vector2(1f, 0.5f);
        panelRT.pivot = new Vector2(1f, 0.5f);
        panelRT.sizeDelta = new Vector2(600f, 500f);
        panelRT.anchoredPosition = new Vector2(-10f, 0f);  // 10px from right edge

        Image panelBG = _mainPanel.GetComponent<Image>();
        panelBG.color = PANEL_BG;
        panelBG.raycastTarget = false; // Don't block mouse clicks to game

        // Configure CanvasGroup to not block raycasts outside panel
        CanvasGroup canvasGroup = _mainPanel.GetComponent<CanvasGroup>();
        canvasGroup.blocksRaycasts = true; // Allow UI interaction
        canvasGroup.interactable = true;

        Debug.Log($"[DivisionEnablers] Panel setup complete - position: {panelRT.anchoredPosition}, size: {panelRT.sizeDelta}, color: {panelBG.color}");

        // Header
        CreateHeader(_mainPanel.transform);

        // Close button
        CreateCloseButton(_mainPanel.transform);

        // Content area (scrollable)
        CreateContentArea(_mainPanel.transform, player);
    }

    static void CreateHeader(Transform parent)
    {
        GameObject header = new GameObject("Header", typeof(RectTransform), typeof(Image));
        header.transform.SetParent(parent, false);

        RectTransform headerRT = header.GetComponent<RectTransform>();
        headerRT.anchorMin = new Vector2(0f, 1f);
        headerRT.anchorMax = new Vector2(1f, 1f);
        headerRT.pivot = new Vector2(0.5f, 1f);
        headerRT.sizeDelta = new Vector2(0f, 60f);
        headerRT.anchoredPosition = Vector2.zero;

        Image headerBG = header.GetComponent<Image>();
        headerBG.color = HEADER_BG;

        // Title text
        GameObject title = new GameObject("Title", typeof(RectTransform));
        title.transform.SetParent(header.transform, false);

        RectTransform titleRT = title.GetComponent<RectTransform>();
        titleRT.anchorMin = new Vector2(0f, 0f);
        titleRT.anchorMax = new Vector2(1f, 1f);
        titleRT.offsetMin = new Vector2(20f, 0f);
        titleRT.offsetMax = new Vector2(-20f, 0f);

        TextMeshProUGUI titleText = title.AddComponent<TextMeshProUGUI>();
        titleText.text = "DIVISION HQ - REQUEST ENABLERS";
        titleText.fontSize = 24f;
        titleText.fontStyle = FontStyles.Bold;
        titleText.alignment = TextAlignmentOptions.Center;
        titleText.color = TEXT_WHITE;
    }

    static void CreateCloseButton(Transform parent)
    {
        GameObject closeBtn = new GameObject("CloseButton", typeof(RectTransform), typeof(Image), typeof(Button));
        closeBtn.transform.SetParent(parent, false);

        RectTransform btnRT = closeBtn.GetComponent<RectTransform>();
        btnRT.anchorMin = new Vector2(1f, 1f);
        btnRT.anchorMax = new Vector2(1f, 1f);
        btnRT.pivot = new Vector2(1f, 1f);
        btnRT.sizeDelta = new Vector2(50f, 50f);
        btnRT.anchoredPosition = new Vector2(-5f, -5f);

        Image btnImage = closeBtn.GetComponent<Image>();
        btnImage.color = new Color(0.8f, 0.2f, 0.2f, 1f);

        Button btn = closeBtn.GetComponent<Button>();
        btn.onClick.AddListener(ClosePanel);

        // X text
        GameObject btnText = new GameObject("Text", typeof(RectTransform));
        btnText.transform.SetParent(closeBtn.transform, false);

        RectTransform textRT = btnText.GetComponent<RectTransform>();
        textRT.anchorMin = Vector2.zero;
        textRT.anchorMax = Vector2.one;
        textRT.offsetMin = Vector2.zero;
        textRT.offsetMax = Vector2.zero;

        TextMeshProUGUI tmp = btnText.AddComponent<TextMeshProUGUI>();
        tmp.text = "X";
        tmp.fontSize = 28f;
        tmp.fontStyle = FontStyles.Bold;
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.color = TEXT_WHITE;
    }

    static void CreateContentArea(Transform parent, Player player)
    {
        // Content container
        GameObject content = new GameObject("Content", typeof(RectTransform));
        content.transform.SetParent(parent, false);

        RectTransform contentRT = content.GetComponent<RectTransform>();
        contentRT.anchorMin = new Vector2(0f, 0f);
        contentRT.anchorMax = new Vector2(1f, 1f);
        contentRT.offsetMin = new Vector2(20f, 20f);
        contentRT.offsetMax = new Vector2(-20f, -70f);

        // Vertical layout for enabler buttons
        VerticalLayoutGroup vlg = content.AddComponent<VerticalLayoutGroup>();
        vlg.spacing = 10f;
        vlg.childAlignment = TextAnchor.UpperCenter;
        vlg.childControlWidth = true;
        vlg.childControlHeight = false;
        vlg.childForceExpandWidth = true;
        vlg.childForceExpandHeight = false;
        vlg.padding = new RectOffset(0, 0, 0, 0);

        // Get player's enabler data
        var playerData = DivisionEnablers.GetPlayerData(player);
        if (playerData == null)
        {
            Debug.LogWarning("[DivisionEnablers] No player data found");
            return;
        }

        // Create button for each enabler
        foreach (var enabler in playerData.enablers)
        {
            CreateEnablerButton(content.transform, player, enabler);
        }
    }

    static void CreateEnablerButton(Transform parent, Player player, DivisionEnablers.Enabler enabler)
    {
        // Button container
        GameObject btnContainer = new GameObject($"Enabler_{enabler.type}", typeof(RectTransform), typeof(Image), typeof(Button), typeof(LayoutElement));
        btnContainer.transform.SetParent(parent, false);

        RectTransform containerRT = btnContainer.GetComponent<RectTransform>();
        containerRT.sizeDelta = new Vector2(0f, 80f);

        LayoutElement le = btnContainer.GetComponent<LayoutElement>();
        le.preferredHeight = 80f;
        le.minHeight = 80f;

        bool canRequest = enabler.CanRequest(player);
        Color buttonColor = canRequest ? BUTTON_AVAILABLE :
                           (enabler.currentCooldown > 0 ? BUTTON_COOLDOWN : BUTTON_UNAVAILABLE);

        Image btnImage = btnContainer.GetComponent<Image>();
        btnImage.color = buttonColor;

        Button btn = btnContainer.GetComponent<Button>();
        btn.onClick.AddListener(() => OnEnablerRequested(player, enabler.type));
        btn.interactable = canRequest;

        // Layout container inside button
        GameObject layout = new GameObject("Layout", typeof(RectTransform), typeof(VerticalLayoutGroup));
        layout.transform.SetParent(btnContainer.transform, false);

        RectTransform layoutRT = layout.GetComponent<RectTransform>();
        layoutRT.anchorMin = Vector2.zero;
        layoutRT.anchorMax = Vector2.one;
        layoutRT.offsetMin = new Vector2(10f, 5f);
        layoutRT.offsetMax = new Vector2(-10f, -5f);

        VerticalLayoutGroup vlg = layout.GetComponent<VerticalLayoutGroup>();
        vlg.spacing = 2f;
        vlg.childAlignment = TextAnchor.UpperLeft;
        vlg.childControlWidth = true;
        vlg.childControlHeight = false;
        vlg.padding = new RectOffset(0, 0, 0, 0);

        // Name
        CreateText(layout.transform, enabler.name, 20f, FontStyles.Bold, TEXT_WHITE);

        // Description
        CreateText(layout.transform, enabler.description, 14f, FontStyles.Normal, TEXT_GREY);

        // Status line
        string status = BuildStatusLine(player, enabler);
        Color statusColor = canRequest ? new Color(0.5f, 1f, 0.5f, 1f) : new Color(1f, 0.5f, 0.5f, 1f);
        CreateText(layout.transform, status, 16f, FontStyles.Normal, statusColor);
    }

    static GameObject CreateText(Transform parent, string text, float fontSize, FontStyles style, Color color)
    {
        GameObject textObj = new GameObject("Text", typeof(RectTransform));
        textObj.transform.SetParent(parent, false);

        RectTransform rt = textObj.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(0f, fontSize + 4f);

        LayoutElement le = textObj.AddComponent<LayoutElement>();
        le.preferredHeight = fontSize + 4f;
        le.minHeight = fontSize + 4f;

        TextMeshProUGUI tmp = textObj.AddComponent<TextMeshProUGUI>();
        tmp.text = text;
        tmp.fontSize = fontSize;
        tmp.fontStyle = style;
        tmp.alignment = TextAlignmentOptions.Left;
        tmp.color = color;
        tmp.enableWordWrapping = true;
        tmp.overflowMode = TextOverflowModes.Ellipsis;

        return textObj;
    }

    static string BuildStatusLine(Player player, DivisionEnablers.Enabler enabler)
    {
        List<string> parts = new List<string>();

        // Cost
        parts.Add($"Cost: ${enabler.costMoney}");

        // Cooldown
        if (enabler.currentCooldown > 0)
            parts.Add($"Cooldown: {enabler.currentCooldown} turns");

        // Uses remaining
        if (enabler.maxUses > 0)
            parts.Add($"Uses: {enabler.remainingUses}/{enabler.maxUses}");

        // Active status
        if (enabler.isActive)
            parts.Add($"ACTIVE ({enabler.remainingDuration} turns)");

        // Money check
        int playerMoney = PlayerHelper.GetMoney(player);
        if (playerMoney < enabler.costMoney)
            parts.Add($"[INSUFFICIENT FUNDS - Need ${enabler.costMoney - playerMoney} more]");

        return string.Join(" | ", parts);
    }

    static void OnEnablerRequested(Player player, DivisionEnablers.EnablerType type)
    {
        // Special handling for artillery - show config panel first
        if (type == DivisionEnablers.EnablerType.ArtillerySupport)
        {
            ShowArtilleryConfigPanel(player);
            return;
        }

        // Special handling for Air Recon - activate targeting flow
        if (type == DivisionEnablers.EnablerType.AirReconnaissance)
        {
            ShowAirReconTargeting(player);
            return;
        }

        bool success = DivisionEnablers.RequestEnabler(player, type);

        if (success)
        {
            // Refresh the panel to show updated state
            ClosePanel();
            OpenPanel();
        }
    }

    static void ShowArtilleryConfigPanel(Player player)
    {
        ClosePanel();
        CreateArtilleryConfigPanel(player);
    }

    static void ShowAirReconTargeting(Player player)
    {
        // Validate availability before entering targeting
        var pdata = DivisionEnablers.GetPlayerData(player);
        var enabler = pdata?.GetEnabler(DivisionEnablers.EnablerType.AirReconnaissance);
        if (enabler == null || !enabler.CanRequest(player))
        {
            UIManager.ShowMessage("Cannot request Air Recon now");
            return;
        }

        // Close panel and start targeting with the enabler's duration
        ClosePanel();
        DivisionEnablersMod.AirReconSystem.ActivateTargeting(player, enabler.activeDuration, radius: 2);
    }

    static Canvas GetCanvas()
    {
        // Create our own dedicated canvas if it doesn't exist
        if (_modCanvas == null)
        {
            GameObject canvasObj = new GameObject("DivisionEnablersModCanvas");
            _modCanvas = canvasObj.AddComponent<Canvas>();
            _modCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
            _modCanvas.sortingOrder = 100; // High sorting order to render on top

            // Add CanvasScaler for proper scaling
            var scaler = canvasObj.AddComponent<UnityEngine.UI.CanvasScaler>();
            scaler.uiScaleMode = UnityEngine.UI.CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920f, 1080f);

            // Add GraphicRaycaster for UI interaction
            _graphicRaycaster = canvasObj.AddComponent<UnityEngine.UI.GraphicRaycaster>();

            Debug.Log("[DivisionEnablers] Created dedicated mod canvas");
        }

        return _modCanvas;
    }

    // Hook to add UI button to game's existing UI
    public static void CreateDivisionHQButton()
    {
        Canvas canvas = GetCanvas();
        if (canvas == null) return;

        GameObject btn = new GameObject("DivisionHQButton", typeof(RectTransform), typeof(Image), typeof(Button));
        btn.transform.SetParent(canvas.transform, false);

        RectTransform btnRT = btn.GetComponent<RectTransform>();
        btnRT.anchorMin = new Vector2(1f, 0.5f);
        btnRT.anchorMax = new Vector2(1f, 0.5f);
        btnRT.pivot = new Vector2(1f, 0.5f);
        btnRT.sizeDelta = new Vector2(120f, 50f);
        btnRT.anchoredPosition = new Vector2(-10f, 100f);

        Image btnImage = btn.GetComponent<Image>();
        btnImage.color = new Color(0.2f, 0.5f, 0.3f, 0.9f);

        Button button = btn.GetComponent<Button>();
        button.onClick.AddListener(TogglePanel);

        // Button text
        GameObject textObj = new GameObject("Text", typeof(RectTransform));
        textObj.transform.SetParent(btn.transform, false);

        RectTransform textRT = textObj.GetComponent<RectTransform>();
        textRT.anchorMin = Vector2.zero;
        textRT.anchorMax = Vector2.one;
        textRT.offsetMin = Vector2.zero;
        textRT.offsetMax = Vector2.zero;

        TextMeshProUGUI tmp = textObj.AddComponent<TextMeshProUGUI>();
        tmp.text = "DIV HQ";
        tmp.fontSize = 18f;
        tmp.fontStyle = FontStyles.Bold;
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.color = Color.white;

        Debug.Log("[DivisionEnablers] Created Division HQ button");
    }

    // ==================================================================================
    // Artillery Configuration Panel
    // ==================================================================================

    static void CreateArtilleryConfigPanel(Player player)
    {
        Canvas canvas = GetCanvas();
        if (canvas == null) return;

        // Main panel
        _mainPanel = new GameObject("ArtilleryConfigPanel", typeof(RectTransform), typeof(Image), typeof(CanvasGroup));
        _mainPanel.transform.SetParent(canvas.transform, false);

        RectTransform panelRT = _mainPanel.GetComponent<RectTransform>();
        panelRT.anchorMin = new Vector2(1f, 0.5f);  // Anchor to right side
        panelRT.anchorMax = new Vector2(1f, 0.5f);
        panelRT.pivot = new Vector2(1f, 0.5f);
        panelRT.sizeDelta = new Vector2(700f, 450f);
        panelRT.anchoredPosition = new Vector2(-10f, 0f);  // 10px from right edge

        Image panelBG = _mainPanel.GetComponent<Image>();
        panelBG.color = PANEL_BG;
        panelBG.raycastTarget = false; // Don't block mouse clicks to game

        // Configure CanvasGroup
        CanvasGroup canvasGroup = _mainPanel.GetComponent<CanvasGroup>();
        canvasGroup.blocksRaycasts = true; // Allow UI interaction
        canvasGroup.interactable = true;

        _isPanelOpen = true;

        // Header
        CreateHeader_Artillery(_mainPanel.transform);

        // Close button
        CreateCloseButton(_mainPanel.transform);

        // Mode selection buttons
        CreateModeSelectionArea(_mainPanel.transform, player);

        // Bottom button area (Confirm/Cancel)
        CreateBottomButtons_Artillery(_mainPanel.transform, player);
    }

    static void CreateHeader_Artillery(Transform parent)
    {
        GameObject header = new GameObject("Header", typeof(RectTransform), typeof(Image));
        header.transform.SetParent(parent, false);

        RectTransform headerRT = header.GetComponent<RectTransform>();
        headerRT.anchorMin = new Vector2(0f, 1f);
        headerRT.anchorMax = new Vector2(1f, 1f);
        headerRT.pivot = new Vector2(0.5f, 1f);
        headerRT.sizeDelta = new Vector2(0f, 60f);
        headerRT.anchoredPosition = Vector2.zero;

        Image headerBG = header.GetComponent<Image>();
        headerBG.color = HEADER_BG;

        // Title
        GameObject title = new GameObject("Title", typeof(RectTransform));
        title.transform.SetParent(header.transform, false);

        RectTransform titleRT = title.GetComponent<RectTransform>();
        titleRT.anchorMin = new Vector2(0f, 0f);
        titleRT.anchorMax = new Vector2(1f, 1f);
        titleRT.offsetMin = new Vector2(20f, 0f);
        titleRT.offsetMax = new Vector2(-20f, 0f);

        TextMeshProUGUI titleText = title.AddComponent<TextMeshProUGUI>();
        titleText.text = "ARTILLERY SUPPORT - SELECT STRIKE MODE";
        titleText.fontSize = 22f;
        titleText.fontStyle = FontStyles.Bold;
        titleText.alignment = TextAlignmentOptions.Center;
        titleText.color = TEXT_WHITE;
    }

    static void CreateModeSelectionArea(Transform parent, Player player)
    {
        GameObject content = new GameObject("Content", typeof(RectTransform));
        content.transform.SetParent(parent, false);

        RectTransform contentRT = content.GetComponent<RectTransform>();
        contentRT.anchorMin = new Vector2(0f, 0f);
        contentRT.anchorMax = new Vector2(1f, 1f);
        contentRT.offsetMin = new Vector2(20f, 70f);
        contentRT.offsetMax = new Vector2(-20f, -70f);

        VerticalLayoutGroup vlg = content.AddComponent<VerticalLayoutGroup>();
        vlg.spacing = 15f;
        vlg.childAlignment = TextAnchor.UpperCenter;
        vlg.childControlWidth = true;
        vlg.childControlHeight = false;
        vlg.childForceExpandWidth = true;
        vlg.padding = new RectOffset(0, 0, 0, 0);

        // Mode buttons
        CreateModeButton(content.transform, player, ArtillerySystem.ArtilleryMode.AreaDamage);
        CreateModeButton(content.transform, player, ArtillerySystem.ArtilleryMode.PrecisionStrike);
        CreateModeButton(content.transform, player, ArtillerySystem.ArtilleryMode.SuppressionBarrage);
    }

    static void CreateModeButton(Transform parent, Player player, ArtillerySystem.ArtilleryMode mode)
    {
        GameObject btnContainer = new GameObject($"Mode_{mode}", typeof(RectTransform), typeof(Image), typeof(Button), typeof(LayoutElement));
        btnContainer.transform.SetParent(parent, false);

        LayoutElement le = btnContainer.GetComponent<LayoutElement>();
        le.preferredHeight = 90f;
        le.minHeight = 90f;

        bool isSelected = ArtillerySystem.CurrentMode == mode;
        Color buttonColor = isSelected ? new Color(0.3f, 0.7f, 0.4f, 1f) : new Color(0.2f, 0.4f, 0.3f, 1f);

        Image btnImage = btnContainer.GetComponent<Image>();
        btnImage.color = buttonColor;

        Button btn = btnContainer.GetComponent<Button>();
        btn.onClick.AddListener(() => OnModeSelected(player, mode));

        // Layout for button content
        GameObject layout = new GameObject("Layout", typeof(RectTransform), typeof(VerticalLayoutGroup));
        layout.transform.SetParent(btnContainer.transform, false);

        RectTransform layoutRT = layout.GetComponent<RectTransform>();
        layoutRT.anchorMin = Vector2.zero;
        layoutRT.anchorMax = Vector2.one;
        layoutRT.offsetMin = new Vector2(15f, 10f);
        layoutRT.offsetMax = new Vector2(-15f, -10f);

        VerticalLayoutGroup vlg = layout.GetComponent<VerticalLayoutGroup>();
        vlg.spacing = 3f;
        vlg.childAlignment = TextAnchor.UpperLeft;
        vlg.childControlWidth = true;
        vlg.childControlHeight = false;

        // Mode name
        string modeName = ArtillerySystem.GetModeName(mode);
        if (isSelected) modeName += " [SELECTED]";
        CreateText(layout.transform, modeName, 20f, FontStyles.Bold, TEXT_WHITE);

        // Description
        string description = ArtillerySystem.GetModeDescription(mode);
        CreateText(layout.transform, description, 16f, FontStyles.Normal, TEXT_GREY);
    }

    static void OnModeSelected(Player player, ArtillerySystem.ArtilleryMode mode)
    {
        ArtillerySystem.CurrentMode = mode;
        Debug.Log($"[Artillery] Mode selected: {mode}");

        // Refresh panel to show selection
        ClosePanel();
        CreateArtilleryConfigPanel(player);
    }

    static void CreateBottomButtons_Artillery(Transform parent, Player player)
    {
        GameObject buttonArea = new GameObject("BottomButtons", typeof(RectTransform));
        buttonArea.transform.SetParent(parent, false);

        RectTransform areaRT = buttonArea.GetComponent<RectTransform>();
        areaRT.anchorMin = new Vector2(0f, 0f);
        areaRT.anchorMax = new Vector2(1f, 0f);
        areaRT.pivot = new Vector2(0.5f, 0f);
        areaRT.sizeDelta = new Vector2(0f, 60f);
        areaRT.anchoredPosition = Vector2.zero;

        HorizontalLayoutGroup hlg = buttonArea.AddComponent<HorizontalLayoutGroup>();
        hlg.spacing = 15f;
        hlg.childAlignment = TextAnchor.MiddleCenter;
        hlg.childControlWidth = true;
        hlg.childControlHeight = true;
        hlg.childForceExpandWidth = true;
        hlg.childForceExpandHeight = false;
        hlg.padding = new RectOffset(20, 20, 10, 10);

        // Confirm button
        CreateActionButton(buttonArea.transform, "CONFIRM & TARGET", new Color(0.2f, 0.7f, 0.3f, 1f), () => OnArtilleryConfirmed(player));

        // Cancel button
        CreateActionButton(buttonArea.transform, "CANCEL", new Color(0.7f, 0.2f, 0.2f, 1f), () => OnArtilleryCancelled());
    }

    static void CreateActionButton(Transform parent, string text, Color color, UnityEngine.Events.UnityAction onClick)
    {
        GameObject btn = new GameObject($"Btn_{text}", typeof(RectTransform), typeof(Image), typeof(Button), typeof(LayoutElement));
        btn.transform.SetParent(parent, false);

        LayoutElement le = btn.GetComponent<LayoutElement>();
        le.preferredHeight = 45f;

        Image btnImage = btn.GetComponent<Image>();
        btnImage.color = color;

        Button button = btn.GetComponent<Button>();
        button.onClick.AddListener(onClick);

        // Button text
        GameObject textObj = new GameObject("Text", typeof(RectTransform));
        textObj.transform.SetParent(btn.transform, false);

        RectTransform textRT = textObj.GetComponent<RectTransform>();
        textRT.anchorMin = Vector2.zero;
        textRT.anchorMax = Vector2.one;
        textRT.offsetMin = Vector2.zero;
        textRT.offsetMax = Vector2.zero;

        TextMeshProUGUI tmp = textObj.AddComponent<TextMeshProUGUI>();
        tmp.text = text;
        tmp.fontSize = 18f;
        tmp.fontStyle = FontStyles.Bold;
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.color = TEXT_WHITE;
    }

    static void OnArtilleryConfirmed(Player player)
    {
        // Check if player can afford artillery
        var playerData = DivisionEnablers.GetPlayerData(player);
        if (playerData == null) return;

        var enabler = playerData.GetEnabler(DivisionEnablers.EnablerType.ArtillerySupport);
        if (enabler == null || !enabler.CanRequest(player))
        {
            UIManager.ShowMessage("Cannot request artillery support!");
            OnArtilleryCancelled();
            return;
        }

        // Deduct cost and activate cooldown
        enabler.Request(player);

        // Close config panel and activate targeting mode
        ClosePanel();
        ArtillerySystem.ActivateTargeting(player);

        Debug.Log($"[Artillery] Targeting activated with mode: {ArtillerySystem.CurrentMode}");
    }

    static void OnArtilleryCancelled()
    {
        ClosePanel();
        // Optionally reopen main Division HQ panel
        // OpenPanel();
    }
}
