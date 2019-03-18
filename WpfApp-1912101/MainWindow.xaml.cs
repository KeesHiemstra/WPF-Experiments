using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_1912101
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public static DateTime Start = DateTime.Now;
    public static int EventsCount = 0;
    public static bool StreamAppend = false;
    public static List<string> Events = new List<string>();

    private static async Task NewEvent(string EventName)
    {
      
      string eventText = $"{DateTime.Now}\t{EventsCount++}\t{(DateTime.Now - Start)}\t{EventName}";
      using (StreamWriter stream = new StreamWriter(@"C:\Etc\Log\Events.log", StreamAppend))
      {
        await stream.WriteLineAsync(eventText);
      }

      StreamAppend = true;
    }

    public MainWindow()
    {
      NewEvent("MainWindow before InitializeComponent()");

      InitializeComponent();

      DataContext = this;
      EventsListBox.ItemsSource = Events;

      NewEvent("MainWindow after InitializeComponent()");
    }

    private void Window_Activated(object sender, EventArgs e)
    {
      NewEvent("Windows_Activated");
    }

    private void Window_Closed(object sender, EventArgs e)
    {
      NewEvent("Windows_Closed");
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      NewEvent("Windows_Closing");
    }

    private void Window_ContentRendered(object sender, EventArgs e)
    {
      NewEvent("Windows_ContentRendered");
    }

    private void Window_ContextMenuClosing(object sender, ContextMenuEventArgs e)
    {
      NewEvent("Windows_ContextMenuClosing");
    }

    private void Window_ContextMenuOpening(object sender, ContextMenuEventArgs e)
    {
      NewEvent("Windows_ContextMenuOpening");
    }

    private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Windows_DataContextChanged");
    }

    private void Window_Deactivated(object sender, EventArgs e)
    {
      NewEvent("Windows_Deactivated");
    }

    private void Window_DpiChanged(object sender, DpiChangedEventArgs e)
    {
      NewEvent("Windows_DpiChanged");
    }

    private void Window_DragEnter(object sender, DragEventArgs e)
    {
      NewEvent("Windows_DragEnter");
    }

    private void Window_DragLeave(object sender, DragEventArgs e)
    {
      NewEvent("Windows_DragLeave");
    }

    private void Window_DragOver(object sender, DragEventArgs e)
    {
      NewEvent("Windows_DragOver");
    }

    private void Window_Drop(object sender, DragEventArgs e)
    {
      NewEvent("Windows_Drop");
    }

    private void Window_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Windows_FocusableChanged");
    }

    private void Window_GiveFeedback(object sender, GiveFeedbackEventArgs e)
    {
      NewEvent("Windows_GiveFeedback");
    }

    private void Window_GotFocus(object sender, RoutedEventArgs e)
    {
      NewEvent("Windows_GetFocus");
    }

    private void Window_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
    {
      NewEvent("Windows_GotKeyboardFocus");
    }

    private void Window_GotMouseCapture(object sender, MouseEventArgs e)
    {
      NewEvent("Windows_GotMouseCapture");
    }

    private void Window_GotStylusCapture(object sender, StylusEventArgs e)
    {
      NewEvent("Windows_GotStylusCapture");
    }

    private void Window_GotTouchCapture(object sender, TouchEventArgs e)
    {
      NewEvent("Windows_GotTouchCapture");
    }

    private void Window_Initialized(object sender, EventArgs e)
    {
      NewEvent("Windows_Initialized");
    }

    private void Window_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Windows_IsEnabledChange");
    }

    private void Window_IsHitTestVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsHitTestVisibleChanged");
    }

    private void Window_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsKeyboardFocusedChanged");
    }

    private void Window_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsKeyboardFocusWithinChanged");
    }

    private void Window_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsMouseCapturedChanged");
    }

    private void Window_IsMouseCaptureWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsMouseCaptureWithinChanged");
    }

    private void Window_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsMouseDirectlyOverChanged");
    }

    private void Window_IsStylusCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsStylusCapturedChanged");
    }

    private void Window_IsStylusCaptureWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsStylusCaptureWithinChanged");
    }

    private void Window_IsStylusDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsStylusDirectlyOverChanged");
    }

    private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
      NewEvent("Window_IsVisibleChanged");
    }

    private void Window_KeyDown(object sender, KeyEventArgs e)
    {
      NewEvent("Window_KeyDown");
    }

    private void Window_KeyUp(object sender, KeyEventArgs e)
    {
      NewEvent("Window_KeyUp");
    }

    private void Window_LayoutUpdated(object sender, EventArgs e)
    {
      NewEvent("Window_LayoutUpdated");
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      NewEvent("Window_Loaded");
    }

    private void Window_LocationChanged(object sender, EventArgs e)
    {
      NewEvent("Window_LocationChanged");
    }

    private void Window_LostFocus(object sender, RoutedEventArgs e)
    {
      NewEvent("Window_LostFocus");
    }

    private void Window_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
    {
      NewEvent("Window_LostKeyboardFocus");
    }

    private void Window_LostMouseCapture(object sender, MouseEventArgs e)
    {
      NewEvent("Window_LostMouseCapture");
    }

    private void Window_LostStylusCapture(object sender, StylusEventArgs e)
    {
      NewEvent("Window_LostStylusCapture");
    }

    private void Window_LostTouchCapture(object sender, TouchEventArgs e)
    {
      NewEvent("Window_LostTouchCapture");
    }

    private void Window_ManipulationBoundaryFeedback(object sender, ManipulationBoundaryFeedbackEventArgs e)
    {
      NewEvent("Window_ManipulationBoundaryFeedback");
    }

    private void Window_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
    {
      NewEvent("Window_ManipulationCompleted");
    }

    private void Window_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
    {
      NewEvent("Window_ManipulationDelta");
    }

    private void Window_ManipulationInertiaStarting(object sender, ManipulationInertiaStartingEventArgs e)
    {
      NewEvent("Window_ManipulationInertiaStarting");
    }

    private void Window_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
    {
      NewEvent("Window_ManipulationStarted");
    }

    private void Window_ManipulationStarting(object sender, ManipulationStartingEventArgs e)
    {
      NewEvent("Window_ManipulationStarting");
    }

    private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_MouseDoubleClick");
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_MouseDown");
    }

    private void Window_MouseEnter(object sender, MouseEventArgs e)
    {
      NewEvent("Window_MouseEnter");
    }

    private void Window_MouseLeave(object sender, MouseEventArgs e)
    {
      NewEvent("Window_MouseLeave");
    }

    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_MouseLeftButtonDown");
    }

    private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_MouseLeftButtonUp");
    }

    private void Window_MouseMove(object sender, MouseEventArgs e)
    {
      NewEvent("Window_MouseMove");
    }

    private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_MouseRightButtonDown");
    }

    private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_MouseRightButtonUp");
    }

    private void Window_MouseUp(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_MouseUp");
    }

    private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
    {
      NewEvent("Window_MouseWheel");
    }

    private void Window_PreviewDragEnter(object sender, DragEventArgs e)
    {
      NewEvent("Window_PreviewDragEnter");
    }

    private void Window_PreviewDragLeave(object sender, DragEventArgs e)
    {
      NewEvent("Window_PreviewDragLeave");
    }

    private void Window_PreviewDragOver(object sender, DragEventArgs e)
    {
      NewEvent("Window_PreviewDragOver");
    }

    private void Window_PreviewDrop(object sender, DragEventArgs e)
    {
      NewEvent("Window_PreviewDrop");
    }

    private void Window_PreviewGiveFeedback(object sender, GiveFeedbackEventArgs e)
    {
      NewEvent("Window_PreviewGiveFeedback");
    }

    private void Window_PreviewGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
    {
      NewEvent("Window_PreviewGotKeyboardFocus");
    }

    private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
    {
      NewEvent("Window_PreviewKeyDown");
    }

    private void Window_PreviewKeyUp(object sender, KeyEventArgs e)
    {
      NewEvent("Window_PreviewKeyUp");
    }

    private void Window_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
    {
      NewEvent("Window_PreviewLostKeyboardFocus");
    }

    private void Window_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_PreviewMouseDoubleClick");
    }

    private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_PreviewMouseDown");
    }

    private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_PreviewMouseLeftButtonDown");
    }

    private void Window_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_PreviewMouseLeftButtonUp");
    }

    private void Window_PreviewMouseMove(object sender, MouseEventArgs e)
    {
      NewEvent("Window_PreviewMouseMove");
    }

    private void Window_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_PreviewMouseRightButtonDown");
    }

    private void Window_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_PreviewMouseRightButtonUp");
    }

    private void Window_PreviewMouseUp(object sender, MouseButtonEventArgs e)
    {
      NewEvent("Window_PreviewMouseUp");
    }

    private void Window_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
    {
      NewEvent("Window_PreviewMouseWheel");
    }

    private void Window_PreviewQueryContinueDrag(object sender, QueryContinueDragEventArgs e)
    {
      NewEvent("Window_PreviewQueryContinueDrag");
    }

    private void Window_PreviewStylusButtonDown(object sender, StylusButtonEventArgs e)
    {
      NewEvent("Window_PreviewStylusButtonDown");
    }

    private void Window_PreviewStylusButtonUp(object sender, StylusButtonEventArgs e)
    {
      NewEvent("Window_PreviewStylusButtonUp");
    }

    private void Window_PreviewStylusDown(object sender, StylusDownEventArgs e)
    {
      NewEvent("Window_PreviewStylusDown");
    }

    private void Window_PreviewStylusInAirMove(object sender, StylusEventArgs e)
    {
      NewEvent("Window_PreviewStylusInAirMove");
    }

    private void Window_PreviewStylusInRange(object sender, StylusEventArgs e)
    {
      NewEvent("Window_PreviewStylusInRange");
    }

    private void Window_PreviewStylusMove(object sender, StylusEventArgs e)
    {
      NewEvent("Window_PreviewStylusMove");
    }

    private void Window_PreviewStylusOutOfRange(object sender, StylusEventArgs e)
    {
      NewEvent("Window_PreviewStylusOutOfRange");
    }

    private void Window_PreviewStylusSystemGesture(object sender, StylusSystemGestureEventArgs e)
    {
      NewEvent("Window_PreviewStylusSystemGesture");
    }

    private void Window_PreviewStylusUp(object sender, StylusEventArgs e)
    {
      NewEvent("Window_PreviewStylusUp");
    }

    private void Window_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
      NewEvent("Window_PreviewTextInput");
    }

    private void Window_PreviewTouchDown(object sender, TouchEventArgs e)
    {
      NewEvent("Window_PreviewTouchDown");
    }

    private void Window_PreviewTouchMove(object sender, TouchEventArgs e)
    {
      NewEvent("Window_PreviewTouchMove");
    }

    private void Window_PreviewTouchUp(object sender, TouchEventArgs e)
    {
      NewEvent("Window_PreviewTouchUp");
    }

    private void Window_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
    {
      NewEvent("Window_QueryContinueDrag");
    }

    private void Window_QueryCursor(object sender, QueryCursorEventArgs e)
    {
      NewEvent("Window_QueryCursor");
    }

    private void Window_RequestBringIntoView(object sender, RequestBringIntoViewEventArgs e)
    {
      NewEvent("Window_RequestBringIntoView");
    }

    private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
    {
      NewEvent("Window_SizeChanged");
    }

    private void Window_SourceInitialized(object sender, EventArgs e)
    {
      NewEvent("Window_SourceInitialized");
    }

    private void Window_SourceUpdated(object sender, DataTransferEventArgs e)
    {
      NewEvent("Window_SourceUpdated");
    }

    private void Window_StateChanged(object sender, EventArgs e)
    {
      NewEvent("Window_StateChanged");
    }

    private void Window_StylusButtonDown(object sender, StylusButtonEventArgs e)
    {
      NewEvent("Window_StylusButtonDown");
    }

    private void Window_StylusButtonUp(object sender, StylusButtonEventArgs e)
    {
      NewEvent("Window_StylusButtonUp");
    }

    private void Window_StylusDown(object sender, StylusDownEventArgs e)
    {
      NewEvent("Window_StylusDown");
    }

    private void Window_StylusEnter(object sender, StylusEventArgs e)
    {
      NewEvent("Window_StylusEnter");
    }

    private void Window_StylusInAirMove(object sender, StylusEventArgs e)
    {
      NewEvent("Window_StylusInAirMove");
    }

    private void Window_StylusInRange(object sender, StylusEventArgs e)
    {
      NewEvent("Window_StylusInRange");
    }

    private void Window_StylusLeave(object sender, StylusEventArgs e)
    {
      NewEvent("Window_StylusLeave");
    }

    private void Window_StylusMove(object sender, StylusEventArgs e)
    {
      NewEvent("Window_StylusMove");
    }

    private void Window_StylusOutOfRange(object sender, StylusEventArgs e)
    {
      NewEvent("Window_StylusOutOfRange");
    }

    private void Window_StylusSystemGesture(object sender, StylusSystemGestureEventArgs e)
    {
      NewEvent("Window_StylusSystemGesture");
    }

    private void Window_StylusUp(object sender, StylusEventArgs e)
    {
      NewEvent("Window_StylusUp");
    }

    private void Window_TargetUpdated(object sender, DataTransferEventArgs e)
    {
      NewEvent("Window_TargetUpdated");
    }

    private void Window_TextInput(object sender, TextCompositionEventArgs e)
    {
      NewEvent("Window_TextInput");
    }

    private void Window_ToolTipClosing(object sender, ToolTipEventArgs e)
    {
      NewEvent("Window_ToolTipClosing");
    }

    private void Window_ToolTipOpening(object sender, ToolTipEventArgs e)
    {
      NewEvent("Window_ToolTipOpening");
    }

    private void Window_TouchDown(object sender, TouchEventArgs e)
    {
      NewEvent("Window_TouchDown");
    }

    private void Window_TouchEnter(object sender, TouchEventArgs e)
    {
      NewEvent("Window_TouchEnter");
    }

    private void Window_TouchLeave(object sender, TouchEventArgs e)
    {
      NewEvent("Window_TouchLeave");
    }

    private void Window_TouchMove(object sender, TouchEventArgs e)
    {
      NewEvent("Window_TouchMove");
    }

    private void Window_TouchUp(object sender, TouchEventArgs e)
    {
      NewEvent("Window_TouchUp");
    }

    private void Window_Unloaded(object sender, RoutedEventArgs e)
    {
      NewEvent("Window_Unloaded");
    }
  }
}
