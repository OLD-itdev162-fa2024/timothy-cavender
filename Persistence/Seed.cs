using Domain;
using Persistence.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elit at imperdiet dui accumsan sit amet nulla. Eget sit amet tellus cras adipiscing enim eu turpis. Viverra maecenas accumsan lacus vel. Arcu bibendum at varius vel. Eget velit aliquet sagittis id consectetur purus ut. Tortor vitae purus faucibus ornare suspendisse sed nisi lacus sed. Purus in mollis nunc sed id semper risus in. Felis imperdiet proin fermentum leo vel orci. At urna condimentum mattis pellentesque id nibh tortor id aliquet. Cras ornare arcu dui vivamus arcu felis bibendum ut tristique. Turpis nunc eget lorem dolor sed viverra. Tristique senectus et netus et malesuada fames ac. Scelerisque purus semper eget duis at tellus at urna condimentum. Tempus imperdiet nulla malesuada pellentesque elit eget gravida. Mauris rhoncus aenean vel elit scelerisque mauris. Faucibus interdum posuere lorem ipsum dolor. Pulvinar etiam non quam lacus.",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Second Post",
                        Body = "Nulla facilisi etiam dignissim diam quis enim lobortis scelerisque. Ultrices vitae auctor eu augue ut lectus arcu. Et ligula ullamcorper malesuada proin libero nunc consequat interdum. Tincidunt lobortis feugiat vivamus at augue. Lorem sed risus ultricies tristique. Congue eu consequat ac felis donec et odio pellentesque diam. Quam viverra orci sagittis eu volutpat. Morbi tincidunt augue interdum velit euismod in pellentesque massa placerat. Tincidunt eget nullam non nisi est. Sit amet nisl suscipit adipiscing. Eget felis eget nunc lobortis mattis aliquam. Proin libero nunc consequat interdum varius sit amet mattis vulputate. Vitae et leo duis ut diam quam nulla porttitor massa. Tincidunt nunc pulvinar sapien et ligula ullamcorper malesuada proin libero. Felis donec et odio pellentesque diam volutpat commodo sed egestas. Dui ut ornare lectus sit amet est placerat. Eu volutpat odio facilisis mauris sit amet massa vitae. Sit amet massa vitae tortor condimentum lacinia. Dui accumsan sit amet nulla facilisi morbi tempus. Condimentum lacinia quis vel eros.",
                        Date = DateTime.Now.AddDays(-7)
                    },
                    new Post {
                        Title = "Third Post",
                        Body = "Sed libero enim sed faucibus turpis. Aenean vel elit scelerisque mauris pellentesque pulvinar pellentesque. Consectetur lorem donec massa sapien faucibus et molestie ac feugiat. Tristique risus nec feugiat in fermentum posuere. Elementum curabitur vitae nunc sed. Orci dapibus ultrices in iaculis nunc sed augue lacus. Sollicitudin nibh sit amet commodo. Tortor at auctor urna nunc id cursus metus aliquam. Congue mauris rhoncus aenean vel elit scelerisque. Sollicitudin ac orci phasellus egestas tellus. Ultrices dui sapien eget mi proin sed libero enim sed. Bibendum ut tristique et egestas quis ipsum. Pharetra magna ac placerat vestibulum lectus. Varius duis at consectetur lorem donec massa. Varius vel pharetra vel turpis.",
                        Date = DateTime.Now.AddDays(-4)
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}