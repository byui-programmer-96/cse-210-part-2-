namespace Namespace {
    
    using constants;
    
    using Cast = game.casting.cast.Cast;
    
    using Food = game.casting.food.Food;
    
    using Label = game.casting.label.Label;
    
    using Cycle = game.casting.cycle.Cycle;
    
    using Cycle2 = game.casting.cycle2.Cycle2;
    
    using Script = game.scripting.script.Script;
    
    using ControlActorsAction = game.scripting.control_actors_action.ControlActorsAction;
    
    using MoveActorsAction = game.scripting.move_actors_action.MoveActorsAction;
    
    using HandleCollisionsAction = game.scripting.handle_collisions_action.HandleCollisionsAction;
    
    using DrawActorsAction = game.scripting.draw_actors_action.DrawActorsAction;
    
    using Director = game.directing.director.Director;
    
    using KeyboardService = game.services.keyboard_service.KeyboardService;
    
    using VideoService = game.services.video_service.VideoService;
    
    using Color = game.shared.color.Color;
    
    using Point = game.shared.point.Point;
    
    public static class Module {
        
        public static object main() {
            // create the cast
            var cast = Cast();
            cast.add_actor("cycles", Cycle());
            cast.add_actor("cycles", Cycle2());
            cast.add_actor("labels", Label("Player ONE", constants.RED, Point(120, 0)));
            cast.add_actor("labels", Label("Player TWO", constants.GREEN, Point(constants.MAX_X - 196, 0)));
            // start the game
            var keyboard_service = KeyboardService();
            var video_service = VideoService();
            var script = Script();
            script.add_action("input", ControlActorsAction(keyboard_service));
            script.add_action("update", MoveActorsAction());
            script.add_action("update", HandleCollisionsAction());
            script.add_action("output", DrawActorsAction(video_service));
            var director = Director(video_service);
            director.start_game(cast, script);
        }
        
        static Module() {
            main();
        }
    }
}
